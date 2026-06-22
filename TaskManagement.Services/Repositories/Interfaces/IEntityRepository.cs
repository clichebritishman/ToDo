namespace TaskManagement.Services.Repositories.Interfaces;

public interface IEntityRepository<TEntity> where TEntity : class
{
    public Task<TEntity> Create(TEntity entity);

    public void Update(TEntity entity);

    Task<List<TEntity>> GetAll();
}