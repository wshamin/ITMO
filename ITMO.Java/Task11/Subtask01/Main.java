package Task11.Subtask01;

public class Main {
    public static void main(String[] args) {
        for (int i = 1; i <= 10; i++) {
            Thread t = new Thread(new NumberPrinter(i));
            System.out.println("Сейчас мы запустим Thread " + i);
            t.start();
        }
    }
}
