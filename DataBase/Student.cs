using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    [Serializable]
    public class Student
    {
        public string FIO { get; set; }
        public string Fac { get; set; }
        public int BTHYear{ get; set; }
        //ctor
        public Student(string FIO, string Fac, int BTHYear)
        {
            this.FIO = FIO;
            this.Fac = Fac;
            this.BTHYear = BTHYear;
        }
        //Показать
        public virtual string Show() 
            => ($"{FIO} {Fac} {BTHYear}");
        
    }
}
