#include "human.h"

class teacher : public human {
public:
    teacher(std::string last_name, std::string name, std::string second_name, unsigned int work_time)
        : human(std::move(last_name), std::move(name), std::move(second_name)), work_time(work_time) {}

    unsigned int get_work_time() {
        return this->work_time;
    }

    void print_info() override {
        std::cout << "Учитель: " << get_full_name() << ", рабочее время: " << get_work_time() << "\n";
    }

private:
    unsigned int work_time;
};
