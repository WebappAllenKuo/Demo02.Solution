using WA.EStore.Domains;

namespace WA.EStore.IServices
{
	public interface IMemberRepository
	{
		bool IsExists(string account);
		void Create(Member member);
	}
}