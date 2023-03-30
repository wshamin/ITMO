package Task11.Subtask01;

public class NumberPrinter implements Runnable {
    public void run() {
        for (int i = 0; i <= 100; i++) {
            System.out.println(Thread.currentThread().getName() + ": " + i + "\n" +
                    "Состояние " + Thread.currentThread().getName() + " во время работы " +
                    Thread.currentThread().getState());
        }
    }
}
