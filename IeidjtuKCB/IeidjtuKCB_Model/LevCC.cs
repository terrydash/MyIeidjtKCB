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
	/// 实体类LevCC 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("LevCC")]
	[Serializable]
	public partial class LevCC : Entity 
	{
		#region Model
		private int _LCID;
		private int? _Atyid;
		private int? _CCID;
		private string _Memo;
		/// <summary>
		/// 
		/// </summary>
		public int LCID
		{
			get{ return _LCID; }
			set
			{
				this.OnPropertyValueChange(_.LCID,_LCID,value);
				this._LCID=value;
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
		public string Memo
		{
			get{ return _Memo; }
			set
			{
				this.OnPropertyValueChange(_.Memo,_Memo,value);
				this._Memo=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.LCID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.LCID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.LCID,
				_.Atyid,
				_.CCID,
				_.Memo};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._LCID,
				this._Atyid,
				this._CCID,
				this._Memo};
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
			public readonly static Field All = new Field("*","LevCC");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LCID = new Field("LCID","LevCC","LCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("Atyid","LevCC","Atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","LevCC","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","LevCC","Memo");
		}
		#endregion


	}
}

