#include "userinterface.h"
#include "student.h"
#include "teacher.h"
#include "colleague.h"
#include <iostream>
#include <limits>

void UserInterface::run() {
    while (true) {
        std::cout << "1. Добавить студента\n2. Добавить преподавателя\n3. Добавить коллегу\n4. Сохранить в файл\n5. Выйти" << std::endl;
        int choice;
        std::cin >> choice;
        std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n'); // очистить буфер ввода
        switch (choice) {
            case 1: {
                std::string fio, phoneNumber, university;
                std::cout << "Введите ФИО студента: ";
                std::getline(std::cin, fio);
                std::cout << "Введите номер телефона студента: ";
                std::getline(std::cin, phoneNumber);
                std::cout << "Введите университет студента: ";
                std::getline(std::cin, university);
                db.addPerson(std::make_shared<Student>(fio, phoneNumber, university));
                break;
            }
            case 2: {
                std::string fio, phoneNumber, university, subject;
                std::cout << "Введите ФИО преподавателя: ";
                std::getline(std::cin, fio);
                std::cout << "Введите номер телефона преподавателя: ";
                std::getline(std::cin, phoneNumber);
                std::cout << "Введите университет преподавателя: ";
                std::getline(std::cin, university);
                std::cout << "Введите предмет преподавателя: ";
                std::getline(std::cin, subject);
                db.addPerson(std::make_shared<Teacher>(fio, phoneNumber, university, subject));
                break;
            }
            case 3: {
                std::string fio, phoneNumber, company, position;
                std::cout << "Введите ФИО коллеги: ";
                std::getline(std::cin, fio);
                std::cout << "Введите номер телефона коллеги: ";
                std::getline(std::cin, phoneNumber);
                std::cout << "Введите компанию коллеги: ";
                std::getline(std::cin, company);
                std::cout << "Введите должность коллеги: ";
                std::getline(std::cin, position);
                db.addPerson(std::make_shared<Colleague>(fio, phoneNumber, company, position));
                break;
            }
            case 4: {
                std::string filename;
                std::cout << "Введите имя файла для сохранения: ";
                std::getline(std::cin, filename);
                db.saveToFile(filename);
                break;
            }
            case 5:
                return;
        }
    }
}