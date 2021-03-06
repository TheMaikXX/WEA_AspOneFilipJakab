﻿using System;
using System.Collections.Generic;

namespace DataProviders.Models
{
    public partial class Transaction
    {
        public Transaction()
        {
            TransactionTags = new HashSet<TransactionTags>();
        }

        public Guid TransactionCode { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int? CategoryId { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }

        public TransactionCategory Category { get; set; }
        public User User { get; set; }
        public ICollection<TransactionTags> TransactionTags { get; set; }
    }
}
