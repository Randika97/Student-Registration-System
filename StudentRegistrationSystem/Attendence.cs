using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationSystem
{
    public partial class Attendence : MaterialSkin.Controls.MaterialForm
    {
        public Attendence()
        {
            InitializeComponent();
            var pos1 = this.PointToScreen(lbl1.Location);
            pos1 = pictureBox1.PointToClient(pos1);
            lbl1.Parent = pictureBox1;
            lbl1.Location = pos1;
            lbl1.BackColor = Color.Transparent;
            var pos2 = this.PointToScreen(linkLabel1.Location);
            pos2 = pictureBox1.PointToClient(pos2);
            linkLabel1.Parent = pictureBox1;
            linkLabel1.Location = pos2;
            linkLabel1.BackColor = Color.Transparent;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PaymentHistory form1 = new PaymentHistory();
            form1.Show();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Results form2 = new Results();
            form2.Show();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Attendence form3 = new Attendence();
            form3.Show();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DegreeContent form4 = new DegreeContent();
            form4.Show();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Timetabel form5 = new Timetabel();
            form5.Show();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Portal form6 = new Portal();
            form6.Show();
        }
    }
}
