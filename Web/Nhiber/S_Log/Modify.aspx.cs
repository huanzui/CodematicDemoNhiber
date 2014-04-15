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
namespace KDMYsoft.Web.Nhiber.S_Log
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		KDMYsoft.BLL.Nhiber.S_Log bll=new KDMYsoft.BLL.Nhiber.S_Log();
		KDMYsoft.Model.Nhiber.S_Log model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtdatetime.Text=model.datetime.ToString();
		this.txtloginfo.Text=model.loginfo;
		this.txtParticular.Text=model.Particular;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtdatetime.Text))
			{
				strErr+="datetime格式错误！\\n";	
			}
			if(this.txtloginfo.Text.Trim().Length==0)
			{
				strErr+="loginfo不能为空！\\n";	
			}
			if(this.txtParticular.Text.Trim().Length==0)
			{
				strErr+="Particular不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			DateTime datetime=DateTime.Parse(this.txtdatetime.Text);
			string loginfo=this.txtloginfo.Text;
			string Particular=this.txtParticular.Text;


			KDMYsoft.Model.Nhiber.S_Log model=new KDMYsoft.Model.Nhiber.S_Log();
			model.ID=ID;
			model.datetime=datetime;
			model.loginfo=loginfo;
			model.Particular=Particular;

			KDMYsoft.BLL.Nhiber.S_Log bll=new KDMYsoft.BLL.Nhiber.S_Log();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
