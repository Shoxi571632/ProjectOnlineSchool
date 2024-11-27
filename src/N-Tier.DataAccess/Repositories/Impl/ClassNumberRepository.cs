﻿using N_Tier.Core.Entities;
using N_Tier.DataAccess.Persistence;

namespace N_Tier.DataAccess.Repositories.Impl;
public class ClassNumberRepository : BaseRepository<ClassNumber> , IClassNumberRepository
{
    public ClassNumberRepository(DatabaseContext databaseContext) : base(databaseContext)
    {
        
    }
}