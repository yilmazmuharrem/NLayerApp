using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerApp.Core.DTOs;
using NLayerApp.Core.Models;
using NLayerApp.Core.Services;

namespace NLayerApp.API.Controllers
{

    public class ProductsController : CustomBaseController
    {

        private readonly IMapper _mapper;
        private readonly IService<Product> _service;

        public ProductsController(IMapper mapper, IService<Product> service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> All(CancellationToken cancellationToken)
        {
            var products = await _service.GetAllAsync(cancellationToken);
            var productsDto = _mapper.Map<List<ProductDto>>(products).ToList();

            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200, productsDto));

        }




        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id,CancellationToken cancellationToken)
        {
            var products = await _service.GetByIdAsync(id);
            var productsDto = _mapper.Map<ProductDto>(products);

            return CreateActionResult(CustomResponseDto<ProductDto>.Success(201, productsDto));

        }



        [HttpPost]
        public async Task<IActionResult> Save(ProductDto productDto, CancellationToken cancellationToken)
        {
            

            var result = await _service.AddAsync(_mapper.Map<Product>(productDto), cancellationToken);
            var products = _mapper.Map<ProductDto>(result);

            return CreateActionResult(CustomResponseDto<ProductDto>.Success(201, products));

        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductUpdateDto productDto, CancellationToken cancellationToken)
        {

            await _service.UpdateAsync(_mapper.Map<Product>(productDto), cancellationToken);
            
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id, CancellationToken cancellationToken)
        {
            var product = await _service.GetByIdAsync(id);

            await _service.RemoveAsync(product, cancellationToken);
         

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }




    }
}
