// Lab10.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <conio.h>

#include "Student.h"

using namespace std;



int main()
{

	Student student("Ivan", "Ivanovich", "Ivanov", "01.12.1987", "Moskva", "79271962525", "FMiIT", "FIiIT");

	student.show();

	_getch();
    return 0;
}

Student* get_students_by_faculty(Student students[])
{


	return nullptr;
}

