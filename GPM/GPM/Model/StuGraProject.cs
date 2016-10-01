using System;
namespace GPM.Model
{
	/// <summary>
	/// StuGraProject:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class StuGraProject
	{
		public StuGraProject()
		{}
		#region Model
		private string _proid;
		private string _stuno;
		private string _openreport;
		private string _midreport;
		private string _endreport;
		private decimal? _opengrade;
		private decimal? _midgrade;
		private decimal? _endgrade;
		private string _openremark;
		private string _midremark;
		private string _endremark;
		private int _stage;
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
		public string StuNo
		{
			set{ _stuno=value;}
			get{return _stuno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OpenReport
		{
			set{ _openreport=value;}
			get{return _openreport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MidReport
		{
			set{ _midreport=value;}
			get{return _midreport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EndReport
		{
			set{ _endreport=value;}
			get{return _endreport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OpenGrade
		{
			set{ _opengrade=value;}
			get{return _opengrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MidGrade
		{
			set{ _midgrade=value;}
			get{return _midgrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? EndGrade
		{
			set{ _endgrade=value;}
			get{return _endgrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OpenRemark
		{
			set{ _openremark=value;}
			get{return _openremark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MidRemark
		{
			set{ _midremark=value;}
			get{return _midremark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EndRemark
		{
			set{ _endremark=value;}
			get{return _endremark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Stage
		{
			set{ _stage=value;}
			get{return _stage;}
		}
		#endregion Model

	}
}

