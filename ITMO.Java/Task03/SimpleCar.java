package Task03;

public class SimpleCar {
    private String color;
    private String name;
    private int weight;

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getWeight() {
        return weight;
    }

    public void setWeight(int weight) {
        this.weight = weight;
    }

    public SimpleCar() {
    }

    public SimpleCar(String color, int weight) {
        this.color = color;
        this.weight = weight;
    }

    public SimpleCar(String color) {
        this.color = color;
    }

    public void getInfo() {
        System.out.println(name + " " + color  + " " + weight);
    }
}
