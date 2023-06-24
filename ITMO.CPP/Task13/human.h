#pragma once
#include <string>

class human {
public:
    human(std::string last_name, std::string name, std::string second_name)
        : last_name(std::move(last_name)), name(std::move(name)), second_name(std::move(second_name)) {}

    virtual std::string get_full_name() {
        return last_name + " " + name + " " + second_name;
    }

    virtual void print_info() = 0; // pure virtual function

private:
    std::string name;
    std::string last_name;
    std::string second_name;
};
