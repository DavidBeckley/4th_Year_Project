using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Google_Maps_Transport_Locator.Models
{
    public class BusDetails
    {
        public BusDetails()
        {

        }

        public BusDetails(int Bid, string busTo, string busFrom, string bNumber, int bStopNum, string bsAddress, string bsLocation, double lat, double longt, int bHeading)
        {
            ID = Bid;
            busTowards = busTo;
            busVia = busFrom;
            busNumber = busNumber;
            bStopNumber = bStopNum;
            busAddress = bsAddress;
            busStopLocation = bsLocation;
            latitude = lat;
            longitude = longt;
            bHeading = heading;
        }

        [Key]
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [DisplayName("Bus Number")]
        [Required(ErrorMessage = "Bus Number is required")]
        [StringLength(5)]
        public string busNumber { get; set; }

        [DisplayName("Bus Destination")]
        [Required(ErrorMessage = "Bus Number is required")]
        public string busTowards { get; set; }

        [DisplayName("Via")]
        [Required(ErrorMessage = "Bus Number is required")]
        public string busVia { get; set; }

        [DisplayName("Bus Stop Number")]
        [Required(ErrorMessage = "Bus Stop Number is required")]
        public int bStopNumber { get; set; }

        [DisplayName("Bus Stop Address")]
        [Required(ErrorMessage = "Bus Stop Address is required")]
        public string busAddress { get; set; }

        [DisplayName("Bus Stop Location ")]
        [Required(ErrorMessage = "Bus Stop Location is required")]
        public string busStopLocation { get; set; }

        [DisplayName("Latitude")]
        [Range(-90, 90, ErrorMessage = "Latitude must be between -90 and 90")]
        public double latitude { get; set; }

        [DisplayName("Longitude")]
        [Range(-90, 90, ErrorMessage = "Longitude must be between -180 and 180")]
        public double longitude { get; set; }

        [DisplayName("Heading")]
        [Required(ErrorMessage = "Heading is required")]
        [Range(0, 360, ErrorMessage = "Heading must be between 0 and 360")]
        public int heading { get; set; }
    }
}