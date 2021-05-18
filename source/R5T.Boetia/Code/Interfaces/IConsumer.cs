using System;
using System.Threading.Tasks;


namespace R5T.Boetia
{
    public interface IConsumer<T>
    {
        Task Consume(T value);
    }
}
