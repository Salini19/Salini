namespace Oct11_Core.Models
{
    public interface ITransientService
    {
        int GetProductId();

    }

    public interface IScopedService
    {
        int GetProductId();
    }
    public interface ISingletonService
    {
        int DefaultID();

    }
}
