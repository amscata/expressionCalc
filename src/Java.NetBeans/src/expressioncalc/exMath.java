/*
 * @(#)exMath.java      Feb 19 2011
 * Project JavaSeaScape
 * Author Amith Chinthaka. All rights reserved.
 *
 * Distribute under terms of GNU general Public License Version 2
 * for FOSS community.
 * Use is subject to license terms.
 */
package expressioncalc;

/**
 * <H1>exMath</H1><br>
 * <I>additional math functions</I>
 * <P>In this class includes additional math functions. Exception handling wasn't
 * done. Therefore methods will throw exceptions for invalid parameters. This is
 * a part of expressionCalc.
 * </P>
 *
 * @author Amith Chinthaka
 */
public class exMath {

    /**
     * Returns fibonacci value of a number.
     *
     * @param no Number which you want to find Fibonacci.
     * @return Fibonacci value of given number
     */
    public static long fib(int no) {
        if (no == 0 | no == 1) {
            return 1;
        } else {
            return (fib(no - 1) + fib(no - 2));
        }
    }

    /**
     * Returns factorial value of a number.
     *
     * @param no Number which you want to find factorial.
     * @return Factorial of the no.
     */
    public static long fact(int no) {
        if (no == 0) {
            return 1;
        } else {
            return no * fact(no - 1);
        }
    }

    /**
     * Returns number of permutations of n distinct objects taken r at a time.
     *
     * @param n.
     * @param r.
     * @return nPr Permutation of r numbers from n numbers.
     */
    public static long nPr(int n, int r) {
        return (fact(n) / fact(n - r));
    }

    /**
     * Returns number of combinations of n distinct object taken r at a time.
     *
     * @param n.
     * @param r.
     * @return nCr Combination of r numbers from n numbers.
     */
    public static double nCr(int n, int r) {
        return (fact(n) / (fact(n - r) * fact(r)));
    }

    /**
     * Returns the number which placed on bit th row, element th column
     * in Pascal Triangle.
     *
     * @param bit The maximum power of mathematical expression
     * @param element The term which you want to find the multiple
     * @return
     */
    public static long pas(int bit, int element) {
        long pascal[][] = new long[bit][bit + 1];
        //First line
        pascal[0][0] = pascal[0][1] = 1;
        for (int n = 1; n <= bit; n++) {
            //Calculate next line
            if (bit > 1 & n < bit) {
                pascal[n][0] = 1;
                for (int i = 1; i <= n; i++) {
                    pascal[n][i] = pascal[n - 1][i - 1] + pascal[n - 1][i];
                }
                pascal[n][n + 1] = 1;
            }
        }
        return (pascal[bit - 1][element - 1]);
    }

    /**
     * Returns a logarithm of a number in given base.
     *
     * @param base.
     * @param no.
     * @return logarithm of no according to any given base.
     */
    public static double log(double base, double no) {
        return (Math.log(no) / Math.log(base));
    }

    /**
     * Returns a reciprocal logarithm.
     *
     * @param a base.
     * @param b number.
     * @return <P>reciprocal logarithm.<br>When gave log(base,no) returns log(no,base).</P>
     */
    public static double logr(double a, double b) {
        return (log(b, a));
    }

    /**
     * Returns radian value of an angle.
     *
     * @param ang angle.
     * @return radian value of given angle.
     */
    public static double rad(double ang) {
        return (Math.PI / 180 * ang);
    }

    /**
     * Returns angle of a radian.
     *
     * @param rad.
     * @return angle of given radian.
     */
    public static double ang(double rad) {
        return (180 / Math.PI * rad);
    }

    /**
     * Return radian value of an angle given in long terms.
     *
     * @param degree.
     * @param digit.
     * @param second.
     * @return radian value of given angle in long terms (with digit and second).
     */
    public static double longrad(double degree, double digit, double second) {
        return (rad(degree + digit / 60 + second / (60 * 60)));
    }

    /**
     * Returns trigonometric sec of an angle.
     *
     * @param rad an angle in radian.
     * @return Sec value of given radian.
     */
    public static double sec(double rad) {
        return (1 / Math.cos(rad));
    }

    /**
     * Returns trigonometric cosec of an angle.
     *
     * @param rad angle in radian.
     * @return Cosec value of given radian.
     */
    public static double cosec(double rad) {
        return (1 / Math.sin(rad));
    }

    /**
     * Returns trigonometric cot of an angle.
     *
     * @param rad angle in radian.
     * @return Cot value of given radian.
     */
    public static double cot(double rad) {
        return (1 / Math.tan(rad));
    }

    /**
     * Returns the arc sec of a value.
     *
     * @param sec value which you want to find radian.
     * @return angle in radian.
     */
    public static double asec(double sec) {
        return (Math.acos(1 / sec));
    }

    /**
     * Returns the arc cosec of a value.
     *
     * @param cosec value which you want to find radian.
     * @return angle in radian.
     */
    public static double acosec(double cosec) {
        return (Math.asin(1 / cosec));
    }

    /**
     * Returns the arc cot of a value.
     *
     * @param cot value which you want to find radian.
     * @return angle in radian.
     */
    public static double acot(double cot) {
        return (Math.atan(1 / cot));
    }
}
