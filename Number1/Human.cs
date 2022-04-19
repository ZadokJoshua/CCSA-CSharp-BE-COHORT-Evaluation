using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLAcademy
{
    class Human
    {
        public string Name { get; set; }
        public string Program { get; set; }

        public virtual string AskQuestion()
        {
            return "Excuse me! I have a question...";
        }

        public virtual string AnswerQuestion()
        {
            return "The answer to your question is...";
        }

        public virtual void AttendClass(DaysOfWeek classDay)
        {

        }
    }
}
