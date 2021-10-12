using PromoCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoCalculator.Services
{
  interface IPromoType
  {
    Task<int> Promo3AsFor130(List<UnitItem> skuItems);
    Task<int> Promo2BsFor45(List<UnitItem> skuItems);
    Task<int> PromoCplusDfor30(List<UnitItem> skuItems);
  }
}
