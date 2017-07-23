// BinarySearchTreeCpp.cpp : Defines the entry point for the console application.
//


#include "stdafx.h"
#include "Node.h";
#include <memory>


int main()
{
	std::unique_ptr<Node> head(new Node(15));
	head->AddValue(20);
	head->AddValue(10);
	head->AddValue(25);
	head->AddValue(15);
	head->AddValue(12);
	head->AddValue(9);
	head->AddValue(8);
	head->AddValue(16);
	head->AddValue(6);
	head->AddValue(5);
	head->AddValue(4);

    return 0;
}

