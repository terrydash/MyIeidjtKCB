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
	/// 实体类EPlanContent 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("EPlanContent")]
	[Serializable]
	public partial class EPlanContent : Entity 
	{
		#region Model
		private int _EPCID;
		private int? _EMID;
		private int? _EMPID;
		private string _Content;
		/// <summary>
		/// 
		/// </summary>
		public int EPCID
		{
			get{ return _EPCID; }
			set
			{
				this.OnPropertyValueChange(_.EPCID,_EPCID,value);
				this._EPCID=value;
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
		public int? EMPID
		{
			get{ return _EMPID; }
			set
			{
				this.OnPropertyValueChange(_.EMPID,_EMPID,value);
				this._EMPID=value;
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
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.EPCID;
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.EPCID,
				_.EMID,
				_.EMPID,
				_.Content};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._EPCID,
				this._EMID,
				this._EMPID,
				this._Content};
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
			public readonly static Field All = new Field("*","EPlanContent");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EPCID = new Field("EPCID","EPlanContent","EPCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMID = new Field("EMID","EPlanContent","EMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMPID = new Field("EMPID","EPlanContent","EMPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","EPlanContent","Content");
		}
		#endregion


	}
}
