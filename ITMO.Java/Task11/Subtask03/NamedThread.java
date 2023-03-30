package Task11.Subtask03;

class NamedThread extends Thread {
    private final Object lock;

    public NamedThread(String name, Object lock) {
        super(name);
        this.lock = lock;
    }

    @Override
    public void run() {
        while (true) {
            synchronized (lock) {
                System.out.println(getName());
                lock.notify();

                try {
                    lock.wait();
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
            }
        }
    }
}

