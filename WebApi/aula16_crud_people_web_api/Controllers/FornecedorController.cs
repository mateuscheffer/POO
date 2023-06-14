using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_continuacao.Domain.Interfaces;
using aula12_ef_test.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace aula12_ef_test.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class FornecedorController : ControllerBase
{
        private readonly IFornecedorRepository _repository;

        public FornecedorController()
        {
            _repository = new aula12_ef_continuacao.Data.Repositories.FornecedorRepository();
        }
        [HttpGet]
        public IEnumerable<Fornecedor> Get()
        {
            return _repository.GetAll();
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = _repository.GetById(id);
            if(item == null)
                return Ok(new {statusCode = 400, message="Nada foi encontrado com o id " + id,item});
            else
                return Ok(new {statusCode = 200, message="OK",item});
        }

        [HttpPost]
        public IActionResult Post([FromBody]Fornecedor item)
        {
            _repository.Save(item);
            return Ok(new {
                statusCode = 200,
                message = "Cadastrado com sucesso.",
                item});
        }

        [HttpPut]
        public IActionResult Put([FromBody]Fornecedor item)
        {
            _repository.Update(item);
            return Ok(new {
                statusCode = 200,
                message = "Fornecedor autalizado com sucesso.",
                item});
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if(_repository.Delete(id))
                return Ok(new {statusCode=200,message="Deletado com sucesso"});
            else
                return Ok(new {statusCode=500,message="Ops!! Algo deu errado... tente novamente."});
        }


    }
}