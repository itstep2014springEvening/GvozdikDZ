#ifndef SIMPLE_H
#define SIMPLE_H

#include <iostream>
#include <vector>
#include <map>


class Simple
{
public:
    Simple();
    Simple(const Simple &other) = default;
    Simple &operator=(const Simple &victim) = default;
    Simple(Simple &&victim) = default;
    Simple &operator=(Simple &&victim) = default;
    ~Simple();

    void remCommand();
    void inputCommand();
    void letCommand();
    void printCommand();
    void gotoCommand();
    void ifgotoCommand();
    void endCommand();

    void commandMaper();
    void codeAnalyser();
    void commandComparison();
    void vectorPrint();

private:
    typedef void(Simple::*Treatmenter)();
    std::map<std::string, Treatmenter> command;
    std::vector<std::vector<std::string>> commandsString;
};

#endif // SIMPLE_H
