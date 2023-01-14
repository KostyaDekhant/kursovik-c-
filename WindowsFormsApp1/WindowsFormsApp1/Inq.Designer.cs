namespace WindowsFormsApp1
{
    partial class Inq
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_F = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.textBox_I = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_O = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_F = new System.Windows.Forms.CheckBox();
            this.checkBox_I = new System.Windows.Forms.CheckBox();
            this.checkBox_O = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_rpa = new System.Windows.Forms.CheckBox();
            this.checkBox_social = new System.Windows.Forms.CheckBox();
            this.checkBox_gr = new System.Windows.Forms.CheckBox();
            this.checkBox_years = new System.Windows.Forms.CheckBox();
            this.checkBox_dir = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label_money = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_money);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox_F);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.textBox_I);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox_O);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBox_F);
            this.groupBox1.Controls.Add(this.checkBox_I);
            this.groupBox1.Controls.Add(this.checkBox_O);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkBox_rpa);
            this.groupBox1.Controls.Add(this.checkBox_social);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(628, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 211);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по характеристикам";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox_F
            // 
            this.textBox_F.Location = new System.Drawing.Point(69, 19);
            this.textBox_F.Name = "textBox_F";
            this.textBox_F.Size = new System.Drawing.Size(137, 20);
            this.textBox_F.TabIndex = 3;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(173, 136);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(63, 21);
            this.comboBox5.TabIndex = 26;
            // 
            // textBox_I
            // 
            this.textBox_I.Location = new System.Drawing.Point(69, 45);
            this.textBox_I.Name = "textBox_I";
            this.textBox_I.Size = new System.Drawing.Size(137, 20);
            this.textBox_I.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(9, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Запрос";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_O
            // 
            this.textBox_O.Location = new System.Drawing.Point(69, 71);
            this.textBox_O.Name = "textBox_O";
            this.textBox_O.Size = new System.Drawing.Size(137, 20);
            this.textBox_O.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Отчество";
            // 
            // checkBox_F
            // 
            this.checkBox_F.AutoSize = true;
            this.checkBox_F.Location = new System.Drawing.Point(221, 19);
            this.checkBox_F.Name = "checkBox_F";
            this.checkBox_F.Size = new System.Drawing.Size(15, 14);
            this.checkBox_F.TabIndex = 9;
            this.checkBox_F.UseVisualStyleBackColor = true;
            // 
            // checkBox_I
            // 
            this.checkBox_I.AutoSize = true;
            this.checkBox_I.Location = new System.Drawing.Point(221, 45);
            this.checkBox_I.Name = "checkBox_I";
            this.checkBox_I.Size = new System.Drawing.Size(15, 14);
            this.checkBox_I.TabIndex = 10;
            this.checkBox_I.UseVisualStyleBackColor = true;
            // 
            // checkBox_O
            // 
            this.checkBox_O.AutoSize = true;
            this.checkBox_O.Location = new System.Drawing.Point(221, 71);
            this.checkBox_O.Name = "checkBox_O";
            this.checkBox_O.Size = new System.Drawing.Size(15, 14);
            this.checkBox_O.TabIndex = 11;
            this.checkBox_O.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Средний балл";
            // 
            // checkBox_rpa
            // 
            this.checkBox_rpa.AutoSize = true;
            this.checkBox_rpa.Location = new System.Drawing.Point(133, 137);
            this.checkBox_rpa.Name = "checkBox_rpa";
            this.checkBox_rpa.Size = new System.Drawing.Size(15, 14);
            this.checkBox_rpa.TabIndex = 14;
            this.checkBox_rpa.UseVisualStyleBackColor = true;
            // 
            // checkBox_social
            // 
            this.checkBox_social.AutoSize = true;
            this.checkBox_social.Location = new System.Drawing.Point(9, 106);
            this.checkBox_social.Name = "checkBox_social";
            this.checkBox_social.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_social.Size = new System.Drawing.Size(149, 17);
            this.checkBox_social.TabIndex = 15;
            this.checkBox_social.Text = "  Социальная стипендия";
            this.checkBox_social.UseVisualStyleBackColor = true;
            // 
            // checkBox_gr
            // 
            this.checkBox_gr.AutoSize = true;
            this.checkBox_gr.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox_gr.Location = new System.Drawing.Point(552, 36);
            this.checkBox_gr.Name = "checkBox_gr";
            this.checkBox_gr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_gr.Size = new System.Drawing.Size(70, 17);
            this.checkBox_gr.TabIndex = 39;
            this.checkBox_gr.Text = "Выбрать";
            this.checkBox_gr.UseVisualStyleBackColor = true;
            this.checkBox_gr.CheckedChanged += new System.EventHandler(this.checkBox_gr_CheckedChanged);
            // 
            // checkBox_years
            // 
            this.checkBox_years.AutoSize = true;
            this.checkBox_years.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox_years.Location = new System.Drawing.Point(424, 38);
            this.checkBox_years.Name = "checkBox_years";
            this.checkBox_years.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_years.Size = new System.Drawing.Size(70, 17);
            this.checkBox_years.TabIndex = 38;
            this.checkBox_years.Text = "Выбрать";
            this.checkBox_years.UseVisualStyleBackColor = true;
            this.checkBox_years.CheckedChanged += new System.EventHandler(this.checkBox_years_CheckedChanged);
            // 
            // checkBox_dir
            // 
            this.checkBox_dir.AutoSize = true;
            this.checkBox_dir.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox_dir.Location = new System.Drawing.Point(296, 38);
            this.checkBox_dir.Name = "checkBox_dir";
            this.checkBox_dir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_dir.Size = new System.Drawing.Size(70, 17);
            this.checkBox_dir.TabIndex = 37;
            this.checkBox_dir.Text = "Выбрать";
            this.checkBox_dir.UseVisualStyleBackColor = true;
            this.checkBox_dir.CheckedChanged += new System.EventHandler(this.checkBox_dir_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton2.Location = new System.Drawing.Point(12, 60);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(100, 17);
            this.radioButton2.TabIndex = 36;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "По факультету";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton1.Location = new System.Drawing.Point(12, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 17);
            this.radioButton1.TabIndex = 35;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Все факультеты";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(501, 59);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 34;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(373, 59);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 33;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(245, 59);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 32;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 376);
            this.dataGridView1.TabIndex = 30;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.вернутьсяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // вернутьсяToolStripMenuItem
            // 
            this.вернутьсяToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.вернутьсяToolStripMenuItem.Name = "вернутьсяToolStripMenuItem";
            this.вернутьсяToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.вернутьсяToolStripMenuItem.Text = "Вернуться";
            this.вернутьсяToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяToolStripMenuItem_Click);
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.Location = new System.Drawing.Point(99, 176);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(53, 13);
            this.label_money.TabIndex = 28;
            this.label_money.Text = "Бюджет: ";
            // 
            // Inq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(920, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox_gr);
            this.Controls.Add(this.checkBox_years);
            this.Controls.Add(this.checkBox_dir);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(936, 526);
            this.MinimumSize = new System.Drawing.Size(936, 526);
            this.Name = "Inq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inq";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inq_FormClosing);
            this.Load += new System.EventHandler(this.Inq_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox_F;
        private System.Windows.Forms.ComboBox comboBox5;
        public System.Windows.Forms.TextBox textBox_I;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox_O;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.CheckBox checkBox_F;
        public System.Windows.Forms.CheckBox checkBox_I;
        public System.Windows.Forms.CheckBox checkBox_O;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.CheckBox checkBox_rpa;
        public System.Windows.Forms.CheckBox checkBox_social;
        private System.Windows.Forms.CheckBox checkBox_gr;
        private System.Windows.Forms.CheckBox checkBox_years;
        private System.Windows.Forms.CheckBox checkBox_dir;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label_money;
    }
}