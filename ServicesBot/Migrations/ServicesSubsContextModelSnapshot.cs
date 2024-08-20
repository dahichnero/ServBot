﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServicesBot.Models;

#nullable disable

namespace ServicesBot.Migrations
{
    [DbContext(typeof(ServicesSubsContext))]
    partial class ServicesSubsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("ServicesBot.Models.Period", b =>
                {
                    b.Property<int>("PeriodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountDays")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("ServiceSubsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PeriodId");

                    b.HasIndex("ServiceSubsId");

                    b.ToTable("Periods");
                });

            modelBuilder.Entity("ServicesBot.Models.ServiceSubs", b =>
                {
                    b.Property<int>("ServiceSubsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("ServiceSubsId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("ServicesBot.Models.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("ServicesBot.Models.UserPeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("EndDay")
                        .HasColumnType("TEXT");

                    b.Property<long>("MyUser")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PeriodId")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("StartDay")
                        .HasColumnType("TEXT");

                    b.Property<int>("StatusId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PeriodId");

                    b.HasIndex("StatusId");

                    b.ToTable("UserPeriods");
                });

            modelBuilder.Entity("ServicesBot.Models.Period", b =>
                {
                    b.HasOne("ServicesBot.Models.ServiceSubs", "ServiceSubs")
                        .WithMany()
                        .HasForeignKey("ServiceSubsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ServiceSubs");
                });

            modelBuilder.Entity("ServicesBot.Models.UserPeriod", b =>
                {
                    b.HasOne("ServicesBot.Models.Period", "Period")
                        .WithMany()
                        .HasForeignKey("PeriodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServicesBot.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Period");

                    b.Navigation("Status");
                });
#pragma warning restore 612, 618
        }
    }
}
