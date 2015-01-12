#ifndef OPEN_H
#define OPEN_H

#include "term.h"

using namespace std;

class Open: public Term
{
public:
    Open();
    Open(const Open &original) = default;
    Open &operator=(const Open &rhs) = default;
    Open(Open &&victim) = default;
    Open &operator=(Open &&rhs) = default;
    ~Open();

    void execute(Machine &machine, int &instruction) const override;
};

#endif // OPEN_H
