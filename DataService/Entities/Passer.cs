namespace DataService.Entities
{
    public partial class Passer
    {
        public string Player { get; set; }
        public int PlayerId { get; set; }
        public string Position { get; set; }
        public string TeamName { get; set; }
        public int PlayerGameCount { get; set; }
        public double AccuracyPercent { get; set; }
        public int AimedPasses { get; set; }
        public int Attempts { get; set; }
        public double AvgDepthOfTarget { get; set; }
        public double AvgTimeToThrow { get; set; }
        public int Bats { get; set; }
        public int BigTimeThrows { get; set; }
        public double BttRate { get; set; }
        public double CompletionPercent { get; set; }
        public int Completions { get; set; }
        public int DeclinedPenalties { get; set; }
        public int DefGenPressures { get; set; }
        public double DropRate { get; set; }
        public int Dropbacks { get; set; }
        public int Drops { get; set; }
        public int FirstDowns { get; set; }
        public int FranchiseId { get; set; }
        public double GradesHandsFumble { get; set; }
        public double GradesOffense { get; set; }
        public double GradesPass { get; set; }
        public double GradesRun { get; set; }
        public int HitAsThrew { get; set; }
        public int Interceptions { get; set; }
        public int PassingSnaps { get; set; }
        public int Penalties { get; set; }
        public double PressureToSackRate { get; set; }
        public double QbRating { get; set; }
        public double SackPercent { get; set; }
        public int Sacks { get; set; }
        public int Scrambles { get; set; }
        public int Spikes { get; set; }
        public int ThrownAways { get; set; }
        public int Touchdowns { get; set; }
        public int TurnoverWorthyPlays { get; set; }
        public double TwpRate { get; set; }
        public int Yards { get; set; }
        public double Ypa { get; set; }
    }
}
