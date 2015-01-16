#include "stack.h"
#include <iostream>

using namespace std;

int main()
{
    cout << "Enter number: ";

    int n;

    cin >> n;

    cout << "Enter " << n << " numbers:" << endl;

    int x;
    Stack<int> st;

    for(int i = 0; i < n; ++i)
    {
        cin >> x;
        st.push(x);
    }

    cout << endl;

    for(int i = 0; i <n; ++i)
    {
        cout << st.onTop() << endl;
        st.pop();
    }

    return 0;
}
