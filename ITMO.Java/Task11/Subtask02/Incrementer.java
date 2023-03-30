package Task11.Subtask02;

import java.util.concurrent.CountDownLatch;

public class Incrementer implements Runnable {
    private Counter counter;
    private CountDownLatch latch;

    public Incrementer(Counter counter, CountDownLatch latch) {
        this.counter = counter;
        this.latch = latch;
    }

    public void run() {
        for (int i = 0; i < 1000; i++) {
            counter.increment();
        }
        latch.countDown();
    }
}
