namespace BookingAPI.Models
{
    public class Appointment
    { 
        public int Id { get; set; }
        public int CliientId { get; set; }
        public int StylistId { get; set; }  
        public DateTime AppointmentDate { get; set; }
        public string? Status { get; set; } //0 Pending, 1 Confirmed, 2 Cancelled
    }
}
