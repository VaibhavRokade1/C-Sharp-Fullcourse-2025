using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsInCSharp._02Project_Category___Product_Manegement.Models
{
    public class Product
    {
        private int Pid;
        private string PName;
        private double Pprice;
        public Category category { get; set; }

        public int GetPid() =>this.Pid;
        public string GetPName() =>this.PName;
        public double  GetPprice() =>this.Pprice;
    }
}
