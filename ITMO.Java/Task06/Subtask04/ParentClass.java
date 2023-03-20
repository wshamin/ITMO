package Task06.Subtask04;

import java.util.Scanner;

public class ParentClass {
    static int number;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        number = scanner.nextInt();
        scanner.close();
        ExtendedClass extendedClass = new ExtendedClass();
        extendedClass.displayNumber();
    }
}
