namespace Task3
{
    internal class Ship : Vehicle
    {
        private int _countOfPassangers;
        private int _portID;

        public Ship(int price, int year, int speed, string name) : base(price, year, speed, name)
        {

        }

        public int CountOfPassangers
        {
            get { return _countOfPassangers; }
            set { _countOfPassangers = value; }
        }

        public int PortID
        {
            get { return _portID; }
            set { _portID = value; }
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine($"Прикреплен к порту {this.PortID}.");
            Console.WriteLine($"Вместимость - {this.CountOfPassangers} пассажиров.");            
        }
    }
}
