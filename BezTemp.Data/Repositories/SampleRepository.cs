using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BezTemp.Data.IRepositories;
using BezTemp.Data.Models;
using BezTemp.Data;
using BezTemp.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BezTemp.Data.Repositories
{
    public class SampleRepository<TModel> : BaseRepository<Sample>, ISampleRepository
    {
        public SampleRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}