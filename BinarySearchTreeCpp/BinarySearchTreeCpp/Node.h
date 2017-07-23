#pragma once

class Node 
{
private:
	Node();
	int Value = 0;
	Node * Left = nullptr;
	Node * Right = nullptr;

public:
	Node(int value);
	void SetLeft(Node * n);
	void SetRight(Node * n);
	void AddValue(int value);
};
