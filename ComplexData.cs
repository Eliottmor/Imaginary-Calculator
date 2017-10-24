
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
    public class ComplexData
    {
        double realNumber;
        double complexNumber;

        public void setRealNumber(double number)
        {
            realNumber = number;
        }
        public void setComplexNumber(double number)
        {
            complexNumber = number;
        }

        public double getRealNumber()
        {
            return realNumber;
        }

        public double getComplexNumber()
        {
            return complexNumber;
        }
    }
}
