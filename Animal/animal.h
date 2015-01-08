#ifndef ANIMAL_H
#define ANIMAL_H


class Animal
{
public:
    Animal()=default;
    Animal(const Animal &)=default;
    Animal &operator=(const Animal &)=default;
    Animal(Animal &&)=default;
    Animal &operator=(Animal &&)=default;
    ~Animal()=default;

    virtual void voice() const;
};

#endif // ANIMAL_H
