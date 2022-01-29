
namespace Trushkova_HW_14
{
    internal class ClassRoom
    {
        private Pupil[] classroom = new Pupil[4];
        public ClassRoom()
        {
            for (int i = 0; i < 4; i++)
            {
                classroom[i] = new Pupil();
            }
        }

        public ClassRoom(Pupil[] pupils)
        {
            this.classroom = pupils;
        }

        public ClassRoom(Pupil pupil1) : this()

        {
            this.classroom[0] = pupil1;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2) : this(pupil1)

        {
            this.classroom[1] = pupil2;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3) : this(pupil1, pupil2)

        {
            this.classroom[2] = pupil3;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4) : this(pupil1, pupil2, pupil3)

        {
            this.classroom[3] = pupil4;
        }

        public Pupil this[int index]
        {
            get { return this.classroom[index]; }
            set { this.classroom[index] = value; }
        }

        //Вывод на экран всех учеников с перечислением всех поведений
        public void Show()
        {
            if (classroom != null)
            {
                for (int i = 0; i < classroom.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"Ученик {i + 1} - это {classroom[i].Type}");
                    classroom[i].Study();
                    classroom[i].Write();
                    classroom[i].Read();
                    classroom[i].Relax();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Класс еще не набран!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
