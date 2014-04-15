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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace KDMYsoft.Web.Nhiber.Accounts_UserRoles
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int UserID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(UserID);
				}
			}
		}
			
	private void ShowInfo(int UserID)
	{
		KDMYsoft.BLL.Nhiber.Accounts_UserRoles bll=new KDMYsoft.BLL.Nhiber.Accounts_UserRoles();
		KDMYsoft.Model.Nhiber.Accounts_UserRoles model=bll.GetModel(UserID);
		this.lblUserID.Text=model.UserID.ToString();
		this.txtRoleID.Text=model.RoleID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtRoleID.Text))
			{
				strErr+="RoleID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int UserID=int.Parse(this.lblUserID.Text);
			int RoleID=int.Parse(this.txtRoleID.Text);


			KDMYsoft.Model.Nhiber.Accounts_UserRoles model=new KDMYsoft.Model.Nhiber.Accounts_UserRoles();
			model.UserID=UserID;
			model.RoleID=RoleID;

			KDMYsoft.BLL.Nhiber.Accounts_UserRoles bll=new KDMYsoft.BLL.Nhiber.Accounts_UserRoles();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
