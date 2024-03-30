namespace ZAD1_2.Zadanie2
{
    public class Zadanie2
    {
        public void Go()
        {
            //ЗАДАНИЕ 02
            Console.WriteLine("ЗАДАНИЕ 02");

            int countStudents = GetIntFromKeyboard("Введите корректное количество студентов: ");

            List<Student> students = new();

            for (int i = 0; i < countStudents; i++)
            {
                Console.WriteLine($"Заполнение студента №{i + 1}");
                Console.WriteLine();

                string name = GetStringFromKeyboard("Введите имя студента: ");
                int age = GetIntFromKeyboard("Введите возраст студента: ");
                float grade = GetFloatFromKeyboard("Введите рейтинг студента: ");

                students.Add(new Student(name, age, grade));

                Console.WriteLine();
            }

            Console.WriteLine();

            foreach (Student student in students)
            {
                Console.WriteLine($"Студент {student.GetName()}");
                Console.WriteLine($"Его возраст {student.GetAge()}");
                Console.WriteLine($"Его рейтинг {student.GetGrade()}");
                Console.WriteLine();
            }
        }


        private string GetStringFromKeyboard(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        private float GetFloatFromKeyboard(string message)
        {
            string? str;
            float number;
            do
            {
                Console.Write(message);
                str = Console.ReadLine();
            }
            while (!float.TryParse(str, out number) || number <= 0);

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
