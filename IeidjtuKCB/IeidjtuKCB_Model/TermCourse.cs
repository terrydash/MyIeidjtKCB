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
	/// 实体类TermCourse 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("TermCourse")]
	[Serializable]
	public partial class TermCourse : Entity 
	{
		#region Model
		private int _TCMID;
		private int? _Atyid;
		private int? _CCID;
		private int? _StuNum;
		private int? _MaxStuNum;
		private int? _OpenNum;
		private int? _BaseStuNum;
		/// <summary>
		/// 
		/// </summary>
		public int TCMID
		{
			get{ return _TCMID; }
			set
			{
				this.OnPropertyValueChange(_.TCMID,_TCMID,value);
				this._TCMID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Atyid
		{
			get{ return _Atyid; }
			set
			{
				this.OnPropertyValueChange(_.Atyid,_Atyid,value);
				this._Atyid=value;
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
		public int? StuNum
		{
			get{ return _StuNum; }
			set
			{
				this.OnPropertyValueChange(_.StuNum,_StuNum,value);
				this._StuNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MaxStuNum
		{
			get{ return _MaxStuNum; }
			set
			{
				this.OnPropertyValueChange(_.MaxStuNum,_MaxStuNum,value);
				this._MaxStuNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OpenNum
		{
			get{ return _OpenNum; }
			set
			{
				this.OnPropertyValueChange(_.OpenNum,_OpenNum,value);
				this._OpenNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BaseStuNum
		{
			get{ return _BaseStuNum; }
			set
			{
				this.OnPropertyValueChange(_.BaseStuNum,_BaseStuNum,value);
				this._BaseStuNum=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.TCMID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.TCMID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.TCMID,
				_.Atyid,
				_.CCID,
				_.StuNum,
				_.MaxStuNum,
				_.OpenNum,
				_.BaseStuNum};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TCMID,
				this._Atyid,
				this._CCID,
				this._StuNum,
				this._MaxStuNum,
				this._OpenNum,
				this._BaseStuNum};
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
			public readonly static Field All = new Field("*","TermCourse");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCMID = new Field("TCMID","TermCourse","TCMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("atyid","TermCourse","atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","TermCourse","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StuNum = new Field("StuNum","TermCourse","StuNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MaxStuNum = new Field("MaxStuNum","TermCourse","MaxStuNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OpenNum = new Field("OpenNum","TermCourse","OpenNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BaseStuNum = new Field("BaseStuNum","TermCourse","BaseStuNum");
		}
		#endregion


	}
}

