package Task03;

import java.time.YearMonth;
import java.util.Date;

public class House {
    private String name;
    private int floorsCount;
    private int yearOfBuilt;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getFloorsCount() {
        return floorsCount;
    }

    public void setFloorsCount(int floorsCount) {
        this.floorsCount = floorsCount;
    }

    public int getYearOfBuilt() {
        return yearOfBuilt;
    }

    public void setYearOfBuilt(int yearOfBuilt) {
        this.yearOfBuilt = yearOfBuilt;
    }

    public int lifeTime() {
        int lifeTime = YearMonth.now().getYear() - yearOfBuilt;
        return lifeTime;
    }
}
