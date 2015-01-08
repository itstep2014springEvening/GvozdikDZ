#ifndef FISH_H
#define FISH_H

#include "animal.h"

class Fish: public Animal
{
public:
    Fish()=default;
    Fish(const Fish &)=default;
    Fish &operator=(const Fish &)=default;
    Fish(Fish &&)=default;
    Fish &operator=(Fish &&)=default;
    ~Fish()=default;

    void voice()const override;
};

#endif // FISH_H
