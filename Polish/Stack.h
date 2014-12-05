#pragma once

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
	Stack(); //�����������
	Stack(const Stack &original); //����������� �����������
	Stack &operator=(const Stack &rhs);  //�������� ������������
	Stack(Stack &&victim); //����������� �����������
	Stack &operator=(Stack &&rhs); //�������� ����������������� ������������
	~Stack(); //����������
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