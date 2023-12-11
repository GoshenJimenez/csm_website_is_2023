﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CSMWebsite2023.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Researches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Abstract = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Researches", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SchoolAds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolAds", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SchoolEvents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolEvents", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    EmailAddress = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GroupPost",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    GroupId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupPost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupPost_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AdComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    SchoolAdsId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ReplyToId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Message = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdComments_SchoolAds_SchoolAdsId",
                        column: x => x.SchoolAdsId,
                        principalTable: "SchoolAds",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdComments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AdMedia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    SchoolAdsId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    MediaType = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdMedia_SchoolAds_SchoolAdsId",
                        column: x => x.SchoolAdsId,
                        principalTable: "SchoolAds",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdMedia_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AdReactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    SchoolAdsId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ReactionType = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdReactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdReactions_SchoolAds_SchoolAdsId",
                        column: x => x.SchoolAdsId,
                        principalTable: "SchoolAds",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdReactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AdShares",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    SchoolAdsId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdShares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdShares_SchoolAds_SchoolAdsId",
                        column: x => x.SchoolAdsId,
                        principalTable: "SchoolAds",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdShares_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChatMembers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ChatId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatMembers_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChatMembers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChatMessages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ChatId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Message = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReplyToId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatMessages_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChatMessages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GroupMembers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    GroupId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupMembers_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GroupMembers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ResearchAuthors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ResearchId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchAuthors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResearchAuthors_Researches_ResearchId",
                        column: x => x.ResearchId,
                        principalTable: "Researches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ResearchAuthors_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ResearchComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ResearchId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ReplyToId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Message = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResearchComments_Researches_ResearchId",
                        column: x => x.ResearchId,
                        principalTable: "Researches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ResearchComments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ResearchMedia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ResearchId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    MediaType = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResearchMedia_Researches_ResearchId",
                        column: x => x.ResearchId,
                        principalTable: "Researches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ResearchMedia_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ResearchReactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ResearchId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ReactionType = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchReactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResearchReactions_Researches_ResearchId",
                        column: x => x.ResearchId,
                        principalTable: "Researches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ResearchReactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ResearchShares",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ResearchId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchShares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResearchShares_Researches_ResearchId",
                        column: x => x.ResearchId,
                        principalTable: "Researches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ResearchShares_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SchoolEventComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    SchoolEventId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ReplyToId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolEventComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolEventComments_SchoolEvents_SchoolEventId",
                        column: x => x.SchoolEventId,
                        principalTable: "SchoolEvents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SchoolEventComments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SchoolEventMedia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    SchoolEventId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    MediaType = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolEventMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolEventMedia_SchoolEvents_SchoolEventId",
                        column: x => x.SchoolEventId,
                        principalTable: "SchoolEvents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SchoolEventMedia_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SchoolEventReactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    SchoolEventId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolEventReactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolEventReactions_SchoolEvents_SchoolEventId",
                        column: x => x.SchoolEventId,
                        principalTable: "SchoolEvents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SchoolEventReactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SchoolEventShares",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    SchoolEventId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolEventShares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolEventShares_SchoolEvents_SchoolEventId",
                        column: x => x.SchoolEventId,
                        principalTable: "SchoolEvents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SchoolEventShares_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SchoolPosts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Content = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolPosts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GroupPostMedia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    GroupId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    GroupPostId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    MediaType = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupPostMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupPostMedia_GroupPost_GroupPostId",
                        column: x => x.GroupPostId,
                        principalTable: "GroupPost",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GroupPostMedia_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChatMedia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ChatId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ChatMessageId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    MediaType = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatMedia_ChatMessages_ChatMessageId",
                        column: x => x.ChatMessageId,
                        principalTable: "ChatMessages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChatMedia_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChatMedia_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChatReactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ChatId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ChatMessageId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ReactionType = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatReactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatReactions_ChatMessages_ChatMessageId",
                        column: x => x.ChatMessageId,
                        principalTable: "ChatMessages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChatReactions_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChatReactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SchoolPostComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    SchoolPostId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Message = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReplyToId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolPostComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolPostComments_SchoolPosts_SchoolPostId",
                        column: x => x.SchoolPostId,
                        principalTable: "SchoolPosts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SchoolPostComments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SchoolPostMedia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    SchoolPostId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    MediaType = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolPostMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolPostMedia_SchoolPosts_SchoolPostId",
                        column: x => x.SchoolPostId,
                        principalTable: "SchoolPosts",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SchoolPostReactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    SchoolPostId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ReactionType = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolPostReactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolPostReactions_SchoolPosts_SchoolPostId",
                        column: x => x.SchoolPostId,
                        principalTable: "SchoolPosts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SchoolPostReactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SchoolPostShares",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    SchoolPostId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolPostShares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolPostShares_SchoolPosts_SchoolPostId",
                        column: x => x.SchoolPostId,
                        principalTable: "SchoolPosts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SchoolPostShares_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("857918e8-67dd-4c35-b70d-936ba0fc0c01"), new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5235), true, "School Friends Chat", new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5234) },
                    { new Guid("857918e8-67dd-4c35-b70d-936ba0fc0c02"), new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5238), true, "Family Chat", new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5237) },
                    { new Guid("857918e8-67dd-4c35-b70d-936ba0fc0c03"), new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5241), true, "CIS 214 Chat", new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5240) },
                    { new Guid("857918e8-67dd-4c35-b70d-936ba0fc0c04"), new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5243), true, "History Class Chat", new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5242) },
                    { new Guid("857918e8-67dd-4c35-b70d-936ba0fc0c05"), new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5245), true, "Barcada Chat", new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5244) }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[] { new Guid("f6d073e1-1948-44ac-a1c7-c85f26457f32"), null, true, "Name", null });

            migrationBuilder.InsertData(
                table: "Researches",
                columns: new[] { "Id", "Abstract", "CreatedAt", "IsActive", "Title", "UpdatedAt" },
                values: new object[] { new Guid("f6d073e1-1948-44ac-a1c7-c85f26457f30"), "Abstract", null, true, "Title", null });

            migrationBuilder.InsertData(
                table: "SchoolAds",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "Title", "UpdatedAt" },
                values: new object[] { new Guid("f6d073e1-1948-44ac-a1c7-c85f26457f34"), null, "Description", true, "Title", null });

            migrationBuilder.InsertData(
                table: "SchoolEvents",
                columns: new[] { "Id", "CreatedAt", "Date", "Description", "IsActive", "Title", "UpdatedAt" },
                values: new object[] { new Guid("f6d073e1-1948-44ac-a1c7-c85f26457f36"), null, new DateTime(2023, 12, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5292), "A party for students to get to get to know one another", true, "Acquaintance Party", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "EmailAddress", "FirstName", "IsActive", "LastName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("91a4e383-5133-4675-ad4e-24ef11bb4c00"), new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5221), "etirel@mailinator.com", "Elspeth", true, "Tirel", new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5201) },
                    { new Guid("91a4e383-5133-4675-ad4e-24ef11bb4c01"), new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5231), "jbeleren@mailinator.com", "Jace", true, "Beleren", new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5230) }
                });

            migrationBuilder.InsertData(
                table: "ChatMembers",
                columns: new[] { "Id", "ChatId", "CreatedAt", "IsActive", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("a3c237aa-97b9-481b-bc32-5ca036b9b501"), new Guid("857918e8-67dd-4c35-b70d-936ba0fc0c03"), new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5258), true, new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5257), new Guid("91a4e383-5133-4675-ad4e-24ef11bb4c00") },
                    { new Guid("a3c237aa-97b9-481b-bc32-5ca036b9b502"), new Guid("857918e8-67dd-4c35-b70d-936ba0fc0c03"), new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5262), true, new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5262), new Guid("91a4e383-5133-4675-ad4e-24ef11bb4c01") }
                });

            migrationBuilder.InsertData(
                table: "ChatMessages",
                columns: new[] { "Id", "ChatId", "CreatedAt", "IsActive", "Message", "ReplyToId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("39c059ac-0cee-4daa-a8bd-2ee9d7050030"), new Guid("857918e8-67dd-4c35-b70d-936ba0fc0c03"), new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5267), true, "Hi, Nunc at turpis faucibus, viverra ipsum non, vestibulum nibh.", null, new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5266), new Guid("91a4e383-5133-4675-ad4e-24ef11bb4c00") },
                    { new Guid("39c059ac-0cee-4daa-a8bd-2ee9d7050031"), new Guid("857918e8-67dd-4c35-b70d-936ba0fc0c03"), new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5272), true, "Hello, Mauris condimentum urna vel diam gravida vulputate", null, new DateTime(2023, 11, 29, 14, 33, 12, 434, DateTimeKind.Local).AddTicks(5271), new Guid("91a4e383-5133-4675-ad4e-24ef11bb4c01") }
                });

            migrationBuilder.InsertData(
                table: "SchoolEventMedia",
                columns: new[] { "Id", "CreatedAt", "IsActive", "MediaType", "SchoolEventId", "UpdatedAt", "UserId", "Value" },
                values: new object[] { new Guid("657ee26a-8b52-4a34-b577-02b961fcdb26"), null, true, 3, new Guid("f6d073e1-1948-44ac-a1c7-c85f26457f36"), null, null, "\\schoolevents\\f6d073e1-1948-44ac-a1c7-c85f26457f36\\articleImage.jpg" });

            migrationBuilder.InsertData(
                table: "SchoolPosts",
                columns: new[] { "Id", "Content", "CreatedAt", "IsActive", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("caf9cd32-5e33-451d-a756-cad109eabef2"), "TEST CONTENT", null, true, "Title", null, new Guid("91a4e383-5133-4675-ad4e-24ef11bb4c01") });

            migrationBuilder.InsertData(
                table: "SchoolPostMedia",
                columns: new[] { "Id", "CreatedAt", "IsActive", "MediaType", "SchoolPostId", "UpdatedAt", "Value" },
                values: new object[] { new Guid("f6d073e1-1948-44ac-a1c7-c85f26457f28"), null, true, 1, new Guid("caf9cd32-5e33-451d-a756-cad109eabef2"), null, "/schoolposts/caf9cd32-5e33-451d-a756-cad109eabef2/main.png" });

            migrationBuilder.CreateIndex(
                name: "IX_AdComments_SchoolAdsId",
                table: "AdComments",
                column: "SchoolAdsId");

            migrationBuilder.CreateIndex(
                name: "IX_AdComments_UserId",
                table: "AdComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AdMedia_SchoolAdsId",
                table: "AdMedia",
                column: "SchoolAdsId");

            migrationBuilder.CreateIndex(
                name: "IX_AdMedia_UserId",
                table: "AdMedia",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AdReactions_SchoolAdsId",
                table: "AdReactions",
                column: "SchoolAdsId");

            migrationBuilder.CreateIndex(
                name: "IX_AdReactions_UserId",
                table: "AdReactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AdShares_SchoolAdsId",
                table: "AdShares",
                column: "SchoolAdsId");

            migrationBuilder.CreateIndex(
                name: "IX_AdShares_UserId",
                table: "AdShares",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMedia_ChatId",
                table: "ChatMedia",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMedia_ChatMessageId",
                table: "ChatMedia",
                column: "ChatMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMedia_UserId",
                table: "ChatMedia",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMembers_ChatId",
                table: "ChatMembers",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMembers_UserId",
                table: "ChatMembers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_ChatId",
                table: "ChatMessages",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_UserId",
                table: "ChatMessages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatReactions_ChatId",
                table: "ChatReactions",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatReactions_ChatMessageId",
                table: "ChatReactions",
                column: "ChatMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatReactions_UserId",
                table: "ChatReactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMembers_GroupId",
                table: "GroupMembers",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMembers_UserId",
                table: "GroupMembers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupPost_GroupId",
                table: "GroupPost",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupPostMedia_GroupId",
                table: "GroupPostMedia",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupPostMedia_GroupPostId",
                table: "GroupPostMedia",
                column: "GroupPostId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchAuthors_ResearchId",
                table: "ResearchAuthors",
                column: "ResearchId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchAuthors_UserId",
                table: "ResearchAuthors",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchComments_ResearchId",
                table: "ResearchComments",
                column: "ResearchId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchComments_UserId",
                table: "ResearchComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchMedia_ResearchId",
                table: "ResearchMedia",
                column: "ResearchId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchMedia_UserId",
                table: "ResearchMedia",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchReactions_ResearchId",
                table: "ResearchReactions",
                column: "ResearchId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchReactions_UserId",
                table: "ResearchReactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchShares_ResearchId",
                table: "ResearchShares",
                column: "ResearchId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchShares_UserId",
                table: "ResearchShares",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolEventComments_SchoolEventId",
                table: "SchoolEventComments",
                column: "SchoolEventId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolEventComments_UserId",
                table: "SchoolEventComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolEventMedia_SchoolEventId",
                table: "SchoolEventMedia",
                column: "SchoolEventId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolEventMedia_UserId",
                table: "SchoolEventMedia",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolEventReactions_SchoolEventId",
                table: "SchoolEventReactions",
                column: "SchoolEventId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolEventReactions_UserId",
                table: "SchoolEventReactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolEventShares_SchoolEventId",
                table: "SchoolEventShares",
                column: "SchoolEventId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolEventShares_UserId",
                table: "SchoolEventShares",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolPostComments_SchoolPostId",
                table: "SchoolPostComments",
                column: "SchoolPostId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolPostComments_UserId",
                table: "SchoolPostComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolPostMedia_SchoolPostId",
                table: "SchoolPostMedia",
                column: "SchoolPostId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolPostReactions_SchoolPostId",
                table: "SchoolPostReactions",
                column: "SchoolPostId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolPostReactions_UserId",
                table: "SchoolPostReactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolPosts_UserId",
                table: "SchoolPosts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolPostShares_SchoolPostId",
                table: "SchoolPostShares",
                column: "SchoolPostId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolPostShares_UserId",
                table: "SchoolPostShares",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdComments");

            migrationBuilder.DropTable(
                name: "AdMedia");

            migrationBuilder.DropTable(
                name: "AdReactions");

            migrationBuilder.DropTable(
                name: "AdShares");

            migrationBuilder.DropTable(
                name: "ChatMedia");

            migrationBuilder.DropTable(
                name: "ChatMembers");

            migrationBuilder.DropTable(
                name: "ChatReactions");

            migrationBuilder.DropTable(
                name: "GroupMembers");

            migrationBuilder.DropTable(
                name: "GroupPostMedia");

            migrationBuilder.DropTable(
                name: "ResearchAuthors");

            migrationBuilder.DropTable(
                name: "ResearchComments");

            migrationBuilder.DropTable(
                name: "ResearchMedia");

            migrationBuilder.DropTable(
                name: "ResearchReactions");

            migrationBuilder.DropTable(
                name: "ResearchShares");

            migrationBuilder.DropTable(
                name: "SchoolEventComments");

            migrationBuilder.DropTable(
                name: "SchoolEventMedia");

            migrationBuilder.DropTable(
                name: "SchoolEventReactions");

            migrationBuilder.DropTable(
                name: "SchoolEventShares");

            migrationBuilder.DropTable(
                name: "SchoolPostComments");

            migrationBuilder.DropTable(
                name: "SchoolPostMedia");

            migrationBuilder.DropTable(
                name: "SchoolPostReactions");

            migrationBuilder.DropTable(
                name: "SchoolPostShares");

            migrationBuilder.DropTable(
                name: "SchoolAds");

            migrationBuilder.DropTable(
                name: "ChatMessages");

            migrationBuilder.DropTable(
                name: "GroupPost");

            migrationBuilder.DropTable(
                name: "Researches");

            migrationBuilder.DropTable(
                name: "SchoolEvents");

            migrationBuilder.DropTable(
                name: "SchoolPosts");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}