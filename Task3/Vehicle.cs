namespace Task3
{
    internal class Vehicle
    {
        //Стоимость в долларах
        private readonly int _price;
        //Скорость в км/ч
        private readonly int _speed;
        private readonly int _year;
        //Координаты х и у в метрах
        private int _x;
        private int _y;
        private readonly string _name;

        public Vehicle (int price, int year, int speed, string name)
        {
            _price = price;
            _year = year;
            _speed = speed;
            _name = name;
        }

        public Vehicle()
        {
            _name = "Средство передвижения";
        }
        
        public string Name
        {
            get { return _name; }            
        }

        public int Price
        {
            get { return _price; }            
        }

        public int Speed
        {
            get { return _speed;  }          
        }

        public int Year
        {
            get { return _year; }            
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        protected void Show()
        {
            Console.WriteLine($"Это {this.Name} стоимостью {this.Price} долларов, " +
                $"максимальная скорость {this.Speed} км/ч, " +
                $"{this.Year} года производства.");            
            Console.WriteLine($"{this.Name} можно найти по координатам {this.X} {this.Y}");
        }    
    }
}
