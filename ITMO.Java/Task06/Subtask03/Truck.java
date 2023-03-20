package Task06.Subtask03;

public class Truck extends Car {
    int wheelNumber;
    int maxWeight;

    public Truck(int w, String m, char c, float s, int wheelNumber, int maxWeight) {
        super(w, m, c, s);
        this.wheelNumber = wheelNumber;
        this.maxWeight = maxWeight;
    }

    public void newWheels(int wheelNumber) {
        this.wheelNumber = wheelNumber;
        System.out.println(this.wheelNumber);
    }
}
