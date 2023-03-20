package Task07.Subtask02;

public class Main {
    public static void main(String[] args) {
        Airplane plane1 = new Airplane();
        plane1.wing.setWeight(900);
        System.out.println(plane1.wing.getWeight());

        Airplane plane2 = new Airplane();
        plane2.wing.setWeight(1000);
        System.out.println(plane2.wing.getWeight());
    }
}
