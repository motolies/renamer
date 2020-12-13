namespace Renamer
{
    partial class WriteNumber
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_StartNumber = new System.Windows.Forms.TextBox();
            this.tb_NumberComma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "시작값";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "자리수";
            // 
            // tb_StartNumber
            // 
            this.tb_StartNumber.Location = new System.Drawing.Point(14, 51);
            this.tb_StartNumber.Name = "tb_StartNumber";
            this.tb_StartNumber.Size = new System.Drawing.Size(220, 21);
            this.tb_StartNumber.TabIndex = 2;
            this.tb_StartNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_StartNumber_KeyDown);
            // 
            // tb_NumberComma
            // 
            this.tb_NumberComma.Location = new System.Drawing.Point(14, 24);
            this.tb_NumberComma.Name = "tb_NumberComma";
            this.tb_NumberComma.Size = new System.Drawing.Size(220, 21);
            this.tb_NumberComma.TabIndex = 1;
            this.tb_NumberComma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_NumberComma_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "붙일 숫자의 자리수와 시작값을 지정합니다.";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "이름 뒤에 번호붙임",
            "이름 앞에 번호붙임"});
            this.comboBox.Location = new System.Drawing.Point(14, 84);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(138, 20);
            this.comboBox.TabIndex = 3;
            this.comboBox.Text = "이름 뒤에 번호붙임";
            // 
            // btn_OK
            // 
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Location = new System.Drawing.Point(158, 78);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(54, 30);
            this.btn_OK.TabIndex = 19;
            this.btn_OK.Text = "확인";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Location = new System.Drawing.Point(218, 78);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(54, 30);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Text = "취소";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // WriteNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 113);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_StartNumber);
            this.Controls.Add(this.tb_NumberComma);
            this.Controls.Add(this.label1);
            this.Name = "WriteNumber";
            this.Text = "WriteNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_StartNumber;
        private System.Windows.Forms.TextBox tb_NumberComma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
    }
}