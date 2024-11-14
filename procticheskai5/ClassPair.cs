using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Ribbon;

namespace procticheskai5
{
    class Pair
    {
        public int One { get; set; }
        public int Two { get; set; }

        public void SetParams(int first, int second)//Метод, он вводит данные(first,second)
        {
            One = first;//Присваивается значение к переменной One
            Two = second;//Присваиваем значение к переменной Two
        }
        public void SetParams(int first)//Перегруз метода, если будет дано 1 число, то к One и Two будет присвоено одно и тоже число
        {
            One = first;
            Two = first;
        }
        public bool Compare(Pair first, Pair second)// сравниваем 2 пары чисел
        {
            if (first.One > second.One || first.One == second.One && first.Two > second.Two) return true;
            return false;
        }
    }
}
