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
namespace KDMYsoft.Web.Nhiber.Accounts_Users
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUserName.Text.Trim().Length==0)
			{
				strErr+="UserName不能为空！\\n";	
			}
			if(this.txtTrueName.Text.Trim().Length==0)
			{
				strErr+="TrueName不能为空！\\n";	
			}
			if(this.txtSex.Text.Trim().Length==0)
			{
				strErr+="Sex不能为空！\\n";	
			}
			if(this.txtPhone.Text.Trim().Length==0)
			{
				strErr+="Phone不能为空！\\n";	
			}
			if(this.txtEmail.Text.Trim().Length==0)
			{
				strErr+="Email不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtEmployeeID.Text))
			{
				strErr+="EmployeeID格式错误！\\n";	
			}
			if(this.txtDepartmentID.Text.Trim().Length==0)
			{
				strErr+="DepartmentID不能为空！\\n";	
			}
			if(this.txtUserType.Text.Trim().Length==0)
			{
				strErr+="UserType不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtStyle.Text))
			{
				strErr+="Style格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string UserName=this.txtUserName.Text;
			byte[] Password= new UnicodeEncoding().GetBytes(this.txtPassword.Text);
			string TrueName=this.txtTrueName.Text;
			string Sex=this.txtSex.Text;
			string Phone=this.txtPhone.Text;
			string Email=this.txtEmail.Text;
			int EmployeeID=int.Parse(this.txtEmployeeID.Text);
			string DepartmentID=this.txtDepartmentID.Text;
			bool Activity=this.chkActivity.Checked;
			string UserType=this.txtUserType.Text;
			int Style=int.Parse(this.txtStyle.Text);

			KDMYsoft.Model.Nhiber.Accounts_Users model=new KDMYsoft.Model.Nhiber.Accounts_Users();
			model.UserName=UserName;
			model.Password=Password;
			model.TrueName=TrueName;
			model.Sex=Sex;
			model.Phone=Phone;
			model.Email=Email;
			model.EmployeeID=EmployeeID;
			model.DepartmentID=DepartmentID;
			model.Activity=Activity;
			model.UserType=UserType;
			model.Style=Style;

			KDMYsoft.BLL.Nhiber.Accounts_Users bll=new KDMYsoft.BLL.Nhiber.Accounts_Users();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
