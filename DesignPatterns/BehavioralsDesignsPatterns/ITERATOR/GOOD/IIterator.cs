namespace DESIGNPATTERNS.BehavioralsDesignsPatterns.Iterator.GOOD
{

    public interface IIterator<T>
    {
        void Next();
        bool HasNext();
        T Current();
    }
}