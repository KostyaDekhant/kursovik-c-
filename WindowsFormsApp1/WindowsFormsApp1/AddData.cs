using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class AddData : Form
    {
        public AddData()
        {
            InitializeComponent();
        }

        //for (int i = 0; i<faculties.Length; i+= data_volume)
        //    {
        //        dataGridView1.Rows[i].Cells[0].Value = faculties[i] + faculties[i + 1]+ faculties[i + 2];
        //        dataGridView1.Rows[i].Cells[1].Value = faculties[i + 3];
        //        dataGridView1.Rows[i].Cells[2].Value = faculties[i + 4];
        //        dataGridView1.Rows[i].Cells[3].Value = faculties[i + 5];
        //        dataGridView1.Rows[i].Cells[4].Value = faculties[i + 6];
        //    }

        public Faculty[] fac = new Faculty[10]; 
        public string path = @"C:\Users\Podor\Documents\GitHub\kursovik-c-\WindowsFormsApp1\WindowsFormsApp1\Data\";
        public int data_volume = 7;
        //public int count_facult = 0;
        public void FacultyOpenFile()
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

        public void DirectOpenFile(int fac_index)
        {
            string[] directions = System.IO.File.ReadAllLines(path + fac[fac_index].getNameF() + "\\"+ "Direction.txt", Encoding.GetEncoding(1251));
            int dir_count = 0;
            Direction dir = new Direction();
            for (int i = 0; i < directions.Length; i+=2)
            {
                dir.setNameD(directions[i]);
                dir.setYearsOfEdD(Int32.Parse(directions[i+1]));
                fac[fac_index].setDirF(dir, dir_count);
                dir_count++;
            }
            fac[fac_index].setCountInDirF(dir_count);
            for (int i = 0; i < dir_count; i++)
            {
                YearsOpenFile(fac_index, i);
            }
        }

        public void YearsOpenFile(int fac_index, int dir_index)
        {
            string[] years = System.IO.File.ReadAllLines(path + fac[fac_index].getNameF() + "\\"
                + fac[fac_index].getDirNameF(dir_index) + "\\" + "YearsOfUni.txt", Encoding.GetEncoding(1251));
            int you_count = 0;
            YearsOfUni you = new YearsOfUni();
            for (int i = 0; i < years.Length; i += 2)
            {
                you.setNameY(years[i]);
                you.setYearOfStartY(Int32.Parse(years[i + 1]));
                fac[fac_index].setYearsF(you, dir_index, you_count);
                you_count++;
            }
            fac[fac_index].getDirF(dir_index).setYearsOfEdD(you_count);
            for (int i = 0; i < you_count; i++)
            {
                GroupOpenFile(fac_index, dir_index, i);
            }
        }

        public void GroupOpenFile(int fac_index, int dir_index, int you_index)
        {
            string[] groups = System.IO.File.ReadAllLines(path + fac[fac_index].getNameF() + "\\"
                + fac[fac_index].getDirNameF(dir_index) + "\\" + fac[fac_index].getDirF(dir_index).getYearsNameD(you_index) 
                + "\\" + "Groups.txt", Encoding.GetEncoding(1251));
            int gr_count = 0;
            Group group = new Group();
            for (int i = 0; i < groups.Length; i ++)
            {
                group.setNameG(groups[i]);
                MessageBox.Show(group.getNameG());
                fac[fac_index].setGroupsF(group, dir_index, you_index, gr_count);
                gr_count++;
            }
            //MessageBox.Show(fac[fac_index].getYearsF(dir_index, you_index).getGroupNameY(0));
            fac[fac_index].getYearsF(dir_index, you_index).setCountGroupsY(gr_count);
            for (int i = 0; i < gr_count; i++)
            {
                 StudOpenFile(fac_index, dir_index, you_index, i);
            }
        }

        public void StudOpenFile(int fac_index, int dir_index, int you_index, int group_index)
        {

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

        public void FacultyComboBoxAdd()
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


        public void DirectComboBoxAdd()
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

        public void YearsComboBoxAdd()
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
                //ClearGrid(GridSize);
		        return;
	        }
	        for (int i = 0; i<count_years; i++)
	        {
                comboBox3.Items.Add(direct.getYearsNameD(i));
	        }
            comboBox3.SelectedIndex = 0;
        }

        public void GroupsComboBoxAdd()
        {
            YearsOfUni you = new YearsOfUni();
	        comboBox4.Items.Clear();
            you = fac[comboBox1.SelectedIndex].getYearsF(comboBox2.SelectedIndex, comboBox3.SelectedIndex);
            int count_groups = you.getCountGroupsY();
	        if (count_groups == 0)
	        {
		        comboBox4.Text = "";
                comboBox4.Items.Clear();
                //ClearGrid(GridSize);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectComboBoxAdd();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            YearsComboBoxAdd();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupsComboBoxAdd();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void faculty_add_bttn_Click(object sender, EventArgs e)
        {

        }

        private void years_add_bttn_Click(object sender, EventArgs e)
        {

        }

        private void directions_add_bttn_Click(object sender, EventArgs e)
        {

        }

        private void add_groups_Click(object sender, EventArgs e)
        {

        }

        private void del_fac_bttn_Click(object sender, EventArgs e)
        {

        }

        private void del_dir_bttn_Click(object sender, EventArgs e)
        {

        }

        private void del_year_bttn_Click(object sender, EventArgs e)
        {

        }

        private void del_gr_bttn_Click(object sender, EventArgs e)
        {

        }

        private void add_stud_Click(object sender, EventArgs e)
        {

        }

        private void del_bttn_Click(object sender, EventArgs e)
        {

        }

        private void save_data_bttn_Click(object sender, EventArgs e)
        {

        }

        private void AddData_Load(object sender, EventArgs e)
        {
            FacultyOpenFile();
            FacultyComboBoxAdd();
        }

        private void AddData_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
        }
    }
}
