﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Budgeting_App.Models.Entities
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        //Relational Props
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
