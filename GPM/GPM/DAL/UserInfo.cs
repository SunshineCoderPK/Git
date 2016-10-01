using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace GPM.DAL
{
	/// <summary>
	/// 数据访问类:UserInfo
	/// </summary>
	public partial class UserInfo
	{
		public UserInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string StuOrEmpNo)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from UserInfo");
			strSql.Append(" where StuOrEmpNo=SQL2012StuOrEmpNo ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012StuOrEmpNo", SqlDbType.NVarChar,10)			};
			parameters[0].Value = StuOrEmpNo;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(GPM.Model.UserInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UserInfo(");
			strSql.Append("StuOrEmpNo,Name,Sex,Age,Department,Major,Class,GraduationYear,ResearchDirections,TelNo,RoleID,Teacher,Password)");
			strSql.Append(" values (");
			strSql.Append("SQL2012StuOrEmpNo,SQL2012Name,SQL2012Sex,SQL2012Age,SQL2012Department,SQL2012Major,SQL2012Class,SQL2012GraduationYear,SQL2012ResearchDirections,SQL2012TelNo,SQL2012RoleID,SQL2012Teacher,SQL2012Password)");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012StuOrEmpNo", SqlDbType.NVarChar,10),
					new SqlParameter("SQL2012Name", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012Sex", SqlDbType.Bit,1),
					new SqlParameter("SQL2012Age", SqlDbType.Int,4),
					new SqlParameter("SQL2012Department", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012Major", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012Class", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012GraduationYear", SqlDbType.Int,4),
					new SqlParameter("SQL2012ResearchDirections", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012TelNo", SqlDbType.NVarChar,11),
					new SqlParameter("SQL2012RoleID", SqlDbType.Int,4),
					new SqlParameter("SQL2012Teacher", SqlDbType.NVarChar,10),
					new SqlParameter("SQL2012Password", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.StuOrEmpNo;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Sex;
			parameters[3].Value = model.Age;
			parameters[4].Value = model.Department;
			parameters[5].Value = model.Major;
			parameters[6].Value = model.Class;
			parameters[7].Value = model.GraduationYear;
			parameters[8].Value = model.ResearchDirections;
			parameters[9].Value = model.TelNo;
			parameters[10].Value = model.RoleID;
			parameters[11].Value = model.Teacher;
			parameters[12].Value = model.Password;

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
		public bool Update(GPM.Model.UserInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UserInfo set ");
			strSql.Append("Name=SQL2012Name,");
			strSql.Append("Sex=SQL2012Sex,");
			strSql.Append("Age=SQL2012Age,");
			strSql.Append("Department=SQL2012Department,");
			strSql.Append("Major=SQL2012Major,");
			strSql.Append("Class=SQL2012Class,");
			strSql.Append("GraduationYear=SQL2012GraduationYear,");
			strSql.Append("ResearchDirections=SQL2012ResearchDirections,");
			strSql.Append("TelNo=SQL2012TelNo,");
			strSql.Append("RoleID=SQL2012RoleID,");
			strSql.Append("Teacher=SQL2012Teacher,");
			strSql.Append("Password=SQL2012Password");
			strSql.Append(" where StuOrEmpNo=SQL2012StuOrEmpNo ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012Name", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012Sex", SqlDbType.Bit,1),
					new SqlParameter("SQL2012Age", SqlDbType.Int,4),
					new SqlParameter("SQL2012Department", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012Major", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012Class", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012GraduationYear", SqlDbType.Int,4),
					new SqlParameter("SQL2012ResearchDirections", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012TelNo", SqlDbType.NVarChar,11),
					new SqlParameter("SQL2012RoleID", SqlDbType.Int,4),
					new SqlParameter("SQL2012Teacher", SqlDbType.NVarChar,10),
					new SqlParameter("SQL2012Password", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012StuOrEmpNo", SqlDbType.NVarChar,10)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.Sex;
			parameters[2].Value = model.Age;
			parameters[3].Value = model.Department;
			parameters[4].Value = model.Major;
			parameters[5].Value = model.Class;
			parameters[6].Value = model.GraduationYear;
			parameters[7].Value = model.ResearchDirections;
			parameters[8].Value = model.TelNo;
			parameters[9].Value = model.RoleID;
			parameters[10].Value = model.Teacher;
			parameters[11].Value = model.Password;
			parameters[12].Value = model.StuOrEmpNo;

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
		public bool Delete(string StuOrEmpNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserInfo ");
			strSql.Append(" where StuOrEmpNo=SQL2012StuOrEmpNo ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012StuOrEmpNo", SqlDbType.NVarChar,10)			};
			parameters[0].Value = StuOrEmpNo;

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
		public bool DeleteList(string StuOrEmpNolist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserInfo ");
			strSql.Append(" where StuOrEmpNo in ("+StuOrEmpNolist + ")  ");
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
		public GPM.Model.UserInfo GetModel(string StuOrEmpNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 StuOrEmpNo,Name,Sex,Age,Department,Major,Class,GraduationYear,ResearchDirections,TelNo,RoleID,Teacher,Password from UserInfo ");
			strSql.Append(" where StuOrEmpNo=SQL2012StuOrEmpNo ");
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012StuOrEmpNo", SqlDbType.NVarChar,10)			};
			parameters[0].Value = StuOrEmpNo;

			GPM.Model.UserInfo model=new GPM.Model.UserInfo();
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
		public GPM.Model.UserInfo DataRowToModel(DataRow row)
		{
			GPM.Model.UserInfo model=new GPM.Model.UserInfo();
			if (row != null)
			{
				if(row["StuOrEmpNo"]!=null)
				{
					model.StuOrEmpNo=row["StuOrEmpNo"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Sex"]!=null && row["Sex"].ToString()!="")
				{
					if((row["Sex"].ToString()=="1")||(row["Sex"].ToString().ToLower()=="true"))
					{
						model.Sex=true;
					}
					else
					{
						model.Sex=false;
					}
				}
				if(row["Age"]!=null && row["Age"].ToString()!="")
				{
					model.Age=int.Parse(row["Age"].ToString());
				}
				if(row["Department"]!=null)
				{
					model.Department=row["Department"].ToString();
				}
				if(row["Major"]!=null)
				{
					model.Major=row["Major"].ToString();
				}
				if(row["Class"]!=null)
				{
					model.Class=row["Class"].ToString();
				}
				if(row["GraduationYear"]!=null && row["GraduationYear"].ToString()!="")
				{
					model.GraduationYear=int.Parse(row["GraduationYear"].ToString());
				}
				if(row["ResearchDirections"]!=null)
				{
					model.ResearchDirections=row["ResearchDirections"].ToString();
				}
				if(row["TelNo"]!=null)
				{
					model.TelNo=row["TelNo"].ToString();
				}
				if(row["RoleID"]!=null && row["RoleID"].ToString()!="")
				{
					model.RoleID=int.Parse(row["RoleID"].ToString());
				}
				if(row["Teacher"]!=null)
				{
					model.Teacher=row["Teacher"].ToString();
				}
				if(row["Password"]!=null)
				{
					model.Password=row["Password"].ToString();
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
			strSql.Append("select StuOrEmpNo,Name,Sex,Age,Department,Major,Class,GraduationYear,ResearchDirections,TelNo,RoleID,Teacher,Password ");
			strSql.Append(" FROM UserInfo ");
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
			strSql.Append(" StuOrEmpNo,Name,Sex,Age,Department,Major,Class,GraduationYear,ResearchDirections,TelNo,RoleID,Teacher,Password ");
			strSql.Append(" FROM UserInfo ");
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
			strSql.Append("select count(1) FROM UserInfo ");
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
				strSql.Append("order by T.StuOrEmpNo desc");
			}
			strSql.Append(")AS Row, T.*  from UserInfo T ");
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
			parameters[0].Value = "UserInfo";
			parameters[1].Value = "StuOrEmpNo";
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

