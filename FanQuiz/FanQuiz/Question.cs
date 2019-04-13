using System;
using System.Collections.Generic;
using System.Text;

namespace FanQuiz
{
    class Question
    {
        public string BaseQuestion { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }

        public Question(string bq, string a, string b, string c, string d)
        {
            BaseQuestion = bq;
            AnswerA = a;
            AnswerB = b;
            AnswerC = c;
            AnswerD = d;
        }

    }
}
