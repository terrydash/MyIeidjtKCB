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
	/// 实体类VW_ExamRmOwnSchol 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("VW_ExamRmOwnSchol")]
	[Serializable]
	public partial class VW_ExamRmOwnSchol : Entity 
	{
		#region Model
		private string _ExamDate;
		private int? _RoomID;
		private int _EXRID;
		private int? _ATYID;
		private int? _ClID;
		private int? _EMLID;
		private string _CCname;
		private string _ClassName;
		private string _CCode;
		private decimal? _Period;
		private int? _StuNum;
		private string _Sort;
		private string _CRname;
		private string _PSName;
		/// <summary>
		/// 
		/// </summary>
		public string ExamDate
		{
			get{ return _ExamDate; }
			set
			{
				this.OnPropertyValueChange(_.ExamDate,_ExamDate,value);
				this._ExamDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RoomID
		{
			get{ return _RoomID; }
			set
			{
				this.OnPropertyValueChange(_.RoomID,_RoomID,value);
				this._RoomID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int EXRID
		{
			get{ return _EXRID; }
			set
			{
				this.OnPropertyValueChange(_.EXRID,_EXRID,value);
				this._EXRID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ATYID
		{
			get{ return _ATYID; }
			set
			{
				this.OnPropertyValueChange(_.ATYID,_ATYID,value);
				this._ATYID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ClID
		{
			get{ return _ClID; }
			set
			{
				this.OnPropertyValueChange(_.ClID,_ClID,value);
				this._ClID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EMLID
		{
			get{ return _EMLID; }
			set
			{
				this.OnPropertyValueChange(_.EMLID,_EMLID,value);
				this._EMLID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CCname
		{
			get{ return _CCname; }
			set
			{
				this.OnPropertyValueChange(_.CCname,_CCname,value);
				this._CCname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClassName
		{
			get{ return _ClassName; }
			set
			{
				this.OnPropertyValueChange(_.ClassName,_ClassName,value);
				this._ClassName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CCode
		{
			get{ return _CCode; }
			set
			{
				this.OnPropertyValueChange(_.CCode,_CCode,value);
				this._CCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Period
		{
			get{ return _Period; }
			set
			{
				this.OnPropertyValueChange(_.Period,_Period,value);
				this._Period=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StuNum
		{
			get{ return _StuNum; }
			set
			{
				this.OnPropertyValueChange(_.StuNum,_StuNum,value);
				this._StuNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sort
		{
			get{ return _Sort; }
			set
			{
				this.OnPropertyValueChange(_.Sort,_Sort,value);
				this._Sort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CRname
		{
			get{ return _CRname; }
			set
			{
				this.OnPropertyValueChange(_.CRname,_CRname,value);
				this._CRname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PSName
		{
			get{ return _PSName; }
			set
			{
				this.OnPropertyValueChange(_.PSName,_PSName,value);
				this._PSName=value;
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
				_.ExamDate,
				_.RoomID,
				_.EXRID,
				_.ATYID,
				_.ClID,
				_.EMLID,
				_.CCname,
				_.ClassName,
				_.CCode,
				_.Period,
				_.StuNum,
				_.Sort,
				_.CRname,
				_.PSName};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ExamDate,
				this._RoomID,
				this._EXRID,
				this._ATYID,
				this._ClID,
				this._EMLID,
				this._CCname,
				this._ClassName,
				this._CCode,
				this._Period,
				this._StuNum,
				this._Sort,
				this._CRname,
				this._PSName};
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
			public readonly static Field All = new Field("*","VW_ExamRmOwnSchol");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExamDate = new Field("ExamDate","VW_ExamRmOwnSchol","ExamDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RoomID = new Field("RoomID","VW_ExamRmOwnSchol","RoomID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EXRID = new Field("EXRID","VW_ExamRmOwnSchol","EXRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATYID = new Field("ATYID","VW_ExamRmOwnSchol","ATYID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClID = new Field("ClID","VW_ExamRmOwnSchol","ClID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMLID = new Field("EMLID","VW_ExamRmOwnSchol","EMLID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCname = new Field("CCname","VW_ExamRmOwnSchol","CCname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassName = new Field("ClassName","VW_ExamRmOwnSchol","ClassName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCode = new Field("CCode","VW_ExamRmOwnSchol","CCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Period = new Field("Period","VW_ExamRmOwnSchol","Period");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StuNum = new Field("StuNum","VW_ExamRmOwnSchol","StuNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sort = new Field("Sort","VW_ExamRmOwnSchol","Sort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CRname = new Field("CRname","VW_ExamRmOwnSchol","CRname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSName = new Field("PSName","VW_ExamRmOwnSchol","PSName");
		}
		#endregion


	}
}
