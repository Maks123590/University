// Lab1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>

#define M_PI  3.14159265358979323846

using namespace std;

int main()
{
	double x;
	double y;
	double z;

	cout << "x = ";
	cin >> x;

	cout << "y = ";
	cin >> y;

	cout << "z = ";
	cin >> z;

	const auto t = (2 * cos(x - M_PI/6.))/(0.5 + pow(sin(y), 2))*(1 + pow(z,2)/(3 - pow(z,2)/5));

	cout << "t = " << t;

	_getch();
    return 0;
}

