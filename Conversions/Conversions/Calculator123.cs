using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    class Calculator123
    {
        private double num1 = 0, num2 = 0, total = 0;
        //public double num1 = 0, num2 = 0;
        public Calculator123()
        {

        }
        public Calculator123(double num1, double num2, double total)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.total = total;
        }

        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }
        
        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public double Add()
        {
            total = (num1 + num2);
            return total;
        }

        public double Sub()
        {
            if(num1 > num2)
            { 
                total = (num1 - num2);
                
            }
            else
            {
                total = (num2 - num1);
            }
            return total;
        }

        public double Mul()
        {
            if(num1>0 && num2>0)
            { 
               total = (num1 * num2);
            }
            else
            {
                MessageBox.Show("Please enter number greater than 0");
            }
            return total;
        }

        public double Div()
        {
            if(num1>0 && num2>0)
            { 
                total = (num1 / num2);
            }
            else
            {
                MessageBox.Show("Please enter number greater than 0","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return total;
        }
    }
}
