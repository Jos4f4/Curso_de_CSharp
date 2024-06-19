using System;
using Trycatch.Entities;
using Trycatch.Entities.Exceptions;

public class ProcessFile
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Room Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-In date: (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservation reservation = new Reservation(number, checkIn, checkOut);
            Console.WriteLine("Reservatio: " + reservation);

            Console.WriteLine();
            Console.WriteLine("Enter data to update the reservation: ");
            Console.Write("Check-In date: (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            reservation.UpdateDates(checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);
        }
        catch(DomainException e)
        {
            Console.WriteLine("Error in reservation: " + e.Message);
        }
        catch(FormatException e)
        {
            Console.WriteLine("Format error: " + e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine("Unexpected error: " + e.Message);
        }

    }
}