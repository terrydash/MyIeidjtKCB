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
	/// 实体类Stdlista 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("stdlista")]
	[Serializable]
	public partial class Stdlista : Entity 
	{
		#region Model
		private int _SID;
		private string _XH;
		private string _Yname;
		private DateTime? _SDate;
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
		public string XH
		{
			get{ return _XH; }
			set
			{
				this.OnPropertyValueChange(_.XH,_XH,value);
				this._XH=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Yname
		{
			get{ return _Yname; }
			set
			{
				this.OnPropertyValueChange(_.Yname,_Yname,value);
				this._Yname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SDate
		{
			get{ return _SDate; }
			set
			{
				this.OnPropertyValueChange(_.SDate,_SDate,value);
				this._SDate=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.SID,
				_.XH,
				_.Yname,
				_.SDate};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SID,
				this._XH,
				this._Yname,
				this._SDate};
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
			public readonly static Field All = new Field("*","stdlista");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SID = new Field("SID","stdlista","SID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field XH = new Field("XH","stdlista","XH");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Yname = new Field("Yname","stdlista","Yname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SDate = new Field("SDate","stdlista","SDate");
		}
		#endregion


	}
}
