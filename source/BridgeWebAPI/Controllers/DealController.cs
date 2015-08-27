﻿using System.Web.Http;
using Bridge.WebAPI.Models;
using Bridge.WebAPI.Queries;

namespace Bridge.WebAPI.Controllers
{
    [RoutePrefix("api/deals")]
    public class DealController : ApiController
    {
        private readonly DealQueries _queries;

        public DealController(DealQueries queries)
        {
            _queries = queries;
        }

        [Route("{id:int}")]
        public DealDetailModel Get(int id)
        {
            return _queries.Get(id);
        }
    }
}