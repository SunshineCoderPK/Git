using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace GPM.DAL
{
	/// <summary>
	/// 数据访问类:StuGraProject
	/// </summary>
	public partial class StuGraProject
	{
		public StuGraProject()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(GPM.Model.StuGraProject model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into StuGraProject(");
			strSql.Append("ProID,StuNo,OpenReport,MidReport,EndReport,OpenGrade,MidGrade,EndGrade,OpenRemark,MidRemark,EndRemark,Stage)");
			strSql.Append(" values (");
			strSql.Append("SQL2012ProID,SQL2012StuNo,SQL2012OpenReport,SQL2012MidReport,SQL2012EndReport,SQL2012OpenGrade,SQL2012MidGrade,SQL2012EndGrade,SQL2012OpenRemark,SQL2012MidRemark,SQL2012EndRemark,SQL2012Stage)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ProID", SqlDbType.NVarChar,10),
					new SqlParameter("SQL2012StuNo", SqlDbType.NVarChar,10),
					new SqlParameter("SQL2012OpenReport", SqlDbType.NVarChar,-1),
					new SqlParameter("SQL2012MidReport", SqlDbType.NVarChar,-1),
					new SqlParameter("SQL2012EndReport", SqlDbType.NVarChar,-1),
					new SqlParameter("SQL2012OpenGrade", SqlDbType.Float,8),
					new SqlParameter("SQL2012MidGrade", SqlDbType.Float,8),
					new SqlParameter("SQL2012EndGrade", SqlDbType.Float,8),
					new SqlParameter("SQL2012OpenRemark", SqlDbType.NVarChar,-1),
					new SqlParameter("SQL2012MidRemark", SqlDbType.NVarChar,-1),
					new SqlParameter("SQL2012EndRemark", SqlDbType.NVarChar,-1),
					new SqlParameter("SQL2012Stage", SqlDbType.Int,4)};
			parameters[0].Value = model.ProID;
			parameters[1].Value = model.StuNo;
			parameters[2].Value = model.OpenReport;
			parameters[3].Value = model.MidReport;
			parameters[4].Value = model.EndReport;
			parameters[5].Value = model.OpenGrade;
			parameters[6].Value = model.MidGrade;
			parameters[7].Value = model.EndGrade;
			parameters[8].Value = model.OpenRemark;
			parameters[9].Value = model.MidRemark;
			parameters[10].Value = model.EndRemark;
			parameters[11].Value = model.Stage;

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
		public bool Update(GPM.Model.StuGraProject model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update StuGraProject set ");
			strSql.Append("ProID=SQL2012ProID,");
			strSql.Append("StuNo=SQL2012StuNo,");
			strSql.Append("OpenReport=SQL2012OpenReport,");
			strSql.Append("MidReport=SQL2012MidReport,");
			strSql.Append("EndReport=SQL2012EndReport,");
			strSql.Append("OpenGrade=SQL2012OpenGrade,");
			strSql.Append("MidGrade=SQL2012MidGrade,");
			strSql.Append("EndGrade=SQL2012EndGrade,");
			strSql.Append("OpenRemark=SQL2012OpenRemark,");
			strSql.Append("MidRemark=SQL2012MidRemark,");
			strSql.Append("EndRemark=SQL2012EndRemark,");
			strSql.Append("Stage=SQL2012Stage");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012ProID", SqlDbType.NVarChar,10),
					new SqlParameter("SQL2012StuNo", SqlDbType.NVarChar,10),
					new SqlParameter("SQL2012OpenReport", SqlDbType.NVarChar,-1),
					new SqlParameter("SQL2012MidReport", SqlDbType.NVarChar,-1),
					new SqlParameter("SQL2012EndReport", SqlDbType.NVarChar,-1),
					new SqlParameter("SQL2012OpenGrade", SqlDbType.Float,8),
					new SqlParameter("SQL2012MidGrade", SqlDbType.Float,8),
					new SqlParameter("SQL2012EndGrade", SqlDbType.Float,8),
					new SqlParameter("SQL2012OpenRemark", SqlDbType.NVarChar,-1),
					new SqlParameter("SQL2012MidRemark", SqlDbType.NVarChar,-1),
					new SqlParameter("SQL2012EndRemark", SqlDbType.NVarChar,-1),
					new SqlParameter("SQL2012Stage", SqlDbType.Int,4)};
			parameters[0].Value = model.ProID;
			parameters[1].Value = model.StuNo;
			parameters[2].Value = model.OpenReport;
			parameters[3].Value = model.MidReport;
			parameters[4].Value = model.EndReport;
			parameters[5].Value = model.OpenGrade;
			parameters[6].Value = model.MidGrade;
			parameters[7].Value = model.EndGrade;
			parameters[8].Value = model.OpenRemark;
			parameters[9].Value = model.MidRemark;
			parameters[10].Value = model.EndRemark;
			parameters[11].Value = model.Stage;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from StuGraProject ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public GPM.Model.StuGraProject GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ProID,StuNo,OpenReport,MidReport,EndReport,OpenGrade,MidGrade,EndGrade,OpenRemark,MidRemark,EndRemark,Stage from StuGraProject ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			GPM.Model.StuGraProject model=new GPM.Model.StuGraProject();
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
		public GPM.Model.StuGraProject DataRowToModel(DataRow row)
		{
			GPM.Model.StuGraProject model=new GPM.Model.StuGraProject();
			if (row != null)
			{
				if(row["ProID"]!=null)
				{
					model.ProID=row["ProID"].ToString();
				}
				if(row["StuNo"]!=null)
				{
					model.StuNo=row["StuNo"].ToString();
				}
				if(row["OpenReport"]!=null)
				{
					model.OpenReport=row["OpenReport"].ToString();
				}
				if(row["MidReport"]!=null)
				{
					model.MidReport=row["MidReport"].ToString();
				}
				if(row["EndReport"]!=null)
				{
					model.EndReport=row["EndReport"].ToString();
				}
				if(row["OpenGrade"]!=null && row["OpenGrade"].ToString()!="")
				{
					model.OpenGrade=decimal.Parse(row["OpenGrade"].ToString());
				}
				if(row["MidGrade"]!=null && row["MidGrade"].ToString()!="")
				{
					model.MidGrade=decimal.Parse(row["MidGrade"].ToString());
				}
				if(row["EndGrade"]!=null && row["EndGrade"].ToString()!="")
				{
					model.EndGrade=decimal.Parse(row["EndGrade"].ToString());
				}
				if(row["OpenRemark"]!=null)
				{
					model.OpenRemark=row["OpenRemark"].ToString();
				}
				if(row["MidRemark"]!=null)
				{
					model.MidRemark=row["MidRemark"].ToString();
				}
				if(row["EndRemark"]!=null)
				{
					model.EndRemark=row["EndRemark"].ToString();
				}
				if(row["Stage"]!=null && row["Stage"].ToString()!="")
				{
					model.Stage=int.Parse(row["Stage"].ToString());
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
			strSql.Append("select ProID,StuNo,OpenReport,MidReport,EndReport,OpenGrade,MidGrade,EndGrade,OpenRemark,MidRemark,EndRemark,Stage ");
			strSql.Append(" FROM StuGraProject ");
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
			strSql.Append(" ProID,StuNo,OpenReport,MidReport,EndReport,OpenGrade,MidGrade,EndGrade,OpenRemark,MidRemark,EndRemark,Stage ");
			strSql.Append(" FROM StuGraProject ");
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
			strSql.Append("select count(1) FROM StuGraProject ");
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
			strSql.Append(")AS Row, T.*  from StuGraProject T ");
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
			parameters[0].Value = "StuGraProject";
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

