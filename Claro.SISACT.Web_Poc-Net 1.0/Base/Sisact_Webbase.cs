using System;
using Claro.SISACT.Common;
using System.Reflection;
using System.Web;

namespace Claro.SISACT.Web_Poc.Base
{
	/// <summary>
	/// Summary description for SisactWebbase.
	/// </summary>
	public class Sisact_Webbase : System.Web.UI.Page
	{
     
		protected override void OnInit(EventArgs e)
		{
			string childPage = this.GetType().UnderlyingSystemType.ToString();
			Constantes.nombrePagina = childPage;

		}
	}
}
