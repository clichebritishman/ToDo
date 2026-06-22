using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TaskManagement.Services.Repositories.Interfaces;


namespace TaskManagement.Services.Repositories;

public class EntityRepository<TEntity>(TaskManagementDatabaseContext taskManagementDatabaseContext) :
    IEntityRepository<TEntity> where TEntity : class
{
    public async Task<TEntity> Create(TEntity entity)
    {
        EntityEntry<TEntity> addedEntity = await taskManagementDatabaseContext
             .Set<TEntity>()
             .AddAsync(entity);

        await taskManagementDatabaseContext.SaveChangesAsync();

        return addedEntity.Entity;
    }

    public async Task<List<TEntity>> GetAll()
        => await taskManagementDatabaseContext
            .Set<TEntity>()
            .ToListAsync();

    public void Update(TEntity entity) 
        => taskManagementDatabaseContext
            .Set<TEntity>()
            .Update(entity);
}
