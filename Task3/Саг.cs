namespace Task3
{
    internal class Car : Vehicle
    {
        public Car(int price, int year, int speed, string name) : base(price, year, speed, name)
        {
            
        }

        public new void Show()
        {
            base.Show();
        }
    }
}
