using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ItemsAndContainersManagement.Core.Interfaces;
using ItemsAndContainersManagement.Core.Model;
using Microsoft.Ajax.Utilities;

namespace ItemsAPI.Controllers.API
{
    public class ContainerController : ApiController
    {
        private readonly IRepository<Container> _containerRepository;

        public ContainerController(IRepository<Container> containerRepository)
        {
            _containerRepository = containerRepository;
        }

  // GET api/values
        public IEnumerable<Container> Get()
        {
            return _containerRepository.List();
        }

        // GET api/values/5
        public Container Get(int id)
        {
            var container = _containerRepository.GetById(id);
            if (container == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return container;
        }

        // POST api/values
        public void Post([FromBody] Container container)
        {
            _containerRepository.Insert(container);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] Container container)
        {
            var containerToUpdate = _containerRepository.GetById(id);
            containerToUpdate.Name = container.Name;
            containerToUpdate.Description = container.Description;
            containerToUpdate.Height = container.Height;
            containerToUpdate.Width = container.Width;
            containerToUpdate.MaxWeight = container.MaxWeight;
            containerToUpdate.ContainerParentId = container.ContainerParentId;
            containerToUpdate.Location = container.Location;
            _containerRepository.Update(containerToUpdate);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            _containerRepository.Delete(id);
        }
    }
}
