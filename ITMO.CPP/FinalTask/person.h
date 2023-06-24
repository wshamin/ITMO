#pragma once
#include <string>

class Person {
public:
    virtual std::string getFIO() const = 0;
    virtual std::string getPhoneNumber() const = 0;
    virtual std::string getOccupation() const = 0;
    virtual std::string getInfo() const = 0;
};