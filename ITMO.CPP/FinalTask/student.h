#include "person.h"

class Student : public Person {
private:
    std::string fio;
    std::string phoneNumber;
    std::string university;
public:
    Student(const std::string& fio, const std::string& phoneNumber, const std::string& university);
    std::string getFIO() const override;
    std::string getPhoneNumber() const override;
    std::string getOccupation() const override;
    std::string getInfo() const override;
};