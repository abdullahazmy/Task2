namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Ask the user for the number of employees
            Console.Write("Enter the number of employees: ");
            int size = int.Parse(Console.ReadLine());

            // Create an instance of Employee to manage the employees array
            Employee company = new Employee(size: size); // Pass the size of the employees array

            // Populate the employees array with user input
            for (int i = 0; i < Employee.Size; i++)
            {
                Console.WriteLine($"Enter details for Employee {i + 1}:");

                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                Console.Write("Hire Date (Day): ");
                int day = int.Parse(Console.ReadLine());

                Console.Write("Hire Date (Month): ");
                int month = int.Parse(Console.ReadLine());

                Console.Write("Hire Date (Year): ");
                int year = int.Parse(Console.ReadLine());

                HiringDate hireDate = new HiringDate { Day = day, Month = month, Year = year };

                Console.Write("Gender: ");
                string gender = Console.ReadLine();

                // Add the employee to the array
                company[i] = new Employee(id, salary, hireDate, gender);
            }

            // Sort the employees by hire date
            company.SortEmployeesByHireDate();

            // Print the sorted employees
            Console.WriteLine("\nEmployees sorted by Hire Date:");
            company.print();
        }
    }
}
