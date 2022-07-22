using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WA.EStore.Domains;

namespace WA.EStore.IServices
{
    public interface IMemberService
    {
	    void Create(Member member);
    }
}
