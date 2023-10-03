using CSMWebsite2023.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.EntityFramework
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User>? Users { get; set; }

        #region Chats
        public DbSet<Chat>? Chats { get; set; }
        public DbSet<ChatMedium>? ChatMedia { get; set; }
        public DbSet<ChatMember>? ChatMembers { get; set; }
        public DbSet<ChatMessage>? ChatMessages { get; set; }
        public DbSet<ChatReaction>? ChatReactions { get; set; }
        #endregion

        #region SchoolPosts
        public DbSet<SchoolPost>? SchoolPosts { get; set; }
        public DbSet<SchoolPostComment>? SchoolPostComments { get; set; }
        public DbSet<SchoolPostMedium>? SchoolPostMedia { get; set; }
        public DbSet<SchoolPostReaction>? SchoolPostReactions { get; set; }
        public DbSet<SchoolPostShare>? SchoolPostShares { get; set; }

        #endregion

        #region Researches
        public DbSet<Research>? Researches { get; set; }
        public DbSet<ResearchAuthor>? ResearchAuthors { get; set; }
        public DbSet<ResearchComment>? ResearchComments { get; set; }
        public DbSet<ResearchMedium>? ResearchMedia { get; set; }
        public DbSet<ResearchReaction>? ResearchReactions { get; set; }
        public DbSet<ResearchShare>? ResearchShares { get; set; }
        #endregion

        #region Group
        public DbSet<Group>? Groups { get; set; }
        public DbSet<GroupMember>? GroupMembers { get; set; }
        public DbSet<GroupPost>? GroupPosts { get; set; }
        public DbSet<GroupPost>? GroupPstComments { get; set; }
        public DbSet<GroupPostMedium>? GroupPostMedia { get; set; }
        public DbSet<GroupPost>? GroupPostReactions { get; set; }
        #endregion

        #region SchoolAds
        public DbSet<SchoolAds>? SchoolAds { get; set; }
        public DbSet<AdComments>? AdComments { get; set; }
        public DbSet<AdMedia>? AdMedium { get; set; }
        public DbSet<AdReactions>? AdReactions { get; set; }
        public DbSet<AdShares>? AdShares { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<User>? users = new List<User>() {
                new User()
                {
                    Id = Guid.Parse("91a4e383-5133-4675-ad4e-24ef11bb4c00"),
                    EmailAddress = "etirel@mailinator.com",
                    FirstName = "Elspeth",
                    LastName =  "Tirel",
                    UpdatedAt = DateTime.Now,
                    CreatedAt = DateTime.Now,
                },
                new User()
                {
                    Id = Guid.Parse("91a4e383-5133-4675-ad4e-24ef11bb4c01"),
                    EmailAddress = "jbeleren@mailinator.com",
                    FirstName = "Jace",
                    LastName =  "Beleren",
                    UpdatedAt = DateTime.Now,
                    CreatedAt = DateTime.Now,
                },
            };

            List<Chat>? chats = new List<Chat>()
            {
                new Chat()
                { //
                    Id = Guid.Parse("857918e8-67dd-4c35-b70d-936ba0fc0c01"),
                    Name = "School Friends Chat",
                    UpdatedAt = DateTime.Now,
                    CreatedAt = DateTime.Now,
                },new Chat()
                {
                    Id = Guid.Parse("857918e8-67dd-4c35-b70d-936ba0fc0c02"),
                    Name = "Family Chat",
                    UpdatedAt = DateTime.Now,
                    CreatedAt = DateTime.Now,
                },new Chat()
                {
                    Id = Guid.Parse("857918e8-67dd-4c35-b70d-936ba0fc0c03"),
                    Name = "CIS 214 Chat",
                    UpdatedAt = DateTime.Now,
                    CreatedAt = DateTime.Now,
                },new Chat()
                {
                    Id = Guid.Parse("857918e8-67dd-4c35-b70d-936ba0fc0c04"),
                    Name = "History Class Chat",
                    UpdatedAt = DateTime.Now,
                    CreatedAt = DateTime.Now,
                },new Chat()
                {
                    Id = Guid.Parse("857918e8-67dd-4c35-b70d-936ba0fc0c05"),
                    Name = "Barcada Chat",
                    UpdatedAt = DateTime.Now,
                    CreatedAt = DateTime.Now,
                }
            };

            List<ChatMember>? chatMembers = new List<ChatMember>() {
                new ChatMember()
                {
                    Id = Guid.Parse("a3c237aa-97b9-481b-bc32-5ca036b9b501"),
                    ChatId = Guid.Parse("857918e8-67dd-4c35-b70d-936ba0fc0c03"),
                    UserId =  Guid.Parse("91a4e383-5133-4675-ad4e-24ef11bb4c00"),
                    UpdatedAt = DateTime.Now,
                    CreatedAt = DateTime.Now,
                },
                new ChatMember()
                {
                    Id = Guid.Parse("a3c237aa-97b9-481b-bc32-5ca036b9b502"),
                    ChatId = Guid.Parse("857918e8-67dd-4c35-b70d-936ba0fc0c03"),
                    UserId =  Guid.Parse("91a4e383-5133-4675-ad4e-24ef11bb4c01"),
                    UpdatedAt = DateTime.Now,
                    CreatedAt = DateTime.Now,
                }
            };

            List<ChatMessage>? chatMessages = new List<ChatMessage>()
            {
                new ChatMessage()
                {
                    Id = Guid.Parse("39c059ac-0cee-4daa-a8bd-2ee9d7050030"),
                    ChatId = Guid.Parse("857918e8-67dd-4c35-b70d-936ba0fc0c03"),
                    UserId =  Guid.Parse("91a4e383-5133-4675-ad4e-24ef11bb4c00"),
                    Message = "Hi, Nunc at turpis faucibus, viverra ipsum non, vestibulum nibh.",
                    UpdatedAt = DateTime.Now,
                    CreatedAt = DateTime.Now,
                },
                new ChatMessage()
                {
                    Id = Guid.Parse("39c059ac-0cee-4daa-a8bd-2ee9d7050031"),
                    ChatId = Guid.Parse("857918e8-67dd-4c35-b70d-936ba0fc0c03"),
                    UserId =  Guid.Parse("91a4e383-5133-4675-ad4e-24ef11bb4c01"),
                    Message = "Hello, Mauris condimentum urna vel diam gravida vulputate",
                    UpdatedAt = DateTime.Now,
                    CreatedAt = DateTime.Now,
                },
            };


            List<SchoolPost> schoolPosts = new List<SchoolPost>()
            {
                new SchoolPost()
                {
                    Id = Guid.Parse("caf9cd32-5e33-451d-a756-cad109eabef2"),
                    Content = "TEST CONTENT",
                    Title = "Title",
                    UserId =  Guid.Parse("91a4e383-5133-4675-ad4e-24ef11bb4c01"),
                }
            };

            List<SchoolPostMedium> schoolPostMedia = new List<SchoolPostMedium> {
                new SchoolPostMedium()
                {
                    Id = Guid.Parse("f6d073e1-1948-44ac-a1c7-c85f26457f28"),
                    MediaType = Data.Enums.MediaType.ImageUrl,
                    SchoolPostId = Guid.Parse("caf9cd32-5e33-451d-a756-cad109eabef2"),
                    Value = "/schoolposts/caf9cd32-5e33-451d-a756-cad109eabef2/main.png"
                }
            };

            List<Research> researches = new List<Research> {
                new Research()
                {
                    Id = Guid.Parse("f6d073e1-1948-44ac-a1c7-c85f26457f30"),
                    Title = "Title",
                    Abstract = "Abstract",
                }
            };


            List<Group> groups = new List<Group> {
                new Group()
                {
                    Id = Guid.Parse("f6d073e1-1948-44ac-a1c7-c85f26457f32"),
                    Name = "Name",
                }
            };

            List<SchoolAds> schoolads = new List<SchoolAds> {
                new SchoolAds()
                {
                    Id = Guid.Parse("f6d073e1-1948-44ac-a1c7-c85f26457f30"),
                    Title = "Title",
                    Description = "Description",
                }
            };
            



            modelBuilder.Entity<Chat>().HasData(chats);
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<ChatMember>().HasData(chatMembers);
            modelBuilder.Entity<ChatMessage>().HasData(chatMessages);

            modelBuilder.Entity<SchoolPost>().HasData(schoolPosts);
            modelBuilder.Entity<SchoolPostMedium>().HasData(schoolPostMedia);

            modelBuilder.Entity<Research>().HasData(researches);


            modelBuilder.Entity<Group>().HasData(groups);

            
            modelBuilder.Entity<SchoolAds>().HasData(schoolads);


        }

    }
}