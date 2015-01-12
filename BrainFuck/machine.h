#ifndef MACHINE_H
#define MACHINE_H

using namespace std;

class Machine
{
public:
    Machine();
    Machine(const Machine &original) = default;
    Machine &operator=(const Machine &rhs) = default;
    Machine(Machine &&victim) = default;
    Machine &operator=(Machine &&rhs) = default;
    ~Machine();

    void inc();
    void dec();
    void shl();
    void shr();
    void set(char c);
    char get() const;
private:
    char array[30000];
    int head;
};

#endif // MACHINE_H
