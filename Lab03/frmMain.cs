using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// object測試
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObject_Click(object sender, EventArgs e)
        {
            int i = 3;
            int j = 0;
            object o = i;
            j = (int)o;
        }

        /// <summary>
        /// var 測試
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVar_Click(object sender, EventArgs e)
        {
            int i = 3;
            int j = 0;
            var v = i;
            j = v;
        }

        /// <summary>
        /// dynamic 測試
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDynamic_Click(object sender, EventArgs e)
        {
            string i = "";
            int j = 0;
            dynamic d = i;
            j = d;
        }

        /// <summary>
        /// dynamic 設計階段加屬性測試
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDynamicDesignTime_Click(object sender, EventArgs e)
        {
            dynamic d = new ExpandoObject();
            d.a = "s";
            d.b = 1;
        }

        /// <summary>
        /// dynamic 執行階段加屬性測試
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDynamicRunTime_Click(object sender, EventArgs e)
        {
            dynamic d = new ExpandoObject();

            var dict = d as IDictionary<string, object>;
            if (dict.ContainsKey("a"))
                dict["a"] = "s";
            else
                dict.Add("a", "s");

            if (dict.ContainsKey("b"))
                dict["b"] = 1;
            else
                dict.Add("b", 1);
        }
    }
}
