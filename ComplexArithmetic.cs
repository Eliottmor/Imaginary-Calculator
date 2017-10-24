
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_EM
{
    class ComplexArithmetic
    {
        string result;
        char operation;
        double realNumberResult;
        double imagNumberResult; 



        public char getOperator()
        {
            return operation;
        }

        public void setOperator(char op)
        {
            operation = op; 
        }
        /// <summary>
        /// Adds the two operands together
        /// </summary>
        /// <param name="one">operand one</param>
        /// <param name="two">operand two</param>
        /// <returns></returns>
        public string Add(ComplexData one, ComplexData two)
        {
            
            realNumberResult = one.getRealNumber() + two.getRealNumber();
            imagNumberResult = one.getComplexNumber() + two.getComplexNumber();

            result = realNumberResult + "" + imagNumberResult.ToString("+0.###;-#.###") + "i"; 
            return result; 
        }
        /// <summary>
        /// subtracts the two operands together
        /// </summary>
        /// <param name="one">operand one</param>
        /// <param name="two">operand two</param>
        /// <returns></returns>
        public string Subtract(ComplexData one, ComplexData two)
        {
            realNumberResult = one.getRealNumber() - two.getRealNumber();
            imagNumberResult = one.getComplexNumber() - two.getComplexNumber();

            result = realNumberResult +  "" + imagNumberResult.ToString("+0.###;-#.###") + "i";
            
            return result;
        }

        /// <summary>
        /// Multiplies
        /// </summary>
        /// <param name="one">operand one</param>
        /// <param name="two">operand two</param>
        /// <returns></returns>
        public string Multiply(ComplexData one, ComplexData two)
        {
            
            realNumberResult = (one.getRealNumber() * two.getRealNumber()) + ((two.getComplexNumber() * one.getComplexNumber()) * -1);
            imagNumberResult = (one.getComplexNumber() * two.getRealNumber()) + (two.getComplexNumber() * one.getRealNumber());

            result = realNumberResult + "" + imagNumberResult.ToString("+0.###;-#.###") + "i";

            return result;
        }

        /// <summary>
        /// Divides
        /// </summary>
        /// <param name="one">operand one</param>
        /// <param name="two">operand two</param>
        /// <returns></returns>
        public string Divide(ComplexData one, ComplexData two)
        {
            ComplexData conjugate = new ComplexData();
            string numerator = "";
            string denominator = "";
            conjugate.setComplexNumber(two.getComplexNumber() * -1);
            conjugate.setRealNumber(two.getRealNumber());
            numerator = Multiply(one, conjugate);
            denominator = Multiply(two, conjugate);

            result = numerator + "\n" + "-----------\n" + denominator; 
            return result;
        }
    }
}
