using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;

namespace _1._1._12
{
    public partial class CulcForm : Form
    {
        public CulcForm()
        {
            InitializeComponent();
        }

        void ValidDen(string denX, string denY, string numX, string numY)
        {
            if (denX.Contains("0") || denY.Contains("0") || numX.Contains("0") || numY.Contains("0"))
                throw new FormatException();
        }

        private void sumBut_Click(object sender, EventArgs e)
        {
            try
            {
                int xNum = Convert.ToInt32(inputXNum.Text);
                int xDen = Convert.ToInt32(inputXDen.Text);
                int yNum = Convert.ToInt32(inputYNum.Text);
                int yDen = Convert.ToInt32(inputYDen.Text);
                ValidDen(inputXDen.Text, inputYDen.Text, inputXNum.Text, inputYNum.Text);
                Number wr = new Number(xNum, xDen, yNum, yDen);
                otvetSumNum.Text = Convert.ToString(wr.SumNum());
                otvetSumDen.Text = Convert.ToString(wr.SumDen());
                return;
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введенных данных!");
            }
        }

        private void subBut_Click(object sender, EventArgs e)
        {
            try
            {
                int xNum = Convert.ToInt32(inputXNum.Text);
                int xDen = Convert.ToInt32(inputXDen.Text);
                int yNum = Convert.ToInt32(inputYNum.Text);
                int yDen = Convert.ToInt32(inputYDen.Text);
                ValidDen(inputXDen.Text, inputYDen.Text, inputXNum.Text, inputYNum.Text);
                Number wr = new Number(xNum, xDen, yNum, yDen);
                otvetSubNum.Text = Convert.ToString(wr.SubNum());
                otvetSubDen.Text = Convert.ToString(wr.SubDen());
                return;
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введенных данных!");
            }
        }

        private void multBut_Click(object sender, EventArgs e)
        {
            try
            {
                int xNum = Convert.ToInt32(inputXNum.Text);
                int xDen = Convert.ToInt32(inputXDen.Text);
                int yNum = Convert.ToInt32(inputYNum.Text);
                int yDen = Convert.ToInt32(inputYDen.Text);
                ValidDen(inputXDen.Text, inputYDen.Text, inputXNum.Text, inputYNum.Text);
                Number wr = new Number(xNum, xDen, yNum, yDen);
                otvetMultNum.Text = Convert.ToString(wr.MultNum());
                otvetMultDen.Text = Convert.ToString(wr.MultDen());
                return;
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введенных данных!");
            }
        }

        private void divBut_Click(object sender, EventArgs e)
        {
            try
            {
                int xNum = Convert.ToInt32(inputXNum.Text);
                int xDen = Convert.ToInt32(inputXDen.Text);
                int yNum = Convert.ToInt32(inputYNum.Text);
                int yDen = Convert.ToInt32(inputYDen.Text);
                ValidDen(inputXDen.Text, inputYDen.Text, inputXNum.Text, inputYNum.Text);
                Number wr = new Number(xNum, xDen, yNum, yDen);
                otvetDivNum.Text = Convert.ToString(wr.DivNum());
                otvetDivDen.Text = Convert.ToString(wr.DivDen());
                return;
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введенных данных!");
            }
        }

    }
}
