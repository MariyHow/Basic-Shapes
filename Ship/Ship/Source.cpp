//Page 267
#include<iostream>
using namespace std;

class Ship {
protected:
	string name;
	string year;
public:
	Ship() { name = ""; year = ""; }
	Ship(string n, string y) { name = n; year = y; }
	void setName(string n) { name = n; }
	void setYear(string y) { year = y; }
	string getName() const { return name; }
	string getYear() const { return year; }
	virtual void PrintInfo() { cout << name << " " << year << " " << endl; }
};

class CruiseShip : public Ship {
private: 
	int passengars;
public:
	CruiseShip() : Ship() { passengars = 0; }
	CruiseShip(string n, string y, int c) :Ship(n, y) { passengars = 0; }
	void setPassengars(int p) { passengars = p; }
	int getPassengars() const { return passengars; }
	virtual void PrintInfo() { cout << name << " " << passengars << " " << endl; }
};

class CargoShip : public Ship {
protected:
	int capacity;
public:
	CargoShip() : Ship() { capacity = 0; }
	CargoShip(string n, string y, int c) :Ship(n, y) { capacity = c; }
	void setCapacity(int c) { capacity = c; }
	int getCapacity() const { return capacity; }
	virtual void PrintInfo() { cout << name << " " << capacity << " " << endl; }
};

int main() {
	Ship* S[3];
	S[0] = new Ship("Courage", "2000");
	S[1] = new CruiseShip("Dream", "2010", 1000);

	S[0]->PrintInfo();
	S[1]->PrintInfo();
}
