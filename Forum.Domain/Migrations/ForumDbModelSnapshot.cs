﻿// <auto-generated />
using Forum.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Forum.Domain.Migrations
{
    [DbContext(typeof(ForumDb))]
    partial class ForumDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Forum.Domain.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AnswerContent")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("AnswerVoteDown")
                        .HasColumnType("integer");

                    b.Property<int>("AnswerVoteUp")
                        .HasColumnType("integer");

                    b.Property<int>("AppUserId")
                        .HasColumnType("integer");

                    b.Property<int>("QuestionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Forum.Domain.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AppUser");
                });

            modelBuilder.Entity("Forum.Domain.CommentToAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AnswerId")
                        .HasColumnType("integer");

                    b.Property<int>("CommentToAnswerVoteDown")
                        .HasColumnType("integer");

                    b.Property<int>("CommentToAnswerVoteUp")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AnswerId");

                    b.ToTable("CommentsToAnswer");
                });

            modelBuilder.Entity("Forum.Domain.CommentToComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CommentToAnswerId")
                        .HasColumnType("integer");

                    b.Property<int>("CommentToCommentVoteDown")
                        .HasColumnType("integer");

                    b.Property<int>("CommentToCommentVoteUp")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CommentToAnswerId");

                    b.ToTable("CommentsToComment");
                });

            modelBuilder.Entity("Forum.Domain.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AppUserId")
                        .HasColumnType("integer");

                    b.Property<string>("QuestionContent")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("QuestionVoteDown")
                        .HasColumnType("integer");

                    b.Property<int>("QuestionVoteUp")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Forum.Domain.QuestionTag", b =>
                {
                    b.Property<int>("QuestionId")
                        .HasColumnType("integer");

                    b.Property<int>("TagId")
                        .HasColumnType("integer");

                    b.HasKey("QuestionId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("QuestionTags");
                });

            modelBuilder.Entity("Forum.Domain.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Forum.Domain.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AppUserId")
                        .HasColumnType("integer");

                    b.Property<string>("DisplayName")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId")
                        .IsUnique();

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("Forum.Domain.Answer", b =>
                {
                    b.HasOne("Forum.Domain.AppUser", "AppUser")
                        .WithMany("Answers")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Forum.Domain.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Forum.Domain.CommentToAnswer", b =>
                {
                    b.HasOne("Forum.Domain.Answer", "Answer")
                        .WithMany("CommentsToAnswer")
                        .HasForeignKey("AnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Answer");
                });

            modelBuilder.Entity("Forum.Domain.CommentToComment", b =>
                {
                    b.HasOne("Forum.Domain.CommentToAnswer", "CommentToAnswer")
                        .WithMany("Comments")
                        .HasForeignKey("CommentToAnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CommentToAnswer");
                });

            modelBuilder.Entity("Forum.Domain.Question", b =>
                {
                    b.HasOne("Forum.Domain.AppUser", "AppUser")
                        .WithMany("Questions")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Forum.Domain.QuestionTag", b =>
                {
                    b.HasOne("Forum.Domain.Question", "Question")
                        .WithMany("QuestionTags")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Forum.Domain.Tag", "Tag")
                        .WithMany("QuestionTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Forum.Domain.UserProfile", b =>
                {
                    b.HasOne("Forum.Domain.AppUser", "AppUser")
                        .WithOne("UserProfile")
                        .HasForeignKey("Forum.Domain.UserProfile", "AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Forum.Domain.Answer", b =>
                {
                    b.Navigation("CommentsToAnswer");
                });

            modelBuilder.Entity("Forum.Domain.AppUser", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Questions");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("Forum.Domain.CommentToAnswer", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Forum.Domain.Question", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("QuestionTags");
                });

            modelBuilder.Entity("Forum.Domain.Tag", b =>
                {
                    b.Navigation("QuestionTags");
                });
#pragma warning restore 612, 618
        }
    }
}
