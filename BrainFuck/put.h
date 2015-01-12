#ifndef PUT_H
#define PUT_H

#include "term.h"

using namespace std;

class Put: public Term
{
public:
    Put() = default;
    Put(const Put &original) = default;
    Put &operator=(const Put &rhs) = default;
    Put(Put &&victim) = default;
    Put &operator=(Put &&rhs) = default;
    ~Put() = default;

    void execute(Machine &machine, int &instruction) const override;
};

#endif // PUT_H
