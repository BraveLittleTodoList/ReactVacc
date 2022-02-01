using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class VaccinationDBContext:DbContext
    {
        public VaccinationDBContext(DbContextOptions<VaccinationDBContext> options) : base(options)
        {

        }

        public DbSet<VRecipient> VRecipients { get; set; }

    }
}
