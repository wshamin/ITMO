package Task06.Subtask05;

import java.util.Scanner;

public class ExtendedClass extends MainClass {
    String userName;

    @Override
    public void infoReader() {
        userName = scanner.nextLine();
        System.out.println(this.userName);
    }
}
