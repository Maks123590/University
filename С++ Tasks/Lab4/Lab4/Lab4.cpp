// Lab4.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include <deque>

using namespace std;

int main()
{
	const int k = 10;

	int array[k];

	for (auto i = 0; i < k; i++)
	{
		cout << "A[" << i << "]= ";
		cin >> array[i];
	}


	deque<int> temp_list;

	for (auto el : array)
	{
		if(el < 0)
		{
			temp_list.push_back(el);
		}
	}

	for (auto el : array)
	{
		if (el >= 0)
		{
			temp_list.push_back(el);
		}
	}

	for (auto i = 0; i < k; i++)
	{
		array[i] = temp_list[i];
	}

	cout << endl;

	for (auto element : array)
	{
		cout << element << ' ';
	}

	_getch();
    return 0;
}

