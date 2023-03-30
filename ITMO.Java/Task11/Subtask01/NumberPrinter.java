package Task11.Subtask01;

public class NumberPrinter implements Runnable {
    private int threadNum;

    public NumberPrinter(int threadNum) {
        this.threadNum = threadNum;
    }

    public void run() {
        System.out.println("Thread " + threadNum + " запущен");
        for (int i = 0; i <= 100; i++) {
            System.out.println("Thread " + threadNum + ": " + i);
        }
        System.out.println("Thread " + threadNum + " завершил свою работу");
    }
}
