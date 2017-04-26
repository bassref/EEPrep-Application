using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEPrep
{
    public partial class AdminLoginForm : Form
    {
        //Variable Declarations
        bool login;
        private string username;
        private string password;

        public AdminLoginForm()
        {
            InitializeComponent();
        }

        public bool successLogin()
        {
            return login;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            string connectionString = 
                /*"Server = rephie0000.db.11668264.hostedresource.com;" + "Database = rephie0000;" + 
                            "Uid = rephie0000;" + "Pwd = E5th3rdb@w0rk";*/
            "Data Source=Reph; " +
                                "Initial Catalog=ExamQuestions;User ID=root;Password=bre@d&Chee3e";
            username = unameTextbox.Text;
            password = pWordTextbox.Text;

            string queryString = "SELECT* FROM Login WHERE Username = ' " + unameTextbox.Text + " ' and " +
                                            " Password = '" + pWordTextbox + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                MessageBox.Show("working");
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0}, {1}", reader[0], reader[1]));
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
        }

        private void validateSignIn()
        {
            
        }
    }
}
