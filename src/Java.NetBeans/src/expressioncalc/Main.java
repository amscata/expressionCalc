/*
 * Main class of expressionCalc
 */
package expressioncalc;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import javax.swing.UIManager;

/*import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.io.InputStreamReader;*/

/*
 * Author : Amith Chinthaka <amscata@gmail.com>
 */
public class Main {

    private static BufferedReader stdin;

    private static void getExp() {
        try {
            System.out.println("      expressionCalc(TM)");
            System.out.print("Enter Mathematical Expression : ");
            stdin = new BufferedReader(new InputStreamReader(System.in));
            String expression = stdin.readLine();
            if (expression.equalsIgnoreCase("EXIT")) {
                stdin.close();
                System.exit(0);
            } else {
                //long st = System.nanoTime();
                System.out.println("\nAnswer is : " + expressionCalc.calculate(expression, 0) + "\n\n");
                //long et = System.nanoTime();
                //System.out.println("Time spent : " + (et - st));
            }
        } catch (IOException ex) {
            System.out.println(ex);
        } catch (Exception e) {
            System.out.println("\n(X) Malform Expression\n" + e);
        } finally {
            try {
                getExp();
                stdin.close();
            } catch (IOException ex) {
                System.out.println("(X) ERROR !");
            }
        }
    }

    private static void runGUI() {
        try {
            UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
        } catch (Exception e) {
        }
        new Window().setVisible(true);
    }

    /*private static void test() {
    try {
    BufferedReader file = new BufferedReader(new FileReader("test.txt"));
    String tempLine = new String();
    int n = 1;
    while ((tempLine = file.readLine()) != null) {
    System.out.print("Expression " + n + " = ");
    System.out.println(expressionCalc.calculate(tempLine, 0));
    n++;
    }
    file.close();
    } catch (FileNotFoundException e) {
    System.out.println("(X) ERROR: " + e);
    } catch (IOException e) {
    System.out.println("(X) ERROR: " + e);
    }
    }*/
    public static void main(String[] args) {
        getExp();
        //test();
        //runGUI();
    }
}
