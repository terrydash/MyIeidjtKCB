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
	/// 实体类PKTemp 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("PKTemp")]
	[Serializable]
	public partial class PKTemp : Entity 
	{
		#region Model
		private int _PKTID;
		private int? _TempID;
		/// <summary>
		/// 
		/// </summary>
		public int PKTID
		{
			get{ return _PKTID; }
			set
			{
				this.OnPropertyValueChange(_.PKTID,_PKTID,value);
				this._PKTID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TempID
		{
			get{ return _TempID; }
			set
			{
				this.OnPropertyValueChange(_.TempID,_TempID,value);
				this._TempID=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.PKTID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.PKTID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.PKTID,
				_.TempID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._PKTID,
				this._TempID};
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
			public readonly static Field All = new Field("*","PKTemp");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PKTID = new Field("PKTID","PKTemp","PKTID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TempID = new Field("TempID","PKTemp","TempID");
		}
		#endregion


	}
}
