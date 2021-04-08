using System;

namespace InheritanceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker("David Busting", 200, 50M);
            var juniorM = new JuniorManager("Yemi Lala", 50000M, 10000M, 200);
            var seniorM = new SeniorManager("Donald Trump", 100000M, 30000, 7);

            Console.WriteLine($"{worker}\nSalary: {worker.Salary():C}\n");
            Console.WriteLine($"{juniorM}\nSalary: {juniorM.Salary():C}\n");
            Console.WriteLine($"{seniorM}\nSalary: {seniorM.Salary():C}\n");

        }
    }
}
