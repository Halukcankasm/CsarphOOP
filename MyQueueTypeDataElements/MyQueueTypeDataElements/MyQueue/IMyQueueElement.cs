namespace MyQueueType
{
    public interface IMyQueueElement
    {
        void Clear();
        object[] Clone();
        bool Contains(object obj);
        object IndexOf(int index);
        void Resize();
        object Peek();
    }
}