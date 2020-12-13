namespace Renamer
{
    partial class Mainform
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_WriteNumber = new System.Windows.Forms.Button();
            this.btn_NummerComma = new System.Windows.Forms.Button();
            this.btn_SetNumber = new System.Windows.Forms.Button();
            this.btn_GroupDel = new System.Windows.Forms.Button();
            this.btn_PositionDel = new System.Windows.Forms.Button();
            this.btn_ClearName = new System.Windows.Forms.Button();
            this.btn_BackAdd = new System.Windows.Forms.Button();
            this.btn_FrontAdd = new System.Windows.Forms.Button();
            this.btn_Replace = new System.Windows.Forms.Button();
            this.btn_Datetime = new System.Windows.Forms.Button();
            this.btn_ChangeCancel = new System.Windows.Forms.Button();
            this.btn_ChangeName = new System.Windows.Forms.Button();
            this.Listview1 = new System.Windows.Forms.ListView();
            this.cH_chngName = new System.Windows.Forms.ColumnHeader();
            this.cH_RawName = new System.Windows.Forms.ColumnHeader();
            this.cH_oldPath = new System.Windows.Forms.ColumnHeader();
            this.ch_newPath = new System.Windows.Forms.ColumnHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ExtChng = new System.Windows.Forms.Button();
            this.btn_ExtAdd = new System.Windows.Forms.Button();
            this.btn_ExtDel = new System.Windows.Forms.Button();
            this.btn_AddPath = new System.Windows.Forms.Button();
            this.btn_PathFolder = new System.Windows.Forms.Button();
            this.btn_SelfName = new System.Windows.Forms.Button();
            this.btn_ClearItem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btn_WriteNumber);
            this.panel1.Controls.Add(this.btn_NummerComma);
            this.panel1.Controls.Add(this.btn_SetNumber);
            this.panel1.Controls.Add(this.btn_GroupDel);
            this.panel1.Controls.Add(this.btn_PositionDel);
            this.panel1.Controls.Add(this.btn_ClearName);
            this.panel1.Controls.Add(this.btn_BackAdd);
            this.panel1.Controls.Add(this.btn_FrontAdd);
            this.panel1.Controls.Add(this.btn_Replace);
            this.panel1.Controls.Add(this.btn_Datetime);
            this.panel1.Controls.Add(this.btn_ChangeCancel);
            this.panel1.Controls.Add(this.btn_ChangeName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 541);
            this.panel1.TabIndex = 0;
            // 
            // btn_WriteNumber
            // 
            this.btn_WriteNumber.FlatAppearance.BorderSize = 0;
            this.btn_WriteNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WriteNumber.Location = new System.Drawing.Point(0, 440);
            this.btn_WriteNumber.Margin = new System.Windows.Forms.Padding(0);
            this.btn_WriteNumber.Name = "btn_WriteNumber";
            this.btn_WriteNumber.Size = new System.Drawing.Size(60, 40);
            this.btn_WriteNumber.TabIndex = 10;
            this.btn_WriteNumber.Text = "번호\r\n붙이기";
            this.btn_WriteNumber.UseVisualStyleBackColor = true;
            this.btn_WriteNumber.Click += new System.EventHandler(this.btn_WriteNumber_Click);
            // 
            // btn_NummerComma
            // 
            this.btn_NummerComma.FlatAppearance.BorderSize = 0;
            this.btn_NummerComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NummerComma.Location = new System.Drawing.Point(0, 400);
            this.btn_NummerComma.Margin = new System.Windows.Forms.Padding(0);
            this.btn_NummerComma.Name = "btn_NummerComma";
            this.btn_NummerComma.Size = new System.Drawing.Size(60, 40);
            this.btn_NummerComma.TabIndex = 9;
            this.btn_NummerComma.Text = "자리수\r\n맞추기";
            this.btn_NummerComma.UseVisualStyleBackColor = true;
            this.btn_NummerComma.Click += new System.EventHandler(this.btn_NummerComma_Click);
            // 
            // btn_SetNumber
            // 
            this.btn_SetNumber.FlatAppearance.BorderSize = 0;
            this.btn_SetNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SetNumber.Location = new System.Drawing.Point(0, 360);
            this.btn_SetNumber.Margin = new System.Windows.Forms.Padding(0);
            this.btn_SetNumber.Name = "btn_SetNumber";
            this.btn_SetNumber.Size = new System.Drawing.Size(60, 40);
            this.btn_SetNumber.TabIndex = 8;
            this.btn_SetNumber.Text = "숫자만\r\n남기기";
            this.btn_SetNumber.UseVisualStyleBackColor = true;
            this.btn_SetNumber.Click += new System.EventHandler(this.btn_SetNumber_Click);
            // 
            // btn_GroupDel
            // 
            this.btn_GroupDel.FlatAppearance.BorderSize = 0;
            this.btn_GroupDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GroupDel.Location = new System.Drawing.Point(0, 320);
            this.btn_GroupDel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_GroupDel.Name = "btn_GroupDel";
            this.btn_GroupDel.Size = new System.Drawing.Size(60, 40);
            this.btn_GroupDel.TabIndex = 3;
            this.btn_GroupDel.Text = "묶인곳\r\n지우기";
            this.btn_GroupDel.UseVisualStyleBackColor = true;
            this.btn_GroupDel.Click += new System.EventHandler(this.btn_GroupDel_Click);
            // 
            // btn_PositionDel
            // 
            this.btn_PositionDel.FlatAppearance.BorderSize = 0;
            this.btn_PositionDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PositionDel.Location = new System.Drawing.Point(0, 280);
            this.btn_PositionDel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_PositionDel.Name = "btn_PositionDel";
            this.btn_PositionDel.Size = new System.Drawing.Size(60, 40);
            this.btn_PositionDel.TabIndex = 7;
            this.btn_PositionDel.Text = "위치\r\n지우기";
            this.btn_PositionDel.UseVisualStyleBackColor = true;
            this.btn_PositionDel.Click += new System.EventHandler(this.btn_PositionDel_Click);
            // 
            // btn_ClearName
            // 
            this.btn_ClearName.FlatAppearance.BorderSize = 0;
            this.btn_ClearName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearName.Location = new System.Drawing.Point(0, 240);
            this.btn_ClearName.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ClearName.Name = "btn_ClearName";
            this.btn_ClearName.Size = new System.Drawing.Size(60, 40);
            this.btn_ClearName.TabIndex = 6;
            this.btn_ClearName.Text = "파일명\r\n지우기";
            this.btn_ClearName.UseVisualStyleBackColor = true;
            this.btn_ClearName.Click += new System.EventHandler(this.btn_ClearName_Click);
            // 
            // btn_BackAdd
            // 
            this.btn_BackAdd.FlatAppearance.BorderSize = 0;
            this.btn_BackAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BackAdd.Location = new System.Drawing.Point(0, 200);
            this.btn_BackAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btn_BackAdd.Name = "btn_BackAdd";
            this.btn_BackAdd.Size = new System.Drawing.Size(60, 40);
            this.btn_BackAdd.TabIndex = 5;
            this.btn_BackAdd.Text = "뒷이름\r\n붙이기";
            this.btn_BackAdd.UseVisualStyleBackColor = true;
            this.btn_BackAdd.Click += new System.EventHandler(this.btn_BackAdd_Click);
            // 
            // btn_FrontAdd
            // 
            this.btn_FrontAdd.FlatAppearance.BorderSize = 0;
            this.btn_FrontAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FrontAdd.Location = new System.Drawing.Point(0, 160);
            this.btn_FrontAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btn_FrontAdd.Name = "btn_FrontAdd";
            this.btn_FrontAdd.Size = new System.Drawing.Size(60, 40);
            this.btn_FrontAdd.TabIndex = 4;
            this.btn_FrontAdd.Text = "앞이름\r\n붙이기";
            this.btn_FrontAdd.UseVisualStyleBackColor = true;
            this.btn_FrontAdd.Click += new System.EventHandler(this.btn_FrontAdd_Click);
            // 
            // btn_Replace
            // 
            this.btn_Replace.FlatAppearance.BorderSize = 0;
            this.btn_Replace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Replace.Location = new System.Drawing.Point(0, 120);
            this.btn_Replace.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Replace.Name = "btn_Replace";
            this.btn_Replace.Size = new System.Drawing.Size(60, 40);
            this.btn_Replace.TabIndex = 3;
            this.btn_Replace.Text = "문자열\r\n바꾸기";
            this.btn_Replace.UseVisualStyleBackColor = true;
            this.btn_Replace.Click += new System.EventHandler(this.btn_Replace_Click);
            // 
            // btn_Datetime
            // 
            this.btn_Datetime.FlatAppearance.BorderSize = 0;
            this.btn_Datetime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Datetime.Location = new System.Drawing.Point(0, 80);
            this.btn_Datetime.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Datetime.Name = "btn_Datetime";
            this.btn_Datetime.Size = new System.Drawing.Size(60, 40);
            this.btn_Datetime.TabIndex = 2;
            this.btn_Datetime.Text = "수정\r\n날짜로";
            this.btn_Datetime.UseVisualStyleBackColor = true;
            this.btn_Datetime.Click += new System.EventHandler(this.btn_Datetime_Click);
            // 
            // btn_ChangeCancel
            // 
            this.btn_ChangeCancel.FlatAppearance.BorderSize = 0;
            this.btn_ChangeCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeCancel.Location = new System.Drawing.Point(0, 40);
            this.btn_ChangeCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ChangeCancel.Name = "btn_ChangeCancel";
            this.btn_ChangeCancel.Size = new System.Drawing.Size(60, 40);
            this.btn_ChangeCancel.TabIndex = 1;
            this.btn_ChangeCancel.Text = "변경\r\n취소";
            this.btn_ChangeCancel.UseVisualStyleBackColor = true;
            this.btn_ChangeCancel.Click += new System.EventHandler(this.btn_ChangeCancel_Click);
            // 
            // btn_ChangeName
            // 
            this.btn_ChangeName.FlatAppearance.BorderSize = 0;
            this.btn_ChangeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeName.Location = new System.Drawing.Point(0, 0);
            this.btn_ChangeName.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ChangeName.Name = "btn_ChangeName";
            this.btn_ChangeName.Size = new System.Drawing.Size(60, 40);
            this.btn_ChangeName.TabIndex = 0;
            this.btn_ChangeName.Text = "변경\r\n적용";
            this.btn_ChangeName.UseVisualStyleBackColor = true;
            this.btn_ChangeName.Click += new System.EventHandler(this.btn_ChangeName_Click);
            // 
            // Listview1
            // 
            this.Listview1.AllowDrop = true;
            this.Listview1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH_chngName,
            this.cH_RawName,
            this.cH_oldPath,
            this.ch_newPath});
            this.Listview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Listview1.FullRowSelect = true;
            this.Listview1.GridLines = true;
            this.Listview1.Location = new System.Drawing.Point(60, 0);
            this.Listview1.Name = "Listview1";
            this.Listview1.Size = new System.Drawing.Size(926, 541);
            this.Listview1.TabIndex = 1;
            this.Listview1.UseCompatibleStateImageBehavior = false;
            this.Listview1.View = System.Windows.Forms.View.Details;
            this.Listview1.DoubleClick += new System.EventHandler(this.btn_SelfName_Click);
            this.Listview1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.Listview1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.Listview1_ItemSelectionChanged);
            this.Listview1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            this.Listview1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // cH_chngName
            // 
            this.cH_chngName.Text = "변경할 파일명";
            this.cH_chngName.Width = 200;
            // 
            // cH_RawName
            // 
            this.cH_RawName.Text = "원본 파일명";
            this.cH_RawName.Width = 200;
            // 
            // cH_oldPath
            // 
            this.cH_oldPath.Text = "파일경로";
            this.cH_oldPath.Width = 260;
            // 
            // ch_newPath
            // 
            this.ch_newPath.Text = "이동경로";
            this.ch_newPath.Width = 260;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.btn_ExtChng);
            this.panel2.Controls.Add(this.btn_ExtAdd);
            this.panel2.Controls.Add(this.btn_ExtDel);
            this.panel2.Controls.Add(this.btn_AddPath);
            this.panel2.Controls.Add(this.btn_PathFolder);
            this.panel2.Controls.Add(this.btn_SelfName);
            this.panel2.Controls.Add(this.btn_ClearItem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(986, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 541);
            this.panel2.TabIndex = 2;
            // 
            // btn_ExtChng
            // 
            this.btn_ExtChng.FlatAppearance.BorderSize = 0;
            this.btn_ExtChng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExtChng.Location = new System.Drawing.Point(0, 240);
            this.btn_ExtChng.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ExtChng.Name = "btn_ExtChng";
            this.btn_ExtChng.Size = new System.Drawing.Size(60, 40);
            this.btn_ExtChng.TabIndex = 16;
            this.btn_ExtChng.Text = "확장자\r\n변경";
            this.btn_ExtChng.UseVisualStyleBackColor = true;
            this.btn_ExtChng.Click += new System.EventHandler(this.btn_ExtChng_Click);
            // 
            // btn_ExtAdd
            // 
            this.btn_ExtAdd.FlatAppearance.BorderSize = 0;
            this.btn_ExtAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExtAdd.Location = new System.Drawing.Point(0, 200);
            this.btn_ExtAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ExtAdd.Name = "btn_ExtAdd";
            this.btn_ExtAdd.Size = new System.Drawing.Size(60, 40);
            this.btn_ExtAdd.TabIndex = 15;
            this.btn_ExtAdd.Text = "확장자\r\n추가";
            this.btn_ExtAdd.UseVisualStyleBackColor = true;
            this.btn_ExtAdd.Click += new System.EventHandler(this.btn_ExtAdd_Click);
            // 
            // btn_ExtDel
            // 
            this.btn_ExtDel.FlatAppearance.BorderSize = 0;
            this.btn_ExtDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExtDel.Location = new System.Drawing.Point(0, 160);
            this.btn_ExtDel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ExtDel.Name = "btn_ExtDel";
            this.btn_ExtDel.Size = new System.Drawing.Size(60, 40);
            this.btn_ExtDel.TabIndex = 3;
            this.btn_ExtDel.Text = "확장자\r\n삭제";
            this.btn_ExtDel.UseVisualStyleBackColor = true;
            this.btn_ExtDel.Click += new System.EventHandler(this.btn_ExtDel_Click);
            // 
            // btn_AddPath
            // 
            this.btn_AddPath.FlatAppearance.BorderSize = 0;
            this.btn_AddPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddPath.Location = new System.Drawing.Point(0, 120);
            this.btn_AddPath.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddPath.Name = "btn_AddPath";
            this.btn_AddPath.Size = new System.Drawing.Size(60, 40);
            this.btn_AddPath.TabIndex = 14;
            this.btn_AddPath.Text = "경로명\r\n붙이기";
            this.btn_AddPath.UseVisualStyleBackColor = true;
            this.btn_AddPath.Click += new System.EventHandler(this.btn_AddPath_Click);
            // 
            // btn_PathFolder
            // 
            this.btn_PathFolder.FlatAppearance.BorderSize = 0;
            this.btn_PathFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PathFolder.Location = new System.Drawing.Point(0, 80);
            this.btn_PathFolder.Margin = new System.Windows.Forms.Padding(0);
            this.btn_PathFolder.Name = "btn_PathFolder";
            this.btn_PathFolder.Size = new System.Drawing.Size(60, 40);
            this.btn_PathFolder.TabIndex = 13;
            this.btn_PathFolder.Text = "경로\r\n통일";
            this.btn_PathFolder.UseVisualStyleBackColor = true;
            this.btn_PathFolder.Click += new System.EventHandler(this.btn_PathFolder_Click);
            // 
            // btn_SelfName
            // 
            this.btn_SelfName.FlatAppearance.BorderSize = 0;
            this.btn_SelfName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelfName.Location = new System.Drawing.Point(0, 40);
            this.btn_SelfName.Margin = new System.Windows.Forms.Padding(0);
            this.btn_SelfName.Name = "btn_SelfName";
            this.btn_SelfName.Size = new System.Drawing.Size(60, 40);
            this.btn_SelfName.TabIndex = 12;
            this.btn_SelfName.Text = "직접\r\n바꾸기\r\n";
            this.btn_SelfName.UseVisualStyleBackColor = true;
            this.btn_SelfName.Click += new System.EventHandler(this.btn_SelfName_Click);
            // 
            // btn_ClearItem
            // 
            this.btn_ClearItem.FlatAppearance.BorderSize = 0;
            this.btn_ClearItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearItem.Location = new System.Drawing.Point(0, 0);
            this.btn_ClearItem.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ClearItem.Name = "btn_ClearItem";
            this.btn_ClearItem.Size = new System.Drawing.Size(60, 40);
            this.btn_ClearItem.TabIndex = 11;
            this.btn_ClearItem.Text = "목록\r\n지우기";
            this.btn_ClearItem.UseVisualStyleBackColor = true;
            this.btn_ClearItem.Click += new System.EventHandler(this.btn_ClearItem_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 541);
            this.Controls.Add(this.Listview1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainform";
            this.Text = "Renamer v0.97 - by motolies";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader cH_chngName;
        private System.Windows.Forms.ColumnHeader cH_RawName;
        private System.Windows.Forms.ColumnHeader cH_oldPath;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ListView Listview1;
        private System.Windows.Forms.ColumnHeader ch_newPath;
        private System.Windows.Forms.Button btn_SetNumber;
        private System.Windows.Forms.Button btn_GroupDel;
        private System.Windows.Forms.Button btn_PositionDel;
        private System.Windows.Forms.Button btn_ClearName;
        private System.Windows.Forms.Button btn_BackAdd;
        private System.Windows.Forms.Button btn_FrontAdd;
        private System.Windows.Forms.Button btn_Replace;
        private System.Windows.Forms.Button btn_Datetime;
        private System.Windows.Forms.Button btn_ChangeCancel;
        private System.Windows.Forms.Button btn_ChangeName;
        private System.Windows.Forms.Button btn_WriteNumber;
        private System.Windows.Forms.Button btn_NummerComma;
        private System.Windows.Forms.Button btn_ExtChng;
        private System.Windows.Forms.Button btn_ExtAdd;
        private System.Windows.Forms.Button btn_ExtDel;
        private System.Windows.Forms.Button btn_AddPath;
        private System.Windows.Forms.Button btn_PathFolder;
        private System.Windows.Forms.Button btn_SelfName;
        private System.Windows.Forms.Button btn_ClearItem;
    }
}

