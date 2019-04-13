using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FanQuiz
{
    public partial class MainPage : ContentPage
    {
        List<Question> Questions = new List<Question>()
        {
            new Question("What's your favorite food?", "A) Something metal", "B) Pizza", "C) Anchovies", "D) Fish"),
            new Question("What do you do on a day off", "A) Drink a lot", "B) Watch old TV", "C) Molt", "D) Travel"),
            new Question("Where did you go to school?", "A) Bending college", "B) A high school, mostly", "C) You've eaten a school of fish", "D) The school you were assigned to"),
            new Question("What do you do best?", "A) Bending", "B) Nothing", "C) Molt more", "D) The bes pilot around"),
            new Question("What's your favorite holiday?", "A) Robonica", "B) TGIF", "C) Silent film festival...um day", "D) Labor day")
        };


        int As=0, Bs=0, Cs=0, Ds=0;
        int currentQuestionIndex=0;

        public MainPage()
        {
           
            InitializeComponent();
            RebindAll();


        }

        public void AnswerA(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            RebindAll();
            As++;
        }
        public void AnswerB(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            RebindAll();
            Bs++;
        }
        public void AnswerC(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            RebindAll();
            Cs++;
        }
        public void AnswerD(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            RebindAll();
            Ds++;
        }

        public void RebindAll()
        {
            if (currentQuestionIndex+1 > Questions.Count)
            {
                currentQuestionIndex = 0;
            }

            questionLabel.BindingContext = Questions[currentQuestionIndex];
            A.BindingContext = Questions[currentQuestionIndex];
            B.BindingContext = Questions[currentQuestionIndex];
            C.BindingContext = Questions[currentQuestionIndex];
            D.BindingContext = Questions[currentQuestionIndex];

            CheckForCharacter();

        }

        public void CheckForCharacter()
        {
            if(currentQuestionIndex == 4)
            {
                if(As >= Bs && As >= Cs && As >= Ds)
                {
                    Complete.Source = "bender.png";
                    
                    
                } else if (Bs >= As && Bs >= Cs && Bs >= Ds){
                    Complete.Source = "fry.png";
                } else if (Cs >= As && Cs >= Bs && Cs >= Ds){
                    Complete.Source = "zoidberg.jpg";
                } else {
                    Complete.Source = "leela.png";
                }
            }
        }
    }
}
