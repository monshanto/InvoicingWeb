﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesAppAPI.Entities
{
    public class InvoiceListViewModel
    {
        public long InvoiceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string InvoiceNumber { get; set; }
        public string PosoNumber { get; set; } 
        public string Date { get; set; } 
        public string DueDate { get; set; }
        public List<ItemViewModel> ItemList { get; set; }
        //public string ItemList { get; set; }
        public string Status { get; set; }  
        public string Type { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public bool IsSent { get; set; }
        public string UserId { get; set; }
        public string Notes { get; set; }
        public string TermsAndConditions { get; set; }
        //sent later 
        public string ConvertedDate { get; set; }
        public bool IsPaid { get; set; }
        public string PaymentDate { get; set; }
        public string PaymentMode { get; set; }

        public long CurrencyId { get; set; }
        public CurrencyViewModel CurrencyDetails { get; set; }
        public long CustomerId { get; set; }
        public CustomerViewModel CustomerDetails { get; set; }
    }
}
