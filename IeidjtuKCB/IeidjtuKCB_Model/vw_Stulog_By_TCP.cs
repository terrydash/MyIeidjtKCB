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
	/// 实体类vw_Stulog_By_TCP 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Stulog_By_TCP")]
	[Serializable]
	public partial class vw_Stulog_By_TCP : Entity 
	{
		#region Model
		private int? _StdID;
		private int? _SPID;
		private int? _GradeID;
		private int? _DeptID;
		private string _GRName;
		private string _Password;
		private string _Gxkstate;
		private string _XKState;
		private int? _ATID;
		private string _StdCode;
		private string _state;
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
		public int? SPID
		{
			get{ return _SPID; }
			set
			{
				this.OnPropertyValueChange(_.SPID,_SPID,value);
				this._SPID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GradeID
		{
			get{ return _GradeID; }
			set
			{
				this.OnPropertyValueChange(_.GradeID,_GradeID,value);
				this._GradeID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DeptID
		{
			get{ return _DeptID; }
			set
			{
				this.OnPropertyValueChange(_.DeptID,_DeptID,value);
				this._DeptID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GRName
		{
			get{ return _GRName; }
			set
			{
				this.OnPropertyValueChange(_.GRName,_GRName,value);
				this._GRName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Password
		{
			get{ return _Password; }
			set
			{
				this.OnPropertyValueChange(_.Password,_Password,value);
				this._Password=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Gxkstate
		{
			get{ return _Gxkstate; }
			set
			{
				this.OnPropertyValueChange(_.Gxkstate,_Gxkstate,value);
				this._Gxkstate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XKState
		{
			get{ return _XKState; }
			set
			{
				this.OnPropertyValueChange(_.XKState,_XKState,value);
				this._XKState=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ATID
		{
			get{ return _ATID; }
			set
			{
				this.OnPropertyValueChange(_.ATID,_ATID,value);
				this._ATID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StdCode
		{
			get{ return _StdCode; }
			set
			{
				this.OnPropertyValueChange(_.StdCode,_StdCode,value);
				this._StdCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string state
		{
			get{ return _state; }
			set
			{
				this.OnPropertyValueChange(_.state,_state,value);
				this._state=value;
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
				_.StdID,
				_.SPID,
				_.GradeID,
				_.DeptID,
				_.GRName,
				_.Password,
				_.Gxkstate,
				_.XKState,
				_.ATID,
				_.StdCode,
				_.state};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._StdID,
				this._SPID,
				this._GradeID,
				this._DeptID,
				this._GRName,
				this._Password,
				this._Gxkstate,
				this._XKState,
				this._ATID,
				this._StdCode,
				this._state};
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
			public readonly static Field All = new Field("*","vw_Stulog_By_TCP");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdID = new Field("StdID","vw_Stulog_By_TCP","StdID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_Stulog_By_TCP","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GradeID = new Field("GradeID","vw_Stulog_By_TCP","GradeID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptID = new Field("DeptID","vw_Stulog_By_TCP","DeptID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRName = new Field("GRName","vw_Stulog_By_TCP","GRName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Password = new Field("Password","vw_Stulog_By_TCP","Password");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Gxkstate = new Field("Gxkstate","vw_Stulog_By_TCP","Gxkstate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field XKState = new Field("XKState","vw_Stulog_By_TCP","XKState");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATID = new Field("ATID","vw_Stulog_By_TCP","ATID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdCode = new Field("StdCode","vw_Stulog_By_TCP","StdCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field state = new Field("state","vw_Stulog_By_TCP","state");
		}
		#endregion


	}
}

