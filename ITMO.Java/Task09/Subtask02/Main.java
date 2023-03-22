package Task09.Subtask02;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;

public class Main {

    public static void main(String[] args) {
        int numberOfElements = 1000000;
        int numberOfRandomSelections = 100000;

        List<Integer> arrayList = new ArrayList<>();
        List<Integer> linkedList = new LinkedList<>();

        long startTime, endTime;

        startTime = System.currentTimeMillis();
        ListOperations.addElements(arrayList, numberOfElements);
        endTime = System.currentTimeMillis();
        System.out.println("Для добавления 100000 элементов в ArrayList потребовалось " + (endTime - startTime) + " мсек");

        startTime = System.currentTimeMillis();
        ListOperations.addElements(linkedList, numberOfElements);
        endTime = System.currentTimeMillis();
        System.out.println("Для добавления 100000 элементов в LinkedList потребовалось " + (endTime - startTime) + " мсек");

        startTime = System.currentTimeMillis();
        ListOperations.getRandomElements(arrayList, numberOfRandomSelections);
        endTime = System.currentTimeMillis();
        System.out.println("Было затрачено " + (endTime - startTime) + " мсек на выбор случайного элемента из ArrayList");

        startTime = System.currentTimeMillis();
        ListOperations.getRandomElements(linkedList, numberOfRandomSelections);
        endTime = System.currentTimeMillis();
        System.out.println("Было затрачено " + (endTime - startTime) + "  мсек на выбор случайного элемента из LinkedList");
    }
}
