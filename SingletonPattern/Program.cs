using System;

namespace SingletonPattern
{
    public class Singleton
    {
        private Singleton() 
        {

        }

        private static Singleton instance;
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();

            }
            return instance;
        }

        public string GetDetails()
        {
            return "India";
        }

    }

    class program
    {
        static void Main(string[] args)
        {
            Singleton sg1 = Singleton.GetInstance();
            string x = sg1.GetDetails();
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }

 }
