using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public List<InvoiceItem> Items { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public string Status { get; set; } // Paid, Unpaid, Partial

        public Invoice()
        {
            Items = new List<InvoiceItem>();
        }

    }
    public class InvoiceItem
    {
        public int TreatmentId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}

