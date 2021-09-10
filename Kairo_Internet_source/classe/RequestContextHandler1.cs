using CefSharp;
namespace Kairo_Internet_source.classe
{
	public class RequestContextHandler1 : IRequestContextHandler
	{
		IResourceRequestHandler IRequestContextHandler.GetResourceRequestHandler(IBrowser browser, IFrame frame, IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling)
		{
			//Return null for the default behaviour
			return null;
		}

		bool IRequestContextHandler.OnBeforePluginLoad(string mimeType, string url, bool isMainFrame, string topOriginUrl, WebPluginInfo pluginInfo, ref PluginPolicy pluginPolicy)
		{
			//pluginPolicy = PluginPolicy.Disable;
			//return true;

			return false;
		}

		void IRequestContextHandler.OnRequestContextInitialized(IRequestContext requestContext)
		{
			//You can set preferences here on your newly initialized request context.
			//Note, there is called on the CEF UI Thread, so you can directly call SetPreference

			//Use this to check that settings preferences are working in your code
			//You should see the minimum font size is now 24pt
			string errorMessage;
			var success = requestContext.SetPreference("webkit.webprefs.minimum_font_size", 24, out errorMessage);

			//You can set the proxy with code similar to the code below
			//https://stackoverflow.com/questions/36095566/cefsharp-3-set-proxy-at-runtime has some additional examples
			//var v = new Dictionary<string, object>
			//{
			//    ["mode"] = "fixed_servers",
			//    ["server"] = "scheme://host:port"
			//};
			//string errorMessage;
			//bool success = requestContext.SetPreference("proxy", v, out errorMessage);
		}
	}
}
