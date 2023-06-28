namespace OnionCrafter.DataAccess.UnitOfWork
{
    /// <summary>
    /// Defines the contract for a unit of work, which manages transactions.
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Begins a new transaction.
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// Commits the current transaction.
        /// </summary>
        void CommitTransaction();

        /// <summary>
        /// Rolls back the current transaction.
        /// </summary>
        void RollbackTransaction();
    }
}