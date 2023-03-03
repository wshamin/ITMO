package JavaBasics.Task01;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        System.out.println("Я");
        System.out.println("хорошо");
        System.out.println("знаю");
        System.out.println("Java");

        double d1 = (46 + 10) * (10 / 3.0);
        System.out.println(d1);

        int d2 = 29 * 4 * -15;
        System.out.println(d2);

        int number = 10500;
        double result = (number / 10.0) / 10;
        System.out.println(result);

        Scanner scan = new Scanner(System.in);
        int a = scan.nextInt();
        int b = scan.nextInt();
        int c = scan.nextInt();
        System.out.println(a);
        System.out.println(b);
        System.out.println(c);

        if (b % 2 != 0) {
            System.out.println("Нечетное");
        } else if (b > 100) {
            System.out.println("Выход за пределы диапазона");
        } else {
            System.out.println("Четное");
        }
    }
}
