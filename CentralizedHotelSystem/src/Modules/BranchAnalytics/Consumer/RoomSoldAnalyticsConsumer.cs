using Modules.ReservationPricing.Domain.Events;

namespace Modules.BranchAnalytics.Consumer
{
    public class BranchAnalyticsConsumer
    {
        private readonly List<RoomReserved> _reservations = new();

        public void OnRoomReserved(RoomReserved @event)
        {
            _reservations.Add(@event);
            Console.WriteLine($"[Analytics] Room reserved: Reservation {@event.ReservationId} for Customer {@event.CustomerName}");
        }

        public void PrintDashboard()
        {
            Console.WriteLine("=== Branch Analytics Dashboard ===");
            foreach (var res in _reservations)
            {
                Console.WriteLine($"Reservation: {res.ReservationId}, Customer: {res.CustomerName}");
            }
            Console.WriteLine("=== End Dashboard ===");
        }
    }
}
