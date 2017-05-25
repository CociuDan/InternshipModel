using AutoMapper;
using GeekStore.Infrastucture.Extensions;
using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.UI.Extensions;
using GeekStore.UI.Models.Common;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GeekStore.UI.Areas.Admin.Controllers
{
    [AdminRoleRequired]
    public class DiskController : Controller
    {
        private readonly IGenericService<DiskDTO> _genericService;
        private readonly IMapper _mapper;

        public DiskController(IGenericService<DiskDTO> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            IEnumerable<DiskViewModel> disks = null;
            return View(disks);
        }

        [HttpPost]
        public JsonResult GetAll(PagedRequestDescription pageDescription)
        {
            int count = _genericService.GetAllCount();
            var disks = _mapper.Map<IEnumerable<DiskDTO>, IEnumerable<DiskViewModel>>(_genericService.GetAllPaged(pageDescription));
            return Json(new { Result = "OK", Records = disks, TotalRecordCount = count });
        }

        [HttpPost]
        public JsonResult Edit(DiskViewModel diskModel)
        {
            try
            {
                _genericService.Update(_mapper.Map<DiskViewModel, DiskDTO>(diskModel));
                return Json(new { Result = "OK", Record = diskModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Create(DiskViewModel diskModel)
        {
            try
            {
                var id = _genericService.Save(_mapper.Map<DiskViewModel, DiskDTO>(diskModel));
                diskModel.ID = id;
                return Json(new { Result = "OK", Record = diskModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Delete(DiskViewModel diskModel)
        {
            try
            {
                _genericService.Delete(diskModel.ID);
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}