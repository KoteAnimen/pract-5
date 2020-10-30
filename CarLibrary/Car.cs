using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Car
    {
        string markAuto;
        int countCylinders;
        int power;

        public string MarkAuto
        {
            get
            {
                return markAuto;
            }
            set
            {
                markAuto = value;
            }
        }

        public int CountCylinders
        {
            get
            {
                return countCylinders;
            }
            set
            {
                if (value > 0) countCylinders = value;
            }
        }

        public int Power
        {
            get
            {
                return power;
            }
            set
            {
                if (value > 0) power = value;
            }
        }

        public Car(string mark, int cylinders, int powerAuto)
        {
            MarkAuto = mark;
            CountCylinders = cylinders;
            Power = powerAuto;
        }

    }
}
