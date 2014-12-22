#ifndef CONSOLESTACK_H
#define CONSOLESTACK_H

#include "stack.h"

class ConsoleStack:public Stack
{
public:
    ConsoleStack()=default;
    ConsoleStack(const ConsoleStack &)= default;
    ConsoleStack &operator=(const ConsoleStack &)= default;
    ConsoleStack(ConsoleStack &&)= default;
    ConsoleStack &operator=(ConsoleStack &&)= default;
    ~ConsoleStack()=default;

    void output() const;
};

#endif // CONSOLESTACK_H
