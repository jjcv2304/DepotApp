using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ItemsAndContainersManagement.Core.Interfaces;
using ItemsAndContainersManagement.Core.Model;

namespace ItemsAPI.Controllers.API
{
    public class ItemsController : ApiController
    {
        private readonly IRepository<Item> _itemRepository;

        public ItemsController(IRepository<Item> itemRepository)
        {
            _itemRepository = itemRepository;
        }

        // GET api/values
        public IEnumerable<Item> Get()
        {
            return _itemRepository.List();
        }

        // GET api/values/5
        public Item Get(int id)
        {
            var item = _itemRepository.GetById(id);
            if (item == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return item;
        }

        // POST api/values
        public void Post([FromBody] Item item)
        {
            _itemRepository.Insert(item);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] Item item)
        {
            var itemToUpdate = _itemRepository.GetById(id);
            itemToUpdate.Name = item.Name;
            itemToUpdate.Description = item.Description;
            itemToUpdate.Height = item.Height;
            itemToUpdate.Width = item.Width;

            _itemRepository.Update(itemToUpdate);
        }

        // DELETE api/values/5  
        public void Delete(int id)
        {
            _itemRepository.Delete(id);
        }
    }
}
