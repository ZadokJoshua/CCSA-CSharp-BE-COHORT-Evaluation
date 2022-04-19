using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CCLAcademy
{
    class Student : Human, IQuestionFaciliator, IQuestionStudent, IAnswer
    {
        public ProgramType MyProgram { get; set; }
        public Student(string name, ProgramType program)
        {
            MyProgram = program;
        }
        public override void AttendClass(DaysOfWeek classDay)
        {
            if((classDay == DaysOfWeek.Tuesday || classDay == DaysOfWeek.Monday || classDay == DaysOfWeek.Thursday) && MyProgram == ProgramType.Backend)
            {
                Console.WriteLine("\tThe host will let you in shortly");
                Thread.Sleep(5000);
                Console.WriteLine("\tYou’re in!");
            }
            else if ((classDay == DaysOfWeek.Tuesday || classDay == DaysOfWeek.Wednesday || classDay == DaysOfWeek.Thursday) && MyProgram == ProgramType.Frontend)
            {
                Console.WriteLine("\tThe host will let you in shortly");
                Thread.Sleep(5000);
                Console.WriteLine("\tYou’re in!");
            }
            else
            {
                Console.WriteLine("\tNo class today");
            }
        }

        public void AnswerExplanation()
        {
            Console.WriteLine("My answer to your question is..."); ;
        }
    }
}
