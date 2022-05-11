using System;
using System.Collections.Generic;
using System.Linq;

namespace RekrutacjaK.Data
{
    public class DataWrapper
    {
        private readonly MainView _mainView;

        public DataWrapper(MainView mainView)
        {
            _mainView = mainView;
            _mainView.productGridView.Columns.Add("dzien","Dzień");
            _mainView.productGridView.Columns.Add("czas","Czas w h");
            _mainView.productGridView.Columns.Add("category","Kategoria");
            _mainView.productGridView.Columns.Add("id","Identyfikator");
        }

        public void SimulateData(int n, bool lastThreeDays , DateTime startDate, DateTime endDate)
        {
            Random rng = new Random();
            
            if (n == 0)
            {
                n = rng.Next(5, 20);
            }

            if (lastThreeDays)
            {
                startDate = DateTime.Today.AddDays(-3);
                endDate = DateTime.Today;
            }
            List<Product> data = new List<Product>();
            DateTime date;
            int producTime;
            Product.Category category;
            var values = Enum.GetValues(typeof(Product.Category));
            var range = (endDate - startDate).Days;
            int productionTime = 0;
            var id = 101;
            var id2 = 101;
            for (int i = 0; i < n; i++)
            {
                date = startDate.AddDays(rng.Next(range));
                producTime = rng.Next(3, 8);
                category = (Product.Category) values.GetValue(rng.Next(values.Length));
                
                var matches = data.Where(x => x._date == date && x._category == category).ToArray();
                
                if (matches.Length == 0)
                {
                    id = 101;
                    data.Add(new Product(date,producTime,category, id));
                }
                else
                {
                    id = matches.Last()._id + 1;
                    data.Add(new Product(date,producTime,category, id));
                }
                
            }
            AddDataToTable(data);
        }

        public void AddDataToTable(List<Product> data)
        {
            foreach (var product in data)
            {
                string[] row = new string[]
                {
                    product._date.ToString(),
                    product._productionTime.ToString(), 
                    product._category.ToString(),
                    product._id.ToString()
                };
                _mainView.productGridView.Rows.Add(row);
            }
        }
    }
}