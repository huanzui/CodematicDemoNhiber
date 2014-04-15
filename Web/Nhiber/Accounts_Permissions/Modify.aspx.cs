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
namespace KDMYsoft.Web.Nhiber.Accounts_Permissions
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int PermissionID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(PermissionID);
				}
			}
		}
			
	private void ShowInfo(int PermissionID)
	{
		KDMYsoft.BLL.Nhiber.Accounts_Permissions bll=new KDMYsoft.BLL.Nhiber.Accounts_Permissions();
		KDMYsoft.Model.Nhiber.Accounts_Permissions model=bll.GetModel(PermissionID);
		this.lblPermissionID.Text=model.PermissionID.ToString();
		this.txtDescription.Text=model.Description;
		this.txtCategoryID.Text=model.CategoryID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDescription.Text.Trim().Length==0)
			{
				strErr+="Description不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtCategoryID.Text))
			{
				strErr+="CategoryID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int PermissionID=int.Parse(this.lblPermissionID.Text);
			string Description=this.txtDescription.Text;
			int CategoryID=int.Parse(this.txtCategoryID.Text);


			KDMYsoft.Model.Nhiber.Accounts_Permissions model=new KDMYsoft.Model.Nhiber.Accounts_Permissions();
			model.PermissionID=PermissionID;
			model.Description=Description;
			model.CategoryID=CategoryID;

			KDMYsoft.BLL.Nhiber.Accounts_Permissions bll=new KDMYsoft.BLL.Nhiber.Accounts_Permissions();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
