using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GroupDotnetAPI.Models 
{
    [Serializable]
    public class Group
    {
        public Group()
        {
            this.Members = new List<Member>();
        }
         [Key]
         public int GroupID {get; set;}

         [Required]
         [StringLength(50, MinimumLength = 2)]
         public string GroupName {get; set;}

         [StringLength(50, MinimumLength = 2)]
         [Column("Type")]
         [Display(Name = "Type")]
         public string Attr1 {get; set;}

         [StringLength(50, MinimumLength = 2)]
         [Column("Location")]
         [Display(Name = "Location")]
         public string Attr2 {get; set;}
         
         //navigation property
          //[JsonIgnore] // 
         public ICollection<Member>Members {get; set;}
   
    }

}