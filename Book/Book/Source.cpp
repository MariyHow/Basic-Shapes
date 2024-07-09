#include<iostream>
#include <stdio.h>
#include <stdlib.h>
using namespace std;

class Book {
protected:
	string title;
	string author;
	int price;
public:
	Book() { title = ""; author = ""; price = 0; }
	Book(string t, string a, int p) { title = t; author = a; price = p; }
	void settitle(string t) { title = t; }
	void setauthor(string a) { author = a; }
	void setPrice(int p) { price = p; }
	string gettitle() const { return title; }
	string getauthor() const { return author; }
	int getPrice() const { return price; }
	void PrintInfo() { cout << title << " " << author << " " << price << " " << endl; }
};

class Node {
public:
	string Book;
	Node* next;
	Node() { Book = "";  next = nullptr; }
	Node(char x) { Book = x; next = nullptr; }
};


class DynamicStack {
public:
	Node* top;
	DynamicStack() { top = nullptr; }

	void PrintInfo() {
		Node* temp = top;
		while (temp != nullptr) {
			cout << temp->Book << " ";
			temp = temp->next;
		}
		cout << endl;
	}

	Book Pop() {
		Node* nodeToBeDeleted = top;
		top = top->next;
		delete nodeToBeDeleted;
		if (top = nullptr)
		{
			cout << "ERROR!! Box is Empty!" << endl;
	}

		int StackTop() {
		if (top != nullptr)
			return top->Book;
		else
			cout << "Nothing to return" << endl;
	}

};

	int main() {
		DynamicStack* Book = new DynamicStack();

		Book->PrintInfo();

		cout << Book->StackTop() << endl;

		Book->Pop();	 Book->PrintInfo();
		Book->Pop();	 Book->PrintInfo();
		Book->Pop();	 Book->PrintInfo();
		Book->Pop();	 Book->PrintInfo();
		Book->Pop();

	}