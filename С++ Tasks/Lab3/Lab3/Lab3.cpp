// Lab3.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include <iomanip>

using namespace std;

void part1()
{
	const auto n = 20;

	cout.fill('|');
	cout.precision(3);
	cout << setiosflags(ios::fixed) << setw(4);;

	for (auto x = 0.1; x <= 1.2; x += 0.1)
	{
		cout << x << " || ";

		auto y = 0.;

		for (auto i = 1; i <= n; i++)
		{
			y += pow(x, i - 1) / (2 * i + 1);

			
		}

		cout << y << " | ";

		cout << endl;
	}
}

void part2()
{
	int n;

	cout << "n = ";

	cin >> n;

	auto count = n == 0? 1 : 0;

	while(n > 0)
	{
		count++;
		n = n / 10;
	}

	cout << "k = " << count;
}

int main()
{
	int n;

	cout << "part1: 1\npart2: 2\n";
	cin >> n;

	n == 1? part1() : part2();

	_getch();
    return 0;
}