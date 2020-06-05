using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class iCalculator : Form
    {
        public iCalculator()
        {
            InitializeComponent();
            KeyPreview = true;

        }

        public int minLength = 6;
        public string Result="0";
        public double FirstArgument = 0;
        public string MathAction = "";
        public Font font34 = new Font("Microsoft Sans Serif", 34, FontStyle.Regular, GraphicsUnit.Point, ((byte)(22)));
        public Font font22 = new Font("Microsoft Sans Serif", 22, FontStyle.Regular, GraphicsUnit.Point, ((byte)(22)));
        public Font font12 = new Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point, ((byte)(12)));

        private void ChangeLabel()
        {
            CheckWindowSize();
            int tempLength = Result.Length;

            if (tempLength >= minLength && tempLength < minLength * 2)
            {
                labelResult.Font = font22;
            }
            else if (tempLength >= 2 * minLength && tempLength < minLength * 3)
            {
                labelResult.Font = font12;
            }
            else if (tempLength/minLength < 1)
            {
                labelResult.Font = font34;
            }
            labelResult.Text = Result;
        }
        private void iCalculator_Resize(object sender, EventArgs e)
        {
            ChangeLabel();
        }
        private void CheckWindowSize()
        {
            if (ClientSize.Width < 350)
            {
                minLength = 6;
            }
            else if (ClientSize.Width < 450)
            {
                minLength = 12;
            }
            else if (ClientSize.Width < 550)
            {
                minLength = 16;
            }
            else if (ClientSize.Width < 750)
            {
                minLength = 20;
            }
        }
        private void RememberFirstArgument()
        {
            FirstArgument = double.Parse(Result);
            DropLabel();
        }

        private void DropLabel()
        {
            Result = "0";
            ChangeLabel();
        }

        private void Calculation()
        {

            switch (MathAction)
            {
                case "division":
                    Result = (FirstArgument / double.Parse(Result)).ToString();
                    break;
                case "multiply":
                    Result = (FirstArgument * double.Parse(Result)).ToString();
                    break;
                case "minus":
                    Result = (FirstArgument - double.Parse(Result)).ToString();
                    break;
                case "plus":
                    Result = (FirstArgument + double.Parse(Result)).ToString();
                    break;
            }
            Clipboard.SetText(Result);
            FirstArgument = double.Parse(Result);
            ChangeLabel();
        }

        #region NumButtonsClick
        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (Result == "0")
            {
                Result = "7";
                ChangeLabel();
            }
            else
            {
                Result = Result + "7";
                ChangeLabel();
            }

        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (Result == "0")
            {
                Result = "8";
                ChangeLabel();
            }
            else
            {
                Result = Result + "8";
                ChangeLabel();
            }
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            if (Result == "0")
            {
                Result = "9";
                ChangeLabel();
            }
            else
            {
                Result = Result + "9";
                ChangeLabel();
            }
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (Result == "0")
            {
                Result = "4";
                ChangeLabel();
            }
            else
            {
                Result = Result + "4";
                ChangeLabel();
            }
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (Result == "0")
            {
                Result = "5";
                ChangeLabel();
            }
            else
            {
                Result = Result + "5";
                ChangeLabel();
            }
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (Result == "0")
            {
                Result = "6";
                ChangeLabel();
            }
            else
            {
                Result = Result + "6";
                ChangeLabel();
            }
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (Result == "0")
            {
                Result = "1";
                ChangeLabel();
            }
            else
            {
                Result = Result + "1";
                ChangeLabel();
            }
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (Result == "0")
            {
                Result = "2";
                ChangeLabel();
            }
            else
            {
                Result = Result + "2";
                ChangeLabel();
            }
        }

        private void buttonThird_Click(object sender, EventArgs e)
        {
            if (Result == "0")
            {
                Result = "3";
                ChangeLabel();
            }
            else
            {
                Result = Result + "3";
                ChangeLabel();
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (Result == "0")
            {

            }
            else 
            {
                Result = Result + "0";
                ChangeLabel();
            }
        }
        #endregion



        private void buttonCE_Click(object sender, EventArgs e)
        {
            DropLabel();
        }

        #region MathActionsClick
        private void buttonDivision_Click(object sender, EventArgs e)
        {
            RememberFirstArgument();
            MathAction = "division";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            RememberFirstArgument();
            MathAction = "multiply";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            RememberFirstArgument();
            MathAction = "minus";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            RememberFirstArgument();
            MathAction = "plus";
        }
        #endregion 
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            Calculation();
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (Result.IndexOf(",") == -1)
            {
                Result = String.Concat(Result, ",");
                ChangeLabel();
            }
            else
            {
                
            }
        }

        private void iCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    buttonZero.PerformClick();
                    break;
                case '1':
                    buttonOne.PerformClick();
                    break;
                case '2':
                    buttonTwo.PerformClick();
                    break;
                case '3':
                    buttonThird.PerformClick();
                    break;
                case '4':
                    buttonFour.PerformClick();
                    break;
                case '5':
                    buttonFive.PerformClick();
                    break;
                case '6':
                    buttonSix.PerformClick();
                    break;
                case '7':
                    buttonSeven.PerformClick();
                    break;
                case '8':
                    buttonEight.PerformClick();
                    break;
                case '9':
                    buttonNine.PerformClick();
                    break;
                case '+':
                    buttonPlus.PerformClick();
                    break;
                case '-':
                    buttonMinus.PerformClick();
                    break;
                case '/':
                    buttonDivision.PerformClick();
                    break;
                case '*':
                    buttonMultiply.PerformClick();
                    break;
                case '=':
                    buttonEqual.PerformClick();
                    break;
                case '.':
                    buttonDot.PerformClick();
                    break;
                case ',':
                    buttonDot.PerformClick();
                    break;
                case (char)13:
                    buttonEqual.PerformClick();
                    break;

                default:
                    break;
            }

        }
    }
}
