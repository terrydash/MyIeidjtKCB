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
	/// 实体类SectionList3 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("SectionList3")]
	[Serializable]
	public partial class SectionList3 : Entity 
	{
		#region Model
		private int _SSID;
		private string _StartS;
		private string _SectionA;
		private string _SectionB;
		/// <summary>
		/// 
		/// </summary>
		public int SSID
		{
			get{ return _SSID; }
			set
			{
				this.OnPropertyValueChange(_.SSID,_SSID,value);
				this._SSID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StartS
		{
			get{ return _StartS; }
			set
			{
				this.OnPropertyValueChange(_.StartS,_StartS,value);
				this._StartS=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SectionA
		{
			get{ return _SectionA; }
			set
			{
				this.OnPropertyValueChange(_.SectionA,_SectionA,value);
				this._SectionA=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SectionB
		{
			get{ return _SectionB; }
			set
			{
				this.OnPropertyValueChange(_.SectionB,_SectionB,value);
				this._SectionB=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.SSID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.SSID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.SSID,
				_.StartS,
				_.SectionA,
				_.SectionB};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SSID,
				this._StartS,
				this._SectionA,
				this._SectionB};
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
			public readonly static Field All = new Field("*","SectionList3");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SSID = new Field("SSID","SectionList3","SSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StartS = new Field("StartS","SectionList3","StartS");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SectionA = new Field("SectionA","SectionList3","SectionA");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SectionB = new Field("SectionB","SectionList3","SectionB");
		}
		#endregion


	}
}
