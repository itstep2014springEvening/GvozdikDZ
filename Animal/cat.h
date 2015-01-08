#ifndef CAT_H
#define CAT_H

#include "animal.h"

class Cat: public Animal
{
public:
    Cat()=default;
    Cat(const Cat &)=default;
    Cat &operator=(const Cat &)=default;
    Cat(Cat &&)=default;
    Cat &operator=(Cat &&)=default;
    ~Cat()=default;

    void voice()const override;
};

#endif // CAT_H
