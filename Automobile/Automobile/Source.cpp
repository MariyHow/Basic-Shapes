#pragma once
// Make
//Year model
// Mileage
// Price
// A car class attributes for the make, year model, milage, price, and number of doors
// A Truck class attributes for the make, year model, mileage, price, and drive type
// A SUV class attributes for the make, year model, mileage, price, and passenger capacity

#include <iostream>
using namespace std;

class Automobile {
protected:
	string make;
	int year;
	int mileage;
	int price;
public:
	Automobile() { make = ""; year = 0; mileage = 0; price = 0; }
	Automobile(string m, int y, int ml, int p) { make = m; year = y; mileage = ml; price = p; }
	void setMake(string m) { make = m; }
	void setYear(int y) { year = y; }
	void setMileage(int ml) { mileage = ml; }
	void setPrice(int p) { price = p; }
	string getMake() const { return make; }
	int getYear() const { return year; }
	int getMileage() const { return mileage; }
	int getPrice() const { return price; }
	virtual void PrintInfo() { cout << make << " " << year << " " << mileage << " " << endl; }

};

class Car : public Automobile {
private:
	int doors;
public:
	Car() :Automobile() { doors = 0; }
	Car(string m, int y, int ml, int p, int d) :Automobile(m, y, ml, p) { doors = d; }
	void setDoors(int d) { doors = d; }
	int getDoors() const { return doors; }

	virtual void PrintInfo() { cout << make << " " << year << " " << mileage << " " << endl; }
};

class SUV : public Automobile {
private:
	int capacity;
public:
	SUV() :Automobile() { capacity = 0; }
	SUV(string m, int y, int ml, int p, int c) :Automobile(m, y, ml, p) { capacity = c; }
	void setCapacity(int c) { capacity = c; }
	int getCapacity() const { return capacity; }

	virtual void PrintInfo() { cout << make << " " << year << " " << mileage << " " << price << " " << capacity << " " << endl; }
};

class Truck : public Automobile {
protected:
	string driveType;
public:
	Truck() :Automobile() { driveType = ""; }
	Truck(string m, int y, int ml, int p, string d) : Automobile(m, y, ml, p) { driveType = d; }
	void setDrive(int d) { driveType = d; }
	string getDrive() const { return driveType; }

	virtual void PrintInfo() { cout << make << " " << year << " " << mileage << " " << endl; }
};

class MonsterTruck : public Truck {
private:
	int wheelSize;
public:
	MonsterTruck() :Truck() { wheelSize = 0; }
	MonsterTruck(string m, int y, int ml, int p, string d, int w) : Truck(m, y, ml, p, d) { wheelSize = w; }
	void setWheel(int w) { wheelSize = w; }
	int getWheel() const { return wheelSize; }

	virtual void PrintInfo() { cout << make << " " << year << " " << mileage << " " << price << " " << driveType << " " << wheelSize << " " << endl; }

};

//----------User Side----------------

int main() {
	//Car C("Toyota", 2019, 10000, 15000, 2); C.PrintInfo();
	//MonsterTruck M("Dodge", 2015, 50000, 30000, "AWD", 60); M.PrintInfo();

	A[0] = new Car("Toyota", 2019, 10000, 15000, 2); A[0]->PrintInfo();
	A[1] = new MonsterTruck("Dodge", 2015, 50000, 30000, "AWD", 60); A[1]->PrintInfo();
}