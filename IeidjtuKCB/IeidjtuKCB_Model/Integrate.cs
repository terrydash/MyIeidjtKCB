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
	/// 实体类Integrate 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Integrate")]
	[Serializable]
	public partial class Integrate : Entity 
	{
		#region Model
		private int _IGID;
		private string _GLcodeS;
		private string _GLCodeD;
		/// <summary>
		/// 
		/// </summary>
		public int IGID
		{
			get{ return _IGID; }
			set
			{
				this.OnPropertyValueChange(_.IGID,_IGID,value);
				this._IGID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLcodeS
		{
			get{ return _GLcodeS; }
			set
			{
				this.OnPropertyValueChange(_.GLcodeS,_GLcodeS,value);
				this._GLcodeS=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLCodeD
		{
			get{ return _GLCodeD; }
			set
			{
				this.OnPropertyValueChange(_.GLCodeD,_GLCodeD,value);
				this._GLCodeD=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.IGID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.IGID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.IGID,
				_.GLcodeS,
				_.GLCodeD};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._IGID,
				this._GLcodeS,
				this._GLCodeD};
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
			public readonly static Field All = new Field("*","Integrate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IGID = new Field("IGID","Integrate","IGID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GLcodeS = new Field("GLcodeS","Integrate","GLcodeS");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GLCodeD = new Field("GLCodeD","Integrate","GLCodeD");
		}
		#endregion


	}
}

