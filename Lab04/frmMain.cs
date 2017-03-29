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
using Lab04.Extensions;
namespace Lab04
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 使用Function處理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDynamicFunction_Click(object sender, EventArgs e)
        {
            dynamic d = new ExpandoObject();

            var dict = d as IDictionary<string, object>;
            if (dict.ContainsKey("a"))
                dict["a"] = "s";
            else
                dict.Add("a", "s");

            AddProperty(dict, "b", 1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        private static void AddProperty(IDictionary<string, object> dict, string name, object value)
        {
            if (dict.ContainsKey(name))
                dict[name] = value;
            else
                dict.Add(name, value);
        }

        /// <summary>
        /// 使用擴充方法處理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDynamicExtension_Click(object sender, EventArgs e)
        {
            ExpandoObject obj = new ExpandoObject();
            dynamic d = obj;
            obj.AddProperty("a", "s");
            obj.AddProperty("b", 1);

        }
    }
}
