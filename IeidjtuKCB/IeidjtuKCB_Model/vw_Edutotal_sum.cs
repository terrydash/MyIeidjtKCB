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
	/// 实体类vw_Edutotal_sum 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Edutotal_sum")]
	[Serializable]
	public partial class vw_Edutotal_sum : Entity 
	{
		#region Model
		private decimal? _LLJX;
		private decimal? _KS;
		private decimal? _JXSX;
		private decimal? _JXSXKW;
		private decimal? _KCSJ;
		private decimal? _KCSJKW;
		private decimal? _SCSX;
		private decimal? _BYSJ;
		private decimal? _BYSJKW;
		private decimal? _JX;
		private decimal? _GYLD;
		private decimal? _GYLDKW;
		private decimal? _JD;
		private decimal? _RXJY;
		private decimal? _BYJY;
		private decimal? _BYJYKW;
		private decimal? _JQ;
		private decimal? _HJ;
		private int? _EMID;
		/// <summary>
		/// 
		/// </summary>
		public decimal? LLJX
		{
			get{ return _LLJX; }
			set
			{
				this.OnPropertyValueChange(_.LLJX,_LLJX,value);
				this._LLJX=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? KS
		{
			get{ return _KS; }
			set
			{
				this.OnPropertyValueChange(_.KS,_KS,value);
				this._KS=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? JXSX
		{
			get{ return _JXSX; }
			set
			{
				this.OnPropertyValueChange(_.JXSX,_JXSX,value);
				this._JXSX=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? JXSXKW
		{
			get{ return _JXSXKW; }
			set
			{
				this.OnPropertyValueChange(_.JXSXKW,_JXSXKW,value);
				this._JXSXKW=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? KCSJ
		{
			get{ return _KCSJ; }
			set
			{
				this.OnPropertyValueChange(_.KCSJ,_KCSJ,value);
				this._KCSJ=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? KCSJKW
		{
			get{ return _KCSJKW; }
			set
			{
				this.OnPropertyValueChange(_.KCSJKW,_KCSJKW,value);
				this._KCSJKW=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SCSX
		{
			get{ return _SCSX; }
			set
			{
				this.OnPropertyValueChange(_.SCSX,_SCSX,value);
				this._SCSX=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BYSJ
		{
			get{ return _BYSJ; }
			set
			{
				this.OnPropertyValueChange(_.BYSJ,_BYSJ,value);
				this._BYSJ=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BYSJKW
		{
			get{ return _BYSJKW; }
			set
			{
				this.OnPropertyValueChange(_.BYSJKW,_BYSJKW,value);
				this._BYSJKW=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? JX
		{
			get{ return _JX; }
			set
			{
				this.OnPropertyValueChange(_.JX,_JX,value);
				this._JX=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? GYLD
		{
			get{ return _GYLD; }
			set
			{
				this.OnPropertyValueChange(_.GYLD,_GYLD,value);
				this._GYLD=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? GYLDKW
		{
			get{ return _GYLDKW; }
			set
			{
				this.OnPropertyValueChange(_.GYLDKW,_GYLDKW,value);
				this._GYLDKW=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? JD
		{
			get{ return _JD; }
			set
			{
				this.OnPropertyValueChange(_.JD,_JD,value);
				this._JD=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? RXJY
		{
			get{ return _RXJY; }
			set
			{
				this.OnPropertyValueChange(_.RXJY,_RXJY,value);
				this._RXJY=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BYJY
		{
			get{ return _BYJY; }
			set
			{
				this.OnPropertyValueChange(_.BYJY,_BYJY,value);
				this._BYJY=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BYJYKW
		{
			get{ return _BYJYKW; }
			set
			{
				this.OnPropertyValueChange(_.BYJYKW,_BYJYKW,value);
				this._BYJYKW=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? JQ
		{
			get{ return _JQ; }
			set
			{
				this.OnPropertyValueChange(_.JQ,_JQ,value);
				this._JQ=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? HJ
		{
			get{ return _HJ; }
			set
			{
				this.OnPropertyValueChange(_.HJ,_HJ,value);
				this._HJ=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EMID
		{
			get{ return _EMID; }
			set
			{
				this.OnPropertyValueChange(_.EMID,_EMID,value);
				this._EMID=value;
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
				_.LLJX,
				_.KS,
				_.JXSX,
				_.JXSXKW,
				_.KCSJ,
				_.KCSJKW,
				_.SCSX,
				_.BYSJ,
				_.BYSJKW,
				_.JX,
				_.GYLD,
				_.GYLDKW,
				_.JD,
				_.RXJY,
				_.BYJY,
				_.BYJYKW,
				_.JQ,
				_.HJ,
				_.EMID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._LLJX,
				this._KS,
				this._JXSX,
				this._JXSXKW,
				this._KCSJ,
				this._KCSJKW,
				this._SCSX,
				this._BYSJ,
				this._BYSJKW,
				this._JX,
				this._GYLD,
				this._GYLDKW,
				this._JD,
				this._RXJY,
				this._BYJY,
				this._BYJYKW,
				this._JQ,
				this._HJ,
				this._EMID};
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
			public readonly static Field All = new Field("*","vw_Edutotal_sum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LLJX = new Field("LLJX","vw_Edutotal_sum","LLJX");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KS = new Field("KS","vw_Edutotal_sum","KS");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field JXSX = new Field("JXSX","vw_Edutotal_sum","JXSX");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field JXSXKW = new Field("JXSXKW","vw_Edutotal_sum","JXSXKW");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KCSJ = new Field("KCSJ","vw_Edutotal_sum","KCSJ");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KCSJKW = new Field("KCSJKW","vw_Edutotal_sum","KCSJKW");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SCSX = new Field("SCSX","vw_Edutotal_sum","SCSX");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BYSJ = new Field("BYSJ","vw_Edutotal_sum","BYSJ");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BYSJKW = new Field("BYSJKW","vw_Edutotal_sum","BYSJKW");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field JX = new Field("JX","vw_Edutotal_sum","JX");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GYLD = new Field("GYLD","vw_Edutotal_sum","GYLD");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GYLDKW = new Field("GYLDKW","vw_Edutotal_sum","GYLDKW");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field JD = new Field("JD","vw_Edutotal_sum","JD");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RXJY = new Field("RXJY","vw_Edutotal_sum","RXJY");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BYJY = new Field("BYJY","vw_Edutotal_sum","BYJY");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BYJYKW = new Field("BYJYKW","vw_Edutotal_sum","BYJYKW");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field JQ = new Field("JQ","vw_Edutotal_sum","JQ");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HJ = new Field("HJ","vw_Edutotal_sum","HJ");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMID = new Field("EMID","vw_Edutotal_sum","EMID");
		}
		#endregion


	}
}
