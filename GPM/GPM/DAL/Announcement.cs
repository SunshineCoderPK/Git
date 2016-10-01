using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace GPM.DAL
{
	/// <summary>
	/// 数据访问类:Announcement
	/// </summary>
	public partial class Announcement
	{
		public Announcement()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("AntID", "Announcement"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AntID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Announcement");
			strSql.Append(" where AntID=SQL2012AntID");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012AntID", SqlDbType.Int,4)
			};
			parameters[0].Value = AntID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(GPM.Model.Announcement model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Announcement(");
			strSql.Append("Title,Contents,Time,Status)");
			strSql.Append(" values (");
			strSql.Append("SQL2012Title,SQL2012Contents,SQL2012Time,SQL2012Status)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012Title", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012Contents", SqlDbType.NVarChar,-1),
					new SqlParameter("SQL2012Time", SqlDbType.DateTime),
					new SqlParameter("SQL2012Status", SqlDbType.Bit,1)};
			parameters[0].Value = model.Title;
			parameters[1].Value = model.Contents;
			parameters[2].Value = model.Time;
			parameters[3].Value = model.Status;

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
		public bool Update(GPM.Model.Announcement model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Announcement set ");
			strSql.Append("Title=SQL2012Title,");
			strSql.Append("Contents=SQL2012Contents,");
			strSql.Append("Time=SQL2012Time,");
			strSql.Append("Status=SQL2012Status");
			strSql.Append(" where AntID=SQL2012AntID");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012Title", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012Contents", SqlDbType.NVarChar,-1),
					new SqlParameter("SQL2012Time", SqlDbType.DateTime),
					new SqlParameter("SQL2012Status", SqlDbType.Bit,1),
					new SqlParameter("SQL2012AntID", SqlDbType.Int,4)};
			parameters[0].Value = model.Title;
			parameters[1].Value = model.Contents;
			parameters[2].Value = model.Time;
			parameters[3].Value = model.Status;
			parameters[4].Value = model.AntID;

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
		public bool Delete(int AntID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Announcement ");
			strSql.Append(" where AntID=SQL2012AntID");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012AntID", SqlDbType.Int,4)
			};
			parameters[0].Value = AntID;

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
		public bool DeleteList(string AntIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Announcement ");
			strSql.Append(" where AntID in ("+AntIDlist + ")  ");
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
		public GPM.Model.Announcement GetModel(int AntID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 AntID,Title,Contents,Time,Status from Announcement ");
			strSql.Append(" where AntID=SQL2012AntID");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012AntID", SqlDbType.Int,4)
			};
			parameters[0].Value = AntID;

			GPM.Model.Announcement model=new GPM.Model.Announcement();
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
		public GPM.Model.Announcement DataRowToModel(DataRow row)
		{
			GPM.Model.Announcement model=new GPM.Model.Announcement();
			if (row != null)
			{
				if(row["AntID"]!=null && row["AntID"].ToString()!="")
				{
					model.AntID=int.Parse(row["AntID"].ToString());
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["Contents"]!=null)
				{
					model.Contents=row["Contents"].ToString();
				}
				if(row["Time"]!=null && row["Time"].ToString()!="")
				{
					model.Time=DateTime.Parse(row["Time"].ToString());
				}
				if(row["Status"]!=null && row["Status"].ToString()!="")
				{
					if((row["Status"].ToString()=="1")||(row["Status"].ToString().ToLower()=="true"))
					{
						model.Status=true;
					}
					else
					{
						model.Status=false;
					}
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
			strSql.Append("select AntID,Title,Contents,Time,Status ");
			strSql.Append(" FROM Announcement ");
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
			strSql.Append(" AntID,Title,Contents,Time,Status ");
			strSql.Append(" FROM Announcement ");
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
			strSql.Append("select count(1) FROM Announcement ");
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
				strSql.Append("order by T.AntID desc");
			}
			strSql.Append(")AS Row, T.*  from Announcement T ");
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
			parameters[0].Value = "Announcement";
			parameters[1].Value = "AntID";
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

