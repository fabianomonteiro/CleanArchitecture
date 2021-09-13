using API.Hateoas.Account.Get;
using Facade;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using UseCases;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase, ICallerInstance
    {
        private readonly AccountFacade _accountFacade;

        public AccountController(AccountFacade accountFacade)
        {
            _accountFacade = accountFacade;
        }

        [HttpGet]
        [Route("ListActive")]
        public async Task<IEnumerable<ListActiveAccountHateoas>> ListActive()
        {
            return await 
                _accountFacade
                    .ListActive()
                    .Execute(this)
                    .GetOutputAsync<IEnumerable<ListActiveAccountHateoas>>();
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<GetAccountByIdHateoas> GetById(int id)
        {
            return await 
                _accountFacade
                    .GetById()
                    .SetInput(id)
                    .Execute(this)
                    .GetOutputAsync<GetAccountByIdHateoas>();
        }
    }
}
