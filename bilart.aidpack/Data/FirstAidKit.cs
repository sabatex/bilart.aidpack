using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace bilart.aidpack.Data
{
    public class FirstAidKit
    {
        public Guid Id { get; set; }
        /// <summary>
        /// GUID or Normalized Email adress
        /// </summary>
        public string UserId { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Hint by days")]
        public int HintByDays { get; set; }
    }
}

