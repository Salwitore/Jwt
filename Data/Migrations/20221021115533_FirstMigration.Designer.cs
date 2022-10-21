﻿// <auto-generated />
using System;
using Data.ContextClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(MasterContext))]
    [Migration("20221021115533_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Data.EntityClasses.LoginUser", b =>
                {
                    b.Property<int>("LoginUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<string>("LoginUserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LoginUserPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginUserId");

                    b.ToTable("LoginUsers");
                });

            modelBuilder.Entity("Data.EntityClasses.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("TicketState")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("TicketTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TicketId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Data.EntityClasses.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserSurname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Data.EntityClasses.UserTicket", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "TicketId");

                    b.HasIndex("TicketId");

                    b.ToTable("UserTickets");
                });

            modelBuilder.Entity("Data.EntityClasses.LoginUser", b =>
                {
                    b.HasOne("Data.EntityClasses.User", "User")
                        .WithOne("LoginUser")
                        .HasForeignKey("Data.EntityClasses.LoginUser", "LoginUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.EntityClasses.UserTicket", b =>
                {
                    b.HasOne("Data.EntityClasses.Ticket", "Ticket")
                        .WithMany("UserTickets")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.EntityClasses.User", "User")
                        .WithMany("UserTickets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ticket");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.EntityClasses.Ticket", b =>
                {
                    b.Navigation("UserTickets");
                });

            modelBuilder.Entity("Data.EntityClasses.User", b =>
                {
                    b.Navigation("LoginUser");

                    b.Navigation("UserTickets");
                });
#pragma warning restore 612, 618
        }
    }
}
