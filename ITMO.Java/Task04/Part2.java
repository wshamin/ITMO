package Task04;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class Part2 {
    public static void main(String[] args) {
        int[] sortedArray = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        int[] notSortedArray = {1, 5, 2, 3, 7, 8, 0, 4, 9, 6};

        checkAscSort(sortedArray);
        checkAscSort(notSortedArray);
        System.out.println();

        printArray();
        System.out.println();

        switchFirstLastNum(sortedArray);
        System.out.println();

        int[] arrayWithUniqueFive = {1, 5, 2, 3, 7, 8, 0, 4, 9, 6, 6, 3, 9, 7, 8, 0, 2, 1, 4};
        findUniqueNumber(arrayWithUniqueFive);
    }

    private static void checkAscSort(int[] array) {
        for (int i = 0; i < array.length; i++) {
            if (i == array.length - 1) {
                System.out.println("OK");
                break;
            }

            if (array[i] > array[i+1]) {
                System.out.println("Please, try again");
                break;
            }
        }
    }

    private static void printArray() {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Array length: ");
        int[] intArray = new int[Integer.parseInt(scanner.nextLine())];
        System.out.println("Numbers of array: ");
        for (int i = 0; i < intArray.length; i++) {
            intArray[i] = Integer.parseInt(scanner.nextLine());
        }

        System.out.println("Result: " + Arrays.toString(intArray));
        scanner.close();
    }

    private static void switchFirstLastNum(int[] intArray) {
        System.out.println("Array 1: " + Arrays.toString(intArray));

        int tempInt = intArray[0];
        intArray[0] = intArray[intArray.length - 1];
        intArray[intArray.length - 1] = tempInt;

        System.out.println("Array 2: " + Arrays.toString(intArray));
    }

    private static void findUniqueNumber(int[] intArray) {
        int[] uniqueNumbers = new int[intArray.length];
        for (int i = 0; i < intArray.length ; i++) {
            uniqueNumbers[i] = intArray[i];
        }

        for (int i = 0; i < intArray.length; i++) {
            for (int j = 0; j < uniqueNumbers.length; j++) {
                if (i != j && intArray[i] == uniqueNumbers[j]) {
                    uniqueNumbers[j] = 0;
                }
            }
        }

        for (int i = 0; i < uniqueNumbers.length; i++) {
            if (uniqueNumbers[i] != 0) {
                System.out.println(uniqueNumbers[i]);
                break;
            }
        }
    }
}
