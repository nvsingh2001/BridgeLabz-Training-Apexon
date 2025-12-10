// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using OOP.Abstraction;
using OOP.Constructors;
using OOP.Destructors;
using OOP.Encapsulation;
using OOP.Inheritance;
using OOP.Polymorphism;
using OOP.Polymorphism.OperatorOverloading;
using System.Runtime.InteropServices.JavaScript;

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

// var dog = new OOP.Abstraction.Dog();
// dog.Sleep();
// dog.MakeSound();
//
// var dog1 = new OOP.Inheritance.Dog("Shiba Inu");
// Console.WriteLine(dog1.Name);
// dog1.Sleep();
// dog1.MakeSound();
//
// MultiLevel multiLevel = new MultiLevel();
//
// Multiple multiple = new Multiple();
//
// Console.WriteLine();
// Console.WriteLine(multiple.Name); 


// MethodOverLoading methodOverLoading = new MethodOverLoading();
//
// methodOverLoading.Add(2,2);
// methodOverLoading.Add(3.5f, 4.3f);
// methodOverLoading.Add("Hello ","World");
//
// MethodOverRiding.GetB().show();
//
// String str1 = new String("ABC");
// String str2 = new String("ABC");
// string str3 = "ABC";
//
// Console.WriteLine(str1 == str2);
//
// Console.WriteLine(str1 == str3);

// InheritanceOverloading inheritanceOverloading = new InheritanceOverloading();
// inheritanceOverloading.add(5,5);
// inheritanceOverloading.add(4.5f, 6.7f);
// inheritanceOverloading.add("Naman ", "Vinay Singh");
//
// Complex complex1 = new Complex(2, 7);
// Complex complex2 = new Complex(7, 14);
//
// Complex result = complex1 + complex2;
// Console.WriteLine(result);



SealedClass sealedClass = new SealedClass();
sealedClass.show();