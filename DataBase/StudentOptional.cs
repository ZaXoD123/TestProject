using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    [Serializable]
    public class StudentOptional : Student
    {
        //новое свойство
        public string Optional { get; set; }
        //ctor
        public StudentOptional(string FIO, string Fac, int BTHYear,string Optional) : base( FIO,  Fac, BTHYear)
        {
            this.Optional = Optional;
        }
        //новый show с optional property
        public override string Show()
            => ($"{FIO} {Fac} {BTHYear} {Optional}");
    }
}
