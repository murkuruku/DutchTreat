using AutoMapper;
using DutchTreat.Data;
using DutchTreat.Data.Entities;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreat.Controllers
{
    [Route("api/orders/{orderid}/items")]
    public class OrderItemController: Controller
    {
        private readonly IDutchRepository _repository;
        private readonly ILogger<OrderItemController> _logger;
        private readonly IMapper _mapper;

        public OrderItemController(IDutchRepository repository,ILogger<OrderItemController> logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get(int orderid)
        {
            try
            {
                var order = _repository.GetOrderById(orderid);
                if(order != null)
                {
                    return Ok(_mapper.Map<IEnumerable<OrderItem>, IEnumerable<OrderItemViewModel>>(order.Items));
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get all items: {ex}");
                return BadRequest("Failed to get all items");
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int orderid, int id)
        {
            try
            {
                var order = _repository.GetOrderById(orderid);
                if (order != null)
                {
                    var item = order.Items.Where(i => i.Id == id).FirstOrDefault();
                    if(item != null)
                    {
                        return Ok(_mapper.Map<OrderItem,OrderItemViewModel>(item));
                    }
                    
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get all items: {ex}");
                return BadRequest("Failed to get all items");
            }
        }
    }
}
