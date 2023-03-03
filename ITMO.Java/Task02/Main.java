package Task02;

public class Main {
    public static void main(String[] args) {
        Calculator calc = new Calculator();

        double resultOfDivInt = calc.div(25, 4);

        double resultOfDivLong = calc.div(100L, 3L);

        System.out.println(resultOfDivInt + " " + resultOfDivLong);
    }
}
