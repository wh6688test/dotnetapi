using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace GroupDotnetAPI.Models 
{
    public class Member
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
         public int MemberID {get; set;}

        //foreign key
         [ForeignKey("GroupID")]
         public int GroupID {get;set;}

         [StringLength(50, MinimumLength = 2)]
         public string MemberName {get; set;}

         [Range(1, 6)]
         public int Rating  {get; set;}
         
         public Group Group {get;set;}
        
    }
}