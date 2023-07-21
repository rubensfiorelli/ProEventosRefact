using ProEventos.Domain.Notifications;

namespace ProEventos.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> FirstNameIsOk(string nome, short maxLength, short minLength, string message, string propertyName)
        {
            if (string.IsNullOrEmpty(nome) || (nome.Length < minLength) || (nome.Length > maxLength))

                AddNotification(new Notification(message, propertyName));

            return this;
        }

        public ContractValidations<T> LastNameIsOk(string sobreName, short maxLength, short minLength, string message, string propertyName)
        {
            if (string.IsNullOrEmpty(sobreName) || (sobreName.Length < minLength) || (sobreName.Length > maxLength))

                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}
