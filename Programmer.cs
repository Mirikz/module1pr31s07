using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module1pr31s07
{
    public class Programmer
    {
        public string secondname;
        public int count_of_programs;
        public int count_of_langs;
        public int q;
        public int Q(int count_of_programs, int count_of_langs)
        {
            int Q = count_of_programs * count_of_langs;
            return Q;
        }
        public void Info()
        {
            Console.WriteLine("Фамилия: {0}, кол-во программ:  {1}, кол-во языков:  {2}" +
                ", качество объекта: {3}", secondname, count_of_programs, count_of_langs, q);
        }

    }
}
