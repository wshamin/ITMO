#include "person.h"

class Colleague : public Person {
private:
    std::string fio;
    std::string phoneNumber;
    std::string company;
    std::string position;
public:
    Colleague(const std::string& fio, const std::string& phoneNumber, const std::string& company, const std::string& position);
    std::string getFIO() const override;
    std::string getPhoneNumber() const override;
    std::string getOccupation() const override;
    std::string getInfo() const override;
};