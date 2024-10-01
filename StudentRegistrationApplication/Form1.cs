namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            string firstName = textBox2.Text;
            string lastName = textBox1.Text;
            string middleName = textBox3.Text;
            string gender = checkBox1.Checked ? "Male" : "Female";
            string dateOfBirth = $"{comboBox1.Text}/{comboBox2.Text}/{comboBox3.Text}";
            string program = comboBox4.Text;


            if (!string.IsNullOrEmpty(dateOfBirth) )
            {
                if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
                {

                    DisplayStudentInfo(firstName, lastName, gender, dateOfBirth, program);
                }
                if (!string.IsNullOrEmpty(dateOfBirth))
                {

                    DisplayStudentInfo(firstName, lastName, gender, dateOfBirth, program);
                }
                else
                {

                    DisplayStudentInfo(firstName, lastName, gender, program);
                }
            }
        }

        private void DisplayStudentInfo(string firstName, string lastName)
        {
            MessageBox.Show($"Student Name: {firstName} {lastName}");
        }


        private void DisplayStudentInfo(string firstName, string lastName, string gender)
        {
            MessageBox.Show($"Student Name: {firstName} {lastName}\nGender: {gender}");
        }


        private void DisplayStudentInfo(string firstName, string lastName, string gender, string dateOfBirth)
        {
            MessageBox.Show($"Student Name: {firstName} {lastName}\nGender: {gender}\nDate of Birth: {dateOfBirth}");
        }

        private void DisplayStudentInfo(string firstName, string lastName, string gender, string dateOfBirth, string program)
        {
            MessageBox.Show($"Student Name: {firstName} {lastName}\nGender: {gender}\nDate of Birth: {dateOfBirth}\nProgram: {program}");
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.Filter = "Bitmaps |*.bmp|JPGs|*.jpg|GIFs|*.gif|All files|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.FileName = "";


            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != string.Empty)
                pictureBox1.Load(openFileDialog1.FileName);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

