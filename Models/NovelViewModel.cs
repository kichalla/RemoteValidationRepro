using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Models
{
    public class NovelViewModel : BookViewModel
    {
        [Remote(action: "ValidateTitle", controller: "Books", AdditionalFields = nameof(Id))]
        public string Protagonist { get; set; }
    }
}
