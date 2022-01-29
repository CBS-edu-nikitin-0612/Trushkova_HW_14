
namespace Trushkova_HW_14
{
    internal class GoodPupil : Pupil
    {
        public override string Type { get { return "Хорошист"; } }
        public override void Study()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Хорошо учится.");
        }
        public override void Read()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Хорошо читает.");
        }
        public override void Write()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Хорошо пишет.");
        }
        public override void Relax()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Хорошо отдыхает.");
        }
    }
}
