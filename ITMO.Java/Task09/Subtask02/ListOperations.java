package Task09.Subtask02;

import java.util.List;
import java.util.Random;

public class ListOperations {

    public static void addElements(List<Integer> list, int numberOfElements) {
        for (int i = 0; i < numberOfElements; i++) {
            list.add(i);
        }
    }

    public static void getRandomElements(List<Integer> list, int numberOfRandomSelections) {
        int listSize = list.size();
        for (int i = 0; i < numberOfRandomSelections; i++) {
            int randomIndex = (int) (Math.random() * listSize);
            list.get(randomIndex);
        }
    }
}
