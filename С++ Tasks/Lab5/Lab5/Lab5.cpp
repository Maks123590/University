// Lab5.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include <iomanip>

using namespace std;

void show_matrix(int** matrix, const int n, const int m)
{
	for (auto i = 0; i < n; i++)
	{
		for (auto j = 0; j < m; j++)
		{
			cout << setw(6) <<matrix[i][j] << ' ';
		}

		cout << endl;
	}
}


int main()
{
	int n;
	int m;

	cout << "N = ";
	cin >> n;

	cout << "M = ";
	cin >> m;


	int** matrix = new int*[n];

	for (auto i = 0; i < n; i++)
	{
		matrix[i] = new int[m];
	}

	for (auto i = 0; i < n; i++)
	{
		for (auto j = 0; j < m; j++)
		{
			cin >> matrix[i][j];
		}
	}

	system("cls");

	show_matrix(matrix, n, m);

	auto counter = 0;

	for (auto i = 0; i < n; i++)
	{
		for (auto j = m-1; j >= m-i-1; j--)
		{
			if (matrix[i][j] >= 0)
			{
				counter++;
			}
		}
	}

	cout << "\namount = " << counter;

	//delete matrix[n];

	_getch();
    return 0;
}

