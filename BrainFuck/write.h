#ifndef WRITE_H
#define WRITE_H

#include "term.h"

using namespace std;

class Write: public Term
{
public:
    Write() = default;
    Write(const Write &original) = default;
    Write &operator=(const Write &rhs) = default;
    Write(Write &&victim) = default;
    Write &operator=(Write &&rhs) = default;
    ~Write() = default;

    void execute(Machine &machine, unsigned int &instruction) const override;
};

#endif // WRITE_H
