#ifndef READ_H
#define READ_H

#include "term.h"

using namespace std;

class Read: public Term
{
public:
    Read() = default;
    Read(const Read &original) = default;
    Read &operator=(const Read &rhs) = default;
    Read(Read &&victim) = default;
    Read &operator=(Read &&rhs) = default;
    ~Read() = default;

    void execute(Machine &machine, unsigned int &instruction) const override;
};

#endif // READ_H
