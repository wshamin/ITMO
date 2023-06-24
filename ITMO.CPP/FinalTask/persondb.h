#include <vector>
#include <memory>
#include "person.h"

class PersonDB {
private:
    std::vector<std::shared_ptr<Person>> persons;
public:
    void addPerson(const std::shared_ptr<Person>& person);
    void saveToFile(const std::string& filename) const;
};