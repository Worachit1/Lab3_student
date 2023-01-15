namespace Lab_OOP_03
{
    public partial class Form1 : Form
    {
        //array <--> List
        List<Student> _students = new List<Student>();
        // max min grade 
        double maxIgrade = 0;
        double minIgrade = int.MaxValue;
        int numStudent = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //get value form texbox
            String name = this.TextBoxname.Text;
            String id = this.TextBoxID.Text;
            String year = this.TextBoxbirthyear.Text;
            String hight = this.TextBoxhight.Text;
            String grade = this.TextBoxgrade.Text;
            String branch = this.TextBoxbranch.Text;

            //convert string to in
            int iYear = Int32.Parse(year);
            int iHight = Int32.Parse(hight);
            double iGrade = Double.Parse(grade);

            //create obj form student
            Student newStudent = new Student(name, id , iYear , iHight , iGrade , branch);
            //add new student to list
            this._students.Add(newStudent);

            //cal max min
            if(iGrade>maxIgrade)
            {
                maxIgrade = iGrade;
            }
            if(iGrade<minIgrade)
            {
                minIgrade = iGrade;
            }

            //cal num Student
            numStudent = numStudent+1;
     
            //clear textbox
            this.TextBoxname.Text = "";
            this.TextBoxID.Text = "";
            this.TextBoxbirthyear.Text = "";
            this.TextBoxhight.Text = "";
            this.TextBoxgrade.Text = "";
            this.TextBoxbranch.Text = "";
            this.maxgrade.Text = "";
            this.mingrade.Text = "";
            this.sumstudent.Text = "";

            //show max min grade
            this.maxgrade.Text = this.maxgrade.Text + maxIgrade;
            this.mingrade.Text = this.mingrade.Text + minIgrade;

            //show num Stdent
            this.sumstudent.Text = this.sumstudent.Text + numStudent;

            //add data to DataGridView
            BindingSource source = new BindingSource();
            source.DataSource = this._students;
            this.dataGridView1.DataSource = source;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear textbox
            this.TextBoxname.Text = "";
            this.TextBoxID.Text = "";
            this.TextBoxbirthyear.Text = "";
            this.TextBoxhight.Text = "";
            this.TextBoxgrade.Text = "";
            this.TextBoxbranch.Text = "";
        }
    }
}