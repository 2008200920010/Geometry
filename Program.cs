﻿  // ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------
using System.ComponentModel;

DavomEt:
System.Console.WriteLine("Welcome to my project!");
System.Console.WriteLine("===========Main=========,===========Drawing=========");
 System.Console.Write("Choose: ");
string Select = Console.ReadLine();

if(Select == "1")
{
    System.Console.WriteLine("What do you need?");
    System.Console.WriteLine("The volume of the cube: ======= The perimeter of a rectangle: ======= The perimeter of the triangle");
    string Choose = Console.ReadLine();

    if(Choose == "1")
    {
      System.Console.WriteLine("Enter the sides of the cube:");
      System.Console.Write("The width of the cube: ");
      int eni = Convert.ToInt32(Console.ReadLine());
      System.Console.Write("The size of the cube: ");
      int buyi = Convert.ToInt32(Console.ReadLine());
      System.Console.Write("The height of the cube: ");
      int balandligi = Convert.ToInt32(Console.ReadLine());
      System.Console.WriteLine($"Volume of the cube: {eni * buyi * balandligi}");
    }
   else if(Choose == "2")
    {
        System.Console.WriteLine("Enter the sides of the rectangle: ");
        System.Console.Write("A: ");
        int A = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("B: ");
        int B = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"Primetr: {(A + B) * 2}");
    }
    if(Choose == "3")
    {
        System.Console.WriteLine("Enter the sides of the triangle:");
        System.Console.Write("A: ");
        int A = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("B: ");
        int B = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("C: ");
        int C = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"The perimeter of the triangle: {A + B + C}");
    }
}

if(Select == "2")
{
    System.Console.WriteLine("What do you want to draw?");
    System.Console.WriteLine("A picture of a rectangle:=========Square picture:========== A picture of a triangle:");
    System.Console.Write("Nima kerak: ");
    string What = Console.ReadLine();

    if(What == "1")
    {
        System.Console.WriteLine("**********\n*        *\n*        *\n*        *\n*        *\n**********\n");
    }
    if(What == "2")
    {
         Console.WriteLine("**********\n*        *\n*        *\n*        *\n**********\n");
    }
    if(What == "3")
    {
         Console.WriteLine("      *\n     *  *\n    *    *\n   *      *\n  *        *\n *          *\n**************");
    }
}
System.Console.WriteLine("Will you continue?");
string Tanlang = Console.ReadLine();
if(Tanlang == "Yes")
{
    goto DavomEt;
}
else if(Tanlang == "No")
{
    System.Console.WriteLine("We say goodbye to you!");
}