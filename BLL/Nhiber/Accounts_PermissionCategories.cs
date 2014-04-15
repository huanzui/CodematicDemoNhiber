using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using KDMYsoft.Model.Nhiber;
namespace KDMYsoft.BLL.Nhiber
{
	/// <summary>
	/// Accounts_PermissionCategories
	/// </summary>
	public partial class Accounts_PermissionCategories
	{
		private readonly KDMYsoft.DAL.Nhiber.Accounts_PermissionCategories dal=new KDMYsoft.DAL.Nhiber.Accounts_PermissionCategories();
		public Accounts_PermissionCategories()
		{}
		#region  BasicMethod

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(KDMYsoft.Model.Nhiber.Accounts_PermissionCategories model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(KDMYsoft.Model.Nhiber.Accounts_PermissionCategories model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int CategoryID)
		{
			
			return dal.Delete(CategoryID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string CategoryIDlist )
		{
			return dal.DeleteList(CategoryIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public KDMYsoft.Model.Nhiber.Accounts_PermissionCategories GetModel(int CategoryID)
		{
			
			return dal.GetModel(CategoryID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public KDMYsoft.Model.Nhiber.Accounts_PermissionCategories GetModelByCache(int CategoryID)
		{
			
			string CacheKey = "Accounts_PermissionCategoriesModel-" + CategoryID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(CategoryID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (KDMYsoft.Model.Nhiber.Accounts_PermissionCategories)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<KDMYsoft.Model.Nhiber.Accounts_PermissionCategories> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<KDMYsoft.Model.Nhiber.Accounts_PermissionCategories> DataTableToList(DataTable dt)
		{
			List<KDMYsoft.Model.Nhiber.Accounts_PermissionCategories> modelList = new List<KDMYsoft.Model.Nhiber.Accounts_PermissionCategories>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				KDMYsoft.Model.Nhiber.Accounts_PermissionCategories model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

