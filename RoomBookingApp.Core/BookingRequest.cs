﻿
namespace RoomBookingApp.Core
{
    public class BookingRequest
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime StartDateTime { get; set; }
    }
}