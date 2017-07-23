using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StockManagement.Core.Interfaces;

namespace ItemsAPI.Controllers.API
{
    public class StockController : ApiController
    {
        private readonly IStockRepository _stockRepository;
        public StockController(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }


    }
}

