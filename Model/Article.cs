using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace razorwebEF.Model
{
    public class Article
    {
        [Key]
        public int Id { set; get; }

        [StringLength(255)]
        [Required]
        [Column(TypeName = "nvarchar")]
        public string Title { set; get; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime CreatedDated { set; get; }

        [Column(TypeName = "ntext")]
        public string Content { set; get; }
    }
}
