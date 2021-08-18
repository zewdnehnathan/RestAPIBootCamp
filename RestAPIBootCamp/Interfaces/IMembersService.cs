using RestAPIBootCamp.Dtos;
using RestAPIBootCamp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPIBootCamp.Interfaces
{
    public interface IMembersService
    {

        public ResponseDto<Member> Get(int? id);

        public ResponseDto<Member> Create(Member member);

        public ResponseDto<Member> Edit(Member member);

        public ResponseDto<Member> Remove(int? id);
        

    }
}
