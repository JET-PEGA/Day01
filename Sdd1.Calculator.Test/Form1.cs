using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sdd1.Calculator.Test
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 公式
        /// </summary>
        Formula _formula;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 離開運算式欄位時，產生參數輸入欄位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtExpression_Leave(object sender, EventArgs e)
        {
            txtPostfixExpression.Text = txtPostfixExpression.Text.ToUpper();
            _formula = new Formula(txtExpression.Text);

            // 建立一個DataTable
            DataTable dtParameter = new DataTable();
            dtParameter.Columns.Add("PARAMETER", typeof(string));
            dtParameter.Columns.Add("VALUE", typeof(string));

            char maxChar = '#';
            foreach (char c in txtExpression.Text)
            {
                if (char.IsUpper(c))
                {
                    if (c > maxChar)
                    {
                        maxChar = c;
                    }
                }
            }

            for (int i = 65; i <= Convert.ToInt32(maxChar); i++)
            {
                object[] item = new object[2];
                item[0] = Convert.ToChar(i);
                dtParameter.Rows.Add(item);
            }
            grdParameter.DataSource = dtParameter;
            txtPostfixExpression.Text = _formula.GetPostfixExpression();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int count = grdParameter.RowCount;
            string[] parameters = new string[count];
            for (int i = 0; i < count; i++)
                parameters[i] = grdParameter.Rows[i].Cells[1].Value.ToString();
            txtResult.Text = _formula.Calculate(parameters).ToString();
        }
    }
}
