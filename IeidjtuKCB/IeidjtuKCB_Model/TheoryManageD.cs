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
	/// 实体类TheoryManageD 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("TheoryManageD")]
	[Serializable]
	public partial class TheoryManageD : Entity 
	{
		#region Model
		private int _TID;
		private int? _TMID;
		private int? _TSID;
		private string _Sorce;
		/// <summary>
		/// 
		/// </summary>
		public int TID
		{
			get{ return _TID; }
			set
			{
				this.OnPropertyValueChange(_.TID,_TID,value);
				this._TID=value;
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
		/// <summary>
		/// 
		/// </summary>
		public int? TSID
		{
			get{ return _TSID; }
			set
			{
				this.OnPropertyValueChange(_.TSID,_TSID,value);
				this._TSID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sorce
		{
			get{ return _Sorce; }
			set
			{
				this.OnPropertyValueChange(_.Sorce,_Sorce,value);
				this._Sorce=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.TID;
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.TID,
				_.TMID,
				_.TSID,
				_.Sorce};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TID,
				this._TMID,
				this._TSID,
				this._Sorce};
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
			public readonly static Field All = new Field("*","TheoryManageD");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TID = new Field("TID","TheoryManageD","TID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TMID = new Field("TMID","TheoryManageD","TMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TSID = new Field("TSID","TheoryManageD","TSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sorce = new Field("Sorce","TheoryManageD","Sorce");
		}
		#endregion


	}
}

