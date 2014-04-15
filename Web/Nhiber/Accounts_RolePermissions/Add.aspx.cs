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
namespace KDMYsoft.Web.Nhiber.Accounts_RolePermissions
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtRoleID.Text))
			{
				strErr+="RoleID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPermissionID.Text))
			{
				strErr+="PermissionID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int RoleID=int.Parse(this.txtRoleID.Text);
			int PermissionID=int.Parse(this.txtPermissionID.Text);

			KDMYsoft.Model.Nhiber.Accounts_RolePermissions model=new KDMYsoft.Model.Nhiber.Accounts_RolePermissions();
			model.RoleID=RoleID;
			model.PermissionID=PermissionID;

			KDMYsoft.BLL.Nhiber.Accounts_RolePermissions bll=new KDMYsoft.BLL.Nhiber.Accounts_RolePermissions();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
