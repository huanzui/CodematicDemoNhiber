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
namespace KDMYsoft.Web.Nhiber.Accounts_PermissionCategories
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int CategoryID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(CategoryID);
				}
			}
		}
			
	private void ShowInfo(int CategoryID)
	{
		KDMYsoft.BLL.Nhiber.Accounts_PermissionCategories bll=new KDMYsoft.BLL.Nhiber.Accounts_PermissionCategories();
		KDMYsoft.Model.Nhiber.Accounts_PermissionCategories model=bll.GetModel(CategoryID);
		this.lblCategoryID.Text=model.CategoryID.ToString();
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
			int CategoryID=int.Parse(this.lblCategoryID.Text);
			string Description=this.txtDescription.Text;


			KDMYsoft.Model.Nhiber.Accounts_PermissionCategories model=new KDMYsoft.Model.Nhiber.Accounts_PermissionCategories();
			model.CategoryID=CategoryID;
			model.Description=Description;

			KDMYsoft.BLL.Nhiber.Accounts_PermissionCategories bll=new KDMYsoft.BLL.Nhiber.Accounts_PermissionCategories();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
