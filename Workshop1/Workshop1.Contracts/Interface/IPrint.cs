namespace Workshop1.Contracts.Interface
{
    /// <summary>
    /// Defines the <see cref="IPrint" />.
    /// </summary>
    public interface IPrint
    {
        /// <summary>
        /// The Print.
        /// </summary>
        /// <param name="name">The Name<see cref="string"/>.</param>
        /// <param name="age">The Age<see cref="string"/>.</param>
        /// <param name="address">The Address<see cref="string"/>.</param>
        /// <param name="phone">The Phone<see cref="string"/>.</param>
        string PrintCustomer(string name, string age, string address, string phone);
    }
}
