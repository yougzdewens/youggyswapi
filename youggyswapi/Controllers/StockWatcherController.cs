using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace youggyswapi.Controllers
{
    public class StockWatcherController : Controller
    {
        YouggySWLib.Business.ValueWatchingBusiness valueWatchingBusiness = new YouggySWLib.Business.ValueWatchingBusiness();

        public string Add(string symbol, string buyOrSell)
        {
            YouggySWLib.Business.SymbolBusiness symbolBusiness = new YouggySWLib.Business.SymbolBusiness();

            YouggySWLib.Model.Symbol symbolModel = symbolBusiness.GetSymbol(symbol).FirstOrDefault();

            valueWatchingBusiness.Insert(
                new YouggySWLib.Model.ValueWatching()
                {
                    BuyOrSell = buyOrSell,
                    IdSymbol = symbolModel.IdSymbol
                });

            return "OK";
        }

        public string Remove(string symbol)
        {
            YouggySWLib.Business.SymbolBusiness symbolBusiness = new YouggySWLib.Business.SymbolBusiness();

            YouggySWLib.Model.Symbol symbolModel = symbolBusiness.GetSymbol(symbol).FirstOrDefault();

            valueWatchingBusiness.RemoveBySymbol(
                new YouggySWLib.Model.ValueWatching()
                {
                    IdSymbol = symbolModel.IdSymbol
                });

            return "OK";
        }

        public string RemoveById(int id)
        {
            valueWatchingBusiness.Remove(
                new YouggySWLib.Model.ValueWatching()
                {
                    IdSymbol = id
                });

            return "OK";
        }

        public List<YouggySWLib.Model.ValueWatching> List()
        {
            return valueWatchingBusiness.GetAllValueWatchings();
        }

        public YouggySWLib.Model.ValueWatching Get(int id)
        {
            return valueWatchingBusiness.GetValueWatching(id);
        }
    }
}
