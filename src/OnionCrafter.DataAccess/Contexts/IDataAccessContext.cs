using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using OnionCrafter.Base.Entities;

namespace OnionCrafter.DataAccess.Context
{
    /// <summary>
    /// Represents a data access context that provides access to the underlying data store.
    /// </summary>
    public interface IDataAccessContext :
        IBaseDataAccessContext,
        IDisposable,
        IAsyncDisposable
    {
        /// <summary>
        /// Gets a DbSet for the specified entity type.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <returns>A DbSet for the specified entity type.</returns>
        public DbSet<TEntity> Set<TEntity>() where TEntity : class, IBaseEntity;

        /// <summary>
        /// Asynchronously saves all changes made in this context to the underlying database.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the number of affected rows.</returns>
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified entity in the context.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entity">The entity to be updated.</param>
        /// <returns>An EntityEntry representing the updated entity.</returns>
        public EntityEntry<TEntity> Update<TEntity>(TEntity entity) where TEntity : class, IBaseEntity;

        /// <summary>
        /// Updates a range of entities in the context.
        /// </summary>
        /// <param name="entities">The entities to be updated.</param>
        public void UpdateRange(params object[] entities);

        /// <summary>
        /// Removes the specified entity from the context.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entity">The entity to be removed.</param>
        /// <returns>An EntityEntry representing the removed entity.</returns>
        public EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : class, IBaseEntity;

        /// <summary>
        /// Asynchronously adds the specified entity to the context.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entity">The entity to be added.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A ValueTask representing the asynchronous operation. The ValueTask result contains the EntityEntry representing the added entity.</returns>
        public ValueTask<EntityEntry<TEntity>> AddAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default) where TEntity : class, IBaseEntity;
    }
}