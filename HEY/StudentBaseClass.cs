using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEY
{
    public class Students      //класс студенты (count порядковый номер)
    {
        string FIO;
        string Fac;
        int BTHYear;
        int count;

        public Students(string FIO, string Fac, int BTHYear, int count)        //конструктор
        {
            this.FIO = FIO;
            this.Fac = Fac;
            this.BTHYear = BTHYear;
            this.count = count;
        }

        public string Show()          //вывести студента
        {
            return (count + ") " + FIO + " " + Fac + " " + BTHYear);
        }
        public string ExitWrite()          //вывести студента
        {
            return (FIO + " " + Fac + " " + BTHYear);
        }

        public static void ShowUniversity(List<Students> arr)        //вывести студента вуза
        {
            foreach (Students i in arr)
            {
                i.Show();
            }
        }
        public static void ShowFac(List<Students> arr, string Fac)        //вывести студента заданного факультета
        {
            foreach (Students i in arr)
            {
                if (i.Fac == Fac) i.Show();
            }
        }
        public void AddFac(string Fac)        //добавить данные о факультете
        {
            this.Fac = Fac;
        }
        public void DeleteFac()        //удалить данные о факультете
        {
            Fac = "-";
        }
        public static void AddStud(List<Students> arr, string FIO, string Fac, int BTHYear)        //добавить студента
        {
            arr.Add(new Students(FIO, Fac, BTHYear, arr.Count + 1));
        }
        public static void DeleteStud(List<Students> arr, int index)            //удалить студента
        {
            if (arr.Count > 0)
            {
                arr.RemoveAt(index);
                for (int i = index; i < arr.Count; i++)
                {
                    arr[i].count--;
                }
            }
        }
        public static void SearchStudFIO(List<Students> arr, string FIO, ref ListBox listBox)            //поиск по фамилии
        {
            foreach (Students i in arr)
            {
                if (i.FIO == FIO)
                {
                    listBox.Items.Add(i.Show());
                }
            }
        }
        public static void SearchStudFIO(List<Students> arr, string FIO, string Fac, ref ListBox listBox)            //поиск по фамилии с факультетом
        {
            foreach (Students i in arr)
            {
                if ((i.FIO == FIO) && (i.Fac == Fac))
                {
                    listBox.Items.Add(i.Show());
                }
            }
        }
        public static void SearchStudYear(List<Students> arr, int BTHYear, ref ListBox listBox)            //поиск по году рождения
        {
            foreach (Students i in arr)
            {
                if (i.BTHYear == BTHYear)
                {
                    listBox.Items.Add(i.Show());
                }
            }
        }
        public static void SearchStudYear(List<Students> arr, int BTHYear, string Fac, ref ListBox listBox)            //поиск по году рождения с факультетом
        {
            foreach (Students i in arr)
            {
                if ((i.BTHYear == BTHYear) && (i.Fac == Fac))
                {
                    listBox.Items.Add(i.Show());
                }
            }
        }
    }
}
