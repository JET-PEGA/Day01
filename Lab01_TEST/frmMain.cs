//using DEV1 = Lab01.DEV1;
//using DEV2 = Lab01.DEV2;
using Lab01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_TEST
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnDev1_Click(object sender, EventArgs e)
        {
            Lab01.DEV1.Calculator calculator = new Lab01.DEV1.Calculator();
            calculator.Add(3);
            Debug.Print(calculator.Result.ToString());
        }

        private void btnDev2_Click(object sender, EventArgs e)
        {
            Lab01.DEV2.Calculator calculator = new Lab01.DEV2.Calculator();
            calculator.Add(3);
            Debug.Print(calculator.Result.ToString());
        }

        private void btnNewAbstract_Click(object sender, EventArgs e)
        {
            //CalculatorBase a = new CalculatorBase();
        }
    }
}
