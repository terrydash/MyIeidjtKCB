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
	/// 实体类SciChkManage 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("SciChkManage")]
	[Serializable]
	public partial class SciChkManage : Entity 
	{
		#region Model
		private int _SCID;
		private int? _JDID;
		private int? _PID;
		private int? _DID;
		private string _People;
		private string _Dept;
		private string _DeptCode;
		private string _ItemLev;
		private int? _Sorce;
		private string _ChkPeople;
		private string _ChkDate;
		private string _RtuFilePeople;
		private string _RtuFileDate;
		private string _State;
		/// <summary>
		/// 
		/// </summary>
		public int SCID
		{
			get{ return _SCID; }
			set
			{
				this.OnPropertyValueChange(_.SCID,_SCID,value);
				this._SCID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? JDID
		{
			get{ return _JDID; }
			set
			{
				this.OnPropertyValueChange(_.JDID,_JDID,value);
				this._JDID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PID
		{
			get{ return _PID; }
			set
			{
				this.OnPropertyValueChange(_.PID,_PID,value);
				this._PID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DID
		{
			get{ return _DID; }
			set
			{
				this.OnPropertyValueChange(_.DID,_DID,value);
				this._DID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string People
		{
			get{ return _People; }
			set
			{
				this.OnPropertyValueChange(_.People,_People,value);
				this._People=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Dept
		{
			get{ return _Dept; }
			set
			{
				this.OnPropertyValueChange(_.Dept,_Dept,value);
				this._Dept=value;
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
		/// <summary>
		/// 
		/// </summary>
		public string ItemLev
		{
			get{ return _ItemLev; }
			set
			{
				this.OnPropertyValueChange(_.ItemLev,_ItemLev,value);
				this._ItemLev=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Sorce
		{
			get{ return _Sorce; }
			set
			{
				this.OnPropertyValueChange(_.Sorce,_Sorce,value);
				this._Sorce=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChkPeople
		{
			get{ return _ChkPeople; }
			set
			{
				this.OnPropertyValueChange(_.ChkPeople,_ChkPeople,value);
				this._ChkPeople=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChkDate
		{
			get{ return _ChkDate; }
			set
			{
				this.OnPropertyValueChange(_.ChkDate,_ChkDate,value);
				this._ChkDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RtuFilePeople
		{
			get{ return _RtuFilePeople; }
			set
			{
				this.OnPropertyValueChange(_.RtuFilePeople,_RtuFilePeople,value);
				this._RtuFilePeople=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RtuFileDate
		{
			get{ return _RtuFileDate; }
			set
			{
				this.OnPropertyValueChange(_.RtuFileDate,_RtuFileDate,value);
				this._RtuFileDate=value;
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
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.SCID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.SCID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.SCID,
				_.JDID,
				_.PID,
				_.DID,
				_.People,
				_.Dept,
				_.DeptCode,
				_.ItemLev,
				_.Sorce,
				_.ChkPeople,
				_.ChkDate,
				_.RtuFilePeople,
				_.RtuFileDate,
				_.State};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SCID,
				this._JDID,
				this._PID,
				this._DID,
				this._People,
				this._Dept,
				this._DeptCode,
				this._ItemLev,
				this._Sorce,
				this._ChkPeople,
				this._ChkDate,
				this._RtuFilePeople,
				this._RtuFileDate,
				this._State};
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
			public readonly static Field All = new Field("*","SciChkManage");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SCID = new Field("SCID","SciChkManage","SCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field JDID = new Field("JDID","SciChkManage","JDID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PID = new Field("PID","SciChkManage","PID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DID = new Field("DID","SciChkManage","DID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field People = new Field("People","SciChkManage","People");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Dept = new Field("Dept","SciChkManage","Dept");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptCode = new Field("DeptCode","SciChkManage","DeptCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ItemLev = new Field("ItemLev","SciChkManage","ItemLev");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sorce = new Field("Sorce","SciChkManage","Sorce");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ChkPeople = new Field("ChkPeople","SciChkManage","ChkPeople");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ChkDate = new Field("ChkDate","SciChkManage","ChkDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RtuFilePeople = new Field("RtuFilePeople","SciChkManage","RtuFilePeople");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RtuFileDate = new Field("RtuFileDate","SciChkManage","RtuFileDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","SciChkManage","State");
		}
		#endregion


	}
}
