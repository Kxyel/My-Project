using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Data.Models.ViewModels
{
    public class BookVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public string Genre { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public int PublisherId { get; set; }
        public int AuthorId { get; set; }
    }
}
