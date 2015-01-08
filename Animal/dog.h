#ifndef DOG_H
#define DOG_H

#include "animal.h"

class Dog: public Animal
{
public:
    Dog()=default;
    Dog(const Dog &)=default;
    Dog &operator=(const Dog &)=default;
    Dog(Dog &&)=default;
    Dog &operator=(Dog &&)=default;
    ~Dog()=default;

    void voice()const override;
};

#endif // DOG_H
