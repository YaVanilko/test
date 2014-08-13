using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class PartsShop
    {
        private static readonly PartsShop shopInstance = new PartsShop();

        private List<Part> listOfParts;

        public Part SupplyPart(string model, string brand)
        {
            return listOfParts.Find(x => (x.Brand == brand && x.Model == model));
        }

        public void ObtainPart(Part part)
        {
            listOfParts.Add(part);
        }

        public static PartsShop ShopInstance
        {
            get { return shopInstance; }
        }

        /// Приватный конструктор 
        private PartsShop() 
        {
            listOfParts = new List<Part>();
        }
    }
}
