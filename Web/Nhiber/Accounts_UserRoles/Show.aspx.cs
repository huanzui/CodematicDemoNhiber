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
namespace KDMYsoft.Web.Nhiber.Accounts_UserRoles
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
					int UserID=(Convert.ToInt32(strid));
					ShowInfo(UserID);
				}
			}
		}
		
	private void ShowInfo(int UserID)
	{
		KDMYsoft.BLL.Nhiber.Accounts_UserRoles bll=new KDMYsoft.BLL.Nhiber.Accounts_UserRoles();
		KDMYsoft.Model.Nhiber.Accounts_UserRoles model=bll.GetModel(UserID);
		this.lblUserID.Text=model.UserID.ToString();
		this.lblRoleID.Text=model.RoleID.ToString();

	}


    }
}
