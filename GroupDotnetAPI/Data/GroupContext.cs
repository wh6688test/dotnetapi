using Microsoft.EntityFrameworkCore;
using GroupDotnetAPI.Models;

namespace GroupDotnetAPI.Data 
{
    
    public class GroupContext : DbContext
    {
         public  GroupContext(DbContextOptions<GroupContext>options): base(options)
         {
         }

         public DbSet<Member> Members {get;set;}
         public DbSet<Group> Groups {get;set;}
          
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().ToTable("Member");
            modelBuilder.Entity<Group>().ToTable("Group");
           
            
            #region Configure the relationship between Group and Members
            modelBuilder.Entity<Group>().HasMany(g => g.Members)
              .WithOne(g => g.Group)
              .HasForeignKey(f => f.GroupID)
              .OnDelete(DeleteBehavior.ClientSetNull);
            #endregion
            
            #region generating sequence for group
            modelBuilder.HasSequence<int>("GroupID", schema: "shared");
            #endregion

            #region Composite key for Members
            modelBuilder.Entity<Member>()
            .HasKey(b => new { MemberID = b.MemberID, GroupID = b.GroupID });
            #endregion

        }
    }


}