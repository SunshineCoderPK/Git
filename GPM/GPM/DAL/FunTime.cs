using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace GPM.DAL
{
	/// <summary>
	/// 数据访问类:FunTime
	/// </summary>
	public partial class FunTime
	{
		public FunTime()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("FunID", "FunTime"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FunID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FunTime");
			strSql.Append(" where FunID=SQL2012FunID");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012FunID", SqlDbType.Int,4)
			};
			parameters[0].Value = FunID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(GPM.Model.FunTime model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FunTime(");
			strSql.Append("FunName,BeginTime,EndTime)");
			strSql.Append(" values (");
			strSql.Append("SQL2012FunName,SQL2012BeginTime,SQL2012EndTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012FunName", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012BeginTime", SqlDbType.DateTime),
					new SqlParameter("SQL2012EndTime", SqlDbType.DateTime)};
			parameters[0].Value = model.FunName;
			parameters[1].Value = model.BeginTime;
			parameters[2].Value = model.EndTime;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(GPM.Model.FunTime model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FunTime set ");
			strSql.Append("FunName=SQL2012FunName,");
			strSql.Append("BeginTime=SQL2012BeginTime,");
			strSql.Append("EndTime=SQL2012EndTime");
			strSql.Append(" where FunID=SQL2012FunID");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012FunName", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012BeginTime", SqlDbType.DateTime),
					new SqlParameter("SQL2012EndTime", SqlDbType.DateTime),
					new SqlParameter("SQL2012FunID", SqlDbType.Int,4)};
			parameters[0].Value = model.FunName;
			parameters[1].Value = model.BeginTime;
			parameters[2].Value = model.EndTime;
			parameters[3].Value = model.FunID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int FunID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FunTime ");
			strSql.Append(" where FunID=SQL2012FunID");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012FunID", SqlDbType.Int,4)
			};
			parameters[0].Value = FunID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string FunIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FunTime ");
			strSql.Append(" where FunID in ("+FunIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public GPM.Model.FunTime GetModel(int FunID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 FunID,FunName,BeginTime,EndTime from FunTime ");
			strSql.Append(" where FunID=SQL2012FunID");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012FunID", SqlDbType.Int,4)
			};
			parameters[0].Value = FunID;

			GPM.Model.FunTime model=new GPM.Model.FunTime();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public GPM.Model.FunTime DataRowToModel(DataRow row)
		{
			GPM.Model.FunTime model=new GPM.Model.FunTime();
			if (row != null)
			{
				if(row["FunID"]!=null && row["FunID"].ToString()!="")
				{
					model.FunID=int.Parse(row["FunID"].ToString());
				}
				if(row["FunName"]!=null)
				{
					model.FunName=row["FunName"].ToString();
				}
				if(row["BeginTime"]!=null && row["BeginTime"].ToString()!="")
				{
					model.BeginTime=DateTime.Parse(row["BeginTime"].ToString());
				}
				if(row["EndTime"]!=null && row["EndTime"].ToString()!="")
				{
					model.EndTime=DateTime.Parse(row["EndTime"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select FunID,FunName,BeginTime,EndTime ");
			strSql.Append(" FROM FunTime ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" FunID,FunName,BeginTime,EndTime ");
			strSql.Append(" FROM FunTime ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM FunTime ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.FunID desc");
			}
			strSql.Append(")AS Row, T.*  from FunTime T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012tblName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012fldName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012PageSize", SqlDbType.Int),
					new SqlParameter("SQL2012PageIndex", SqlDbType.Int),
					new SqlParameter("SQL2012IsReCount", SqlDbType.Bit),
					new SqlParameter("SQL2012OrderType", SqlDbType.Bit),
					new SqlParameter("SQL2012strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "FunTime";
			parameters[1].Value = "FunID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

