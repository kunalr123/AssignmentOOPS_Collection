using HRLib;

namespace HRAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ConfirmEmployee employee;
            ConfirmEmployee employee1;
                try
                {
                    employee = new ConfirmEmployee();
                    Console.WriteLine(employee.ToString());

                    employee1 = new ConfirmEmployee("sample", "US", 4000, "SWE");
                     if(employee1.Basic < 5000)
                {
                    throw new Exception("Basic salary should be more than 5000");
                }
                    Console.WriteLine(employee1);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            

            
            //ConfirmEmployee employee = new ConfirmEmployee();
            //Console.WriteLine(employee.ToString());

            





            Trainee trainee = new Trainee();
            Console.WriteLine(trainee.ToString());
            Trainee trainee1 = new Trainee("adi","US",60,5);
            Console.WriteLine(trainee1);
            
        }
    }
}
