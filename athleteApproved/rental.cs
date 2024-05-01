using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace athleteApproved
{
    public class rental
    {
        public string userName { get; set; }  
        public int userId { get; set; }
        public string rentalName { get; set; }   
        public string rentalAddress { get; set; }
        public int zipCode { get; set; }
        public string operatingHrs { get; set; }

        public string rentalFee { get; set; }

    }
    public class clsRentalManager
    {
        public List<rental> lstRental = new  List<rental>(); 

        public clsRentalManager()
        {
           lstRental.Add(new rental()
           {
               userName = "Iceman",
               userId = 69,
               rentalName = "Mapua Gymnasium",
               rentalAddress = "Intramuros, Manila",
               zipCode = 2004,
               operatingHrs = "10:00 AM - 10:00 PM",
               rentalFee = "300 per hour"

           });
            lstRental.Add(new rental()
            {
                userName = "Iceman",
                userId = 69,
                rentalName = "Mapua Gymnasium",
                rentalAddress = "Intramuros, Manila",
                zipCode = 2004,
                operatingHrs = "10:00 AM - 10:00 PM",
                rentalFee = "400 per hour"

            });
        }
    }
}
