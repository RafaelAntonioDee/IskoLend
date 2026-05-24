using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IskoLendModels;
using System.Threading.Tasks;

namespace IskoLendDataManagement
{
    public class CategoryDataServices
    {
        List<SupplyCategories> categories = new List<SupplyCategories>();
        public CategoryDataServices()
        {
            SupplyCategories category1 = new SupplyCategories { SupplyCategoryID = "C001", SupplyCategoryName = "Writing Materials" };
            SupplyCategories category2 = new SupplyCategories { SupplyCategoryID = "C002", SupplyCategoryName = "School Equipments" };
            SupplyCategories category3 = new SupplyCategories { SupplyCategoryID = "C003", SupplyCategoryName = "Art Supplies" };
            SupplyCategories category4 = new SupplyCategories { SupplyCategoryID = "C004", SupplyCategoryName = "Sports Equipment" };
            Add(category1);
            Add(category2);
            Add(category3);
            Add(category4);

        }
        public void Add(SupplyCategories category)
        {
            categories.Add(category);
        }
        public List<SupplyCategories> GetCategories()
        {
            return categories;
        }
        public SupplyCategories? GetCategoryByID(string categoryID)
        {
            return categories.FirstOrDefault(c => c.SupplyCategoryID == categoryID);
        }
    }
}
