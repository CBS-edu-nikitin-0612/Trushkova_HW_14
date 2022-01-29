

namespace Trushkova_HW_14
{
    internal class ExcelentPupil : Pupil
    {
        public override string Type { get { return "Отличник"; } }
        public override void Study()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Отлично учится.");
        }
        public override void Read()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Отлично читает.");
        }
        public override void Write()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Отлично пишет.");
        }
        public override void Relax()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Плохо отдыхает.");
        }
    }
}
