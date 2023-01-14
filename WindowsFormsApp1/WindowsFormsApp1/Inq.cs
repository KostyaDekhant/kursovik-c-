using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Inq : Form
    {
        public Inq()
        {
            InitializeComponent();
        }
        public AddData ad = new AddData();
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (comboBox1.Text != "")
                {
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    comboBox3.Text = "";
                    comboBox4.Text = "";
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                }
                checkBox_dir.Enabled = false;
            }
        }

        private void Inq_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartForm form = new StartForm();
            form.Show();
        }

        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                //AddData ad = new AddData();
                ad.FacultyOpenFile();
                ad.FacultyComboBoxAdd(comboBox1, comboBox2, comboBox3, comboBox4);
                ad.Close();
                comboBox1.Enabled = true;
                checkBox_dir.Enabled = true;
            }
        }

        private void Inq_Load(object sender, EventArgs e)
        {
            //AddData ad = new AddData();
            dataGridView1.ColumnCount = ad.data_volume - 3;
            dataGridView1.Columns[0].HeaderText = "ФИО";
            dataGridView1.Columns[1].HeaderText = "Телефон";
            dataGridView1.Columns[2].HeaderText = "Средний балл";
            dataGridView1.Columns[3].HeaderText = "Стипендия";
            checkBox_dir.Checked = false;
            checkBox_years.Checked = false;
            checkBox_gr.Checked = false;
            ad.OpenSholarshipFile();

            ad.FacultyOpenFile();
            checkBox_years.Enabled = false;
            checkBox_gr.Enabled = false;

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;

            PrintComboBoxSign();
            radioButton1.Checked = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.RowCount = 0;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            //ad.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox_dir.Checked == true)
            {
                //AddData ad = new AddData();
                ad.DirectComboBoxAdd(comboBox1, comboBox2, comboBox3, comboBox4);
                //ad.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox_years.Checked == true)
            {
                //AddData ad = new AddData();
                ad.YearsComboBoxAdd(comboBox1, comboBox2, comboBox3, comboBox4);
                //ad.Close();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox_gr.Checked == true)
            {
                //AddData ad = new AddData();
                ad.GroupsComboBoxAdd(comboBox1, comboBox2, comboBox3, comboBox4);
                //ad.Close();
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrintInfoAboutStud()
        {
            //AddData ad = new AddData();
            int flag = 0;
            int facult_ind = 0, dir_ind = 0, year_ind = 0, group_ind = 0;
            ad.total_money = 0;
            //ad.getFac(facult);
            int facult_count = 0, dir_count = 0, years_count = 0, groups_count = 0;
            if (radioButton1.Checked == false)
            {
                facult_ind = comboBox1.SelectedIndex;
                facult_count = facult_ind + 1;
                if (checkBox_dir.Checked == true)
                {
                    dir_ind = comboBox2.SelectedIndex;
                    dir_count = dir_ind + 1;
                    if (checkBox_years.Checked == true)
                    {
                        year_ind = comboBox3.SelectedIndex;
                        years_count = year_ind + 1;
                        if (checkBox_gr.Checked == true)
                        {
                            group_ind = comboBox4.SelectedIndex;
                            groups_count = group_ind + 1;
                        }
                        else
                            flag = 1;
                    }
                    else
                        flag = 2;

                }
                else
                    flag = 3;

            }
            else
            {
                facult_count = ad.fac[0].getCountF();
                flag = 3;
            }
            for (int i = facult_ind; i < facult_count; i++)
            {
                if (flag == 3)
                    dir_count = ad.fac[i].getCountInDirF();
                for (int j = dir_ind; j < dir_count; j++)
                {
                    if (flag >= 2)
                        years_count = ad.fac[i].getCountInYearsF(j);
                    for (int k = year_ind; k < years_count; k++)
                    {
                        if (flag >= 1)
                            groups_count = ad.fac[i].getCountInGroupsF(j, k);
                        for (int l = group_ind; l < groups_count; l++)
                        {

                            ad.StudentsPrint(i, j, k, l, dataGridView1, this);
                        }
                    }
                }
            }
            label_money.Text = "Бюджет: "+ad.total_money.ToString();
            ad.set_header_num(dataGridView1);
            ad.Close();
        }

        public bool CheckTextBoxes(int fac_index, int dir_index, int year_index, int group_index, int stud_index)
        {
            //AddData ad = new AddData();
            int flag_for_checkboxes = 1;
            if (checkBox_F.Checked == true)
            {
                if (textBox_F.Text == "")
                {
                    MessageBox.Show("Поле \"Фамилия\" не было введено!");
                    checkBox_F.Checked = false;
                    return false;
                }
                if (textBox_F.Text != ad.fac[fac_index].getStudF(dir_index, year_index, group_index, stud_index).getlastname())
                {
                    flag_for_checkboxes = 0;
                }
            }
            if (checkBox_I.Checked == true)
            {
                if (textBox_I.Text == "")
                {
                    checkBox_I.Checked = false;
                    MessageBox.Show("Поле \"Имя\" не было введено!");
                    return false;
                }
                if (textBox_I.Text != ad.fac[fac_index].getStudF(dir_index, year_index, group_index, stud_index).getfirstname())
                {
                    flag_for_checkboxes = 0;
                }
            }
            if (checkBox_O.Checked == true)
            {
                if (textBox_O.Text == "")
                {
                    checkBox_O.Checked = false;
                    MessageBox.Show("Поле \"Отчество\" не было введено!");
                    return false;
                }
                if (textBox_O.Text != ad.fac[fac_index].getStudF(dir_index, year_index, group_index, stud_index).getmidname().ToString())
                {
                    flag_for_checkboxes = 0;
                }
            }
            if (checkBox_rpa.Checked == true)
            {
                if (textBox1.Text == "")
                {
                    checkBox_rpa.Checked = false;
                    MessageBox.Show("Рейтинг не был указан!");
                    return false;
                }
                if (comboBox5.SelectedIndex == 0)
                {
                    if (textBox1.Text != ad.fac[fac_index].getStudF(dir_index, year_index, group_index, stud_index).getGPA().ToString())
                    {
                        flag_for_checkboxes = 0;
                    }
                }
                else if (comboBox5.SelectedIndex == 1)
                {
                    if (Int32.Parse(textBox1.Text) > ad.fac[fac_index].getStudF(dir_index, year_index, group_index, stud_index).getGPA())
                    {
                        flag_for_checkboxes = 0;
                    }
                }
                else if (comboBox5.SelectedIndex == 2)
                {
                    if (Int32.Parse(textBox1.Text) < ad.fac[fac_index].getStudF(dir_index, year_index, group_index, stud_index).getGPA())
                    {
                        flag_for_checkboxes = 0;
                    }
                }
                else if (comboBox5.SelectedIndex == 3)
                {
                    if (Int32.Parse(textBox1.Text) >= ad.fac[fac_index].getStudF(dir_index, year_index, group_index, stud_index).getGPA())
                    {
                        flag_for_checkboxes = 0;
                    }
                }
                else if (comboBox5.SelectedIndex == 4)
                {
                    if (Int32.Parse(textBox1.Text) <= ad.fac[fac_index].getStudF(dir_index, year_index, group_index, stud_index).getGPA())
                    {
                        flag_for_checkboxes = 0;
                    }
                }

            }
            if (checkBox_social.Checked == true)
            {
                if (ad.fac[fac_index].getStudF(dir_index, year_index, group_index, stud_index).getSocial() == false)
                {
                    flag_for_checkboxes = 0;
                }
            }
            if (flag_for_checkboxes == 1)
            {
                return true;
            }
            else
                return false;

        }

        private void PrintComboBoxSign()
        {
            comboBox5.Items.Add("==");
            comboBox5.Items.Add(">=");
            comboBox5.Items.Add("<=");
            comboBox5.Items.Add(">");
            comboBox5.Items.Add("<");
            comboBox5.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 0;
            PrintInfoAboutStud();
        }

        private void checkBox_dir_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_dir.Checked == true)
            {
                ad.DirectComboBoxAdd(comboBox1, comboBox2, comboBox3, comboBox4);
                comboBox2.Enabled = true;
                checkBox_years.Enabled = true;
            }
            else
            {
                if (checkBox_years.Checked == true)
                    checkBox_years.Checked = false;
                if (checkBox_gr.Checked == true)
                    checkBox_gr.Checked = false;
                checkBox_years.Enabled = false;
                checkBox_gr.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox2.Text = "";
                comboBox2.Items.Clear();
            }
        }

        private void checkBox_years_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_years.Checked == true)
            {
                ad.YearsComboBoxAdd(comboBox1, comboBox2, comboBox3, comboBox4);
                comboBox3.Enabled = true;
                checkBox_gr.Enabled = true;
            }
            else
            {
                if (checkBox_gr.Checked == true)
                    checkBox_gr.Checked = false;
                comboBox3.Text = "";
                comboBox3.Items.Clear();
                checkBox_gr.Enabled = false;
                comboBox3.Enabled = false;
            }
        }

        private void checkBox_gr_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_gr.Checked == true)
            {
                ad.GroupsComboBoxAdd(comboBox1, comboBox2, comboBox3, comboBox4);
                comboBox4.Enabled = true;
            }
            else
            {
                comboBox4.Text = "";
                comboBox4.Items.Clear();
                comboBox4.Enabled = false;
            }
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                AddData.path = folderBrowserDialog1.SelectedPath+"\\";
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                ad.ClearGrid(dataGridView1.RowCount);
                ad.FacultyOpenFile();
                ad.FacultyComboBoxAdd(comboBox1, comboBox2, comboBox3, comboBox4);
                MessageBox.Show("Данные обновлены!");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if (textBox1.Text.Length >= 3 && symbol != 8 && symbol != 9)
            {
                e.Handled = true;
                return;
            }
            if ((symbol <= 47 || symbol >= 58) && symbol != 8 && symbol != 9)
            {
                e.Handled = true;
                return;
            }
            if (textBox1.Text.Length != 0 && symbol != 8 && symbol != 9)
            {
                if (Int32.Parse((textBox1.Text)) > 10 && textBox1.Text.Length == 2)
                {
                    e.Handled = true;
                    return;
                }
                else if (Int32.Parse(textBox1.Text) == 10 && textBox1.Text.Length == 2 && symbol != 48)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (symbol == 48 && textBox1.Text.Length == 0)
            {
                e.Handled = true;
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] <= 47 || textBox1.Text[i] >= 58)
                {
                    textBox1.Text = "";
                    return;
                }
            }
        }
    }
}
