package Task03;

public class JavaProgram {
    public static void main(String[] args) {
        Study study = new Study("«Изучение Java - это просто!»");

        System.out.println(study.printCourse());

        System.out.println();

        SimpleCar suzuki = new SimpleCar();
        suzuki.setName("Suzuki Escudo");
        suzuki.setColor("Blue");
        suzuki.setWeight(900);

        SimpleCar toyota = new SimpleCar("Black", 2200);
        toyota.setName("Toyota Land Cruiser");

        suzuki.getInfo();
        toyota.getInfo();

        System.out.println();

        House oldHouse = new House();
        oldHouse.setName("John's House");
        oldHouse.setFloorsCount(2);
        oldHouse.setYearOfBuilt(1994);

        House newHouse = new House();
        newHouse.setName("Eleonora's House");
        newHouse.setFloorsCount(4);
        newHouse.setYearOfBuilt(2012);

        System.out.println(oldHouse.getName() + " " + oldHouse.getFloorsCount() + " "
                + oldHouse.getYearOfBuilt() + " " + oldHouse.lifeTime());

        System.out.println(newHouse.getName() + " " + newHouse.getFloorsCount() + " "
                + newHouse.getYearOfBuilt() + " " + newHouse.lifeTime());

        System.out.println();

        Tree maple = new Tree("maple", 22);
        Tree alder = new Tree("alder", true, 12);
        Tree simpleTree = new Tree();
    }
}
