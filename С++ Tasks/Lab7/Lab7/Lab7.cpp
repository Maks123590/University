// Lab7.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include <string>

using namespace std;

struct customer
{
	string FIO;
	string address;
	int discount;
};


void show_custumer(const customer payer)
{
	cout << "________________________________________________" << endl;

	cout << "FIO: " << payer.FIO << endl;
	cout << "address: " << payer.address << endl;
	cout << "discount: " << payer.discount << endl;
	
}

int main()
{
	const auto n = 4;
	
	struct customer custumers[n];

	for (auto i = 0; i < n; i++)
	{
		string temp;

		cout << "input FIO for custumer[" << i << "] = ";
		getline(cin, custumers[i].FIO);

		cout << "input address for custumer[" << i << "] = ";
		getline(cin, custumers[i].address);

		cout << "input discount for custumer[" << i << "] = ";
		cin >> custumers[i].discount;

		cout << endl << endl;

		getline(cin, temp);
	}

	for (auto custumer : custumers)
	{
		if (custumer.discount == 5)
		{
			show_custumer(custumer);
		}
	}

	_getch();
    return 0;
}

