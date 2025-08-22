using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsInCSharp._02Project_Category___Product_Manegement.Models
{
    public class Category
    {
        private int CatId;
        private string CatName;
        private string CatDesciption;

        public void SetCatId(int id){
            this.CatId = id;
        }
        public void SetCatName(string Name ) {
            this.CatName = Name;
        }
        public void SetCatDesciption(string CatDesciption) {
            this.CatDesciption = CatDesciption;
        }

        public int GetCatId() => this.CatId;
        public string GetCatName() => this.CatName;
        public string GetDescription() => this.CatDesciption;

    }
}
