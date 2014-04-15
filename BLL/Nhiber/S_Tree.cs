using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using KDMYsoft.Model.Nhiber;
namespace KDMYsoft.BLL.Nhiber
{
	/// <summary>
	/// S_Tree
	/// </summary>
	public partial class S_Tree
	{
		private readonly KDMYsoft.DAL.Nhiber.S_Tree dal=new KDMYsoft.DAL.Nhiber.S_Tree();
		public S_Tree()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int NodeID)
		{
			return dal.Exists(NodeID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KDMYsoft.Model.Nhiber.S_Tree model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(KDMYsoft.Model.Nhiber.S_Tree model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int NodeID)
		{
			
			return dal.Delete(NodeID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string NodeIDlist )
		{
			return dal.DeleteList(NodeIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public KDMYsoft.Model.Nhiber.S_Tree GetModel(int NodeID)
		{
			
			return dal.GetModel(NodeID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public KDMYsoft.Model.Nhiber.S_Tree GetModelByCache(int NodeID)
		{
			
			string CacheKey = "S_TreeModel-" + NodeID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(NodeID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (KDMYsoft.Model.Nhiber.S_Tree)objModel;
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
		public List<KDMYsoft.Model.Nhiber.S_Tree> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<KDMYsoft.Model.Nhiber.S_Tree> DataTableToList(DataTable dt)
		{
			List<KDMYsoft.Model.Nhiber.S_Tree> modelList = new List<KDMYsoft.Model.Nhiber.S_Tree>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				KDMYsoft.Model.Nhiber.S_Tree model;
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

