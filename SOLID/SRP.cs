namespace SOLID
{
    //плохой пример
    public class Storage
    {
        public int ID { get; set; }
        public string GoodsName { get; set; }
        public int Quantity { get; set; }
        /// <summary>
        /// Данный метод добавляет в БД новый товар
        /// </summary>
        /// <param name="storage">Объект для вставки</param>
        /// <returns>Результат вставки новых данных</returns>
        public bool Add(Storage storage)
        {
            // Вставить данные товара в таблицу БД
            return true;
        }

        /// <summary>
        /// товарная-накладная
        /// </summary>
        public void GenerateConsignmentNote(Storage storage)
        {
            // Генерация товарной-накладной
        }
    }

    //правильный вариант
    public class StorageNew
    {
        public int ID { get; set; }
        public string GoodsName { get; set; }
        public int Quantity { get; set; }
        /// <summary>
        /// Данный метод добавляет в БД новый товар
        /// </summary>
        /// <param name="storage">Объект для вставки</param>
        /// <returns>Результат вставки новых данных</returns>
        public bool Add(StorageNew storage)
        {
            // Вставить данные товара в таблицу БД
            return true;
        }
    }

    public class StorageReportNew
    {
        /// <summary>
        /// товарная-накладная
        /// </summary>
        public void GenerateConsignmentNote(Storage storage)
        {
            // Генерация товарной-накладной
        }
    }
}
    
    