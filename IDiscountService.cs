namespace ParkingApp
{
    public interface IDiscountService
    {
        // Set up for injection using Moq into Parking Service
        double GetDiscount();
    }
}
