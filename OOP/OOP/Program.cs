// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using OOP.Abstraction;
using OOP.Constructors;
using OOP.Destructors;
using OOP.Encapsulation;
using OOP.Inheritance;

// DefaultConstructor dc = new DefaultConstructor();
//
// Console.WriteLine(dc.x);
// Console.WriteLine(dc.str);
// Console.WriteLine();
//
// DefaultConstructorUserDefined dcud = new DefaultConstructorUserDefined();  
//
// Console.WriteLine(dcud.x);
// Console.WriteLine(dcud.str);
// Console.WriteLine();
//
//
// ParameterizedConstructor pc = new ParameterizedConstructor(20, "Ankit"); 
// Console.WriteLine(pc.x);
// Console.WriteLine(pc.str);
// Console.WriteLine();
//
// CopyConstructor ccObj1 = new CopyConstructor(30, "Neha");
// Console.WriteLine("CopyConstructor Object 1");
// Console.WriteLine(ccObj1.x);
// Console.WriteLine(ccObj1.str);
// Console.WriteLine();
//
// CopyConstructor ccObj2 = new CopyConstructor(ccObj1);
// Console.WriteLine("CopyConstructor Object 2");
// Console.WriteLine(ccObj1.x);
// Console.WriteLine(ccObj1.str);
// Console.WriteLine();
//
// StaticConstructor sc = new StaticConstructor(50, "Non Static Constructor!");
// Console.WriteLine(StaticConstructor.xStatic);
// Console.WriteLine(StaticConstructor.strStatic);
// Console.WriteLine(sc.x);
// Console.WriteLine(sc.str);
// Console.WriteLine();
//
// PrivateConstructor.getInstance().display();
// Console.WriteLine();
//
// DestructorDemo demo = new DestructorDemo();
// demo.x = 100;
// Console.WriteLine(demo.x);
//
// demo = null;
// GC.Collect();
// GC.WaitForPendingFinalizers();
//
// DestructorDemo resource = null;
// try
// {
//     resource = new DestructorDemo();
//     Console.WriteLine("Using Resources");
// }
// finally
// {
//     if (resource != null)
//     {
//         Console.WriteLine("Calling Dispose Method to Destroy Resources");
//         resource.Dispose();
//     }
// }
// //Trying to Call the Dispose Method again
// Console.WriteLine();
// Console.WriteLine("Trying to Call the Dispose Method Again To Destroy Resources");
// resource.Dispose();
// Console.ReadKey();

// var account = new BankAccount(50);
// account.Deposit(100);
// account.Withdraw(1000);
// account.Withdraw(50);

// Circle circle = new Circle(5);
// Console.WriteLine(circle.Area() + '\n');

var dog = new OOP.Abstraction.Dog();
dog.Sleep();
dog.MakeSound();

var dog1 = new OOP.Inheritance.Dog("Shiba Inu");
Console.WriteLine(dog1.Name);
dog1.Sleep();
dog1.MakeSound();

MultiLevel multiLevel = new MultiLevel();

Multiple multiple = new Multiple();

Console.WriteLine();
Console.WriteLine(multiple.Name);