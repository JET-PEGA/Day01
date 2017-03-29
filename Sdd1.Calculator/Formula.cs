using System;
using System.Collections.Generic;

namespace Sdd1.Calculator
{
    /// <summary>
    /// 運算式類別
    /// </summary>
    public class Formula
    {
        /// <summary>
        /// 運算式
        /// </summary>
        string _expression;

        /// <summary>
        /// 後序式的佇列
        /// </summary>
        Queue<FormulaElement> _postfixQueue = default(Queue<FormulaElement>);

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="expression">運算式字串</param>
        public Formula(string expression)
        {
            _expression = expression;
            Queue<FormulaElement> infixQueue = GetInfixQueue(expression);   // 取得中序佇列
            _postfixQueue = ConvertToPostfixQueue(infixQueue);          // 將中序轉為後序
        }

        /// <summary>
        /// 計算
        /// </summary>
        /// <param name="Parameters">參數陣列</param>
        /// <returns></returns>
        public double Calculate(string[] Parameters)
        {
            double ret = default(double);

            Queue<FormulaElement> postfixQueue = new Queue<FormulaElement>(_postfixQueue); // 取得一個複製的後序佇列副本

            Stack<FormulaElement> stack = new Stack<FormulaElement>();

            while (postfixQueue.Count > 0)
            {
                FormulaElement element = postfixQueue.Dequeue();
                if (element.ElementType != FormulaElementType.Operator) // 若是運算元
                {
                    if (element.ElementType != FormulaElementType.Constant)
                        element.Constant = Convert.ToDouble(Parameters[element.Variable]);
                    stack.Push(element);
                }
                else // 若為運算子
                {
                    double operand1 = stack.Pop().Constant;
                    double operand2 = stack.Pop().Constant;
                    switch (element.Operator)
                    {
                        case '+':
                            stack.Push(new FormulaElement(FormulaElementType.Constant, operand2 + operand1));
                            break;
                        case '-':
                            stack.Push(new FormulaElement(FormulaElementType.Constant, operand2 - operand1));
                            break;
                        case '*':
                            stack.Push(new FormulaElement(FormulaElementType.Constant, operand2 * operand1));
                            break;
                        case '/':
                            stack.Push(new FormulaElement(FormulaElementType.Constant, operand2 / operand1));
                            break;
                    }
                }
            }
            ret = stack.Pop().Constant;
            return ret;
        }

        /// <summary>
        /// 取得後序表示式
        /// </summary>
        /// <returns>後序表示式</returns>
        public string GetPostfixExpression()
        {
            string ret = default(string);
            string postfixString = string.Empty;

            Queue<FormulaElement> postfixQueue = new Queue<FormulaElement>(_postfixQueue); // 取得一個複製的後序佇列副本

            // 產生後序表示式字串
            while (postfixQueue.Count > 0)
                postfixString += postfixQueue.Dequeue().ToString();

            ret = postfixString;
            return ret;
        }

        /// <summary>
        /// 轉換為對等字串表示
        /// </summary>
        /// <returns>中序表示式</returns>
        public override string ToString()
        {
            string ret = default(string);
            ret = _expression;
            return ret;
        }


        /// <summary>
        /// 取得中序佇列
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        private Queue<FormulaElement> GetInfixQueue(string expression)
        {
            Queue<FormulaElement> infixQueue = new Queue<FormulaElement>();
            string perators = "-+/*()";
            string number = string.Empty;

            // 將運算式載入中序佇列
            foreach (char c in expression)
            {
                if (char.IsNumber(c)) // 是否為數字
                    number += c;
                else if (c == '.') //是否為小數點
                {
                    if (number == string.Empty)
                        number += "0.";
                    else
                        number += ".";
                }
                else if (char.IsUpper(c)) // 是否為大寫英文引數
                {
                    if (number != string.Empty)
                    {
                        infixQueue.Enqueue(new FormulaElement(FormulaElementType.Constant, Convert.ToDouble(number)));
                        number = string.Empty;
                    }
                    infixQueue.Enqueue(new FormulaElement(FormulaElementType.Variable, Convert.ToInt32(c) - 65));
                }
                else if (perators.IndexOf(c) >= 0) // 是否為運算子
                {
                    if (number != string.Empty)
                    {
                        infixQueue.Enqueue(new FormulaElement(FormulaElementType.Constant, Convert.ToDouble(number)));
                        number = string.Empty;
                    }
                    infixQueue.Enqueue(new FormulaElement(FormulaElementType.Operator, c));
                }
            }
            return infixQueue;
        }

        /// <summary>
        /// 將中序佇列轉換成後序佇列
        /// </summary>
        /// <param name="infixQueue"></param>
        /// <returns></returns>
        private Queue<FormulaElement> ConvertToPostfixQueue(Queue<FormulaElement> infixQueue)
        {
            Stack<FormulaElement> stack = new Stack<FormulaElement>();          // 暫存堆疊
            Queue<FormulaElement> postfixQueue = new Queue<FormulaElement>();   // 存放後序運算式的佇列

            string number = string.Empty;

            // 依序處理中序運算式的佇列的每一個元素
            while (infixQueue.Count > 0)
            {
                FormulaElement element = infixQueue.Dequeue();

                if (element.ElementType == FormulaElementType.Constant || element.ElementType == FormulaElementType.Variable)
                    postfixQueue.Enqueue(element);
                else
                {
                    switch (element.Operator)
                    {
                        case '(':
                            stack.Push(element);
                            break;
                        case ')':
                            while (stack.Count > 0)
                            {
                                if (stack.Peek().Operator != '(')
                                    postfixQueue.Enqueue(stack.Pop());
                                else
                                {
                                    stack.Pop();
                                    //break; // Bug 就在這裡 請移除註解，增加break; 即可修復Bug
                                }
                            }
                            break;
                        default:
                            if (stack.Count == 0) // 堆疊為空時
                                stack.Push(element);
                            else
                            {
                                while (stack.Count > 0)
                                {
                                    if (element.IsGreaterThan(stack.Peek()))
                                        break;
                                    else
                                        postfixQueue.Enqueue(stack.Pop());
                                }
                                stack.Push(element);

                            }
                            break;
                    }
                }
            }

            // 將運算子堆疊
            while (stack.Count > 0)
                postfixQueue.Enqueue(stack.Pop());

            return postfixQueue;
        }


    }

}