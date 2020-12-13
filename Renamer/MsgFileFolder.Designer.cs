namespace Renamer
{
    partial class MsgFileFolder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chb_Continue = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Folder = new System.Windows.Forms.Button();
            this.btn_File = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chb_Continue
            // 
            this.chb_Continue.AutoSize = true;
            this.chb_Continue.Location = new System.Drawing.Point(12, 67);
            this.chb_Continue.Name = "chb_Continue";
            this.chb_Continue.Size = new System.Drawing.Size(100, 16);
            this.chb_Continue.TabIndex = 10;
            this.chb_Continue.Text = "같은 작업수행";
            this.chb_Continue.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "선택한 개체중에 폴더가 있습니다. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "파일을 선택하시겠습니까?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "폴더을 선택하시겠습니까?";
            // 
            // btn_Folder
            // 
            this.btn_Folder.FlatAppearance.BorderSize = 0;
            this.btn_Folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Folder.Location = new System.Drawing.Point(166, 59);
            this.btn_Folder.Name = "btn_Folder";
            this.btn_Folder.Size = new System.Drawing.Size(54, 30);
            this.btn_Folder.TabIndex = 30;
            this.btn_Folder.Text = "폴더";
            this.btn_Folder.UseVisualStyleBackColor = true;
            this.btn_Folder.Click += new System.EventHandler(this.btn_Folder_ButtonClick);
            // 
            // btn_File
            // 
            this.btn_File.FlatAppearance.BorderSize = 0;
            this.btn_File.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_File.Location = new System.Drawing.Point(107, 59);
            this.btn_File.Name = "btn_File";
            this.btn_File.Size = new System.Drawing.Size(54, 30);
            this.btn_File.TabIndex = 29;
            this.btn_File.Text = "파일";
            this.btn_File.UseVisualStyleBackColor = true;
            this.btn_File.Click += new System.EventHandler(this.btn_File_ButtonClick);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Location = new System.Drawing.Point(225, 59);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(54, 30);
            this.btn_Cancel.TabIndex = 31;
            this.btn_Cancel.Text = "취소";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_ButtonClick);
            // 
            // MsgFileFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 95);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Folder);
            this.Controls.Add(this.btn_File);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chb_Continue);
            this.Name = "MsgFileFolder";
            this.Text = "Select File or Folder";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MsgFileFolder_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chb_Continue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Folder;
        private System.Windows.Forms.Button btn_File;
        private System.Windows.Forms.Button btn_Cancel;

    }
}