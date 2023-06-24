#include <iostream>
#include <vector>
#include "human.h"
#include "student.h"
#include "teacher.h"

int main() {
    std::vector<int> scores;

    scores.push_back(5);
    scores.push_back(3);
    scores.push_back(4);
    scores.push_back(4);
    scores.push_back(5);
    scores.push_back(3);
    scores.push_back(3);
    scores.push_back(3);
    scores.push_back(3);

    student* stud = new student("Петров", "Иван", "Алексеевич", scores);

    unsigned int teacher_work_time = 40;
    teacher* tch = new teacher("Сергеев", "Дмитрий", "Сергеевич", teacher_work_time);

    std::vector<human*> people;

    people.push_back(stud);
    people.push_back(tch);

    for (auto& person : people) {
        person->print_info();
    }

    delete stud;
    delete tch;

    return 0;
}
