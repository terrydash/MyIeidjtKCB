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
	/// 实体类vw_Workplan 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Workplan")]
	[Serializable]
	public partial class vw_Workplan : Entity 
	{
		#region Model
		private int _WPID;
		private string _WPDate;
		private string _WPTitle;
		private string _Content;
		private string _Deptcode;
		private int? _PSID;
		private int? _UID;
		private string _OPer;
		private string _MKDate;
		private int? _WeekNo;
		private string _ifpub;
		private string _State;
		private string _Memo;
		private int? _DeptID;
		private string _DeptName;
		private int? _APMID;
		private int? _ToRole;
		private string _PsortName;
		private int? _PIID;
		private string _WPNo;
		private DateTime? _OverDate;
		private string _ToOper;
		/// <summary>
		/// 
		/// </summary>
		public int WPID
		{
			get{ return _WPID; }
			set
			{
				this.OnPropertyValueChange(_.WPID,_WPID,value);
				this._WPID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WPDate
		{
			get{ return _WPDate; }
			set
			{
				this.OnPropertyValueChange(_.WPDate,_WPDate,value);
				this._WPDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WPTitle
		{
			get{ return _WPTitle; }
			set
			{
				this.OnPropertyValueChange(_.WPTitle,_WPTitle,value);
				this._WPTitle=value;
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
		public string Deptcode
		{
			get{ return _Deptcode; }
			set
			{
				this.OnPropertyValueChange(_.Deptcode,_Deptcode,value);
				this._Deptcode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PSID
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
		public int? UID
		{
			get{ return _UID; }
			set
			{
				this.OnPropertyValueChange(_.UID,_UID,value);
				this._UID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OPer
		{
			get{ return _OPer; }
			set
			{
				this.OnPropertyValueChange(_.OPer,_OPer,value);
				this._OPer=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MKDate
		{
			get{ return _MKDate; }
			set
			{
				this.OnPropertyValueChange(_.MKDate,_MKDate,value);
				this._MKDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? WeekNo
		{
			get{ return _WeekNo; }
			set
			{
				this.OnPropertyValueChange(_.WeekNo,_WeekNo,value);
				this._WeekNo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ifpub
		{
			get{ return _ifpub; }
			set
			{
				this.OnPropertyValueChange(_.ifpub,_ifpub,value);
				this._ifpub=value;
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
		public string Memo
		{
			get{ return _Memo; }
			set
			{
				this.OnPropertyValueChange(_.Memo,_Memo,value);
				this._Memo=value;
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
		public string DeptName
		{
			get{ return _DeptName; }
			set
			{
				this.OnPropertyValueChange(_.DeptName,_DeptName,value);
				this._DeptName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? APMID
		{
			get{ return _APMID; }
			set
			{
				this.OnPropertyValueChange(_.APMID,_APMID,value);
				this._APMID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ToRole
		{
			get{ return _ToRole; }
			set
			{
				this.OnPropertyValueChange(_.ToRole,_ToRole,value);
				this._ToRole=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PsortName
		{
			get{ return _PsortName; }
			set
			{
				this.OnPropertyValueChange(_.PsortName,_PsortName,value);
				this._PsortName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PIID
		{
			get{ return _PIID; }
			set
			{
				this.OnPropertyValueChange(_.PIID,_PIID,value);
				this._PIID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WPNo
		{
			get{ return _WPNo; }
			set
			{
				this.OnPropertyValueChange(_.WPNo,_WPNo,value);
				this._WPNo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OverDate
		{
			get{ return _OverDate; }
			set
			{
				this.OnPropertyValueChange(_.OverDate,_OverDate,value);
				this._OverDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ToOper
		{
			get{ return _ToOper; }
			set
			{
				this.OnPropertyValueChange(_.ToOper,_ToOper,value);
				this._ToOper=value;
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
				_.WPID,
				_.WPDate,
				_.WPTitle,
				_.Content,
				_.Deptcode,
				_.PSID,
				_.UID,
				_.OPer,
				_.MKDate,
				_.WeekNo,
				_.ifpub,
				_.State,
				_.Memo,
				_.DeptID,
				_.DeptName,
				_.APMID,
				_.ToRole,
				_.PsortName,
				_.PIID,
				_.WPNo,
				_.OverDate,
				_.ToOper};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._WPID,
				this._WPDate,
				this._WPTitle,
				this._Content,
				this._Deptcode,
				this._PSID,
				this._UID,
				this._OPer,
				this._MKDate,
				this._WeekNo,
				this._ifpub,
				this._State,
				this._Memo,
				this._DeptID,
				this._DeptName,
				this._APMID,
				this._ToRole,
				this._PsortName,
				this._PIID,
				this._WPNo,
				this._OverDate,
				this._ToOper};
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
			public readonly static Field All = new Field("*","vw_Workplan");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field WPID = new Field("WPID","vw_Workplan","WPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field WPDate = new Field("WPDate","vw_Workplan","WPDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field WPTitle = new Field("WPTitle","vw_Workplan","WPTitle");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","vw_Workplan","Content");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Deptcode = new Field("Deptcode","vw_Workplan","Deptcode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","vw_Workplan","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UID = new Field("UID","vw_Workplan","UID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OPer = new Field("OPer","vw_Workplan","OPer");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MKDate = new Field("MKDate","vw_Workplan","MKDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field WeekNo = new Field("WeekNo","vw_Workplan","WeekNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ifpub = new Field("ifpub","vw_Workplan","ifpub");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","vw_Workplan","State");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","vw_Workplan","Memo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptID = new Field("DeptID","vw_Workplan","DeptID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptName = new Field("DeptName","vw_Workplan","DeptName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APMID = new Field("APMID","vw_Workplan","APMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ToRole = new Field("ToRole","vw_Workplan","ToRole");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PsortName = new Field("PsortName","vw_Workplan","PsortName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PIID = new Field("PIID","vw_Workplan","PIID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field WPNo = new Field("WPNo","vw_Workplan","WPNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OverDate = new Field("OverDate","vw_Workplan","OverDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ToOper = new Field("ToOper","vw_Workplan","ToOper");
		}
		#endregion


	}
}
