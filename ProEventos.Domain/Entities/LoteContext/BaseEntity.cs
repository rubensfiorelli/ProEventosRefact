using ProEventos.Domain.Notifications;
using ProEventos.Domain.Validations.Contracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProEventos.Domain.Entities.LoteContext
{
    public abstract class BaseEntity : IValidations
    {
        private List<Notification> _notifications;

        protected BaseEntity(string descricao)
        {
            Id = Guid.NewGuid();
            Descricao = descricao;
        }

        [Key]
        public Guid Id { get; protected set; }

        private DateTime? _createAt;
        public DateTime? CreateAt
        {
            get { return _createAt; }
            set { _createAt = value == null ? DateTime.UtcNow : value; }
        }

        public DateTime? UpdateAt { get; set; }
        public string Descricao { get; private set; }

        [NotMapped]
        public IReadOnlyCollection<Notification> Notifications => _notifications;


        public void SetNotificationsList(List<Notification> notifications)
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
