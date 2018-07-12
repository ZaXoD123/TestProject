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
    public partial class DeleteStud : Form
    {
        List<Students> temp;
        ListBox tempBox;
        public DeleteStud(ref List<Students> stud, ref ListBox listBox)
        {
            InitializeComponent();
            temp = stud;
            tempBox = listBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Students.DeleteStud(temp, int.Parse(DelIndex.Text)-1);
            
            Form1.Reset(ref temp,ref tempBox);
            this.Hide();
        }

    }
}
