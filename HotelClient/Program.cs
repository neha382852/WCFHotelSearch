
using HotelClient.HotelRetrievalServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchHotelClient hotelclient = new SearchHotelClient("BasicHttpBinding_ISearchHotel");

            int flag = 1;
            while (flag == 1)
            {
                Console.WriteLine("Enter 1 to check all hotels Or Enter 2 to get hotel by id");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Hotel Details:-");

                        Hotel[] hotelslist = hotelclient.GetAllHotels();

                        for (int i = 0; i < hotelslist.Length; i++)
                        {
                            Console.WriteLine("HotelId:-" + hotelslist[i].hotelId);
                            Console.WriteLine("HotelName:- " + hotelslist[i].HotelName);
                            Console.WriteLine("HotelAddress:- " + hotelslist[i].HotelAddress);
                            Console.WriteLine("HotelRating:- " + hotelslist[i].HotelRating);
                            Console.WriteLine("-----------");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter ID by which you want to search the hotel");
                        int id = int.Parse(Console.ReadLine());

                        Hotel hotel = hotelclient.GetHotelById(id);
                        if (hotel == null)
                        {
                            Console.WriteLine("Invalid hotel Id. Hotel not found");
                        }
                        else
                        {
                            Console.WriteLine("HotelId:-" + hotel.hotelId);
                            Console.WriteLine("HotelName:- " + hotel.HotelName);
                            Console.WriteLine("HotelAddress:- " + hotel.HotelAddress);
                            Console.WriteLine("HotelRating:- " + hotel.HotelRating);
                            Console.WriteLine("-----------");

                        }
                        break;
                }
                Console.WriteLine("Enter 1 to continue or 0 to stop");
                flag = int.Parse(Console.ReadLine());
            }
        }
    }
}
