using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Windows.ApplicationModel.Store;
using System.Windows.Navigation;
using System.Windows;

namespace MillionaireEntertainment
{
    public class Products
    {
        private static readonly string PRODUCT_SIX = "productID";
        private const int PRODUCT_SIX_AMOUNT = 1000000;

        private static readonly string PRODUCT_FIVE = "productID";
        private const int PRODUCT_FIVE_AMOUNT = 425000;

        private static readonly string PRODUCT_FOUR = "productID";
        private const int PRODUCT_FOUR_AMOUNT = 165000;

        private static readonly string PRODUCT_THREE = "productID";
        private const int PRODUCT_THREE_AMOUNT = 75000;

        private static readonly string PRODUCT_TWO = "productID";
        private const int PRODUCT_TWO_AMOUNT = 37500;

        private static readonly string PRODUCT_ONE = "productID";
        private const int PRODUCT_ONE_AMOUNT = 15000; 



        static void PurchaseChips(string productid, int amount)
        {
            try
            {
                Deployment.Current.Dispatcher.BeginInvoke(async delegate
                {
                    try
                    {
                        await CurrentApp.RequestProductPurchaseAsync(productid, false);

                        DoFulfillment(productid, amount); 
                    }
                    catch(Exception e)
                    {
                        
                    }
                }); 
            }
            catch (Exception e)
            {

            }
        }

        private static void DoFulfillment(string productid, int amount)
        {
            ProductLicense license = CurrentApp.LicenseInformation.ProductLicenses[productid]; 

            if (license.IsConsumable && license.IsActive)
            {
                User.add_Coins(amount);
                CurrentApp.ReportProductFulfillment(productid); 
            }
        }

        public static void PURCHASE_SIX()
        {
            PurchaseChips(PRODUCT_SIX, PRODUCT_SIX_AMOUNT); 
        }

        public static void PURCHASE_FIVE()
        {
            PurchaseChips(PRODUCT_FIVE, PRODUCT_FIVE_AMOUNT); 
        }

        public static void PURCHASE_FOUR()
        {
            PurchaseChips(PRODUCT_FOUR, PRODUCT_FOUR_AMOUNT); 
        }

        public static void PURCHASE_THREE()
        {
            PurchaseChips(PRODUCT_THREE, PRODUCT_THREE_AMOUNT); 
        }

        public static void PURCHASE_TWO()
        {
            PurchaseChips(PRODUCT_TWO, PRODUCT_TWO_AMOUNT); 
        }

        public static void PURCHASE_ONE()
        {
            PurchaseChips(PRODUCT_ONE, PRODUCT_ONE_AMOUNT); 
        }
    }
}
