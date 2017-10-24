
// Project Prolog
// Name: Eliott Moreno
// CS3260 Section 001
// Project: Lab_02
// Date: 09/06/2017 10:46:44 PM
// Purpose: The purpose of this project is to calculate complex numbers.
// 
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes plagiarism, and that I will receive
// a zero on this project if I am found in violation of this policy.
// 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02_EM
{
    public partial class Form1 : Form
    {
        TextBox selTB = null;
        ComplexData operandOne = new ComplexData();
        ComplexData operandTwo = new ComplexData();
        ComplexArithmetic calculator = new ComplexArithmetic(); 

        public Form1()
        {
            //Adds event handlers to the textboxes for when you click in them. 
            InitializeComponent();
            TxtOperandOne.Enter += tb_Enter;
            TxtOperandTwo.Enter += tb_Enter;
            TxtResult.Enter += tb_Enter;
            TxtOperator.Enter += tb_Enter;
          


        }

        ~Form1()
        {
            TxtOperandOne.Enter += tb_Enter;
            TxtOperandTwo.Enter += tb_Enter;
            TxtResult.Enter += tb_Enter;
        }
        /// <summary>
        /// sets the selTB to the most recent selected textbox. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_Enter(object sender, EventArgs e)
        {
            selTB = (TextBox)sender;
           
        }
        /// <summary>
        /// Adds a 1 to the selected Textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOne_Click(object sender, EventArgs e)
        {
            selTB.Text += "1";

            if (selTB != null) selTB.Focus();
        }

        /// <summary>
        /// Adds a 2 to the selected Textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTwo_Click(object sender, EventArgs e)
        {
            selTB.Text += "2";

            if (selTB != null) selTB.Focus();
        }

        /// <summary>
        /// Adds a 3 to the selected Textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnThree_Click(object sender, EventArgs e)
        {
            selTB.Text += "3";

            if (selTB != null) selTB.Focus();
        }

        /// <summary>
        /// Adds a 4 to the selected Textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFour_Click(object sender, EventArgs e)
        {
            selTB.Text += "4";

            if (selTB != null) selTB.Focus();
        }

        /// <summary>
        /// Adds a 5 to the selected Textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFive_Click(object sender, EventArgs e)
        {
            selTB.Text += "5";

            if (selTB != null) selTB.Focus();
        }

        /// <summary>
        /// Adds a 6 to the selected Textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSix_Click(object sender, EventArgs e)
        {
            selTB.Text += "6";

            if (selTB != null) selTB.Focus();
        }

        /// <summary>
        /// Adds a 7 to the selected Textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSeven_Click(object sender, EventArgs e)
        {
            selTB.Text += "7";

            if (selTB != null) selTB.Focus();
        }

        /// <summary>
        /// Adds a 8 to the selected Textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEight_Click(object sender, EventArgs e)
        {
            selTB.Text += "8";

            if (selTB != null) selTB.Focus();
        }

        /// <summary>
        /// Adds a 9 to the selected Textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNine_Click(object sender, EventArgs e)
        {
            selTB.Text += "9";

            if (selTB != null) selTB.Focus();
        }

        /// <summary>
        /// Adds a 0 to the selected Textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnZero_Click(object sender, EventArgs e)
        {
            selTB.Text += "0";

            if (selTB != null) selTB.Focus();
        }
        /// <summary>
        /// When the additoion button is clicked it makes sure only 1 can go into operator, and
        /// allows it to be added to other textboxes as necessary.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (TxtOperator.TextLength < 1)
            {
                selTB.Text += "+";

                if (selTB != null) selTB.Focus();
            }
            else if (selTB.Name != "TxtOperator")
            {
                selTB.Text += "+";

                if (selTB != null) selTB.Focus();
            }
        }
        /// <summary>
        /// When the subtraction button is clicked, it makes sure you can't add it to any textbox except
        /// the operator textbox. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (TxtOperator.TextLength < 1)
            {
                selTB.Text += "-";

                if (selTB != null) selTB.Focus();
            }
            else if (selTB.Name != "TxtOperator")
            {
                selTB.Text += "-";

                if (selTB != null) selTB.Focus();
            }
        }

        /// <summary>
        /// When the multiplation button is clicked, it makes sure you can't add it to any textbox except
        /// the operator textbox. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (TxtOperator.TextLength < 1 && selTB.Name == "TxtOperator")
            {
                selTB.Text += "x";

                if (selTB != null) selTB.Focus();
            }  

        }

        /// <summary>
        /// When the division button is clicked, it makes sure you can't add it to any textbox except
        /// the operator textbox. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (TxtOperator.TextLength < 1 && selTB.Name == "TxtOperator")
            {
                selTB.Text += "/";

                if (selTB != null) selTB.Focus();
            }
        }
        /// <summary>
        /// Adds an i to the selected Textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnComplex_Click(object sender, EventArgs e)
        {
            selTB.Text += "i";

            if (selTB != null) selTB.Focus();
        }
        /// <summary>
        /// Adds an . to the selected Textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            selTB.Text += ".";

            if (selTB != null) selTB.Focus();
        }

        /// <summary>
        /// Chooses which method to do based on the operator they set. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCalculate_Click(object sender, EventArgs e) {

            
            string regexPattern =
                // Match any float, negative or positive, group it
                @"([-+]?\d+\.?\d*|[-+]?\d*\.?\d+)" +
                // ... possibly following that with whitespace
                @"\s*" +
                // ... followed by a plus
                @"\-|\+" +
                // and possibly more whitespace:
                @"\s*" +
                // Match any other float, and save it
                @"([-+]?\d+\.?\d*|[-+]?\d*\.?\d+)" +
                // ... followed by 'i'
                @"i";
            Regex regex = new Regex(regexPattern);

            if (regex.IsMatch(TxtOperandOne.Text) && regex.IsMatch(TxtOperandTwo.Text))
            {

                calculator.setOperator(TxtOperator.Text[0]);

                //splits the operants into real and complex numbers and adds them to the ComplexDataclass object. 
                OperandSplitter(TxtOperandOne.Text, operandOne);
                OperandSplitter(TxtOperandTwo.Text, operandTwo);

                if (calculator.getOperator() == '+')
                {
                    TxtResult.Text = calculator.Add(operandOne, operandTwo);
                }
                else if (calculator.getOperator() == '-')
                {
                    TxtResult.Text = calculator.Subtract(operandOne, operandTwo);
                }
                else if (calculator.getOperator() == 'x')
                {
                    TxtResult.Text = calculator.Multiply(operandOne, operandTwo);
                }
                else if (calculator.getOperator() == '/')
                {
                    TxtResult.Text = calculator.Divide(operandOne, operandTwo).Replace("\n", Environment.NewLine);
                }
            } else
            {
                MessageBox.Show("Operands are not formatted correctly.");
            }
        }
        /// <summary>
        /// Splits the operand into 2 data types: real number and complex number. 
        /// </summary>
        /// <param name="operand">This is the original operand from textbox. It uses this operand
        /// to split it and put real and complex numbers into the class object. </param>
        /// <param name="OperandObject"> puts in operand object so you can get the real number and 
        /// imaginary numbers</param>
        public void OperandSplitter(string operand, ComplexData OperandObject)
        {
            string newTxtOperand = operand;
            string sign = "";
             if (operand.StartsWith("-"))
            {
                newTxtOperand = operand.Substring(1);
                sign = "-"; 
            }

            if (newTxtOperand.Contains("+"))
            {
                string[] operandOneArray = newTxtOperand.Split('+');
                operandOneArray[0] = operandOneArray[0].Insert(0, sign);
                OperandObject.setRealNumber(Double.Parse(operandOneArray[0]));
                OperandObject.setComplexNumber(Double.Parse(operandOneArray[1].TrimEnd('i')));
            }
            else if (newTxtOperand.Contains("-"))
            {
                string[] operandOneArray = newTxtOperand.Split('-');
                operandOneArray[0] = operandOneArray[0].Insert(0, sign);
                operandOneArray[1] = operandOneArray[1].Insert(0, "-");
                OperandObject.setRealNumber(Double.Parse(operandOneArray[0]));
                operandOneArray[1].TrimEnd('i');
                OperandObject.setComplexNumber(Double.Parse(operandOneArray[1].TrimEnd('i')));
            }
        }
        /// <summary>
        /// Clears the textbox that is selected. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            selTB.Text = "";

            if (selTB != null) selTB.Focus();
        }
    }
}

