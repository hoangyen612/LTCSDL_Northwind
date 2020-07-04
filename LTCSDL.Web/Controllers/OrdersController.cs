﻿using LTCSDL.BLL;
using LTCSDL.Common.DAL;
using LTCSDL.Common.Req;
using LTCSDL.Common.Rsp;
using LTCSDL.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LTCSDL.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        public OrdersController()
        {
            _svc = new OrdersSvc();
        }

        [HttpPost("get-all")]
        public IActionResult getAllProduct()
        {
            var res = new SingleRsp();
            res.Data = _svc.All;
            return Ok(res);
        }

        [HttpPost("get-customer-order-history")]
        public IActionResult GetCustOrderHist(string id)
        {
            var res = new SingleRsp();
            res.Data = _svc.GetCustOrderHist(id);
            return Ok(res);
        }

        [HttpPost("get-customer-order-history-linq")]
        public IActionResult GetCustOrderHistLinq(string id)
        {
            var res = new SingleRsp();
            res.Data = _svc.GetCustOrderHist_Linq(id);
            return Ok(res);
        }

        [HttpPost("get-customer-order-detail-linq")]
        public IActionResult GetCustOrdersDetailLinq(int orderId)
        {
            var res = new SingleRsp();
            res.Data = _svc.GetCustOrdersDetail_Linq(orderId);
            return Ok(res);
        }

        [HttpPost("get-customer-order-detail-linq1")]
        public IActionResult GetCustOrdersDetailLinq1(int orderId)
        {
            var res = new SingleRsp();
            res.Data = _svc.GetCustOrdersDetail_Linq(orderId);
            return Ok(res);
        }
        [HttpPost("get-order-in-space-time")]
        public IActionResult GetOrderInSpaceTime([FromBody] OrderFullReq req)
        {
            var res = new SingleRsp();
            res.Data = _svc.GetOrderInSpaceTime(req);
            return Ok(res);
        }
        [HttpPost("get-order-in-space-time-linq")]
        public IActionResult GetOrderInSpaceTime_Linq([FromBody] OrderFullReq req)
        {
            var res = new SingleRsp();
            res.Data = _svc.GetOrderInSpaceTime_Linq(req);
            return Ok(res);
        }
        
        [HttpPost("get-order-detail-by-id")]
        public IActionResult GetOrderDetailByOrderId([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            res.Data = _svc.GetOrderDetailByOrderId(req.Id);
            return Ok(res);
        }

        [HttpPost("get-order-detail-by-id-linq")]
        public IActionResult GetOrderDetailByOrderId_Linq([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            res.Data = _svc.GetOrderDetailByOrderId_Linq(req.Id);
            return Ok(res);
        }

        [HttpPost("get-order-of-employee")]
        public IActionResult GetOrderOfEmployee([FromBody] OrderFullReq req)
        {
            var res = new SingleRsp();
            res.Data = _svc.GetOrderOfEmployee(req);
            return Ok(res);
        }

        [HttpPost("get-order-of-employee-linq")]
        public IActionResult GetOrderOfEmployee_Linq([FromBody] OrderFullReq req)
        {
            var res = new SingleRsp();
            res.Data = _svc.GetOrderOfEmployee_Linq(req);
            return Ok(res);
        }

        [HttpPost("get-best-seller-in-month-year")]
        public IActionResult GetBestSeller([FromBody] OrderFullReq req)
        {
            var res = new SingleRsp();
            res.Data = _svc.GetBestSeller(req);
            return Ok(res);
        }
        [HttpPost("doanh-thu-theo-quoc-gia")]
        public IActionResult DoanhThuTheoQG([FromBody] OrderFullReq req)
        {
            var res = new SingleRsp();
            res.Data = _svc.DoanhThuTheoQG(req);
            return Ok(res);
        }

        [HttpPost("tim-dh")]
        public IActionResult SearchOrder([FromBody] SearchReq req)
        {
            var res = new SingleRsp();
            res.Data = _svc.SearchOrder(req);
            return Ok(res);
        }

        [HttpPost("get-orders-in-day")]
        public IActionResult OrdersInDay([FromBody] OrderTodayReq req)
        {
            var res = new SingleRsp();
            res.Data = _svc.OrdersInDay(req);
            return Ok(res);
        }
        private readonly OrdersSvc _svc;
    }
}