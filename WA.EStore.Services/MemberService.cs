using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WA.EStore.Domains;
using WA.EStore.IServices;

namespace WA.EStore.Services
{
    public class MemberService:IMemberService
    {
	    private readonly IMemberRepository _repository;

	    public MemberService(IMemberRepository repository)
	    {
		    _repository = repository;
	    }

	    public void Create(Member member)
	    {
		    // 檢查 account 是否唯一
		    if (_repository.IsExists(member.Account))
		    {
			    throw new Exception("帳號已存在");
		    }

		    // 建立記錄
		    _repository.Create(member);
		}
    }
}
