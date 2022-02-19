namespace Cola.BackgroundTasks.Queue
{
    public interface IBackgroundQueue<T>
    {     
        void Enqueue(T item);       
        T Dequeue();
    }
}
