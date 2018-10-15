using System;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace M3u_to_folder
{
    public partial class Principal : Form
    {
        private M3uManager manager = null;
        private long size = 0;
        private bool enable_check = false;

        public Principal()
        {
            InitializeComponent();
        }

        private void BTN_m3u_Click(object sender, EventArgs e)
        {
            LBOX_mp3.Items.Clear();
            TXT_m3u.Text = string.Empty;
            OpenList.FileName = string.Empty;
            size = 0;
            enable_check = false;

            if (OpenList.ShowDialog() == DialogResult.OK)
            {
                manager = new M3uManager(OpenList.FileName);
                StringDictionary list = manager.List;

                if (list != null)
                {
                    TXT_m3u.Text = OpenList.FileName;

                    foreach (string title in list.Keys)
                    {
                        LBOX_mp3.Items.Add(title, true);
                        size = size + manager.Get_File_size(title);
                    }
                    enable_check = true;
                    Lbl_Size2.Text = size.ToString();
                    LbL_TotalFiles.Text = list.Count.ToString();
                }
                else
                {
                    MessageBox.Show("There is a problem with this list");
                    OpenList.FileName = string.Empty;
                }
            }
        }

        private void BTN_Folder_Click(object sender, EventArgs e)
        {
            OpenFolder.SelectedPath = string.Empty;
            TXT_Folder.Text = string.Empty;
            if (OpenFolder.ShowDialog() == DialogResult.OK)
            {
                TXT_Folder.Text = OpenFolder.SelectedPath;
            }

        }

        private void BTN_ok_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(OpenList.FileName)) && (!String.IsNullOrEmpty(OpenFolder.SelectedPath)))
            {
                Progress p = new Progress(manager, OpenFolder.SelectedPath, LBOX_mp3);
                p.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must select a M3U List and Target folder");
            }
        }

        private void LBOX_mp3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (enable_check)
            {
                string title = LBOX_mp3.GetItemText(LBOX_mp3.Items[e.Index]);

                if (e.CurrentValue == CheckState.Checked)
                {
                    size = size + manager.Get_File_size(title);
                }
                else if (e.CurrentValue == CheckState.Unchecked)
                {
                    size = size - manager.Get_File_size(title);
                }

                Lbl_Size2.Text = size.ToString();
            }


        }

    }
}