namespace Workshop1.Contracts.Interface
{
    /// <summary>
    /// Defines the <see cref="ICustomerFacade" />.
    /// </summary>
    public interface ICustomerFacade
    {
        /// <summary>
        /// The SaveData.
        /// </summary>
        void SaveData(string address, string age, string creditCardNumber, string gender, string id,
            string lastName, string name, string phoneNumber);

        /// <summary>
        /// The ShowData
        /// </summary>
        void ShowData();
    }
}
