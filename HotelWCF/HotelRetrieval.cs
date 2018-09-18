using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWCF
{
    class HotelRetrieval : ISearchHotel
    {

        public List<Hotel> GetAllHotels()
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\nanand\source\repos\HotelWCF\data.json"))
            {
                var json = reader.ReadToEnd();
                List<Hotel> hotels = JsonConvert.DeserializeObject<List<Hotel>>(json);
                return hotels;
            }
        }

        public Hotel GetHotelById(int id)
        {
            List<Hotel> hotellist = GetAllHotels();
            Hotel hotel = hotellist.Find(x => x.hotelId == id);
            return hotel;
        }
    }
}
