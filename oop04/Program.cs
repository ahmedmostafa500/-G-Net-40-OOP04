using System.Buffers.Text;
using System.Numerics;
using System.Text;
using System.Xml.Linq;

namespace oop04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1
            #region question1
            //Q1: What is the difference between static binding and dynamic binding? When does each one happen ?
            // Static binding means the method call is decided at compile time.
            // The compiler already knows which method will be executed before the program runs.
            // When does it happen?
            // Static binding happens when using:
            // static methods
            // private methods
            // sealed methods
            //Method Overloading

            //  Dynamic binding means the method call is decided at runtime.
            //  The program decides which method to execute while running, based on the object type.
            //  When does it happen?
            // Dynamic binding happens when using:
            //virtual
            //override
            //abstract
            #endregion
            #region question2
            //Q2: What is the difference between method overloading and method overriding?
            //    Method Overloading means:
            //    Same method name
            //    But different parameters
            //    Inside the same class
            //    So we create multiple versions of a method.
            //    Purpose:
            //    To perform similar actions in different ways
            //    Happens at:
            //   Compile Time → (Static Binding)

            // Method Overriding means:
            //A child class changes the behavior of a method from the parent class.
            //Conditions:
            //Must be in inheritance
            //Parent method must be virtual or abstract
            //Child method must use override
            //Happens at:
            //Runtime → (Dynamic Binding)
            #endregion
            #region question3
            //Q3: What keywords are used for Method Overriding? What does each one mean ?
            // 1. virtual
            // Used in:
            // Parent class
            // It tells the compiler:
            // “This method can be changed(overridden) in a child class.”

            // 2. override
            //Used in:
            // Child class
            // It tells the compiler:
            //  “I am replacing the parent class method with a new implementation.”
            //   This creates runtime polymorphism.
            #endregion
            #endregion
            #region part2
            Cinema cinema = new Cinema();
            cinema.OpenCinema();

            Console.WriteLine("\n========== SetPrice Test ==========");

            StandardTicket t1 = new StandardTicket("Inception", 120m, "A-5");
            VIPTicket t2 = new VIPTicket("Avengers", 200m, true);
            IMAXTicket t3 = new IMAXTicket("Dune", 180m, false);

            // Test overloaded methods
            t1.SetPrice(150m);
            t1.SetPrice(100m, 1.5m);

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.PrintAllTickets();

            TicketProcessor.ProcessTicket(t2);

            cinema.CloseCinema();
            #endregion
        }
    }
}
