using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace EEPrep
{
    public partial class WelcomingScreen : Form 
    {
        private readonly QuestionController _questionController;

        public WelcomingScreen()
        {
            InitializeComponent();
            //MySqlDatabaseConnection db = new MySqlDatabaseConnection("EEPrep.DatabaseConnection");
            //MySqlDataProvider provider = new MySqlDataProvider(db);
            //_questionController = new QuestionController(provider);
            
        }

        public QuestionController QuestionController
        {
            get { return _questionController; }
        }

        /**
         * 
         */
        private void WelcomingScreen_Load(object sender, EventArgs e)
        {
            // call to get the questions from the db so this is the first time the program connects
            // to the database
            /*IEnumerable<Question> questions = QuestionController.GetQuestions();
            foreach (Question question in questions)
            {
                String value = question.QuestionText;
                Console.WriteLine(value);
            }*/
        }

        /**
         * 
         */
        private void StudentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLoginForm StudentLogin = new StudentLoginForm();
            StudentLogin.Show();
        }

       /**
        * 
        */
        private void aboutButton_Click(object sender, EventArgs e)
        {
            About_Screen about = new About_Screen();
            about.Show();
        }
    }
}
