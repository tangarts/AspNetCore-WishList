using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace WishList.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
    }
}
