using EmployeeWageCalculation;
using System;

namespace EmployeeWageCalculation7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            EmployeeWageBuilderArray employeeWageBuilderObject1 = new EmployeeWageBuilderArray();
            employeeWageBuilderObject1.addCompany(12, 20, 100, "Dmart");
            employeeWageBuilderObject1.addCompany(15, 17, 80, "Relience");
            employeeWageBuilderObject1.computeEmpWageForAllCompany();
            Console.WriteLine("Total wage of Dmart " + employeeWageBuilderObject1.getTotalWageByCompanyName("Dmart"));
            
        }
    }
}
