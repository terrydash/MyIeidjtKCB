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
	/// 实体类ExpGroupName 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("ExpGroupName")]
	[Serializable]
	public partial class ExpGroupName : Entity 
	{
		#region Model
		private int _EGNID;
		private int? _Deptid;
		private string _EGroupName;
		private string _Content;
		private int? _Nums;
		/// <summary>
		/// 
		/// </summary>
		public int EGNID
		{
			get{ return _EGNID; }
			set
			{
				this.OnPropertyValueChange(_.EGNID,_EGNID,value);
				this._EGNID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Deptid
		{
			get{ return _Deptid; }
			set
			{
				this.OnPropertyValueChange(_.Deptid,_Deptid,value);
				this._Deptid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EGroupName
		{
			get{ return _EGroupName; }
			set
			{
				this.OnPropertyValueChange(_.EGroupName,_EGroupName,value);
				this._EGroupName=value;
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
		public int? Nums
		{
			get{ return _Nums; }
			set
			{
				this.OnPropertyValueChange(_.Nums,_Nums,value);
				this._Nums=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.EGNID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.EGNID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.EGNID,
				_.Deptid,
				_.EGroupName,
				_.Content,
				_.Nums};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._EGNID,
				this._Deptid,
				this._EGroupName,
				this._Content,
				this._Nums};
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
			public readonly static Field All = new Field("*","ExpGroupName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EGNID = new Field("EGNID","ExpGroupName","EGNID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Deptid = new Field("Deptid","ExpGroupName","Deptid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EGroupName = new Field("EGroupName","ExpGroupName","EGroupName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","ExpGroupName","Content");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Nums = new Field("Nums","ExpGroupName","Nums");
		}
		#endregion


	}
}

