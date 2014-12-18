#pragma once

typedef int Data;

class BinTree
{
public:
	BinTree(); //�����������
	BinTree(const BinTree &original); //����������� �����������
	BinTree &operator=(const BinTree &rhs);  //�������� ������������
	BinTree(BinTree &&victim); //����������� �����������
	BinTree &operator=(BinTree &&rhs); //�������� ����������������� ������������
	~BinTree(); //����������

	bool find(Data data) const;
	void push(Data data);
	void pop(Data data);
	void output() const;
private:
	struct Node
	{
		Data data;
		Node *right;
		Node *left;
		Node(Data data);
		~Node();
	} *root;
	static void output(Node *node);
};