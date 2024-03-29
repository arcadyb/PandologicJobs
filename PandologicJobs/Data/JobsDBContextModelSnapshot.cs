﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PandologicJobs.Models;

namespace PandologicTest.Data
{
    [DbContext(typeof(JobsDBContext))]
    partial class JobsDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("PandologicReact.Models.DailyJobs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ActiveJobs")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CumulativeViews")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CumulativeViewsPredicted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("LandingPageId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LandingPageId");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActiveJobs = 21,
                            CumulativeViews = 42,
                            CumulativeViewsPredicted = 62,
                            Date = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 2,
                            ActiveJobs = 22,
                            CumulativeViews = 44,
                            CumulativeViewsPredicted = 64,
                            Date = new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 3,
                            ActiveJobs = 23,
                            CumulativeViews = 46,
                            CumulativeViewsPredicted = 66,
                            Date = new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 4,
                            ActiveJobs = 24,
                            CumulativeViews = 48,
                            CumulativeViewsPredicted = 68,
                            Date = new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 5,
                            ActiveJobs = 25,
                            CumulativeViews = 50,
                            CumulativeViewsPredicted = 70,
                            Date = new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 6,
                            ActiveJobs = 26,
                            CumulativeViews = 52,
                            CumulativeViewsPredicted = 72,
                            Date = new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 7,
                            ActiveJobs = 27,
                            CumulativeViews = 54,
                            CumulativeViewsPredicted = 74,
                            Date = new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 8,
                            ActiveJobs = 28,
                            CumulativeViews = 56,
                            CumulativeViewsPredicted = 76,
                            Date = new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 9,
                            ActiveJobs = 29,
                            CumulativeViews = 58,
                            CumulativeViewsPredicted = 78,
                            Date = new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 10,
                            ActiveJobs = 30,
                            CumulativeViews = 60,
                            CumulativeViewsPredicted = 80,
                            Date = new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 11,
                            ActiveJobs = 31,
                            CumulativeViews = 62,
                            CumulativeViewsPredicted = 82,
                            Date = new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 12,
                            ActiveJobs = 32,
                            CumulativeViews = 64,
                            CumulativeViewsPredicted = 84,
                            Date = new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 13,
                            ActiveJobs = 33,
                            CumulativeViews = 66,
                            CumulativeViewsPredicted = 86,
                            Date = new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 14,
                            ActiveJobs = 34,
                            CumulativeViews = 68,
                            CumulativeViewsPredicted = 88,
                            Date = new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 15,
                            ActiveJobs = 35,
                            CumulativeViews = 70,
                            CumulativeViewsPredicted = 90,
                            Date = new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 16,
                            ActiveJobs = 36,
                            CumulativeViews = 72,
                            CumulativeViewsPredicted = 92,
                            Date = new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 17,
                            ActiveJobs = 37,
                            CumulativeViews = 74,
                            CumulativeViewsPredicted = 94,
                            Date = new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 18,
                            ActiveJobs = 38,
                            CumulativeViews = 76,
                            CumulativeViewsPredicted = 96,
                            Date = new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 19,
                            ActiveJobs = 39,
                            CumulativeViews = 78,
                            CumulativeViewsPredicted = 98,
                            Date = new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 20,
                            ActiveJobs = 40,
                            CumulativeViews = 80,
                            CumulativeViewsPredicted = 100,
                            Date = new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 21,
                            ActiveJobs = 41,
                            CumulativeViews = 82,
                            CumulativeViewsPredicted = 102,
                            Date = new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 22,
                            ActiveJobs = 42,
                            CumulativeViews = 84,
                            CumulativeViewsPredicted = 104,
                            Date = new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 23,
                            ActiveJobs = 43,
                            CumulativeViews = 86,
                            CumulativeViewsPredicted = 106,
                            Date = new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 24,
                            ActiveJobs = 44,
                            CumulativeViews = 88,
                            CumulativeViewsPredicted = 108,
                            Date = new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 25,
                            CumulativeViewsPredicted = 110,
                            Date = new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 26,
                            CumulativeViewsPredicted = 112,
                            Date = new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 27,
                            CumulativeViewsPredicted = 114,
                            Date = new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 28,
                            CumulativeViewsPredicted = 116,
                            Date = new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        },
                        new
                        {
                            Id = 29,
                            CumulativeViewsPredicted = 118,
                            Date = new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LandingPageId = 1
                        });
                });

            modelBuilder.Entity("PandologicReact.Models.LandingPage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Pages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "xyz",
                            Url = "https://xyz.com/MainPage"
                        },
                        new
                        {
                            Id = 2,
                            Name = "yyy",
                            Url = "https://yyy.com/MainPage"
                        });
                });

            modelBuilder.Entity("PandologicReact.Models.DailyJobs", b =>
                {
                    b.HasOne("PandologicReact.Models.LandingPage", null)
                        .WithMany("DailyJobs")
                        .HasForeignKey("LandingPageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PandologicReact.Models.LandingPage", b =>
                {
                    b.Navigation("DailyJobs");
                });
#pragma warning restore 612, 618
        }
    }
}
