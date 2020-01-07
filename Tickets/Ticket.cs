using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    //not possible to instantiate abstract class
    abstract class Ticket
    {
        private string eventname;
        private string rownumber;
        private string price;
        private string seat;
        private string eventdate;

        //constructor
        //public Ticket()
        //{
        //}
        public Ticket(string EventName, string SitNumber, string RowNumber, string Price, string EventDate)
        {
            eventName = EventName;
            Seat = SitNumber;
            RowNum = RowNumber;
            TicketPrice = Price;
            eventDate = EventDate;
        }
        public string eventName
        {
            get { return eventname; }
            set { eventname = value; }
        }
        public string Seat 
        {
            get { return seat; }
            set { seat = value; }
        }
        public string RowNum
        {
            get { return rownumber; }
            set { rownumber = value; }
        }
        public string TicketPrice
        {
            get { return price; }
            set { price = value; }
        }

        public string eventDate
        {
            get { return eventdate; }
            set { eventdate = value; }
        }

        //abstract method doesn't have body, enforces derived class to use this method
        public override string ToString()
        {
        return eventname.ToUpper() +":\t"  + "\n\tWhen:\t" + eventdate +
        "\n\tRow:\t" + rownumber +
        "\n\tSeat number:\t" + seat +
        "\n\tPrice:\t" + price;
        }
        
    }

    //derived class
    class Play : Ticket
    {
        public string gamename;
        public Play(string EventName,  string SitNumber, string RowNumber, string Price, string EventDate, string GameName) : base(EventName, SitNumber, RowNumber, Price, EventDate)
        {
            gameName = GameName;
        }
        public string gameName
        {
            get { return gamename; }
            set { gamename = value; }
        }
        //overrides the abstarct method of a base class
        public override string ToString()
        {
            return base.ToString() + "\nGame Name:" + gamename;
            
        }
    }

    class Lecture : Ticket
    {
        public string lecturetype;
        public Lecture(string EventName,string SitNumber, string RowNumber, string Price, string EventDate, string LectureType) : base(EventName,SitNumber, RowNumber, Price, EventDate)
        {
            lectureType = LectureType;
        }
        public string lectureType
        {
            get { return lecturetype; }
            set { lecturetype = value; }
        }
        //overrides the abstarct method of a base class
        public override string ToString()
        {
            return base.ToString() + "\nLecture Type:" + lectureType;

        }
    }

    class Musical : Ticket
    {
        public string janre;
        public Musical(string EventName, string SitNumber, string RowNumber, string Price, string EventDate, string Janre) : base( EventName, SitNumber, RowNumber, Price, EventDate)
        {
            musicJanre = Janre;
        }
        public string musicJanre
        {
            get { return janre; }
            set { janre = value; }
        }
        //overrides the abstarct method of a base class
        public override string ToString()
        {
            return base.ToString() + "\nConcert Janer:" + janre;
        }
    }
}
