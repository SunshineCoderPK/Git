﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace GPM.DAL
{
	/// <summary>
	/// 数据访问类:TeaGraProject
	/// </summary>
	public partial class TeaGraProject
	{
		public TeaGraProject()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ProID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TeaGraProject");
			strSql.Append(" where ProID=SQL2012ProID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ProID", SqlDbType.NVarChar,10)			};
			parameters[0].Value = ProID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(GPM.Model.TeaGraProject model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TeaGraProject(");
			strSql.Append("ProID,ProName,EmpNo,PulishTime,Department,Major)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ProID,SQL2012ProName,SQL2012EmpNo,SQL2012PulishTime,SQL2012Department,SQL2012Major)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ProID", SqlDbType.NVarChar,10),
					new SqlParameter("SQL2012ProName", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012EmpNo", SqlDbType.NVarChar,10),
					new SqlParameter("SQL2012PulishTime", SqlDbType.DateTime),
					new SqlParameter("SQL2012Department", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012Major", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.ProID;
			parameters[1].Value = model.ProName;
			parameters[2].Value = model.EmpNo;
			parameters[3].Value = model.PulishTime;
			parameters[4].Value = model.Department;
			parameters[5].Value = model.Major;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(GPM.Model.TeaGraProject model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TeaGraProject set ");
			strSql.Append("ProName=SQL2012ProName,");
			strSql.Append("EmpNo=SQL2012EmpNo,");
			strSql.Append("PulishTime=SQL2012PulishTime,");
			strSql.Append("Department=SQL2012Department,");
			strSql.Append("Major=SQL2012Major");
			strSql.Append(" where ProID=SQL2012ProID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ProName", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012EmpNo", SqlDbType.NVarChar,10),
					new SqlParameter("SQL2012PulishTime", SqlDbType.DateTime),
					new SqlParameter("SQL2012Department", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012Major", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012ProID", SqlDbType.NVarChar,10)};
			parameters[0].Value = model.ProName;
			parameters[1].Value = model.EmpNo;
			parameters[2].Value = model.PulishTime;
			parameters[3].Value = model.Department;
			parameters[4].Value = model.Major;
			parameters[5].Value = model.ProID;

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
		public bool Delete(string ProID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TeaGraProject ");
			strSql.Append(" where ProID=SQL2012ProID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ProID", SqlDbType.NVarChar,10)			};
			parameters[0].Value = ProID;

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
		public bool DeleteList(string ProIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TeaGraProject ");
			strSql.Append(" where ProID in ("+ProIDlist + ")  ");
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
		public GPM.Model.TeaGraProject GetModel(string ProID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ProID,ProName,EmpNo,PulishTime,Department,Major from TeaGraProject ");
			strSql.Append(" where ProID=SQL2012ProID ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ProID", SqlDbType.NVarChar,10)			};
			parameters[0].Value = ProID;

			GPM.Model.TeaGraProject model=new GPM.Model.TeaGraProject();
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
		public GPM.Model.TeaGraProject DataRowToModel(DataRow row)
		{
			GPM.Model.TeaGraProject model=new GPM.Model.TeaGraProject();
			if (row != null)
			{
				if(row["ProID"]!=null)
				{
					model.ProID=row["ProID"].ToString();
				}
				if(row["ProName"]!=null)
				{
					model.ProName=row["ProName"].ToString();
				}
				if(row["EmpNo"]!=null)
				{
					model.EmpNo=row["EmpNo"].ToString();
				}
				if(row["PulishTime"]!=null && row["PulishTime"].ToString()!="")
				{
					model.PulishTime=DateTime.Parse(row["PulishTime"].ToString());
				}
				if(row["Department"]!=null)
				{
					model.Department=row["Department"].ToString();
				}
				if(row["Major"]!=null)
				{
					model.Major=row["Major"].ToString();
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
			strSql.Append("select ProID,ProName,EmpNo,PulishTime,Department,Major ");
			strSql.Append(" FROM TeaGraProject ");
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
			strSql.Append(" ProID,ProName,EmpNo,PulishTime,Department,Major ");
			strSql.Append(" FROM TeaGraProject ");
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
			strSql.Append("select count(1) FROM TeaGraProject ");
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
				strSql.Append("order by T.ProID desc");
			}
			strSql.Append(")AS Row, T.*  from TeaGraProject T ");
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
			parameters[0].Value = "TeaGraProject";
			parameters[1].Value = "ProID";
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

