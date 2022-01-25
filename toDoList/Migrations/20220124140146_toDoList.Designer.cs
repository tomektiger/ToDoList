﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using toDoList.DataAccess;

namespace toDoList.Migrations
{
    [DbContext(typeof(TaskContext))]
    [Migration("20220124140146_toDoList")]
    partial class toDoList
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("toDoList.Models.Tasks", b =>
                {
                    b.Property<byte[]>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<string>("Task")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}