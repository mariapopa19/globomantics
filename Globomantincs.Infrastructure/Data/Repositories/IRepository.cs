﻿namespace Globomantincs.Infrastructure.Data.Repositories;

public interface IRepository<T>
{
    Task<T> GetAsync(Guid id);
    Task<T> FindByAsync(string value);
    Task<IEnumerable<T>> AllAsync();
    Task AddAsync(T Item);
    Task SaveChangesAsync();
}