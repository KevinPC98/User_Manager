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
    class NacionesContext : DbContext
    {
        public NacionesContext() : base("UsuarioBEContext")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Nacionalidad> entity { set; get; }
    }
}
