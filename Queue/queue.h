#ifndef QUEUE_H
#define QUEUE_H

typedef int Data;

class Queue
{
public:
    Queue(); //Конструктор
    Queue(const Queue &other); //Конструктор копирования
    Queue &operator=(const Queue &rhs);  //Оператор присваивания
    Queue(Queue &&victim); //Конструктор перемещения
    Queue &operator=(Queue &&rhs); //Оператор переместительного присваивания
    ~Queue(); //Деструктор

    void push(Data data);
    void pop();
    Data inBegin() const;
    Data inEnd() const;
    bool isEmpty() const;
    void clear();

    void output() const;
private:
    struct Node
    {
        Data data;
        Node *next;
    } *head, *tail;
    int size;
    static Node *copy(const Node *node);
    static void output(Node *node);
};
#endif // QUEUE_H
