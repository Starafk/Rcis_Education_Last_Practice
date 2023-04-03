using System;
using rcis_ep2_task_two;

namespace Program
{
    public class Program
    {
        // 1 Задание
        static void Main()
        {
            Student student = new Student( "Роман", 475, 2000, 07, 29);
            student.setPointShool(4,4,5,4,5);

            int gradePointAverage = 0;
            for (int i = 0; i < 5; ++i)
            {
                gradePointAverage += student.grade[i];
            }
            gradePointAverage /= 5;

            Console.WriteLine($"Студента зовут {student.surname}, он из {student.group} группы." +
                              $"\nРодился {student.dateOfBirth.Day} {student.dateOfBirth.Month} {student.dateOfBirth.Year} года" +
                              $"\nИмеет средний балл: {gradePointAverage}");
        }
        // 2 Задание
        static void Main()
        {
            Train train = new Train("Томск", 409, 13, 05);
            Console.WriteLine($"Поезд {train.nameDestination}-{train.trainNumber} отправляется в {train.timeDeparture:t}");
        }
        // 3 Задание
        static void Main()
        {
            Numbers number = new Numbers(10, 100);
            
            number.Print();
            Console.WriteLine("\nИзмененные значения.");
            number.Edit(100, 10);
            number.Print();
            Console.WriteLine($"Сумма чисел равна: {number.Amount()} \n" +
                              $"Наибольшее значение: {number.Larger()}");
        }
        // 4 Задание
        static void Main()
        {
            Counter counter = new Counter(1);
            counter.Print();

            for (int i = 0; i < 6; ++i)
            {
                counter.Decrease();
            }
            counter.Print();
            
            for (int i = 0; i < 15; ++i)
            {
                counter.Increase();
            }
            counter.Print();
        }
        // 5 Задание
        static void Main()
        {
            Struct? billy = null;
            Struct? van = null;
            Struct? ivan = null;
            
            try
            {
                billy = new Struct("Билли", "Херрингтон");
                van = new Struct("Ван", "Мастер");
                ivan = new Struct();
                
                Console.WriteLine($" Три мужика: {billy.name}, {ivan.name} и {van.name} {van.surname}.");
            }
            finally
            {
                billy?.Dispose();
                van?.Dispose();
                ivan?.Dispose();
            }
        }
    }
}
