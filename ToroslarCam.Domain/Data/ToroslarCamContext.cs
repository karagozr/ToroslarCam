using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToroslarCam.Domain.Entities;
using ToroslarCam.Domain.Helpers;

namespace ToroslarCam.Domain.Data
{
    public class ToroslarCamContext : DbContext
    {

        private string _connectionString;
        public ToroslarCamContext()
        {
            _connectionString=SqliteDbHelper.GetConnection("TOROSLAR_CAM_VERITABANI");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionString);
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
