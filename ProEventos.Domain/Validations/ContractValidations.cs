using ProEventos.Domain.Notifications;
using ProEventos.Domain.Validations.Contracts;

namespace ProEventos.Domain.Validations
{
    public partial class ContractValidations<T> where T : IContract
    {
        private List<Notification> _notifications;

        public ContractValidations()
        {
            _notifications = new List<Notification>();
        }

        public IReadOnlyCollection<Notification> Notifications => _notifications;

        public void AddNotification(Notification notification)
        {
            _notifications.Add(notification);
        }
        public bool IsValid()
        {
            return _notifications.Any();
        }
    }
}
