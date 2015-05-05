using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using AutoMapper;
using NewsWeb.Business.Models;
using NewsWeb.Dto;

namespace NewsWeb.Api.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/category")]
    public class CategoryController : ApiController
    {
        private readonly ICategoryBusiness _categoryBusiness;

        public CategoryController(ICategoryBusiness categoryBusiness)
        {
            _categoryBusiness = categoryBusiness;
        }

        [HttpGet]
        public async Task<IHttpActionResult> Index()
        {
            try
            {
                var categories = await _categoryBusiness.GetAllAsync();

                return Ok(Mapper.Map<IEnumerable<Category>>(categories));
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpGet]
        [Route("{cid}/news/{nid}")]
        public async Task<IHttpActionResult> Contents(Guid cid, Guid nid)
        {
            try
            {
                var category = await _categoryBusiness.GetByIdAsync(cid);

                var news = category.Articles.FirstOrDefault(a => a.Id == nid);
                if (news == null) return NotFound();

                return Ok(Mapper.Map<Article>(news));
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
