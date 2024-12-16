// See https://aka.ms/new-console-template for more information

// 1️ C# Primitive Types
//Task 1
using System;

int Num1 = 5;
double Num2 = 22.5;
string FirstName = "Mohammad";
bool isTrue = true;
Console.WriteLine(Num1+", "+Num2+", "+FirstName+ ", "+isTrue);
Console.WriteLine("------------------------------");

// Task 2
int number = 5; 
double result = Convert.ToDouble(number);
Console.WriteLine(number.GetType());
Console.WriteLine(result.GetType());
//only the data type of result is set to double; using convert does not change the variable data type it only changes to the new type for the new variable we want to store it in.
Console.WriteLine("------------------------------");


//Bonus!
// the char data type can only be used for one character {digit,letter or symbol} inside single 


// 2 C# Variables
//Task 1
string studentName = "Mohammad";
double grade_point_average = 99.9;
string favorite_subject = "Math";




//Task 2
double width = 5.5; 
double height = 3.2;
double Area = width * height;
Console.WriteLine("The area of the rectangle is "+ Area);
Console.WriteLine("------------------------------");

//challenge 1 

Console.WriteLine("Enter hour: ");
string lunch_hour = Console.ReadLine();
int time_for_lunch = Convert.ToInt32(lunch_hour);
if(time_for_lunch>= 11 && time_for_lunch <=14 )
{
    Console.WriteLine("Lunch Time");
}
else
{
    Console.WriteLine("Not Yet");
}