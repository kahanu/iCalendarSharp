﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DemoMvc.Models
{
    public class MessageModel
    {
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage="Subject is required.")]
        public string Subject { get; set; }

        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

        public string Location { get; set; }

        [Required(ErrorMessage="Recipient Email is required")]
        [DisplayName("Recipient Email")]
        public string Email { get; set; }

        public string FileName { get; set; }
    }
}