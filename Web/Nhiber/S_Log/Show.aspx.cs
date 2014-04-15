using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace KDMYsoft.Web.Nhiber.S_Log
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		KDMYsoft.BLL.Nhiber.S_Log bll=new KDMYsoft.BLL.Nhiber.S_Log();
		KDMYsoft.Model.Nhiber.S_Log model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lbldatetime.Text=model.datetime.ToString();
		this.lblloginfo.Text=model.loginfo;
		this.lblParticular.Text=model.Particular;

	}


    }
}
