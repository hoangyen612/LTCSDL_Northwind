﻿using LTCSDL.BLL;
using LTCSDL.Common.Req;
using LTCSDL.Common.Rsp;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LTCSDL.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController()
        {
            _svc = new ProductsSvc();
        }

        [HttpPost("get-all")]
        public IActionResult getAllProduct()
        {
            var res = new SingleRsp();
            res.Data = _svc.All;
            return Ok(res);
        }

        [HttpPost("get-product-by-id")]
        public IActionResult getProductById([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            var pro = _svc.GetProductById(req.Id);
            res.Data = pro;
            return Ok(res);
        }

        [HttpPost("get-product-by-supplier")]
        public IActionResult getProductBySupplier([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            var lstPro = _svc.All.Where(p => p.SupplierId == req.Id).ToList();
            res.Data = lstPro;
            return Ok(res);
        }

        [HttpPost("search-products")]
        public IActionResult SearchProducts([FromBody] SearchReq req)
        {
            var res = new SingleRsp();
            var pros = _svc.SearchProduct(req.Keyword, req.Page, req.Size);
            res.Data = pros;
            return Ok(res);
        }

        [HttpPost("create-product")]
        public IActionResult CreateProduct([FromBody] ProductsReq req)
        {
            var res = _svc.CreateProduct(req);
            return Ok(res);
        }

        [HttpPost("update-product")]
        public IActionResult UpdateProduct([FromBody] ProductsReq req)
        {
            var res = _svc.UpdateProduct(req);
            return Ok(res);
        }

        [HttpPost("get-product-not-order-in-aday")]
        public IActionResult ProductNotOrder([FromBody] GetProductReq req)
        {
            var res = _svc.ProductNotOrder(req);
            return Ok(res);
        }

        [HttpPost("quantity-products-in-order")]
        public IActionResult QuantityProducts([FromBody] TimeReq req)
        {
            var res = _svc.QuantityProducts(req);
            return Ok(res);
        }

        private readonly ProductsSvc _svc;
    }
}