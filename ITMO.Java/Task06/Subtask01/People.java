package Task06.Subtask01;

public abstract class People {
    String firstName;
    String lastName;

    public People(String firstName, String lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public String getFirstName() {
        return firstName;
    }

    public String getLastName() {
        return lastName;
    }

    abstract void getInfo();
}
