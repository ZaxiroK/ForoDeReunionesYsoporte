using System;

namespace ForoDeReunionesYsoporte.Models
{
    public class Meeting
    {
        public int ID { get; set; }
        public string MeetingTittle  { get; set; }
        public DateTime Date { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public Boolean Virtual { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
    
    }
} 