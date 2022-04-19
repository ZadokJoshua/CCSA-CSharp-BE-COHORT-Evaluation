using System;

namespace CCLAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
         _____  _____  _        ___  _____   ___ ______ ________  ____   __
        /  __ \/  __ \| |      / _ \/  __ \ / _ \|  _  \  ___|  \/  \ \ / /
        | /  \/| /  \/| |     / /_\ \ /  \// /_\ \ | | | |__ | .  . |\ V / 
        | |    | |    | |     |  _  | |    |  _  | | | |  __|| |\/| | \ /  
        | \__/\| \__/\| |____ | | | | \__/\| | | | |/ /| |___| |  | | | |  
         \____/ \____/\_____/ \_| |_/\____/\_| |_/___/ \____/\_|  |_/ \_/  
            ");

            Human[] myTest = new Human[10];

            myTest[0] = new Student("Zadok", ProgramType.Backend);
            myTest[1] = new Student("James", ProgramType.Frontend);
            myTest[2] = new Student("Tsado", ProgramType.Backend);
            myTest[3] = new Student("Amek", ProgramType.Backend);
            myTest[4] = new Student("Nimi", ProgramType.Frontend);
            myTest[5] = new Student("Josh", ProgramType.Backend);

            myTest[6] = new Facilitator("Edem", ProgramType.Frontend);
            myTest[7] = new Facilitator("Desmond", ProgramType.Backend);
            myTest[8] = new Facilitator("Pamila", ProgramType.Frontend);
            myTest[9] = new Facilitator("Sam", ProgramType.Frontend);

            for (int i = 0; i < myTest.Length; i++)
            {
                Console.WriteLine("\t-------------------------------");
                Console.WriteLine($"\tOn {DaysOfWeek.Monday}...");
                myTest[i].AttendClass(DaysOfWeek.Monday);

                Console.WriteLine($"\t...and on {DaysOfWeek.Wednesday}");
                myTest[i].AttendClass(DaysOfWeek.Wednesday);
                Console.WriteLine("\t-------------------------------");
            }
        }
    }
}
