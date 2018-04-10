using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //11


namespace ConsoleApp4_IKMtest
{
    //11 - 1/2
    static class StuffDoer
    {
        public static void Main11(string[] args)
        {
            int intOne = 1;
            Int32 intTwo = 2;
            String stringThree = "3";
            String stringFour = "4";
            StuffDoer.doStuff(ref intOne, intTwo, ref stringThree, stringFour);
            WriteLine($"{intOne}, {intTwo}, {stringThree}, {stringFour}");
        }

        private static void doStuff(ref int intOne, Int32 intTwo, ref String stringThree, String stringFour)
        {
            intOne = 100;
            intTwo = 200;
            stringThree = "300";
            stringFour = "400";
        }
    }



    //10 - part 1/2
    public interface A { }
    public interface B { }
    public class C : A { }
    public class D : B { }
    public class E : C { }



    //8 https://codeblog.jonskeet.uk/2015/01/30/clean-event-handlers-invocation-with-c-6/


    class Program
    {

        //1
        class Obj
        {
            private int num = 1;
        }

        //7
        /*
         * tried applying this: https://www.tutorialspoint.com/csharp/csharp_queue.htm
         * wouldn't compile
         * 
        Queue q = new Queue();
        q.Enqueue('A');
        q.Enqueue('M');
        q.Enqueue('G');
        q.Enqueue('W');
         
        WriteLine("Current queue: ");
        foreach (char c in q) Console.Write(c + " ");
         
        WriteLine();
        q.Enqueue('V');
        q.Enqueue('H');
        WriteLine("Current queue: ");
        foreach (char c in q) Console.Write(c + " ");
         
        WriteLine();
        WriteLine("Removing some values ");
        char ch = (char)q.Dequeue();
        WriteLine("The removed value: {0}", ch);
        ch = (char) q.Dequeue();
        WriteLine("The removed value: {0}", ch);
         
        ReadKey();



        /*
         //6
        public virtual double Getd();
        public abstract Test
        {
            public abstract double GetResult();
        }
        */


        //14
        private readonly int topSpeed = 333;
        //If it's private and readonly, the benefit is that you can't inadvertently change it from another part of that class after it is initialized. The readonly modifier ensures the field can only be given a value during its initialization or in its class constructor.

        Program()
        {
            topSpeed = 234;
        }

        void Foo()
        {
            //topSpeed = 234;
        }



        //15 - 2/2
        private static void writeOutput(object o)
        {
            if (o == null)
            {
                WriteLine("null");
            }
            else
            {
                WriteLine(o.ToString());
            }
        }

        //19
        static class ClassTester
        {
            public static void Main19()
            {
                new Clerk("John");
                ReadLine();
            }
        }

        public class Employee
        {
            public Employee(String name)
            {
                WriteLine($"in employee constructor, {name}");
            }
        }

        public class Clerk : Employee
        {
            public Clerk(String name) : base(name)
            {
                WriteLine($"In clerk constructor, {name}");
            }
        }

        //21
        public class City
        {
            public string name { get; set; }
            public Country country { get; set; }
        }

        public class Country
        {
            public string name { get; set; }
            public string abbrev { get; set; }
        }


        //21 again -- as 27 again ... 
        public static class MyTest
        {
            public static void Main21Again()
            {
                try
                {
                    DerivedClass B = new DerivedClass();
                    B.Test();
                    BaseClass A = (BaseClass) B;
                    A.Test();
                }
                catch (Exception ex)
                {
                    WriteLine(ex.GetType().ToString());
                }
            }
        }

        public class BaseClass
        {
            public virtual void Test()
            {
                WriteLine("from base");
            }
        }

        public class DerivedClass : BaseClass
        {
            public override void Test()
            {
                WriteLine("From DerivedClass");
            }
        }


        //22
        public static Func<int, int> X(Func<int, int, int> f)
        {
            WriteLine(f.Method.Name);
            return a => f(a, 4);
        }

        public static void Main22()
        {
            Func<int, int> f = X(Sum);
            var res = f(5);
            WriteLine(res);
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }


