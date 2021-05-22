namespace DataService.Entities
{
    public partial class Rusher
    {
        public string Player { get; set; }
        public int PlayerId { get; set; }
        public string Position { get; set; }
        public string TeamName { get; set; }
        public int PlayerGameCount { get; set; }
        public int Attempts { get; set; }
        public int AvoidedTackles { get; set; }
        public int BreakawayAttempts { get; set; }
        public double BreakawayPercent { get; set; }
        public int BreakawayYards { get; set; }
        public int DeclinedPenalties { get; set; }
        public int DesignedYards { get; set; }
        public int Drops { get; set; }
        public double EluRecvMtf { get; set; }
        public double EluRushMtf { get; set; }
        public double EluYco { get; set; }
        public double ElusiveRating { get; set; }
        public double Explosive { get; set; }
        public int FirstDowns { get; set; }
        public int FranchiseId { get; set; }
        public int Fumbles { get; set; }
        public int GapAttempts { get; set; }
        public double GradesOffense { get; set; }
        public double GradesOffensePenalty { get; set; }
        public double GradesPassBlock { get; set; }
        public double GradesPassRoute { get; set; }
        public double GradesRun { get; set; }
        public double GradesRunBlock { get; set; }
        public int Longest { get; set; }
        public int Penalties { get; set; }
        public int RecYards { get; set; }
        public int Receptions { get; set; }
        public int Routes { get; set; }
        public int RunPlays { get; set; }
        public int ScrambleYards { get; set; }
        public int Scrambles { get; set; }
        public int Targets { get; set; }
        public int TotalTouches { get; set; }
        public int Touchdowns { get; set; }
        public int Yards { get; set; }
        public int YardsAfterContact { get; set; }
        public double YcoAttempt { get; set; }
        public double Ypa { get; set; }
        public double Yprr { get; set; }
        public int ZoneAttempts { get; set; }
    }
}
