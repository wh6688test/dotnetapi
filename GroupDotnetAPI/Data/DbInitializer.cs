using GroupDotnetAPI.Models;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace GroupDotnetAPI.Data
{
    public static class DbInitializer
    {
        public static void Initialize(GroupContext context)
        {
               //context.Configuration.ProxyCreationEnabled = true; 
               //context.Configuration.LazyLoadingEnabled = true;
               //context.Configuration.AutoDetectChangesEnabled = true;

               //context.Database.EnsureCreated();

                if (context.Groups.Any())
                 {
                     return;
                     //return context.Groups.Include(g => g.Members).AsSingleQuery().ToList();
                 }

                var groups = new Group[]
                 {
                     new Group {GroupName="DummyGroup", Attr1="Dummy1", Attr2="Dummy City"}

                 };

                 context.Groups.AddRange(groups);
                 context.SaveChanges();


                var members = new Member[] 
                 {
                     new Member{
                           GroupID = groups.Single(s => s.GroupName=="DummyGroup").GroupID,
                           MemberID=1,
                           MemberName= "Joe Doe", Rating=4
                     },
                     new Member{  
                            GroupID = groups.Single(s => s.GroupName=="DummyGroup").GroupID, 
                            MemberID=2, 
                            MemberName = "Jane Smith", Rating=5
                     }
                 };

                 foreach (Member m in members) 
                 {
                    var memberInDB = context.Members.Where (
                        g =>  g.Group.GroupID == m.GroupID
                    ).SingleOrDefault();
            
                    if (memberInDB == null)
                    {
                        context.Members.Add(m);
                    }
                 }
                 context.SaveChanges();

            }
    }
}