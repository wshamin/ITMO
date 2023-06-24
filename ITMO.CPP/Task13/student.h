#include "human.h"
#include <vector>

class student : public human {
public:
    student(std::string last_name, std::string name, std::string second_name, std::vector<int> scores)
        : human(std::move(last_name), std::move(name), std::move(second_name)), scores(std::move(scores)) {}

    float get_average_score() {
        int sum_scores = 0;
        for (int i = 0; i < scores.size(); ++i) {
            sum_scores += this->scores[i];
        }
        return (float)sum_scores / (float)scores.size();
    }

    void print_info() override {
        std::cout << "Студент: " << get_full_name() << ", средний балл: " << get_average_score() << "\n";
    }

private:
    std::vector<int> scores;
};
