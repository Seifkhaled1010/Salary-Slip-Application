namespace OOP_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee[] emps = new Employee[2];

            Console.Write("TAX: ");
            Employee.TAX = Convert.ToDouble(Console.ReadLine());

            Employee e1 = new Employee();
            Console.WriteLine("First Employee");
            Console.Write("First Name:");
            e1.FNAME = Console.ReadLine();

            Console.Write("Last Name:");
            e1.LNAME = Console.ReadLine();

            Console.Write("Wage: ");
            e1.Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("LoggedHours: ");
            e1.LoggedHours = Convert.ToDouble(Console.ReadLine());

            emps[0] = e1;

            Console.WriteLine("\nSecond Employee");

            Employee e2 = new Employee();

            Console.Write("First Name: ");
            e2.FNAME = Console.ReadLine();

            Console.Write("Last Name: ");
            e2.LNAME = Console.ReadLine();

            Console.Write("Wage: ");
            e2.Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("LoggedHours: ");
            e2.LoggedHours = Convert.ToDouble(Console.ReadLine());

            emps[1] = e2;

            foreach (var emp in emps)
            {
                var salary = emp.Wage * emp.LoggedHours;
                var taxAmount = salary * Employee.TAX;
                var netSalary = salary - taxAmount;

                Console.WriteLine($"\nFirst Name: {emp.FNAME}");
                Console.WriteLine($"Last Name: {emp.LNAME}");
                Console.WriteLine($"Wage: {emp.Wage}");
                Console.WriteLine($"LoggedHours: {emp.LoggedHours}");
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Salary: ${salary}");
                Console.WriteLine($"Deductable Tax ({Employee.TAX * 100}%), Amount: ${taxAmount}");
                Console.WriteLine($"Net Salary: {netSalary}\n");
            }
            Console.Read();
        }
    }
}
