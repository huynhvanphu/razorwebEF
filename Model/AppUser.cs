using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace razorwebEF.Model
{
    public class AppUser : IdentityUser
    {
        //Khai bao san, de sau nay bo sung (neu can)
        [Column(TypeName = "nvarchar")]
        [StringLength(500)]
        public string HomeAddress { get; set; }
    }
}
