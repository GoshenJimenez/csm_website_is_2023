using System;
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("857918e8-67dd-4c35-b70d-936ba0fc0c01"), new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3108), "School Friends Chat", new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3108) },
                    { new Guid("857918e8-67dd-4c35-b70d-936ba0fc0c02"), new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3111), "Family Chat", new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3110) },
                    { new Guid("857918e8-67dd-4c35-b70d-936ba0fc0c03"), new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3113), "CIS 214 Chat", new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3112) },
                    { new Guid("857918e8-67dd-4c35-b70d-936ba0fc0c04"), new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3118), "History Class Chat", new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3114) },
                    { new Guid("857918e8-67dd-4c35-b70d-936ba0fc0c05"), new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3124), "Barcada Chat", new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3123) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "EmailAddress", "FirstName", "LastName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("91a4e383-5133-4675-ad4e-24ef11bb4c00"), new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3094), "etirel@mailinator.com", "Elspeth", "Tirel", new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3080) },
                    { new Guid("91a4e383-5133-4675-ad4e-24ef11bb4c01"), new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3103), "jbeleren@mailinator.com", "Jace", "Beleren", new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3102) }
                });

            migrationBuilder.InsertData(
                table: "ChatMembers",
                columns: new[] { "Id", "ChatId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("a3c237aa-97b9-481b-bc32-5ca036b9b501"), new Guid("857918e8-67dd-4c35-b70d-936ba0fc0c03"), new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3133), new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3133), new Guid("91a4e383-5133-4675-ad4e-24ef11bb4c00") },
                    { new Guid("a3c237aa-97b9-481b-bc32-5ca036b9b502"), new Guid("857918e8-67dd-4c35-b70d-936ba0fc0c03"), new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3137), new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3136), new Guid("91a4e383-5133-4675-ad4e-24ef11bb4c01") }
                });

            migrationBuilder.InsertData(
                table: "ChatMessages",
                columns: new[] { "Id", "ChatId", "CreatedAt", "Message", "ReplyToId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("39c059ac-0cee-4daa-a8bd-2ee9d7050030"), new Guid("857918e8-67dd-4c35-b70d-936ba0fc0c03"), new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3143), "Hi, Nunc at turpis faucibus, viverra ipsum non, vestibulum nibh.", null, new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3142), new Guid("91a4e383-5133-4675-ad4e-24ef11bb4c00") },
                    { new Guid("39c059ac-0cee-4daa-a8bd-2ee9d7050031"), new Guid("857918e8-67dd-4c35-b70d-936ba0fc0c03"), new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3179), "Hello, Mauris condimentum urna vel diam gravida vulputate", null, new DateTime(2023, 9, 22, 14, 52, 9, 862, DateTimeKind.Local).AddTicks(3178), new Guid("91a4e383-5133-4675-ad4e-24ef11bb4c01") }
                });

            migrationBuilder.InsertData(
                table: "SchoolPosts",
                columns: new[] { "Id", "Content", "CreatedAt", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("caf9cd32-5e33-451d-a756-cad109eabef2"), "TEST CONTENT", null, "Title", null, new Guid("91a4e383-5133-4675-ad4e-24ef11bb4c01") });

            migrationBuilder.InsertData(
                table: "SchoolPostMedia",
                columns: new[] { "Id", "CreatedAt", "MediaType", "SchoolPostId", "UpdatedAt", "Value" },
                values: new object[] { new Guid("f6d073e1-1948-44ac-a1c7-c85f26457f28"), null, 1, new Guid("caf9cd32-5e33-451d-a756-cad109eabef2"), null, "/schoolposts/caf9cd32-5e33-451d-a756-cad109eabef2/main.png" });

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
                name: "ChatMedia");

            migrationBuilder.DropTable(
                name: "ChatMembers");

            migrationBuilder.DropTable(
                name: "ChatReactions");

            migrationBuilder.DropTable(
                name: "SchoolPostComments");

            migrationBuilder.DropTable(
                name: "SchoolPostMedia");

            migrationBuilder.DropTable(
                name: "SchoolPostReactions");

            migrationBuilder.DropTable(
                name: "SchoolPostShares");

            migrationBuilder.DropTable(
                name: "ChatMessages");

            migrationBuilder.DropTable(
                name: "SchoolPosts");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
