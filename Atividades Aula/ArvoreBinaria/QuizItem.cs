using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinaria
{
    public class QuizItem
    {
        public string Text { get; set; }
        public QuizItem(string text) => Text = text;
    }
}
