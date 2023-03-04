namespace SOLID
{
    //плохой пример открытости\закрытости
    public class StorageReport
    {
        // <summary>
        /// Тип отчета
        /// </summary>
        public string TypeReport { get; set; }

        /// <summary>
        /// товарная-накладная
        /// </summary>
        public void GenerateConsignmentNote(Storage storage)
        {
                    
            if (TypeReport == "CSV")
            {
                // Генерация товарной-накладной в формате CSV
            }

            if (TypeReport == "PDF")
            {
                // Генерация товарной-накладной в формате PDF
            }
        }
    }

    // вариация корректной реализации

    public class IStorageReport
    {
        /// <summary>
        /// Метод для создания товарной-накладной
        /// </summary>
        public virtual void GenerateConsignmentNote(Storage storage)
        {
            // Базовая реализация, которую нельзя модифицировать
        }
    }

    public class StorageCSVReport : IStorageReport
    {
        public override void GenerateConsignmentNote(Storage storage)
        {
            // Генерация отчета в формате CSV
        }
    }

    public class StoragePDFReport : IStorageReport
    {
        public override void GenerateConsignmentNote(Storage storage)
        {
            // Генерация отчета в формате PDF
        }
    }

}