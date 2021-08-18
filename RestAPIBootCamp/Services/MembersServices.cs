using RestAPIBootCamp.Dtos;
using RestAPIBootCamp.Interfaces;
using RestAPIBootCamp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPIBootCamp.Services
{
    public class MembersServices : IMembersService
    {
        private readonly List<Member> _members;

        public MembersServices() 
        {
            _members = new List<Member>();
            _members.AddRange
                (
                  new List<Member>
                  {
                     new Member
                     {
                         Id=1,
                         FullName = "Nathan"
                     },
                     new Member
                     {
                         Id=2,
                         FullName = "Biruk"
                     },
                     new Member
                     {
                         Id=3,
                         FullName = "Ashenafi"
                     }
                  }
                );
        }

        public ResponseDto<Member> Create(Member member) 
        {
            _members.Add(member);
            return new ResponseDto<Member>(_members.ToList(), true);
        }
        public ResponseDto<Member> Edit(Member member)
        {
            //variable naming
            Member toEdit = _members.Find(x => x.Id == member.Id);
            toEdit.FullName = member.FullName;
            toEdit.Position = member.Position;
            toEdit.Role = member.Role;

            return new ResponseDto<Member>(_members.ToList(),true);
        }
        public ResponseDto<Member> Remove(int? id) 
        {
            _members.Remove(_members.Find(x=>x.Id == id));
            return new ResponseDto<Member>(_members.ToList(),true);
        }

        public ResponseDto<Member> Get(int? id)
        {
            return new ResponseDto<Member>(_members.ToList(), true);
        }
    }
}
