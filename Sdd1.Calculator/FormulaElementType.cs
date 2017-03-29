using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sdd1.Calculator
{
    /// <summary>
    /// 公式元素類型
    /// </summary>
    public enum FormulaElementType
    {
        /// <summary>
        /// 常數
        /// </summary>
        Constant,

        /// <summary>
        /// 變數
        /// </summary>
        Variable,

        /// <summary>
        /// 運算子
        /// </summary>
        Operator,
    }
}