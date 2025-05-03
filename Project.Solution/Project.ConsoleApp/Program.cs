// Swap Values of Variables Without Creating a Temporary Variable.

// 1) Swap integers
Console.WriteLine("-----Swap integers-----");
// 1) a. With 2 variables.
Console.WriteLine("-----With 2 variables-----");
int a = 19;
int b = 22;
Console.WriteLine($"Before swap: a = {a}, b = {b}");

a += b; // 111

b = a - b; // 19
a = a - b;  // 22
Console.WriteLine($"After swap: a = {a}, b = {b}");

// 1) b. With 3 variables.
Console.WriteLine("-----With 3 variables-----");
int intA = 19;
int intB = 22;
int intC = 70;
Console.WriteLine($"Before swap: intA = {intA}, intB = {intB}, intC: {intC}");

intA += intB + intC; // 111

intB = intA - intB - intC; // 19
intC = intA - intB - intC; // 22
intA = intA - intB - intC; // 70
Console.WriteLine($"After swap: intA = {intA}, intB = {intB}, intC: {intC}");

// 2) Swap strings
Console.WriteLine("-----Swap strings-----");
string str1 = "Poland";
string str2 = "Sweden";
Console.WriteLine($"Before swap st1: {str1}, str2: {str2}");

str1 += str2; // PolandSweden

str2 = str1[..str1.IndexOf(str2)]; // Sweden
str1 = str1[str2.Length..]; // Poland
Console.WriteLine($"After swap st1: {str1}, str2: {str2}");

Console.ReadKey();