using Microsoft.AspNetCore.Mvc;
using OdontoPrevApplication.Application.Dtos;
using OdontoPrevApplication.Application.Interfaces;
using OdontoPrevApplication.Domain.Entities;

namespace OdontoPrevApplication.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeneficiarioController : ControllerBase
    {
        private readonly IBeneficiarioApplicationService _beneficiarioApplicationService;

        public BeneficiarioController(IBeneficiarioApplicationService beneficiarioApplicationService)
        {
            _beneficiarioApplicationService = beneficiarioApplicationService;
        }

        [HttpGet]
        [Produces(typeof(IEnumerable<BeneficiarioEntity>))]
        public IActionResult Get()
        {
            try
            {
                var entidades = _beneficiarioApplicationService.ObterTodos();

                if (entidades is null) return NoContent();

                return Ok(entidades);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        [Produces(typeof(BeneficiarioEntity))]
        public IActionResult ObterPorId(int id)
        {
            try
            {
                var entidade = _beneficiarioApplicationService.ObterPorId(id);

                if (entidade is null) return NoContent();

                return Ok(entidade);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Produces(typeof(BeneficiarioEntity))]
        public IActionResult Post([FromBody] BeneficiarioDto entidadeDto)
        {
            try
            {
                var entidade = _beneficiarioApplicationService.SalvarDados(entidadeDto);

                var uri = Url.Action(nameof(Get), new { id = entidade.Id });

                return Created(uri, entidade);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        [Produces(typeof(BeneficiarioEntity))]
        public IActionResult Put(int id, [FromBody] BeneficiarioDto entidadeDto)
        {
            try
            {
                var entidade = _beneficiarioApplicationService.EditarDados(id, entidadeDto);

                return Ok(entidade);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        [Produces(typeof(BeneficiarioEntity))]
        public IActionResult Delete(int id)
        {
            try
            {
                var entidade = _beneficiarioApplicationService.DeletarDados(id);

                return Ok(entidade);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
