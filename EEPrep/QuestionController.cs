/**
 * Executes a query on the database to retrieve all the questions and store in an array list
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Remoting.Messaging;

namespace EEPrep
{
    public class QuestionController
    {
        private IDbDataProvider provider;

        public QuestionController(IDbDataProvider provider)
        {
            this.provider = provider;
        }
        
        public IDbDataProvider DbProvider => provider;
        
        public IEnumerable<Question> GetQuestions(string topic)
        {
            IDataReader dataReader = provider.ExecuteReader("SELECT * FROM rephie0000.ExamPrepQues Where Topic = '" +topic +"';");
            IEnumerable<Question> results = new List<Question>();
           //TODO Figure out how to Clear the list
            // results.Question.Clear();
            while (dataReader.Read())
            {
                (results as List<Question>).Add(GetQuestion(dataReader));
            }
            dataReader.Close();
            return results;
        }

        private Question GetQuestion(IDataReader dataReader)
        {
            Question Result = new Question();
            Result.QuestionText = Convert.ToString(dataReader["Question"]);
            Result.OptionA = Convert.ToString(dataReader["OptionA"]);
            Result.OptionB = Convert.ToString(dataReader["OptionB"]);
            Result.OptionC = Convert.ToString(dataReader["OptionC"]);
            Result.OptionD = Convert.ToString(dataReader["OptionD"]);
            Result.OptionE = Convert.ToString(dataReader["OptionE"]);
            Result.Answer = Convert.ToChar(dataReader["Answer"]);
            Result.Topic = Convert.ToString(dataReader["Topic"]);
            Result.Reason = Convert.ToString(dataReader["Reason"]);
            return Result;
        }

        public Question Result { get; set; }
        public Question AccessQuestion ()
        {
            return Result;
        }
    }
}