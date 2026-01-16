namespace HRLib
{
    public abstract class Employee
    {
        //employee class properties

        #region properties
        private string name;
        public string Name { get { return name; }set { name = value; } }

        private string address;
        public string Address { get { return address; } set { address = value; } }

        
        private int empid ;
        public int EmpId { get { return empid; } set { empid = value; } }

        private static int count;

        #endregion

        #region constructor

        static Employee()
        {
            count = 1;
        }
        public Employee()
        {

            count++;
            EmpId = count;
            name = "kunal";
            address = "Washim";
        }

        public Employee(string name, string address):this()
        {
            this.Name = name;
            this.Address = address;

        }

       public abstract double CalculateSalary();

        public override string ToString()
        {
            return $"Employee ID: {EmpId} Name is :{Name} and Address:{Address}";
        }
        #endregion
    }
}
