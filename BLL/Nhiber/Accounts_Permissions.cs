using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using KDMYsoft.Model.Nhiber;
namespace KDMYsoft.BLL.Nhiber
{
	/// <summary>
	/// Accounts_Permissions
	/// </summary>
	public partial class Accounts_Permissions
	{
		private readonly KDMYsoft.DAL.Nhiber.Accounts_Permissions dal=new KDMYsoft.DAL.Nhiber.Accounts_Permissions();
		public Accounts_Permissions()
		{}
		#region  BasicMethod

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(KDMYsoft.Model.Nhiber.Accounts_Permissions model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(KDMYsoft.Model.Nhiber.Accounts_Permissions model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int PermissionID)
		{
			
			return dal.Delete(PermissionID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string PermissionIDlist )
		{
			return dal.DeleteList(PermissionIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public KDMYsoft.Model.Nhiber.Accounts_Permissions GetModel(int PermissionID)
		{
			
			return dal.GetModel(PermissionID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public KDMYsoft.Model.Nhiber.Accounts_Permissions GetModelByCache(int PermissionID)
		{
			
			string CacheKey = "Accounts_PermissionsModel-" + PermissionID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(PermissionID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (KDMYsoft.Model.Nhiber.Accounts_Permissions)objModel;
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
		public List<KDMYsoft.Model.Nhiber.Accounts_Permissions> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<KDMYsoft.Model.Nhiber.Accounts_Permissions> DataTableToList(DataTable dt)
		{
			List<KDMYsoft.Model.Nhiber.Accounts_Permissions> modelList = new List<KDMYsoft.Model.Nhiber.Accounts_Permissions>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				KDMYsoft.Model.Nhiber.Accounts_Permissions model;
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