        //25
        public interface IMyInterface
        {
            string Name { get;  }
        }

        public class MyTestClass : IMyInterface
        {
            private string name;
//            goes here.
//            a -- non public ...no..
//            protected string Name
//            {
//                get { return name; }
//            }
//
//            b -- yes
//            public string Name
//            {
//                get { return name;  }
//                set { name = value;  }
//            }
//            c -- override ... no
//            public override string Name
//            {
//                get { return name; }
//            }
//
//                d -- no
//            public string Name
//            {
//                private get { return name;  }
//                set { name = value; }
//            }

            //e == yes
            public string Name => $"{name}";
        }

        //27
        public class MyTestClass28
        {
            static void Main28()
            {
                try
                {
                    //TestMethod();
                }
                catch (Exception e)
                {
                    WriteLine(e.Message);
                }
                finally
                {
                    WriteLine("in finally block");
                }
            }

            public void TestMethod()
            {
                throw new Exception("Exception in TestMethod");
            }
        }

        //28
        //a) conversion exception? no
        //b) instances of this class are stored on the stack because it only contains value types.
        //e) heap? 

        public struct Rectangle
        //public class Rectangle
        {
            public double x { get; set; }
            public float y { get; set; }

            public double Area
            {
                get { return x * y; }
            }
        }

        //37
        //which of the following correctly describe how to decorate ... to max 10 chars?
        [AttributeUsage((AttributeTargets.Property))]
        public class CheckAttribute : Attribute
        {
            public int MaxLength { get; set; }
        }

        public class Employee37
        {
            //[Check(MaxLength => 10)]
            public string FirstName { get; set; }
        }
        public class eb
        {
            //[Check(MaxLength == 10)]
            public string Firstname { get; set; }
        }
        public class ec
        {
            [Check(MaxLength = 10)]
            public string Firstname { get; set; }
        }

        public class ed
        {
            //[Check(10)]
            public string FirstName { get; set; }
        }
        public class ee
        {
            [CheckAttribute(MaxLength = 10)]
            public string FirstName { get; set; }
        }

        static void Main(string[] args)
        {

            //37 
            //decorate property

            //36
            //registry 

            //32

            //e) delegates are ideal for callback functions

            //30 
            String s = "NY";
            s.ToUpper();
            s.ToLowerInvariant();
            s.Clone();
            s += "er";
            WriteLine(s);
            ReadKey();
            s.GetType(); //ctrl + e, h (inheritance hierarchy resharper)

            //28
            Rectangle r = new Rectangle();
            WriteLine(r.Area);
            ReadKey();

            //25
            //which will compile successfully?

            //24 generics C#

            //23 expando object

            //22
            Main22();
            ReadKey();

            //21 again 404
            MyTest.Main21Again();
            ReadKey();

            //21
            City city = new City();
            city.name = "Los Angeles";

            string labelCity = city.name;
            //string labelCountry = city.country.abbrev;

            //a) 
            //string labelCountry = null; 
            //if(!city.country.abbrev.HasValue)
            //b)
            string labelCountryB = null;
            if (city != null)
            {
                if (city.country == null)
                {
                    labelCountryB = "US";
                }
            }
            //ReadKey();
            //c
            string labelCountryC = city.country != null ? (city.country.abbrev != null ? city.country.abbrev : "US") : "US";

            //d
            //exception
            //string labelCountryD = city.country.abbrev != null ? city.country.abbrev : "US";

            //e

            string labelCountryE = city?.country?.abbrev ?? "US"; 

            WriteLine($"Name: {labelCity}");
            WriteLine($"Country: {labelCountryB} {labelCountryC} {labelCountryE}");
            ReadLine();

            //e ??  double question mark is null-coalescing

            //20
            int[] values = new int[] {5, 4, 3, 4, 2, 5, 9, 4, 2, 4};
            var results = (from c in values orderby c select c * c).Distinct().Take(5);
            foreach (var resultt in results)
            {
                WriteLine(resultt);
            }            
            WriteLine("--");
            //a
            results = values.Distinct().OrderBy(f => f * f).Take(5).Select(c => c * c);
            foreach (var resultt in results)
            {
                WriteLine(resultt);
            }
            WriteLine("--");
            //b
            IEnumerable<int> resultss = values.Select(c => c * c).Take(5).Distinct().OrderBy(f => f);
            foreach (var resultt in resultss)
            {
                WriteLine(resultt);
            }
            WriteLine("--");
            //c
            IEnumerable<int> resultc = values.Select(c => c * c).OrderBy(f => f).Distinct().Take(5);
            foreach (var resultt in resultc)
            {
                WriteLine(resultt);
            }
            WriteLine("--");
            //d
            IEnumerable<int> resultd = values.Distinct().OrderBy(f => f).Take(5).Select(c => c * c);
            foreach (var resultt in resultd)
            {
                WriteLine(resultt);
            }
            WriteLine("--");
            //cannot implicitly convert type...
            //e
//            int[] resulte = values.Select(c => c * c).Take(5).OrderBy(f => f);
//            foreach (var resultt in resulte)
//            {
//                WriteLine(resultt);
//            }
//            WriteLine("--");
            ReadKey();


            //19
            ClassTester.Main19();
            ReadKey();

            //16 -- skipped
            //EventLogEntry.WriteEvent -- nope
            //EventLog.WriteEntry("asdf");
            //EventInstance.WriteEntry();
            //EventLog.WriteEntry();



            //15 - 1/2
            bool? a = null, b = null;
            writeOutput(a & b);
            writeOutput(a | b);
            a = true;
            writeOutput(a & b);
            writeOutput(a | b);
            b = false;
            writeOutput(a & b);
            writeOutput(a | b);
            ReadLine();




            //13
            int intValue = 250;
            byte byteValue = (byte) intValue;
            WriteLine(byteValue);

            //12

            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries

            // The Three Parts of a LINQ Query:
            //  1. Data source.
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            // 3. Query execution.
            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }


