package Task04;

import java.util.ArrayList;
import java.util.Arrays;

public class Part1 {
    public static void main(String[] args) {
        oddNumbersFromOneToNN();

        divByThreeAndFive(100);

        System.out.println("Результат: " + sumCompare(5, 10, 15));
        System.out.println();

        System.out.println("Результат: " + secondSumCompare(5, 10, 15));
        System.out.println();

        int[] intArray = {3, -3, 7, 4, 5, 4, 3};
        System.out.println(firstAndLastNumCheck(intArray));
        System.out.println();

        System.out.println(containsOneAndThree(intArray));
    }

    private static void oddNumbersFromOneToNN() {
        for (int i = 1; i < 100; i += 2) {
            System.out.print(i + " ");
        }
        System.out.println();
        System.out.println();
    }

    private static void divByThreeAndFive(int value) {
        int[] dividedBy3 = new int[value];
        int[] dividedBy5 = new int[value];
        int[] dividedBy3And5 = new int[value];

        for (int i = 1; i <= value; i++) {
            if (i % 3 == 0 && i % 5 != 0) {
                dividedBy3[i-1] = i;
                continue;
            }

            if (i % 3 != 0 && i % 5 == 0) {
                dividedBy5[i-1] = i;
                continue;
            }

            if (i % 3 == 0) {
                dividedBy3And5[i-1] = i;
            }
        }

        System.out.print("Делится на 3: ");
        for (Integer i : dividedBy3) {
            if (i != 0) {
                System.out.print(i + ", ");
            }
        }
        System.out.println();

        System.out.print("Делится на 5: ");
        for (Integer i : dividedBy5) {
            if (i != 0) {
                System.out.print(i + ", ");
            }
        }
        System.out.println();

        System.out.print("Делится на 3 и 5: ");
        for (Integer i : dividedBy3And5) {
            if (i != 0) {
                System.out.print(i + ", ");
            }
        }
        System.out.println();
        System.out.println();
    }

    private static boolean sumCompare(int firstNumber, int secondNumber, int thirdNumber) {
        System.out.println("Введите первое число: " + firstNumber);
        System.out.println("Введите второе число: " + secondNumber);
        System.out.println("Введите третье число: " + thirdNumber);
        return firstNumber + secondNumber == thirdNumber;
    }

    private static boolean secondSumCompare(int firstNumber, int secondNumber, int thirdNumber) {
        System.out.println("Введите первое число: " + firstNumber);
        System.out.println("Введите второе число: " + secondNumber);
        System.out.println("Введите третье число: " + thirdNumber);
        return secondNumber > firstNumber && thirdNumber > secondNumber;
    }

    private static boolean firstAndLastNumCheck(int[] intArray) {
        System.out.println(Arrays.toString(intArray));
        return intArray[0] == 3 && intArray[intArray.length - 1] == 3;
    }

    private static boolean containsOneAndThree(int[] intArray) {
        for (int j : intArray) {
            if (j == 1 || j == 3) return true;
        }
        return false;
    }
}
