using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace expressionCalc
{
    public partial class frmExpCalc : Form
    {
        public frmExpCalc()
        {
            InitializeComponent();
        }

        private static String text = "";
        private void expression_TextChanged(object sender, EventArgs e)
        {            
                if (expText.Text != "")
                {
                    OK.Enabled = true;
                    if (expText.Text[(expText.Text.Length - 1)] == '\n')
                    {
                        try
                        {
                            answer.Text = "" + calculate(expText.Text,0);
                            expText.Text = "";
                        }
                        catch (Exception)
                        {
                            answer.Text = "Malform Expresion !";
                            expText.Text = text;
                        }
                    }
                    else
                    {
                        text = expText.Text;
                    }
                }
                else
                {
                    OK.Enabled = false;
                }
            }            
          
////////////////////////////////////////////////////////////////////////////////////////////
        public static long fact(int no)
        {
            if (no == 0)
            {
                return 1;
            }
            else
            {
                return no * fact(no - 1);
            }
            
        }

        public static long nPr(int n, int r)
        {
            return (fact(n) / fact(n - r));
        }

        public static double nCr(int n, int r)
        {
            return (fact(n) / (fact(n - r) * fact(r)));
        }

        public static double log(double b, double no) 
        {
            return (Math.Log(no) / Math.Log(b));
        }

        public static double rad(double ang)
        {
            return (Math.PI / 180 * ang);
        }

        public static double ang(double rad)
        {
            return (180 / Math.PI * rad);
        }

        public static double sec(double rad)
        {
            return (1 / Math.Cos(rad));
        }

        public static double cosec(double rad)
        {
            return (1 / Math.Sin(rad));
        }

        public static double cot(double rad)
        {
            return (1 / Math.Tan(rad));
        }

        public static double asec(double sec)
        {
            return (Math.Acos(1 / sec));
        }

        public static double acosec(double cosec)
        {
            return (Math.Asin(1 / cosec));
        }

        public static double acot(double cot)
        {
            return (Math.Atan(1 / cot));
        }

        public static double cbrt(double no)
        {
            return (Math.Pow(no, (Double.Parse("1")/Double.Parse("3"))));
        }        
////////////////////////////////////////////////////////////////////////////////////////////
       public static double calculate(String expression,int Opt)
        {
            byte brackets = 0, opt = 0;
            double ans = 0;            
            Boolean no1 = false, no2 = false, func = false;
            char op = '#';
            String No1 = "", No2 = "", exp = "", values = "";

            for (int i = 0; i < expression.Length; i++)
            {
                if (brackets == 0)
                {
                    switch (expression[i])
                    {
                        case '(':                            
                            brackets++;
                            break;
///////////////////////////////////////////////////////////////////////////////////////////
                        /* operator codes
                     * 11-lg	12-ln	13-log
                     * 21-sin	22-sec	23-sqrt
                     * 31-cos	32-cot	33-cosec    34-cbrt
                     * 41-tan
                     * 51-asin	52-acos	53-atan	54-acosec
                     * 55-asec	56-acot 57-ang  58-abs
                     */

                    case 'l':
                        if (i <= expression.Length - 3) 
                        {
                            if (expression[i + 1] == 'g' & expression[i + 2] == '(')
                            {
                                opt = 11;
                                func = true;
                                brackets++;
                                i += 2;
                            }
                            else if (expression[i + 1] == 'n' & expression[i + 2] == '(')
                            {
                                opt = 12;
                                func = true;
                                brackets++;
                                i += 2;
                            } else if (i <= expression.Length - 4) 
                            {
                                if (expression[i + 1] == 'o' & expression[i + 2] == 'g' & expression[i + 3] == '(') 
                                {
                                    opt = 13;
                                    func = true;
                                    brackets++;
                                    i += 3;
                                }
                            }
                        }
                        break;
                    case 's':
                        if (i <= expression.Length - 4)
                        {
                            if (expression[i + 1] == 'i' & expression[i + 2] == 'n' & expression[i + 3] == '(') 
                            {
                                opt = 21;
                                func = true;
                                brackets++;
                                i += 3;
                            } else if (expression[i + 1] == 'e' & expression[i + 2] == 'c' & expression[i + 3] == '(') 
                            {
                                opt = 22;
                                func = true;
                                brackets++;
                                i += 3;
                            }
                            else if (i <= expression.Length - 5)
                            {
                                if (expression[i + 1] == 'q' & expression[i + 2] == 'r' & expression[i + 3] == 't' & expression[i + 4] == '(') 
                                {
                                    opt = 23;
                                    func = true;
                                    brackets++;
                                    i += 4;
                                }
                            }
                        }
                        break;
                    case 'c':
                        if (i <= expression.Length - 4)
                        {
                            if (expression[i + 1] == 'o' & expression[i + 2] == 's' & expression[i + 3] == '(') 
                            {
                                opt = 31;
                                func = true;
                                brackets++;
                                i += 3;
                            } else if (expression[i + 1] == 'o' & expression[i + 2] == 't' & expression[i + 3] == '(') 
                            {
                                opt = 32;
                                func = true;
                                brackets++;
                                i += 3;
                            }
                            else if (i <= expression.Length - 5 & expression[i + 1] == 'b')
                            {
                                if (expression[i + 2] == 'r' & expression[i + 3] == 't' & expression[i + 4] == '(') 
                                {
                                    opt = 34;
                                    func = true;
                                    brackets++;
                                    i += 4;
                                }
                            }
                            else if (i <= expression.Length - 6)
                            {
                                if (expression[i + 1] == 'o' & expression[i + 2] == 's' & expression[i + 3] == 'e' & expression[i + 4] == 'c' & expression[i + 5] == '(') 
                                {
                                    opt = 33;
                                    func = true;
                                    brackets++;
                                    i += 5;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incomplete input for nCr\nAnswer can be wrong\n\nFor nCr give capital C, for cos, cot, and cosec give simple c", "Malform expression");
                            }
                        } 
                        else 
                        {
                            MessageBox.Show("Incomplete input for nCr\nAnswer can be wrong\n\nFor nCr give capital C, for cos, cot, and cosec give simple c", "Malform expression");
                        }
                        break;
                    case 't':
                        if (i <= expression.Length - 4)
                        {
                            if (expression[i + 1] == 'a' & expression[i + 2] == 'n' & expression[i + 3] == '(') 
                            {
                                opt = 41;
                                func = true;
                                brackets++;
                                i += 3;
                            }
                        }
                        break;
                    case 'a':
                        if (i <= expression.Length - 4 & expression[i + 1] == 'n')
                        {
                            if (expression[i + 2] == 'g' & expression[i + 3] == '(') 
                            {
                                opt = 57;
                                func = true;
                                brackets++;
                                i += 3;
                            }
                        }
                        else if (i <= expression.Length - 4 & expression[i + 1] == 'b')
                        {
                            if (expression[i + 2] == 's' & expression[i + 3] == '(')
                            {
                                opt = 58;
                                func = true;
                                brackets++;
                                i += 3;
                            }
                        }
                        else if (i <= expression.Length - 5)
                        {
                            if (expression[i + 1] == 's' & expression[i + 2] == 'i' & expression[i + 3] == 'n' & expression[i + 4] == '(') 
                            {
                                opt = 51;
                                func = true;
                                brackets++;
                                i += 4;
                            } else if (expression[i + 1] == 'c' & expression[i + 2] == 'o' & expression[i + 3] == 's' & expression[i + 4] == '(') 
                            {
                                opt = 52;
                                func = true;
                                brackets++;
                                i += 4;
                            } else if (expression[i + 1] == 't' & expression[i + 2] == 'a' & expression[i + 3] == 'n' & expression[i + 4] == '(') 
                            {
                                opt = 53;
                                func = true;
                                brackets++;
                                i += 4;
                            } else if (expression[i + 1] == 's' & expression[i + 2] == 'e' & expression[i + 3] == 'c' & expression[i + 4] == '(') 
                            {
                                opt = 55;
                                func = true;
                                brackets++;
                                i += 4;
                            } else if (expression[i + 1] == 'c' & expression[i + 2] == 'o' & expression[i + 3] == 't' & expression[i + 4] == '(') 
                            {
                                opt = 56;
                                func = true;
                                brackets++;
                                i += 4;
                            }
                            else if (i <= expression.Length - 7)
                            {
                                if (expression[i + 1] == 'c' & expression[i + 2] == 'o' & expression[i + 3] == 's' & expression[i + 4] == 'e' & expression[i + 5] == 'c' & expression[i + 6] == '(') 
                                {
                                    opt = 54;
                                    func = true;
                                    brackets++;
                                    i += 7;
                                }
                            }
                        }
                        break;
                    case 'r':
                        if (i <= expression.Length - 4)
                        {
                            if (expression[i + 1] == 'a' & expression[i + 2] == 'd' & expression[i + 3] == '(') 
                            {
                                opt = 61;
                                func = true;
                                brackets++;
                                i += 3;
                            }
                        }
                        break;
///////////////////////////////////////////////////////////////////////////////////////////
                        case '/':
                        case '*':
                        case '%':
                        case '^':
                        case 'P':
                        case 'C':
                        case ',':
                            if (No1.Length > 0 & No2.Length > 0)
                            {
                                switch (op)
                                {
                                    case '*':
                                        ans = Double.Parse(No1) * Double.Parse(No2);
                                        break;
                                    case '/':
                                        ans = Double.Parse(No1) / Double.Parse(No2);
                                        break;
                                    case '%':
                                        ans = Double.Parse(No1) % Double.Parse(No2);
                                        break;
                                    case '^':
                                        ans = Math.Pow(Double.Parse(No1), Double.Parse(No2));
                                        break;
                                    case 'P':
                                        if (Double.Parse(No1) >= 0 & Double.Parse(No2) >= 0)
                                        {
                                            ans = nPr((int)Double.Parse(No1), (int)Double.Parse(No2));
                                        }
                                        else
                                        {
                                            MessageBox.Show("There is a negative values for nPr function\nAnswer can be wrong", "Malform expression");
                                        }
                                        break;
                                    case 'C':
                                        if (Double.Parse(No1) >= 0 & Double.Parse(No2) >= 0)
                                        {
                                            ans = nCr((int)Double.Parse(No1), (int)Double.Parse(No2));
                                        }
                                        else
                                        {
                                            MessageBox.Show("There is a negative values for nCr function\nAnswer can be wrong", "Malform expression");
                                        }
                                        break;
                                    case ',':
                                        if (Opt == 13 & Double.Parse(No1) >= 0 & Double.Parse(No2) >= 0) 
                                        {
                                            ans = log(Double.Parse(No1), Double.Parse(No2));
                                        } 
                                        else 
                                        {
                                            MessageBox.Show("\n(X) Malform expression, Found invalid charactor ',' or Negative number for log()\nAnswer can be wrong");
                                        }
                                        break;
                                }
                                No1 = ""+ans;
                                no1 = true;
                                No2 = "";
                                no2 = false;
                                ans = 0;
                            }
                            else if (No1.Length > 0)
                            {
                                no1 = true;
                            }
                            op = expression[i];
                            break;
                        case '+':
                        case '-':                        
                            if (no1 == false & No1.Length == 0)
                            {
                                No1 = "" + expression[i];
                            }
                            else if (no1 == false & No1.Length > 0)
                            {                                
                                if (No1.Length <= 1 & (No1[0] == '+' | No1[0] == '-')) 
                                {
	                                if (expression[i] == '+' & No1=="+") 
	                                {
		                                No1 = "+";
                                    } 
	                                else if ((expression[i] == '+' & No1=="-") | (expression[i] == '-' & No1=="+")) 
	                                {
		                                No1 = "-";
	                                } else if (expression[i] == '-' & No1=="-") 
	                                {
		                                No1 = "+";
	                                }
                                } else 
                                {
	                                values += No1+",";
	                                No1 = "";
	                                No1 += expression[i];
	                                no1 = false;
                                }                                 
                            }

                            if (no1 == true & No2.Length == 0)
                            {
                                No2 += expression[i];
                            }
                            else if (no1 == true & No2.Length > 0)
                            {
                                switch (op)
                                {
                                    case '*':
                                        ans = Double.Parse(No1) * Double.Parse(No2);
                                        break;
                                    case '/':
                                        ans = Double.Parse(No1) / Double.Parse(No2);
                                        break;
                                    case '%':
                                        ans = Double.Parse(No1) % Double.Parse(No2);
                                        break;
                                    case '^':
                                        ans = Math.Pow(Double.Parse(No1), Double.Parse(No2));
                                        break;
                                    case 'P':
                                        if (Double.Parse(No1) >= 0 & Double.Parse(No2) >= 0)
                                        {
                                            ans = nPr((int)Double.Parse(No1), (int)Double.Parse(No2));
                                        }
                                        else
                                        {
                                            MessageBox.Show("There is a negative values for nPr function\nAnswer can be wrong", "Malform expression");
                                        }
                                        break;
                                    case 'C':
                                        if (Double.Parse(No1) >= 0 & Double.Parse(No2) >= 0)
                                        {
                                            ans = nCr((int)Double.Parse(No1), (int)Double.Parse(No2));
                                        }
                                        else
                                        {
                                            MessageBox.Show("There is a negative values for nCr function\nAnswer can be wrong", "Malform expression");
                                        }
                                        break;
                                    case ',':
                                        if (Opt == 13 & Double.Parse(No1) >= 0 & Double.Parse(No2) >= 0)
                                        {
                                            ans = log(Double.Parse(No1), Double.Parse(No2));
                                        }
                                        else
                                        {
                                            MessageBox.Show("Found invalid charactor ',' or Negative number for log()\nAnswer can be wrong", "Malform expression");
                                        }
                                        break;
                                }
                                values+=ans+",";
                                ans = 0;
                                No1 = "";
                                No1 += expression[i];
                                no1 = false;
                                No2 = "";
                                no2 = false;
                            }
                            break;
                        case '.':
                            if (no1 == false & No1.Length > 0)
                            {
                                No1 += ".";
                            }
                            else if (no1 == false & No1.Length == 0)
                            {
                                No1 += "0.";
                            }
                            else if (no2 == false & No2.Length > 0)
                            {
                                No2 += ".";
                            }
                            else if (no2 == false & No2.Length == 0)
                            {
                                No2 += "0.";
                            }
                            break;
                        case 'e':
                        case 'p':                        
                            double no = 0.0;
                            if (expression[i] == 'p' & i != expression.Length - 1)
                            {
                                if (expression[i + 1] == 'i')
                                {
                                    no = Math.PI;
                                }
                                else
                                {
                                    MessageBox.Show("Incomplete input for pi\nAnswer can be wrong\n\nFor nPr give capital P, for pi give simple pi", "Malform expression");                                    
                                }
                            }
                            else if (expression[i] == 'e')
                            {
                                no = Math.E;
                            }                              
                            else 
                            {
                                MessageBox.Show("Incomplete input for pi\nAnswer can be wrong\n\nFor nPr give capital P, for pi give simple pi", "Malform expression");
                            }
                            
                            if (no1 == false)
                            {
                                if (No1.Length == 0)
                                {
                                    No1 += no;
                                }
                                else if (No1.Length == 1 & (No1[0] == '+' | No1[0] == '-'))
                                {
                                    No1 += no;
                                } 
                                else
                                {
                                    No1 = "" + Double.Parse(No1) * no;
                                }
                            } 
                            else if (no2 == false)
                            {
                                if (No2.Length == 0)
                                {
                                    No2 += no;
                                } 
                                else if (No2.Length == 1 & (No2[0] == '+' | No2[0] == '-'))
                                {
                                    No2 += no;
                                } 
                                else 
                                {
                                    No2 = "" + Double.Parse(No2) * no;
                                }
                            } 
                            else if (no2 == true)
                            {
                                if (op == '*')
                                {
                                    ans = Double.Parse(No1) * Double.Parse(No2);
                                }
                                No1 = "" + ans;
                                no1 = true;
                                No2 = "" + no;
                                no2 = false;
                            }
                            break;
                            case '!':
                                if (no1 == false & No1.Length >= 1)
                                {
                                    if (No1.Length == 1 & No1[0] == '+')
                                    {
                                        No1 += 1;
                                    }
                                    else if (Double.Parse(No1) >= 0)
                                    {
                                        No1 = "" + (fact((int) (Double.Parse(No1))));
                                    }
                                    else
                                    {
                                        No1 = "-" + fact((int)Math.Abs(Double.Parse(No1)));
                                    }
                                }
                                else if (no2 == false & No2.Length >= 1)
                                {
                                    if (No2.Length == 1 & No2[0] == '+')
                                    {
                                        No2 += 1;
                                    } 
                                    else if (Double.Parse(No2) >= 0)
                                    {
                                        No2 = "" + (fact((int) (Double.Parse(No2))));
                                    } 
                                    else
                                    {
                                        No2 = "-" + fact((int)Math.Abs(Double.Parse(No2)));
                                    }
                                }
                                else if (no2 == true)
                                {
                                    if (Double.Parse(No2) >= 0)
                                    {
                                        No2 = "" + fact((int)(Double.Parse(No2)));
                                    }
                                    else
                                    {
                                        No2 = "-" + fact((int)Math.Abs(Double.Parse(No2)));
                                    }
                                    no2 = false;
                                }
                                break;
                        default:
                            if (expression[i] + 0 >= 48 & expression[i] + 0 <= 57)
                            {
                                if (no1 == false)
                                {
                                    No1 += expression[i];
                                }
                                else if (no2 == false)
                                {
                                    No2 += expression[i];
                                }
                                else if (no2 == true)
                                {
                                    if (op == '*')
                                    {
                                        ans = Double.Parse(No1) * Double.Parse(No2);                                            
                                    }
                                    No1 = "" + ans;
                                    no1 = true;
                                    No2 = "" + expression[i];
                                    no2 = false;
                                }
                            }
                            break;
                    }//end of the main switch

                    /*
                     * Prepare process for recursion
                     */
                    if (brackets == 1 | func == true) 
                    {
                        if (no1 == false & No1.Length == 0)
                        {
                            no1 = true;
                            No1 = "1";
                            op = '*';
                        }
                        else if (no1 == false & No1.Length > 0)
                        {
                            if (No1.Length == 1)
                            {
                                switch (No1[0])
                                {
                                    case '+':
                                    case '-':
                                        No1 += "1";
                                        break;
                                }
                            }
                            no1 = true;
                            op = '*';
                        }
                        else if (No1.Length > 0 & No2.Length > 0)
                        {
                            switch (op)
                            {
                                case '*':
                                    ans = Double.Parse(No1) * Double.Parse(No2);
                                    break;
                                case '/':
                                    ans = Double.Parse(No1) / Double.Parse(No2);
                                    break;
                                case '%':
                                    ans = Double.Parse(No1) % Double.Parse(No2);
                                    break;
                                case '^':
                                    ans = Math.Pow(Double.Parse(No1), Double.Parse(No2));
                                    break;
                                case 'P':
                                    if (Double.Parse(No1) >= 0 & Double.Parse(No2) >= 0)
                                    {
                                        ans = nPr((int)Double.Parse(No1), (int)Double.Parse(No2));
                                    }
                                    else
                                    {
                                        MessageBox.Show("There is a negative values for nPr function\nAnswer can be wrong", "Malform expression");
                                    }
                                    break;
                                case 'C':
                                    if (Double.Parse(No1) >= 0 & Double.Parse(No2) >= 0)
                                    {
                                        ans = nCr((int)Double.Parse(No1), (int)Double.Parse(No2));
                                    }
                                    else
                                    {
                                        MessageBox.Show("There is a negative values for nCr function\nAnswer can be wrong", "Malform expression");
                                    }
                                    break;
                                case ',':
                                    if (Opt == 13 & Double.Parse(No1) >= 0 & Double.Parse(No2) >= 0)
                                    {
                                        ans = log(Double.Parse(No1), Double.Parse(No2));
                                    }
                                    else
                                    {
                                        MessageBox.Show("Found invalid charactor ',' or Negative number for log()\nAnswer can be wrong","Malform expression");
                                    }
                                    break;
                            }
                            No1 = "" + ans;
                            op = '*';
                        }
                        exp = "";
                        No2 = "";
                        no2 = false;
                        ans = 0;
                    }
                }//end of the main if
                else
                {
                    //recurtion point
                    switch (expression[i])
                    {
                        case '(':
                            brackets++;
                            break;
                        case ')':
                            brackets--;
                            break;
                    }

                    if (brackets == 0)
                    {                        
                        if (func == true) 
                        {
                            switch (opt) 
                            {
                                case 11:
                                    ans = Math.Log10(calculate(exp,0));
                                    break;
                                case 12:
                                    ans = Math.Log(calculate(exp,0));
                                    break;
                                case 13:                                    
                                    String[] tempLog = exp.Split(',');
                                    if (tempLog.Length > 1) 
                                    {
                                        ans = calculate(exp,13);
                                    } else 
                                    {
                                        MessageBox.Show("Incomplete input for log() base or no is missing\nAnswer can be wrong\n\n\nFor log() give log(base,no)", "Malform expression");
                                        ans = 0;
                                    }                                    
                                    break;
                                case 21:
                                    ans = Math.Sin(calculate(exp,0));
                                    break;
                                case 22:
                                    ans = sec(calculate(exp,0));
                                    break;
                                case 23:
                                    ans = Math.Sqrt(calculate(exp,0));
                                    break;
                                case 31:
                                    ans = Math.Cos(calculate(exp,0));
                                    break;
                                case 32:
                                    ans = cot(calculate(exp,0));
                                    break;
                                case 33:
                                    ans = cosec(calculate(exp,0));
                                    break;
                                case 34:
                                    ans = cbrt(calculate(exp,0));                                    
                                    break;
                                case 41:
                                    ans = Math.Tan(calculate(exp,0));
                                    break;
                                case 51:
                                    ans = Math.Asin(calculate(exp,0));
                                    break;
                                case 52:
                                    ans = Math.Acos(calculate(exp,0));
                                    break;
                                case 53:
                                    ans = Math.Atan(calculate(exp,0));
                                    break;
                                case 54:
                                    ans = acosec(calculate(exp,0));
                                    break;
                                case 55:
                                    ans = asec(calculate(exp,0));
                                    break;
                                case 56:
                                    ans = acot(calculate(exp,0));
                                    break;
                                case 57:
                                    ans = ang(calculate(exp,0));
                                    break;
                                case 58:
                                    ans = Math.Abs(calculate(exp,0));
                                    break;
                                case 61:
                                    ans = rad(calculate(exp,0));
                                    break;
                            }
                            opt = 0;
                            func = false;
                        }else
                        {
                            ans = calculate(exp,0);
                        }                       
                        No2 += ""+ans;
                        no2 = true;
                        ans = 0;
                    }
                    else
                    {
                        exp += expression[i];
                    }
                }

                if (i == expression.Length - 1)
                {
                    if (no1 == false & No1.Length > 0)
                    {
                        values+=No1+",";
                    }
                    else if (no1 == true & No2.Length == 0)
                    {
                        values+=No1+",";
                    }
                    else if (no1 = true & No2.Length > 0)
                    {
                        switch (op)
                        {
                            case '/':
                                ans = Double.Parse(No1) / Double.Parse(No2);
                                break;
                            case '*':
                                ans = Double.Parse(No1) * Double.Parse(No2);
                                break;
                            case '%':
                                ans = Double.Parse(No1) % Double.Parse(No2);
                                break;
                            case '^':
                                ans = Math.Pow(Double.Parse(No1), Double.Parse(No2));
                                break;
                            case 'P':
                                if (Double.Parse(No1) >= 0 & Double.Parse(No2) >= 0)
                                {
                                    ans = nPr((int)Double.Parse(No1), (int)Double.Parse(No2));
                                }
                                else
                                {
                                    MessageBox.Show("There is a negative values for nPr function\nAnswer can be wrong", "Malform expression");
                                }
                                break;
                            case 'C':
                                if (Double.Parse(No1) >= 0 & Double.Parse(No2) >= 0)
                                {
                                    ans = nCr((int)Double.Parse(No1), (int)Double.Parse(No2));
                                }
                                else
                                {
                                    MessageBox.Show("There is a negative values for nCr function\nAnswer can be wrong", "Malform expression");
                                }
                                break;
                            case ',':
                                if (Opt == 13 & Double.Parse(No1) >= 0 & Double.Parse(No2) >= 0)
                                {
                                    ans = log(Double.Parse(No1), Double.Parse(No2));
                                }
                                else
                                {
                                    MessageBox.Show("Found invalid charactor ',' or Negative number for log()\nAnswer can be wrong","Malform expression");
                                }
                                break;
                            case '+':
                                ans = Double.Parse(No1) + Double.Parse(No2);
                                break;
                            case '-':
                                ans = Double.Parse(No1) - Double.Parse(No2);
                                break;
                        }
                    }
                }
            }

            if (brackets > 0) 
            {
                if (brackets > 1) 
                {
                    MessageBox.Show("There are " + brackets + " brackets without closing\nAnswer can be wrong","Malform expression");
                } else 
                {
                    MessageBox.Show("There is one bracket without closing\nAnswer can be wrong", "Malform expression");
                }
            }

            String[] temp = values.Split(',');
            for (int i = 0; i < temp.Length-1; i++)
            {                
                No1 = temp[i];
                ans += Double.Parse(No1);
            }
            return ans;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                answer.Text = "" + calculate(expText.Text,0);
                expText.Text = "";
            }
            catch (Exception)
            {
                answer.Text = "Malform Expresion !";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {        
        }       

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
        }

        private void lnkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlAbout.Visible = true;
        }       
                
    }
}
