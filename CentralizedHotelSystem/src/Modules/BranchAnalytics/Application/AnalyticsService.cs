using Modules.ReservationPricing.Domain.Events;
using Modules.FoodBeverage.Domain.Events;
using System;

namespace Modules.BranchAnalytics.Application
{
    public class AnalyticsService
    {
        public void HandleRoomReserved(RoomReserved @event)
        {
            Console.WriteLine($"[Analytics] Reservation made: {@event.ReservationId} for Customer {@event.CustomerName}");
        }

        public void HandleFoodSold(FoodSold @event)
        {
            Console.WriteLine($"[Analytics] Food sold: {@event.FoodName} (ID: {@event.FoodId})");
        }
    }
}
