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
	/// 实体类vw_FileManager 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_FileManager")]
	[Serializable]
	public partial class vw_FileManager : Entity 
	{
		#region Model
		private string _FSName;
		private string _MFilename;
		private DateTime _Indate;
		private int _FMID;
		private string _FSortCode;
		private string _State;
		private string _FName;
		private string _FromDept;
		private string _FromDeptCode;
		private string _Oper;
		private string _ifPub;
		/// <summary>
		/// 
		/// </summary>
		public string FSName
		{
			get{ return _FSName; }
			set
			{
				this.OnPropertyValueChange(_.FSName,_FSName,value);
				this._FSName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MFilename
		{
			get{ return _MFilename; }
			set
			{
				this.OnPropertyValueChange(_.MFilename,_MFilename,value);
				this._MFilename=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime Indate
		{
			get{ return _Indate; }
			set
			{
				this.OnPropertyValueChange(_.Indate,_Indate,value);
				this._Indate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int FMID
		{
			get{ return _FMID; }
			set
			{
				this.OnPropertyValueChange(_.FMID,_FMID,value);
				this._FMID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FSortCode
		{
			get{ return _FSortCode; }
			set
			{
				this.OnPropertyValueChange(_.FSortCode,_FSortCode,value);
				this._FSortCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string State
		{
			get{ return _State; }
			set
			{
				this.OnPropertyValueChange(_.State,_State,value);
				this._State=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FName
		{
			get{ return _FName; }
			set
			{
				this.OnPropertyValueChange(_.FName,_FName,value);
				this._FName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FromDept
		{
			get{ return _FromDept; }
			set
			{
				this.OnPropertyValueChange(_.FromDept,_FromDept,value);
				this._FromDept=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FromDeptCode
		{
			get{ return _FromDeptCode; }
			set
			{
				this.OnPropertyValueChange(_.FromDeptCode,_FromDeptCode,value);
				this._FromDeptCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Oper
		{
			get{ return _Oper; }
			set
			{
				this.OnPropertyValueChange(_.Oper,_Oper,value);
				this._Oper=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ifPub
		{
			get{ return _ifPub; }
			set
			{
				this.OnPropertyValueChange(_.ifPub,_ifPub,value);
				this._ifPub=value;
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
				_.FSName,
				_.MFilename,
				_.Indate,
				_.FMID,
				_.FSortCode,
				_.State,
				_.FName,
				_.FromDept,
				_.FromDeptCode,
				_.Oper,
				_.ifPub};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._FSName,
				this._MFilename,
				this._Indate,
				this._FMID,
				this._FSortCode,
				this._State,
				this._FName,
				this._FromDept,
				this._FromDeptCode,
				this._Oper,
				this._ifPub};
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
			public readonly static Field All = new Field("*","vw_FileManager");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FSName = new Field("FSName","vw_FileManager","FSName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MFilename = new Field("MFilename","vw_FileManager","MFilename");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Indate = new Field("Indate","vw_FileManager","Indate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FMID = new Field("FMID","vw_FileManager","FMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FSortCode = new Field("FSortCode","vw_FileManager","FSortCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","vw_FileManager","State");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FName = new Field("FName","vw_FileManager","FName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FromDept = new Field("FromDept","vw_FileManager","FromDept");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FromDeptCode = new Field("FromDeptCode","vw_FileManager","FromDeptCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Oper = new Field("Oper","vw_FileManager","Oper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ifPub = new Field("ifPub","vw_FileManager","ifPub");
		}
		#endregion


	}
}

