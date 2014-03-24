/*
 * @(#)expressionCalc.java
 *
 * expressionCalc application_Developments:Started date: Feb 11th 2011
 * expressionCalc Completed : Feb 25th 2011
 * Released on Feb 28th 2011 v1.1.1
 *
 * Under JavaSeScape project
 *
 * @author Amith Chinthaka
 * @version 1.1.1
 * Project Started Date: 2011/1/7
 * All rights reserved by Amith Chinthaka <amscata@gmail.com>
 * 
 * This source code distribute under GNU General Public License Version 2 for FOSS users
 * Please develop and re-distribute this code and contribute FOSS community.
 *
 * Bio CODE : #10001026_AMSCATA_EXPCALC_{��?����?�����??����?��}
 * Complete Source Code Released on Feb 1st 2012
 */
package expressioncalc;

import java.util.Vector;

public class expressionCalc {

    /**
     * <H1><U>Core of the Program</U></H1>
     * <P>Get string expression and divide it into characters.
     * Then check with some key characters specific to this calculator like + - * / ()
     * Main swith case check that key characters
     * Bracketed expressions send to recursion
     * Calculator based on BODMAS theorem and GIGO concept
     * </P>
     * @exception NumberFormatException - Not handled
     * @param expression
     * @return answer
     */
    public static double calculate(String expression, int Opt) {

        //Store function
        byte opt = 0;

        //To inform whether the recursion has been done, because of the function
        //or the bracket operator
        boolean func = false;

        //Count number of breckets
        byte brackets = 0;

        //Calculate firstly partial answers and finally calculate total answer
        double ans = 0;

        //Set status to No1 and No2. Set false if No1 and No2 can be used to store values
        boolean no1 = false, no2 = false;

        //Store key character, the operation
        char op = '\0';

        //Store two numbers which going to do mathematical opration
        //exp for store bracketed expressions. this exp used as a input to do recursion
        String No1 = "", No2 = "", exp = "";

        //In this vector used to store calculated parcial answers separatly.
        //After doing all calculations Addition has been done
        Vector values = new Vector();

        //This for loop used to divide expression into characters and check for key characters
        for (int i = 0; i < expression.length(); i++) {
            //Check whether recursion is in progress(>0) or not(0)
            if (brackets == 0) {
                //Switch according to key characters
                switch (expression.charAt(i)) {
                    case '(':
                        brackets++;
                        break;
                    case ')':
                        System.out.println("\n(X) Malform expression, Found closing bracket without opening bracket\n    Answer can be wrong");
                        break;

                    /* operator codes
                     * 11-lg	12-ln	13-log
                     * 21-sin	22-sec	23-sqrt
                     * 31-cos	32-cot	33-cosec    34-cbrt
                     * 41-tan
                     * 51-asin	52-acos	53-atan	54-acosec
                     * 55-asec	56-acot 57-ang  58-abs
                     * 61-rad
                     * 71-fib
                     */

                    case 'l':
                        if (i <= expression.length() - 3) {
                            if (expression.charAt(i + 1) == 'g' & expression.charAt(i + 2) == '(') {
                                opt = 11;
                                func = true;
                                brackets++;
                                i += 2;
                            } else if (expression.charAt(i + 1) == 'n' & expression.charAt(i + 2) == '(') {
                                opt = 12;
                                func = true;
                                brackets++;
                                i += 2;
                            } else if (i <= expression.length() - 4) {
                                if (expression.charAt(i + 1) == 'o' & expression.charAt(i + 2) == 'g' & expression.charAt(i + 3) == '(') {
                                    opt = 13;
                                    func = true;
                                    brackets++;
                                    i += 3;
                                }
                            }
                        }
                        break;
                    case 's':
                        if (i <= expression.length() - 4) {
                            if (expression.charAt(i + 1) == 'i' & expression.charAt(i + 2) == 'n' & expression.charAt(i + 3) == '(') {
                                opt = 21;
                                func = true;
                                brackets++;
                                i += 3;
                            } else if (expression.charAt(i + 1) == 'e' & expression.charAt(i + 2) == 'c' & expression.charAt(i + 3) == '(') {
                                opt = 22;
                                func = true;
                                brackets++;
                                i += 3;
                            } else if (i <= expression.length() - 5) {
                                if (expression.charAt(i + 1) == 'q' & expression.charAt(i + 2) == 'r' & expression.charAt(i + 3) == 't' & expression.charAt(i + 4) == '(') {
                                    opt = 23;
                                    func = true;
                                    brackets++;
                                    i += 4;
                                }
                            }
                        }
                        break;
                    case 'c':
                        if (i <= expression.length() - 4) {
                            if (expression.charAt(i + 1) == 'o' & expression.charAt(i + 2) == 's' & expression.charAt(i + 3) == '(') {
                                opt = 31;
                                func = true;
                                brackets++;
                                i += 3;
                            } else if (expression.charAt(i + 1) == 'o' & expression.charAt(i + 2) == 't' & expression.charAt(i + 3) == '(') {
                                opt = 32;
                                func = true;
                                brackets++;
                                i += 3;
                            } else if (i <= expression.length() - 5 & expression.charAt(i + 1) == 'b') {
                                if (expression.charAt(i + 2) == 'r' & expression.charAt(i + 3) == 't' & expression.charAt(i + 4) == '(') {
                                    opt = 34;
                                    func = true;
                                    brackets++;
                                    i += 4;
                                }
                            } else if (i <= expression.length() - 6) {
                                if (expression.charAt(i + 1) == 'o' & expression.charAt(i + 2) == 's' & expression.charAt(i + 3) == 'e' & expression.charAt(i + 4) == 'c' & expression.charAt(i + 5) == '(') {
                                    opt = 33;
                                    func = true;
                                    brackets++;
                                    i += 5;
                                }
                            } else {
                                System.out.println("\n(X) Malform expression, Incomplete input for nCr\n    Answer can be wrong");
                                System.out.println("(i) For nCr give capital C, for cos, cot, and cosec give simple c");
                            }
                        } else {
                            System.out.println("\n(X) Malform expression, Incomplete input for nCr\n    Answer can be wrong");
                            System.out.println("(i) For nCr give capital C, for cos, cot, and cosec give simple c");
                        }
                        break;
                    case 't':
                        if (i <= expression.length() - 4) {
                            if (expression.charAt(i + 1) == 'a' & expression.charAt(i + 2) == 'n' & expression.charAt(i + 3) == '(') {
                                opt = 41;
                                func = true;
                                brackets++;
                                i += 3;
                            }
                        }
                        break;
                    case 'a':
                        if (i <= expression.length() - 4 & expression.charAt(i + 1) == 'n') {
                            if (expression.charAt(i + 2) == 'g' & expression.charAt(i + 3) == '(') {
                                opt = 57;
                                func = true;
                                brackets++;
                                i += 3;
                            }
                        } else if (i <= expression.length() - 4 & expression.charAt(i + 1) == 'b') {
                            if (expression.charAt(i + 2) == 's' & expression.charAt(i + 3) == '(') {
                                opt = 58;
                                func = true;
                                brackets++;
                                i += 3;
                            }
                        } else if (i <= expression.length() - 5) {
                            if (expression.charAt(i + 1) == 's' & expression.charAt(i + 2) == 'i' & expression.charAt(i + 3) == 'n' & expression.charAt(i + 4) == '(') {
                                opt = 51;
                                func = true;
                                brackets++;
                                i += 4;
                            } else if (expression.charAt(i + 1) == 'c' & expression.charAt(i + 2) == 'o' & expression.charAt(i + 3) == 's' & expression.charAt(i + 4) == '(') {
                                opt = 52;
                                func = true;
                                brackets++;
                                i += 4;
                            } else if (expression.charAt(i + 1) == 't' & expression.charAt(i + 2) == 'a' & expression.charAt(i + 3) == 'n' & expression.charAt(i + 4) == '(') {
                                opt = 53;
                                func = true;
                                brackets++;
                                i += 4;
                            } else if (expression.charAt(i + 1) == 's' & expression.charAt(i + 2) == 'e' & expression.charAt(i + 3) == 'c' & expression.charAt(i + 4) == '(') {
                                opt = 55;
                                func = true;
                                brackets++;
                                i += 4;
                            } else if (expression.charAt(i + 1) == 'c' & expression.charAt(i + 2) == 'o' & expression.charAt(i + 3) == 't' & expression.charAt(i + 4) == '(') {
                                opt = 56;
                                func = true;
                                brackets++;
                                i += 4;
                            } else if (i <= expression.length() - 7) {
                                if (expression.charAt(i + 1) == 'c' & expression.charAt(i + 2) == 'o' & expression.charAt(i + 3) == 's' & expression.charAt(i + 4) == 'e' & expression.charAt(i + 5) == 'c' & expression.charAt(i + 6) == '(') {
                                    opt = 54;
                                    func = true;
                                    brackets++;
                                    i += 7;
                                }
                            }
                        }
                        break;
                    case 'r':
                        if (i <= expression.length() - 4) {
                            if (expression.charAt(i + 1) == 'a' & expression.charAt(i + 2) == 'd' & expression.charAt(i + 3) == '(') {
                                opt = 61;
                                func = true;
                                brackets++;
                                i += 3;
                            }
                        }
                    case 'f':
                        if (i <= expression.length() - 4) {
                            if (expression.charAt(i + 1) == 'i' & expression.charAt(i + 2) == 'b' & expression.charAt(i + 3) == '(') {
                                opt = 71;
                                func = true;
                                brackets++;
                                i += 3;
                            }
                        }
                        break;

                    case '/':
                    case '*':
                    case '%':
                    case '^':
                    case 'P':
                    case 'C':
                    case ',':
                        if (No1.length() > 0 & No2.length() > 0) {
                            switch (op) {
                                case '*':
                                    ans = Double.parseDouble(No1) * Double.parseDouble(No2);
                                    break;
                                case '/':
                                    ans = Double.parseDouble(No1) / Double.parseDouble(No2);
                                    break;
                                case '%':
                                    ans = Double.parseDouble(No1) % Double.parseDouble(No2);
                                    break;
                                case '^':
                                    ans = Math.pow(Double.parseDouble(No1), Double.parseDouble(No2));
                                    break;
                                case 'P':
                                    if (Double.parseDouble(No1) >= 0 & Double.parseDouble(No2) >= 0) {
                                        ans = (double) exMath.nPr((int) Double.parseDouble(No1), (int) Double.parseDouble(No2));
                                    } else {
                                        System.out.println("\n(X) Malform function\n    There is a negative values for nPr function\n    Answer can be wrong");
                                    }
                                    break;
                                case 'C':
                                    if (Double.parseDouble(No1) >= 0 & Double.parseDouble(No2) >= 0) {
                                        ans = (double) exMath.nCr((int) Double.parseDouble(No1), (int) Double.parseDouble(No2));
                                    } else {
                                        System.out.println("\n(X) Malform function\n    There is a negative values for nCr function\n    Answer can be wrong");
                                    }
                                    break;
                                case ',':
                                    if (Opt == 13 & Double.parseDouble(No1) >= 0 & Double.parseDouble(No2) >= 0) {
                                        ans = exMath.log(Double.parseDouble(No1), Double.parseDouble(No2));
                                    } else {
                                        System.out.println("\n(X) Malform expression, Found invalid charactor ',' or Negative number or zero for log()\n    Answer can be wrong");
                                    }
                                    break;
                            }
                            No1 = String.valueOf(ans);
                            no1 = true;
                            No2 = "";
                            no2 = false;
                            ans = 0;
                        } else if (No1.length() > 0) {
                            no1 = true;
                        }
                        op = expression.charAt(i);
                        break;
                    case '+':
                    case '-':
                        if (no1 == false & No1.length() == 0) {
                            No1 = "" + expression.charAt(i);
                        } else if (no1 == false & No1.length() > 0) {
                            if (No1.length() <= 1 & (No1.charAt(0) == '+' | No1.charAt(0) == '-')) {
                                if (expression.charAt(i) == '+' & No1.equals("+")) {
                                    No1 = "+";
                                } else if ((expression.charAt(i) == '+' & No1.equals("-")) | (expression.charAt(i) == '-' & No1.equals("+"))) {
                                    No1 = "-";
                                } else if (expression.charAt(i) == '-' & No1.equals("-")) {
                                    No1 = "+";
                                }
                            } else {
                                values.add(No1);
                                No1 = String.valueOf(expression.charAt(i));
                            }
                        }

                        if (no1 == true & No2.length() == 0) {
                            No2 += expression.charAt(i);
                        } else if (no1 == true & No2.length() > 0) {
                            switch (op) {
                                case '*':
                                    ans = Double.parseDouble(No1) * Double.parseDouble(No2);
                                    break;
                                case '/':
                                    ans = Double.parseDouble(No1) / Double.parseDouble(No2);
                                    break;
                                case '%':
                                    ans = Double.parseDouble(No1) % Double.parseDouble(No2);
                                    break;
                                case '^':
                                    ans = Math.pow(Double.parseDouble(No1), Double.parseDouble(No2));
                                    break;
                                case 'P':
                                    if (Double.parseDouble(No1) >= 0 & Double.parseDouble(No2) >= 0) {
                                        ans = (double) exMath.nPr((int) Double.parseDouble(No1), (int) Double.parseDouble(No2));
                                    } else {
                                        System.out.println("\n(X) Malform function\n    There is a negative values for nPr function\n    Answer can be wrong");
                                    }
                                    break;
                                case 'C':
                                    if (Double.parseDouble(No1) >= 0 & Double.parseDouble(No2) >= 0) {
                                        ans = (double) exMath.nCr((int) Double.parseDouble(No1), (int) Double.parseDouble(No2));
                                    } else {
                                        System.out.println("\n(X) Malform function\n    There is a negative values for nCr function\n    Answer can be wrong");
                                    }
                                    break;
                                case ',':
                                    if (Opt == 13 & Double.parseDouble(No1) >= 0 & Double.parseDouble(No2) >= 0) {
                                        ans = exMath.log(Double.parseDouble(No1), Double.parseDouble(No2));
                                    } else {
                                        System.out.println("\n(X) Malform expression, Found invalid charactor ',' or Negative number for log()\n    Answer can be wrong");
                                    }
                                    break;
                            }
                            values.add(ans);
                            ans = 0;
                            No1 = "";
                            No1 += expression.charAt(i);
                            no1 = false;
                            No2 = "";
                            no2 = false;
                        }
                        break;

                    case '.':
                        if (no1 == false & No1.length() > 0) {
                            No1 += ".";
                        } else if (no1 == false & No1.length() == 0) {
                            No1 += "0.";
                        } else if (no2 == false & No2.length() > 0) {
                            No2 += ".";
                        } else if (no2 == false & No2.length() == 0) {
                            No2 += "0.";
                        }
                        break;
                    case 'e':
                    case 'p':
                        double no = 0.0;
                        if (expression.charAt(i) == 'p' & i != expression.length() - 1) {
                            if (expression.charAt(i + 1) == 'i') {
                                no = Math.PI;
                                i++;
                            } else {
                                System.out.println("\n(X) Malform expression, Incomplete input for pi\n    Answer can be wrong");
                                System.out.println("(i) For nPr give capital P, for pi give simple pi");
                            }
                        } else if (expression.charAt(i) == 'e') {
                            no = Math.E;
                        } else {
                            System.out.println("\n(X) Malform expression, Incomplete input for pi\n    Answer can be wrong");
                            System.out.println("(i) For nPr give capital P, for pi give simple pi");
                        }

                        if (no1 == false) {
                            if (No1.length() == 0) {
                                No1 += no;
                            } else if (No1.length() == 1 & (No1.charAt(0) == '+' | No1.charAt(0) == '-')) {
                                No1 += no;
                            } else {
                                No1 = "" + Double.parseDouble(No1) * no;
                            }
                        } else if (no2 == false) {
                            if (No2.length() == 0) {
                                No2 += no;
                            } else if (No2.length() == 1 & (No2.charAt(0) == '+' | No2.charAt(0) == '-')) {
                                No2 += no;
                            } else {
                                No2 = "" + Double.parseDouble(No2) * no;
                            }
                        } else if (no2 == true) {
                            if (op == '*') {
                                ans = Double.parseDouble(No1) * Double.parseDouble(No2);
                            }
                            No1 = String.valueOf(ans);
                            no1 = true;
                            No2 = String.valueOf(no);
                            no2 = false;
                        }
                        break;
                    case '!':
                        if (no1 == false & No1.length() >= 1) {
                            if (No1.length() == 1 & (No1.charAt(0) == '+' | No1.charAt(0) == '-')) {
                                No1 += 1;
                            } else if (Double.parseDouble(No1) >= 0) {
                                No1 = String.valueOf(exMath.fact((int) (Double.parseDouble(No1))));
                            } else {
                                No1 = "-" + exMath.fact((int) Math.abs(Double.parseDouble(No1)));
                            }
                        } else if (no2 == false & No2.length() >= 1) {
                            if (No2.length() == 1 & (No2.charAt(0) == '+' | No2.charAt(0) == '-')) {
                                No2 += 1;
                            } else if (Double.parseDouble(No2) >= 0) {
                                No2 = String.valueOf(exMath.fact((int) (Double.parseDouble(No2))));
                            } else {
                                No2 = "-" + exMath.fact((int) Math.abs(Double.parseDouble(No2)));
                            }
                        } else if (no2 == true) {
                            if (Double.parseDouble(No2) >= 0) {
                                No2 = String.valueOf(exMath.fact((int) (Double.parseDouble(No2))));
                            } else {
                                No2 = "-" + exMath.fact((int) Math.abs(Double.parseDouble(No2)));
                            }
                            no2 = false;
                        }
                        break;
                    default:
                        if (expression.charAt(i) + 0 >= 48 & expression.charAt(i) + 0 <= 57) {
                            if (no1 == false) {
                                No1 += expression.charAt(i);
                            } else if (no2 == false) {
                                No2 += expression.charAt(i);
                            } else if (no2 == true) {
                                if (op == '*') {
                                    ans = Double.parseDouble(No1) * Double.parseDouble(No2);
                                }
                                No1 = String.valueOf(ans);
                                no1 = true;
                                No2 = String.valueOf(expression.charAt(i));
                                no2 = false;
                            }
                        } else {
                            System.out.println("\n(X) Malform expression, Found invalid charactor '" + expression.charAt(i) + "'\n    Answer can be wrong");
                        }
                }

                /*
                 * Prepare process for recursion
                 */
                if (brackets == 1 | func == true) {
                    if (no1 == false & No1.length() == 0) {
                        no1 = true;
                        No1 = "1";
                        op = '*';
                    } else if (no1 == false & No1.length() > 0) {
                        if (No1.length() == 1) {
                            switch (No1.charAt(0)) {
                                case '+':
                                case '-':
                                    No1 += "1";
                                    break;
                            }
                        }
                        no1 = true;
                        op = '*';
                    } else if (No1.length() > 0 & No2.length() > 0) {
                        switch (op) {
                            case '*':
                                ans = Double.parseDouble(No1) * Double.parseDouble(No2);
                                break;
                            case '/':
                                ans = Double.parseDouble(No1) / Double.parseDouble(No2);
                                break;
                            case '%':
                                ans = Double.parseDouble(No1) % Double.parseDouble(No2);
                                break;
                            case '^':
                                ans = Math.pow(Double.parseDouble(No1), Double.parseDouble(No2));
                                break;
                            case 'P':
                                if (Double.parseDouble(No1) >= 0 & Double.parseDouble(No2) >= 0) {
                                    ans = (double) exMath.nPr((int) Double.parseDouble(No1), (int) Double.parseDouble(No2));
                                } else {
                                    System.out.println("\n(X) Malform function\n    There is a negative values for nPr function\n    Answer can be wrong");
                                }
                                break;
                            case 'C':
                                if (Double.parseDouble(No1) >= 0 & Double.parseDouble(No2) >= 0) {
                                    ans = (double) exMath.nCr((int) Double.parseDouble(No1), (int) Double.parseDouble(No2));
                                } else {
                                    System.out.println("\n(X) Malform function\n    There is a negative values for nCr function\n    Answer can be wrong");
                                }
                                break;
                            case ',':
                                if (Opt == 13 & Double.parseDouble(No1) >= 0 & Double.parseDouble(No2) >= 0) {
                                    ans = exMath.log(Double.parseDouble(No1), Double.parseDouble(No2));
                                } else {
                                    System.out.println("\n(X) Malform expression, Found invalid charactor ',' or Negative number for log()\n    Answer can be wrong");
                                }
                                break;
                        }
                        No1 = String.valueOf(ans);
                        op = '*';
                    }
                    exp = "";
                    No2 = "";
                    no2 = false;
                    ans = 0;
                }
                
            } else {
                //Count number of breckets
                switch (expression.charAt(i)) {
                    case '(':
                        brackets++;
                        break;
                    case ')':
                        brackets--;
                        break;
                }

                //If number of brackets equal to zero the recursion is end
                if (brackets == 0) {
                    if (func == true) {
                        switch (opt) {
                            case 11:
                                ans = Math.log10(calculate(exp, 0));
                                break;
                            case 12:
                                ans = Math.log(calculate(exp, 0));
                                break;
                            case 13:
                                String tempLog[] = exp.split(",");
                                if (tempLog.length > 1) {
                                    ans = calculate(exp, 13);
                                } else {
                                    System.out.println("\n(X) Malform expression, Incomplete input for log() base or no is missing\n(i) For log() give log(base,no)\n    Answer can be wrong");
                                    ans = 0;
                                }
                                break;
                            case 21:
                                ans = Math.sin(calculate(exp, 0));
                                break;
                            case 22:
                                ans = exMath.sec(calculate(exp, 0));
                                break;
                            case 23:
                                ans = Math.sqrt(calculate(exp, 0));
                                break;
                            case 31:
                                ans = Math.cos(calculate(exp, 0));
                                break;
                            case 32:
                                ans = exMath.cot(calculate(exp, 0));
                                break;
                            case 33:
                                ans = exMath.cosec(calculate(exp, 0));
                                break;
                            case 34:
                                ans = Math.cbrt(calculate(exp, 0));
                                break;
                            case 41:
                                ans = Math.tan(calculate(exp, 0));
                                break;
                            case 51:
                                ans = Math.asin(calculate(exp, 0));
                                break;
                            case 52:
                                ans = Math.acos(calculate(exp, 0));
                                break;
                            case 53:
                                ans = Math.atan(calculate(exp, 0));
                                break;
                            case 54:
                                ans = exMath.acosec(calculate(exp, 0));
                                break;
                            case 55:
                                ans = exMath.asec(calculate(exp, 0));
                                break;
                            case 56:
                                ans = exMath.acot(calculate(exp, 0));
                                break;
                            case 57:
                                ans = exMath.ang(calculate(exp, 0));
                                break;
                            case 58:
                                ans = Math.abs(calculate(exp, 0));
                                break;
                            case 61:
                                ans = exMath.rad(calculate(exp, 0));
                                break;
                            case 71:
                                ans = exMath.fib((int) calculate(exp, 0));
                                break;
                        }
                        opt = 0;
                        func = false;
                    } else {
                        ans = calculate(exp, 0);
                    }
                    No2 = String.valueOf(ans);
                    no2 = true;
                    ans = 0;
                } else {
                    exp += expression.charAt(i);
                }
            }
            //When reached to end of the main expression last mathematical operation has been done here
            if (i == expression.length() - 1) {
                if (no1 == false & No1.length() > 0) {
                    values.add(No1);
                } else if (no1 == true & No2.length() == 0) {
                    values.add(No1);
                } else if (no1 = true & No2.length() > 0) {
                    switch (op) {
                        case '/':
                            ans = Double.parseDouble(No1) / Double.parseDouble(No2);
                            break;
                        case '*':
                            ans = Double.parseDouble(No1) * Double.parseDouble(No2);
                            break;
                        case '%':
                            ans = Double.parseDouble(No1) % Double.parseDouble(No2);
                            break;
                        case '^':
                            ans = Math.pow(Double.parseDouble(No1), Double.parseDouble(No2));
                            break;
                        case 'P':
                            if (Double.parseDouble(No1) >= 0 & Double.parseDouble(No2) >= 0) {
                                ans = (double) exMath.nPr((int) Double.parseDouble(No1), (int) Double.parseDouble(No2));
                            } else {
                                System.out.println("\n(X) Malform function\n    There is a negative values for nPr function\n    Answer can be wrong");
                            }
                            break;
                        case 'C':
                            if (Double.parseDouble(No1) >= 0 & Double.parseDouble(No2) >= 0) {
                                ans = (double) exMath.nCr((int) Double.parseDouble(No1), (int) Double.parseDouble(No2));
                            } else {
                                System.out.println("\n(X) Malform function\n    There is a negative values for nCr function\n    Answer can be wrong");
                            }
                            break;
                        case ',':
                            if (Opt == 13 & Double.parseDouble(No1) >= 0 & Double.parseDouble(No2) >= 0) {
                                ans = exMath.log(Double.parseDouble(No1), Double.parseDouble(No2));
                            } else {
                                System.out.println("\n(X) Malform expression, Found invalid charactor ',' or Negative number for log()\n    Answer can be wrong");
                            }
                            break;
                        case '+':
                            ans = Double.parseDouble(No1) + Double.parseDouble(No2);
                            break;
                        case '-':
                            ans = Double.parseDouble(No1) - Double.parseDouble(No2);
                            break;
                    }
                }
            }
        }

        if (brackets > 0) {
            if (brackets > 1) {
                System.out.println("\n(X) Malform expression, There are " + brackets + " brackets without closing\n    Answer can be wrong");
            } else {
                System.out.println("\n(X) Malform expression, There is " + brackets + " bracket without closing\n    Answer can be wrong");
            }
        }
        //Final addition has been done here
        //Final addition means BODM(A and S)(Addition & Subtraction)
        for (int i = 0; i < values.size(); i++) {
            No1 = String.valueOf(values.get(i));
            ans += Double.parseDouble(No1);
        }
        return ans;
    }
}
