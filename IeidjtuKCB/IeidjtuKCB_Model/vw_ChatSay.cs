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
	/// 实体类vw_ChatSay 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_ChatSay")]
	[Serializable]
	public partial class vw_ChatSay : Entity 
	{
		#region Model
		private int _CSID;
		private int? _CMID;
		private int? _CRID;
		private DateTime? _Saydate;
		private string _Content;
		private string _Username;
		private int? _SaytoAll;
		/// <summary>
		/// 
		/// </summary>
		public int CSID
		{
			get{ return _CSID; }
			set
			{
				this.OnPropertyValueChange(_.CSID,_CSID,value);
				this._CSID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CMID
		{
			get{ return _CMID; }
			set
			{
				this.OnPropertyValueChange(_.CMID,_CMID,value);
				this._CMID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CRID
		{
			get{ return _CRID; }
			set
			{
				this.OnPropertyValueChange(_.CRID,_CRID,value);
				this._CRID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Saydate
		{
			get{ return _Saydate; }
			set
			{
				this.OnPropertyValueChange(_.Saydate,_Saydate,value);
				this._Saydate=value;
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
		public string Username
		{
			get{ return _Username; }
			set
			{
				this.OnPropertyValueChange(_.Username,_Username,value);
				this._Username=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SaytoAll
		{
			get{ return _SaytoAll; }
			set
			{
				this.OnPropertyValueChange(_.SaytoAll,_SaytoAll,value);
				this._SaytoAll=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 是否只读
		/// </summary>
		public override bool IsReadOnly()
		{
			return true;
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.CSID,
				_.CMID,
				_.CRID,
				_.Saydate,
				_.Content,
				_.Username,
				_.SaytoAll};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._CSID,
				this._CMID,
				this._CRID,
				this._Saydate,
				this._Content,
				this._Username,
				this._SaytoAll};
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
			public readonly static Field All = new Field("*","vw_ChatSay");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CSID = new Field("CSID","vw_ChatSay","CSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CMID = new Field("CMID","vw_ChatSay","CMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CRID = new Field("CRID","vw_ChatSay","CRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Saydate = new Field("Saydate","vw_ChatSay","Saydate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","vw_ChatSay","Content");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Username = new Field("Username","vw_ChatSay","Username");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SaytoAll = new Field("SaytoAll","vw_ChatSay","SaytoAll");
		}
		#endregion


	}
}

