using System;
using System.ComponentModel.DataAnnotations;

namespace NewFakeBookMarkIII.Models
{
    public class Photo
    {
        [Key]
        public int FileID { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public DateTime DatePhotoAdded { get; set; }
        public bool HasProfilePicture { get; set; }
    }
}