using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class AddData : Form
    {
        public AddData()
        {
            InitializeComponent();
        }

        public Faculty[] fac = new Faculty[10]; 
        public static string path = @"C:\Users\Podor\Documents\GitHub\kursovik-c-\WindowsFormsApp1\WindowsFormsApp1\Data\";
        public int data_volume = 7;
        public Encoding enc = Encoding.GetEncoding(1251);
        public int year_now = 2022;
        public int[] Row_del_index = new int[200];
        public int[] DeletedRows = new int[200];
        public int[] sholarship = new int[10];
        public int total_money = 0;
        public bool needsave = false;

        public void OpenSholarshipFile()
        {
            string[] sholars = System.IO.File.ReadAllLines(path + "Sholarship.txt", Encoding.GetEncoding(1251));
            for (int i = 0; i < sholars.Length; i++)
            {
                sholarship[i] = Int32.Parse(sholars[i]);
            }
        }

        public void FacultyOpenFile()
        {
            if(File.Exists(path + "Faculty.txt"))
            {
                string[] faculties = System.IO.File.ReadAllLines(path + "Faculty.txt", Encoding.GetEncoding(1251));
                int fac_count = 0;
                foreach (string faculty in faculties)
                {
                    fac[fac_count] = new Faculty();
                    fac[fac_count].setNameF(faculty);
                    fac_count++;
                }
                fac[0].setCountF(fac_count);
                for (int i = 0; i < fac_count; i++)
                {
                    DirectOpenFile(i);
                }
            }
            else
            {
                MessageBox.Show("Ошибка! Файл с факультетами утерян!");
            }
        }

        public void DirectOpenFile(int fac_index)
        {
            string dirfile = path + fac[fac_index].getNameF() + "\\" + "Direction.txt";
            if (File.Exists(dirfile))
            {
                string[] directions = System.IO.File.ReadAllLines(dirfile, Encoding.GetEncoding(1251));
                int dir_count = 0;
                Direction dir = new Direction();
                for (int i = 0; i < directions.Length; i += 2)
                {
                    dir.setNameD(directions[i]);
                    dir.setYearsOfEdD(Int32.Parse(directions[i + 1]));
                    fac[fac_index].setDirF(dir, dir_count);
                    dir_count++;
                }
                fac[fac_index].setCountInDirF(dir_count);
                for (int i = 0; i < dir_count; i++)
                {
                    YearsOpenFile(fac_index, i);
                }
            }
            else
            {
                MessageBox.Show("Ошибка! Файл с направлениями утерян!");
            }
        }

        public void YearsOpenFile(int fac_index, int dir_index)
        {
            string yearfile = path + fac[fac_index].getNameF() + "\\"
                + fac[fac_index].getDirNameF(dir_index) + "\\" + "YearsOfUni.txt";
            if (File.Exists(yearfile))
            {
                string[] years = System.IO.File.ReadAllLines(yearfile, Encoding.GetEncoding(1251));
                int you_count = 0;
                YearsOfUni you = new YearsOfUni();
                for (int i = 0; i < years.Length; i += 2)
                {
                    you.setNameY(years[i]);
                    you.setYearOfStartY(Int32.Parse(years[i + 1]));
                    fac[fac_index].setYearsF(you, dir_index, you_count);
                    you_count++;
                }
                Direction direct = new Direction();
                direct.setDir(fac[fac_index].getDirF(dir_index));
                direct.setYearsOfEdD(you_count);
                fac[fac_index].setDirF(direct, dir_index);
                for (int i = 0; i < you_count; i++)
                {
                    GroupOpenFile(fac_index, dir_index, i);
                }
            }
            else
            {
                MessageBox.Show("Ошибка! Файл с курсами утерян!");
            }
        }

        public void GroupOpenFile(int fac_index, int dir_index, int you_index)
        {
            string grfile = path + fac[fac_index].getNameF() + "\\" + fac[fac_index].getDirNameF(dir_index) + "\\" 
                + fac[fac_index].getDirF(dir_index).getYearsNameD(you_index) + "\\" + "Groups.txt";
            if (File.Exists(grfile))
            {
                string[] groups = System.IO.File.ReadAllLines(grfile, Encoding.GetEncoding(1251));
                int gr_count = 0;
                Group group = new Group();
                YearsOfUni you = new YearsOfUni();
                you.setYearY(fac[fac_index].getYearsF(dir_index, you_index));
                you.setCountGroupsY(groups.Length);
                for (int i = 0; i < groups.Length; i++)
                {
                    group.setNameG(groups[i]);
                    you.setGroupsY(group, i);
                    gr_count++;
                }
                fac[fac_index].setYearsF(you, dir_index, you_index);
                for (int i = 0; i < gr_count; i++)
                {
                    StudOpenFile(fac_index, dir_index, you_index, i);
                }
            }
            else
            {
                MessageBox.Show("Ошибка! Файл с группами утерян!");
            }
        }

        public void StudOpenFile(int fac_index, int dir_index, int you_index, int group_index)
        {
            YearsOfUni you = new YearsOfUni();
            you.setYearY(fac[fac_index].getYearsF(dir_index, you_index));
            string yearfile = path + fac[fac_index].getNameF() + "\\"
                + fac[fac_index].getDirNameF(dir_index) + "\\" + fac[fac_index].getDirF(dir_index).getYearsNameD(you_index)
                + "\\" + you.getGroupNameY(group_index) + "\\" + "Students.txt";
            if (File.Exists(yearfile))
            {
                string[] students = System.IO.File.ReadAllLines(yearfile, Encoding.GetEncoding(1251));
                int stud_count = 0;
                Student stud = new Student();
                Group group = new Group();
                for (int i = 0; i < students.Length; i += data_volume)
                {
                    stud.setFIO(students[i], students[i + 1], students[i + 2]);
                    stud.setPhone_num(students[i + 3]);
                    stud.setGPA(Int32.Parse(students[i + 4]));
                    stud.setSpecial(Int32.Parse(students[i + 5]));
                    if (Int32.Parse(students[i + 6]) == 1)
                        stud.setSocial(true);
                    else
                        stud.setSocial(false);
                    fac[fac_index].setStudF(stud, dir_index, you_index, group_index, i / data_volume);
                    stud_count++;
                }
                group.setGroup(fac[fac_index].getGroupF(dir_index, you_index, group_index));
                group.setCountStudG(stud_count);
                fac[fac_index].setGroupsF(group, dir_index, you_index, group_index);
            }
            else
            {
                MessageBox.Show("Ошибка! Файл с информацией о студентах утерян!");
            }
        }

        public void CreateDataGrid()
        {
            dataGridView1.ColumnCount = data_volume - 3;
            dataGridView1.Columns[0].HeaderText = "ФИО";
            dataGridView1.Columns[1].HeaderText = "Телефон";
            dataGridView1.Columns[2].HeaderText = "Средний \nбалл";
            dataGridView1.Columns[2].Width = 20;
            dataGridView1.Columns[3].HeaderText = "Доп. \nстипендия";
            DataGridViewCheckBoxColumn cbc = new DataGridViewCheckBoxColumn();
            cbc.HeaderText = "Соц. стипендия";
            dataGridView1.Columns.Insert(4, cbc);
        }

        public void FacultyComboBoxAdd(System.Windows.Forms.ComboBox comboBox1, System.Windows.Forms.ComboBox comboBox2,
            System.Windows.Forms.ComboBox comboBox3, System.Windows.Forms.ComboBox comboBox4)
        {
            comboBox1.Items.Clear();
            int fac_count = fac[0].getCountF();
            if (fac_count == 0)
            {
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";
                return;
            }
            for (int i = 0; i < fac_count; i++)
            {
                comboBox1.Items.Add(fac[i].getNameF());
            }
            comboBox1.SelectedIndex = 0;
        }


        public void DirectComboBoxAdd(System.Windows.Forms.ComboBox comboBox1, System.Windows.Forms.ComboBox comboBox2,
            System.Windows.Forms.ComboBox comboBox3, System.Windows.Forms.ComboBox comboBox4)
        {
            comboBox2.Items.Clear();
            int dir_count = fac[comboBox1.SelectedIndex].getCountInDirF();
            if (dir_count == 0)
            {
                comboBox2.Text = "";
                comboBox2.Items.Clear();
                comboBox3.Text = "";
                comboBox3.Items.Clear();
                comboBox4.Text = "";
                comboBox4.Items.Clear();
                return;
            }
            for (int i = 0; i < dir_count; i++)
            {
                comboBox2.Items.Add(fac[comboBox1.SelectedIndex].getDirNameF(i));
              
            }
            comboBox2.SelectedIndex = 0;
        }

        public void YearsComboBoxAdd(System.Windows.Forms.ComboBox comboBox1, System.Windows.Forms.ComboBox comboBox2,
            System.Windows.Forms.ComboBox comboBox3, System.Windows.Forms.ComboBox comboBox4)
        {
            comboBox3.Items.Clear();
            Direction direct = new Direction();
            direct.setDir(fac[comboBox1.SelectedIndex].getDirF(comboBox2.SelectedIndex));
            int count_years = direct.getYearsOfEdD();
            
            if (count_years == 0)
	        {
		        comboBox3.Text = "";
		        comboBox3.Items.Clear();
                comboBox4.Text = "";
		        comboBox4.Items.Clear();
                ClearGrid(dataGridView1.RowCount);
                return;
	        }
	        for (int i = 0; i<count_years; i++)
	        {
                comboBox3.Items.Add(direct.getYearsNameD(i));
	        }
            comboBox3.SelectedIndex = 0;
        }

        public void GroupsComboBoxAdd(System.Windows.Forms.ComboBox comboBox1, System.Windows.Forms.ComboBox comboBox2,
            System.Windows.Forms.ComboBox comboBox3, System.Windows.Forms.ComboBox comboBox4)
        {
            YearsOfUni you = new YearsOfUni();
	        comboBox4.Items.Clear();
            you = fac[comboBox1.SelectedIndex].getYearsF(comboBox2.SelectedIndex, comboBox3.SelectedIndex);
            int count_groups = you.getCountGroupsY();
	        if (count_groups == 0)
	        {
		        comboBox4.Text = "";
                comboBox4.Items.Clear();
                ClearGrid(dataGridView1.RowCount);
                return;
	        }
	        if (count_groups == 9)
	        {
		        add_groups.Enabled = false;
	        }
            else
                add_groups.Enabled = true;
            for (int i = 0; i < count_groups; i++)
            {
                comboBox4.Items.Add(you.getGroupNameY(i));
            }
            comboBox4.SelectedIndex = 0;
        }

        public void StudentsPrint(int fac_index, int dir_index, int you_index, int group_index, DataGridView dataGridView1, Inq inq)
        {
            if (inq == null)
            {
                Inq inq1 = new Inq();
                inq = inq1;
            }
            ClearGrid(dataGridView1.RowCount);
            Student stud = new Student();
            Group group = new Group();
            group.setGroup(fac[fac_index].getGroupF(dir_index, you_index, group_index));
            int count_stud_before = dataGridView1.RowCount;
            int count_stud = group.getCountStudG();
            int rows_added = count_stud_before;
            for (int i = count_stud_before; i < count_stud_before + count_stud; i++)
            {
                if (inq.CheckTextBoxes(fac_index, dir_index, you_index, group_index, i - count_stud_before))
                {
                    dataGridView1.RowCount += 1;
                    stud.setStud(fac[fac_index].getStudF(dir_index, you_index, group_index, i - count_stud_before));
                    dataGridView1.Rows[rows_added].Cells[0].Value = stud.getlastname() + " " + stud.getfirstname() + " " + stud.getmidname();
                    dataGridView1.Rows[rows_added].Cells[1].Value = stud.getPhone_num();
                    dataGridView1.Rows[rows_added].Cells[2].Value = stud.getGPA().ToString();
                    if (dataGridView1.ColumnCount == 5)
                    {
                        dataGridView1.Rows[rows_added].Cells[3].Value = stud.getSpecial().ToString();
                        dataGridView1.Rows[rows_added].Cells[4].Value = stud.getSocial().ToString();
                    }
                    else
                    {
                        int sholar_calculation = Sholarship_Calculation(fac_index, dir_index, you_index, group_index, i - count_stud_before);
                        dataGridView1.Rows[rows_added].Cells[3].Value = sholar_calculation;
                        total_money += sholar_calculation;
                    }
                    rows_added++;
                }
            }
            if(rows_added > count_stud_before)
                set_header_num(dataGridView1);
        }

        public void ClearGrid(int size_of_grid)
        {
            dataGridView1.RowCount = 0;
        }

        public int Sholarship_Calculation(int fac_index, int dir_index, int year_index, int group_index, int stud_index)
        {

            Student stud = new Student();
            int sholar = 0;
            stud = fac[fac_index].getStudF(dir_index, year_index, group_index, stud_index);
            if (stud.getGPA() >= 90)
            {
                sholar += sholarship[0] * 2;
            }
            else if (stud.getGPA() >= 75)
            {
                sholar += (int)(sholarship[0] * 1.5);
            }

            else if (stud.getGPA() >= 50)
            {
                sholar += sholarship[0];
            }
            else if (stud.getSocial() == true)
            {
                sholar += sholarship[1];
            }
            if (stud.getSocial() == true && stud.getGPA() >= 50)
            {
                sholar += sholarship[2];
            }
            if (stud.getSpecial() != 0)
            {
                sholar += stud.getSpecial();
            }
            return sholar;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_facult.Text = comboBox1.Text;
            DirectComboBoxAdd(comboBox1, comboBox2, comboBox3, comboBox4);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] dir_name = comboBox2.Text.Split(' ');
            if (comboBox2.Text.Length > 14)
                label_dir.Text = dir_name[0];
            else
                label_dir.Text = comboBox2.Text;
            YearsComboBoxAdd(comboBox1, comboBox2, comboBox3, comboBox4);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_year.Text = comboBox3.Text;
            GroupsComboBoxAdd(comboBox1, comboBox2, comboBox3, comboBox4);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_gr.Text = comboBox4.Text;
            total_money = 0;
            StudentsPrint(comboBox1.SelectedIndex, comboBox2.SelectedIndex, comboBox3.SelectedIndex, comboBox4.SelectedIndex, dataGridView1, null);
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath + "\\";
            }
            else
            {
                MessageBox.Show("Вы не выбрали репозиторий!");
                return;
            }
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            ClearGrid(dataGridView1.RowCount);
            FacultyOpenFile();
            FacultyComboBoxAdd(comboBox1, comboBox2, comboBox3, comboBox4);
            MessageBox.Show("Данные обновлены!");
        }
        private void faculty_add_bttn_Click(object sender, EventArgs e)
        {
            if (textBox_faculty.Text != "")
            {
                FileStream file;
                var sr = new StreamWriter(path + "Faculty.txt", true, enc);
                sr.WriteLine(textBox_faculty.Text);
                sr.Close();
                System.IO.Directory.CreateDirectory(path + "\\" + textBox_faculty.Text);
                file = System.IO.File.Create(path + "\\" + textBox_faculty.Text + "\\" + "Direction.txt");
                textBox_faculty.Text = string.Empty;
                file.Close();
                MessageBox.Show("Готово!");
                fac[0].setCountF(fac[0].getCountF() + 1);
                FacultyOpenFile();
                FacultyComboBoxAdd(comboBox1, comboBox2, comboBox3, comboBox4);
            }
            else
                MessageBox.Show("Введите название факультета!");
        }

        private void directions_add_bttn_Click(object sender, EventArgs e)
        {
          
            if(textBox_directions.Text != "" && maskedTextBox_directions.Text != "")
            {
                FileStream file;
                var sr = new StreamWriter(path + "\\" + comboBox1.Text + "\\" + "Direction.txt", true, enc);
                sr.WriteLine(textBox_directions.Text);
                sr.WriteLine(maskedTextBox_directions.Text.ToString());
                sr.Close();
                System.IO.Directory.CreateDirectory(path + "\\" + comboBox1.Text + "\\" + textBox_directions.Text);
                file = System.IO.File.Create(path + "\\" + comboBox1.Text + "\\" + textBox_directions.Text + "\\" + "YearsOfUni.txt");
                file.Close();
                var year = new StreamWriter(path + "\\" + comboBox1.Text + "\\" + textBox_directions.Text + "\\" + "YearsOfUni.txt", true, enc);
                YearsOfUni you = new YearsOfUni();
                for (int i = 0; i < Int32.Parse(maskedTextBox_directions.Text); i++)
                {
                    string year_name = (i + 1).ToString() + " курс";
                    year.WriteLine(year_name);
                    year.WriteLine(year_now-i);
                    System.IO.Directory.CreateDirectory(path + "\\" + comboBox1.Text + "\\" + textBox_directions.Text + "\\" + year_name);
                    file = System.IO.File.Create(path + "\\" + comboBox1.Text + "\\" + textBox_directions.Text + "\\" + year_name + "\\" + "Groups.txt");
                }
                year.Close();
                file.Close();
                textBox_directions.Text = string.Empty;
                maskedTextBox_directions.Text = string.Empty;
                MessageBox.Show("Готово!");
                fac[comboBox1.SelectedIndex].setCountInDirF(fac[comboBox1.SelectedIndex].getCountInDirF() + 1);
                DirectOpenFile(comboBox1.SelectedIndex);
                DirectComboBoxAdd(comboBox1, comboBox2, comboBox3, comboBox4);
            }
            else if (textBox_directions.Text == "")
            {
                MessageBox.Show("Введите название направления!");
            }
            else if(maskedTextBox_directions.Text == "")
            {
                MessageBox.Show("Введите количество курсов!");
            }
        }
        private void years_add_bttn_Click(object sender, EventArgs e)
        {
            
        }
        private void add_groups_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_groups.Text != "" && maskedTextBox_groups.Text != "0")
            {
                string pathgroup = path + comboBox1.Text + "\\" + comboBox2.Text + "\\" + comboBox3.Text + "\\";
                if (!File.Exists(pathgroup + "Groups.txt"))
                {
                    FileStream file = System.IO.File.Create(pathgroup + "Groups.txt");
                    file.Close();
                }
                string group_name_temp = "";
                if (checkBox_name_gr.Checked == true && textBox_name_group.Text != "")
                {
                    group_name_temp = textBox_name_group.Text;
                }
                else
                {
                    if (checkBox_name_gr.Checked == true)
                    {
                        MessageBox.Show("Название не было введено!");
                        checkBox_name_gr.Checked = false;
                    }
                    string[] str = comboBox2.Text.Split(' ', '-');
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i].Length > 1)
                        {
                            str[i] = str[i].ToUpper();
                            group_name_temp += str[i][0];
                        }
                    }
                }
                string year_now_str = (year_now % 10).ToString();
                group_name_temp += "-" + year_now_str;
                string group_name = "";
                int gr_count = Int32.Parse(maskedTextBox_groups.Text);
                var sr = new StreamWriter(pathgroup + "Groups.txt", true, enc);
                int gr_count_before = fac[comboBox1.SelectedIndex].getCountInGroupsF(comboBox2.SelectedIndex, comboBox3.SelectedIndex);
                for (int i = 0; i < gr_count; i++)
                {
                    group_name = group_name_temp + (i + 1 + gr_count_before).ToString();
                    System.IO.Directory.CreateDirectory(pathgroup + group_name);
                    sr.WriteLine(group_name);
                }
                sr.Close();
                GroupOpenFile(comboBox1.SelectedIndex, comboBox2.SelectedIndex, comboBox3.SelectedIndex);
                GroupsComboBoxAdd(comboBox1, comboBox2, comboBox3, comboBox4);
            }
            else
                MessageBox.Show("Введите количество групп!");
        }

        

        private void del_fac_bttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить \"" + label_facult.Text + "\"?", "",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var facultfile = new StreamWriter(path + "Faculty.txt", false, enc);
                int fac_count = fac[0].getCountF();
                for (int i = 0; i < fac_count; i++)
                {
                    if(i != comboBox1.SelectedIndex)
                    {
                        facultfile.WriteLine(fac[i].getNameF());
                    }
                }
                facultfile.Close();
                System.IO.Directory.Move(path + fac[comboBox1.SelectedIndex].getNameF(), path + fac[comboBox1.SelectedIndex].getNameF() + " Временный");
                for (int i = comboBox1.SelectedIndex; i < fac_count; i++)
                {
                    fac[i] = fac[i + 1];
                }
                fac[0].setCountF(fac_count-1);
                FacultyComboBoxAdd(comboBox1, comboBox2, comboBox3, comboBox4);
            }
        }

        private void del_dir_bttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить \"" + label_dir.Text + "\"?", "",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var dirfile = new StreamWriter(path + comboBox1.Text + "\\" + "Direction.txt", false, enc);
                int dir_count = fac[comboBox1.SelectedIndex].getCountInDirF();
                for (int i = 0; i < dir_count; i++)
                {
                    if (i != comboBox2.SelectedIndex)
                    {
                        dirfile.WriteLine(fac[comboBox1.SelectedIndex].getDirNameF(i));
                        dirfile.WriteLine(fac[comboBox1.SelectedIndex].getDirF(i).getYearsOfEdD());
                    }
                }
                dirfile.Close();
                string dir_temp = path + fac[comboBox1.SelectedIndex].getNameF() + "\\" + fac[comboBox1.SelectedIndex].getDirNameF(comboBox2.SelectedIndex);
                System.IO.Directory.Move(dir_temp, dir_temp + " Временный");
                for (int i = comboBox2.SelectedIndex; i < dir_count; i++)
                {
                    fac[comboBox1.SelectedIndex].setDirF(fac[comboBox1.SelectedIndex].getDirF(i+1), i);
                }
                fac[comboBox1.SelectedIndex].setCountInDirF(dir_count - 1);
                DirectComboBoxAdd(comboBox1, comboBox2, comboBox3, comboBox4);
            }
        }

        private void del_year_bttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить \"" + label_year.Text + "\"?", "",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var yearfile = new StreamWriter(path + comboBox1.Text + "\\" + comboBox2.Text + "\\" + "YearsOfUni.txt", false, enc);
                int years_count = fac[comboBox1.SelectedIndex].getDirF(comboBox2.SelectedIndex).getYearsOfEdD();
                for (int i = 0; i < years_count; i++)
                {
                    if (i != comboBox3.SelectedIndex)
                    {
                        yearfile.WriteLine(fac[comboBox1.SelectedIndex].getDirF(comboBox2.SelectedIndex).getYearsNameD(i));
                        yearfile.WriteLine(fac[comboBox1.SelectedIndex].getYearsF(comboBox2.SelectedIndex, i).getYearOfStartY());
                    }
                }
                yearfile.Close();
                string year_temp = path + comboBox1.Text + "\\" + comboBox2.Text + "\\" + comboBox3.Text;
                System.IO.Directory.Move(year_temp, year_temp + " Временный");
                for (int i = comboBox3.SelectedIndex; i < years_count; i++)
                {
                    fac[comboBox1.SelectedIndex].setYearsF(fac[comboBox1.SelectedIndex].getYearsF(comboBox2.SelectedIndex, i + 1), comboBox2.SelectedIndex, i);
                }
                fac[comboBox1.SelectedIndex].getDirF(comboBox2.SelectedIndex).setYearsOfEdD(years_count-1);
                YearsComboBoxAdd(comboBox1, comboBox2, comboBox3, comboBox4);
            }
        }

        private void del_gr_bttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить \"" + label_gr.Text + "\"?", "",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var groupfile = new StreamWriter(path + comboBox1.Text + "\\" + comboBox2.Text + "\\" + comboBox3.Text + "\\" + "Groups.txt", false, enc);
                int group_count = fac[comboBox1.SelectedIndex].getYearsF(comboBox2.SelectedIndex, comboBox3.SelectedIndex).getCountGroupsY();
                for (int i = 0; i < group_count; i++)
                {
                    if (i != comboBox4.SelectedIndex)
                    {
                        groupfile.WriteLine(fac[comboBox1.SelectedIndex].getYearsF(comboBox2.SelectedIndex, comboBox3.SelectedIndex).getGroupNameY(i));
                    }
                }
                groupfile.Close();
                string group_temp = path + comboBox1.Text + "\\" + comboBox2.Text + "\\" + comboBox3.Text + "\\" + comboBox4.Text;
                System.IO.Directory.Move(group_temp, group_temp + " Временный");
                for (int i = comboBox4.SelectedIndex; i < group_count; i++)
                {
                    fac[comboBox1.SelectedIndex].setGroupsF(fac[comboBox1.SelectedIndex].getGroupF(comboBox2.SelectedIndex, comboBox3.SelectedIndex, i+1), comboBox2.SelectedIndex, comboBox3.SelectedIndex, i);
                }
                fac[comboBox1.SelectedIndex].getYearsF(comboBox2.SelectedIndex, comboBox3.SelectedIndex).setCountGroupsY(group_count-1);
                GroupsComboBoxAdd(comboBox1, comboBox2, comboBox3, comboBox4);
            }
        }

        private void add_stud_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_stud_count.Text != "")
            {
                int stud_count = Int32.Parse(maskedTextBox_stud_count.Text);
                for (int i = 0; i < stud_count; i++)
                {
                    dataGridView1.Rows.Add();
                }
                set_header_num(dataGridView1);
            }
            else
                MessageBox.Show("Введите количество студентов!");
        }

        public void set_header_num(DataGridView dataGrid)
        {
            int grid_size = dataGrid.Rows.Count;
            for (int i = 0; i < grid_size; i++)
            {
                dataGrid.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void del_bttn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text[textBox1.Text.Length - 1] == 44 || textBox1.Text[textBox1.Text.Length - 1] == 45)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
                int count_of_nums = 0;
                int len_of_text = textBox1.Text.Length - 1;
                int temp_num = 0;
                int len_of_num = 0;
                bool flag_for_end = false;
                while (len_of_text >= 0)
                {
                    if (Char.IsDigit(textBox1.Text[len_of_text]) && !flag_for_end)
                    {
                        temp_num += (textBox1.Text[len_of_text] - '0') * (int)Math.Pow(10, len_of_num);
                        len_of_num++;
                    }
                    else
                    {
                        Row_del_index[count_of_nums] = temp_num;
                        temp_num = 0;
                        len_of_num = 0;
                        if (textBox1.Text[len_of_text] == 44)
                            Row_del_index[count_of_nums + 1] = -1;
                        else if (textBox1.Text[len_of_text] == 45)
                            Row_del_index[count_of_nums + 1] = -2;
                        if (!flag_for_end)
                            count_of_nums += 2;
                    }
                    if (len_of_text == 0 && !flag_for_end)
                        flag_for_end = true;
                    else
                        len_of_text--;
                }
                sort_array(count_of_nums);
                int RowCount_dg = dataGridView1.Rows.Count;
                del_rows(count_of_nums, RowCount_dg);
            }
            else
                MessageBox.Show("Введите строки, которые нужно удалить!");
        }

        private bool RowWasDeleted(int[] DeletedRows, int rowindex, int rowcount)
        {
            for (int i = 0; i < rowcount; i++)
            {
                if (rowindex == DeletedRows[i])
                    return true;
            }
            return false;
        }
        private void del_rows(int count_of_nums, int RowCount_dg)
        {
            int flag_for_comma = 0;
            int count_of_del_rows = 0;
            for (int i = 0; i <= count_of_nums; i += 2)
            {
                flag_for_comma = 0;
                if (i <= count_of_nums)
                {
                    if (Row_del_index[i + 1] == -1)
                    {
                        flag_for_comma = 1;
                    }
                    else if (Row_del_index[i + 1] == -2)
                    {
                        for (int j = Row_del_index[i + 2]; j <= Row_del_index[i]; j++)
                        {
                            if (!RowWasDeleted(DeletedRows, j, RowCount_dg))
                            {
                                dataGridView1.Rows.RemoveAt(Row_del_index[i + 2] - 1);
                                DeletedRows[count_of_del_rows] = j;
                                count_of_del_rows++;
                            }
                        }
                        i += 2;
                    }
                    else if (Row_del_index[i + 1] != -2 && Row_del_index[i + 1] != -1)
                    {
                        flag_for_comma = 1;
                    }
                }
                else
                    flag_for_comma = 1;
                if (flag_for_comma == 1)
                {
                    if (!RowWasDeleted(DeletedRows, Row_del_index[i], RowCount_dg))
                    {
                        dataGridView1.Rows.RemoveAt(Row_del_index[i] - 1);
                        DeletedRows[count_of_del_rows] = Row_del_index[i];
                        count_of_del_rows++;
                    }
                }
            }
            textBox1.Text = "";
            clear_variables_for_del(RowCount_dg);
        }
        private void clear_variables_for_del(int rowcount)
        {
            for (int i = 0; i < rowcount; i++)
            {
                DeletedRows[i] = 0;
                Row_del_index[i] = 0;
            }
        }
        private void sort_array(int count_of_nums)
        {
            int temp_num = 0;
            int temp_num1 = 0;
            int temp_sym = 0;
            for (int i = count_of_nums; i >= 2; i -= 2)
            {
                for (int j = i - 2; j >= 0; j -= 2)
                {
                    if (i - 3 > 0)
                    {
                        if (Row_del_index[j - 1] == -2) //i-3
                        {
                            simple_sort(j, j - 2);
                            if (Row_del_index[i] > Row_del_index[j - 2])
                            {
                                temp_num = Row_del_index[i];
                                temp_sym = Row_del_index[i - 1];
                                Row_del_index[i] = Row_del_index[j];
                                Row_del_index[i - 1] = Row_del_index[j - 1];
                                Row_del_index[j] = Row_del_index[j - 2];
                                Row_del_index[j - 1] = temp_sym;
                                Row_del_index[j - 2] = temp_num;
                                //MessageBox.Show("1");
                            }
                            j -= 2;

                        }
                        else if (Row_del_index[i - 1] == -2 && Row_del_index[j - 3] != -2)
                        {
                            simple_sort(i, j);
                            if (Row_del_index[i - 2] > Row_del_index[j - 2])
                            {
                                temp_num = Row_del_index[j - 2];
                                temp_sym = Row_del_index[j - 1];
                                Row_del_index[j - 2] = Row_del_index[i - 2];
                                Row_del_index[j - 1] = Row_del_index[i - 1];
                                Row_del_index[i - 2] = Row_del_index[i];
                                Row_del_index[i - 1] = temp_sym;
                                Row_del_index[i] = temp_num;
                                //MessageBox.Show("2");
                            }
                            j -= 2;
                        }
                        else if (Row_del_index[i - 1] == -2 && Row_del_index[j - 3] == -2)
                        {
                            simple_sort(i, i - 2);
                            simple_sort(j - 2, j - 4);
                            if (Row_del_index[j] > Row_del_index[j - 4])
                            {
                                temp_num = Row_del_index[j - 2];
                                temp_sym = Row_del_index[j - 3];
                                temp_num1 = Row_del_index[j - 4];
                                Row_del_index[j - 2] = Row_del_index[i];
                                Row_del_index[j - 3] = Row_del_index[i - 1];
                                Row_del_index[j - 4] = Row_del_index[j];
                                Row_del_index[j] = temp_num1;
                                Row_del_index[i - 1] = temp_sym;
                                Row_del_index[i] = temp_num;
                                //MessageBox.Show("3");
                            }
                            j -= 4;
                        }
                        else if (Row_del_index[i - 1] != -2 && (Row_del_index[j - 1] != -2))
                        {
                            simple_sort(i, j);
                            //MessageBox.Show("4");
                        }
                        else
                            simple_sort(i, j);

                    }
                    else if (Row_del_index[i - 1] != -2)
                    {
                        //MessageBox.Show("5");
                        simple_sort(i, j);
                    }
                }
            }
        }

        private void simple_sort(int i, int j)
        {
            if (Row_del_index[i] > Row_del_index[j])
            {
                int temp_num = Row_del_index[i];
                Row_del_index[i] = Row_del_index[j];
                Row_del_index[j] = temp_num;
            }
        }
        private void save_data_bttn_Click(object sender, EventArgs e)
        {
            SaveStudFile(comboBox1.SelectedIndex, comboBox2.SelectedIndex, comboBox3.SelectedIndex, comboBox4.SelectedIndex);
        }

        private void SaveStudFile(int fac_index, int dir_index, int you_index, int gr_index)
        {
            int row_count = dataGridView1.RowCount;
            Student stud = new Student();
            string repos = comboBox1.Text + "\\" + comboBox2.Text + "\\" + comboBox3.Text + "\\" + comboBox4.Text + "\\";
            var st = new StreamWriter(path + repos + "Students.txt", false, enc);
            for (int i = 0; i < row_count; i++)
            {
                string[] FIO = dataGridView1.Rows[i].Cells[0].Value.ToString().Split(' ');
                stud.setFIO(FIO[0], FIO[1], FIO[2]);
                stud.setPhone_num(dataGridView1.Rows[i].Cells[1].Value.ToString());
                stud.setGPA(Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
                stud.setSpecial(Int32.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()));
                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "True")
                    stud.setSocial(true);
                else
                    stud.setSocial(false);
                fac[fac_index].setStudF(stud, dir_index, you_index, gr_index, i);
                st.WriteLine(stud.getlastname());
                st.WriteLine(stud.getfirstname());
                st.WriteLine(stud.getmidname());
                st.WriteLine(stud.getPhone_num());
                st.WriteLine(stud.getGPA());
                st.WriteLine(stud.getSpecial());
                if(stud.getSocial())
                    st.WriteLine("1");
                else
                    st.WriteLine("0");
            }
            st.Close();
            MessageBox.Show("Данные успешно сохранены!");
            needsave = false;
        }

        private void AddData_Load(object sender, EventArgs e)
        {

            maskedTextBox_directions.Mask = "0";
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridView1.ReadOnly = true;
            checkBox_edit_grid.Text = "Выключён";
            OpenSholarshipFile();
            FacultyOpenFile();
            CreateDataGrid();
            FacultyComboBoxAdd(comboBox1, comboBox2, comboBox3, comboBox4);
        }
        private void AddData_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
        }
        private bool check_data_grid()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1[j, i].Value == null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void checkBox_edit_grid_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_edit_grid.Checked == true)
            {
                dataGridView1.ReadOnly = false;
                checkBox_edit_grid.Text = "Включён";
                add_groups.Enabled = false;
                add_stud.Enabled = false;
                save_data_bttn.Enabled = false;
                needsave = true;
            }
            else
            {
                if (check_data_grid())
                {
                    checkBox_edit_grid.Checked = true;
                    MessageBox.Show("Не все данные введены!", "Внимание!");
                    //Flag_for_checkbox = true;
                    return;
                }
                dataGridView1.ReadOnly = true;
                checkBox_edit_grid.Text = "Выключён";
                add_groups.Enabled = true;
                add_stud.Enabled = true;
                save_data_bttn.Enabled = true;
            }
        }

        private void maskedTextBox_groups_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            int groups_count_class = fac[comboBox1.SelectedIndex].getYearsF(comboBox2.SelectedIndex, comboBox3.SelectedIndex).getCountGroupsY();
            if ((groups_count_class + (symbol - '0')) > 9)
            {
                MessageBox.Show("групп не может быть больше 10!");
                e.Handled = true;   
                maskedTextBox_groups.Text = Convert.ToString(9 - groups_count_class);
            }
        }

        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(needsave)
            {
                if (MessageBox.Show("Данные не сохранены! Вы действительно хотите выйти?", "",
                MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }
            this.Close();
        }
    }
}
