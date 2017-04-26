using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEPrep
{
    public partial class StudentLoginForm : Form
    {

        //Variable Declarations
        public bool catdone = false;
        private Student student;

        public Student Student
        {
            get
            {
                if (object.ReferenceEquals(student, null))
                {
                   student = new Student();
                }
                return student;
            }
            set { student = value; }

        }

        public StudentLoginForm()
        {
            InitializeComponent();
            
        }

       

        private void studentInfo()
        {
            Student person = new Student();
            person.Name = NameTextBox.Text;
            person.Email = EmailTextBox.Text;
        }

        private void StuLoginNextButton_Click(object sender, EventArgs e)
        {
            if ((NameTextBox.Text != "") && (EmailTextBox.Text != ""))
            {
                studentInfo();
                this.Hide();
                CategoryForm options = new CategoryForm(NameTextBox.Text, EmailTextBox.Text);
                options.Show();
                if (options.done())
                    catdone = true;
            }
            else
            {
                if (NameTextBox.Text == "")
                    MessageBox.Show("Please Enter A Name !","", MessageBoxButtons.OK);
                else if (EmailTextBox.Text == "")
                    MessageBox.Show("Please Enter An E-mail !", "", MessageBoxButtons.OK);
            }
        }
    }
 }

