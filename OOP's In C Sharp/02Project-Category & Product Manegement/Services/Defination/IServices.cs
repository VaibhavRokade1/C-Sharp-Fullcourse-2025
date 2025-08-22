using OOPsInCSharp._02Project_Category___Product_Manegement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsInCSharp._02Project_Category___Product_Manegement.Services.Defination
{
    public interface ICategory
    {
       void AddCategory(Category category);
       void UpdateCategory(int id ,Category category);
       void RemoveCategory(int id);
    }

    public interface IProduct 
    {
        void AddProduct(Product product);
        void UpdateProduct(int id ,Product product);
        void RemoveProduct(int id);
        void ShowProducts();
    }
}
