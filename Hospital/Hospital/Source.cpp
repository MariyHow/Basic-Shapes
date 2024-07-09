
The PatientAccount class keeps a total of the patient’s charges in variable TotalCharges.It will also keep track of the number of days spent in the hospital. ($500 per day)
The Surgery class will have stored within it the charges for at least three types of surgery(Surgery1 :$100, Surgery2 : $200, Surgery3 : $300).It can update the TotalCharges variable of the PatientAccount class.

The Pharmacy class will have stored within it the price of three types of medication(Medication1 :$10, Medication2 : $20, Medication3 : $30).It can update the TotalCharges variable of the PatientAccount class.

The main program has a menu that allows the user to enter a type of surgery, a type of medication, number of days of hospital stay, and check the patient out of the hospital.When the patient checks out, the total charges should be displayed.

#include <iostream>
#include <string>
using namespace std;

class PatientAccount
{
private:
    double TotalCharges;
    int days;

public:
    PatientAccount() { TotalCharges = ""; days = ""; }
    PatientAccount(double t, int d) { TotalCharges = t; days = d; }
    void setTotalCharges(double t) { TotalCharges = t; }
    void setDays(int d) { days = d; }
    double getTotalCharges() const { return TotalCharges; }
    int getDays() const { return days; }
    virtual void PrintInfo() { cout << TotalCharges << " " << days << " " << endl; }
};

class Surgery
{
private:
    double surgeryCost;
    string surgeryType;

public:
    Surgery(double, string);
    double getCost();
    string getSurgeryType();
    void getSurgeryDisplay(double& cost1);
};

Surgery::Surgery(double c = 0, string st = " ")
{
    surgeryType = st;
    surgeryCost = c;

}
string Surgery::getSurgeryType()
{
    cout << "Enter the surgery type \n";
    cout << "Surgery 1" << endl;
    cout << "Surgery 2" << endl;
    cout << "Surgery 3" << endl;
    cin >> surgeryType;
    return surgeryType;
}

double Surgery::getCost()
{
    if (surgeryType == "Surgery 1")
    {
        surgeryCost = 100;
    }
    if (surgeryType == "Surgery 2")
    {
        surgeryCost = 200;
    }
    if (surgeryType == "Surgery 3")
    {
        surgeryCost = 300;
    }
    {
        cout << "Enter the name of the surgery :";
        cin >> surgeryType;
        cout << "Enter the total price of surgery: ";
        cin >> surgeryCost;
        return surgeryCost;
    }

}


class Pharmacy
{
private:
    double medCost;
    string medName;

public:
    Pharmacy(double, string);
    double getMedCost();
    string getMedtype();
    void getPharmacyDisplay(double& cost2);
};

Pharmacy::Pharmacy(float mc = 0, string mn = " ")
{
    medCost = mc;
    medName = mn;
};

string Pharmacy::getMedtype()
{
    cout << "Enter the medicine type ";
    cout << "Medication 1" << endl;
    cout << "Medication 2" << endl;
    cout << "Medication 3" << endl;
    cin >> medName;
    return medName;
}

double Pharmacy::getMedCost()
{
    if (medName == "Medication 1")
    {
        medCost = 10;
    }
    if (medName == "Medication 2")
    {
        medCost = 20;
    }
    if (medName == "Medication 3")
    {
        medCost = 30;
    }
    {
        cout << "Enter the name of the medicine :";
        cin >> medName;
        cout << "Enter the total cost of medicine: ";
        cin >> medCost;
        return medCost;
    }
}

void PatientAccount::getPatientDisplay(double& totalCost)
{
    PatientAccount patient(getdailyprice(), getDays());
    totalCost = days * dailyprice;

    cout << "Days: " << days << endl;
    cout << "Daily Rate: " << dailyprice << endl;
    cout << "Total Cost: " << totalCost << endl;
}

void Surgery::getSurgeryDisplay(double& cost1)
{
    Surgery patient(getCost(), getSurgeryType());
    cost1 = surgeryCost;
    cout << "Surgery Type: " << surgeryType << endl;
    cout << "Surgery Cost: " << surgeryCost << endl;
    cout << "Total Cost: " << cost1 << endl;
}

void Pharmacy::getPharmacyDisplay(double& cost2)
{
    Pharmacy patient(getMedCost(), getMedtype());
    cost2 = medCost;
    cout << "Medication Name: " << medName << endl;
    cout << "Medication Cost: " << medCost << endl;
    cout << "Total Cost: " << cost2 << endl;
}

int main()
{
    double totalCost, cost1, cost2, cost3;

    PatientAccount patient;
    Surgery patient1;
    Pharmacy patient2;

    patient.getPatientDisplay(totalCost);
    patient1.getSurgeryDisplay(cost1);
    patient2.getPharmacyDisplay(cost2);

    cost3 = ((totalCost + cost1) + cost2);
    cout << "Total Cost Hospital: " << cost3 << endl;
    cin.clear();
    cin.sync();
    cin.get();

    return 0;
}