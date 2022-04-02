using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Asm_PIIT_PhamDucThang_T2009M.Models
{
    public class Coin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int MarketId;        
        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter base asset")]
        public string BaseAsset { get; set; }
        [Required(ErrorMessage = "Please enter quote asset")]
        public string QuoteAsset { get; set; }
        [Required(ErrorMessage = "Please enter last price")]
        public double LastPrice { get; set; }
        [Required(ErrorMessage = "Please enter volumn24h")]
        public double Volumn24h { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Status { get; set; }
        public virtual Market Market { get; set; }


    }
}