using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Impl;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace DAL.Tests
{
    class TestStationRepository : BaseRepository <Station>
    {
        public TestStationRepository(DbContext context) : base(context)
        {

        }
    }
}
