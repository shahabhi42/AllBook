using System;
using System.ComponentModel.DataAnnotations;

namespace NewFakeBookMarkIII.Models
{
    public class Friend
    {
        [Key]
        public int FriendID { get; set; }
        public string FriendName { get; set; }
        public DateTime DataFriended { get; set; }
    }
}