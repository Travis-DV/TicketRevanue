using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketRevanue
{
    public partial class Form1 : Form
    {
        private int gradeA = 0;
        private int gradeB = 0;
        private int gradeC = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void gradeAinTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                gradeA = int.Parse(gradeAinTB.Text) * 15;
                gradeAoutTB.Text = $"{gradeA}";
            }
            catch (FormatException)
            {
                gradeAoutTB.Text = $"Please input a number";
            }
            total();
        }

        private void gradeBinTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                gradeB = int.Parse(gradeBinTB.Text) * 12;
                gradeBoutTB.Text = $"{gradeB}";
            }
            catch (FormatException)
            {
                gradeBoutTB.Text = $"Please input a number";
            }
            total();
        }

        private void gradeCinTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                gradeC = int.Parse(gradeCinTB.Text) * 9;
                gradeCoutTB.Text = $"{gradeC}";
            }
            catch (FormatException)
            {
                gradeCoutTB.Text = $"Please input a number";
            }
            total();
        }

        private void total()
        {
            totalTB.Text = $"{gradeA + gradeB + gradeC}";
        }

        private void clearBUT_Click(object sender, EventArgs e)
        {
            gradeAinTB.Text = "";
            gradeAoutTB.Text = "";
            gradeBinTB.Text = "";
            gradeBoutTB.Text = "";
            gradeCinTB.Text = "";
            gradeCoutTB.Text = "";
            totalTB.Text = "";
        }
    }
}
