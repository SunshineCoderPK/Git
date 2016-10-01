using System;
namespace GPM.Model
{
	/// <summary>
	/// TeaGraProject:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TeaGraProject
	{
		public TeaGraProject()
		{}
		#region Model
		private string _proid;
		private string _proname;
		private string _empno;
		private DateTime? _pulishtime;
		private string _department;
		private string _major;
		/// <summary>
		/// 
		/// </summary>
		public string ProID
		{
			set{ _proid=value;}
			get{return _proid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProName
		{
			set{ _proname=value;}
			get{return _proname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EmpNo
		{
			set{ _empno=value;}
			get{return _empno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PulishTime
		{
			set{ _pulishtime=value;}
			get{return _pulishtime;}
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
		#endregion Model

	}
}

