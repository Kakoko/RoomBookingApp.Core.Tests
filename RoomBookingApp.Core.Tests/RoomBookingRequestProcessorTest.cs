using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBookingApp.Core.Tests
{
    public class RoomBookingRequestProcessorTest
    {
        [Fact]
        public void Should_Return_Booking_Response_With_Request_Values()
        {
            //Arrange
            var request = new BookingRequest
            {
                FullName = "John Doe",
                Email = "test@test.com",
                StartDateTime = new DateTime(2021, 1, 1, 10, 0, 0)
            };

            var roomBookingRequestProcessor = new RoomBookingRequestProcessor();

            //Act
            RoomBookingResult result= roomBookingRequestProcessor.BookRoom(request);


            //Assert
            result.ShouldNotBeNull();
            Assert.Equal(request.FullName, result.FullName);
            Assert.Equal(request.Email, result.Email);
            Assert.Equal(request.StartDateTime, result.StartDateTime);

        }
    }
}
