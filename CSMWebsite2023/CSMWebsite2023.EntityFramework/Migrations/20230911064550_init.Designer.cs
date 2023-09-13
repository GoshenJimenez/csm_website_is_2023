﻿// <auto-generated />
using System;
using CSMWebsite2023.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CSMWebsite2023.EntityFramework.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    [Migration("20230911064550_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CSMWebsite2023.Data.Models.Chat", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("CSMWebsite2023.Data.Models.ChatMedium", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ChatId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ChatMessageId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("MediaType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("ChatMessageId");

                    b.HasIndex("UserId");

                    b.ToTable("ChatMedia");
                });

            modelBuilder.Entity("CSMWebsite2023.Data.Models.ChatMember", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ChatId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("UserId");

                    b.ToTable("ChatMembers");
                });

            modelBuilder.Entity("CSMWebsite2023.Data.Models.ChatMessage", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ChatId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Message")
                        .HasColumnType("longtext");

                    b.Property<Guid?>("ReplyToId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("UserId");

                    b.ToTable("ChatMessages");
                });

            modelBuilder.Entity("CSMWebsite2023.Data.Models.ChatReaction", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ChatId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ChatMessageId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ReactionType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("ChatMessageId");

                    b.HasIndex("UserId");

                    b.ToTable("ChatReactions");
                });

            modelBuilder.Entity("CSMWebsite2023.Data.Models.User", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CSMWebsite2023.Data.Models.ChatMedium", b =>
                {
                    b.HasOne("CSMWebsite2023.Data.Models.Chat", "Chat")
                        .WithMany()
                        .HasForeignKey("ChatId");

                    b.HasOne("CSMWebsite2023.Data.Models.ChatMessage", "ChatMessage")
                        .WithMany()
                        .HasForeignKey("ChatMessageId");

                    b.HasOne("CSMWebsite2023.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Chat");

                    b.Navigation("ChatMessage");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CSMWebsite2023.Data.Models.ChatMember", b =>
                {
                    b.HasOne("CSMWebsite2023.Data.Models.Chat", "Chat")
                        .WithMany()
                        .HasForeignKey("ChatId");

                    b.HasOne("CSMWebsite2023.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Chat");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CSMWebsite2023.Data.Models.ChatMessage", b =>
                {
                    b.HasOne("CSMWebsite2023.Data.Models.Chat", "Chat")
                        .WithMany()
                        .HasForeignKey("ChatId");

                    b.HasOne("CSMWebsite2023.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Chat");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CSMWebsite2023.Data.Models.ChatReaction", b =>
                {
                    b.HasOne("CSMWebsite2023.Data.Models.Chat", "Chat")
                        .WithMany()
                        .HasForeignKey("ChatId");

                    b.HasOne("CSMWebsite2023.Data.Models.ChatMessage", "ChatMessage")
                        .WithMany()
                        .HasForeignKey("ChatMessageId");

                    b.HasOne("CSMWebsite2023.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Chat");

                    b.Navigation("ChatMessage");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}