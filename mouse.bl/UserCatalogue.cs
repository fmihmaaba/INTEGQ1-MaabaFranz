using System;
using System.Collections.Generic;
using System.Text;

namespace mouse.bl
{
    public class UserCatalogue
    {
        public void Catalogue()
        {
            ManageProduct productServices = new ManageProduct();

        START:
            Console.WriteLine("(1) Product View");
            Console.WriteLine("(2) Product Add");
            Console.WriteLine("(3) Product Removed");
            Console.WriteLine("(4) exit           ");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    productServices.ProductView();
                    goto START;
                case 2:
                    productServices.ProductAdd();
                    goto START;
                case 3:
                    productServices.ProductRemoved();
                    goto START;

                default:
                    break;
            }

        }
    }
}
