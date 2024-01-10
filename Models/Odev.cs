using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebFinal.ViewModels;

namespace WebFinal.Models
{
    public class Odev
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string CategoryName { get; set; }
        public int CategoryId { get; set; }




    }
}