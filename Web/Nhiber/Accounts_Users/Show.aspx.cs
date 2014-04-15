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
namespace KDMYsoft.Web.Nhiber.Accounts_Users
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
		KDMYsoft.BLL.Nhiber.Accounts_Users bll=new KDMYsoft.BLL.Nhiber.Accounts_Users();
		KDMYsoft.Model.Nhiber.Accounts_Users model=bll.GetModel(UserID);
		this.lblUserID.Text=model.UserID.ToString();
		this.lblUserName.Text=model.UserName;
		this.lblPassword.Text=model.Password.ToString();
		this.lblTrueName.Text=model.TrueName;
		this.lblSex.Text=model.Sex;
		this.lblPhone.Text=model.Phone;
		this.lblEmail.Text=model.Email;
		this.lblEmployeeID.Text=model.EmployeeID.ToString();
		this.lblDepartmentID.Text=model.DepartmentID;
		this.lblActivity.Text=model.Activity?"是":"否";
		this.lblUserType.Text=model.UserType;
		this.lblStyle.Text=model.Style.ToString();

	}


    }
}
