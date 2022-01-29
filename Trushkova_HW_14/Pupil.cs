
namespace Trushkova_HW_14
{
    internal class Pupil
    {
        //Тип ученика
        public virtual string Type { get { return "Обычный ученик"; } }

        public virtual void Study()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Просто учится.");
        }
        public virtual void Read()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Просто читает.");
        }
        public virtual void Write()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Просто пишет.");
        }
        public virtual void Relax()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Просто отдыхает.");
        }
    }
}
