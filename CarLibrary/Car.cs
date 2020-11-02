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

        public string SetParams(Car car)
        {
            MarkAuto = car.MarkAuto;
            CountCylinders = car.CountCylinders;
            Power = car.Power;
            return "Машина марки " + car.MarkAuto + " с количеством цилиндров " + car.CountCylinders.ToString() + " мощностью " + car.Power.ToString() + " лошадей";
        }

        public string SetParams(string mark)
        {
            MarkAuto = mark;            
            return "Машина марки " + MarkAuto ;
        }

        public string SetParams(int cylinders)
        {
            CountCylinders = cylinders;            
            return "Количество цилиндров " + CountCylinders.ToString();
        }
        
        public string SetParams(string mark, int cylinders)
        {
            MarkAuto = mark;
            CountCylinders = cylinders;
            return "Машина марки " + MarkAuto + " с количеством цилиндров " + CountCylinders.ToString();
        }

        public string SetParams(int cylinders, int power)
        {
            CountCylinders = cylinders;
            Power = power;
            return " Количество цилиндров " + CountCylinders.ToString() + " мощностью " + Power.ToString() + " лошадей";
        }

        public string SetParams(int power, string mark)
        {
            MarkAuto = mark;            
            Power = power;
            return "Машина марки " + MarkAuto + " мощностью " + Power.ToString() + " лошадей";
        }        
    }
}
