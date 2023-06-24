#include "personDB.h"
#include <fstream>

void PersonDB::addPerson(const std::shared_ptr<Person>& person) {
    persons.push_back(person);
}

void PersonDB::saveToFile(const std::string& filename) const {
    std::ofstream file(filename);
    for (const auto& person : persons) {
        file << person->getInfo() << std::endl;
    }
}
