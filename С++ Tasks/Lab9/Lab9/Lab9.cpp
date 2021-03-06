// Lab9.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include <fstream>

using namespace std;

const int N = 15;

struct product
{
	char name[30];
	int count;
	double price;
};

void structs_to_file(product products[], const int poducts_count, const string path);
void structs_from_file(product products[], const int poducts_count, const string path);
void generate_data(product products[]);
void show_in_console(product products[], const int poducts_count);

int main()
{
	const string file_path = "source.txt";
	
	int k;

	product products[N];

	cout << "0. generate data and write to file\n";
	cout << "1. read data from file" << endl;

	cin >> k;

	if (k == 0)
	{
		generate_data(products);

		structs_to_file(products, N, file_path);
	}
	else
	{
		structs_from_file(products, N, file_path);
	}

	show_in_console(products, N);

	_getch();
    return 0;
}


void show_in_console(product products[], const int poducts_count)
{
	cout.setf(ios::fixed);
	cout.precision(2);

	for (auto i = 0; i < poducts_count; i++)
	{

		cout << "__________________________\n" << endl;
		cout << "name: " << products[i].name << endl
			 << "count: " << products[i].count << endl
			 << "price: " << products[i].price << endl;
			 
	}
}

void structs_to_file(product products[], const int poducts_count, const string path)
{
	ofstream to_file(path);
	
	to_file.setf(ios::fixed);
	to_file.precision(2);

		if (to_file)
		{
			for (auto i = 0; i < poducts_count; i++)
			{
				to_file << products[i].name << " " << products[i].count << " " << products[i].price << "\n";
			}
		}
}

void structs_from_file(product products[], const int poducts_count, const string path)
{
	ifstream from_file(path, ios::binary | ios::in);
	
	if (from_file)
	{
		for (auto i = 0; i < poducts_count; i++)
		{
			from_file >> products[i].name >> products[i].count >> products[i].price;
		}
	}
}

void generate_data(product products[])
{
	products[0] = { "Bread", 10, 20 };
	products[1] = { "Beer", 20, 55.5 };
	products[2] = { "Sausage", 37, 85.4 };
	products[3] = { "Stew", 42, 102.5 };
	products[4] = { "Bacon", 4, 67.3 };
	products[5] = { "Jam", 15, 45.7 };
	products[6] = { "Cucumber", 11, 17.5 };
	products[7] = { "Pepper", 20, 35.9 };
	products[8] = { "Potatoes", 12, 12.6 };
	products[9] = { "Vodka", 4, 115.8 };
	products[10] = { "BMW", 4, 2200000 };
	products[11] = { "apartment", 4, 4000000 };
	products[12] = { "garage", 4, 1000000 };
	products[13] = { "helicopter", 4, 27000000 };
	products[14] = { "House", 4, 7000000 };
}
