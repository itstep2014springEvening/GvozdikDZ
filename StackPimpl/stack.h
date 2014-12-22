#ifndef STACK_H
#define STACK_H

typedef int Data;

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
protected:
    void getArrayRepresentation(Data *&array, int &size) const;
private:
    class Implementation;
    Implementation *pimpl;
};

#endif // STACK_H
