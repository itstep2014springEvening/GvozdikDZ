#include <iostream>
#include <fstream>
#include <regex>
#include "simple.h"

using namespace std;

Simple::Simple()
{

}

Simple::~Simple()
{

}

void Simple::remCommand()
{
    cout << "1" << endl;
}

void Simple::inputCommand()
{
    cout << "2" << endl;
}

void Simple::letCommand()
{
    cout << "3" << endl;
}

void Simple::printCommand()
{
    cout << "4" << endl;
}




void Simple::gotoCommand()
{
    cout << "5" << endl;
}

void Simple::ifgotoCommand()
{
    cout << "6" << endl;
}

void Simple::endCommand()
{
    cout << "7" << endl;
}

void Simple::commandMaper()
{
    command.insert(make_pair("rem", &remCommand));
    command.insert(make_pair("input", &inputCommand));
    command.insert(make_pair("let", &letCommand));
    command.insert(make_pair("print", &printCommand));
    command.insert(make_pair("goto", &gotoCommand));
    command.insert(make_pair("if", &ifgotoCommand));
    command.insert(make_pair("end", &endCommand));
}

void Simple::codeAnalyser()
{
    ifstream inputFile("program.txt");
    if (inputFile)
    {
        int i = 0;
        cout << "Read program from \"program.txt\" file:" << endl;
        while(!inputFile.eof())
        {
            string inputString;
            getline(inputFile, inputString);
            commandsString.push_back(vector<string>());
            regex wordRegex("([a-z]+|(0|[1-9])\\d*|[=!<>]=|[-+*/=()<>])");
            for (auto it = sregex_iterator(inputString.begin(), inputString.end(), wordRegex), end = sregex_iterator(); it != end; ++it)
            {
                commandsString[i].push_back(it->str());
            }
            ++i;
        }
        commandMaper();
        commandComparison();
    }
    else
        cout << "Open file \"program.txt\" error!" << endl;
}

void Simple::commandComparison()
{
    for(unsigned int j = 0; j < commandsString.size(); j++)
    {
        for(auto it = command.begin(); it != command.end(); ++it)
        {
            if (it->first == commandsString[j][1])
               (this->*command[commandsString[j][1]])();
        }
    }
}

void Simple::vectorPrint()
{
    for(unsigned int j = 0; j < commandsString.size(); j++)
    {
        for(unsigned int k = 0; k < commandsString[j].size(); ++k)
        {
            cout << commandsString[j][k] << " ";
        }
        cout << endl;
    }
}

