namespace Bookify.Domain.Abstractions;
public abstract class Entity
{
    private readonly List<IDomainEvent> _doaminEvents = new();

    protected Entity(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; init; }

    public IReadOnlyList<IDomainEvent> GetDomainEvents => _doaminEvents.ToList();

    public void ClearDomainEvents() => _doaminEvents.Clear();

    protected void RaiseDomainEvent(IDomainEvent domainEvent) => _doaminEvents.Add(domainEvent);
}
