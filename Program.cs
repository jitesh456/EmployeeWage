using System;

namespace EmployeeWageCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            EmployeeWageBuilderArray employeeWageBuilderObject1 = new EmployeeWageBuilderArray();
            employeeWageBuilderObject1.addCompany(12, 20, 100, "Dmart");
            employeeWageBuilderObject1.addCompany(15, 17, 80, "Relience");
            employeeWageBuilderObject1.computeEmpWageForAllCompany();

        }
    }
}
