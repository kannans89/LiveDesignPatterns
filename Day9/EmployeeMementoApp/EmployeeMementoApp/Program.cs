namespace EmployeeMementoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var history = new CareTaker();
            var orginalEmployee = new Employee("Derek", "London", "1234");
            history.Save(orginalEmployee);

            orginalEmployee.Name = "Derek like coding";
            history.Save(orginalEmployee);


            orginalEmployee.Name = "Derek works at Coats";//not saving state

            history.Revert(orginalEmployee);
            history.Revert(orginalEmployee);
            Console.WriteLine(orginalEmployee.Name);


        }
    }
}