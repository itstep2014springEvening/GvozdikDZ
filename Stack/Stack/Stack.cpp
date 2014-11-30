#include "Stack.h"
#include <iostream>
#include <utility>

using namespace std;

Stack::Stack() : top(nullptr) //�����������
{

}
Stack::Stack(const Stack &original) : top(copy(original.top)) //����������� �����������
{

}
Stack &Stack::operator=(const Stack &rhs) //�������� ����������� ������������
{
	Stack temp(rhs);
	swap(*this, temp);
	return *this;
}
Stack::Stack(Stack &&victim) : top(nullptr) //����������� �����������
{
	swap(top, victim.top);
}
Stack &Stack::operator=(Stack &&rhs) //�������� ����������������� ������������
{
	swap(*this, rhs);
	return *this;
}
Stack::~Stack() //����������
{
	clear();
}
Stack::Node *Stack::copy(const Stack::Node *originalTop/*���������*/) //�������
{
	Node *newTop = nullptr;
	Node *p = nullptr;
	const Node *q = originalTop;
	p = new Node(q->data);
	newTop = p;
	q = q->next;
	while (q != nullptr)
	{
		Node *r = nullptr;
		r = new Node(q->data);
		p->next = r;
		p = p->next;
		q = q->next;
	}
	return newTop;
}
void Stack::push(Data data)
{

}
void Stack::pop()
{

}
Data Stack::onTop() const
{

}
bool Stack::isEmpty()const
{

}
void Stack::clear()
{

}