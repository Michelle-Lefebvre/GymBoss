﻿// <auto-generated />
using System;
using GymBoss.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GymBoss.Data.Migrations
{
    [DbContext(typeof(GymBossContext))]
    partial class GymBossContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("GymBoss.Models.Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BMI")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Bust")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Calves")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Chest")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("Forearm")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Hips")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Neck")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PTrainerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RestingHeartRate")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Thigh")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UpperArm")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Waist")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("GymBoss.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmailReminder")
                        .HasColumnType("TEXT");

                    b.Property<int>("PTrainerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("GymBoss.Models.Trainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Certifications")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Education")
                        .HasColumnType("TEXT");

                    b.Property<string>("Specialties")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("GymBoss.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Allergies")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cell")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmerFirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmerLastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmerPhone1")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmerPhone2")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Injuries")
                        .HasColumnType("TEXT");

                    b.Property<string>("IsClient")
                        .HasColumnType("TEXT");

                    b.Property<string>("IsManager")
                        .HasColumnType("TEXT");

                    b.Property<string>("IsTrainer")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Province")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
