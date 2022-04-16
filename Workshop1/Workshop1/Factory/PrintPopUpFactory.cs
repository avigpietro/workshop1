using Workshop1.Interfaces;

namespace Workshop1.Factory
{
    /// <inheritdoc/>
    public class PrintPopUpFactory : IPrintPopUpFactory
    {
        /// <inheritdoc/>
        public PrintPopUp Create()
        {
            return new PrintPopUp();
        }
    }
}
