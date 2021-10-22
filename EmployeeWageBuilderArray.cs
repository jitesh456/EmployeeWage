using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCalculation
{
    public class EmployeeWageBuilderArray
    {

        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;

        EmployeeWage[] employeeWages;

        Dictionary<string, int> companyDictionary = new Dictionary<string, int>();


        static int noOfCompany=0;

        public EmployeeWageBuilderArray()
        {
            this.employeeWages = new EmployeeWage[5];
        }

        public void addCompany(int empRatePerHoure, int noOfWorkingDays, int maxWorkingHr, string companyName)
        {
            employeeWages[noOfCompany] = new EmployeeWage(empRatePerHoure, noOfWorkingDays, maxWorkingHr, companyName);
            noOfCompany++;
        }

        public void computeEmpWageForAllCompany()
        {
            for (int no = 0; no < noOfCompany; no++)
            {
                int wage= computeEmpWage(employeeWages[no]);
                employeeWages[no].setTotalEmployeeWage(wage);
                companyDictionary.Add(employeeWages[no].CompanyName, employeeWages[no].totalEmpWage);
                Console.WriteLine(" Employee Wage: " + employeeWages[no].getTotalEmployeeWage() + " company:" + employeeWages[no].CompanyName);
            }
        }


        public  int computeEmpWage(EmployeeWage employeeWage)
        {
            int empWage = 0;
            int totalempHr = 0;
            int empHr = 0;
            Random random = new Random();
            int totalWage = 0;
            int empCheck = random.Next(0, 3);
            int day = 0;

            while (day < employeeWage.noOfWorkingDays && totalempHr < employeeWage.maxWorkingHr)
            {
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHr = 8;
                        break;

                    case IS_PART_TIME:
                        empHr = 4;
                        break;
                    default:

                        empHr = 0;
                        break;
                }

                totalempHr += empHr;
                empWage = empHr * employeeWage.empRatePerHoure;
                totalWage += empWage;
                employeeWage.dayWage[day] = empWage;
                day++;
            }



            Console.WriteLine(" No Of days: " + day + " No of hr: " + empHr);
            
            return totalWage;
        }

        public int getTotalWageByCompanyName(string name)
        {
            return companyDictionary[name];
        }
    }
}
