namespace Tienda.Soporte.SharedKernel.Core
{
    public interface IBusinessRule
    {
        bool IsBroken();

        string Message { get; }
    }
}