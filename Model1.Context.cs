﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cint
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProgressMEntities : DbContext
    {
        public ProgressMEntities()
            : base("name=ProgressMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Водители> Водители { get; set; }
        public virtual DbSet<Маршруты> Маршруты { get; set; }
        public virtual DbSet<Операторы> Операторы { get; set; }
        public virtual DbSet<Статус> Статус { get; set; }
        public virtual DbSet<Типы_траспорта> Типы_траспорта { get; set; }
        public virtual DbSet<ТипыГрузов> ТипыГрузов { get; set; }
        public virtual DbSet<Транспорт> Транспорт { get; set; }
        public virtual DbSet<Учёт> Учёт { get; set; }
    }
}