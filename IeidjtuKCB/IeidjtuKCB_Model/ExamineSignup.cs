﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://ITdos.com/Dos/ORM/Index.html
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace IeidjtuKCB.Model
{

	/// <summary>
	/// 实体类ExamineSignup 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("ExamineSignup")]
	[Serializable]
	public partial class ExamineSignup : Entity 
	{
		#region Model
		private int _ESID;
		private int? _EMID;
		private int? _Atyid;
		private int? _StdID;
		private DateTime? _Signdate;
		private string _State;
		private int? _KCID;
		private string _Stdcode;
		private string _CLName;
		private int? _EMRID;
		private string _姓名;
		private string _性别;
		private string _年级;
		private string _校区;
		private string _学院;
		private string _系别;
		private string _专业;
		private string _学制;
		private string _入学年份;
		private string _准考证号;
		private string _考场号;
		private string _流水号;
		private string _成绩;
		private string _身份证号;
		private string _备注;
		private string _是否通过;
		private Guid? _ONID;
		private string _SchoolNo;
		private string _RGName;
		private string _YXDM;
		/// <summary>
		/// 
		/// </summary>
		public int ESID
		{
			get{ return _ESID; }
			set
			{
				this.OnPropertyValueChange(_.ESID,_ESID,value);
				this._ESID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EMID
		{
			get{ return _EMID; }
			set
			{
				this.OnPropertyValueChange(_.EMID,_EMID,value);
				this._EMID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Atyid
		{
			get{ return _Atyid; }
			set
			{
				this.OnPropertyValueChange(_.Atyid,_Atyid,value);
				this._Atyid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StdID
		{
			get{ return _StdID; }
			set
			{
				this.OnPropertyValueChange(_.StdID,_StdID,value);
				this._StdID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Signdate
		{
			get{ return _Signdate; }
			set
			{
				this.OnPropertyValueChange(_.Signdate,_Signdate,value);
				this._Signdate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string State
		{
			get{ return _State; }
			set
			{
				this.OnPropertyValueChange(_.State,_State,value);
				this._State=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? KCID
		{
			get{ return _KCID; }
			set
			{
				this.OnPropertyValueChange(_.KCID,_KCID,value);
				this._KCID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Stdcode
		{
			get{ return _Stdcode; }
			set
			{
				this.OnPropertyValueChange(_.Stdcode,_Stdcode,value);
				this._Stdcode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLName
		{
			get{ return _CLName; }
			set
			{
				this.OnPropertyValueChange(_.CLName,_CLName,value);
				this._CLName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EMRID
		{
			get{ return _EMRID; }
			set
			{
				this.OnPropertyValueChange(_.EMRID,_EMRID,value);
				this._EMRID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 姓名
		{
			get{ return _姓名; }
			set
			{
				this.OnPropertyValueChange(_.姓名,_姓名,value);
				this._姓名=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 性别
		{
			get{ return _性别; }
			set
			{
				this.OnPropertyValueChange(_.性别,_性别,value);
				this._性别=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 年级
		{
			get{ return _年级; }
			set
			{
				this.OnPropertyValueChange(_.年级,_年级,value);
				this._年级=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 校区
		{
			get{ return _校区; }
			set
			{
				this.OnPropertyValueChange(_.校区,_校区,value);
				this._校区=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 学院
		{
			get{ return _学院; }
			set
			{
				this.OnPropertyValueChange(_.学院,_学院,value);
				this._学院=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 系别
		{
			get{ return _系别; }
			set
			{
				this.OnPropertyValueChange(_.系别,_系别,value);
				this._系别=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 专业
		{
			get{ return _专业; }
			set
			{
				this.OnPropertyValueChange(_.专业,_专业,value);
				this._专业=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 学制
		{
			get{ return _学制; }
			set
			{
				this.OnPropertyValueChange(_.学制,_学制,value);
				this._学制=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 入学年份
		{
			get{ return _入学年份; }
			set
			{
				this.OnPropertyValueChange(_.入学年份,_入学年份,value);
				this._入学年份=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 准考证号
		{
			get{ return _准考证号; }
			set
			{
				this.OnPropertyValueChange(_.准考证号,_准考证号,value);
				this._准考证号=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 考场号
		{
			get{ return _考场号; }
			set
			{
				this.OnPropertyValueChange(_.考场号,_考场号,value);
				this._考场号=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 流水号
		{
			get{ return _流水号; }
			set
			{
				this.OnPropertyValueChange(_.流水号,_流水号,value);
				this._流水号=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 成绩
		{
			get{ return _成绩; }
			set
			{
				this.OnPropertyValueChange(_.成绩,_成绩,value);
				this._成绩=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 身份证号
		{
			get{ return _身份证号; }
			set
			{
				this.OnPropertyValueChange(_.身份证号,_身份证号,value);
				this._身份证号=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 备注
		{
			get{ return _备注; }
			set
			{
				this.OnPropertyValueChange(_.备注,_备注,value);
				this._备注=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 是否通过
		{
			get{ return _是否通过; }
			set
			{
				this.OnPropertyValueChange(_.是否通过,_是否通过,value);
				this._是否通过=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid? ONID
		{
			get{ return _ONID; }
			set
			{
				this.OnPropertyValueChange(_.ONID,_ONID,value);
				this._ONID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SchoolNo
		{
			get{ return _SchoolNo; }
			set
			{
				this.OnPropertyValueChange(_.SchoolNo,_SchoolNo,value);
				this._SchoolNo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RGName
		{
			get{ return _RGName; }
			set
			{
				this.OnPropertyValueChange(_.RGName,_RGName,value);
				this._RGName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YXDM
		{
			get{ return _YXDM; }
			set
			{
				this.OnPropertyValueChange(_.YXDM,_YXDM,value);
				this._YXDM=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.ESID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.ESID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ESID,
				_.EMID,
				_.Atyid,
				_.StdID,
				_.Signdate,
				_.State,
				_.KCID,
				_.Stdcode,
				_.CLName,
				_.EMRID,
				_.姓名,
				_.性别,
				_.年级,
				_.校区,
				_.学院,
				_.系别,
				_.专业,
				_.学制,
				_.入学年份,
				_.准考证号,
				_.考场号,
				_.流水号,
				_.成绩,
				_.身份证号,
				_.备注,
				_.是否通过,
				_.ONID,
				_.SchoolNo,
				_.RGName,
				_.YXDM};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ESID,
				this._EMID,
				this._Atyid,
				this._StdID,
				this._Signdate,
				this._State,
				this._KCID,
				this._Stdcode,
				this._CLName,
				this._EMRID,
				this._姓名,
				this._性别,
				this._年级,
				this._校区,
				this._学院,
				this._系别,
				this._专业,
				this._学制,
				this._入学年份,
				this._准考证号,
				this._考场号,
				this._流水号,
				this._成绩,
				this._身份证号,
				this._备注,
				this._是否通过,
				this._ONID,
				this._SchoolNo,
				this._RGName,
				this._YXDM};
		}
		#endregion

		#region _Field
		/// <summary>
		/// 字段信息
		/// </summary>
		public class _
		{
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*","ExamineSignup");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ESID = new Field("ESID","ExamineSignup","ESID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMID = new Field("EMID","ExamineSignup","EMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("Atyid","ExamineSignup","Atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdID = new Field("StdID","ExamineSignup","StdID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Signdate = new Field("Signdate","ExamineSignup","Signdate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("state","ExamineSignup","state");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KCID = new Field("KCID","ExamineSignup","KCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdcode = new Field("Stdcode","ExamineSignup","Stdcode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLName = new Field("CLName","ExamineSignup","CLName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMRID = new Field("EMRID","ExamineSignup","EMRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 姓名 = new Field("姓名","ExamineSignup","姓名");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 性别 = new Field("性别","ExamineSignup","性别");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 年级 = new Field("年级","ExamineSignup","年级");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 校区 = new Field("校区","ExamineSignup","校区");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学院 = new Field("学院","ExamineSignup","学院");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 系别 = new Field("系别","ExamineSignup","系别");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 专业 = new Field("专业","ExamineSignup","专业");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学制 = new Field("学制","ExamineSignup","学制");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 入学年份 = new Field("入学年份","ExamineSignup","入学年份");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 准考证号 = new Field("准考证号","ExamineSignup","准考证号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 考场号 = new Field("考场号","ExamineSignup","考场号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 流水号 = new Field("流水号","ExamineSignup","流水号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 成绩 = new Field("成绩","ExamineSignup","成绩");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 身份证号 = new Field("身份证号","ExamineSignup","身份证号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 备注 = new Field("备注","ExamineSignup","备注");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 是否通过 = new Field("是否通过","ExamineSignup","是否通过");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ONID = new Field("ONID","ExamineSignup","ONID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SchoolNo = new Field("SchoolNo","ExamineSignup","SchoolNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RGName = new Field("RGName","ExamineSignup","RGName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field YXDM = new Field("YXDM","ExamineSignup","YXDM");
		}
		#endregion


	}
}

