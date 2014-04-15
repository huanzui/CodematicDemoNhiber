using System;
namespace KDMYsoft.Model.Nhiber
{
	/// <summary>
	/// Accounts_Permissions:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Accounts_Permissions
	{
		public Accounts_Permissions()
		{}
		#region Model
		private int _permissionid;
		private string _description;
		private int? _categoryid;
		/// <summary>
		/// 
		/// </summary>
		public int PermissionID
		{
			set{ _permissionid=value;}
			get{return _permissionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CategoryID
		{
			set{ _categoryid=value;}
			get{return _categoryid;}
		}
		#endregion Model

	}
}

