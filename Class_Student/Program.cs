// Придумать класс, описывающий студента. Предусмотреть в нём следующие моменты:
// фамилия, имя, отчество, группа, возраст, массив (зубчатый) оценок по
// программированию, администрированию и дизайну. Предусмотреть конструктор.
// Также добавить методы по работе с перечисленными данными:
// возможность установки/получения оценок, получение среднего балла по заданному предмету,
// распечатка данных о студенте.

Console.Write("Имя ");
string _first_name = Console.ReadLine();
Console.Write("Отчество ");
string _second_name = Console.ReadLine();
Console.Write("Фамилия ");
string _last_name = Console.ReadLine();
Console.Write("Группа ");
string _group = Console.ReadLine();
Console.Write("Возраст ");
int _age = int.Parse(Console.ReadLine());
Console.Write("Количество оценок по программированию ");
int _size1 = int.Parse(Console.ReadLine());
Console.Write("Количество оценок по администрированию ");
int _size2 = int.Parse(Console.ReadLine());
Console.Write("Количество оценок по дизайну ");
int _size3 = int.Parse(Console.ReadLine());

Student First = new Student(_first_name, _second_name, _last_name, _group, _age, _size1, _size2, _size3);
First.prog();
First.print();
Console.ReadKey();

public class Student
{
    string first_name;
    string second_name;
    string last_name;
    string group;
    int age;

    int[][] grade = new int[3][];

    public Student(string first_name, string second_name, string last_name, string group, int age, int size1, int size2, int size3)
    {
        this.first_name = first_name;
        this.second_name = second_name;
        this.last_name = last_name;
        this.group = group;
        this.age = age;
        this.grade[0] = new int[size1];
        this.grade[1] = new int[size2];
        this.grade[2] = new int[size3];
    }

    public void prog()
    {
        for (int i = 0; i < grade.Length; i++)
        {
            for (int j = 0; j < grade[i].Length; j++)
            {
                Random rnd = new Random();
                grade[i][j] = rnd.Next(1, 5);
            }
        }
    }

    public void print()
    {
        Console.Write($"Имя Отчество Фамилия {first_name}"); ;
        Console.Write($" {second_name}");
        Console.WriteLine($" {last_name}");
        Console.WriteLine($"Группа {group}");
        Console.WriteLine($"Возраст {age}");
        for (int i = 0; i < grade.Length; i++)
        {
            if (i == 0) Console.WriteLine("Оценки по программированию: ");
            else if (i == 1) Console.WriteLine("Оценки по администрированию: ");
            else Console.WriteLine("Оценки по дизайну: ");

            for (int j = 0; j < grade[i].Length; j++)
            {
                Console.WriteLine(grade[i][j]);
            }

            Console.WriteLine();
        }

        for (int i = 0; i < grade.Length; i++)
        {

            double Sum = 0;
            for (int j = 0; j < grade[i].Length; j++)
            {
                Sum = Sum + grade[i][j];
            }
            double Sr = Sum / grade[i].Length;

            if (i == 0) Console.WriteLine("Средняя оценка по программированию: " + Math.Round(Sr, 1));
            else if (i == 1) Console.WriteLine("Средняя оценка по администрированию: " + Math.Round(Sr, 1));
            else Console.WriteLine("Средняя оценка по дизайну: " + Math.Round(Sr, 1));
        }
    }
}

