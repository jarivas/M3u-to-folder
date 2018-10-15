using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace M3u_to_folder
{
    public partial class Progress : Form
    {
        private M3uData msg;

        public Progress(M3uManager m, string f, CheckedListBox clb)
        {
            InitializeComponent();
            msg = new M3uData(m, f, clb);
        }


        private void Progress_Load(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync(msg);
        }

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (BGWorker.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                M3uData msg = e.Argument as M3uData;
                for (int i = 0; i < msg.listbox.CheckedItems.Count; i++)
                {
                    if (!msg.mngr.Copy_File(msg.listbox.CheckedItems[i].ToString(), msg.folder))
                    {
                        BGWorker.CancelAsync();
                    }

                    int percentComplete = (int)((i + 1) * 100) / msg.listbox.CheckedItems.Count;
                    BGWorker.ReportProgress(percentComplete);
                }

            }
        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Operation cancelled by an error", "Error");
            }
            else
            {
                MessageBox.Show("The files were copied", "Finish");
            }
            this.Close();
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PBar_Load.Value = e.ProgressPercentage;            
        }

    }
}