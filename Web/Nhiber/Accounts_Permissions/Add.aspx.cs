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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string Description=this.txtDescription.Text;
			int CategoryID=int.Parse(this.txtCategoryID.Text);

			KDMYsoft.Model.Nhiber.Accounts_Permissions model=new KDMYsoft.Model.Nhiber.Accounts_Permissions();
			model.Description=Description;
			model.CategoryID=CategoryID;

			KDMYsoft.BLL.Nhiber.Accounts_Permissions bll=new KDMYsoft.BLL.Nhiber.Accounts_Permissions();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
