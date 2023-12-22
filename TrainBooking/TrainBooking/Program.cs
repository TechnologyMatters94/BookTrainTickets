using System;

namespace TrainBooking
{
    class Program
    {


        static void Main(string[] args)
        {
            int option;
            List<TicketBO> trainDetails = new List<TicketBO>();
            do
            {
                Console.WriteLine("Please select one from below");
                Console.WriteLine("1. Book a Ticket");
                Console.WriteLine("2. View a Ticket");
                Console.WriteLine("3. View All Ticket");
                Console.WriteLine("4. Cancel Ticket");
                Console.WriteLine("5. Exit");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        // Book a Ticket
                        TicketBO ticketBO = new TicketBO();
                        Console.WriteLine("Enter Name :");
                        ticketBO.Name = Console.ReadLine();

                        Console.WriteLine("Enter Source :");
                        ticketBO.Source = Console.ReadLine();

                        Console.WriteLine("Enter Destination :");
                        ticketBO.Destination = Console.ReadLine();

                        ticketBO.Id = 1000 + trainDetails.Count + 1;

                        trainDetails.Add(ticketBO);
                        Console.WriteLine("Ticket Booked Successfully");
                        break;
                    case 2:
                        break;
                    case 3:
                        // View All Ticket
                        foreach (TicketBO ticket in trainDetails)
                        {
                            Console.WriteLine(" ------------------------- #" + ticket.Id + " ------------------------- ");
                            Console.WriteLine(" ");
                            Console.WriteLine("ID : " + ticket.Id);
                            Console.WriteLine("NAME : " + ticket.Name);
                            Console.WriteLine("SOURCE : " + ticket.Source);
                            Console.WriteLine("DESTINATION : " + ticket.Destination);
                            Console.WriteLine(" ");
                        }

                        break;
                    case 4:
                        break;
                    case 5:
                        Console.WriteLine("Exited Successfully");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }

            } while (option > 0 && option < 5);

        }
    }
}
