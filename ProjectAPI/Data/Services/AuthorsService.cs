using ProjectAPI.Data.Models;
using ProjectAPI.Data.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Data.Services
{
    public class AuthorsService
    {
        private AppDbContext _context;
        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }
        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
              FullName = author.FullName
            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }

    }
}



