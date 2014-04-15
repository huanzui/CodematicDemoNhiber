using System;
namespace KDMYsoft.Model.Nhiber
{
	/// <summary>
	/// Accounts_RolePermissions:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Accounts_RolePermissions
	{
		public Accounts_RolePermissions()
		{}
		#region Model
		private int _roleid;
		private int _permissionid;
		/// <summary>
		/// 
		/// </summary>
		public int RoleID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PermissionID
		{
			set{ _permissionid=value;}
			get{return _permissionid;}
		}
		#endregion Model

	}
}

