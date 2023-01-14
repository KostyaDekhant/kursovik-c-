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

namespace WindowsFormsApp1
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        public bool flag_for_file_open = false;

        private void add_data_Click(object sender, EventArgs e)
        { 
            AddData addData = new AddData();
            if(!File.Exists(AddData.path+"Faculty.txt"))
            {
                файлToolStripMenuItem.PerformClick();
                if(flag_for_file_open)
                {
                    flag_for_file_open = false;
                    return;
                }    
            }
            addData.Show();
            this.Hide();
        }

        private void make_inq_Click(object sender, EventArgs e)
        {
            AddData addData = new AddData();
            Inq inq = new Inq();
            if (!File.Exists(AddData.path + "Faculty.txt"))
            {
                файлToolStripMenuItem.PerformClick();
                if (flag_for_file_open)
                {
                    flag_for_file_open = false;
                    return;
                }
            }
            inq.Show();
            this.Hide();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddData addData = new AddData();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                AddData.path = folderBrowserDialog1.SelectedPath + "\\";
            }
            else
            {
                MessageBox.Show("Вы не выбрали репозиторий!");
                flag_for_file_open = true;
                return;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
