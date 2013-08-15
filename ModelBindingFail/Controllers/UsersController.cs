namespace ModelBindingFail.Controllers
{
	using System;
	using System.Web.Http;

	public class UsersController : ApiController
    {
		[HttpPost]
        public void Foo(User user)
        {
	        if (user == null)
	        {
		        throw new NullReferenceException();
	        }
        }
    }
}
