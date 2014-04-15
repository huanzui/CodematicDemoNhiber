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
namespace KDMYsoft.Web.Nhiber.Accounts_RolePermissions
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
		
	private void ShowInfo()
	{
		KDMYsoft.BLL.Nhiber.Accounts_RolePermissions bll=new KDMYsoft.BLL.Nhiber.Accounts_RolePermissions();
		KDMYsoft.Model.Nhiber.Accounts_RolePermissions model=bll.GetModel();
		this.lblRoleID.Text=model.RoleID.ToString();
		this.lblPermissionID.Text=model.PermissionID.ToString();

	}


    }
}
