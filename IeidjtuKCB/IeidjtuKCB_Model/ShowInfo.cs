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
	/// 实体类ShowInfo 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("ShowInfo")]
	[Serializable]
	public partial class ShowInfo : Entity 
	{
		#region Model
		private int _SID;
		private string _PName;
		private string _Html;
		/// <summary>
		/// 
		/// </summary>
		public int SID
		{
			get{ return _SID; }
			set
			{
				this.OnPropertyValueChange(_.SID,_SID,value);
				this._SID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PName
		{
			get{ return _PName; }
			set
			{
				this.OnPropertyValueChange(_.PName,_PName,value);
				this._PName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Html
		{
			get{ return _Html; }
			set
			{
				this.OnPropertyValueChange(_.Html,_Html,value);
				this._Html=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.SID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.SID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.SID,
				_.PName,
				_.Html};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SID,
				this._PName,
				this._Html};
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
			public readonly static Field All = new Field("*","ShowInfo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SID = new Field("SID","ShowInfo","SID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PName = new Field("PName","ShowInfo","PName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Html = new Field("Html","ShowInfo","Html");
		}
		#endregion


	}
}

