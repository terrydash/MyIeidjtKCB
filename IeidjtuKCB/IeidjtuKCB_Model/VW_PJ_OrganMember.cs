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
	/// 实体类VW_PJ_OrganMember 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("VW_PJ_OrganMember")]
	[Serializable]
	public partial class VW_PJ_OrganMember : Entity 
	{
		#region Model
		private int _MBID;
		private string _PSID;
		private string _StdID;
		private string _MemberCode;
		private int? _UnitID;
		private string _OrgCode;
		private string _OrgName;
		private int? _DTID;
		private string _DTName;
		private string _State;
		private string _MBCode;
		private string _MBName;
		private string _DutyName;
		private string _DutyCode;
		private int? _OrgID;
		private string _Content;
		private string _DeptCode;
		/// <summary>
		/// 
		/// </summary>
		public int MBID
		{
			get{ return _MBID; }
			set
			{
				this.OnPropertyValueChange(_.MBID,_MBID,value);
				this._MBID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PSID
		{
			get{ return _PSID; }
			set
			{
				this.OnPropertyValueChange(_.PSID,_PSID,value);
				this._PSID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StdID
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
		public string MemberCode
		{
			get{ return _MemberCode; }
			set
			{
				this.OnPropertyValueChange(_.MemberCode,_MemberCode,value);
				this._MemberCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UnitID
		{
			get{ return _UnitID; }
			set
			{
				this.OnPropertyValueChange(_.UnitID,_UnitID,value);
				this._UnitID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrgCode
		{
			get{ return _OrgCode; }
			set
			{
				this.OnPropertyValueChange(_.OrgCode,_OrgCode,value);
				this._OrgCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrgName
		{
			get{ return _OrgName; }
			set
			{
				this.OnPropertyValueChange(_.OrgName,_OrgName,value);
				this._OrgName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DTID
		{
			get{ return _DTID; }
			set
			{
				this.OnPropertyValueChange(_.DTID,_DTID,value);
				this._DTID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DTName
		{
			get{ return _DTName; }
			set
			{
				this.OnPropertyValueChange(_.DTName,_DTName,value);
				this._DTName=value;
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
		public string MBCode
		{
			get{ return _MBCode; }
			set
			{
				this.OnPropertyValueChange(_.MBCode,_MBCode,value);
				this._MBCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MBName
		{
			get{ return _MBName; }
			set
			{
				this.OnPropertyValueChange(_.MBName,_MBName,value);
				this._MBName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DutyName
		{
			get{ return _DutyName; }
			set
			{
				this.OnPropertyValueChange(_.DutyName,_DutyName,value);
				this._DutyName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DutyCode
		{
			get{ return _DutyCode; }
			set
			{
				this.OnPropertyValueChange(_.DutyCode,_DutyCode,value);
				this._DutyCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OrgID
		{
			get{ return _OrgID; }
			set
			{
				this.OnPropertyValueChange(_.OrgID,_OrgID,value);
				this._OrgID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Content
		{
			get{ return _Content; }
			set
			{
				this.OnPropertyValueChange(_.Content,_Content,value);
				this._Content=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeptCode
		{
			get{ return _DeptCode; }
			set
			{
				this.OnPropertyValueChange(_.DeptCode,_DeptCode,value);
				this._DeptCode=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 是否只读
		/// </summary>
		public override bool IsReadOnly()
		{
			return true;
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.MBID,
				_.PSID,
				_.StdID,
				_.MemberCode,
				_.UnitID,
				_.OrgCode,
				_.OrgName,
				_.DTID,
				_.DTName,
				_.State,
				_.MBCode,
				_.MBName,
				_.DutyName,
				_.DutyCode,
				_.OrgID,
				_.Content,
				_.DeptCode};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._MBID,
				this._PSID,
				this._StdID,
				this._MemberCode,
				this._UnitID,
				this._OrgCode,
				this._OrgName,
				this._DTID,
				this._DTName,
				this._State,
				this._MBCode,
				this._MBName,
				this._DutyName,
				this._DutyCode,
				this._OrgID,
				this._Content,
				this._DeptCode};
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
			public readonly static Field All = new Field("*","VW_PJ_OrganMember");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MBID = new Field("MBID","VW_PJ_OrganMember","MBID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","VW_PJ_OrganMember","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdID = new Field("StdID","VW_PJ_OrganMember","StdID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MemberCode = new Field("MemberCode","VW_PJ_OrganMember","MemberCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UnitID = new Field("UnitID","VW_PJ_OrganMember","UnitID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OrgCode = new Field("OrgCode","VW_PJ_OrganMember","OrgCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OrgName = new Field("OrgName","VW_PJ_OrganMember","OrgName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DTID = new Field("DTID","VW_PJ_OrganMember","DTID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DTName = new Field("DTName","VW_PJ_OrganMember","DTName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","VW_PJ_OrganMember","State");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MBCode = new Field("MBCode","VW_PJ_OrganMember","MBCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MBName = new Field("MBName","VW_PJ_OrganMember","MBName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DutyName = new Field("DutyName","VW_PJ_OrganMember","DutyName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DutyCode = new Field("DutyCode","VW_PJ_OrganMember","DutyCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OrgID = new Field("OrgID","VW_PJ_OrganMember","OrgID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","VW_PJ_OrganMember","Content");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptCode = new Field("DeptCode","VW_PJ_OrganMember","DeptCode");
		}
		#endregion


	}
}

