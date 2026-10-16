PrintHeader();
PrintHeader();
System.Console.WriteLine("Основная часть программы");
PrintFooter();

void PrintHeader()
{
    System.Console.WriteLine("^_^");
    System.Console.WriteLine("Лабораторная работа №13");
    System.Console.WriteLine("0_0");
    System.Console.WriteLine("Дата формирования отчета: 16.10.2026");
}

void PrintFooter()
{
    System.Console.WriteLine(">_<");
    System.Console.WriteLine("Конец программы");
    System.Console.WriteLine("X_X");
}

void PrintStudentCard(string name, int age, int group)
{
    System.Console.WriteLine($"Студент: {name}, возраст: {age}, номер группы: {group}");
}

PrintStudentCard("Егор", 18,251);
PrintStudentCard("Валерия", 17, 233);

double CalculateScholarship(double baseAmount, double bonusPercent,double averageGrade)
{
    if (averageGrade >= 4.5)
    {
        return baseAmount + baseAmount * bonusPercent / 100;
    }
    else
    {
        return baseAmount;
    }
}
double result = CalculateScholarship(2000, 15, 4.4);
System.Console.WriteLine(result);


double CalculateAvarageGrade(int[] grades)
{
    int sum = 0;
    foreach (int grade in grades)
    {
        sum += grade;
    }
    return (double)sum / grades.Length;
}
int CountFives(int[] grades)
{
    int five = 0;
    foreach (int grade in grades)
    {
        if (grade == 5)
        {
            five++;
        }
    }
    return (int)five;
}
int[] grades = { 4, 5, 3, 5, 4 };
double average = CalculateAvarageGrade(grades);
int five = CountFives(grades);
System.Console.WriteLine(average);
System.Console.WriteLine(five);

// class Program {
//     static void Main() {
//         Console.WriteLine(Add(2, 3)); // вызовет первый вариант: int Add(int, int) → 5
//     Console.WriteLine(Add(2.5, 3.5)); // вызовет второй вариант: double Add(double, double) → 6.0
//     Console.WriteLine(Add(2, 3, 4)); // вызовет третий вариант: int Add(int, int, int) → 9
//     }
// static int Add(int a, int b) {
//     return a + b;
//     }
// static double Add(double a, double b) {
//     return a + b;
//     }
// static int Add(int a, int b, int c) {
//     return a + b + c;
//     }
// }

//Задание А
// void PrintDivider()
// {
//     System.Console.WriteLine("----------");
// }
// System.Console.WriteLine("Привет!");
// PrintDivider();
// System.Console.WriteLine("Как дела?");
// PrintDivider();
// System.Console.WriteLine("Пока!");

// Задание Б
// void PrintPerson(string name, int age)
// {
//     System.Console.WriteLine($"Имя: {name}, Возраст: {age}");
// }
// PrintPerson("Егор", 19);
// PrintPerson("Саша", 17);


//Вариант 1
// void PrintSeparator()
// {
//     System.Console.WriteLine("----------");
// }
// System.Console.WriteLine("Привет!");
// PrintSeparator();
// System.Console.WriteLine("Как дела?");
// PrintSeparator();
// System.Console.WriteLine("Что делаешь?");
// PrintSeparator();
// System.Console.WriteLine("Пока!");

//Вариант 6
// int CountVowels(string word)
// {
//     int sum = 0;
//     string glas = "аоуэыяеюёи";
//     foreach (char words in word)
//     {
//         foreach (char glass in glas)
//         {
//             if (words == glass)
//             {
//                 sum++;
//             }
//         }
//     }
//     return (int)sum;
// }
// string text = "привет";
// int glas = CountVowels(text);
// System.Console.WriteLine($"Гласных: {glas}");