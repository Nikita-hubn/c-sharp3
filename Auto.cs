using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Auto
    {
        private int _Speed;
        private int _Fuel;
        private int _Price;
        private string _Name;

        public Auto(int speed, int fuel, string name, int price) //конструктор
        {
            _Name = name;
            _Speed = speed;
            _Fuel = fuel;
            _Price = price;
        }
        public string GetName()
        {
            return _Name;
        }

        public void SetName(string name)
        {
            _Name = name;
        }
        public int GetSpeed()
        {
            return _Speed;
        }

        public void SetName(int speed)
        {
            _Speed = speed;
        }

        public int GetPrice()
        {
            return _Price;
        }

        public void SetPrice(int price)
        {
            _Price = price;
        }
        public int GetFuel()
        {
            return _Fuel;
        }
        public void SetFuel(int fuel)
        {
            _Fuel = fuel;
        }
        public string MakeStr() // возвращает строку для вывода в листбокс
        {
            return "Название: " + GetName() + "цена: " + GetPrice() + ", Расход топлива: " + GetFuel() + ", Скорость: " + GetSpeed();
        }
    }
}
