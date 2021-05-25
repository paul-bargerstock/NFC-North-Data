using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataService.Entities
{
    public partial class FootballExampleContext : DbContext
    {
        public FootballExampleContext()
        {
        }

        public FootballExampleContext(DbContextOptions<FootballExampleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Passer> Passers { get; set; }
        public virtual DbSet<PlayerInfo> PlayerInfos { get; set; }
        public virtual DbSet<Receiver> Receivers { get; set; }
        public virtual DbSet<Rusher> Rushers { get; set; }
        public virtual DbSet<Player> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) //todo; appsettings via DI
            {
                optionsBuilder.UseSqlServer();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PlayerId).HasColumnName("PlayerId");

                entity.Property(e => e.FullName).HasColumnName("FullName");

                entity.Property(e => e.TeamName).HasColumnName("TeamName");

                entity.Property(e => e.NFLHeadshotSrc).HasColumnName("NFLHeadshotSrc");
            });

            modelBuilder.Entity<Passer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AccuracyPercent).HasColumnName("accuracy_percent");

                entity.Property(e => e.AimedPasses).HasColumnName("aimed_passes");

                entity.Property(e => e.Attempts).HasColumnName("attempts");

                entity.Property(e => e.AvgDepthOfTarget).HasColumnName("avg_depth_of_target");

                entity.Property(e => e.AvgTimeToThrow).HasColumnName("avg_time_to_throw");

                entity.Property(e => e.Bats).HasColumnName("bats");

                entity.Property(e => e.BigTimeThrows).HasColumnName("big_time_throws");

                entity.Property(e => e.BttRate).HasColumnName("btt_rate");

                entity.Property(e => e.CompletionPercent).HasColumnName("completion_percent");

                entity.Property(e => e.Completions).HasColumnName("completions");

                entity.Property(e => e.DeclinedPenalties).HasColumnName("declined_penalties");

                entity.Property(e => e.DefGenPressures).HasColumnName("def_gen_pressures");

                entity.Property(e => e.DropRate).HasColumnName("drop_rate");

                entity.Property(e => e.Dropbacks).HasColumnName("dropbacks");

                entity.Property(e => e.Drops).HasColumnName("drops");

                entity.Property(e => e.FirstDowns).HasColumnName("first_downs");

                entity.Property(e => e.FranchiseId).HasColumnName("franchise_id");

                entity.Property(e => e.GradesHandsFumble).HasColumnName("grades_hands_fumble");

                entity.Property(e => e.GradesOffense).HasColumnName("grades_offense");

                entity.Property(e => e.GradesPass).HasColumnName("grades_pass");

                entity.Property(e => e.GradesRun).HasColumnName("grades_run");

                entity.Property(e => e.HitAsThrew).HasColumnName("hit_as_threw");

                entity.Property(e => e.Interceptions).HasColumnName("interceptions");

                entity.Property(e => e.PassingSnaps).HasColumnName("passing_snaps");

                entity.Property(e => e.Penalties).HasColumnName("penalties");

                entity.Property(e => e.Player)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("player");

                entity.Property(e => e.PlayerGameCount).HasColumnName("player_game_count");

                entity.Property(e => e.PlayerId).HasColumnName("player_id");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("position");

                entity.Property(e => e.PressureToSackRate).HasColumnName("pressure_to_sack_rate");

                entity.Property(e => e.QbRating).HasColumnName("qb_rating");

                entity.Property(e => e.SackPercent).HasColumnName("sack_percent");

                entity.Property(e => e.Sacks).HasColumnName("sacks");

                entity.Property(e => e.Scrambles).HasColumnName("scrambles");

                entity.Property(e => e.Spikes).HasColumnName("spikes");

                entity.Property(e => e.TeamName)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("team_name");

                entity.Property(e => e.ThrownAways).HasColumnName("thrown_aways");

                entity.Property(e => e.Touchdowns).HasColumnName("touchdowns");

                entity.Property(e => e.TurnoverWorthyPlays).HasColumnName("turnover_worthy_plays");

                entity.Property(e => e.TwpRate).HasColumnName("twp_rate");

                entity.Property(e => e.Yards).HasColumnName("yards");

                entity.Property(e => e.Ypa).HasColumnName("ypa");
            });

            modelBuilder.Entity<PlayerInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PlayerInfo");

                entity.Property(e => e.AgentFirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AgentLastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Arm)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.ClubName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CollegeName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DraftClub)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Hand)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Height)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LionsPos)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Nflexperience).HasColumnName("NFLExperience");

                entity.Property(e => e.PlayerId).HasColumnName("PlayerId");

                entity.Property(e => e.PracticeSquadEligible)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SchoolCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Wingspan)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e._40Time)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("40 Time");
            });

            modelBuilder.Entity<Receiver>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AvgDepthOfTarget).HasColumnName("avg_depth_of_target");

                entity.Property(e => e.AvoidedTackles).HasColumnName("avoided_tackles");

                entity.Property(e => e.CaughtPercent).HasColumnName("caught_percent");

                entity.Property(e => e.ContestedCatchRate).HasColumnName("contested_catch_rate");

                entity.Property(e => e.ContestedReceptions).HasColumnName("contested_receptions");

                entity.Property(e => e.ContestedTargets).HasColumnName("contested_targets");

                entity.Property(e => e.DeclinedPenalties).HasColumnName("declined_penalties");

                entity.Property(e => e.DropRate).HasColumnName("drop_rate");

                entity.Property(e => e.Drops).HasColumnName("drops");

                entity.Property(e => e.FirstDowns).HasColumnName("first_downs");

                entity.Property(e => e.FranchiseId).HasColumnName("franchise_id");

                entity.Property(e => e.Fumbles).HasColumnName("fumbles");

                entity.Property(e => e.GradesHandsDrop).HasColumnName("grades_hands_drop");

                entity.Property(e => e.GradesHandsFumble).HasColumnName("grades_hands_fumble");

                entity.Property(e => e.GradesOffense).HasColumnName("grades_offense");

                entity.Property(e => e.GradesPassRoute).HasColumnName("grades_pass_route");

                entity.Property(e => e.InlineRate).HasColumnName("inline_rate");

                entity.Property(e => e.InlineSnaps).HasColumnName("inline_snaps");

                entity.Property(e => e.Interceptions).HasColumnName("interceptions");

                entity.Property(e => e.Longest).HasColumnName("longest");

                entity.Property(e => e.PassBlockRate).HasColumnName("pass_block_rate");

                entity.Property(e => e.PassBlocks).HasColumnName("pass_blocks");

                entity.Property(e => e.PassPlays).HasColumnName("pass_plays");

                entity.Property(e => e.Penalties).HasColumnName("penalties");

                entity.Property(e => e.Player)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("player");

                entity.Property(e => e.PlayerGameCount).HasColumnName("player_game_count");

                entity.Property(e => e.PlayerId).HasColumnName("player_id");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("position");

                entity.Property(e => e.Receptions).HasColumnName("receptions");

                entity.Property(e => e.RouteRate).HasColumnName("route_rate");

                entity.Property(e => e.Routes).HasColumnName("routes");

                entity.Property(e => e.SlotRate).HasColumnName("slot_rate");

                entity.Property(e => e.SlotSnaps).HasColumnName("slot_snaps");

                entity.Property(e => e.TargetedQbRating).HasColumnName("targeted_qb_rating");

                entity.Property(e => e.Targets).HasColumnName("targets");

                entity.Property(e => e.TeamName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("team_name");

                entity.Property(e => e.Touchdowns).HasColumnName("touchdowns");

                entity.Property(e => e.WideRate).HasColumnName("wide_rate");

                entity.Property(e => e.WideSnaps).HasColumnName("wide_snaps");

                entity.Property(e => e.Yards).HasColumnName("yards");

                entity.Property(e => e.YardsAfterCatch).HasColumnName("yards_after_catch");

                entity.Property(e => e.YardsAfterCatchPerReception).HasColumnName("yards_after_catch_per_reception");

                entity.Property(e => e.YardsPerReception).HasColumnName("yards_per_reception");

                entity.Property(e => e.Yprr).HasColumnName("yprr");
            });

            modelBuilder.Entity<Rusher>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Attempts).HasColumnName("attempts");

                entity.Property(e => e.AvoidedTackles).HasColumnName("avoided_tackles");

                entity.Property(e => e.BreakawayAttempts).HasColumnName("breakaway_attempts");

                entity.Property(e => e.BreakawayPercent).HasColumnName("breakaway_percent");

                entity.Property(e => e.BreakawayYards).HasColumnName("breakaway_yards");

                entity.Property(e => e.DeclinedPenalties).HasColumnName("declined_penalties");

                entity.Property(e => e.DesignedYards).HasColumnName("designed_yards");

                entity.Property(e => e.Drops).HasColumnName("drops");

                entity.Property(e => e.EluRecvMtf).HasColumnName("elu_recv_mtf");

                entity.Property(e => e.EluRushMtf).HasColumnName("elu_rush_mtf");

                entity.Property(e => e.EluYco).HasColumnName("elu_yco");

                entity.Property(e => e.ElusiveRating).HasColumnName("elusive_rating");

                entity.Property(e => e.Explosive).HasColumnName("explosive");

                entity.Property(e => e.FirstDowns).HasColumnName("first_downs");

                entity.Property(e => e.FranchiseId).HasColumnName("franchise_id");

                entity.Property(e => e.Fumbles).HasColumnName("fumbles");

                entity.Property(e => e.GapAttempts).HasColumnName("gap_attempts");

                entity.Property(e => e.GradesOffense).HasColumnName("grades_offense");

                entity.Property(e => e.GradesOffensePenalty).HasColumnName("grades_offense_penalty");

                entity.Property(e => e.GradesPassBlock).HasColumnName("grades_pass_block");

                entity.Property(e => e.GradesPassRoute).HasColumnName("grades_pass_route");

                entity.Property(e => e.GradesRun).HasColumnName("grades_run");

                entity.Property(e => e.GradesRunBlock).HasColumnName("grades_run_block");

                entity.Property(e => e.Longest).HasColumnName("longest");

                entity.Property(e => e.Penalties).HasColumnName("penalties");

                entity.Property(e => e.Player)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("player");

                entity.Property(e => e.PlayerGameCount).HasColumnName("player_game_count");

                entity.Property(e => e.PlayerId).HasColumnName("player_id");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("position");

                entity.Property(e => e.RecYards).HasColumnName("rec_yards");

                entity.Property(e => e.Receptions).HasColumnName("receptions");

                entity.Property(e => e.Routes).HasColumnName("routes");

                entity.Property(e => e.RunPlays).HasColumnName("run_plays");

                entity.Property(e => e.ScrambleYards).HasColumnName("scramble_yards");

                entity.Property(e => e.Scrambles).HasColumnName("scrambles");

                entity.Property(e => e.Targets).HasColumnName("targets");

                entity.Property(e => e.TeamName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("team_name");

                entity.Property(e => e.TotalTouches).HasColumnName("total_touches");

                entity.Property(e => e.Touchdowns).HasColumnName("touchdowns");

                entity.Property(e => e.Yards).HasColumnName("yards");

                entity.Property(e => e.YardsAfterContact).HasColumnName("yards_after_contact");

                entity.Property(e => e.YcoAttempt).HasColumnName("yco_attempt");

                entity.Property(e => e.Ypa).HasColumnName("ypa");

                entity.Property(e => e.Yprr).HasColumnName("yprr");

                entity.Property(e => e.ZoneAttempts).HasColumnName("zone_attempts");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
