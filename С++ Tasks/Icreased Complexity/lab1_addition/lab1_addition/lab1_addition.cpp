// lab1_addition.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"

#include <conio.h>
#include <string>
#include <iostream>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;

struct elem
{
	int A;
	int B;
};

bool compare_a (const elem i, const elem j) {
	return (i.A < j.A);
}

int main()
{
	const auto n = 5;

	vector<elem> mebius_list;

	for (auto i = 0; i < n; i++)
	{
		int A;
		int B;

		cout << "elem[" << i << "]: ";

		cout << "A: ";
		cin >> A;

		cout << "B: ";
		cin >> B;

		cout << endl;

		mebius_list.push_back({ A, B });
	}

	sort(mebius_list.begin(), mebius_list.end(), compare_a);

	auto b_sorted = true;

	for (int i = 1; i < mebius_list.size(); i++)
	{
		if (mebius_list.at(i - 1).B > mebius_list.at(i).B)
		{
			b_sorted = false;
			break;
		}
	}

	if ((mebius_list.back().A <= mebius_list.front().B) && b_sorted)
	{
		cout << "possible:\n";

		for (auto elem : mebius_list)
		{
			cout << "A: " << elem.A << endl;
		}

		for (auto elem : mebius_list)
		{
			cout << "B: " << elem.B << endl;
		}
	}
	else
	{
		cout << "not possible";
	}
	_getch();
    return 0;
}

//A 0 1 2 3 4
//B 5 6 7 8 9
//out : possible