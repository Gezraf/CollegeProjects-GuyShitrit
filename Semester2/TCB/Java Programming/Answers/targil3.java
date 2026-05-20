//ID: 330707761, Author: Guy Shitrit
import java.util.Scanner;

public class Main {

    public static boolean isdigit(char c) {
        return '0' <= c && c <= '9';
    }

    public static boolean isletter(char c) {
        return 'A' <= c && c <= 'z';
    }

    public static int tonumeric(char c) {
        return c - '0';
    }
    public static void Q1(String str) {
        int digitCount = 0, letterCount = 0, otherCount = 0;

        for(int i = 0; i < str.length(); i++) {
            if (isdigit(str.charAt(i))) {
                digitCount++;
            } else if (isletter(str.charAt(i))) {
                letterCount++;
            } else {
                otherCount++;
            }
        }

        System.out.println("Digit Count: " + digitCount);
        System.out.println("Digit Count: " + letterCount);
        System.out.println("Digit Count: " + otherCount);
    }


    public static String Q2(String str) {
        String res = "";
        for(int i = 0; i < str.length(); i++) {
            if(isdigit(str.charAt(i))) {
                for(int j = 0; j < tonumeric(str.charAt(i)); j++) {
                    res += "*";
                }
            } else {
                res += str.charAt(i);
            }
        }

        return res;
    }


    public static void Q3(char c, String str) {
        for(int i = 0; i < str.length(); i++) {
            if(str.charAt(i) == c) {
                System.out.println(str.substring(i));
            }
        }
    }


    public static int Q4(String str) {
        String res = "";

        for(int i = 0; i < str.length(); i++) {
            if(isdigit(str.charAt(i))) {
                res += str.charAt(i);
                res += str.charAt(i + 1);
                return Integer.parseInt(res);
            }
        }

        return -1;
    }

    public static String Q5(String str) {
        String res = "", temp = "";
        int start = 0;

        for (int i = 0; i < str.length(); i++) {

            if (str.charAt(i) == '*') {
                temp = str.substring(start, i);

                if (temp.length() % 2 == 1) {
                    res += temp.charAt(temp.length() / 2);
                }

                start = i + 1;
            }
        }

        temp = str.substring(start);
        if (temp.length() % 2 == 1) {
            res += temp.charAt(temp.length() / 2);
        }

        return res;
    }

    public static void main(String[] args) {
        Q1("C+2A<3N321C2aaa");
        System.out.println(Q2("a2b3"));
        Q3('a', "Java is a good language!");
        System.out.println(Q4("acbdsbFDDg12ddsad"));
        System.out.println(Q5("abc*nssj*x*abc*aaaaa"));
    }
}
