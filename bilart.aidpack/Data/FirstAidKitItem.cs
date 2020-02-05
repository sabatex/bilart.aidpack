using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace bilart.aidpack.Data
{
    public class FirstAidKitItem
    {
        public Guid Id { get; set; }
        public Guid FirstAidKitId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Used",Description ="True if item unpack or used")]
        public bool IsUsed { get; set; }
        [Display(Name = "Expiry Date",Description = "Item expiry date")]
        public DateTime ExpiryDate { get; set; }
    }
}
