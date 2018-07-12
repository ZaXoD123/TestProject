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
    public partial class ChangeFac : Form
    {
        List<Students> temp;
        ListBox tempBox;
        public ChangeFac(ref List<Students> stud, ref ListBox listBox)
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
            if (ChIndex.Text != "")
            {
                if (ChTo.Text == "")
                {
                    temp[int.Parse(ChIndex.Text) - 1].DeleteFac();

                }
                else
                {
                    temp[int.Parse(ChIndex.Text) - 1].AddFac(ChTo.Text);
                }
            }
            Form1.Reset(ref temp, ref tempBox);
            this.Hide();
        }
    }
}
