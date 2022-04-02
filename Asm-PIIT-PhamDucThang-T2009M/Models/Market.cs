using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asm_PIIT_PhamDucThang_T2009M.Models
{
    public class Market
    {
        public Market()
        {
            Coins = new HashSet<Coin>();
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Description")]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<Coin> Coins { get; set; }
    }
}