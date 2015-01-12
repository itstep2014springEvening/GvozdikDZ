#ifndef DEC_H
#define DEC_H

#include "term.h"

using namespace std;

class Dec: public Term
{
public:
    Dec() = default;
    Dec(const Dec &original) = default;
    Dec &operator=(const Dec &rhs) = default;
    Dec(Dec &&victim) = default;
    Dec &operator=(Dec &&rhs) = default;
    ~Dec() = default;

    void execute(Machine &machine, int &instruction) const override;
};

#endif // DEC_H
