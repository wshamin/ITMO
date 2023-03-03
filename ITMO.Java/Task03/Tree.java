package Task03;

public class Tree {
    private String name;
    private boolean isLive;
    private int age;

    public Tree() {
        System.out.println("Пустой конструктор без параметров сработал");
    }

    public Tree(String name, boolean isLive, int age) {
        this.name = name;
        this.isLive = isLive;
        this.age = age;
    }

    public Tree(String name, int age) {
        this.name = name;
        this.age = age;
    }
}
