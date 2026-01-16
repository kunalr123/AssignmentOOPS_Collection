using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class Trainee:Employee
    {
        private int noofdays;
        public int NoOfDays { get { return noofdays; } set { noofdays = value; } }


        private double rateperday;
        public double RateperDay { get { return rateperday; } set { rateperday = value; } }


        public Trainee() : base()
        {
            NoOfDays = 30;
            RateperDay = 5;
        }

        public Trainee(string name,string address,int noofdays, double rateperday) : base(name, address)
        {
            NoOfDays = noofdays;
            RateperDay = rateperday;
        }

        public override double CalculateSalary()
        {
            return NoOfDays * RateperDay;

        }


        public override string ToString()
        {
            return $"{base.ToString()} No of days : {NoOfDays} Rate Per Day: {RateperDay} and NetSalary is {CalculateSalary()}";
        }
    }


    }

