using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CRICKET.Models
{
    public partial class CRICKETContext : DbContext
    {
        public CRICKETContext()
        {
        }

        public CRICKETContext(DbContextOptions<CRICKETContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Matches> Matches { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Stadium> Stadium { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=CRICKET;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.ContinentName)
                    .HasColumnName("continent_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasColumnName("country_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Matches>(entity =>
            {
                entity.HasKey(e => e.MatchId);

                entity.Property(e => e.MatchId).HasColumnName("Match_id");

                entity.Property(e => e.DateTime)
                    .HasColumnName("Date_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Result)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StadiumName)
                    .HasColumnName("Stadium_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TeamA).HasColumnName("Team_A");

                entity.Property(e => e.TeamB).HasColumnName("Team_B");

                entity.Property(e => e.WasMatchPlayed)
                    .HasColumnName("was_match_played")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.TeamANavigation)
                    .WithMany(p => p.MatchesTeamANavigation)
                    .HasForeignKey(d => d.TeamA)
                    .HasConstraintName("FK__Matches__Team_A__6477ECF3");

                entity.HasOne(d => d.TeamBNavigation)
                    .WithMany(p => p.MatchesTeamBNavigation)
                    .HasForeignKey(d => d.TeamB)
                    .HasConstraintName("FK__Matches__Team_B__656C112C");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.Property(e => e.PlayerId).HasColumnName("Player_id");

                entity.Property(e => e.CountryId).HasColumnName("Country_id");

                entity.Property(e => e.PlayerAge)
                    .HasColumnName("player_age")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlayerName)
                    .HasColumnName("Player_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Player)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__Player__Country___6B24EA82");
            });

            modelBuilder.Entity<Stadium>(entity =>
            {
                entity.HasKey(e => e.StadiumName);

                entity.Property(e => e.StadiumName)
                    .HasColumnName("stadium_name")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.StadiumCount).HasColumnName("stadium_count");

                entity.Property(e => e.StadiumId).HasColumnName("stadium_id");

                entity.Property(e => e.StadiumMatches).HasColumnName("stadium_matches");

                entity.HasOne(d => d.StadiumNavigation)
                    .WithMany(p => p.Stadium)
                    .HasForeignKey(d => d.StadiumId)
                    .HasConstraintName("FK__Stadium__stadium__68487DD7");
            });
        }
    }
}
