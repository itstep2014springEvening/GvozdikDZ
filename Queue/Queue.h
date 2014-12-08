#pragma once

typedef int Data;

class Queue
{
public:
	Queue(); //Конструктор
	Queue(const Queue &original); //Конструктор копирования
	Queue &operator=(const Queue &rhs);  //Оператор присваивания
	Queue(Queue &&victim); //Конструктор перемещения
	Queue &operator=(Queue &&rhs); //Оператор переместительного присваивания
	~Queue(); //Деструктор
	void push(Data data);
	void pop();
	Data first() const;
	Data last() const;
	bool isEmpty() const;
	void clear();
private:
	struct Node
	{
		Data data;
		Node *next;
		Node(Data data);
		~Node();
	};
	struct queueStruct
	{
		int size;
		Node *first;
		Node *last;
	} *queueNode;
	static Node *copy(const Node *other);
};