#include "Teacher.h"

Teacher::Teacher(const std::string& fio, const std::string& phoneNumber, const std::string& university, const std::string& subject)
    : fio(fio), phoneNumber(phoneNumber), university(university), subject(subject) {}

std::string Teacher::getFIO() const {
    return fio;
}

std::string Teacher::getPhoneNumber() const {
    return phoneNumber;
}

std::string Teacher::getOccupation() const {
    return "Преподаватель";
}

std::string Teacher::getInfo() const {
    return "Преподаватель " + fio + ". Телефон: " + phoneNumber + ". Университет: " + university + ". Предмет: " + subject;
}
