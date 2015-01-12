#ifndef CLOSE_H
#define CLOSE_H

#include "term.h"

using namespace std;

class Close: public Term
{
public:
    Close(int neighbour);
    Close(const Close &original);
    Close &operator=(const Close &rhs);
    Close(Close &&victim);
    Close &operator=(Close &&rhs);
    ~Close();

    void execute(Machine &machine, int &instruction) const override;
private:
    int neighbour;
};

#endif // CLOSE_H
