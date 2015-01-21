#include <iostream>
#include "list.h"
#include <exception>

using namespace std;

int main()
{
    try
    {
    List<int> list1, list2;
    list1.pushDatumToTheEnd(5);
    list1.pushDatumToTheEnd(3);
    list1.pushDatumToTheEnd(2);
    list1.pushDatumToTheEnd(7);
    list1.pushDatumToTheEnd(8);
    list1.pushDatumToTheEnd(6);
    cout << "list 1:\n";
    for(List<int>::Iterator it = list1.begin(); it != list1.end(); ++it)
    {
        cout << *it << endl;
    }

    list2.pushDatumToTheBegin(-2);
    list2.pushDatumToTheBegin(-5);
    list2.pushDatumToTheBegin(-7);
    list2.pushDatumToTheBegin(-8);
    list2.pushDatumToTheBegin(-3);
    cout << "list 2:\n";
    for(auto it = list2.begin(), end = list2.end(); it != end; ++it)
    {
        cout << *it << endl;
    }
    cout << "cut insert" << endl;
    auto from = list2.begin();
    ++from;
    auto to = list2.end();
    --to;
    auto where = list1.begin();
    ++where;
    ++where;
    auto list3 = list2.cutList(from, to);
    list1.insertList(where, list3);
    cout << "list 1:\n";
    for(List<int>::Iterator it = list1.begin(); it != list1.end(); ++it)
    {
        cout << *it << endl;
    }
    cout << "list 2:\n";
    for(auto it = list2.begin(), end = list2.end(); it != end; ++it)
    {
        cout << *it << endl;
    }
    } catch(exception &e)
    {
        cerr << e.what() << endl;
    }

    return 0;
}

