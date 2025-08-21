using Microsoft.EntityFrameworkCore;
using roosapp.models;

namespace roosapp.data;

public class DataService
{
    private readonly DataContext context;

    public DataService(DataContext dataContext)
    {
        this.context = dataContext;
    }

    public void Save<T>(T entity) where T : class
    {
        context.Set<T>().Add(entity);
        context.SaveChanges();
    }

    public T? GetById<T>(Guid id) where T : class
    {
        return context.Set<T>().Find(id);
    }

    public List<T> GetAll<T>() where T : class
    {
        return context.Set<T>().ToList();
    }
}
