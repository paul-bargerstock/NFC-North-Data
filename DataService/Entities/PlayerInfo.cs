using System;

namespace DataService.Entities
{
    public partial class PlayerInfo
    {
        public int PlayerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthdate { get; set; }
        public double Age { get; set; }
        public string LionsPos { get; set; }
        public int JerseyNumber { get; set; }
        public string CollegeName { get; set; }
        public string SchoolCode { get; set; }
        public string ClubName { get; set; }
        public int EntryYear { get; set; }
        public int DraftRound { get; set; }
        public int DraftNumber { get; set; }
        public string DraftClub { get; set; }
        public string PracticeSquadEligible { get; set; }
        public int AccruedSeasons { get; set; }
        public int MinSalaryCredits { get; set; }
        public int Nflexperience { get; set; }
        public int PracticeSquadCredit { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string _40Time { get; set; }
        public string Arm { get; set; }
        public string Hand { get; set; }
        public string Wingspan { get; set; }
        public string AgentFirstName { get; set; }
        public string AgentLastName { get; set; }
    }
}
