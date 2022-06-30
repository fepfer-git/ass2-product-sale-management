using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        Member CheckLogin(String email, String password);
        public List<Member> GetMembers();
        public void SaveMember(Member m);
        public void UpdateMember(Member m);
        public void DeleteMember(Member m);
        public Boolean CheckMemberIdDuplicated(int memberID);
        public Boolean CheckEmailDuplicated(string email);
        public Boolean CheckUpdateEmailDuplicated(int memberID, string email);
        public Member GetMemberByMemberID(string memberID);
    }
}
