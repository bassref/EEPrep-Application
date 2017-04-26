/**
 * Sets up what a question is composed of.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEPrep
{
    public class Question
    {
        private string questiontext;
        private string optiona;
        private string optionb;
        private string optionc;
        private string optiond;
        private string optione;
        private char answer;
        private string topic;
        private string reason;

        public Question()
        {
            
        }

        public Question(Question temp)
        {
            temp.QuestionText = this.QuestionText;
            temp.OptionA = this.OptionA;
            temp.OptionB = this.OptionB;
            temp.OptionC = this.OptionC;
            temp.OptionD = this.OptionD;
            temp.OptionE = this.OptionE;
            temp.Answer = this.Answer;
            temp.Topic = this.Topic;
            temp.Reason = this.Reason;
        }
        public String QuestionText
        {
            get
            {
                return questiontext;
            }
            set
            {
                questiontext = value;
            }
        }
        public String OptionA {
            get
            {
                return optiona;
            }
            set
            {
                optiona = value;
            }
        }
        public String OptionB {
            get
            {
                return optionb;
            }
            set
            {
                optionb = value;
            }
        }
        public String OptionC {
            get
            {
                return optionc;
            }
            set
            {
                optionc = value;
            }
        }
        public String OptionD {
            get
            {
                return optiond;
            }
            set
            {
                optiond = value;
            }
        }
        public String OptionE {
            get
            {
                return optione;
            }
            set
            {
                optione = value;
            }
        }
        public Char Answer {
            get
            {
                return answer;
            }
            set
            {
                answer = value;
            }
        }
        public String Topic {
            get
            {
                return topic;
            }
            set
            {
                topic = value;
            }
        }
        public String Reason {
            get
            {
                return reason;
            }
            set
            {
                reason = value;
            }
        }

        
    }

}
