

namespace Trushkova_HW_14
{
    internal class BadPupil : Pupil
    {  
        public override string Type { get { return "Двоичник"; } }

        public override void Study()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Плохо учится.");
        }
        public override void Read()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Плохо читает.");
        }
        public override void Write()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Плохо пишет.");
        }
        public override void Relax()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Отлично отдыхает.");
        }
    }
}
