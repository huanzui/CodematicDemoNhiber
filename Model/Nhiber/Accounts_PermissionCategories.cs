using System;
namespace KDMYsoft.Model.Nhiber
{
	/// <summary>
	/// Accounts_PermissionCategories:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Accounts_PermissionCategories
	{
		public Accounts_PermissionCategories()
		{}
		#region Model
		private int _categoryid;
		private string _description;
		/// <summary>
		/// 
		/// </summary>
		public int CategoryID
		{
			set{ _categoryid=value;}
			get{return _categoryid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		#endregion Model

	}
}

