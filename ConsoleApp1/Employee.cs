namespace ConsoleApp1
{
    struct HiringDate : IComparable<HiringDate>
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }

        // Implementing IComparable to compare HireDates for sorting
        public int CompareTo(HiringDate other)
        {
            if (this.Year != other.Year)
                return this.Year.CompareTo(other.Year);
            if (this.Month != other.Month)
                return this.Month.CompareTo(other.Month);
            return this.Day.CompareTo(other.Day);
        }
    }



    internal class Employee
    {
        #region Basics
        public int Id { get; set; }
        public double Salary { get; set; }

        // Property for HiringDate
        public HiringDate HireDate { get; set; }

        public string Gender { get; set; }
        public static int Size { get; set; }

        public Employee(int id = 0, double salary = 0, HiringDate? hireDate = null, string gender = "Unknown", int size = 0)
        {
            Id = id;
            Salary = salary;
            // If hireDate is null, set a default HiringDate
            HireDate = hireDate ?? new HiringDate { Day = 1, Month = 1, Year = 1 };
            Gender = gender;
            Size = size;
        }



        public override string ToString()
        {
            return $"Id: {Id}, Salary: {Salary}, HireDate: {HireDate}, Gender: {Gender}";
        }

        Employee[] employees = new Employee[Size];

        #endregion

        #region indexer
        // Implement the indexer, for sorting Employees by HireDate

        public Employee this[int index]
        {
            get
            {
                return employees[index];
            }
            set
            {
                employees[index] = value;
            }
        }

        #endregion

        #region Sorting Employees by HireDate
        public void SortEmployeesByHireDate()
        {
            Array.Sort(employees, (x, y) => x.HireDate.CompareTo(y.HireDate));
        }

        #endregion


        #region print the employees

        public void print()
        {
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }
        }

        #endregion
    }
}

