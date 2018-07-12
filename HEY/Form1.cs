using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HEY
{
    public partial class Form1 : Form
    {
        List<Students> stud = new List<Students>();
        AddStud AS;
        DeleteStud DS;
        ChangeFac CF;
        SearchStud SS;
        string [] strings;

        public Form1()
        {
            InitializeComponent();
            if (File.Exists(@"StudentBase.txt"))
            {
               
            
            using (StreamReader sr = new StreamReader(@"StudentBase.txt"))        //считывание из файла в strings[]
            {
                strings = sr.ReadToEnd().Split(new char[] { '\n', ' ' });
            }
            for (int i = 0; i < strings.Length-2; i+=3)
            {
                Students.AddStud(stud,strings[i],strings[i+1],int.Parse(strings[i+2]));
            }
            }
            Reset(ref stud,ref listBox);
        }


        private void btnAddStud_Click(object sender, EventArgs e)
        {
            AS = new AddStud(ref stud, ref listBox);
            AS.ShowDialog();
            
        }

        private void btnDeleteStud_Click(object sender, EventArgs e)
        {
            DS = new DeleteStud(ref stud, ref listBox);
            DS.ShowDialog();
        }


         public static void Reset(ref List<Students> stud,ref ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (Students i in stud)
            {
                listBox.Items.Add(i.Show());
            }
        }
        public static void SearchResult(ref List<Students> stud, ref ListBox listBox, int flag, string FIO, string Fac, int Year)
        {
            listBox.Items.Clear();
            if (flag == 1)
            {
                Students.SearchStudYear(stud, Year, Fac, ref listBox);
            }
            else
            {
                Students.SearchStudFIO(stud, FIO, Fac, ref listBox);
            }
        }
        public static void SearchResult(ref List<Students> stud, ref ListBox listBox, int flag, string FIO, int Year)
        {
            listBox.Items.Clear();
            if (flag == 1)
            {
                Students.SearchStudYear(stud, Year, ref listBox);
            }
            else
            {
                Students.SearchStudFIO(stud, FIO, ref listBox);
            }
        }


        private void btnAddFac_Click(object sender, EventArgs e)
        {
            CF = new ChangeFac(ref stud, ref listBox);
            CF.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SS = new SearchStud(ref stud, ref listBox);
            SS.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("StudentBase.txt"))
            {
                foreach (Students i in stud)
                {
                    sw.WriteLine(i.ExitWrite());

                }
            }
            Application.Exit();
        }
    }
}
