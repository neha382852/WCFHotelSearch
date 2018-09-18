using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelWCF
{
    [DataContract]
    class Hotel
    {
        [DataMember]
        public int hotelId;

        [DataMember]
        public string HotelName;

        [DataMember]
        public string HotelAddress;

        [DataMember]
        public int HotelRating;



    }
}
