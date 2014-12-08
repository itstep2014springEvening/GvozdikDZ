#include "Queue.h"
#include <iostream>
#include <utility>

using namespace std;

Queue::Queue() : queueNode(nullptr) //�����������
{

}
Queue::Queue(const Queue &original) : queueNode(nullptr) //����������� �����������
{
	queueNode = copy(original.queueNode);
}
Queue &Queue::operator=(const Queue &rhs) //�������� ����������� ������������
{
	Queue temp(rhs);
	swap(*this, temp);
	return *this;
}
Queue::Queue(Queue &&victim) : queueNode(nullptr) //����������� �����������
{
	swap(queueNode, victim.queueNode);
}
Queue &Queue::operator=(Queue &&rhs) //�������� ����������������� ������������
{
	swap(*this, rhs);
	return *this;
}
Queue::~Queue() //����������
{
	clear();
}
Queue::Node *Queue::copy(const Queue::Node *original/*���������*/) //�������
{
	Node *newTop = nullptr;
	Node *p = nullptr;
	const Node *q = original;
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
void Queue::push(Data data)
{
	Node *p = nullptr;
	p = new Node(data);
	queueNode->last = p->next;
	queueNode->last = p;
	queueNode->size++;
}
void Queue::pop()
{
	if (!isEmpty())
	{
		Node *p = queueNode->first;
		p = queueNode->first->next;
		delete p;
	}
}
Data Queue::first() const
{
	if (isEmpty())
		throw exception();
	return queueNode->first->data;
}
Data Queue::last() const
{
	if (isEmpty())
		throw exception();
	return queueNode->last->data;
}
bool Queue::isEmpty()const
{
	return queueNode == nullptr;
}
void Queue::clear()
{
	while (!isEmpty())
	{
		Node *p = queueNode->first;
		p = queueNode->first->next;
		delete p;
	}
}