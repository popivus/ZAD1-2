namespace ZAD1_2.Zadanie1
{
    public class Zadanie1
    {
        public void Go()
        {
            //ЗАДАНИЕ 01
            Console.WriteLine("ЗАДАНИЕ 01");

            decimal x = GetDecimalFromKeyboard("Введите корректно первую сторону прямоугольника (> 0): ");
            decimal y = GetDecimalFromKeyboard("Введите корректно вторую сторону прямоугольника (> 0): ");

            Rectangle rectangle = new(x, y);

            Console.WriteLine($"Первая сторона прямоугольника = {rectangle.X}");
            Console.WriteLine($"Вторая сторона прямоугольника = {rectangle.Y}");
            Console.WriteLine($"Площадь прямоугольника = {rectangle.GetArea()}");
            Console.WriteLine();


            //ЗАДАНИЕ 01а
            Console.WriteLine("ЗАДАНИЕ 01а");

            int rectangleCount = 0;
            while (rectangleCount < 1 || rectangleCount > 10)
                rectangleCount = GetIntFromKeyboard("Введите корректное количество прямоугольников: ");

            Rectangle[] rectangles = new Rectangle[rectangleCount];
            for (int i = 0; i < rectangleCount; i++)
            {
                Console.WriteLine($"Прямоугольник №{i + 1}");
                decimal x1 = GetDecimalFromKeyboard("Введите корректно первую сторону прямоугольника (> 0): ");
                decimal y1 = GetDecimalFromKeyboard("Введите корректно вторую сторону прямоугольника (> 0): ");
                rectangles[i] = new Rectangle(x1, y1);

                Console.WriteLine();
            }
        }

        private decimal GetDecimalFromKeyboard(string message)
        {
            string? str;
            decimal number;
            do
            {
                Console.Write(message);
                str = Console.ReadLine();
            }
            while (!decimal.TryParse(str, out number) || number <= 0);

            return number;
        }

        private int GetIntFromKeyboard(string message)
        {
            string? str;
            int number;
            do
            {
                Console.Write(message);
                str = Console.ReadLine();
            }
            while (!int.TryParse(str, out number) || number <= 0);

            return number;
        }
    }
}
