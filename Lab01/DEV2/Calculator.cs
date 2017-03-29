using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.DEV2
{
    public class Calculator: Lab01.DEV1.Calculator
    {
        /// <summary>
        /// 加上一個整數
        /// </summary>
        /// <param name="value">數值</param>
        public void Dec(int value)
        {
            _result -= value;
        }
    }
}
