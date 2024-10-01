namespace StudentRegistrationApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 6);
            label1.Name = "label1";
            label1.Size = new Size(264, 23);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 38);
            label2.Name = "label2";
            label2.Size = new Size(86, 16);
            label2.TabIndex = 1;
            label2.Text = "Last Name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 86);
            label3.Name = "label3";
            label3.Size = new Size(86, 16);
            label3.TabIndex = 2;
            label3.Text = "First Name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 140);
            label4.Name = "label4";
            label4.Size = new Size(99, 16);
            label4.TabIndex = 3;
            label4.Text = "Middle Name *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 196);
            label5.Name = "label5";
            label5.Size = new Size(65, 16);
            label5.TabIndex = 4;
            label5.Text = "Gender *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 224);
            label6.Name = "label6";
            label6.Size = new Size(102, 16);
            label6.TabIndex = 5;
            label6.Text = "Date of birth *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 287);
            label7.Name = "label7";
            label7.Size = new Size(131, 16);
            label7.TabIndex = 6;
            label7.Text = "Program to apply *";
            label7.Click += label7_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 22);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 22);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(16, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 22);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(84, 197);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(54, 18);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Male";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(140, 198);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(67, 18);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "Female";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBox1.Location = new Point(16, 251);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(66, 22);
            comboBox1.TabIndex = 12;
            comboBox1.Text = "-Day-";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "January ", "February", "March", "April", "May", "June", "July", "August ", "September", "October", "November", "December" });
            comboBox2.Location = new Point(89, 252);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(106, 22);
            comboBox2.TabIndex = 13;
            comboBox2.Text = "-Month-";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1901", "1902", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024" });
            comboBox3.Location = new Point(202, 252);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(97, 22);
            comboBox3.TabIndex = 14;
            comboBox3.Text = "-Year-";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Bachelor of Architecture (B.Arch.)", "Bachelor of Arts (B.A.)", "Bachelor of Business (B.B.)", "Bachelor of Business Administration (B.B.A.)", "Bachelor of Science in Business (B.S.B.)", "Bachelor of Canon Law (B.C.L.)", "Bachelor of Computer Science (B.C.S.)", "Bachelor of Science in Computer Science (B.S.C.S.)", "Bachelor of Criminal Justice (B.C.J.)", "Bachelor of Science in Criminal Justice (B.S.C.J.)", "Bachelor of Divinity (B.D.)", "Bachelor of Education (B.Ed.)", "Bachelor of Science in Education (B.S.Ed.)", "Bachelor of Wireless Engineering (B.W.E.)", "Bachelor of Engineering (B.E./B.Eng.)", "Bachelor of Science in Engineering (B.S.E./B.S.EN.)", "Bachelor of Science in Aerospace Engineering (B.S.A.E.)", "Bachelor of Science in Agricultural Engineering (B.S.A.E.)", "Bachelor of Science in Biological Systems (B.S.B.S.)", "Bachelor of Science in Biosystems and Agricultural Engineering (B.S.B.A.E.)", "Bachelor of Science in Biological Engineering (B.S.B.E.)", "Bachelor of Biomedical Engineering (B.B.m.E.)", "Bachelor of Science in Biomedical Engineering (B.S.B.E./B.S.B.M.E.)", "Bachelor of Science in Chemical Engineering (B.S.Ch.E.)", "Bachelor of Science in Chemical and Biomolecular Engineering (B.S.Ch.B.E.)", "Bachelor of Science in Chemical and Materials Engineering (B.S.C.M.E.)", "Bachelor of Civil Engineering (B.C.E.)", "Bachelor of Science in Civil Engineering (B.S.C.E.)", "Bachelor of Science in Civil and Infrastructure Engineering (B.S.-C.I.E.)", "Bachelor of Computer Engineering (B.Comp.E.)", "Bachelor of Science in Computer Engineering (B.S.C.E./B.S.Cmp.E.)", "Bachelor of Science in Computer Science and Engineering (B.S.C.S.E.)", "Bachelor of Science in Electrical and Computer Engineering (B.S.E.C.E.)", "Bachelor of Electrical Engineering (B.E.E.)", "Bachelor of Science in Electrical Engineering (B.S.E.E.)", "Bachelor of Science in Engineering Management (B.S.E.Mgt.)", "Bachelor of Science in Environmental Engineering (B.S.En.E./B.S.Env.E.)", "Bachelor of Fiber Engineering (B.F.E.)", "Bachelor of Science in Industrial Engineering (B.S.I.E.)", "Bachelor of Science in Manufacturing Engineering (B.S.Mfg.E.)", "Bachelor of Science in Manufacturing Systems Engineering (B.S.M.S.E.)", "Bachelor of Science in Materials Science and Engineering (B.S.M.S.E.)", "Bachelor of Science in Materials Engineering (B.S.MA.E.)", "Bachelor of Mechanical Engineering (B.M.E.)", "Bachelor of Science in Mechanical Engineering (B.S.M.E.)", "Bachelor of Science in Metallurgical Engineering (B.S.Mt.E.)", "Bachelor of Science in Mining Engineering (B.S.MI.E.)", "Bachelor of Science in Systems (B.S.-SYST.)", "Bachelor of Software Engineering (B.S.W.E.)", "Bachelor of Science in Software Engineering (B.S.S.E.)", "Bachelor of Systems Engineering (B.S.E.)", "Bachelor of Science in Systems Engineering (B.S.S.E.)", "Bachelor of Engineering Technology (B.E.T.)", "Bachelor of Science in Engineering Technology (B.S.E.T.)", "Bachelor of Science in Civil Engineering Technology (B.S.C.E.T./B.S.Civ.E.T.)", "Bachelor of Science in Computer Engineering Technology (B.S.C.E.T.)", "Bachelor of Science in Construction Engineering Technology (B.S.Con.E.T.)", "Bachelor of Science in Drafting Design Technology (B.S.D.D.T.)", "Bachelor of Science in Electrical/Electronics Technology (B.S.E.T.)", "Bachelor of Science in Electrical Engineering Technology (B.S.E.E.T.)", "Bachelor of Science in Electro-Mechanical Engineering Technology (B.S.E.M.E.T.)", "Bachelor of Science in Mechanical Engineering Technology (B.S.M.E.T.)", "Bachelor of Fine Arts (B.F.A.)", "Bachelor of Forestry (B.F.)", "Bachelor of Science in Forest Research (B.S.For.Res.)", "Bachelor of Hebrew Letters (B.H.L.)", "Bachelor of Journalism (B.J.)", "Bachelor of Laws (LL.B.)", "Bachelor of Liberal Studies (B.L.S.)", "Bachelor of Literature (B.Lit.)", "Bachelor of Marine Science (B.M.S.)", "Bachelor of Music (B.M.)", "Bachelor of Nursing (B.N.)", "Bachelor of Science in Nursing (B.S.N.)", "Bachelor of Pharmacy (B.Pharm.)", "Bachelor of Philosophy (B.Phil.)", "Bachelor of Religious Education (B.R.E.)", "Bachelor of Science (B.S.)", "Bachelor of Science in Chemistry (B.S.Ch.)", "Bachelor of Technology (B.T./B.Tech.)" });
            comboBox4.Location = new Point(15, 305);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(284, 22);
            comboBox4.TabIndex = 15;
            comboBox4.Text = "-Select program-";
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(303, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 177);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(14, 342);
            button1.Name = "button1";
            button1.Size = new Size(137, 27);
            button1.TabIndex = 17;
            button1.Text = "Register Student";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(363, 224);
            button2.Name = "button2";
            button2.Size = new Size(82, 27);
            button2.TabIndex = 18;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(533, 390);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Student Registration";
            TransparencyKey = Color.Gainsboro;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
