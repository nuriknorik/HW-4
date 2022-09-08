/*
Задание 1
*/


/*class Money
 
{
    int manat;

    public Money(int rub, int manat)
    {
        
        this.manat = manat;
    }
 
    public static Money operator *(Money money, double num)
    {
        var Val = (money.manat*100 + money.manat)*num;
        return new Money((int)Val/100, (int)Val%100);
    }
 
    public override string ToString()
    {
        return string.Format("{}azn {}qepik", manat);
    }
}
 
class  Product
{
    readonly string name;
    Money price;
    public  Product(string name, Money price)
    {
        name = name;
        this.price = price;
    }
 
    public void DecPrice(int mon)
    {
        this.price = price*((100 - mon)/100);
    }
 
    public override string ToString()
    {
        return string.Format("Name: {0}; Price: {1}", name, price);
    }
}*/



/*Задание 2*/
/*using System;
 
namespace Program
{
    class Program
    {
        public class Instrument
        {
            public string type;
            public string name;
            
 
            public Instrument(string type, string name)
            {
                type = type;
                name = name;
                
            }
 
            public virtual string Print()
            {
                return "Instrument Type" + this.type + "\n" + "Surname:" + this.name;
            }
        }
 
        public class  Sound  : Instrument
        {
 
            public  Sound(string type, string name) : base("Скрипка", name)
            {
                type = type;
                name = name;

 
            }
            public override string Print()
            {
                return "Instrument Type:" + this.type + "\n" + "Surname:" + this.name;
            }
        }
        
 
        public class  Sound2 : Instrument
        {
            public  Sound2(string type, string name) : base("Укулеле", name)
            {
                type = type;
                name = name;
 
            }
            public override string Print()
            {
                return "Instrument Type:" + this.type + "\n" + "Surname:" + this.name;
            }
        }
 
        public static void Main(string[] args)
        {
            Instrument[] instru = new Instrument[]
            {
                new  Sound ("Струнный ", "Скрипкка "),
                new  Sound2("Струнный","Укулеле"),
            };
            
            for (int i = 0; i < instru.Length; i++)
            {
                Console.WriteLine(instru[i].Print());
            }
            
        }
    }
}*/

 /*Задание 3*/
 /*namespace Worker
{
    abstract class Worker 
    {
        public  abstract  string Routine();
         
        public abstract string Person();
       
    }
    class Manager : Worker 
    {
        public override string Routine()
        {
            return String.Format("Create new project");
        }
        public override string Person()
        {
            return String.Format("Works");
        }
 
    }
    class President : Worker
    {
        public override string Routine()
        {
            return String.Format("President");
        }
        public override string Person()
        {
            return String.Format(" Works");
        }
 
    }
    class Security: Worker
    {
        public override string Routine()
        {
            return String.Format("Watching");
        }
        public override string Person()
        {
            return String.Format("Works");
        }
 
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> list = new List<Worker>();
            foreach (var a in list)
            {
                Console.WriteLine( a.Routine()+"\n" +a.Person());
               
            }
            string name = Console.ReadLine();
            foreach (var b in list){
                Console.WriteLine( b.Routine()+ "\n"+ b.Person());
               
                }
            Console.ReadLine();
        }
    }
}*/