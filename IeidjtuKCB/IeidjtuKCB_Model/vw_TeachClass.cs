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
	/// 实体类vw_TeachClass 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_TeachClass")]
	[Serializable]
	public partial class vw_TeachClass : Entity 
	{
		#region Model
		private int _TCID;
		private string _教学班级名称;
		private string _课程名称;
		private string _编码;
		private string _备注;
		private string _状态;
		private int? _CCID;
		private int? _TCHID;
		private string _当前学期;
		private decimal? _学分;
		private int? _ActYear;
		private string _考试类型;
		private string _DeptName;
		private string _ReportState;
		private string _Affirmant;
		private int? _预计数量;
		private string _RGName;
		private int? _CTID;
		private int? _StartA;
		private int? _EndA;
		private int? _PerWeekA;
		private string _StartB;
		private string _EndB;
		private string _PerWeekB;
		private int? _RGID;
		private int? _Prelect;
		private int? _FAXH;
		private int? _HTCHID;
		private int? _TCHID3;
		private string _任课教师;
		private string _StandCode;
		private string _助课教师;
		private string _StandCode2;
		private string _教师3;
		private string _StandCode3;
		private string _ComeDept;
		private string _CLRSort;
		private decimal? _Period;
		private int? _Experiment;
		private int? _OnComputer;
		private int? _EPID;
		private string _CPyCode;
		private string _ExminSort;
		private string _Sort;
		private string _IFJoin;
		private int? _FAXHB;
		private string _Grade;
		private string _LimitSP;
		private string _SPName;
		private int? _OpenNum;
		private int? _SPID;
		private string _Oper;
		private DateTime? _OperDate;
		private string _Lev;
		private int? _PKstate;
		private string _Memo;
		private string _SelectState;
		private string _GroupMark;
		private string _Cunit;
		private string _Csort;
		private string _Minor;
		private int? _KBID;
		private int? _havenum;
		private string _ctype;
		private string _Deptcode;
		private decimal? _Other;
		private string _NeedCalendar;
		private string _NeedPJ;
		private string _FX;
		private string _Sex;
		private string _Birthday;
		private string _TTName;
		private int? _CLnums;
		private int? _RgNums;
		private int? _KsNums;
		private string _LimitGrade;
		private string _LSPMethod;
		private DateTime? _SubmitDate;
		private DateTime? _Receiptdate;
		private DateTime? _CheckDate;
		private string _Receipter;
		/// <summary>
		/// 
		/// </summary>
		public int TCID
		{
			get{ return _TCID; }
			set
			{
				this.OnPropertyValueChange(_.TCID,_TCID,value);
				this._TCID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 教学班级名称
		{
			get{ return _教学班级名称; }
			set
			{
				this.OnPropertyValueChange(_.教学班级名称,_教学班级名称,value);
				this._教学班级名称=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 课程名称
		{
			get{ return _课程名称; }
			set
			{
				this.OnPropertyValueChange(_.课程名称,_课程名称,value);
				this._课程名称=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 编码
		{
			get{ return _编码; }
			set
			{
				this.OnPropertyValueChange(_.编码,_编码,value);
				this._编码=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 备注
		{
			get{ return _备注; }
			set
			{
				this.OnPropertyValueChange(_.备注,_备注,value);
				this._备注=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 状态
		{
			get{ return _状态; }
			set
			{
				this.OnPropertyValueChange(_.状态,_状态,value);
				this._状态=value;
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
		public int? TCHID
		{
			get{ return _TCHID; }
			set
			{
				this.OnPropertyValueChange(_.TCHID,_TCHID,value);
				this._TCHID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 当前学期
		{
			get{ return _当前学期; }
			set
			{
				this.OnPropertyValueChange(_.当前学期,_当前学期,value);
				this._当前学期=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 学分
		{
			get{ return _学分; }
			set
			{
				this.OnPropertyValueChange(_.学分,_学分,value);
				this._学分=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ActYear
		{
			get{ return _ActYear; }
			set
			{
				this.OnPropertyValueChange(_.ActYear,_ActYear,value);
				this._ActYear=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 考试类型
		{
			get{ return _考试类型; }
			set
			{
				this.OnPropertyValueChange(_.考试类型,_考试类型,value);
				this._考试类型=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeptName
		{
			get{ return _DeptName; }
			set
			{
				this.OnPropertyValueChange(_.DeptName,_DeptName,value);
				this._DeptName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReportState
		{
			get{ return _ReportState; }
			set
			{
				this.OnPropertyValueChange(_.ReportState,_ReportState,value);
				this._ReportState=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Affirmant
		{
			get{ return _Affirmant; }
			set
			{
				this.OnPropertyValueChange(_.Affirmant,_Affirmant,value);
				this._Affirmant=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? 预计数量
		{
			get{ return _预计数量; }
			set
			{
				this.OnPropertyValueChange(_.预计数量,_预计数量,value);
				this._预计数量=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RGName
		{
			get{ return _RGName; }
			set
			{
				this.OnPropertyValueChange(_.RGName,_RGName,value);
				this._RGName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CTID
		{
			get{ return _CTID; }
			set
			{
				this.OnPropertyValueChange(_.CTID,_CTID,value);
				this._CTID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StartA
		{
			get{ return _StartA; }
			set
			{
				this.OnPropertyValueChange(_.StartA,_StartA,value);
				this._StartA=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EndA
		{
			get{ return _EndA; }
			set
			{
				this.OnPropertyValueChange(_.EndA,_EndA,value);
				this._EndA=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PerWeekA
		{
			get{ return _PerWeekA; }
			set
			{
				this.OnPropertyValueChange(_.PerWeekA,_PerWeekA,value);
				this._PerWeekA=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StartB
		{
			get{ return _StartB; }
			set
			{
				this.OnPropertyValueChange(_.StartB,_StartB,value);
				this._StartB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EndB
		{
			get{ return _EndB; }
			set
			{
				this.OnPropertyValueChange(_.EndB,_EndB,value);
				this._EndB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PerWeekB
		{
			get{ return _PerWeekB; }
			set
			{
				this.OnPropertyValueChange(_.PerWeekB,_PerWeekB,value);
				this._PerWeekB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RGID
		{
			get{ return _RGID; }
			set
			{
				this.OnPropertyValueChange(_.RGID,_RGID,value);
				this._RGID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Prelect
		{
			get{ return _Prelect; }
			set
			{
				this.OnPropertyValueChange(_.Prelect,_Prelect,value);
				this._Prelect=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FAXH
		{
			get{ return _FAXH; }
			set
			{
				this.OnPropertyValueChange(_.FAXH,_FAXH,value);
				this._FAXH=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? HTCHID
		{
			get{ return _HTCHID; }
			set
			{
				this.OnPropertyValueChange(_.HTCHID,_HTCHID,value);
				this._HTCHID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TCHID3
		{
			get{ return _TCHID3; }
			set
			{
				this.OnPropertyValueChange(_.TCHID3,_TCHID3,value);
				this._TCHID3=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 任课教师
		{
			get{ return _任课教师; }
			set
			{
				this.OnPropertyValueChange(_.任课教师,_任课教师,value);
				this._任课教师=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StandCode
		{
			get{ return _StandCode; }
			set
			{
				this.OnPropertyValueChange(_.StandCode,_StandCode,value);
				this._StandCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 助课教师
		{
			get{ return _助课教师; }
			set
			{
				this.OnPropertyValueChange(_.助课教师,_助课教师,value);
				this._助课教师=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StandCode2
		{
			get{ return _StandCode2; }
			set
			{
				this.OnPropertyValueChange(_.StandCode2,_StandCode2,value);
				this._StandCode2=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 教师3
		{
			get{ return _教师3; }
			set
			{
				this.OnPropertyValueChange(_.教师3,_教师3,value);
				this._教师3=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StandCode3
		{
			get{ return _StandCode3; }
			set
			{
				this.OnPropertyValueChange(_.StandCode3,_StandCode3,value);
				this._StandCode3=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ComeDept
		{
			get{ return _ComeDept; }
			set
			{
				this.OnPropertyValueChange(_.ComeDept,_ComeDept,value);
				this._ComeDept=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLRSort
		{
			get{ return _CLRSort; }
			set
			{
				this.OnPropertyValueChange(_.CLRSort,_CLRSort,value);
				this._CLRSort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Period
		{
			get{ return _Period; }
			set
			{
				this.OnPropertyValueChange(_.Period,_Period,value);
				this._Period=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Experiment
		{
			get{ return _Experiment; }
			set
			{
				this.OnPropertyValueChange(_.Experiment,_Experiment,value);
				this._Experiment=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OnComputer
		{
			get{ return _OnComputer; }
			set
			{
				this.OnPropertyValueChange(_.OnComputer,_OnComputer,value);
				this._OnComputer=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EPID
		{
			get{ return _EPID; }
			set
			{
				this.OnPropertyValueChange(_.EPID,_EPID,value);
				this._EPID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CPyCode
		{
			get{ return _CPyCode; }
			set
			{
				this.OnPropertyValueChange(_.CPyCode,_CPyCode,value);
				this._CPyCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExminSort
		{
			get{ return _ExminSort; }
			set
			{
				this.OnPropertyValueChange(_.ExminSort,_ExminSort,value);
				this._ExminSort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sort
		{
			get{ return _Sort; }
			set
			{
				this.OnPropertyValueChange(_.Sort,_Sort,value);
				this._Sort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IFJoin
		{
			get{ return _IFJoin; }
			set
			{
				this.OnPropertyValueChange(_.IFJoin,_IFJoin,value);
				this._IFJoin=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FAXHB
		{
			get{ return _FAXHB; }
			set
			{
				this.OnPropertyValueChange(_.FAXHB,_FAXHB,value);
				this._FAXHB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Grade
		{
			get{ return _Grade; }
			set
			{
				this.OnPropertyValueChange(_.Grade,_Grade,value);
				this._Grade=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LimitSP
		{
			get{ return _LimitSP; }
			set
			{
				this.OnPropertyValueChange(_.LimitSP,_LimitSP,value);
				this._LimitSP=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SPName
		{
			get{ return _SPName; }
			set
			{
				this.OnPropertyValueChange(_.SPName,_SPName,value);
				this._SPName=value;
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
		public int? SPID
		{
			get{ return _SPID; }
			set
			{
				this.OnPropertyValueChange(_.SPID,_SPID,value);
				this._SPID=value;
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
		public DateTime? OperDate
		{
			get{ return _OperDate; }
			set
			{
				this.OnPropertyValueChange(_.OperDate,_OperDate,value);
				this._OperDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Lev
		{
			get{ return _Lev; }
			set
			{
				this.OnPropertyValueChange(_.Lev,_Lev,value);
				this._Lev=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PKstate
		{
			get{ return _PKstate; }
			set
			{
				this.OnPropertyValueChange(_.PKstate,_PKstate,value);
				this._PKstate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Memo
		{
			get{ return _Memo; }
			set
			{
				this.OnPropertyValueChange(_.Memo,_Memo,value);
				this._Memo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SelectState
		{
			get{ return _SelectState; }
			set
			{
				this.OnPropertyValueChange(_.SelectState,_SelectState,value);
				this._SelectState=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GroupMark
		{
			get{ return _GroupMark; }
			set
			{
				this.OnPropertyValueChange(_.GroupMark,_GroupMark,value);
				this._GroupMark=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Cunit
		{
			get{ return _Cunit; }
			set
			{
				this.OnPropertyValueChange(_.Cunit,_Cunit,value);
				this._Cunit=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Csort
		{
			get{ return _Csort; }
			set
			{
				this.OnPropertyValueChange(_.Csort,_Csort,value);
				this._Csort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Minor
		{
			get{ return _Minor; }
			set
			{
				this.OnPropertyValueChange(_.Minor,_Minor,value);
				this._Minor=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? KBID
		{
			get{ return _KBID; }
			set
			{
				this.OnPropertyValueChange(_.KBID,_KBID,value);
				this._KBID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? havenum
		{
			get{ return _havenum; }
			set
			{
				this.OnPropertyValueChange(_.havenum,_havenum,value);
				this._havenum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ctype
		{
			get{ return _ctype; }
			set
			{
				this.OnPropertyValueChange(_.ctype,_ctype,value);
				this._ctype=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Deptcode
		{
			get{ return _Deptcode; }
			set
			{
				this.OnPropertyValueChange(_.Deptcode,_Deptcode,value);
				this._Deptcode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Other
		{
			get{ return _Other; }
			set
			{
				this.OnPropertyValueChange(_.Other,_Other,value);
				this._Other=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NeedCalendar
		{
			get{ return _NeedCalendar; }
			set
			{
				this.OnPropertyValueChange(_.NeedCalendar,_NeedCalendar,value);
				this._NeedCalendar=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NeedPJ
		{
			get{ return _NeedPJ; }
			set
			{
				this.OnPropertyValueChange(_.NeedPJ,_NeedPJ,value);
				this._NeedPJ=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FX
		{
			get{ return _FX; }
			set
			{
				this.OnPropertyValueChange(_.FX,_FX,value);
				this._FX=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sex
		{
			get{ return _Sex; }
			set
			{
				this.OnPropertyValueChange(_.Sex,_Sex,value);
				this._Sex=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Birthday
		{
			get{ return _Birthday; }
			set
			{
				this.OnPropertyValueChange(_.Birthday,_Birthday,value);
				this._Birthday=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TTName
		{
			get{ return _TTName; }
			set
			{
				this.OnPropertyValueChange(_.TTName,_TTName,value);
				this._TTName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CLnums
		{
			get{ return _CLnums; }
			set
			{
				this.OnPropertyValueChange(_.CLnums,_CLnums,value);
				this._CLnums=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RgNums
		{
			get{ return _RgNums; }
			set
			{
				this.OnPropertyValueChange(_.RgNums,_RgNums,value);
				this._RgNums=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? KsNums
		{
			get{ return _KsNums; }
			set
			{
				this.OnPropertyValueChange(_.KsNums,_KsNums,value);
				this._KsNums=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LimitGrade
		{
			get{ return _LimitGrade; }
			set
			{
				this.OnPropertyValueChange(_.LimitGrade,_LimitGrade,value);
				this._LimitGrade=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LSPMethod
		{
			get{ return _LSPMethod; }
			set
			{
				this.OnPropertyValueChange(_.LSPMethod,_LSPMethod,value);
				this._LSPMethod=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SubmitDate
		{
			get{ return _SubmitDate; }
			set
			{
				this.OnPropertyValueChange(_.SubmitDate,_SubmitDate,value);
				this._SubmitDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Receiptdate
		{
			get{ return _Receiptdate; }
			set
			{
				this.OnPropertyValueChange(_.Receiptdate,_Receiptdate,value);
				this._Receiptdate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CheckDate
		{
			get{ return _CheckDate; }
			set
			{
				this.OnPropertyValueChange(_.CheckDate,_CheckDate,value);
				this._CheckDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Receipter
		{
			get{ return _Receipter; }
			set
			{
				this.OnPropertyValueChange(_.Receipter,_Receipter,value);
				this._Receipter=value;
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
				_.TCID,
				_.教学班级名称,
				_.课程名称,
				_.编码,
				_.备注,
				_.状态,
				_.CCID,
				_.TCHID,
				_.当前学期,
				_.学分,
				_.ActYear,
				_.考试类型,
				_.DeptName,
				_.ReportState,
				_.Affirmant,
				_.预计数量,
				_.RGName,
				_.CTID,
				_.StartA,
				_.EndA,
				_.PerWeekA,
				_.StartB,
				_.EndB,
				_.PerWeekB,
				_.RGID,
				_.Prelect,
				_.FAXH,
				_.HTCHID,
				_.TCHID3,
				_.任课教师,
				_.StandCode,
				_.助课教师,
				_.StandCode2,
				_.教师3,
				_.StandCode3,
				_.ComeDept,
				_.CLRSort,
				_.Period,
				_.Experiment,
				_.OnComputer,
				_.EPID,
				_.CPyCode,
				_.ExminSort,
				_.Sort,
				_.IFJoin,
				_.FAXHB,
				_.Grade,
				_.LimitSP,
				_.SPName,
				_.OpenNum,
				_.SPID,
				_.Oper,
				_.OperDate,
				_.Lev,
				_.PKstate,
				_.Memo,
				_.SelectState,
				_.GroupMark,
				_.Cunit,
				_.Csort,
				_.Minor,
				_.KBID,
				_.havenum,
				_.ctype,
				_.Deptcode,
				_.Other,
				_.NeedCalendar,
				_.NeedPJ,
				_.FX,
				_.Sex,
				_.Birthday,
				_.TTName,
				_.CLnums,
				_.RgNums,
				_.KsNums,
				_.LimitGrade,
				_.LSPMethod,
				_.SubmitDate,
				_.Receiptdate,
				_.CheckDate,
				_.Receipter};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TCID,
				this._教学班级名称,
				this._课程名称,
				this._编码,
				this._备注,
				this._状态,
				this._CCID,
				this._TCHID,
				this._当前学期,
				this._学分,
				this._ActYear,
				this._考试类型,
				this._DeptName,
				this._ReportState,
				this._Affirmant,
				this._预计数量,
				this._RGName,
				this._CTID,
				this._StartA,
				this._EndA,
				this._PerWeekA,
				this._StartB,
				this._EndB,
				this._PerWeekB,
				this._RGID,
				this._Prelect,
				this._FAXH,
				this._HTCHID,
				this._TCHID3,
				this._任课教师,
				this._StandCode,
				this._助课教师,
				this._StandCode2,
				this._教师3,
				this._StandCode3,
				this._ComeDept,
				this._CLRSort,
				this._Period,
				this._Experiment,
				this._OnComputer,
				this._EPID,
				this._CPyCode,
				this._ExminSort,
				this._Sort,
				this._IFJoin,
				this._FAXHB,
				this._Grade,
				this._LimitSP,
				this._SPName,
				this._OpenNum,
				this._SPID,
				this._Oper,
				this._OperDate,
				this._Lev,
				this._PKstate,
				this._Memo,
				this._SelectState,
				this._GroupMark,
				this._Cunit,
				this._Csort,
				this._Minor,
				this._KBID,
				this._havenum,
				this._ctype,
				this._Deptcode,
				this._Other,
				this._NeedCalendar,
				this._NeedPJ,
				this._FX,
				this._Sex,
				this._Birthday,
				this._TTName,
				this._CLnums,
				this._RgNums,
				this._KsNums,
				this._LimitGrade,
				this._LSPMethod,
				this._SubmitDate,
				this._Receiptdate,
				this._CheckDate,
				this._Receipter};
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
			public readonly static Field All = new Field("*","vw_TeachClass");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","vw_TeachClass","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 教学班级名称 = new Field("教学班级名称","vw_TeachClass","教学班级名称");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 课程名称 = new Field("课程名称","vw_TeachClass","课程名称");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 编码 = new Field("编码","vw_TeachClass","编码");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 备注 = new Field("备注","vw_TeachClass","备注");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 状态 = new Field("状态","vw_TeachClass","状态");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_TeachClass","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCHID = new Field("TCHID","vw_TeachClass","TCHID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 当前学期 = new Field("当前学期","vw_TeachClass","当前学期");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学分 = new Field("学分","vw_TeachClass","学分");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ActYear = new Field("ActYear","vw_TeachClass","ActYear");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 考试类型 = new Field("考试类型","vw_TeachClass","考试类型");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptName = new Field("DeptName","vw_TeachClass","DeptName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ReportState = new Field("ReportState","vw_TeachClass","ReportState");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Affirmant = new Field("Affirmant","vw_TeachClass","Affirmant");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 预计数量 = new Field("预计数量","vw_TeachClass","预计数量");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RGName = new Field("RGName","vw_TeachClass","RGName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CTID = new Field("CTID","vw_TeachClass","CTID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StartA = new Field("StartA","vw_TeachClass","StartA");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EndA = new Field("EndA","vw_TeachClass","EndA");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PerWeekA = new Field("PerWeekA","vw_TeachClass","PerWeekA");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StartB = new Field("StartB","vw_TeachClass","StartB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EndB = new Field("EndB","vw_TeachClass","EndB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PerWeekB = new Field("PerWeekB","vw_TeachClass","PerWeekB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RGID = new Field("RGID","vw_TeachClass","RGID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Prelect = new Field("Prelect","vw_TeachClass","Prelect");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FAXH = new Field("FAXH","vw_TeachClass","FAXH");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HTCHID = new Field("HTCHID","vw_TeachClass","HTCHID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCHID3 = new Field("TCHID3","vw_TeachClass","TCHID3");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 任课教师 = new Field("任课教师","vw_TeachClass","任课教师");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StandCode = new Field("StandCode","vw_TeachClass","StandCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 助课教师 = new Field("助课教师","vw_TeachClass","助课教师");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StandCode2 = new Field("StandCode2","vw_TeachClass","StandCode2");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 教师3 = new Field("教师3","vw_TeachClass","教师3");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StandCode3 = new Field("StandCode3","vw_TeachClass","StandCode3");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ComeDept = new Field("ComeDept","vw_TeachClass","ComeDept");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLRSort = new Field("CLRSort","vw_TeachClass","CLRSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Period = new Field("Period","vw_TeachClass","Period");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Experiment = new Field("Experiment","vw_TeachClass","Experiment");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OnComputer = new Field("OnComputer","vw_TeachClass","OnComputer");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EPID = new Field("EPID","vw_TeachClass","EPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CPyCode = new Field("CPyCode","vw_TeachClass","CPyCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExminSort = new Field("ExminSort","vw_TeachClass","ExminSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sort = new Field("Sort","vw_TeachClass","Sort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IFJoin = new Field("IFJoin","vw_TeachClass","IFJoin");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FAXHB = new Field("FAXHB","vw_TeachClass","FAXHB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Grade = new Field("Grade","vw_TeachClass","Grade");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LimitSP = new Field("LimitSP","vw_TeachClass","LimitSP");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPName = new Field("SPName","vw_TeachClass","SPName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OpenNum = new Field("OpenNum","vw_TeachClass","OpenNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_TeachClass","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Oper = new Field("Oper","vw_TeachClass","Oper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OperDate = new Field("OperDate","vw_TeachClass","OperDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Lev = new Field("Lev","vw_TeachClass","Lev");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PKstate = new Field("PKstate","vw_TeachClass","PKstate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","vw_TeachClass","Memo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SelectState = new Field("SelectState","vw_TeachClass","SelectState");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GroupMark = new Field("GroupMark","vw_TeachClass","GroupMark");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Cunit = new Field("Cunit","vw_TeachClass","Cunit");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Csort = new Field("Csort","vw_TeachClass","Csort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Minor = new Field("Minor","vw_TeachClass","Minor");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KBID = new Field("KBID","vw_TeachClass","KBID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field havenum = new Field("havenum","vw_TeachClass","havenum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ctype = new Field("ctype","vw_TeachClass","ctype");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Deptcode = new Field("Deptcode","vw_TeachClass","Deptcode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Other = new Field("Other","vw_TeachClass","Other");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field NeedCalendar = new Field("NeedCalendar","vw_TeachClass","NeedCalendar");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field NeedPJ = new Field("NeedPJ","vw_TeachClass","NeedPJ");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FX = new Field("FX","vw_TeachClass","FX");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sex = new Field("Sex","vw_TeachClass","Sex");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Birthday = new Field("Birthday","vw_TeachClass","Birthday");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TTName = new Field("TTName","vw_TeachClass","TTName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLnums = new Field("CLnums","vw_TeachClass","CLnums");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RgNums = new Field("RgNums","vw_TeachClass","RgNums");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KsNums = new Field("KsNums","vw_TeachClass","KsNums");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LimitGrade = new Field("LimitGrade","vw_TeachClass","LimitGrade");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LSPMethod = new Field("LSPMethod","vw_TeachClass","LSPMethod");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SubmitDate = new Field("SubmitDate","vw_TeachClass","SubmitDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Receiptdate = new Field("Receiptdate","vw_TeachClass","Receiptdate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CheckDate = new Field("CheckDate","vw_TeachClass","CheckDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Receipter = new Field("Receipter","vw_TeachClass","Receipter");
		}
		#endregion


	}
}

