#include<iostream>
#include<list>
using namespace std;

class BasicShape {
protected:
	double area;
public:
	double getArea() const { return area; }
	virtual void calcArea() = 0;
};

class Triangle: public BasicShape {
private:
	int Base;
	int perpendicular;
public:
	Triangle(int b, int p) { Base = b; perpendicular = p; calcArea(); }
	int getBase() const { return Base; }
	virtual void calcArea() { area = Base * perpendicular * 0.5f; }
};

class Square: public BasicShape {
private:
	int Side;
public:
	Square(int s) { Side = s; calcArea(); }
	int getSide() const { return Side; }
	virtual void calcArea() { area = Side * Side; }
};

int main() {
	Triangle* T = new Triangle(6, 2);
	cout << T->getArea();





}