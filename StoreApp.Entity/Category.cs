using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Entity
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //Category-Product => 1'e Çok İlişki
        //1
        public List<Product> Products { get; set; }
    }
}
