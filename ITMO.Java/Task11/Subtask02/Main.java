package Task11.Subtask02;

import java.util.concurrent.CountDownLatch;

public class Main {
    public static void main(String[] args) throws InterruptedException {
        Counter counter = new Counter();
        int numberOfThreads = 100;
        CountDownLatch latch = new CountDownLatch(numberOfThreads);
        Thread[] threads = new Thread[numberOfThreads];

        for (int i = 0; i < threads.length; i++) {
            threads[i] = new Thread(new Incrementer(counter, latch));
            threads[i].start();
        }

        try {
            latch.await();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        System.out.println("Конечное число: " + counter.getCount());
    }
}
