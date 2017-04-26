using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEPrep
{
    public partial class QuestionForm : Form
    {
        private int count = 0;
        private int numQuestions = 0;
        private new List<char> ansChosen;
        private readonly QuestionController questionController;
        private readonly IDbDataProvider dataProvider;
        private Pager pager;
        //  private List<Question> questions;
        IEnumerable<Question> questions ;
        private Student Person;
        //private string choice;

        public QuestionForm(Student person)
        {
            InitializeComponent();
            Person = person;
            ClearBoxes();
            numTextBox.Text = "1";
                        // it takes the string for the provider name and looks for it 
            //in the app.config file
            this.dataProvider = new MySqlDataProvider(new MySqlDatabaseConnection());
            this.questionController = new QuestionController(dataProvider);
            questions = questionController.GetQuestions(Person.Topic);
            /* pager = new Pager()
             {
                 PageSize = 1, 
                 ItemCount = questions.Count,
                 PageIndex = 0
             };*/
            numQuestions = questions.Count<Question>();
        }
        
        /**
         * Purpose: Clears all the boxes on the question form
         */
        private void ClearBoxes()
        {
            
            numTextBox.Clear();
            QuestionTextBox.Clear();
            questionPictureBox.InitialImage = null;
            opALabel.Text = "";
            opBLabel.Text = "";
            opCLabel.Text = "";
            opDLabel.Text = "";
            opELabel.Text = "";
        }

        /**
         * 
         */

        private void quizLength()
        {
            // if the category choice is 
        }

        /**
         * Purpose: Shows the question and its related information on 
         * the question form.
         */
        private void ShowQuestion()
        {
            Question tempQues;
            tempQues = questions.ElementAt<Question>(count);
            QuestionTextBox.Text = "";
        }
        // TO DO : on the last question the next button displays "Submit"

        private void nextButton_Click(object sender, EventArgs e)
        {
           ClearBoxes();
           ShowQuestion();
        }
    }
}
