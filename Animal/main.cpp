#include <iostream>
#include <cstdlib>
#include <ctime>
#include "cat.h"
#include "dog.h"
#include "fish.h"

using namespace std;

int main()
{
    srand(time(nullptr));
    Animal *array[5];
    for (int i = 0; i < 5; ++i)
    {
        switch(rand()%3)
        {
            case 0:
            {
                array[i] = new Dog;
                break;
            }
            case 1:
            {
                array[i] = new Cat;
                break;
            }
            case 2:
            {
                array[i] = new Fish;
                break;
            }
        }
    }
    int select;
    cout << "Enter number: ";
    cin >> select;
    while(0 <= select && select < 5)
    {
        array[select]->voice();
        cin >> select;
    }
    return 0;
}

