using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiNotas.Models
{
    public class NotesContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }
    }
}