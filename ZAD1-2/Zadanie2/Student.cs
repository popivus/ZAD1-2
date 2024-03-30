namespace ZAD1_2.Zadanie2
{
    public class Student
    {
        public Student(string name, int age, float grade) => Set(name, age, grade);

        private string _name;
        private int _age;
        private float _grade;

        public string GetName() => _name;
        public int GetAge() => _age;
        public float GetGrade() => _grade;

        public void SetName(string name) => _name = name;
        public void SetAge(int age)
        {
            if (age <= 0)
                throw new ArgumentException("Возраст не может быть меньше или равен 0");

            _age = age;
        }
        public void SetGrade(float grade)
        {
            if (grade <= 0)
                throw new ArgumentException("Рейтинг не может быть меньше или равен 0");

            _grade = grade;
        }

        public void Set(string name, int age, float grade)
        {
            SetName(name);
            SetAge(age);
            SetGrade(grade);
        }

        public void Show()
        {
            Console.WriteLine($"Студент {_name}");
            Console.WriteLine($"Возраст: {_age}");
            Console.WriteLine($"Рейтинг: {_grade}");
            Console.WriteLine();
        }
    }
}
