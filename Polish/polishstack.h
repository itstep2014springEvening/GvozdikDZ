#ifndef POLISHSTACK_H
#define POLISHSTACK_H

struct DAC
{
    double x;
    char operation;
    bool isDouble;
};
typedef DAC Data;

class Stack
{
public:
    Stack(); //Конструктор
    Stack(const Stack &original); //Конструктор копирования
    Stack &operator=(const Stack &rhs);  //Оператор присваивания
    Stack(Stack &&victim); //Конструктор перемещения
    Stack &operator=(Stack &&rhs); //Оператор переместительного присваивания
    ~Stack(); //Деструктор
    void push(Data data);
    void pop();
    Data onTop() const;
    bool isEmpty() const;
    void clear();
private:
    struct Node
    {
        Data data;
        Node *next;
        Node(Data data);
        ~Node();
    } *top;
    static Node *copy(const Node *otherTop);
};

#endif // POLISHSTACK_H
