using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Asm_PIIT_PhamDucThang_T2009M.Data
{
    public class Asm_PIIT_PhamDucThang_T2009MContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Asm_PIIT_PhamDucThang_T2009MContext() : base("name=Asm_PIIT_PhamDucThang_T2009MContext")
        {
        }

        public System.Data.Entity.DbSet<Asm_PIIT_PhamDucThang_T2009M.Models.Market> Markets { get; set; }

        public System.Data.Entity.DbSet<Asm_PIIT_PhamDucThang_T2009M.Models.Coin> Coins { get; set; }
    }
}
