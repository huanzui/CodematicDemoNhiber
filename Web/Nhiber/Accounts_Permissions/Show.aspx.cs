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
namespace KDMYsoft.Web.Nhiber.Accounts_Permissions
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
					int PermissionID=(Convert.ToInt32(strid));
					ShowInfo(PermissionID);
				}
			}
		}
		
	private void ShowInfo(int PermissionID)
	{
		KDMYsoft.BLL.Nhiber.Accounts_Permissions bll=new KDMYsoft.BLL.Nhiber.Accounts_Permissions();
		KDMYsoft.Model.Nhiber.Accounts_Permissions model=bll.GetModel(PermissionID);
		this.lblPermissionID.Text=model.PermissionID.ToString();
		this.lblDescription.Text=model.Description;
		this.lblCategoryID.Text=model.CategoryID.ToString();

	}


    }
}
