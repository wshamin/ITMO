#include<iostream>

class Time {
private:
    int hours;
    int minutes;
    int seconds;

public:
    // Конструктор по умолчанию
    Time() : hours(0), minutes(0), seconds(0) { }

    // Конструктор с параметрами
    Time(int h, int m, int s) {
        seconds = s % 60;
        minutes = (m + s / 60) % 60;
        hours = (h + (m + s / 60) / 60) % 24;
    }

    // Метод для вывода времени
    void displayTime() const {
        std::cout << hours << ":" << minutes << ":" << seconds << std::endl;
    }

    // Метод для сложения двух объектов Time
    void addTime(const Time& t) {
        seconds = (this->seconds + t.seconds) % 60;
        int totalMinutes = this->minutes + t.minutes + (this->seconds + t.seconds) / 60;
        minutes = totalMinutes % 60;
        int totalHours = this->hours + t.hours + totalMinutes / 60;
        hours = totalHours % 24;
    }
};

int main() {
    // Создаем два инициализированных объекта
    Time t1(10, 59, 59);
    Time t2(2, 59, 2);

    // Складываем два инициализированных значения
    t1.addTime(t2);

    // Выводим значение на экран
    t1.displayTime();

    return 0;
}
