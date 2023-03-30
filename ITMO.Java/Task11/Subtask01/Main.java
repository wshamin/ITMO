package Task11.Subtask01;

public class Main {
    public static void main(String[] args) {
        for (int i = 1; i <= 10; i++) {
            Thread t = new Thread(new NumberPrinter());
            System.out.println("Состояние " + t.getName() + " перед запуском " + t.getState());
            t.start();
            System.out.println("Состояние " + t.getName() + " после запуска " + t.getState());
        }
    }
}
