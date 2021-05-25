using DataService.Entities;

namespace NFCNorth.Models
{
    public class PlayerDetailViewModel
    {
        public string FullName { get; set; }
        public string Team { get; set; }
        public string Description { get; set; }
        public string HeadshotLocation { get; set; }

        // Normally we wouldn't expose our entities to the front-end, but for the sake of simplicity..
        public Rusher RushingStats { get; set; }
        public Passer PassingStats { get; set; }
        public Receiver ReceivingStats { get; set; }
        public PlayerInfo PlayerInfo { get; set; }
    }
}
