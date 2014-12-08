#pragma once

typedef int Data;

class Queue
{
public:
	Queue(); //�����������
	Queue(const Queue &original); //����������� �����������
	Queue &operator=(const Queue &rhs);  //�������� ������������
	Queue(Queue &&victim); //����������� �����������
	Queue &operator=(Queue &&rhs); //�������� ����������������� ������������
	~Queue(); //����������
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