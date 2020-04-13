namespace Neon.FinanceBridge.Common.Domain.Events
{
    public interface IHandler<in T> where T : Message
    {
        void Handle(T message);
    }
}