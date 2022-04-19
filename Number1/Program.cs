using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Human[] myTest = new Human[10];

            myTest[0] = new Student("Zadok", ProgramType.Backend);
            myTest[1] = new Student("James", ProgramType.Backend);
            myTest[2] = new Facilitator("Sam", ProgramType.Frontend);
            myTest[3] = new Student("Sadok", ProgramType.Backend);
            myTest[4] = new Student("Amek", ProgramType.Backend);
            myTest[5] = new Facilitator("Pamila", ProgramType.Frontend);
            myTest[6] = new Student("Nimi", ProgramType.Backend);
            myTest[7] = new Student("Josh", ProgramType.Backend);
            myTest[8] = new Facilitator("Edem", ProgramType.Frontend);
            myTest[9] = new Facilitator("Desmond", ProgramType.Backend);

            myTest[0].AttendClass(DaysOfWeek.Saturday);
        }
    }
}
