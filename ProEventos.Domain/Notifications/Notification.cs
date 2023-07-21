using ProEventos.Domain.Notifications.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProEventos.Domain.Notifications
{
    [NotMapped]
    public class Notification : INotification
    {

        public Notification(string message, string propertyName)
        {
            Message = message;
            PropertyName = propertyName;
        }

        public string Message { get; private set; }
        public string PropertyName { get; private set; }
    }
}
