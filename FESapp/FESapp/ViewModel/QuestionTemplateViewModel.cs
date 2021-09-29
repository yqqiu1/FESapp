using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using FESapp.FormsVideoLibrary;

namespace FESapp.ViewModel
{
    public class QuestionTemplateViewModel : View, INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;

        private int questionIndex;
        private int numQuestions;
        private bool answer;
        private string question;
        private string answerA;
        private string answerB;
        private string answerC;
        private string answerD;
        public QuizModel quiz { get; }


        public QuestionTemplateViewModel(QuizModel quiz)
        {
            //grabbing data from page
            this.quiz = quiz;

            //initialising commands which allows for button presses to be registered
            ButtonA = new Command(incrementQuestions);
            ButtonB = new Command(incrementQuestions);
            ButtonC = new Command(incrementQuestions);
            ButtonD = new Command(incrementQuestions);

            //setting answer boolean to false because we're answering a question, not showing answer yet
            answer = true;

            //initialising how many questions in quiz in total to avoid over indexing
            numQuestions = quiz.quizzes.Count;

            //setting initial question index to 0
            questionIndex = 0;

            //initialising first question and answers
            updateQuestionAnswer();
        }

        //called everytime a button is pressed. Increments question by 1 if possible
        public async void incrementQuestions()
        {
            //display next question
            if (!answer)
            {          
                //are there more questions to be answered?
                if (questionIndex < numQuestions-1)
                {
                    //increment question index by one and update view to new questions
                    questionIndex++;

                    //update information to be displayed in the question and answer fields
                    updateQuestionAnswer();

                    //refresh page to display new data
                    updateView();

                    //set answer variable to true so it'll display answer once button is clicked
                    answer = true;
                }
                else
                {
                    await Navigation.PopModalAsync();
                }
            }

            //user just answered a question, need to display answer
            else
            {
                question = quiz.quizzes[questionIndex].correctAnswer;
                updateView();
                //set answer variable to false so it'll display question next
                answer = false;
            }
        }

        public void updateView()
        {
            OnPropertyChanged(nameof(Question));
            OnPropertyChanged(nameof(AnswerA));
            OnPropertyChanged(nameof(AnswerB));
            OnPropertyChanged(nameof(AnswerC));
            OnPropertyChanged(nameof(AnswerD));
        }

        public void updateQuestionAnswer()
        {
            question = quiz.quizzes[questionIndex].question;
            answerA = quiz.quizzes[questionIndex].answerA;
            answerB = quiz.quizzes[questionIndex].answerB;
            answerC = quiz.quizzes[questionIndex].answerC;
            answerD = quiz.quizzes[questionIndex].answerD;
        }

        //button commands
        public ICommand ButtonA { get; set; }
        public ICommand ButtonB { get; set; }
        public ICommand ButtonC { get; set; }
        public ICommand ButtonD { get; set; }

        //changes the question and answer strings
        public string Question => question;
        public string AnswerA => answerA;
        public string AnswerB => answerB;
        public string AnswerC => answerC;
        public string AnswerD => answerD;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
