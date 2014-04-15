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
namespace KDMYsoft.Web.Nhiber.Accounts_Roles
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int RoleID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(RoleID);
				}
			}
		}
			
	private void ShowInfo(int RoleID)
	{
		KDMYsoft.BLL.Nhiber.Accounts_Roles bll=new KDMYsoft.BLL.Nhiber.Accounts_Roles();
		KDMYsoft.Model.Nhiber.Accounts_Roles model=bll.GetModel(RoleID);
		this.lblRoleID.Text=model.RoleID.ToString();
		this.txtDescription.Text=model.Description;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDescription.Text.Trim().Length==0)
			{
				strErr+="Description不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int RoleID=int.Parse(this.lblRoleID.Text);
			string Description=this.txtDescription.Text;


			KDMYsoft.Model.Nhiber.Accounts_Roles model=new KDMYsoft.Model.Nhiber.Accounts_Roles();
			model.RoleID=RoleID;
			model.Description=Description;

			KDMYsoft.BLL.Nhiber.Accounts_Roles bll=new KDMYsoft.BLL.Nhiber.Accounts_Roles();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
