using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace HRLib
{
    public class ConfirmEmployee : Employee
    {
        private double basic;
        public double Basic {
            get { return basic; } 
      
            set { 
                if(value < 5000)
                {
                    throw new EmpException("Your basic salary should not smaller than 5000");
                }
                else
                {
                    basic = value;
                }
            }
                    
        }

        private string designation;

        public string Designation { get {return designation;} set { designation = value; } }



        public ConfirmEmployee():base()
        {
            Basic = 10000;
            Designation = "Pune";
        }
        public ConfirmEmployee(string name,string address,double basic, string designation) : base(name, address)
        {
            Basic = basic;
            Designation = designation;
        }


        public override double CalculateSalary()
        {
                double Netsalary;
                if (Basic >= 30000)
                {
                    double HRA = (30 * Basic) / 100;
                    double conv = (30 * Basic) / 100;
                    double PF = (10 * Basic) / 100;
                   return  Netsalary = Basic + HRA + conv - PF;

                }
                else if (Basic >= 20000)
                {
                    double HRA = (20 * Basic) / 100;
                    double conv = (20 * Basic) / 100;
                    double PF = (10 * Basic) / 100;
                  return  Netsalary = Basic + HRA + conv - PF;
                }
                else
                {
                    double HRA = (10 * Basic) / 100;
                    double conv = (10 * Basic) / 100;
                    double PF = (10 * Basic) / 100;
                   return Netsalary = Basic + HRA + conv - PF;
                }

            }

        //public override double CalculateSalary()
        //{

        //}

        public override string ToString()
        {
            return $"{base.ToString()} Basic is: {Basic} and Desig:{Designation} and NetSalary is : {CalculateSalary()} ";
        }
    }


    }





