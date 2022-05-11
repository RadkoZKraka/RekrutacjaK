using System;

namespace RekrutacjaK.Data
{
    public class Product
    {
        public DateTime _date;
        public int _productionTime;
        public Category _category;
        public int _id;
        
        public Product(DateTime date,int productionTime, Category category, int id)
        {
            _date = date;
            _productionTime = productionTime;
            _category = category;
            _id = id;
        }

        public enum Category
        {
            Pluszaki,
            Klocki,
            Lalki  
        }
    }
}