using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HotelWCF
{
    [ServiceContract]
    interface ISearchHotel
    {
        [OperationContract]
        Hotel GetHotelById(int id);

        [OperationContract]
        List<Hotel> GetAllHotels();

        
    }
}
