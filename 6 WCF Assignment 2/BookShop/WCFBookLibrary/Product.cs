using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductList;

namespace WCFBookLibrary
{
    class Product : IProduct
    {

        List<string> result = new List<string>();
        

        public List<string> FindBooks(string search)
        {

         



            foreach (var item in list)
            {

                if (item.name == search)
                {
                    result.Add(item.name + "\n");
                }

            }


            return result;

        }
        
    }
}
