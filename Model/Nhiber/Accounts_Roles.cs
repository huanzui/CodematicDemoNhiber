using System;
namespace KDMYsoft.Model.Nhiber
{
	/// <summary>
	/// Accounts_Roles:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Accounts_Roles
	{
		public Accounts_Roles()
		{}
		#region Model
		private int _roleid;
		private string _description;
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
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		#endregion Model

	}
}

