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
	/// 实体类ChargeCoding 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("ChargeCoding")]
	[Serializable]
	public partial class ChargeCoding : Entity 
	{
		#region Model
		private int _CHCID;
		private string _CHCDate;
		private string _CHCSort;
		private int? _UserID;
		private string _CHCCoding;
		private string _CXSort;
		/// <summary>
		/// 
		/// </summary>
		public int CHCID
		{
			get{ return _CHCID; }
			set
			{
				this.OnPropertyValueChange(_.CHCID,_CHCID,value);
				this._CHCID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CHCDate
		{
			get{ return _CHCDate; }
			set
			{
				this.OnPropertyValueChange(_.CHCDate,_CHCDate,value);
				this._CHCDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CHCSort
		{
			get{ return _CHCSort; }
			set
			{
				this.OnPropertyValueChange(_.CHCSort,_CHCSort,value);
				this._CHCSort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserID
		{
			get{ return _UserID; }
			set
			{
				this.OnPropertyValueChange(_.UserID,_UserID,value);
				this._UserID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CHCCoding
		{
			get{ return _CHCCoding; }
			set
			{
				this.OnPropertyValueChange(_.CHCCoding,_CHCCoding,value);
				this._CHCCoding=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CXSort
		{
			get{ return _CXSort; }
			set
			{
				this.OnPropertyValueChange(_.CXSort,_CXSort,value);
				this._CXSort=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.CHCID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.CHCID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.CHCID,
				_.CHCDate,
				_.CHCSort,
				_.UserID,
				_.CHCCoding,
				_.CXSort};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._CHCID,
				this._CHCDate,
				this._CHCSort,
				this._UserID,
				this._CHCCoding,
				this._CXSort};
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
			public readonly static Field All = new Field("*","ChargeCoding");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CHCID = new Field("CHCID","ChargeCoding","CHCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CHCDate = new Field("CHCDate","ChargeCoding","CHCDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CHCSort = new Field("CHCSort","ChargeCoding","CHCSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UserID = new Field("UserID","ChargeCoding","UserID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CHCCoding = new Field("CHCCoding","ChargeCoding","CHCCoding");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CXSort = new Field("CXSort","ChargeCoding","CXSort");
		}
		#endregion


	}
}

