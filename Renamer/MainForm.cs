using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Renamer
{
    public partial class Mainform : Form
    {

        public Mainform()
        {
            InitializeComponent();
            FormSpec.Init(this);
            this.ShowIcon = true;
        }

        internal const string PredefinedTimeFormat = "yyyy-MM-dd HH.mm.ss";
        public string mfReturn = string.Empty;
        public string mfChecked = string.Empty;


        private void Mainform_Load(object sender, EventArgs e)
        {

            btn_disable();
           
            

        }



        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            // DELETE Key 를 누를때 삭제하도록
            if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem item in Listview1.Items)
                {
                    if (item.Selected)
                    {
                        Listview1.Items.Remove(item);


                    }
                }
                if (Listview1.Items.Count == 0)
                    btn_disable();

            }
            // CTRL + A 할때 모두 선택하도록
            else if (e.KeyCode == Keys.A && e.Control)
            {
                foreach (ListViewItem item in Listview1.Items)
                {
                    item.Selected = true;

                }
            }
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);

                // 데이터 중복검사
                for (int y = 0; y < s.Length; y++)
                {

                    for (int i = 0; i < Listview1.Items.Count; i++)
                    {
                        string item = Listview1.Items[i].SubItems[2].Text + "\\" + Listview1.Items[i].SubItems[1].Text;

                        if (s[y] == item)
                            s[y] = string.Empty;
                    }
                }

                mfChecked = string.Empty;

                //리스트뷰에 아이템 넣기
                for (int i = 0; i < s.Length; i++)
                {
                    string Fname = s[i].ToString();


                    if (s[i] != string.Empty)
                    {
                        FileInfo fi = new FileInfo(Fname);

                        //파일일때
                        if (fi.Exists)
                        {

                            string[] subItems = new string[Listview1.Columns.Count];

                            subItems[0] = Path.GetFileName(Fname);
                            subItems[1] = Path.GetFileName(Fname);
                            subItems[2] = Path.GetDirectoryName(Fname);
                            subItems[3] = Path.GetDirectoryName(Fname);

                            ListViewItem item = new ListViewItem(subItems);
                            Listview1.Items.Add(item);
                        }
                        //폴더일때
                        if (!fi.Exists)
                        {
                            //메세지 폼 띄우기
                            if (mfChecked == "False" || mfChecked == string.Empty)
                            {
                                MsgFileFolder mff = new MsgFileFolder();
                                FormSpec.Init(mff);
                                mff.mf = this;
                                mff.StartPosition = FormStartPosition.CenterParent;
                                mff.ShowDialog();

                                Console.WriteLine(mfChecked);
                                Console.WriteLine(mfReturn);
                            }

                            //연속대답 체크시
                            if (mfChecked == "True")
                            {
                                //폴더를 넣었는데 파일을 넣을 때
                                if (mfReturn == "file")
                                {
                                    string[] files = Directory.GetFiles(Fname);

                                    foreach (string _Fname in files)
                                    {
                                        string[] subItems = new string[Listview1.Columns.Count];

                                        subItems[0] = Path.GetFileName(_Fname);
                                        subItems[1] = Path.GetFileName(_Fname);
                                        subItems[2] = Path.GetDirectoryName(_Fname);
                                        subItems[3] = Path.GetDirectoryName(_Fname);

                                        ListViewItem item = new ListViewItem(subItems);
                                        Listview1.Items.Add(item);
                                    }


                                }
                                //폴더를 넣을 때
                                else if (mfReturn == "folder")
                                {
                                    string[] subItems = new string[Listview1.Columns.Count];

                                    subItems[0] = Path.GetFileName(Fname);
                                    subItems[1] = Path.GetFileName(Fname);
                                    subItems[2] = Path.GetDirectoryName(Fname);
                                    subItems[3] = Path.GetDirectoryName(Fname);

                                    ListViewItem item = new ListViewItem(subItems);
                                    Listview1.Items.Add(item);

                                }
                                // 취소
                                else
                                {
                                    break;
                                }
                            }
                            //연속대답 미체크시
                            else if (mfChecked == "False")
                            {
                                if (mfReturn == "file")
                                {
                                    string[] files = Directory.GetFiles(Fname);

                                    foreach (string _Fname in files)
                                    {
                                        string[] subItems = new string[Listview1.Columns.Count];

                                        subItems[0] = Path.GetFileName(_Fname);
                                        subItems[1] = Path.GetFileName(_Fname);
                                        subItems[2] = Path.GetDirectoryName(_Fname);
                                        subItems[3] = Path.GetDirectoryName(_Fname);

                                        ListViewItem item = new ListViewItem(subItems);
                                        Listview1.Items.Add(item);
                                    }


                                }
                                //폴더를 넣을 때
                                else if (mfReturn == "folder")
                                {
                                    string[] subItems = new string[Listview1.Columns.Count];

                                    subItems[0] = Path.GetFileName(Fname);
                                    subItems[1] = Path.GetFileName(Fname);
                                    subItems[2] = Path.GetDirectoryName(Fname);
                                    subItems[3] = Path.GetDirectoryName(Fname);

                                    ListViewItem item = new ListViewItem(subItems);
                                    Listview1.Items.Add(item);

                                }
                                // 취소
                                else
                                {

                                }
                            }
                        }
                    }
                }
                //리스트뷰에 한줄마다 색칠하기
                SetAlternatingRowColors(Listview1, Color.FromArgb(255, 255, 255), Color.FromArgb(232, 242, 255));

                if (Listview1.Items.Count > 0)
                {
                    btn_enable();
                    btn_SelfName.Enabled = false;
                }

            }
            catch (Exception x)
            {
                Console.WriteLine(x);
            }
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        public void SetAlternatingRowColors(ListView lst, Color color1, Color color2)
        {
            //loop through each ListViewItem in the ListView control 
            foreach (ListViewItem item in lst.Items)
            {
                if ((item.Index % 2) == 0)
                    item.BackColor = color1;
                else
                    item.BackColor = color2;
            }
        }
        

        private void btn_ChangeName_Click(object sender, EventArgs e)
        {
            string _error = string.Empty;
            
            try
            {
                for (int i = 0; i < Listview1.Items.Count; i++)
                {
                    for (int y = 0; y < Listview1.Items.Count; y++)
                    {
                        string alt1 = Listview1.Items[i].SubItems[3].Text + "\\" + Listview1.Items[i].SubItems[0].Text;
                        string alt2 = Listview1.Items[y].SubItems[3].Text + "\\" + Listview1.Items[y].SubItems[0].Text;

                        if (alt1 == alt2 && i != y)
                        {
                            MessageBox.Show("변경할 파일명 중에 중복되는 이름이 있습니다.");
                            return;
                        }

                    }
                }
              



                //변경부분
                for (int i = 0; i < Listview1.Items.Count; i++)
                {
                    _error = Listview1.Items[i].SubItems[2].Text + "\\" + Listview1.Items[i].SubItems[1].Text;
                    FileInfo fi = new FileInfo(_error);

                    //파일일 경우
                    if (fi.Exists)
                    {
                        string oldname = Listview1.Items[i].SubItems[2].Text + "\\" + Listview1.Items[i].SubItems[1].Text;
                        string newname = Listview1.Items[i].SubItems[3].Text + "\\" + Listview1.Items[i].SubItems[0].Text;

                        File.Move(oldname, newname);
                    }
                    else//폴더일 경우
                    {
                        string oldname = Listview1.Items[i].SubItems[2].Text + "\\" + Listview1.Items[i].SubItems[1].Text;
                        string newname = Listview1.Items[i].SubItems[3].Text + "\\" + Listview1.Items[i].SubItems[0].Text;

                        Directory.Move(oldname, newname);
                    }

                }

                MessageBox.Show("모두 잘 변경 되었습니다.");
            }
            catch (Exception x)
            {
                MessageBox.Show(_error + "\n" + x.ToString());

            }
        }

        private void btn_ChangeCancel_Click(object sender, EventArgs e)
        {
            string _error = string.Empty;
            try
            {


                //변경부분
                for (int i = 0; i < Listview1.Items.Count; i++)
                {
                    _error = Listview1.Items[i].SubItems[2].Text + "\\" + Listview1.Items[i].SubItems[1].Text;
                    FileInfo fi = new FileInfo(_error);
                    //파일일 경우
                    if (fi.Exists)
                    {
                        string oldname = Listview1.Items[i].SubItems[2].Text + "\\" + Listview1.Items[i].SubItems[1].Text;
                        string newname = Listview1.Items[i].SubItems[3].Text + "\\" + Listview1.Items[i].SubItems[0].Text;

                        File.Move(newname, oldname);
                    }
                    else//폴더일경우
                    {
                        string oldname = Listview1.Items[i].SubItems[2].Text + "\\" + Listview1.Items[i].SubItems[1].Text;
                        string newname = Listview1.Items[i].SubItems[3].Text + "\\" + Listview1.Items[i].SubItems[0].Text;

                        Directory.Move(newname, oldname);
                    }
                }
                MessageBox.Show("모두 잘 복원 되었습니다.");
            }
            catch (Exception x)
            {
                MessageBox.Show(_error + "\n" + x.ToString());
            }
        }

        private void btn_Datetime_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Listview1.Items.Count; i++)
                {
                    string Fname = Listview1.Items[i].SubItems[2].Text + "\\" + Listview1.Items[i].SubItems[1].Text;
                    FileInfo fi = new FileInfo(Fname);
                    Console.WriteLine(Fname);
                    Listview1.Items[i].SubItems[0].Text = fi.LastWriteTime.ToString(PredefinedTimeFormat) + Path.GetExtension(Fname);
                }
            }
            catch
            { }
        }

        private void btn_Replace_Click(object sender, EventArgs e)
        {
            try
            {
                Replace rp = new Replace();
                FormSpec.Init(rp);
                rp.mf = this;
                rp.StartPosition = FormStartPosition.CenterParent;
                rp.ShowDialog();
            }
            catch { }
        }
        private void btn_FrontAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrontAdd fa = new FrontAdd();
                FormSpec.Init(fa);
                fa.mf = this;
                fa.StartPosition = FormStartPosition.CenterParent;
                fa.ShowDialog();
            }
            catch { }
        }
        private void btn_BackAdd_Click(object sender, EventArgs e)
        {
            try
            {
                BackAdd ba = new BackAdd();
                FormSpec.Init(ba);
                ba.mf = this;
                ba.StartPosition = FormStartPosition.CenterParent;
                ba.ShowDialog();
            }
            catch { }
        }
        private void btn_PositionDel_Click(object sender, EventArgs e)
        {
            try
            {
                PositionDel pd = new PositionDel();
                FormSpec.Init(pd);
                pd.mf = this;
                pd.StartPosition = FormStartPosition.CenterParent;
                pd.ShowDialog();
            }
            catch { }
        }
        private void btn_GroupDel_Click(object sender, EventArgs e)
        {
            try
            {

                GroupDel gd = new GroupDel();
                FormSpec.Init(gd);
                gd.mf = this;
                gd.StartPosition = FormStartPosition.CenterParent;
                gd.ShowDialog();

            }
            catch { }
        }
        private void btn_SetNumber_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Listview1.Items.Count; i++)
                {
                    Listview1.Items[i].SubItems[0].Text = Regex.Replace(Path.GetFileNameWithoutExtension(Listview1.Items[i].SubItems[0].Text), @"\D", "")
                        + Path.GetExtension(Listview1.Items[i].SubItems[0].Text);
                }
            }
            catch
            { }
        }
        private void btn_ClearName_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Listview1.Items.Count; i++)
                {
                    string Fname = Listview1.Items[i].SubItems[2].Text + "\\" + Listview1.Items[i].SubItems[1].Text;
                    Listview1.Items[i].SubItems[0].Text = Path.GetExtension(Fname);

                }
            }
            catch { }
        }
        private void btn_NummerComma_Click(object sender, EventArgs e)
        {
            NumberComma nc = new NumberComma();
            FormSpec.Init(nc);
            nc.mf = this;
            nc.StartPosition = FormStartPosition.CenterParent;
            nc.ShowDialog();
        }

        private void btn_WriteNumber_Click(object sender, EventArgs e)
        {
            WriteNumber wn = new WriteNumber();
            FormSpec.Init(wn);
            wn.mf = this;
            wn.StartPosition = FormStartPosition.CenterParent;
            wn.ShowDialog();
        }
        private void btn_ClearItem_Click(object sender, EventArgs e)
        {
            Listview1.Items.Clear();
            btn_disable();
        }
        private void btn_SelfName_Click(object sender, EventArgs e)
        {
            if (Listview1.SelectedItems.Count == 1)
            {
                SelfName sn = new SelfName();
                FormSpec.Init(sn);
                sn.mf = this;
                sn.StartPosition = FormStartPosition.CenterParent;
                sn.ShowDialog();
            }
        }
        private void btn_PathFolder_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.ShowDialog();
                string selected = dialog.SelectedPath;
                for (int i = 0; i < Listview1.Items.Count; i++)
                {
                    Listview1.Items[i].SubItems[3].Text = selected;
                }

            }
            catch { }

        }
        private void btn_AddPath_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Listview1.Items.Count; i++)
                {
                    DriveInfo info = new DriveInfo(Listview1.Items[i].SubItems[2].Text + "\\" + Listview1.Items[i].SubItems[0].Text);
                    //폴더일때
                    if (Listview1.Items[i].SubItems[2].Text == info.RootDirectory.ToString())
                    {
                        Listview1.Items[i].SubItems[0].Text = (info.RootDirectory.ToString()).Substring(0, 1) + "_" + Listview1.Items[i].SubItems[0].Text;
                    }
                    else//파일일때
                    {
                        Listview1.Items[i].SubItems[0].Text = Path.GetFileName(Listview1.Items[i].SubItems[2].Text) + "_" + Listview1.Items[i].SubItems[0].Text;
                    }
                }
            }
            catch { }

        }

        private void btn_ExtChng_Click(object sender, EventArgs e)
        {
            ExtChng ec = new ExtChng();
            FormSpec.Init(ec);
            ec.mf = this;
            ec.StartPosition = FormStartPosition.CenterParent;
            ec.ShowDialog();
        }

        private void btn_ExtAdd_Click(object sender, EventArgs e)
        {
            ExtAdd ea = new ExtAdd();
            FormSpec.Init(ea);
            ea.mf = this;
            ea.StartPosition = FormStartPosition.CenterParent;
            ea.ShowDialog();
        }

        private void btn_ExtDel_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Listview1.Items.Count; i++)
                {
                    Listview1.Items[i].SubItems[0].Text = Path.GetFileNameWithoutExtension(Listview1.Items[i].SubItems[0].Text);
                }
            }
            catch { }
        }


        //문자열 변환 메소드
        public void Chng(string raw, string chng, string frontback, string kind)
        {
            try
            {

                switch (kind)
                {
                    case "replace":
                        for (int i = 0; i < Listview1.Items.Count; i++)
                        {
                            Listview1.Items[i].SubItems[0].Text = (Listview1.Items[i].SubItems[0].Text).Replace(raw, chng);
                        }
                        break;
                    case "frontadd":
                        for (int i = 0; i < Listview1.Items.Count; i++)
                        {
                            Listview1.Items[i].SubItems[0].Text = raw + Listview1.Items[i].SubItems[0].Text;
                        }
                        break;
                    case "backadd":
                        for (int i = 0; i < Listview1.Items.Count; i++)
                        {

                            Listview1.Items[i].SubItems[0].Text = Path.GetFileNameWithoutExtension(Listview1.Items[i].SubItems[0].Text) + raw + Path.GetExtension(Listview1.Items[i].SubItems[0].Text);

                        }
                        break;
                    case "position":

                        for (int i = 0; i < Listview1.Items.Count; i++)
                        {


                            int _stringCount = Path.GetFileNameWithoutExtension(Listview1.Items[i].SubItems[0].Text).Length;
                            if (Convert.ToInt16(chng) > _stringCount)
                                chng = _stringCount.ToString();

                            Listview1.Items[i].SubItems[0].Text = (Path.GetFileNameWithoutExtension(Listview1.Items[i].SubItems[0].Text))
                                .Remove(Convert.ToInt16(raw) - 1, Convert.ToInt16(chng)) + Path.GetExtension(Listview1.Items[i].SubItems[0].Text);
                        }
                        break;
                    case "groupdel":
                        for (int i = 0; i < Listview1.Items.Count; i++)
                        {

                            string _string = Path.GetFileNameWithoutExtension(Listview1.Items[i].SubItems[0].Text);
                            int _stringCount = Path.GetFileNameWithoutExtension(Listview1.Items[i].SubItems[0].Text).Length;
                            string _rename = string.Empty;
                            int a = _string.IndexOf(raw);
                            int b = _string.LastIndexOf(chng) + 1;


                            Console.WriteLine(a + "\t" + b + "\t" + _stringCount);

                            _rename += Path.GetFileNameWithoutExtension(Listview1.Items[i].SubItems[0].Text).Substring(0, a);
                            _rename += Path.GetFileNameWithoutExtension(Listview1.Items[i].SubItems[0].Text).Substring(b, _stringCount - b);
                            Listview1.Items[i].SubItems[0].Text = _rename + Path.GetExtension(Listview1.Items[i].SubItems[0].Text);

                        }
                        break;
                    case "writenumber":
                        for (int i = 0 + Convert.ToInt16(chng); i < Listview1.Items.Count + Convert.ToInt16(chng); i++)
                        {
                            string NumberComma = "D" + raw.ToString();
                            Console.WriteLine(NumberComma);

                            if (frontback == "뒤")
                            {
                                Listview1.Items[i - Convert.ToInt16(chng)].SubItems[0].Text = Path.GetFileNameWithoutExtension(Listview1.Items[i - Convert.ToInt16(chng)].SubItems[0].Text)
                                    + i.ToString(NumberComma) + Path.GetExtension(Listview1.Items[i - Convert.ToInt16(chng)].SubItems[0].Text);

                            }
                            if (frontback == "앞")
                            {
                                Listview1.Items[i - Convert.ToInt16(chng)].SubItems[0].Text = i.ToString(NumberComma)
                                    + Path.GetFileNameWithoutExtension(Listview1.Items[i - Convert.ToInt16(chng)].SubItems[0].Text) + Path.GetExtension(Listview1.Items[i - Convert.ToInt16(chng)].SubItems[0].Text);
                            }

                        }
                        break;
                    case "selfname":
                        Listview1.SelectedItems[0].SubItems[0].Text = raw;
                        break;
                    case "extadd":
                        for (int i = 0; i < Listview1.Items.Count; i++)
                        {
                            Listview1.Items[i].SubItems[0].Text = Path.GetFileName(Listview1.Items[i].SubItems[0].Text) + "." + raw;

                        }
                        break;
                    case "extchng":
                        for (int i = 0; i < Listview1.Items.Count; i++)
                        {
                            Listview1.Items[i].SubItems[0].Text = Path.GetFileNameWithoutExtension(Listview1.Items[i].SubItems[0].Text) + "." + raw;

                        }
                        break;
                    case "numbercomma":
                        for (int i = 0; i < Listview1.Items.Count; i++)
                        {
                            if (frontback == "뒤")
                            {
                                Listview1.Items[i].SubItems[0].Text = (SetNumber.BackNumberSet(Listview1.Items[i].SubItems[0].Text, Convert.ToInt16(raw)));
                            }
                            if (frontback == "앞")
                            {
                                Listview1.Items[i].SubItems[0].Text = (SetNumber.FrontNumberSet(Listview1.Items[i].SubItems[0].Text, Convert.ToInt16(raw)));
                            }
                        }
                        break;
                }

            }
            catch (Exception x)
            {
                Console.WriteLine(x);
            }


        }

        private void btn_enable()
        {
            btn_ChangeName.Enabled = true;
            btn_ChangeCancel.Enabled = true;
            btn_Datetime.Enabled = true;
            btn_Replace.Enabled = true;
            btn_FrontAdd.Enabled = true;
            btn_BackAdd.Enabled = true;
            btn_ClearName.Enabled = true;
            btn_PositionDel.Enabled = true;
            btn_GroupDel.Enabled = true;
            btn_SetNumber.Enabled = true;
            btn_NummerComma.Enabled = true;
            btn_WriteNumber.Enabled = true;
            btn_ClearItem.Enabled = true;
            btn_SelfName.Enabled = true;
            btn_PathFolder.Enabled = true;
            btn_AddPath.Enabled = true;
            btn_ExtDel.Enabled = true;
            btn_ExtAdd.Enabled = true;
            btn_ExtChng.Enabled = true;
        }

        private void btn_disable()
        {
            btn_ChangeName.Enabled = false;
            btn_ChangeCancel.Enabled = false;
            btn_Datetime.Enabled = false;
            btn_Replace.Enabled = false;
            btn_FrontAdd.Enabled = false;
            btn_BackAdd.Enabled = false;
            btn_ClearName.Enabled = false;
            btn_PositionDel.Enabled = false;
            btn_GroupDel.Enabled = false;
            btn_SetNumber.Enabled = false;
            btn_NummerComma.Enabled = false;
            btn_WriteNumber.Enabled = false;
            btn_ClearItem.Enabled = false;
            btn_SelfName.Enabled = false;
            btn_PathFolder.Enabled = false;
            btn_AddPath.Enabled = false;
            btn_ExtDel.Enabled = false;
            btn_ExtAdd.Enabled = false;
            btn_ExtChng.Enabled = false;
        }

        private void Listview1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (Listview1.SelectedItems.Count == 1)
                btn_SelfName.Enabled = true;
            else
                btn_SelfName.Enabled = false;
        }

































    }
}
