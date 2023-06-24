#include "Student.h"

Student::Student(const std::string& fio, const std::string& phoneNumber, const std::string& university)
    : fio(fio), phoneNumber(phoneNumber), university(university) {}

std::string Student::getFIO() const {
    return fio;
}

std::string Student::getPhoneNumber() const {
    return phoneNumber;
}

std::string Student::getOccupation() const {
    return "Студент";
}

std::string Student::getInfo() const {
    return "Студент " + fio + ". Телефон: " + phoneNumber + ". Университет: " + university;
}
