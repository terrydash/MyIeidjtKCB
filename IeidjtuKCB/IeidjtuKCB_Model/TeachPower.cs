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
	/// 实体类TeachPower 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("TeachPower")]
	[Serializable]
	public partial class TeachPower : Entity 
	{
		#region Model
		private int _TPID;
		private int? _TRoleID;
		private int? _CCID;
		private int? _TFunID;
		private int? _PSID;
		/// <summary>
		/// 
		/// </summary>
		public int TPID
		{
			get{ return _TPID; }
			set
			{
				this.OnPropertyValueChange(_.TPID,_TPID,value);
				this._TPID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TRoleID
		{
			get{ return _TRoleID; }
			set
			{
				this.OnPropertyValueChange(_.TRoleID,_TRoleID,value);
				this._TRoleID=value;
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
		public int? TFunID
		{
			get{ return _TFunID; }
			set
			{
				this.OnPropertyValueChange(_.TFunID,_TFunID,value);
				this._TFunID=value;
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
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.TPID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.TPID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.TPID,
				_.TRoleID,
				_.CCID,
				_.TFunID,
				_.PSID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TPID,
				this._TRoleID,
				this._CCID,
				this._TFunID,
				this._PSID};
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
			public readonly static Field All = new Field("*","TeachPower");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TPID = new Field("TPID","TeachPower","TPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TRoleID = new Field("TRoleID","TeachPower","TRoleID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","TeachPower","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TFunID = new Field("TFunID","TeachPower","TFunID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","TeachPower","PSID");
		}
		#endregion


	}
}

