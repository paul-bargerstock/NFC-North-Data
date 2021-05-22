namespace DataService.Entities
{
    public partial class Receiver
    {
        public string Player { get; set; }
        public int PlayerId { get; set; }
        public string Position { get; set; }
        public string TeamName { get; set; }
        public int PlayerGameCount { get; set; }
        public double AvgDepthOfTarget { get; set; }
        public int AvoidedTackles { get; set; }
        public double CaughtPercent { get; set; }
        public double ContestedCatchRate { get; set; }
        public int ContestedReceptions { get; set; }
        public int ContestedTargets { get; set; }
        public int DeclinedPenalties { get; set; }
        public double DropRate { get; set; }
        public int Drops { get; set; }
        public int FirstDowns { get; set; }
        public int FranchiseId { get; set; }
        public int Fumbles { get; set; }
        public double GradesHandsDrop { get; set; }
        public double GradesHandsFumble { get; set; }
        public double GradesOffense { get; set; }
        public double GradesPassRoute { get; set; }
        public double InlineRate { get; set; }
        public int InlineSnaps { get; set; }
        public int Interceptions { get; set; }
        public int Longest { get; set; }
        public double PassBlockRate { get; set; }
        public int PassBlocks { get; set; }
        public int PassPlays { get; set; }
        public int Penalties { get; set; }
        public int Receptions { get; set; }
        public double RouteRate { get; set; }
        public int Routes { get; set; }
        public double SlotRate { get; set; }
        public int SlotSnaps { get; set; }
        public double TargetedQbRating { get; set; }
        public int Targets { get; set; }
        public int Touchdowns { get; set; }
        public double WideRate { get; set; }
        public int WideSnaps { get; set; }
        public int Yards { get; set; }
        public int YardsAfterCatch { get; set; }
        public double YardsAfterCatchPerReception { get; set; }
        public int YardsPerReception { get; set; }
        public double Yprr { get; set; }
    }
}
