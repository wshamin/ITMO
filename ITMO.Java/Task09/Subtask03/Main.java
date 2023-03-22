package Task09.Subtask03;

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        User user1 = new User("Федор");
        User user2 = new User("Алексей");
        User user3 = new User("Иван");

        Map<User, Integer> userPoints = new HashMap<>();
        userPoints.put(user1, 100);
        userPoints.put(user2, 200);
        userPoints.put(user3, 300);

        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите имя пользователя: ");
        String inputName = scanner.nextLine();

        boolean userFound = false;
        for (Map.Entry<User, Integer> entry : userPoints.entrySet()) {
            if (entry.getKey().getName().equals(inputName)) {
                userFound = true;
                System.out.println("Количество очков пользователя " + inputName + ": " + entry.getValue());
                break;
            }
        }

        if (!userFound) {
            System.out.println("Пользователь с именем " + inputName + " не найден.");
        }
    }
}
