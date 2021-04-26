using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace youggyswapi.Controllers
{
    public class SymbolController : ControllerBase
    {
        YouggySWLib.Business.SymbolBusiness business = new YouggySWLib.Business.SymbolBusiness();

        public float GetPercentageValueFor(int nbDayBefore, int idSymbol)
        {
            return business.GetPercentageValueFor(nbDayBefore, idSymbol);
        }

        public List<YouggySWLib.Model.Symbol> Search(string symbol)
        {
            return business.GetSymbol(symbol);
        }
    }
}
