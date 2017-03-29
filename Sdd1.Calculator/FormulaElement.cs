using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sdd1.Calculator
{
    /// <summary>
    /// 運算式元素類別
    /// </summary>
    public class FormulaElement
    {
        /// <summary>
        /// 元素類型
        /// </summary>
        public FormulaElementType ElementType { get; set; }

        /// <summary>
        /// 常數運算元
        /// </summary>
        public double Constant { get; set; }

        /// <summary>
        /// 變數運算元
        /// </summary>
        public int Variable { get; set; }

        /// <summary>
        /// 運算子
        /// </summary>
        public char Operator { get; set; }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="elementType"></param>
        /// <param name="constant"></param>
        public FormulaElement(FormulaElementType elementType, double constant)
        {
            ElementType = elementType;
            Constant = constant;
        }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="elementType"></param>
        /// <param name="variable"></param>
        public FormulaElement(FormulaElementType elementType, int variable)
        {
            ElementType = elementType;
            Variable = variable;
        }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="elementType"></param>
        /// <param name="operatorChar"></param>
        public FormulaElement(FormulaElementType elementType, char operatorChar)
        {
            ElementType = elementType;
            Operator = operatorChar;
        }

        /// <summary>
        /// 是否大於
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool IsGreaterThan(FormulaElement element)
        {
            bool ret = false;

            if (Priority(this.Operator) > Priority(element.Operator))
                ret = true;
            return ret;
        }

        /// <summary>
        /// 優先權
        /// </summary>
        /// <returns></returns>
        public int Priority(char Operator)
        {
            int ret = default(int);
            switch (Operator)
            {
                case '(':
                case ')':
                    ret = 1;
                    break;
                case '+':
                case '-':
                    ret = 2;
                    break;
                case '*':
                case '/':
                    ret = 3;
                    break;
            }
            return ret;
        }

        /// <summary>
        /// 轉換為對等字串表示
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string ret = default(string);
            switch (ElementType)
            {
                case FormulaElementType.Constant:// 常數運算元
                    ret = Constant.ToString();
                    break;
                case FormulaElementType.Variable:// 變數運算元
                    ret = "[" + Variable.ToString() + "]";
                    break;
                case FormulaElementType.Operator:// 運算子
                    ret = Operator.ToString();
                    break;
            }
            return ret;
        }
    }
}