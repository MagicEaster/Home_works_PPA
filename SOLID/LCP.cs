using System;

namespace SOLID
{
    // не хороший вариант

    public abstract class FullStorage
    {
        public virtual string GetGoodsOrderDetails(int id)
        {
            return "Order";
        }

        public virtual string GetGoodsDetails(int id)
        {
            return "Goods";
        }
    }

    public class GoodsForOrder : FullStorage
    {
        public override string GetGoodsOrderDetails(int id)
        {
            return "Order";
        }

        public override string GetGoodsDetails(int id)
        {
            return "Goods";
        }
    }

    public class GoodsForOffice : FullStorage
    {
        // Т.к это товары для офиса, то для них нет инфы о заказах

        public override string GetGoodsOrderDetails(int id)
        {
            throw new NotImplementedException();
        }

        public override string GetGoodsDetails(int id)
        {
            return "Goods";
        }
    }

    // вариант получше

    public interface IGoods
    {
        string GetGoodsDetails (int goodsID);
    }

    public interface IOrder
    {
        string GetOrderDetails (int employeeId);
    }

    public class GoodsForOrders : IOrder, IGoods
    {
        public string GetOrderDetails(int employeeId)
        {
            return "Order";
        }

        public string GetGoodsDetails(int goodsID)
        {
            return "Goods";
        }
    }

    public class OfficeGoods : IGoods
    {
        public string GetGoodsDetails(int goodsID)
        {
            return "Goods";
        }
    }

}