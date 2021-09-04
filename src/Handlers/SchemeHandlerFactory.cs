using CefSharp;

namespace Kairo_Internet {
	internal class SchemeHandlerFactory : ISchemeHandlerFactory {

		public IResourceHandler Create(IBrowser browser, IFrame frame, string schemeName, IRequest request) {
			return new SchemeHandler(MainForm.Instance);
		}
	}
}