            // https://stackoverflow.com/questions/16012380/merge-2-arrays-using-linq
            //join two arrays
            int[] num1 = new int[] { 1, 55, 89, 43, 67, -3 };
            int[] num2 = new int[] { 11, 35, 79, 23, 7, -10 };

            //var result = from n1 in num1
              //  from n2 in num2
                //select result;

            var res = num1.Concat(num2).ToArray();
            var result = num1.Union(num2).ToArray();
            //var ress = num1.GroupJoin(num2).ToArray();



            int[] array1 = {1, 2, 3, 4};
            int[] array2 = {3, 5, 5, 8};
            WriteLine(array1);
            var resss = array1.Intersect(array2).ToArray();

            //var res2 = array1.OrderBy()  --- no
            //var res3 = array1.Group??? --- incrorrect usage
            //var res4 = array1.CrossJoin 


            foreach (var item in resss)
            {
                WriteLine(item.ToString());
            }


            //WriteLine(resss);

            ReadKey();


            //11 2/2
            StuffDoer.Main11(new string[6]);
            ReadKey();


            //10 - part 2

            //B b = new B();
            //A a = new C();
            //E e = new A();
            //C c = new E();
            A aa = new E();

            //7
            //Queue<String>() q = new Queue();



            var firstName = "";
            //5
            try
            {

            }
            catch (Exception ex) when (firstName == null)
            {
                WriteLine($"{firstName} cannot be null");
            }
            catch (Exception ex)
            {
                if (firstName == null)
                {
                    WriteLine($"{nameof(firstName)} cannot be null");
                }
            }
//            catch (Exception ex) when (firstName == null)
//            {
//                WriteLine($"{nameof(firstName)} cannot be null");
//            }
//            finally (Exception ex)
//            {
//                
//            }

            ReadKey();

            //1
            //which of the following are required to override Equals() method in C#?
            Obj obj = new Obj();
            WriteLine(obj.Equals(obj));

            WriteLine(obj.Equals(null));

            Obj obj1 = new Obj();
            Obj obj2 = new Obj();
            WriteLine(obj1.Equals(obj2));
            ReadKey();
        }
    }

}
