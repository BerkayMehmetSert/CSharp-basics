﻿var a = 5;
var b = 10;
var add = a + b;
var subtraction = a - b;
var multiplication = a * b;
var division = a / b;
var modulus = a % b;
var increment = a++;
var decrement = b--;
var equal = a == b; 
var notEqual = a != b;
var greaterThan = a > b;
var lessThan = a < b;
var greaterThanOrEqual = a >= b;
var lessThanOrEqual = a <= b;
var ternary = a > b ? "a is greater than b" : "a is not greater than b";

var mathPow = Math.Pow(a, b);
var mathSqrt = Math.Sqrt(a);
var mathAbs = Math.Abs(a);
var mathRound = Math.Round(4.5);
var mathCeiling = Math.Ceiling(4.5);
var mathFloor = Math.Floor(4.5);
var mathMax = Math.Max(a, b);
var mathMin = Math.Min(a, b);

Console.WriteLine($"a: {a}");
Console.WriteLine($"b: {b}");
Console.WriteLine($"Add: {add}");
Console.WriteLine($"Subtraction: {subtraction}");
Console.WriteLine($"Multiplication: {multiplication}");
Console.WriteLine($"Division: {division}");
Console.WriteLine($"Modulus: {modulus}");
Console.WriteLine($"Increment: {increment}");
Console.WriteLine($"Decrement: {decrement}");
Console.WriteLine($"Equal: {equal}");
Console.WriteLine($"Not Equal: {notEqual}");
Console.WriteLine($"Greater Than: {greaterThan}");
Console.WriteLine($"Less Than: {lessThan}");
Console.WriteLine($"Greater Than Or Equal: {greaterThanOrEqual}");
Console.WriteLine($"Less Than Or Equal: {lessThanOrEqual}");
Console.WriteLine($"Ternary: {ternary}");
Console.WriteLine($"a+=b: {a+=b}");
Console.WriteLine($"a-=b: {a-=b}");
Console.WriteLine($"a*=b: {a*=b}");
Console.WriteLine($"a/=b: {a/=b}");
Console.WriteLine($"a%=b: {a%=b}");
Console.WriteLine();
Console.WriteLine($"Math.Pow(a, b): {mathPow}");
Console.WriteLine($"Math.Sqrt(a): {mathSqrt}");
Console.WriteLine($"Math.Abs(a): {mathAbs}");
Console.WriteLine($"Math.Round(4.5): {mathRound}");
Console.WriteLine($"Math.Ceiling(4.5): {mathCeiling}");
Console.WriteLine($"Math.Floor(4.5): {mathFloor}");
Console.WriteLine($"Math.Max(a, b): {mathMax}");
Console.WriteLine($"Math.Min(a, b): {mathMin}");