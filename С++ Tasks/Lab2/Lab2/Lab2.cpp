// Lab2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>

using namespace std;

void part1()
{
	double x;
	double y;
	double s;

	cout << "x = ";
	cin >> x;

	cout << "y = ";
	cin >> y;

	if (x * y > 0)
	{
		s = pow((x + y), 2) - pow(abs(x), 1 / 3.);
	}
	else if (x * y < 0)
	{
		s = pow((x + y), 2) - sin(x);
	}
	else
	{
		s = pow((x + y), 2) - pow(y, 3);
	}

	cout << "s = " << s;
}

void part2()
{
	double a;
	double b;
	double c;

	cout << "a = ";
	cin >> a;

	cout << "b = ";
	cin >> b;

	cout << "c = ";
	cin >> c;

	cout << "M = " << static_cast<int>((a + pow(b, 2)) / c) % 3;
}


int main()
{
	auto n = 0;

	cout << "part 1: 1\npart 2: 2\n";
	cin >> n;

	n == 1 ? part1() : part2();

	_getch();
    return 0;
}