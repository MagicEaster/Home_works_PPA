namespace SOLID
{
    //в этом интерфейсе несколько ответственностей

    public interface IGoodsISP
    {
        bool AddGoodsDetails();
        bool ShowGoodsDetails(int orderId);
    }

     // разбиение на два интерфейса

    public interface IOperationAdd
    {
        bool AddGoodsDetails();
    }

    public interface IOperationGet
    {
        bool ShowGoodsDetails(int orderId);
    }

}