package Task11.Subtask03;

public class Main {
    public static void main(String[] args) {
        Object lock = new Object();

        NamedThread thread1 = new NamedThread("Thread 1", lock);
        NamedThread thread2 = new NamedThread("Thread 2", lock);

        thread1.start();
        thread2.start();

        try {
            thread1.join();
            thread2.join();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }
}
