using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesiQuizManagerClientHosted.Shared
{
    public class QuizItem
    {
        public QuizItem()
        {
            Choices = new List<string>();
        }
        public string Question { get; set; }
        public List<String> Choices { get; set; }
        public int AnswerIndex { get; set; }
        public int Score { get; set; }
    }
}
