// Lab2_addition.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>

using namespace std;

int main()
{
	int n;
	int a;
	int b;

	auto count = 0;

	cin >> n >> a >> b;

	for (auto i = 1; i <= a; i++)
	{
		for (auto j = 1; j <= b; j++)
		{
			if (i + j == n)
			{
				count++;
			}
		}
	}

	cout << count;

	_getch();
    return 0;
}

