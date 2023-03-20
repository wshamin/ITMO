package Task06.Subtask05;

import java.util.Scanner;

public class MainClass {
    int userAge;
    Scanner scanner = new Scanner(System.in);

    public void infoReader() {
        this.userAge = scanner.nextInt();
        System.out.println(this.userAge);
    }
}
