#include "person.h"

class Teacher : public Person {
private:
    std::string fio;
    std::string phoneNumber;
    std::string university;
    std::string subject;
public:
    Teacher(const std::string& fio, const std::string& phoneNumber, const std::string& university, const std::string& subject);
    std::string getFIO() const override;
    std::string getPhoneNumber() const override;
    std::string getOccupation() const override;
    std::string getInfo() const override;
};