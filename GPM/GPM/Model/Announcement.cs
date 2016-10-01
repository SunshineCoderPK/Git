using System;
namespace GPM.Model
{
	/// <summary>
	/// Announcement:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Announcement
	{
		public Announcement()
		{}
		#region Model
		private int _antid;
		private string _title;
		private string _contents;
		private DateTime? _time;
		private bool _status;
		/// <summary>
		/// 
		/// </summary>
		public int AntID
		{
			set{ _antid=value;}
			get{return _antid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Contents
		{
			set{ _contents=value;}
			get{return _contents;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		#endregion Model

	}
}

