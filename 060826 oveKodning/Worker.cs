using System;
using System.Collections.Generic;
using System.Text;

namespace _060826_oveKodning
{
    public class Worker
    {
        public string Name;
        public string EmployeeId;
        public string Position;
        public int EmploymentStartYear;
        public int EmploymentEndYear;
        /// <summary>
        /// Constructoren til Worker, som initialiserer alle egenskaberne for en ny instans af klassen.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="employeeId"></param>
        /// <param name="position"></param>
        /// <param name="employmentStartYear"></param>
        /// <param name="employmentEndYear"></param>
        public Worker(string name, string employeeId, string position, int employmentStartYear, int employmentEndYear)
        {
            Name = name;
            EmployeeId = employeeId;
            Position = position;
            EmploymentStartYear = employmentStartYear;
            EmploymentEndYear = employmentEndYear;
        }
    }
}
