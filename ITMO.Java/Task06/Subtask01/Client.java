package Task06.Subtask01;

public class Client extends People {
    String bankName;

    public Client(String firstName, String lastName, String bankName) {
        super(firstName, lastName);
        this.bankName = bankName;
    }

    @Override
    void getInfo() {
        System.out.println(this.firstName + " " + this.lastName);
    }
}
