using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEY
{
    public partial class AddStud : Form
    {
        List<Students> temp;
        ListBox tempBox;
        public AddStud(ref List<Students> stud, ref ListBox listBox)
        {
            InitializeComponent();
            temp = stud;
            tempBox = listBox;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((FIO.Text!="")&&(Fac.Text!= "")&&(BTHYear.Text != ""))
            {
                Students.AddStud(temp, FIO.Text, Fac.Text, int.Parse(BTHYear.Text));
            }
            Form1.Reset(ref temp,ref tempBox);
            this.Hide();
        }
    }
}
