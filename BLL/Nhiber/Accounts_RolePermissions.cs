﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using KDMYsoft.Model.Nhiber;
namespace KDMYsoft.BLL.Nhiber
{
	/// <summary>
	/// Accounts_RolePermissions
	/// </summary>
	public partial class Accounts_RolePermissions
	{
		private readonly KDMYsoft.DAL.Nhiber.Accounts_RolePermissions dal=new KDMYsoft.DAL.Nhiber.Accounts_RolePermissions();
		public Accounts_RolePermissions()
		{}
		#region  BasicMethod

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KDMYsoft.Model.Nhiber.Accounts_RolePermissions model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(KDMYsoft.Model.Nhiber.Accounts_RolePermissions model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.Delete();
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public KDMYsoft.Model.Nhiber.Accounts_RolePermissions GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.GetModel();
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public KDMYsoft.Model.Nhiber.Accounts_RolePermissions GetModelByCache()
		{
			//该表无主键信息，请自定义主键/条件字段
			string CacheKey = "Accounts_RolePermissionsModel-" ;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel();
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (KDMYsoft.Model.Nhiber.Accounts_RolePermissions)objModel;
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
		public List<KDMYsoft.Model.Nhiber.Accounts_RolePermissions> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<KDMYsoft.Model.Nhiber.Accounts_RolePermissions> DataTableToList(DataTable dt)
		{
			List<KDMYsoft.Model.Nhiber.Accounts_RolePermissions> modelList = new List<KDMYsoft.Model.Nhiber.Accounts_RolePermissions>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				KDMYsoft.Model.Nhiber.Accounts_RolePermissions model;
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

