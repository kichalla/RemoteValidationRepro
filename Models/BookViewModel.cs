using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class BookViewModel
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public int ISBN { get; set; }
    }
}
