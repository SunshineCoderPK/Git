using System;
namespace GPM.Model
{
	/// <summary>
	/// FunTime:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FunTime
	{
		public FunTime()
		{}
		#region Model
		private int _funid;
		private string _funname;
		private DateTime? _begintime;
		private DateTime? _endtime;
		/// <summary>
		/// 
		/// </summary>
		public int FunID
		{
			set{ _funid=value;}
			get{return _funid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FunName
		{
			set{ _funname=value;}
			get{return _funname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BeginTime
		{
			set{ _begintime=value;}
			get{return _begintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EndTime
		{
			set{ _endtime=value;}
			get{return _endtime;}
		}
		#endregion Model

	}
}

