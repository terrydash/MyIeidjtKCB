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
	/// 实体类SecExamine 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("SecExamine")]
	[Serializable]
	public partial class SecExamine : Entity 
	{
		#region Model
		private int _SEID;
		private int? _Atyid;
		private int? _Stdid;
		private int? _CCID;
		private int? _PSID;
		private int? _TCID;
		private int? _CLID;
		private int? _GRID;
		private string _Examine;
		private string _State;
		private string _Memo;
		private int? _TMID;
		/// <summary>
		/// 
		/// </summary>
		public int SEID
		{
			get{ return _SEID; }
			set
			{
				this.OnPropertyValueChange(_.SEID,_SEID,value);
				this._SEID=value;
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
		public int? Stdid
		{
			get{ return _Stdid; }
			set
			{
				this.OnPropertyValueChange(_.Stdid,_Stdid,value);
				this._Stdid=value;
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
		public int? TCID
		{
			get{ return _TCID; }
			set
			{
				this.OnPropertyValueChange(_.TCID,_TCID,value);
				this._TCID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CLID
		{
			get{ return _CLID; }
			set
			{
				this.OnPropertyValueChange(_.CLID,_CLID,value);
				this._CLID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GRID
		{
			get{ return _GRID; }
			set
			{
				this.OnPropertyValueChange(_.GRID,_GRID,value);
				this._GRID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Examine
		{
			get{ return _Examine; }
			set
			{
				this.OnPropertyValueChange(_.Examine,_Examine,value);
				this._Examine=value;
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
		public int? TMID
		{
			get{ return _TMID; }
			set
			{
				this.OnPropertyValueChange(_.TMID,_TMID,value);
				this._TMID=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.SEID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.SEID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.SEID,
				_.Atyid,
				_.Stdid,
				_.CCID,
				_.PSID,
				_.TCID,
				_.CLID,
				_.GRID,
				_.Examine,
				_.State,
				_.Memo,
				_.TMID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SEID,
				this._Atyid,
				this._Stdid,
				this._CCID,
				this._PSID,
				this._TCID,
				this._CLID,
				this._GRID,
				this._Examine,
				this._State,
				this._Memo,
				this._TMID};
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
			public readonly static Field All = new Field("*","SecExamine");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SEID = new Field("SEID","SecExamine","SEID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("atyid","SecExamine","atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdid = new Field("stdid","SecExamine","stdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","SecExamine","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","SecExamine","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","SecExamine","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLID = new Field("CLID","SecExamine","CLID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","SecExamine","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Examine = new Field("Examine","SecExamine","Examine");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("state","SecExamine","state");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("memo","SecExamine","memo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TMID = new Field("TMID","SecExamine","TMID");
		}
		#endregion


	}
}
