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
	/// 实体类Form 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Form")]
	[Serializable]
	public partial class Form : Entity 
	{
		#region Model
		private int _FormID;
		private int? _CCID;
		private string _ChpNo;
		private string _ChpName;
		private string _FormNo;
		private string _FormName;
		private string _FormColm;
		private string _FormLine;
		private string _FormCont;
		private int? _Formtotal;
		private string _Formpost;
		/// <summary>
		/// 
		/// </summary>
		public int FormID
		{
			get{ return _FormID; }
			set
			{
				this.OnPropertyValueChange(_.FormID,_FormID,value);
				this._FormID=value;
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
		public string ChpNo
		{
			get{ return _ChpNo; }
			set
			{
				this.OnPropertyValueChange(_.ChpNo,_ChpNo,value);
				this._ChpNo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChpName
		{
			get{ return _ChpName; }
			set
			{
				this.OnPropertyValueChange(_.ChpName,_ChpName,value);
				this._ChpName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FormNo
		{
			get{ return _FormNo; }
			set
			{
				this.OnPropertyValueChange(_.FormNo,_FormNo,value);
				this._FormNo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FormName
		{
			get{ return _FormName; }
			set
			{
				this.OnPropertyValueChange(_.FormName,_FormName,value);
				this._FormName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FormColm
		{
			get{ return _FormColm; }
			set
			{
				this.OnPropertyValueChange(_.FormColm,_FormColm,value);
				this._FormColm=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FormLine
		{
			get{ return _FormLine; }
			set
			{
				this.OnPropertyValueChange(_.FormLine,_FormLine,value);
				this._FormLine=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FormCont
		{
			get{ return _FormCont; }
			set
			{
				this.OnPropertyValueChange(_.FormCont,_FormCont,value);
				this._FormCont=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Formtotal
		{
			get{ return _Formtotal; }
			set
			{
				this.OnPropertyValueChange(_.Formtotal,_Formtotal,value);
				this._Formtotal=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Formpost
		{
			get{ return _Formpost; }
			set
			{
				this.OnPropertyValueChange(_.Formpost,_Formpost,value);
				this._Formpost=value;
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
				_.FormID,
				_.CCID,
				_.ChpNo,
				_.ChpName,
				_.FormNo,
				_.FormName,
				_.FormColm,
				_.FormLine,
				_.FormCont,
				_.Formtotal,
				_.Formpost};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._FormID,
				this._CCID,
				this._ChpNo,
				this._ChpName,
				this._FormNo,
				this._FormName,
				this._FormColm,
				this._FormLine,
				this._FormCont,
				this._Formtotal,
				this._Formpost};
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
			public readonly static Field All = new Field("*","Form");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FormID = new Field("FormID","Form","FormID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","Form","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ChpNo = new Field("ChpNo","Form","ChpNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ChpName = new Field("ChpName","Form","ChpName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FormNo = new Field("FormNo","Form","FormNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FormName = new Field("FormName","Form","FormName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FormColm = new Field("FormColm","Form","FormColm");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FormLine = new Field("FormLine","Form","FormLine");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FormCont = new Field("FormCont","Form","FormCont");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Formtotal = new Field("Formtotal","Form","Formtotal");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Formpost = new Field("Formpost","Form","Formpost");
		}
		#endregion


	}
}
