using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace iPhone2FrozenPeas
{
    public class PriceConverter
    {
        /* Based off of https://twitter.com/Alexand19039479/status/1519278784456937474 */
        /* There are 2777 Peas in a 1kg bag of peas */
        /* 1kg bag of peas is $6.99 according to https://www.groceryonwheels.org/green-peas-1 */
        public static int ConvertToPea(int price) { return Convert.ToInt32(2777 * (price / 6.99)); }
        public static int iPhonePrice(string iPhone)
        {
            /* Prices based off of the most expensive version of each phone */
            switch (iPhone)
            {
                case "iPhone":
                    return 499;
                case "iPhone 3G":
                    return 599;
                case "iPhone 3GS":
                    return 599;
                case "iPhone 4":
                    return 599;
                case "iPhone 4S":
                    return 649;
                case "iPhone 5":
                    return 649;
                case "iPhone 5c":
                    return 520;
                case "iPhone 5s":
                    return 649;
                case "iPhone 6":
                    return 649;
                case "iPhone 6 Plus":
                    return 749;
                case "iPhone 6s":
                    return 649;
                case "iPhone 6s Plus":
                    return 749;
                case "iPhone SE (1st generation)":
                    return 249;
                case "iPhone 7":
                    return 649;
                case "iPhone 7 Plus":
                    return 769;
                case "iPhone 8":
                    return 699;
                case "iPhone 8 Plus":
                    return 799;
                case "iPhone X":
                    return 999;
                case "iPhone XR":
                    return 899;
                case "iPhone XS":
                    return 999;
                case "iPhone XS Max":
                    return 1449;
                case "iPhone 11":
                    return 699;
                case "iPhone 11 Pro":
                    return 999;
                case "iPhone 11 Pro Max":
                    return 1099;
                case "iPhone SE (2nd generation)":
                    return 399;
                case "iPhone 12 mini":
                    return 699;
                case "iPhone 12":
                    return 749;
                case "iPhone 12 Pro":
                    return 999;
                case "iPhone 12 Pro Max":
                    return 1099;
                case "iPhone 13 mini":
                    return 929;
                case "iPhone 13":
                    return 1029;
                case "iPhone 13 Pro":
                    return 1499;
                case "iPhone 13 Pro Max":
                    return 1439;
                case "iPhone SE (3rd generation)":
                    return 329;
                case "iPhone 14":
                    return 1129;
                case "iPhone 14 Plus":
                    return 1229;
                case "iPhone 14 Pro":
                    return 1499;
                case "iPhone 14 Pro Max":
                    return 1599;
                default:
                    return 0;
            }
        }
    }
}
