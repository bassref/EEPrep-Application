using System;
using System.Collections;
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
    public partial class CategoryForm : Form
    {
        ArrayList Topics = new ArrayList();
        int quesChoice;
        int numQuestions;
        bool click = false;
        private bool randomQuestions;
        private RadioButton[] catChoice;
        Student Person = new Student();

        
        

        public CategoryForm(string name,string email)
        {
            Person.Name = name;
            Person.Email = email;
            
            InitializeComponent();
            catChoice = new RadioButton[] {algorithmsRB, discreteRB, infoManRB, progRB, softEngRB, systemsRB,
                        otherRB, randQuesOneRB, randQuesTwoRB  };
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
         

            foreach ( RadioButton rb in TopicGroupBox.Controls)
            {
                if(rb.Checked)
                    Person.Topic = rb.Text;
            }
            this.Hide();
            QuestionForm test = new QuestionForm(Person);
            test.Show();
        }

        public string PickOption(int quesChoice)
        {
            switch (quesChoice)
            {
                case 0:
                    QuestionCat = "Algorithms and Complexity";
                    numQuestions = 30;
                    break;
                case 1:
                    QuestionCat = "Discrete Structures";
                    numQuestions = 30;
                    break;
                case 2:
                    QuestionCat = "Information Management";
                    numQuestions = 30;
                    break;
                case 3:
                    QuestionCat = "Programming";
                    numQuestions = 30;
                    break;
                case 4:
                    QuestionCat = "Software Engineering";
                    numQuestions = 30;
                    break;
                case 5:
                    QuestionCat = "Systems";
                    numQuestions = 30;
                    break;
                case 6:
                    QuestionCat = "Other";
                    numQuestions = 30;
                    break;
                case 7:
                    QuestionCat = "25 questions";
                    numQuestions = 25;
                    break;
                case 8:
                    QuestionCat = "40 questions";
                    numQuestions = 40;
                    break;
            }
            return QuestionCat;
        }

        public String QuestionCat
        {get; set; }

        public int QNum()
        {
            int questions =0;
            return questions;
        }
        public bool done()
        {
            return click;
        }

        
    }
}
