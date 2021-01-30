using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("American Express");
            isimler.Add("VISA");
            isimler.Add("MasterCard");
            isimler.Add("TROY");

            Console.WriteLine(isimler.Count() + " elemanlı isimler sınıfı oluşturuldu!");
            Console.WriteLine("---------------------------");
            
            
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("3", "American Express");
            myDictionary.Add("4", "VISA");
            myDictionary.Add("5", "MasterCard"); 
            myDictionary.Add("9", "TROY");
            Console.WriteLine(myDictionary.Count() + " elemanlı myDictionary sınıfı oluşturuldu!");
            Console.WriteLine("---------------------------");
            
        }
    }
}
