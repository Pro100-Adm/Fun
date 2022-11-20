// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

double AskUser()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
    double op = double.Parse(Ask);
    return op;
}
catch (Exception)
{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}
else{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}

string AskUser2()
{
Console.Write("Введите операцию: ");
string? Ask = Console.ReadLine();
if (Ask != null){
if (Ask == "+" || Ask == "/" || Ask == "*" || Ask == "-"){
return Ask;
}else{
    Console.WriteLine("Введите верный операнд!");
    return AskUser2();
}
}
else{
    Console.WriteLine("Введите верный операнд!");
    return AskUser2();
}
}

double CalcFunc(string operation, double op1, double op2){
    double result = 0;
    if(operation == "+") {
        result=op1+op2;
    }
    else if(operation == "-") {
        result=op1-op2;
    }
    else if(operation == "*") {
        result=op1*op2;
    }
    else if(operation == "/") {
        result=op1/op2;
    }
    Console.WriteLine($"Результат: {result}");
    return result;
}

CalcFunc(AskUser2(), AskUser(),AskUser());