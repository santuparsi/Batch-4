using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnExceptionHandling
{
    class TicketException:ApplicationException
    {
        public override string Message => "Ticket Count is Exceeded";
    }
    class Demo2
    {
        public static void BookTicket(int count)
        {
            try
            {
                if (count <= 3)
                {
                    Console.WriteLine("Booking Done..");
                }
                else
                {
                    throw new TicketException();
                }
            }
            catch(TicketException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main()
        {
            try
            {
                BookTicket(1);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
