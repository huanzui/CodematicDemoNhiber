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
namespace KDMYsoft.Web.Nhiber.S_Tree
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int NodeID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(NodeID);
				}
			}
		}
			
	private void ShowInfo(int NodeID)
	{
		KDMYsoft.BLL.Nhiber.S_Tree bll=new KDMYsoft.BLL.Nhiber.S_Tree();
		KDMYsoft.Model.Nhiber.S_Tree model=bll.GetModel(NodeID);
		this.lblNodeID.Text=model.NodeID.ToString();
		this.txtText.Text=model.Text;
		this.txtParentID.Text=model.ParentID.ToString();
		this.txtParentPath.Text=model.ParentPath;
		this.txtLocation.Text=model.Location;
		this.txtOrderID.Text=model.OrderID.ToString();
		this.txtcomment.Text=model.comment;
		this.txtUrl.Text=model.Url;
		this.txtPermissionID.Text=model.PermissionID.ToString();
		this.txtImageUrl.Text=model.ImageUrl;
		this.txtModuleID.Text=model.ModuleID.ToString();
		this.txtKeShiDM.Text=model.KeShiDM.ToString();
		this.txtKeshiPublic.Text=model.KeshiPublic;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtText.Text.Trim().Length==0)
			{
				strErr+="Text不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtParentID.Text))
			{
				strErr+="ParentID格式错误！\\n";	
			}
			if(this.txtParentPath.Text.Trim().Length==0)
			{
				strErr+="ParentPath不能为空！\\n";	
			}
			if(this.txtLocation.Text.Trim().Length==0)
			{
				strErr+="Location不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOrderID.Text))
			{
				strErr+="OrderID格式错误！\\n";	
			}
			if(this.txtcomment.Text.Trim().Length==0)
			{
				strErr+="comment不能为空！\\n";	
			}
			if(this.txtUrl.Text.Trim().Length==0)
			{
				strErr+="Url不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPermissionID.Text))
			{
				strErr+="PermissionID格式错误！\\n";	
			}
			if(this.txtImageUrl.Text.Trim().Length==0)
			{
				strErr+="ImageUrl不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtModuleID.Text))
			{
				strErr+="ModuleID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtKeShiDM.Text))
			{
				strErr+="KeShiDM格式错误！\\n";	
			}
			if(this.txtKeshiPublic.Text.Trim().Length==0)
			{
				strErr+="KeshiPublic不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int NodeID=int.Parse(this.lblNodeID.Text);
			string Text=this.txtText.Text;
			int ParentID=int.Parse(this.txtParentID.Text);
			string ParentPath=this.txtParentPath.Text;
			string Location=this.txtLocation.Text;
			int OrderID=int.Parse(this.txtOrderID.Text);
			string comment=this.txtcomment.Text;
			string Url=this.txtUrl.Text;
			int PermissionID=int.Parse(this.txtPermissionID.Text);
			string ImageUrl=this.txtImageUrl.Text;
			int ModuleID=int.Parse(this.txtModuleID.Text);
			int KeShiDM=int.Parse(this.txtKeShiDM.Text);
			string KeshiPublic=this.txtKeshiPublic.Text;


			KDMYsoft.Model.Nhiber.S_Tree model=new KDMYsoft.Model.Nhiber.S_Tree();
			model.NodeID=NodeID;
			model.Text=Text;
			model.ParentID=ParentID;
			model.ParentPath=ParentPath;
			model.Location=Location;
			model.OrderID=OrderID;
			model.comment=comment;
			model.Url=Url;
			model.PermissionID=PermissionID;
			model.ImageUrl=ImageUrl;
			model.ModuleID=ModuleID;
			model.KeShiDM=KeShiDM;
			model.KeshiPublic=KeshiPublic;

			KDMYsoft.BLL.Nhiber.S_Tree bll=new KDMYsoft.BLL.Nhiber.S_Tree();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
