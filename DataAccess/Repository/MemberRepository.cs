using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public bool CheckEmailDuplicated(string email) => MemberDAO.Instance.CheckEmailDuplicated(email);

        public Member CheckLogin(string email, string password) => MemberDAO.Instance.CheckLogin(email, password);

        public bool CheckMemberIdDuplicated(int memberID) => MemberDAO.Instance.CheckMemberIdDuplicated(memberID);

        public bool CheckUpdateEmailDuplicated(int memberID, string email) => MemberDAO.Instance.CheckUpdateEmailDuplicated(memberID, email);

        public void DeleteMember(Member m) => MemberDAO.Instance.DeleteMember(m);

        public Member GetMemberByMemberID(string memberID) => MemberDAO.Instance.GetMemberByMemberID(memberID);

        public List<Member> GetMembers() => MemberDAO.Instance.GetMembers();

        public void SaveMember(Member m) => MemberDAO.Instance.SaveMember(m);

        public void UpdateMember(Member m) => MemberDAO.Instance.UpdateMember(m);
    }
}
