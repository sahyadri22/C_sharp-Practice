using System;
namespace Program
{
 class Car
 {
  public string color;
  public string model;
  public int year;
  
  public Car(string colorname, string modelname, int yearname)
  {
   color = colorname;
   model=modelname;
   year= yearname;
   }
   }
    
   class Data {
   static void Main(string[]args)
   {
    Car Swift= new Car("white", "desire",2003);
    Car Audi = new Car("red", "unique",2006);
    Console.WriteLine(Swift.year);
    Console.WriteLine(Audi.model);
    
    }
    }
    }
    