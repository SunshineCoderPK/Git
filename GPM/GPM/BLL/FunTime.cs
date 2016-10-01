using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using GPM.Model;
namespace GPM.BLL
{
	/// <summary>
	/// FunTime
	/// </summary>
	public partial class FunTime
	{
		private readonly GPM.DAL.FunTime dal=new GPM.DAL.FunTime();
		public FunTime()
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
		public bool Exists(int FunID)
		{
			return dal.Exists(FunID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(GPM.Model.FunTime model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(GPM.Model.FunTime model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int FunID)
		{
			
			return dal.Delete(FunID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string FunIDlist )
		{
			return dal.DeleteList(FunIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public GPM.Model.FunTime GetModel(int FunID)
		{
			
			return dal.GetModel(FunID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public GPM.Model.FunTime GetModelByCache(int FunID)
		{
			
			string CacheKey = "FunTimeModel-" + FunID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(FunID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (GPM.Model.FunTime)objModel;
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
		public List<GPM.Model.FunTime> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<GPM.Model.FunTime> DataTableToList(DataTable dt)
		{
			List<GPM.Model.FunTime> modelList = new List<GPM.Model.FunTime>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				GPM.Model.FunTime model;
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

