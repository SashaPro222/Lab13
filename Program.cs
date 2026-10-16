// using System.Diagnostics.Contracts;

// PrintHeader();
// PrintHeader();
// System.Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader()
// {
//     System.Console.WriteLine("^_^");
//     System.Console.WriteLine("Лабораторная работа №13");
//     System.Console.WriteLine("0_0");
//     System.Console.WriteLine("Дата формирования отчета: 16.10.2026");
// }

// void PrintFooter()
// {
//     System.Console.WriteLine(">_<");
//     System.Console.WriteLine("Конец программы");
//     System.Console.WriteLine("X_X");
// }

// void PrintStudentCard(string name, int age, int group)
// {
//     System.Console.WriteLine($"Студент: {name}, возраст: {age}, номер группы: {group}");
// }

// PrintStudentCard("Егор", 18,251);
// PrintStudentCard("Валерия", 17, 233);

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