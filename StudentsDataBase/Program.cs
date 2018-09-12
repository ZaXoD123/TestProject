using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace StudentsDataBase
{
    public static class Glue
    {
        static List<Student> myStorage = new List<Student>();
        static Glue()
        {
            Load();
        }
        //Сериализация-Десериализация
        public static void Save()
        {
            FileStream fileStream = new FileStream("Data.dat", FileMode.OpenOrCreate);
            (new BinaryFormatter()).Serialize(fileStream, myStorage);
            fileStream.Close();
        }
        public static void Load()
        {
            FileStream fileStream = new FileStream("Data.dat", FileMode.OpenOrCreate);
            try { myStorage = (new BinaryFormatter()).Deserialize(fileStream) as List<Student>; }
            catch { }
            fileStream.Close();
        }
        //Удалить-Добавить
        public static void AddStudent(string FIO, string Fac, int BTHYear)
            => myStorage.Add(new Student(FIO, Fac, BTHYear));
        public static void AddStudent(string FIO, string Fac, int BTHYear, string optional)
            => myStorage.Add(new StudentOptional(FIO, Fac, BTHYear, optional));
        public static void DeleteStud(int index)
        {
            try
            {
                myStorage.RemoveAt(index-1);
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new Exception("Delete Exception");
            }

        }
        public static void ChangeFac(int index, string newFaculty)
            => myStorage[index-1].Fac = newFaculty;
        public static List<string> GoToString(this List<Student> students)
        {
            var tempList = new List<string>(students.Count);
            for (int i = 0; i < students.Count; i++)
            {
                tempList.Add($"{i+1}) {students[i].Show()}");
            }
            return tempList;
        }
        public static List<string> GetData()
            => myStorage.GoToString();
        public static List<string> ShowFac(string Fac)
            => myStorage.Where(n => n.Fac == Fac).Select(n => n).ToList().GoToString();
        //Поиск
        static List<Student> SearchStudent(object Current)
        {
            if (Current is string)
            {
                return myStorage.Where(n => n.FIO == Current as string).Select(n => n).ToList();
            }
            return myStorage.Where(n => n.BTHYear == (int)Current).Select(n => n).ToList();
        }
        public static List<string> SearchStudent(object Current, string CurrentFac)
        {
            if (CurrentFac == "") return SearchStudent(Current).GoToString();
        return(SearchStudent(Current)).Where(n => n.Fac == CurrentFac).Select(n => n).ToList().GoToString();
        }
    }
}
