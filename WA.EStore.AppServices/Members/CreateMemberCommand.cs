using System;
using WA.EStore.Domains;
using WA.EStore.IServices;

namespace WA.EStore.AppServices.Members
{
	public class CreateMemberRequest
	{
		public string Account { get; set; }
		public string Password { get; set; }

		public Member ToModel()
			=> new Member(Account, Password);
	}

	public class CreateMemberResponse
	{
		// 略過細節
	}

	public class CreateMemberCommand
	{
		private readonly IMemberService _memberService;

		public CreateMemberCommand(IMemberService memberService)
		{
			_memberService = memberService;
		}

		public CreateMemberResponse Execute(CreateMemberRequest request)
		{
			// todo 驗證 request

			// 將 request 轉型為 WA.EStore.Domains.Member, 在此, 會在 Member 建構函數裡再進行欄位驗證
			var member = request.ToModel();

			// 建立記錄, 在這裡會檢查帳號是否唯一
			_memberService.Create(member);

			// return response
			return new CreateMemberResponse();
		}
	}
}