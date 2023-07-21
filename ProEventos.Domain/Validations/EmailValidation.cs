using ProEventos.Domain.Notifications;
using System.Text.RegularExpressions;

namespace ProEventos.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> EmailIsOk(string email, string message, string propertyName)
        {
            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"))

                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}
