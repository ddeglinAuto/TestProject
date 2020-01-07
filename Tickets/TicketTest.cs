using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tickets
{
    [TestClass]
    public class TicketTest
    {

        [TestMethod]
        public void Play_Test()
        {
            DateTime date = new DateTime(2020, 3, 4);
            //Ticket ticket = new Ticket("1", "2", "3", "2020");
            Play play = new Play("Chess championship","1", "2", "3", "15/4/2020", "Chess");
            Console.WriteLine(play);
                        
        }
        [TestMethod]
        public void Lecture_Test()
        {
            DateTime date = new DateTime(2020, 3, 4);
            //Ticket ticket = new Ticket("1", "2", "3", "2020");
            Lecture lecture = new Lecture("AI in 2020","1", "2", "3", "15/4/2020", "Artificial inteligence");
            Console.WriteLine(lecture);
                        
        }
        [TestMethod]
        public void Musical_Test()
        {
            DateTime date = new DateTime(2020, 3, 4);
            //Ticket ticket = new Ticket("1", "2", "3", "2020");
            Musical musical = new Musical("Back to 80s", "1", "2", "3", "15/4/2020", "REM");
            Console.WriteLine(musical);

        }
        [TestMethod]
        public void ProtectedTestMethod()
        {
            DateTime date = new DateTime(2020, 3, 4);
            //Ticket ticket = new Ticket("1", "2", "3", "2020");
            //Play play = new Play("1", "2", "3", date, "REM");
        }
    }
}
