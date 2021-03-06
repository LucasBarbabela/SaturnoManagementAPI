﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaturnoManagementAPI.DTO;
using SaturnoManagementAPI.Tabelas;

namespace SaturnoManagementAPI.Configuração
{
    public class ERPContext : DbContext
    {

        public ERPContext(DbContextOptions<ERPContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Transacao> Transacoes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }




    }
}
