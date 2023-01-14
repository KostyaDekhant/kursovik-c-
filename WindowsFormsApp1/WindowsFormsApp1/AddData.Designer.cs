namespace WindowsFormsApp1
{
    partial class AddData
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_gr = new System.Windows.Forms.Label();
            this.label_year = new System.Windows.Forms.Label();
            this.label_dir = new System.Windows.Forms.Label();
            this.label_facult = new System.Windows.Forms.Label();
            this.del_gr_bttn = new System.Windows.Forms.Button();
            this.del_year_bttn = new System.Windows.Forms.Button();
            this.del_dir_bttn = new System.Windows.Forms.Button();
            this.del_fac_bttn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.del_bttn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox_stud_count = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.save_data_bttn = new System.Windows.Forms.Button();
            this.add_stud = new System.Windows.Forms.Button();
            this.checkBox_edit_grid = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_name_gr = new System.Windows.Forms.CheckBox();
            this.textBox_name_group = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox_directions = new System.Windows.Forms.MaskedTextBox();
            this.textBox_directions = new System.Windows.Forms.TextBox();
            this.textBox_faculty = new System.Windows.Forms.TextBox();
            this.years_add_bttn = new System.Windows.Forms.Button();
            this.years_label = new System.Windows.Forms.Label();
            this.directions_add_bttn = new System.Windows.Forms.Button();
            this.dir_label = new System.Windows.Forms.Label();
            this.faculty_add_bttn = new System.Windows.Forms.Button();
            this.new_f_label = new System.Windows.Forms.Label();
            this.maskedTextBox_groups = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.add_groups = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_gr);
            this.groupBox2.Controls.Add(this.label_year);
            this.groupBox2.Controls.Add(this.label_dir);
            this.groupBox2.Controls.Add(this.label_facult);
            this.groupBox2.Controls.Add(this.del_gr_bttn);
            this.groupBox2.Controls.Add(this.del_year_bttn);
            this.groupBox2.Controls.Add(this.del_dir_bttn);
            this.groupBox2.Controls.Add(this.del_fac_bttn);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(628, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 151);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удаление объектов";
            // 
            // label_gr
            // 
            this.label_gr.AutoSize = true;
            this.label_gr.Location = new System.Drawing.Point(12, 114);
            this.label_gr.Name = "label_gr";
            this.label_gr.Size = new System.Drawing.Size(42, 13);
            this.label_gr.TabIndex = 7;
            this.label_gr.Text = "Группа";
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Location = new System.Drawing.Point(12, 85);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(31, 13);
            this.label_year.TabIndex = 6;
            this.label_year.Text = "Курс";
            // 
            // label_dir
            // 
            this.label_dir.AutoSize = true;
            this.label_dir.Location = new System.Drawing.Point(12, 55);
            this.label_dir.Name = "label_dir";
            this.label_dir.Size = new System.Drawing.Size(75, 13);
            this.label_dir.TabIndex = 5;
            this.label_dir.Text = "Направление";
            // 
            // label_facult
            // 
            this.label_facult.AutoSize = true;
            this.label_facult.Location = new System.Drawing.Point(12, 28);
            this.label_facult.Name = "label_facult";
            this.label_facult.Size = new System.Drawing.Size(63, 13);
            this.label_facult.TabIndex = 4;
            this.label_facult.Text = "Факультет";
            // 
            // del_gr_bttn
            // 
            this.del_gr_bttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.del_gr_bttn.Location = new System.Drawing.Point(129, 109);
            this.del_gr_bttn.Name = "del_gr_bttn";
            this.del_gr_bttn.Size = new System.Drawing.Size(139, 23);
            this.del_gr_bttn.TabIndex = 3;
            this.del_gr_bttn.Text = "Удалить группу";
            this.del_gr_bttn.UseVisualStyleBackColor = true;
            this.del_gr_bttn.Click += new System.EventHandler(this.del_gr_bttn_Click);
            // 
            // del_year_bttn
            // 
            this.del_year_bttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.del_year_bttn.Location = new System.Drawing.Point(129, 80);
            this.del_year_bttn.Name = "del_year_bttn";
            this.del_year_bttn.Size = new System.Drawing.Size(139, 23);
            this.del_year_bttn.TabIndex = 2;
            this.del_year_bttn.Text = "Удалить курс";
            this.del_year_bttn.UseVisualStyleBackColor = true;
            this.del_year_bttn.Click += new System.EventHandler(this.del_year_bttn_Click);
            // 
            // del_dir_bttn
            // 
            this.del_dir_bttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.del_dir_bttn.Location = new System.Drawing.Point(129, 52);
            this.del_dir_bttn.Name = "del_dir_bttn";
            this.del_dir_bttn.Size = new System.Drawing.Size(139, 23);
            this.del_dir_bttn.TabIndex = 1;
            this.del_dir_bttn.Text = "Удалить направление";
            this.del_dir_bttn.UseVisualStyleBackColor = true;
            this.del_dir_bttn.Click += new System.EventHandler(this.del_dir_bttn_Click);
            // 
            // del_fac_bttn
            // 
            this.del_fac_bttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.del_fac_bttn.Location = new System.Drawing.Point(129, 23);
            this.del_fac_bttn.Name = "del_fac_bttn";
            this.del_fac_bttn.Size = new System.Drawing.Size(139, 23);
            this.del_fac_bttn.TabIndex = 0;
            this.del_fac_bttn.Text = "Удалить факультет";
            this.del_fac_bttn.UseVisualStyleBackColor = true;
            this.del_fac_bttn.Click += new System.EventHandler(this.del_fac_bttn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.del_bttn);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.maskedTextBox_stud_count);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.save_data_bttn);
            this.groupBox3.Controls.Add(this.add_stud);
            this.groupBox3.Controls.Add(this.checkBox_edit_grid);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(913, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 151);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Редактировать список";
            // 
            // del_bttn
            // 
            this.del_bttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.del_bttn.Location = new System.Drawing.Point(143, 93);
            this.del_bttn.Name = "del_bttn";
            this.del_bttn.Size = new System.Drawing.Size(100, 21);
            this.del_bttn.TabIndex = 12;
            this.del_bttn.Text = "Удалить";
            this.del_bttn.UseVisualStyleBackColor = true;
            this.del_bttn.Click += new System.EventHandler(this.del_bttn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Укажите строки:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 10;
            // 
            // maskedTextBox_stud_count
            // 
            this.maskedTextBox_stud_count.Location = new System.Drawing.Point(143, 20);
            this.maskedTextBox_stud_count.Name = "maskedTextBox_stud_count";
            this.maskedTextBox_stud_count.Size = new System.Drawing.Size(17, 20);
            this.maskedTextBox_stud_count.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сохранить данные:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество студентов:";
            // 
            // save_data_bttn
            // 
            this.save_data_bttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save_data_bttn.Location = new System.Drawing.Point(143, 119);
            this.save_data_bttn.Name = "save_data_bttn";
            this.save_data_bttn.Size = new System.Drawing.Size(100, 23);
            this.save_data_bttn.TabIndex = 2;
            this.save_data_bttn.Text = "Сохранить данные";
            this.save_data_bttn.UseVisualStyleBackColor = true;
            this.save_data_bttn.Click += new System.EventHandler(this.save_data_bttn_Click);
            // 
            // add_stud
            // 
            this.add_stud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add_stud.Location = new System.Drawing.Point(168, 19);
            this.add_stud.Name = "add_stud";
            this.add_stud.Size = new System.Drawing.Size(75, 21);
            this.add_stud.TabIndex = 8;
            this.add_stud.Text = "Добавить";
            this.add_stud.UseVisualStyleBackColor = true;
            this.add_stud.Click += new System.EventHandler(this.add_stud_Click);
            // 
            // checkBox_edit_grid
            // 
            this.checkBox_edit_grid.AutoSize = true;
            this.checkBox_edit_grid.Location = new System.Drawing.Point(143, 54);
            this.checkBox_edit_grid.Name = "checkBox_edit_grid";
            this.checkBox_edit_grid.Size = new System.Drawing.Size(15, 14);
            this.checkBox_edit_grid.TabIndex = 1;
            this.checkBox_edit_grid.UseVisualStyleBackColor = true;
            this.checkBox_edit_grid.CheckedChanged += new System.EventHandler(this.checkBox_edit_grid_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Редактирование списка:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_name_gr);
            this.groupBox1.Controls.Add(this.textBox_name_group);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.maskedTextBox_directions);
            this.groupBox1.Controls.Add(this.textBox_directions);
            this.groupBox1.Controls.Add(this.textBox_faculty);
            this.groupBox1.Controls.Add(this.years_add_bttn);
            this.groupBox1.Controls.Add(this.years_label);
            this.groupBox1.Controls.Add(this.directions_add_bttn);
            this.groupBox1.Controls.Add(this.dir_label);
            this.groupBox1.Controls.Add(this.faculty_add_bttn);
            this.groupBox1.Controls.Add(this.new_f_label);
            this.groupBox1.Controls.Add(this.maskedTextBox_groups);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.add_groups);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(628, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 157);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание объектов";
            // 
            // checkBox_name_gr
            // 
            this.checkBox_name_gr.AutoSize = true;
            this.checkBox_name_gr.Location = new System.Drawing.Point(409, 129);
            this.checkBox_name_gr.Name = "checkBox_name_gr";
            this.checkBox_name_gr.Size = new System.Drawing.Size(119, 17);
            this.checkBox_name_gr.TabIndex = 26;
            this.checkBox_name_gr.Text = "Создать название";
            this.checkBox_name_gr.UseVisualStyleBackColor = true;
            // 
            // textBox_name_group
            // 
            this.textBox_name_group.Location = new System.Drawing.Point(302, 126);
            this.textBox_name_group.Name = "textBox_name_group";
            this.textBox_name_group.Size = new System.Drawing.Size(100, 20);
            this.textBox_name_group.TabIndex = 25;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(382, 45);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(21, 20);
            this.maskedTextBox1.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Кол-во курсов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 22;
            // 
            // maskedTextBox_directions
            // 
            this.maskedTextBox_directions.Location = new System.Drawing.Point(104, 126);
            this.maskedTextBox_directions.Name = "maskedTextBox_directions";
            this.maskedTextBox_directions.Size = new System.Drawing.Size(21, 20);
            this.maskedTextBox_directions.TabIndex = 21;
            // 
            // textBox_directions
            // 
            this.textBox_directions.Location = new System.Drawing.Point(14, 100);
            this.textBox_directions.Name = "textBox_directions";
            this.textBox_directions.Size = new System.Drawing.Size(111, 20);
            this.textBox_directions.TabIndex = 20;
            // 
            // textBox_faculty
            // 
            this.textBox_faculty.Location = new System.Drawing.Point(12, 45);
            this.textBox_faculty.Name = "textBox_faculty";
            this.textBox_faculty.Size = new System.Drawing.Size(111, 20);
            this.textBox_faculty.TabIndex = 19;
            // 
            // years_add_bttn
            // 
            this.years_add_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.years_add_bttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.years_add_bttn.Location = new System.Drawing.Point(409, 45);
            this.years_add_bttn.Name = "years_add_bttn";
            this.years_add_bttn.Size = new System.Drawing.Size(114, 20);
            this.years_add_bttn.TabIndex = 18;
            this.years_add_bttn.Text = "Добавить курсы";
            this.years_add_bttn.UseVisualStyleBackColor = true;
            this.years_add_bttn.Click += new System.EventHandler(this.years_add_bttn_Click);
            // 
            // years_label
            // 
            this.years_label.AutoSize = true;
            this.years_label.Location = new System.Drawing.Point(299, 50);
            this.years_label.Name = "years_label";
            this.years_label.Size = new System.Drawing.Size(39, 13);
            this.years_label.TabIndex = 17;
            this.years_label.Text = "Курсы";
            // 
            // directions_add_bttn
            // 
            this.directions_add_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.directions_add_bttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.directions_add_bttn.Location = new System.Drawing.Point(131, 100);
            this.directions_add_bttn.Name = "directions_add_bttn";
            this.directions_add_bttn.Size = new System.Drawing.Size(137, 20);
            this.directions_add_bttn.TabIndex = 16;
            this.directions_add_bttn.Text = "Добавить направление";
            this.directions_add_bttn.UseVisualStyleBackColor = true;
            this.directions_add_bttn.Click += new System.EventHandler(this.directions_add_bttn_Click);
            // 
            // dir_label
            // 
            this.dir_label.AutoSize = true;
            this.dir_label.Location = new System.Drawing.Point(11, 78);
            this.dir_label.Name = "dir_label";
            this.dir_label.Size = new System.Drawing.Size(75, 13);
            this.dir_label.TabIndex = 15;
            this.dir_label.Text = "Направления";
            // 
            // faculty_add_bttn
            // 
            this.faculty_add_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.faculty_add_bttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.faculty_add_bttn.Location = new System.Drawing.Point(129, 45);
            this.faculty_add_bttn.Name = "faculty_add_bttn";
            this.faculty_add_bttn.Size = new System.Drawing.Size(139, 20);
            this.faculty_add_bttn.TabIndex = 14;
            this.faculty_add_bttn.Text = "Добавить факультет";
            this.faculty_add_bttn.UseVisualStyleBackColor = true;
            this.faculty_add_bttn.Click += new System.EventHandler(this.faculty_add_bttn_Click);
            // 
            // new_f_label
            // 
            this.new_f_label.AutoSize = true;
            this.new_f_label.Location = new System.Drawing.Point(9, 23);
            this.new_f_label.Name = "new_f_label";
            this.new_f_label.Size = new System.Drawing.Size(63, 13);
            this.new_f_label.TabIndex = 13;
            this.new_f_label.Text = "Факультет";
            // 
            // maskedTextBox_groups
            // 
            this.maskedTextBox_groups.Location = new System.Drawing.Point(388, 100);
            this.maskedTextBox_groups.Name = "maskedTextBox_groups";
            this.maskedTextBox_groups.Size = new System.Drawing.Size(15, 20);
            this.maskedTextBox_groups.TabIndex = 12;
            this.maskedTextBox_groups.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox_groups_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кол-во групп";
            // 
            // add_groups
            // 
            this.add_groups.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add_groups.Location = new System.Drawing.Point(409, 100);
            this.add_groups.Name = "add_groups";
            this.add_groups.Size = new System.Drawing.Size(114, 20);
            this.add_groups.TabIndex = 4;
            this.add_groups.Text = "Добавить группы";
            this.add_groups.UseVisualStyleBackColor = true;
            this.add_groups.Click += new System.EventHandler(this.add_groups_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(405, 33);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 15;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(278, 33);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 16;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(151, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(24, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 314);
            this.dataGridView1.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.вернутьсяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1187, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // вернутьсяToolStripMenuItem
            // 
            this.вернутьсяToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.вернутьсяToolStripMenuItem.Name = "вернутьсяToolStripMenuItem";
            this.вернутьсяToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.вернутьсяToolStripMenuItem.Text = "Вернуться";
            this.вернутьсяToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяToolStripMenuItem_Click);
            // 
            // AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1187, 416);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1203, 455);
            this.MinimumSize = new System.Drawing.Size(1203, 455);
            this.Name = "AddData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddData_FormClosing);
            this.Load += new System.EventHandler(this.AddData_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_gr;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.Label label_dir;
        private System.Windows.Forms.Label label_facult;
        private System.Windows.Forms.Button del_gr_bttn;
        private System.Windows.Forms.Button del_year_bttn;
        private System.Windows.Forms.Button del_dir_bttn;
        private System.Windows.Forms.Button del_fac_bttn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button del_bttn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_stud_count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_data_bttn;
        private System.Windows.Forms.Button add_stud;
        private System.Windows.Forms.CheckBox checkBox_edit_grid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_name_gr;
        private System.Windows.Forms.TextBox textBox_name_group;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_directions;
        private System.Windows.Forms.TextBox textBox_directions;
        private System.Windows.Forms.TextBox textBox_faculty;
        private System.Windows.Forms.Button years_add_bttn;
        private System.Windows.Forms.Label years_label;
        private System.Windows.Forms.Button directions_add_bttn;
        private System.Windows.Forms.Label dir_label;
        private System.Windows.Forms.Button faculty_add_bttn;
        private System.Windows.Forms.Label new_f_label;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_groups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_groups;
        public System.Windows.Forms.ComboBox comboBox4;
        public System.Windows.Forms.ComboBox comboBox3;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}