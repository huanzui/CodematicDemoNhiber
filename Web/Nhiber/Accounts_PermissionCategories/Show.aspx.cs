﻿using System;
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
namespace KDMYsoft.Web.Nhiber.Accounts_PermissionCategories
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
					int CategoryID=(Convert.ToInt32(strid));
					ShowInfo(CategoryID);
				}
			}
		}
		
	private void ShowInfo(int CategoryID)
	{
		KDMYsoft.BLL.Nhiber.Accounts_PermissionCategories bll=new KDMYsoft.BLL.Nhiber.Accounts_PermissionCategories();
		KDMYsoft.Model.Nhiber.Accounts_PermissionCategories model=bll.GetModel(CategoryID);
		this.lblCategoryID.Text=model.CategoryID.ToString();
		this.lblDescription.Text=model.Description;

	}


    }
}
