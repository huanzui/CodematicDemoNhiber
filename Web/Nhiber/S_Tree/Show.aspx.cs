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
namespace KDMYsoft.Web.Nhiber.S_Tree
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
					int NodeID=(Convert.ToInt32(strid));
					ShowInfo(NodeID);
				}
			}
		}
		
	private void ShowInfo(int NodeID)
	{
		KDMYsoft.BLL.Nhiber.S_Tree bll=new KDMYsoft.BLL.Nhiber.S_Tree();
		KDMYsoft.Model.Nhiber.S_Tree model=bll.GetModel(NodeID);
		this.lblNodeID.Text=model.NodeID.ToString();
		this.lblText.Text=model.Text;
		this.lblParentID.Text=model.ParentID.ToString();
		this.lblParentPath.Text=model.ParentPath;
		this.lblLocation.Text=model.Location;
		this.lblOrderID.Text=model.OrderID.ToString();
		this.lblcomment.Text=model.comment;
		this.lblUrl.Text=model.Url;
		this.lblPermissionID.Text=model.PermissionID.ToString();
		this.lblImageUrl.Text=model.ImageUrl;
		this.lblModuleID.Text=model.ModuleID.ToString();
		this.lblKeShiDM.Text=model.KeShiDM.ToString();
		this.lblKeshiPublic.Text=model.KeshiPublic;

	}


    }
}
