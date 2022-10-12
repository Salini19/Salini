namespace Oct11_Core.Models
{
    public class OperationServices:ITransientService,IScopedService,ISingletonService
    {

        int id;
        int no;
        public OperationServices()
        {
            no = 1;
            Random random = new Random();
            id = random.Next(100);
        }
        public int GetProductId()
        {
            return id;
        }
        public int DefaultID()
        {
            return no;
        }
    }
}
