// See https://aka.ms/new-console-template for more information
using Assign1;
using System.Runtime.Serialization.Formatters;

Console.WriteLine("Hello, World!");
Console.WriteLine("enter the value to run diffrent problems  for ");
int n = Convert.ToInt32(Console.ReadLine());
    switch (n) {
    //Class1 c = new Class1();
    case 0:
        Class2.login();
        break;
    case 1:
        Class3.calculator();
        break;
        case 2:
Class4.ticket();
        break;
        case 3:
Class5.rockpaper();
        break;
        case 4:
Class6.book();
        break;
        case 5:
Class7.Tempconverter();
        break;
        case 6:
Class8.grade();
        break;
    case 7:

        string[] parameter = { "particulate matter", "PM2.5", "Ozone(O3)", "Sulphur dioxide(SO2)", "nitrogen dioxide", "carbon monoxide", "lead" };
        double []parameterValue = new double[parameter.Length];
        for (int i = 0;i< parameter.Length; i++)
        {
            Console.WriteLine($"enter the value of {parameter[i]}\n");
            parameterValue[i] = Convert.ToDouble(parameter[i]);
        }
Class9.AirIndex(parameterValue);
        break;
        case 8:

Class1.light();
        break;

}