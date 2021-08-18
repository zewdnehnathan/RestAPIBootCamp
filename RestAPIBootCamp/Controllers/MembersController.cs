using Microsoft.AspNetCore.Mvc;
using RestAPIBootCamp.Model;
using RestAPIBootCamp.Services;
using RestAPIBootCamp.Interfaces;
using System.Collections.Generic;
using System.Linq;
using RestAPIBootCamp.Dtos;

namespace RestAPIBootCamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IMembersService _memberService;

        public MembersController(IMembersService memberService)
        {
            _memberService = memberService;
        }


        [HttpGet("GetAll")]
        public ResponseDto<Member> Get()
        {
            return _memberService.Get(null);

        }

        [HttpPost]
        public ResponseDto<Member> Add(Member member)
        {
            return _memberService.Create(member);
            
        }

        [HttpPut]
        public ResponseDto<Member> Edit(Member member)
        {
            return _memberService.Edit(member);
        }

        [HttpDelete]
        public ResponseDto<Member> Remove(int id) 
        {
            return _memberService.Remove(null);
        }


    }
}
