namespace M3u_to_folder
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.OpenList = new System.Windows.Forms.OpenFileDialog();
            this.TXT_m3u = new System.Windows.Forms.TextBox();
            this.BTN_m3u = new System.Windows.Forms.Button();
            this.LBOX_mp3 = new System.Windows.Forms.CheckedListBox();
            this.TXT_Folder = new System.Windows.Forms.TextBox();
            this.BTN_Folder = new System.Windows.Forms.Button();
            this.BTN_ok = new System.Windows.Forms.Button();
            this.OpenFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.Lbl_Size1 = new System.Windows.Forms.Label();
            this.Lbl_Size2 = new System.Windows.Forms.Label();
            this.Panel_Select = new System.Windows.Forms.Panel();
            this.LbL_TotalFiles = new System.Windows.Forms.Label();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Panel_List = new System.Windows.Forms.Panel();
            this.Panel_Select.SuspendLayout();
            this.Panel_List.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenList
            // 
            this.OpenList.Filter = "MP3 List| *.m3u|MP3 List Unicode | *.m3u8";
            // 
            // TXT_m3u
            // 
            this.TXT_m3u.Location = new System.Drawing.Point(23, 23);
            this.TXT_m3u.Name = "TXT_m3u";
            this.TXT_m3u.Size = new System.Drawing.Size(184, 20);
            this.TXT_m3u.TabIndex = 0;
            this.TXT_m3u.TabStop = false;
            // 
            // BTN_m3u
            // 
            this.BTN_m3u.Location = new System.Drawing.Point(231, 19);
            this.BTN_m3u.Name = "BTN_m3u";
            this.BTN_m3u.Size = new System.Drawing.Size(86, 23);
            this.BTN_m3u.TabIndex = 0;
            this.BTN_m3u.Text = "Select m3u";
            this.BTN_m3u.UseVisualStyleBackColor = true;
            this.BTN_m3u.Click += new System.EventHandler(this.BTN_m3u_Click);
            // 
            // LBOX_mp3
            // 
            this.LBOX_mp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBOX_mp3.HorizontalScrollbar = true;
            this.LBOX_mp3.Location = new System.Drawing.Point(0, 0);
            this.LBOX_mp3.Name = "LBOX_mp3";
            this.LBOX_mp3.Size = new System.Drawing.Size(754, 469);
            this.LBOX_mp3.TabIndex = 2;
            this.LBOX_mp3.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.LBOX_mp3_ItemCheck);
            // 
            // TXT_Folder
            // 
            this.TXT_Folder.Location = new System.Drawing.Point(23, 59);
            this.TXT_Folder.Name = "TXT_Folder";
            this.TXT_Folder.Size = new System.Drawing.Size(184, 20);
            this.TXT_Folder.TabIndex = 3;
            this.TXT_Folder.TabStop = false;
            // 
            // BTN_Folder
            // 
            this.BTN_Folder.Location = new System.Drawing.Point(231, 57);
            this.BTN_Folder.Name = "BTN_Folder";
            this.BTN_Folder.Size = new System.Drawing.Size(86, 23);
            this.BTN_Folder.TabIndex = 1;
            this.BTN_Folder.Text = "Select Target";
            this.BTN_Folder.UseVisualStyleBackColor = true;
            this.BTN_Folder.Click += new System.EventHandler(this.BTN_Folder_Click);
            // 
            // BTN_ok
            // 
            this.BTN_ok.Location = new System.Drawing.Point(231, 95);
            this.BTN_ok.Name = "BTN_ok";
            this.BTN_ok.Size = new System.Drawing.Size(86, 23);
            this.BTN_ok.TabIndex = 2;
            this.BTN_ok.Text = "Go!";
            this.BTN_ok.UseVisualStyleBackColor = true;
            this.BTN_ok.Click += new System.EventHandler(this.BTN_ok_Click);
            // 
            // Lbl_Size1
            // 
            this.Lbl_Size1.AutoSize = true;
            this.Lbl_Size1.Location = new System.Drawing.Point(346, 26);
            this.Lbl_Size1.Name = "Lbl_Size1";
            this.Lbl_Size1.Size = new System.Drawing.Size(55, 13);
            this.Lbl_Size1.TabIndex = 6;
            this.Lbl_Size1.Text = "Size (MB):";
            // 
            // Lbl_Size2
            // 
            this.Lbl_Size2.AutoSize = true;
            this.Lbl_Size2.Location = new System.Drawing.Point(422, 27);
            this.Lbl_Size2.Name = "Lbl_Size2";
            this.Lbl_Size2.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Size2.TabIndex = 7;
            this.Lbl_Size2.Text = "0";
            // 
            // Panel_Select
            // 
            this.Panel_Select.Controls.Add(this.LbL_TotalFiles);
            this.Panel_Select.Controls.Add(this.Lbl_Total);
            this.Panel_Select.Controls.Add(this.BTN_Folder);
            this.Panel_Select.Controls.Add(this.TXT_Folder);
            this.Panel_Select.Controls.Add(this.BTN_m3u);
            this.Panel_Select.Controls.Add(this.BTN_ok);
            this.Panel_Select.Controls.Add(this.TXT_m3u);
            this.Panel_Select.Controls.Add(this.Lbl_Size2);
            this.Panel_Select.Controls.Add(this.Lbl_Size1);
            this.Panel_Select.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Select.Location = new System.Drawing.Point(0, 0);
            this.Panel_Select.Name = "Panel_Select";
            this.Panel_Select.Size = new System.Drawing.Size(754, 133);
            this.Panel_Select.TabIndex = 8;
            // 
            // LbL_TotalFiles
            // 
            this.LbL_TotalFiles.AutoSize = true;
            this.LbL_TotalFiles.Location = new System.Drawing.Point(422, 58);
            this.LbL_TotalFiles.Name = "LbL_TotalFiles";
            this.LbL_TotalFiles.Size = new System.Drawing.Size(13, 13);
            this.LbL_TotalFiles.TabIndex = 10;
            this.LbL_TotalFiles.Text = "0";
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Location = new System.Drawing.Point(346, 57);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(58, 13);
            this.Lbl_Total.TabIndex = 9;
            this.Lbl_Total.Text = "Total Files:";
            // 
            // Panel_List
            // 
            this.Panel_List.Controls.Add(this.LBOX_mp3);
            this.Panel_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_List.Location = new System.Drawing.Point(0, 133);
            this.Panel_List.Name = "Panel_List";
            this.Panel_List.Size = new System.Drawing.Size(754, 473);
            this.Panel_List.TabIndex = 9;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 606);
            this.Controls.Add(this.Panel_List);
            this.Controls.Add(this.Panel_Select);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "M3U to Folder";
            this.Panel_Select.ResumeLayout(false);
            this.Panel_Select.PerformLayout();
            this.Panel_List.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenList;
        private System.Windows.Forms.TextBox TXT_m3u;
        private System.Windows.Forms.Button BTN_m3u;
        private System.Windows.Forms.CheckedListBox LBOX_mp3;
        private System.Windows.Forms.TextBox TXT_Folder;
        private System.Windows.Forms.Button BTN_Folder;
        private System.Windows.Forms.Button BTN_ok;
        private System.Windows.Forms.FolderBrowserDialog OpenFolder;
        private System.Windows.Forms.Label Lbl_Size1;
        private System.Windows.Forms.Label Lbl_Size2;
        private System.Windows.Forms.Panel Panel_Select;
        private System.Windows.Forms.Panel Panel_List;
        private System.Windows.Forms.Label LbL_TotalFiles;
        private System.Windows.Forms.Label Lbl_Total;
    }
}

