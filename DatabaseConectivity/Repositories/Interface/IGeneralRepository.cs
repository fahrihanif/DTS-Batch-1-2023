namespace DatabaseConnectivity.Repositories.Interface;
public interface IGeneralRepository<TEntity>
{
    List<TEntity> GetAll();
    TEntity GetById(int id);
    int Insert(TEntity entity);
    int Update(TEntity entity);
    int Delete(int id);
}
