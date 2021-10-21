using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCalculation
{
    public class EmployeeWage
    {

        public int empRatePerHoure;
        public int noOfWorkingDays;
        public int maxWorkingHr;
        public string CompanyName;
        public int totalEmpWage;

        public EmployeeWage(int empRatePerHoure, int noOfWorkingDays, int maxWorkingHr, string companyName)
        {
            this.empRatePerHoure = empRatePerHoure;
            this.noOfWorkingDays = noOfWorkingDays;
            this.maxWorkingHr = maxWorkingHr;
            CompanyName = companyName;
            totalEmpWage = 0;
        }

        public void setTotalEmployeeWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;

        }

        public int getTotalEmployeeWage()
        {
            return totalEmpWage;
        }
    }
}
