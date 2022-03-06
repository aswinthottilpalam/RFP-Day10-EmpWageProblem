using System;

namespace RFP_day10_EmpWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Welcome to the employee wage computation programs");
            UC9EmpWageBuilder CompanyOne = new UC9EmpWageBuilder("CompanyOne", 20, 5, 10);
            CompanyOne.GetMonthlyEmpWage();
            Console.WriteLine(CompanyOne.ToString());

            UC9EmpWageBuilder CompanyTwo = new UC9EmpWageBuilder("CompanyTwo", 10, 4, 20);
            CompanyTwo.GetMonthlyEmpWage();
            Console.WriteLine(CompanyTwo.ToString());

            UC9EmpWageBuilder CompanyThree = new UC9EmpWageBuilder("CompanyThree", 35, 3, 25);
            CompanyThree.GetMonthlyEmpWage();
            Console.WriteLine(CompanyThree.ToString());

            Console.ReadLine();
        }
    }
}
