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
	/// 实体类vw_StuagainApp_Get 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_StuagainApp_Get")]
	[Serializable]
	public partial class vw_StuagainApp_Get : Entity 
	{
		#region Model
		private int? _AtyID;
		private int? _EPID;
		private int? _CCID;
		private string _MState;
		private string _课程名称;
		private string _课程代码;
		private decimal? _学分;
		private int? _StdID;
		private int _CXID;
		/// <summary>
		/// 
		/// </summary>
		public int? AtyID
		{
			get{ return _AtyID; }
			set
			{
				this.OnPropertyValueChange(_.AtyID,_AtyID,value);
				this._AtyID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EPID
		{
			get{ return _EPID; }
			set
			{
				this.OnPropertyValueChange(_.EPID,_EPID,value);
				this._EPID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CCID
		{
			get{ return _CCID; }
			set
			{
				this.OnPropertyValueChange(_.CCID,_CCID,value);
				this._CCID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MState
		{
			get{ return _MState; }
			set
			{
				this.OnPropertyValueChange(_.MState,_MState,value);
				this._MState=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 课程名称
		{
			get{ return _课程名称; }
			set
			{
				this.OnPropertyValueChange(_.课程名称,_课程名称,value);
				this._课程名称=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 课程代码
		{
			get{ return _课程代码; }
			set
			{
				this.OnPropertyValueChange(_.课程代码,_课程代码,value);
				this._课程代码=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 学分
		{
			get{ return _学分; }
			set
			{
				this.OnPropertyValueChange(_.学分,_学分,value);
				this._学分=value;
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
		public int CXID
		{
			get{ return _CXID; }
			set
			{
				this.OnPropertyValueChange(_.CXID,_CXID,value);
				this._CXID=value;
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
				_.AtyID,
				_.EPID,
				_.CCID,
				_.MState,
				_.课程名称,
				_.课程代码,
				_.学分,
				_.StdID,
				_.CXID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._AtyID,
				this._EPID,
				this._CCID,
				this._MState,
				this._课程名称,
				this._课程代码,
				this._学分,
				this._StdID,
				this._CXID};
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
			public readonly static Field All = new Field("*","vw_StuagainApp_Get");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AtyID = new Field("AtyID","vw_StuagainApp_Get","AtyID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EPID = new Field("EPID","vw_StuagainApp_Get","EPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_StuagainApp_Get","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MState = new Field("MState","vw_StuagainApp_Get","MState");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 课程名称 = new Field("课程名称","vw_StuagainApp_Get","课程名称");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 课程代码 = new Field("课程代码","vw_StuagainApp_Get","课程代码");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学分 = new Field("学分","vw_StuagainApp_Get","学分");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdID = new Field("StdID","vw_StuagainApp_Get","StdID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CXID = new Field("CXID","vw_StuagainApp_Get","CXID");
		}
		#endregion


	}
}
