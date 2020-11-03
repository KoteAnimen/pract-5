using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Car
    {
        public static string MarkAuto { get; set; }
        public static int CountCylinders { get; set; }
        public static int Power { get; set; }        

        
        public static string SetParams(string mark, int cylinders, int power) //функция установки параметров автомобиля(марка, цилиндры, мощность). 
        {
            MarkAuto = mark;
            CountCylinders = cylinders;
            Power = power;
            return "Машина марки " + MarkAuto + " с количеством цилиндров " + CountCylinders.ToString() + " мощностью " + Power.ToString() + " лошадей";
        }

        public static string SetParams(string mark) //перегрузка функции SetParams с аргументом марка.
        {
            MarkAuto = mark;            
            return "Машина марки " + MarkAuto ;
        }
        // остальные перегрузки функции SetParams()
        public static string SetParams(int cylinders)
        {
            CountCylinders = cylinders;            
            return "Количество цилиндров " + CountCylinders.ToString();
        }
        
        public static string SetParams(string mark, int cylinders)
        {
            MarkAuto = mark;
            CountCylinders = cylinders;
            return "Машина марки " + MarkAuto + " с количеством цилиндров " + CountCylinders.ToString();
        }

        public static string SetParams(int cylinders, int power)
        {
            CountCylinders = cylinders;
            Power = power;
            return " Количество цилиндров " + CountCylinders.ToString() + " мощностью " + Power.ToString() + " лошадей";
        }

        public static string SetParams(int power, string mark)
        {
            MarkAuto = mark;            
            Power = power;
            return "Машина марки " + MarkAuto + " мощностью " + Power.ToString() + " лошадей";
        }        
    }
}
