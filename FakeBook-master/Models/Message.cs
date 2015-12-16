using System;
using System.ComponentModel.DataAnnotations;

namespace NewFakeBookMarkIII.Models
{
    public class Message
    {
        [Key]
        public int ThreadID { get; set; }
        public string Reciepient { get; set; }
        public string MessageText { get; set; }
        public DateTime DateSent { get; set; }
        public bool Status { get; set; }
        public virtual ApplicationUser Member { get; set; }
    }
}