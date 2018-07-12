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
    public partial class SearchStud : Form
    {
        List<Students> temp;
        ListBox tempBox;
        public SearchStud(ref List<Students> stud, ref ListBox listBox)
        {
            InitializeComponent();
            temp = stud;
            tempBox = listBox;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)        //year
        {
            label3.Show();
            label1.Hide();
            FIO.Hide();
            BTHYear.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)        //
        {
            label3.Hide();
            label1.Show();
            FIO.Show();
            BTHYear.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked)&&(BTHYear.Text!="")&&(Fac.Text!=""))       //year
            {
                Form1.SearchResult(ref temp,ref tempBox, 1, FIO.Text, Fac.Text, int.Parse(BTHYear.Text));
            }
            if ((radioButton1.Checked) && (BTHYear.Text != "") && (Fac.Text == ""))       //year
            {
                Form1.SearchResult(ref temp, ref tempBox, 1, FIO.Text, int.Parse(BTHYear.Text));
            }
            if ((radioButton2.Checked) && (BTHYear.Text != "") && (Fac.Text != ""))       //fio
            {
                Form1.SearchResult(ref temp, ref tempBox, 2, FIO.Text, Fac.Text, int.Parse(BTHYear.Text));
            }
            if ((radioButton2.Checked) && (BTHYear.Text != "") && (Fac.Text == ""))       //fio
            {
                Form1.SearchResult(ref temp, ref tempBox, 2, FIO.Text, int.Parse(BTHYear.Text));
            }
            Hide();
        }
    }
}