namespace ModelBindingFail
{
	using System.Net.Http;
	using System.Threading;
	using System.Threading.Tasks;

	public class TestMessageHandler : DelegatingHandler
	{
		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			request.Content.ReadAsStringAsync().ContinueWith((task) =>
			{
				/* do stuff with task.Result */
			});

			return base.SendAsync(request, cancellationToken);
		}
	}
}