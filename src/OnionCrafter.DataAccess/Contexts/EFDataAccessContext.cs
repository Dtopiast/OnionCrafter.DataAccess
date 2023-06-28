using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using OnionCrafter.Base.Entities;
using OnionCrafter.Base.Exceptions;
using OnionCrafter.DataAccess.Context;
using OnionCrafter.DataAccess.UnitOfWork;

namespace OnionCrafter.DataAccess.Contexts
{
    /// <summary>
    /// Represents an EF Data Access Context that serves as a unit of work and provides access to the underlying database.
    /// </summary>
    public class EFDataAccessContext :
        DbContext,
        IDataAccessContext,
        IUnitOfWork
    {
        /// <inheritdoc/>

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        /// <inheritdoc/>

        public new DbSet<TEntity> Set<TEntity>() where TEntity : class, IBaseEntity
        {
            return base.Set<TEntity>();
        }

        /// <inheritdoc/>

        public new EntityEntry<TEntity> Update<TEntity>(TEntity entity) where TEntity : class, IBaseEntity
        {
            return base.Update<TEntity>(entity);
        }

        /// <inheritdoc/>

        public new void UpdateRange(params object[] entities)
        {
            if (entities.Any(entity => !(entity is IBaseEntity)))
                throw new InvalidEntityCastException();
            base.UpdateRange(entities);
        }

        /// <inheritdoc/>

        public new EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : class, IBaseEntity
        {
            return base.Remove<TEntity>(entity);
        }

        /// <inheritdoc/>
        public new async ValueTask<EntityEntry<TEntity>> AddAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default) where TEntity : class, IBaseEntity
        {
            return await base.AddAsync<TEntity>(entity, cancellationToken);
        }

        /// <inheritdoc/>

        public void BeginTransaction()
        {
            base.Database.BeginTransaction();
        }

        /// <inheritdoc/>

        public void CommitTransaction()
        {
            base.Database.CommitTransaction();
        }

        /// <inheritdoc/>

        public void RollbackTransaction()
        {
            base.Database.RollbackTransaction();
        }
    }
}