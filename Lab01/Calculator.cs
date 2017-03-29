using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Calculator : CalculatorBase
    {
        /// <summary>
        /// 加上一個整數
        ///// </summary>
        /// <param name="value">數值</param>
        public override void Dec(int value)
        {
            _result -= value;
        }
    }
}
