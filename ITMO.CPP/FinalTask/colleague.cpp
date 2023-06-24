#include "Colleague.h"

Colleague::Colleague(const std::string& fio, const std::string& phoneNumber, const std::string& company, const std::string& position)
    : fio(fio), phoneNumber(phoneNumber), company(company), position(position) {}

std::string Colleague::getFIO() const {
    return fio;
}

std::string Colleague::getPhoneNumber() const {
    return phoneNumber;
}

std::string Colleague::getOccupation() const {
    return "Коллега";
}

std::string Colleague::getInfo() const {
    return "Коллега " + fio + ". Телефон: " + phoneNumber + ". Компания: " + company + ". Должность: " + position;
}
