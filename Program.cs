namespace oop4
{
    #region part2 Q1
    /*
    class Ticket
    {
        private static int ticketCounter = 0;

        public int TicketId { get; private set; }
        public string MovieName { get; set; }
        public decimal Price { get; protected set; }

        public decimal PriceAfterTax
        {
            get { return Price * 1.14m; }
        }

        public Ticket(string movieName, decimal price)
        {
            MovieName = movieName;
            Price = price;

            ticketCounter++;
            TicketId = ticketCounter;
        }

        // Method Overloading: first version
        public void SetPrice(decimal price)
        {
            if (price > 0)
            {
                Price = price;
            }
        }

        // Method Overloading: second version
        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            if (basePrice > 0 && multiplier > 0)
            {
                Price = basePrice * multiplier;
            }
        }

        public virtual void PrintTicket()
        {
            Console.WriteLine(
                "Ticket #" + TicketId +
                " | " + MovieName +
                " | Price: " + Price.ToString("F2") +
                " EGP | After Tax: " +
                PriceAfterTax.ToString("F2") + " EGP");
        }
    }

    class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(
            string movieName,
            decimal price,
            string seatNumber)
            : base(movieName, price)
        {
            SeatNumber = seatNumber;
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine("  Seat: " + SeatNumber);
        }
    }

    class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; set; }

        public VIPTicket(
            string movieName,
            decimal price,
            bool loungeAccess,
            decimal serviceFee)
            : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
            ServiceFee = serviceFee;
        }

        public override void PrintTicket()
        {
            base.PrintTicket();

            Console.WriteLine(
                "  Lounge: " + (LoungeAccess ? "Yes" : "No") +
                " | Service Fee: " + ServiceFee + " EGP");
        }
    }

    class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(
            string movieName,
            decimal price,
            bool is3D)
            : base(movieName, price)
        {
            Is3D = is3D;
        }

        public override void PrintTicket()
        {
            base.PrintTicket();

            Console.WriteLine(
                "  IMAX 3D: " + (Is3D ? "Yes" : "No"));
        }
    }

    class Projector
    {
        public void Start()
        {
            Console.WriteLine("Projector started.");
        }

        public void Stop()
        {
            Console.WriteLine("Projector stopped.");
        }
    }

    class Cinema
    {
        private Ticket[] tickets = new Ticket[20];
        private Projector projector = new Projector();

        public void OpenCinema()
        {
            Console.WriteLine("========== Cinema Opened ==========");
            projector.Start();
        }

        public void CloseCinema()
        {
            Console.WriteLine("========== Cinema Closed ==========");
            projector.Stop();
        }

        public bool AddTicket(Ticket ticket)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = ticket;
                    return true;
                }
            }

            return false;
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("========== All Tickets ==========");

            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] != null)
                {
                    tickets[i].PrintTicket();
                }
            }
        }
    }
    */
    #endregion
    internal class Program
    {
        #region part2 Q1
        /*
        // Polymorphism: accepts any type of Ticket
        static void ProcessTicket(Ticket t)
        {
            t.PrintTicket();
        }
        */
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            //Static Binding:(Compile Time)يتم التحديد وقت 
            //ex:Method Overloading

            //Dynamic Binding:(Run Time)يتم التحديد وقت 
            //ex:Method Overriding باستخدام virtual وoverride
            #endregion

            #region Q2
            /*
            Method Overloading: Defining multiple methods with the same name but
            different parameter lists in the same class.

             Method Overriding: Redefining an inherited virtual or abstract method in a derived class using 
             the same method signature to provide a different implementation
            */
            #endregion

            #region Q3
            /*
            virtual: Allows a method in the base class to be overridden in a derived class.
            override: Provides a new implementation of an inherited virtual or abstract method.

            abstract: Declares a method without an implementation, requiring a non-abstract derived class to implement it.
            sealed: Prevents a method that overrides a base method from being overridden further when used with override.
            */
            #endregion

            #region part2 Q1
            /*
            Cinema cinema = new Cinema();

            // a. Create and open cinema
            cinema.OpenCinema();

            // b. Create three ticket types
            StandardTicket standard = new StandardTicket(
                "Inception", 100m, "A-5");

            VIPTicket vip = new VIPTicket(
                "Avengers", 200m, true, 50m);

            IMAXTicket imax = new IMAXTicket(
                "Dune", 180m, false);

            // c. Test both SetPrice methods
            Console.WriteLine("========== SetPrice Test ==========");

            Console.WriteLine("Setting price directly: 150");
            standard.SetPrice(150m);

            Console.WriteLine(
                "Setting price with multiplier: 100 x 1.5 = 150");
            standard.SetPrice(100m, 1.5m);

            // d. Add tickets and print them
            cinema.AddTicket(standard);
            cinema.AddTicket(vip);
            cinema.AddTicket(imax);

            cinema.PrintAllTickets();

            // e. Process a single ticket
            Console.WriteLine(
                "========== Process Single Ticket ==========");

            ProcessTicket(vip);

            // f. Close cinema
            cinema.CloseCinema();
            */
            #endregion
        }
    }
}
