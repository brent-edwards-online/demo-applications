#include "Node.h"
#include <memory>
Node::Node() {}

Node::Node(int value)
{
	this->Value = value;
	this->Left = nullptr;
	this->Right = nullptr;
}

void Node::SetLeft(Node * n)
{
	this->Left = n;
}

void Node::SetRight(Node * n)
{
	this->Left = n;
}

void Node::AddValue(int value)
{
	if (value <= this->Value)
	{
		if (this->Left != nullptr)
		{
			this->Left->AddValue(value);
		}
		else
		{
			std::unique_ptr<Node> newNode(new Node(value));
			this->Left = newNode.get();
		}
	}
	else
	{
		if (this->Right != nullptr)
		{
			this->Right->AddValue(value);
		}
		else
		{
			std::unique_ptr<Node> newNode(new Node(value));
			this->Right = newNode.get();
		}
	}
}