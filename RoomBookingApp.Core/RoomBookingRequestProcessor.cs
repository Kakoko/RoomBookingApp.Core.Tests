
namespace RoomBookingApp.Core 
{ 

    public class RoomBookingRequestProcessor
    {
        public RoomBookingRequestProcessor()
        {
        }

        public RoomBookingResult BookRoom(BookingRequest bookingRequest)
        {
            return new RoomBookingResult
            {
                FullName = bookingRequest.FullName,
                Email = bookingRequest.Email,
                StartDateTime = bookingRequest.StartDateTime
            };
        }
    }
}