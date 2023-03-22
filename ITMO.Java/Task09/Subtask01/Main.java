package Task09.Subtask01;

import java.util.Collection;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        Collection<String> listWithDuplicates = List.of("один", "два", "три", "четыре", "один", "три");

        Collection<String> listWithoutDuplicates = RemoveDuplicatesUtil.removeDuplicates(listWithDuplicates);
        System.out.println("Оригинальная коллекция: " + listWithDuplicates);
        System.out.println("Коллекция без дубликатов: " + listWithoutDuplicates);
    }
}
