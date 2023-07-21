using ProEventos.Domain.Notifications;
using ProEventos.Domain.Validations.Contracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProEventos.Domain.Entities.EventoContext
{
    public abstract class BaseEntity : IValidations
    {

        private List<Notification> _notifications;

        [Key]
        public Guid Id { get; protected set; }

        private DateTime? _createAt;

        protected BaseEntity(DateTime? createAt, DateTime? updateAt, DateTime data, string descricao)
        {
            Id = Guid.NewGuid();
            CreateAt = createAt;
            CreateAt = createAt;
            UpdateAt = updateAt;
            Data = data;
            Descricao = descricao;
        }

        public DateTime? CreateAt
        {
            get { return _createAt; }
            set { _createAt = value == null ? DateTime.UtcNow : value; }
        }

        public DateTime? UpdateAt { get; set; }
        public DateTime Data { get; private set; }
        public string Descricao { get; private set; }

        [NotMapped]
        public IReadOnlyCollection<Notification> Notifications => _notifications;

        protected void SetNotificationsList(List<Notification> notifications)
        {
            _notifications = notifications;
        }

        public virtual void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public abstract bool Validation();

    }
}
