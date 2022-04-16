namespace Workshop1.Contracts.Interface
{
    /// <summary>
    /// Defines the <see cref="IFileManager" />.
    /// </summary>
    public interface IFileManager
    {
        /// <summary>
        /// The Write.
        /// </summary>
        void Write(string entity);

        /// <summary>
        /// The Read.
        /// </summary>
        /// <returns></returns>
        string Read();
    }
}
