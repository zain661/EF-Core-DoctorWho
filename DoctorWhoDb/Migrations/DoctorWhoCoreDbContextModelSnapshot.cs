// <auto-generated />
using System;
using DoctorWhoDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorWhoDb.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDbContext_))]
    partial class DoctorWhoCoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DoctorWhoDb.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Sydney Newman"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Donald Wilson"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "Brian Hayles"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "Robert Holmes"
                        },
                        new
                        {
                            AuthorId = 5,
                            AuthorName = "Terrance Dicks"
                        });
                });

            modelBuilder.Entity("DoctorWhoDb.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanionId"));

                    b.Property<string>("CompanionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhoPlayed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanionId");

                    b.ToTable("Companions");

                    b.HasData(
                        new
                        {
                            CompanionId = 1,
                            CompanionName = "Susan Foreman",
                            WhoPlayed = "Carole Ann Ford"
                        },
                        new
                        {
                            CompanionId = 2,
                            CompanionName = "Vicki",
                            WhoPlayed = "Maureen O'Brien"
                        },
                        new
                        {
                            CompanionId = 3,
                            CompanionName = "Steven Taylor",
                            WhoPlayed = "Peter Purves"
                        },
                        new
                        {
                            CompanionId = 4,
                            CompanionName = "Katarina",
                            WhoPlayed = "Adrienne Hill"
                        },
                        new
                        {
                            CompanionId = 5,
                            CompanionName = "Ace",
                            WhoPlayed = "Sophie Aldred"
                        });
                });

            modelBuilder.Entity("DoctorWhoDb.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"));

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FirstEpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastEpisodeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            BirthDate = new DateTime(1908, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "William Hartnell",
                            DoctorNumber = 1,
                            FirstEpisodeDate = new DateTime(1963, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1966, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 2,
                            BirthDate = new DateTime(1920, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Patrick Troughton",
                            DoctorNumber = 2,
                            FirstEpisodeDate = new DateTime(1966, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1969, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 3,
                            BirthDate = new DateTime(1919, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Jon Pertwee",
                            DoctorNumber = 3,
                            FirstEpisodeDate = new DateTime(1970, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1974, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 4,
                            BirthDate = new DateTime(1934, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Tom Baker",
                            DoctorNumber = 4,
                            FirstEpisodeDate = new DateTime(1974, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1981, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 5,
                            BirthDate = new DateTime(1951, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Peter Davison",
                            DoctorNumber = 5,
                            FirstEpisodeDate = new DateTime(1982, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1984, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DoctorWhoDb.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnemyId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnemyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnemyId");

                    b.ToTable("Enemies");

                    b.HasData(
                        new
                        {
                            EnemyId = 1,
                            Description = "A race of mutants from the planet Skaro",
                            EnemyName = "Daleks"
                        },
                        new
                        {
                            EnemyId = 2,
                            Description = "A race of cybernetically augmented humanoids",
                            EnemyName = "Cybermen"
                        },
                        new
                        {
                            EnemyId = 3,
                            Description = "A warrior race of clones",
                            EnemyName = "Sontarans"
                        },
                        new
                        {
                            EnemyId = 4,
                            Description = "An intelligent reptilian species",
                            EnemyName = "Silurians"
                        },
                        new
                        {
                            EnemyId = 5,
                            Description = "A species of quantum-locked humanoids",
                            EnemyName = "Weeping Angels"
                        });
                });

            modelBuilder.Entity("DoctorWhoDb.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Episodes");

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            AuthorId = 1,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(1963, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "TV",
                            Notes = "First episode of Doctor Who",
                            SeriesNumber = 1,
                            Title = "An Unearthly Child"
                        },
                        new
                        {
                            EpisodeId = 2,
                            AuthorId = 2,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(1963, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 2,
                            EpisodeType = "TV",
                            Notes = "First appearance of the Daleks",
                            SeriesNumber = 1,
                            Title = "The Daleks"
                        },
                        new
                        {
                            EpisodeId = 3,
                            AuthorId = 3,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(1966, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "TV",
                            Notes = "",
                            SeriesNumber = 2,
                            Title = "The Power of the Daleks"
                        },
                        new
                        {
                            EpisodeId = 4,
                            AuthorId = 4,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(1970, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "TV",
                            Notes = "",
                            SeriesNumber = 3,
                            Title = "Spearhead from Space"
                        },
                        new
                        {
                            EpisodeId = 5,
                            AuthorId = 5,
                            DoctorId = 4,
                            EpisodeDate = new DateTime(1974, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "TV",
                            Notes = "",
                            SeriesNumber = 4,
                            Title = "Robot"
                        });
                });

            modelBuilder.Entity("DoctorWhoDb.EpisodeCompanion", b =>
                {
                    b.Property<int>("EpisodeCompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeCompanionId"));

                    b.Property<int>("CompanionId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeCompanionId");

                    b.HasIndex("CompanionId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeCompanions");

                    b.HasData(
                        new
                        {
                            EpisodeCompanionId = 1,
                            CompanionId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeCompanionId = 2,
                            CompanionId = 1,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeCompanionId = 3,
                            CompanionId = 2,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeCompanionId = 4,
                            CompanionId = 3,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeCompanionId = 5,
                            CompanionId = 4,
                            EpisodeId = 5
                        });
                });

            modelBuilder.Entity("DoctorWhoDb.EpisodeEnemy", b =>
                {
                    b.Property<int>("EpisodeEnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeEnemyId"));

                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeEnemyId");

                    b.HasIndex("EnemyId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeEnemies");

                    b.HasData(
                        new
                        {
                            EpisodeEnemyId = 1,
                            EnemyId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeEnemyId = 2,
                            EnemyId = 1,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeEnemyId = 3,
                            EnemyId = 2,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeEnemyId = 4,
                            EnemyId = 3,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeEnemyId = 5,
                            EnemyId = 4,
                            EpisodeId = 5
                        });
                });

            modelBuilder.Entity("DoctorWhoDb.viewEpisodes", b =>
                {
                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Companions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Enemies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.ToTable((string)null);

                    b.ToView("viewEpisodes", (string)null);
                });

            modelBuilder.Entity("DoctorWhoDb.Episode", b =>
                {
                    b.HasOne("DoctorWhoDb.Author", "Author")
                        .WithMany("Episodes")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWhoDb.Doctor", "Doctor")
                        .WithMany("Episodes")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("DoctorWhoDb.EpisodeCompanion", b =>
                {
                    b.HasOne("DoctorWhoDb.Companion", "Companion")
                        .WithMany("EpisodeCompanions")
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWhoDb.Episode", "Episode")
                        .WithMany("EpisodeCompanions")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companion");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWhoDb.EpisodeEnemy", b =>
                {
                    b.HasOne("DoctorWhoDb.Enemy", "Enemy")
                        .WithMany("EpisodeEnemies")
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWhoDb.Episode", "Episode")
                        .WithMany("EpisodeEnemies")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enemy");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWhoDb.Author", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWhoDb.Companion", b =>
                {
                    b.Navigation("EpisodeCompanions");
                });

            modelBuilder.Entity("DoctorWhoDb.Doctor", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWhoDb.Enemy", b =>
                {
                    b.Navigation("EpisodeEnemies");
                });

            modelBuilder.Entity("DoctorWhoDb.Episode", b =>
                {
                    b.Navigation("EpisodeCompanions");

                    b.Navigation("EpisodeEnemies");
                });
#pragma warning restore 612, 618
        }
    }
}
