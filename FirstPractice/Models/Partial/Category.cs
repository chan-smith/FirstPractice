using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstPractice.Models
{
    [MetadataType(typeof(CategoryMetadata))]
    public partial class Category
    {
        public class CategoryMetadata
        {
            public int CategoryID { get; set; }

            [Display(Name ="分類名稱")]
            [Required(ErrorMessage ="不可空白")]
            public string CategoryName { get; set; }

            [Display(Name = "分類描述")]
            [Required(ErrorMessage = "不可空白")]
            public string Description { get; set; }

            public byte[] Picture { get; set; }
        }

    }
}