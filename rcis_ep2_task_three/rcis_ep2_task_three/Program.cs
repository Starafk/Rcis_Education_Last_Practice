using System;
using rcis_ep2_task_three;

namespace Program
{
    public class Program
    {
        // Задание 1
        static void Main()
        {
            Worker worker = new Worker("Билли", "Херрингтон", 14, 4);
            worker.GetSalary();
        }
        
        // Задание 2
        static void Main()
        {
            NewWorker worker = new NewWorker("Ван", "Даркхолм", 365, 10);
            Console.WriteLine($"ФИО: {worker.Name} {worker.Surname} \n");
            worker.GetSalary();
        }
        
        // Задание 3
        static void Main()
        {
            Calculation line = new Calculation();
            
            line.SetCalculationLine("123456");
            line.SetLastSymbolCalculationLine('X');
            line.GetCalculationLine();
            line.GetLastSymbol();
            line.DeleteLastSymbol();
            line.GetCalculationLine();
        }
    }
}
