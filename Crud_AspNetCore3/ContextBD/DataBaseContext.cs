using Crud_AspNetCore3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_AspNetCore3.ContextBD
{
    public class DataBaseContext: DbContext
    {

        public DbSet<Produto> Produtos { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {

        }
    }
}
