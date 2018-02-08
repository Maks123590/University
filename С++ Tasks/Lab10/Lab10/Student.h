#pragma once
#include <iostream>

using namespace std;

class Student
{
private:
	string first_name_;
	string last_name_;
	string middle_name_;
	string born_date_;
	string address_;
	string phone_;
	string faculty_;
	string faculty_year_;
public:
		string get_address() const;
		void set_address(const string value);

		string get_phone() const;
		void set_phone(const string value);
		
		string get_faculty() const;
		void set_faculty(const string value);

		string get_faculty_year() const;
		void set_faculty_year(const string value);

		Student(const string first_name, const string last_name, const string middle_name, const string born_date,
			const string address, const string phone, const string faculty, const string faculty_year);

		void show() const;
};
