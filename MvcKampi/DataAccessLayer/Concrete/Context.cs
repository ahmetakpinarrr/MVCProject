﻿using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
   public class Context: DbContext
    {
        public DbSet<About> Abouts { get; set; } // about ve abouts arasındaki fark? About projenin içindeki sınıfın ismi.Abouts ise SQL de 
        //veri tabanına yansıyacak tablodur.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
