using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Company_Manage
{
    public interface StoreAPI
    {
        object GetAllEmployee();
        object GetALLProduct();
    }
    public class ImplementClass : StoreAPI
    {
        public object GetAllEmployee()
        {
            return ElectroniceStore.Employees;
        }
        public object GetALLProduct()
        {
            return ElectroniceStore.Products;
        }
    }
}
