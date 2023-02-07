using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USER.BE;

namespace USER.DAC
{
    public class UsuarioBEContext: DbContext
    {
        public UsuarioBEContext() : base("UsuarioBEContext")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<UsuarioBE> entity { set; get; }
    }
}
