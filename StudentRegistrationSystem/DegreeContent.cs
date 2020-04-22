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
    public partial class DegreeContent : MaterialSkin.Controls.MaterialForm
    {
        public DegreeContent()
        {
            InitializeComponent();
            var pos1 = this.PointToScreen(label1.Location);
            pos1 = pictureBox2.PointToClient(pos1);
            label1.Parent = pictureBox2;
            label1.Location = pos1;
            label1.BackColor = Color.Transparent;
            var pos2 = this.PointToScreen(label2.Location);
            pos2 = pictureBox2.PointToClient(pos2);
            label2.Parent = pictureBox2;
            label2.Location = pos2;
            label2.BackColor = Color.Transparent;
            var pos3 = this.PointToScreen(label3.Location);
            pos3 = pictureBox2.PointToClient(pos3);
            label3.Parent = pictureBox2;
            label3.Location = pos3;
            label3.BackColor = Color.Transparent;
            var pos4 = this.PointToScreen(label4.Location);
            pos4 = pictureBox2.PointToClient(pos4);
            label4.Parent = pictureBox2;
            label4.Location = pos4;
            label4.BackColor = Color.Transparent;
            var pos5 = this.PointToScreen(label5.Location);
            pos5 = pictureBox2.PointToClient(pos5);
            label5.Parent = pictureBox2;
            label5.Location = pos5;
            label5.BackColor = Color.Transparent;
            var pos6 = this.PointToScreen(label6.Location);
            pos6 = pictureBox2.PointToClient(pos6);
            label6.Parent = pictureBox2;
            label6.Location = pos6;
            label6.BackColor = Color.Transparent;
            var pos7 = this.PointToScreen(label7.Location);
            pos7 = pictureBox2.PointToClient(pos7);
            label7.Parent = pictureBox2;
            label7.Location = pos7;
            label7.BackColor = Color.Transparent;
            var pos8 = this.PointToScreen(label8.Location);
            pos8 = pictureBox2.PointToClient(pos8);
            label8.Parent = pictureBox2;
            label8.Location = pos8;
            label8.BackColor = Color.Transparent;
            var pos9 = this.PointToScreen(label9.Location);
            pos9 = pictureBox2.PointToClient(pos9);
            label9.Parent = pictureBox2;
            label9.Location = pos9;
            label9.BackColor = Color.Transparent;
            var pos10 = this.PointToScreen(label10.Location);
            pos10 = pictureBox2.PointToClient(pos10);
            label10.Parent = pictureBox2;
            label10.Location = pos10;
            label10.BackColor = Color.Transparent;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Attendence form3 = new Attendence();
            form3.Show();
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

        private void Label8_Click(object sender, EventArgs e)
        {

        }
    }
}
