﻿using DataConsole.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConsole.Context
{
    class CardapioContext : DbContext
    {
        public DbSet<Cardapio> Cardapios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=rod2;Password=123@Persist Security Info=True");
        }
    }
}
