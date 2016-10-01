using System;
namespace GPM.Model
{
	/// <summary>
	/// UserInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class UserInfo
	{
		public UserInfo()
		{}
		#region Model
		private string _stuorempno;
		private string _name;
		private bool _sex;
		private int? _age;
		private string _department;
		private string _major;
		private string _class;
		private int? _graduationyear;
		private string _researchdirections;
		private string _telno;
		private int _roleid;
		private string _teacher;
		private string _password;
		/// <summary>
		/// 
		/// </summary>
		public string StuOrEmpNo
		{
			set{ _stuorempno=value;}
			get{return _stuorempno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Age
		{
			set{ _age=value;}
			get{return _age;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Department
		{
			set{ _department=value;}
			get{return _department;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Major
		{
			set{ _major=value;}
			get{return _major;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Class
		{
			set{ _class=value;}
			get{return _class;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GraduationYear
		{
			set{ _graduationyear=value;}
			get{return _graduationyear;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ResearchDirections
		{
			set{ _researchdirections=value;}
			get{return _researchdirections;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TelNo
		{
			set{ _telno=value;}
			get{return _telno;}
		}
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
		public string Teacher
		{
			set{ _teacher=value;}
			get{return _teacher;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
		}
		#endregion Model

	}
}

