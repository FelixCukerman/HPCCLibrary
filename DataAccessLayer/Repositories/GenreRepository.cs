﻿using DataAccessLayer.Interfaces;
using EntitiesLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenreRepository : GenericRepository<Genre>, IGenreRepository
    {
        public GenreRepository(LibraryContext context) : base(context)
        {
        }

        public async Task<Genre> GetGenreByTitle(string title)
        {
            Genre result = await _data.Genres.FirstOrDefaultAsync(genre => genre.Title == title);

            return result;
        }
    }
}
