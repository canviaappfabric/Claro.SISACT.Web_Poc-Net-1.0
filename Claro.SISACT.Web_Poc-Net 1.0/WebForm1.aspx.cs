using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

using Claro.SISACT.Common;
using Claro.SISACT.Web_Poc.Base;


namespace Claro.SISACT.Web_Poc
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public class WebForm1 : Sisact_Webbase
	{
		
		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion

		private void Page_Load(object sender, System.EventArgs e)
		{
			

			Session["Usuario"] = Request.QueryString["Usuario"];


			if (!Page.IsPostBack)
				CargarDeclConocimiento();

		}


		private  void CargarDeclConocimiento()
		{
			string CurrentUser = string.Empty;
			GeneradorLog objLog = new GeneradorLog(CurrentUser, null, null, "WEB");
			objLog.CrearArchivolog("Segmento: " + "1234",  null);
		}



	}
}
