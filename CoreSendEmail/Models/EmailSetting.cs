using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSendEmail.Models
{
    public class EmailSetting
    {
        public long Id { get; set; }

        [Required]
        public string senderName { get; set; }

        [Required]
        [EmailAddress]
        public string recipientName { get; set; }

        [Required]
        [EmailAddress]
        public string recipientMail { get; set; }

        [Required]
        public string subject { get; set; }

        [Required]
        public string content { get; set; }

        [Required]
        [EmailAddress]
        public string userName { get; set; }

        [Required]
        public string password { get; set; }
    }
}
