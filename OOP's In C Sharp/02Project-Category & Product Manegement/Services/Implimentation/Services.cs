using OOPsInCSharp._02Project_Category___Product_Manegement.Models;
using OOPsInCSharp._02Project_Category___Product_Manegement.Services.Defination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsInCSharp._02Project_Category___Product_Manegement.Services.Implimentation
{
    public class Services : ICategory , IProduct
    {
        Category[] AllCategory = new Category[10];
        public static int catIndex = 0;

        Product[] Allproduct = new Product[10];
        public static int prodIndex = 0;

        // Add New Category
        public void AddCategory(Category category)
        {
            // Handle exception using try , catch() block
            try
            {
                AllCategory[catIndex++] = category;
            }
            catch (NullReferenceException ex) {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch(Exception ex) {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void AddProduct(Product product)
        {
            
            // Handle exception using try , catch() block
            try
            {
              
                foreach (var item in Allproduct)
                {
                    if ( item.GetPid() != null && item.GetPid() != product.GetPid())
                    {
                        this.Allproduct[prodIndex++] = product;
                        break;
                    }
                    else {
                        Console.WriteLine("Product already exist...!!!");
                    }
                    
                }
            }
            catch (NullReferenceException ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void RemoveCategory(int id)
        {
            try { 
             AllCategory = AllCategory.Where(item => item.GetCatId() != null && item.GetCatId() != id).ToArray();
            } catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void RemoveProduct(int id)
        {
            Allproduct = Allproduct.Where(item=> item.GetPid() != null && item.GetPid() != id).ToArray();
        }

        public void UpdateCategory(int id, Category category)
        {
            try 
            {


                for (int i=0;i<AllCategory.GetLength(0);i++)
                {
                    if (AllCategory[i].GetCatId() == id) 
                    {
                        AllCategory[i] = category;
                        break;
                    }
                }

                for (int j = 0; j < Allproduct.GetLength(0); j++)
                {
                    if (Allproduct[j].category.GetCatId() == id)
                    {
                        Allproduct[j].category = category;
                    }
                }



            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void UpdateProduct(int id, Product product)
        {
            try
            {
                for (int i = 0; i < Allproduct.GetLength(0); i++)
                {
                    if (Allproduct[i].GetPid() == id)
                    {
                        Allproduct[i] = product;
                        break;
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
       
        public void ShowProducts()
        {
            foreach (var item in Allproduct)
            {
                Console.WriteLine(item);
            }
        }
    }
}
