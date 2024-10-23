namespace BookingAPI.Models
{
    public class Slot
    {
        public int SlotId { get; set; }
        public int StylistId { get; set; }
        public DateOnly DateSlot { get; set; }
        public DateTime TimeSlot { get; set; }  
        public bool isSlotAvailable { get; set; }
    }
}
