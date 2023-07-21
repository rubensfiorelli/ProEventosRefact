using ProEventos.Domain.Notifications;

namespace ProEventos.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> LocalIsOk(string local, short maxLength, short minLength, string message, string propertyName)
        {
            if (string.IsNullOrEmpty(local) || (local.Length < minLength) || (local.Length > maxLength))

                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}
