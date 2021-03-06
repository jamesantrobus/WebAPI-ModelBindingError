﻿namespace ModelBindingFail
{
	using System.Web;
	using System.Web.Http;
	using System.Web.Mvc;
	using System.Web.Routing;

	public class WebApiApplication : HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			WebApiConfig.Register(GlobalConfiguration.Configuration);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);

			GlobalConfiguration.Configuration.MessageHandlers.Add(new TestMessageHandler());
		}
	}
}