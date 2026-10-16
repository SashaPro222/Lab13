using System.Diagnostics.Contracts;

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
