#include "stdafx.h"
#include "Student.h"
#include <string>

string Student::get_address() const
{
	return address_;
}
void Student::set_address(const string value)
{
	address_ = value;
}

string Student::get_phone() const
{
	return phone_;
}
void Student::set_phone(const string value)
{
	phone_ = value;
}

string Student::get_faculty() const
{
	return faculty_;
}
void Student::set_faculty(const string value)
{
	faculty_ = value;
}

string Student::get_faculty_year() const
{
	return faculty_year_;
}
void Student::set_faculty_year(const string value)
{
	faculty_year_ = value;
}

Student::Student(const string first_name, const string last_name, const string middle_name, const string born_date,
	const string address, const string phone, const string faculty, const string faculty_year)
{
	first_name_ = first_name;
	middle_name_ = middle_name;
	last_name_ = last_name;

	born_date_ = born_date;

	set_address(address);
	set_phone(phone);
	set_faculty(faculty);
	set_faculty_year(faculty_year);
}

void Student::show() const
{
	cout << endl;

	cout << first_name_ << " | " << middle_name_ << " | " << last_name_ << " | "
		<< born_date_ << " | " << address_ << " | " << phone_ << " | "
		<< faculty_ << " | " << faculty_year_ << endl;

	cout << endl;
}
