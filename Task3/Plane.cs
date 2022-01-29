namespace Task3
{
    internal class Plane : Vehicle
    {
        //Высота в км
        private int _height;
        
        private int _countOfPassangers;

        public Plane(int price, int year, int speed, string name) : base(price, year, speed, name)
        {

        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public int CountOfPassangers
        {
            get { return _countOfPassangers; }

            set { _countOfPassangers = value; }
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine($"Вместимость - {this.CountOfPassangers} пассажиров.");
            Console.WriteLine($"Находится на высоте {this.Height} км.");
        }
    }
}
