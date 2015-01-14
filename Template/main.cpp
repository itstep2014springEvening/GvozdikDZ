#include<iostream>

using namespace std;

template <int i, int j, int k>
struct Sfinae
{
    static const int result = 0;
};

namespace zz
{
template <int i>
struct Sfinae<i,i,i>
{
    static const int result = 1;
};
}

template <int i, int j>
struct Sfinae<i,j,i>
{
    static const int result = 2;
};

int main()
{
    Sfinae<1,1,1> s;
    cout << s.result;
}

/*#include<iostream>

using namespace std;

template <typename T>

void swap(T &a, T &b)
{
    T t = a;
    a = b;
    b = t;
    t=a*b;
    t=a+b;
    t=a/b;
    t=a-b;
    t=a%b;
    cout << "a and b are integer" << endl;
}

template <typename T>

void swap(T &a, T &b)
{
    T t = a;
    a = b;
    b = t;
    t=a*b;
    t=a+b;
    t=a/b;
    t=a-b;
    cout << "a and b are double" << endl;
}

class Open
{
public:
    Open() = default;
    Open(const Open &original) = default;
    Open &operator=(const Open &rhs) = default;
    Open(Open &&victim) = default;
    Open &operator=(Open &&rhs) = default;
    ~Open() = default;
};

int main()
{
    int a, b;
    swap(a,b);
}


*/

template <typename T>
class Stack
{
public:
    Stack();
    void push(T value);
};
template<typename T>
Stack <T>::Stack()
template<typename T>
Stack <T>::push(T value);
