using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class taxopark
    {
        public List<Auto> taxi;
        public taxopark()
        {
            taxi = new List<Auto>();
            taxi.Add(new Auto(220, 65, "reno", 400000));
            taxi.Add(new Auto(200, 85, "lada", 220000));
            taxi.Add(new Auto(300, 70, "bmw", 1220000));
            taxi.Add(new Auto(270, 60, "kia", 720000));
        }
        public int Price() 
        {
            int sum = 0;
            for (int i = 0; i < taxi.Count(); i++)
            {
                sum += taxi[i].GetPrice();
            }
            return sum;
        }
        public string FindByRange(int first, int last) 
        {
            string str = "";
            int len;
            for (int i = 0; i < taxi.Count(); i++)
            {
                len = taxi[i].GetSpeed();
                if (len >= first && len <= last)
                {
                    str += taxi[i].MakeStr() + " ";
                }
            }
            return str;
        }
    }
}
