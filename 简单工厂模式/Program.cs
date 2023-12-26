// See https://aka.ms/new-console-template for more information

using Simple_Factory_Design_Pattern.Services;

Console.WriteLine("请输入一个数字：");
var d1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("请输入一个数字：");
var d2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("请输入操作符：");
var oper = Console.ReadLine();
var calculator = Factory.GetCalculator(oper);
var d= calculator.GetResult(d1,d2);
Console.WriteLine(d);