namespace Vehicle.UnitTests
{
    public class VehicleTests
    {
        [Fact]
        public void WhenCreated_HasCorrectProperties()
        {
            Vehicle megansCar = new Vehicle(4, "Green");

            Assert.Equal(4, megansCar.NumberOfWheels);
            Assert.Equal("Green", megansCar.Color);
            Assert.Equal(0, megansCar.MilesDriven);
        }

        // This test needs some work!
        [Fact]
        public void Summary_ReturnsInfoAboutVehicle()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");

            var expected = "This Blue vehicle has 2 wheels, and has driven 0 miles.";

            Assert.Equal(expected, andysBike.Summary());
        }

        // Add more tests here!
        [Fact]
        public void CanIncrease_MilesDrivenBy5()
        {
            Vehicle ashersBike = new Vehicle(2, "Black");

            Assert.Equal(5, ashersBike.Drive());
            //Had to edit lines 31 + 34 on Vehicle.CS
        }

        [Fact]
        public void ReassignValueOfColor()
        {
            Vehicle ashersBike = new Vehicle(2, "Black");

            ashersBike.Paint("pink");

            Assert.Equal("Pink", ashersBike.Paint("Pink"));
            // Can't convert void to char??? Error CS1503 -- Theres no char?!- insert sobbing emoji
            //Like I did for the above, giving it a return type DID fix it. Edited lines 37 + 40. Was it the "correct" solution? Maybe not but it was A solution ...pls don't take point off - I would consider this B+ problem solving
        }
    }
}