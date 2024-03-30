namespace ZAD1_2.Zadanie1
{
    public class Rectangle
    {
        public Rectangle(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }

        private decimal _x;
        public decimal X
        {
            get => _x;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Сторона прямоугольника не может быть меньше 0");

                _x = value;
            }
        }

        private decimal _y;
        public decimal Y
        {
            get => _y;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Сторона прямоугольника не может быть меньше 0");

                _y = value;
            }
        }

        public decimal GetArea() => X * Y;
    }
}
