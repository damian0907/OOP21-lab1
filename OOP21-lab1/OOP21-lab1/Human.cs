using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1 {
    public class Human {
        public string FirstName;
        public string LastName;
        public Animal Pet;
        public Phone Phone;
        public int Number;
        
        private DateTime salaryModificationDate;
        private decimal salary;
        private decimal car;

        public decimal Salary
        {
            get
            {
                Console.WriteLine(salaryModificationDate);
                return salary;
            }
            set
            {
                if(value > 0)
                {
                    salaryModificationDate = DateTime.Now;
                    salary = value;
                    Console.WriteLine("Added new salary");
                }
                
            }
        }
        
        public decimal Car
        {
            get
            {
                return car;
            }
            set
            {
                if (salary > value)
                {
                    car = value;
                    Console.WriteLine("Salary is above car value ");
                }
                else
                {
                    Console.WriteLine();
                }
                
            }
        }
        
        
    }
}
