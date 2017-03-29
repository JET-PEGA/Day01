using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.DEV1
{
    public class Calculator
    {
        /// <summary>
        /// 欄位
        /// </summary>
        protected int _result = 0;

        /// <summary>
        /// 屬性
        /// </summary>
        public int Result
        {
            get
            {
                return _result;
            }
        }

        /// <summary>
        /// 加上一個整數
        /// </summary>
        /// <param name="value">數值</param>
        public void Add(int value)
        {
            /// TODO:曾建中
            _result += value;
        }
    }
}
