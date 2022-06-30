using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class MemberDAO
    {

        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }

        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public Member CheckLogin(String email, String password)
        { 
            var listMembers = new List<Member>();
            Member member;
            try
            {
                using (var dbContext = new FStoreDBContext())
                {
                    member = dbContext.Members.SingleOrDefault(m => m.Email == email && m.Password == password);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return member;
        }

        public List<Member> GetMembers()
        {
            var listMembers = new List<Member>();
            try
            {
                using (var db = new FStoreDBContext())
                {
                    listMembers = db.Members.ToList();
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listMembers;
        }

        public void SaveMember(Member m)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    context.Members.Add(m);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateMember(Member m)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    context.Entry<Member>(m).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteMember(Member m)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    var m1 = context.Members.SingleOrDefault(c => c.MemberId == m.MemberId);
                    context.Members.Remove(m1);

                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Boolean CheckMemberIdDuplicated(int memberID)
        {
            Boolean check = false;
            Member mem = new Member();
            try
            {
                using (var dbContext = new FStoreDBContext())
                {
                    mem = dbContext.Members.SingleOrDefault(m => m.MemberId == memberID);
                }
                if (mem != null)
                {
                    check = true;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return check;
        }

        public Boolean CheckEmailDuplicated(string email)
        {
            Boolean check = false;
            Member mem = new Member();
            try
            {
                using (var dbContext = new FStoreDBContext())
                {
                    mem = dbContext.Members.SingleOrDefault(m => m.Email.Equals(email));
                }
                if (mem != null)
                {
                    check = true;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return check;
        }

        public Boolean CheckUpdateEmailDuplicated(int memberID, string email)
        {
            Boolean check = false;
            Member mem = new Member();

            try
            {
                using (var dbContext = new FStoreDBContext())
                {
                    mem = dbContext.Members.SingleOrDefault(m => m.Email.Equals(email));
                }
                if (mem == null)
                {
                    check = false;
                }
                else
                {
                    if (mem.MemberId.Equals(memberID))
                    {
                        check = false;
                    }
                    else
                    {
                        check = true;
                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return check;
        }

        public Member GetMemberByMemberID(string memberID)
        {          
            Member mem = new Member();
            try
            {
                using (var dbContext = new FStoreDBContext())
                {
                    mem = dbContext.Members.SingleOrDefault(m => m.MemberId == int.Parse(memberID));
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return mem;
        }

    }
}
