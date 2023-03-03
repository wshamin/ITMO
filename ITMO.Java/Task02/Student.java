package JavaBasics.Task02;

public class Student {
    private String name;
    private int age;
    private String faculty;
    private boolean foreigner;
    private String university;
    private SportSection section;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public String getFaculty() {
        return faculty;
    }

    public void setFaculty(String faculty) {
        this.faculty = faculty;
    }

    public boolean isForeigner() {
        return foreigner;
    }

    public void setForeigner(boolean foreigner) {
        this.foreigner = foreigner;
    }

    public String getUniversity() {
        return university;
    }

    public void setUniversity(String university) {
        this.university = university;
    }

    public SportSection getSection() {
        return section;
    }

    public void setSection(SportSection section) {
        this.section = section;
    }

    public Student() {
    }

    public Student(String name, int age, String university) {
        this.name = name;
        this.age = age;
        this.university = university;
    }

    public Student(String name, int age, String faculty, boolean foreign, String university, SportSection section) {
        this.name = name;
        this.age = age;
        this.faculty = faculty;
        this.foreigner = foreign;
        this.university = university;
        this.section = section;
    }

    @Override
    public String toString() {
        return "Student{" +
                "name='" + name + '\'' +
                ", age=" + age +
                ", faculty='" + faculty + '\'' +
                ", foreigner=" + foreigner +
                ", university='" + university + '\'' +
                ", section=" + section +
                '}';
    }
}
