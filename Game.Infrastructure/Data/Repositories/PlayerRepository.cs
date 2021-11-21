﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Infrastructure.Data.Repositories
{
    public class PlayerRepository : BaseRepository
    {
        public PlayerRepository(DbContextOptions<BaseRepository> options) : base(options)
        {
        }
    }
}
