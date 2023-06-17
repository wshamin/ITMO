#include "human.h.cpp"
#include <string>
#include <vector>

class student : public human {
     public:
         // Конструктор класса Student
         student(std::string last_name, std::string name, std::string second_name,
         std::vector<int> scores) : human(last_name, name, second_name) {
             this->scores = scores;
         }
         // Получение среднего балла студента
         float get_average_score()
         {
             // Общее количество оценок
             unsigned int count_scores = this->scores.size(); // Сумма всех оценок студента
             unsigned int sum_scores = 0;
// Средний балл
             float average_score;
             for (unsigned int i = 0; i < count_scores; ++i) { sum_scores += this->scores[i];
             }
             average_score = (float) sum_scores / (float) count_scores;
             return average_score;
         }
     private:
         // Оценки студента
         std::vector<int> scores;
};