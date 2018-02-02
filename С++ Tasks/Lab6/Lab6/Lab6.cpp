// Lab6.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include <string>
#include <windows.h>

using namespace std;

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	string str;

	getline(cin, str);

	int wordCounter = 0;
	int charCounter = 0;

	for (auto i = 0; i < str.length(); i++)
	{
		if (str[i] != ' ')
		{
			charCounter++;
		}
		else
		{
			if (charCounter == 5)
			{
				wordCounter++;
			}

			charCounter = 0;
		}
	}

	cout << "words count = " << wordCounter;

	_getch();
    return 0;
}

