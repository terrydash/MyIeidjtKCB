﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Support: http://www.cnblogs.com/huxj
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

namespace IeidjtuKCB_Model
{

    /// <summary>
    /// 实体类Vw_Cschedule 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("vw_Cschedule")]
    public partial class Vw_Cschedule : Entity
    {
        #region Model
        private int _CSID;
        private int? _AtyID;
        private int? _TCID;
        private int? _PSID;
        private int? _CCID;
        private int? _CRID;
        private int? _DayOfWeek;
        private string _SectionTH;
        private string _State;
        private string _CCode;
        private string _CCname;
        private string _PsName;
        private string _CRname;
        private string _TCName;
        private int? _StartW;
        private int? _EndW;
        private string _CLRSort;
        private int? _MaxStuNum;
        private string _RGName;
        private int? _PsNumber;
        private string _Sort;
        private string _RoomRGName;
        private string _DeptCode;
        private string _ExminSort;
        private string _Oper;
        private string _Grade;
        private string _Memo;
        private string _BuildName;
        private int? _Havenum;
        private string _DSZ;
        private string _Mark;
        private string _Expr1;
        private string _Expr2;
        private string _Ctype;
        private int? _PSID2;
        private int? _PSID3;
        private decimal? _Period;
        private int? _Prelect;
        private int? _Experiment;
        private int? _OnComputer;
        private string _ATName;
        private decimal? _Source;
        private decimal? _Other;
        private string _TTName;
        private string _Sex;
        private string _Birthday;
        private string _PSNameB;
        private string _PSNameC;
        private string _Csort;
        /// <summary>
        /// 
        /// </summary>
        public int CSID
        {
            get { return _CSID; }
            set
            {
                this.OnPropertyValueChange(_.CSID, _CSID, value);
                this._CSID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? AtyID
        {
            get { return _AtyID; }
            set
            {
                this.OnPropertyValueChange(_.AtyID, _AtyID, value);
                this._AtyID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? TCID
        {
            get { return _TCID; }
            set
            {
                this.OnPropertyValueChange(_.TCID, _TCID, value);
                this._TCID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? PSID
        {
            get { return _PSID; }
            set
            {
                this.OnPropertyValueChange(_.PSID, _PSID, value);
                this._PSID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CCID
        {
            get { return _CCID; }
            set
            {
                this.OnPropertyValueChange(_.CCID, _CCID, value);
                this._CCID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CRID
        {
            get { return _CRID; }
            set
            {
                this.OnPropertyValueChange(_.CRID, _CRID, value);
                this._CRID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? DayOfWeek
        {
            get { return _DayOfWeek; }
            set
            {
                this.OnPropertyValueChange(_.DayOfWeek, _DayOfWeek, value);
                this._DayOfWeek = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SectionTH
        {
            get { return _SectionTH; }
            set
            {
                this.OnPropertyValueChange(_.SectionTH, _SectionTH, value);
                this._SectionTH = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string State
        {
            get { return _State; }
            set
            {
                this.OnPropertyValueChange(_.State, _State, value);
                this._State = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CCode
        {
            get { return _CCode; }
            set
            {
                this.OnPropertyValueChange(_.CCode, _CCode, value);
                this._CCode = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CCname
        {
            get { return _CCname; }
            set
            {
                this.OnPropertyValueChange(_.CCname, _CCname, value);
                this._CCname = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PsName
        {
            get { return _PsName; }
            set
            {
                this.OnPropertyValueChange(_.PsName, _PsName, value);
                this._PsName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CRname
        {
            get { return _CRname; }
            set
            {
                this.OnPropertyValueChange(_.CRname, _CRname, value);
                this._CRname = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TCName
        {
            get { return _TCName; }
            set
            {
                this.OnPropertyValueChange(_.TCName, _TCName, value);
                this._TCName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? StartW
        {
            get { return _StartW; }
            set
            {
                this.OnPropertyValueChange(_.StartW, _StartW, value);
                this._StartW = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? EndW
        {
            get { return _EndW; }
            set
            {
                this.OnPropertyValueChange(_.EndW, _EndW, value);
                this._EndW = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CLRSort
        {
            get { return _CLRSort; }
            set
            {
                this.OnPropertyValueChange(_.CLRSort, _CLRSort, value);
                this._CLRSort = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? MaxStuNum
        {
            get { return _MaxStuNum; }
            set
            {
                this.OnPropertyValueChange(_.MaxStuNum, _MaxStuNum, value);
                this._MaxStuNum = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RGName
        {
            get { return _RGName; }
            set
            {
                this.OnPropertyValueChange(_.RGName, _RGName, value);
                this._RGName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? PsNumber
        {
            get { return _PsNumber; }
            set
            {
                this.OnPropertyValueChange(_.PsNumber, _PsNumber, value);
                this._PsNumber = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Sort
        {
            get { return _Sort; }
            set
            {
                this.OnPropertyValueChange(_.Sort, _Sort, value);
                this._Sort = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RoomRGName
        {
            get { return _RoomRGName; }
            set
            {
                this.OnPropertyValueChange(_.RoomRGName, _RoomRGName, value);
                this._RoomRGName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DeptCode
        {
            get { return _DeptCode; }
            set
            {
                this.OnPropertyValueChange(_.DeptCode, _DeptCode, value);
                this._DeptCode = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ExminSort
        {
            get { return _ExminSort; }
            set
            {
                this.OnPropertyValueChange(_.ExminSort, _ExminSort, value);
                this._ExminSort = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Oper
        {
            get { return _Oper; }
            set
            {
                this.OnPropertyValueChange(_.Oper, _Oper, value);
                this._Oper = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Grade
        {
            get { return _Grade; }
            set
            {
                this.OnPropertyValueChange(_.Grade, _Grade, value);
                this._Grade = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Memo
        {
            get { return _Memo; }
            set
            {
                this.OnPropertyValueChange(_.Memo, _Memo, value);
                this._Memo = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BuildName
        {
            get { return _BuildName; }
            set
            {
                this.OnPropertyValueChange(_.BuildName, _BuildName, value);
                this._BuildName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Havenum
        {
            get { return _Havenum; }
            set
            {
                this.OnPropertyValueChange(_.Havenum, _Havenum, value);
                this._Havenum = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DSZ
        {
            get { return _DSZ; }
            set
            {
                this.OnPropertyValueChange(_.DSZ, _DSZ, value);
                this._DSZ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Mark
        {
            get { return _Mark; }
            set
            {
                this.OnPropertyValueChange(_.Mark, _Mark, value);
                this._Mark = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Expr1
        {
            get { return _Expr1; }
            set
            {
                this.OnPropertyValueChange(_.Expr1, _Expr1, value);
                this._Expr1 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Expr2
        {
            get { return _Expr2; }
            set
            {
                this.OnPropertyValueChange(_.Expr2, _Expr2, value);
                this._Expr2 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Ctype
        {
            get { return _Ctype; }
            set
            {
                this.OnPropertyValueChange(_.Ctype, _Ctype, value);
                this._Ctype = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? PSID2
        {
            get { return _PSID2; }
            set
            {
                this.OnPropertyValueChange(_.PSID2, _PSID2, value);
                this._PSID2 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? PSID3
        {
            get { return _PSID3; }
            set
            {
                this.OnPropertyValueChange(_.PSID3, _PSID3, value);
                this._PSID3 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Period
        {
            get { return _Period; }
            set
            {
                this.OnPropertyValueChange(_.Period, _Period, value);
                this._Period = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Prelect
        {
            get { return _Prelect; }
            set
            {
                this.OnPropertyValueChange(_.Prelect, _Prelect, value);
                this._Prelect = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Experiment
        {
            get { return _Experiment; }
            set
            {
                this.OnPropertyValueChange(_.Experiment, _Experiment, value);
                this._Experiment = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? OnComputer
        {
            get { return _OnComputer; }
            set
            {
                this.OnPropertyValueChange(_.OnComputer, _OnComputer, value);
                this._OnComputer = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ATName
        {
            get { return _ATName; }
            set
            {
                this.OnPropertyValueChange(_.ATName, _ATName, value);
                this._ATName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Source
        {
            get { return _Source; }
            set
            {
                this.OnPropertyValueChange(_.Source, _Source, value);
                this._Source = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Other
        {
            get { return _Other; }
            set
            {
                this.OnPropertyValueChange(_.Other, _Other, value);
                this._Other = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TTName
        {
            get { return _TTName; }
            set
            {
                this.OnPropertyValueChange(_.TTName, _TTName, value);
                this._TTName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Sex
        {
            get { return _Sex; }
            set
            {
                this.OnPropertyValueChange(_.Sex, _Sex, value);
                this._Sex = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Birthday
        {
            get { return _Birthday; }
            set
            {
                this.OnPropertyValueChange(_.Birthday, _Birthday, value);
                this._Birthday = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PSNameB
        {
            get { return _PSNameB; }
            set
            {
                this.OnPropertyValueChange(_.PSNameB, _PSNameB, value);
                this._PSNameB = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PSNameC
        {
            get { return _PSNameC; }
            set
            {
                this.OnPropertyValueChange(_.PSNameC, _PSNameC, value);
                this._PSNameC = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Csort
        {
            get { return _Csort; }
            set
            {
                this.OnPropertyValueChange(_.Csort, _Csort, value);
                this._Csort = value;
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
                _.AtyID,
                _.TCID,
                _.PSID,
                _.CCID,
                _.CRID,
                _.DayOfWeek,
                _.SectionTH,
                _.State,
                _.CCode,
                _.CCname,
                _.PsName,
                _.CRname,
                _.TCName,
                _.StartW,
                _.EndW,
                _.CLRSort,
                _.MaxStuNum,
                _.RGName,
                _.PsNumber,
                _.Sort,
                _.RoomRGName,
                _.DeptCode,
                _.ExminSort,
                _.Oper,
                _.Grade,
                _.Memo,
                _.BuildName,
                _.Havenum,
                _.DSZ,
                _.Mark,
                _.Expr1,
                _.Expr2,
                _.Ctype,
                _.PSID2,
                _.PSID3,
                _.Period,
                _.Prelect,
                _.Experiment,
                _.OnComputer,
                _.ATName,
                _.Source,
                _.Other,
                _.TTName,
                _.Sex,
                _.Birthday,
                _.PSNameB,
                _.PSNameC,
                _.Csort};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._CSID,
                this._AtyID,
                this._TCID,
                this._PSID,
                this._CCID,
                this._CRID,
                this._DayOfWeek,
                this._SectionTH,
                this._State,
                this._CCode,
                this._CCname,
                this._PsName,
                this._CRname,
                this._TCName,
                this._StartW,
                this._EndW,
                this._CLRSort,
                this._MaxStuNum,
                this._RGName,
                this._PsNumber,
                this._Sort,
                this._RoomRGName,
                this._DeptCode,
                this._ExminSort,
                this._Oper,
                this._Grade,
                this._Memo,
                this._BuildName,
                this._Havenum,
                this._DSZ,
                this._Mark,
                this._Expr1,
                this._Expr2,
                this._Ctype,
                this._PSID2,
                this._PSID3,
                this._Period,
                this._Prelect,
                this._Experiment,
                this._OnComputer,
                this._ATName,
                this._Source,
                this._Other,
                this._TTName,
                this._Sex,
                this._Birthday,
                this._PSNameB,
                this._PSNameC,
                this._Csort};
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
            public readonly static Field All = new Field("*", "vw_Cschedule");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CSID = new Field("CSID", "vw_Cschedule", "CSID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field AtyID = new Field("AtyID", "vw_Cschedule", "AtyID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TCID = new Field("TCID", "vw_Cschedule", "TCID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PSID = new Field("PSID", "vw_Cschedule", "PSID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CCID = new Field("CCID", "vw_Cschedule", "CCID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CRID = new Field("CRID", "vw_Cschedule", "CRID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DayOfWeek = new Field("DayOfWeek", "vw_Cschedule", "DayOfWeek");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SectionTH = new Field("SectionTH", "vw_Cschedule", "SectionTH");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field State = new Field("State", "vw_Cschedule", "State");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CCode = new Field("CCode", "vw_Cschedule", "CCode");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CCname = new Field("CCname", "vw_Cschedule", "CCname");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PsName = new Field("PsName", "vw_Cschedule", "PsName");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CRname = new Field("CRname", "vw_Cschedule", "CRname");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TCName = new Field("TCName", "vw_Cschedule", "TCName");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field StartW = new Field("StartW", "vw_Cschedule", "StartW");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field EndW = new Field("EndW", "vw_Cschedule", "EndW");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CLRSort = new Field("CLRSort", "vw_Cschedule", "CLRSort");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MaxStuNum = new Field("MaxStuNum", "vw_Cschedule", "MaxStuNum");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RGName = new Field("RGName", "vw_Cschedule", "RGName");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PsNumber = new Field("PsNumber", "vw_Cschedule", "PsNumber");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Sort = new Field("Sort", "vw_Cschedule", "Sort");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RoomRGName = new Field("RoomRGName", "vw_Cschedule", "RoomRGName");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DeptCode = new Field("DeptCode", "vw_Cschedule", "DeptCode");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ExminSort = new Field("ExminSort", "vw_Cschedule", "ExminSort");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Oper = new Field("Oper", "vw_Cschedule", "Oper");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Grade = new Field("Grade", "vw_Cschedule", "Grade");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Memo = new Field("Memo", "vw_Cschedule", "Memo");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BuildName = new Field("BuildName", "vw_Cschedule", "BuildName");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Havenum = new Field("havenum", "vw_Cschedule", "havenum");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DSZ = new Field("DSZ", "vw_Cschedule", "DSZ");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Mark = new Field("Mark", "vw_Cschedule", "Mark");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Expr1 = new Field("Expr1", "vw_Cschedule", "Expr1");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Expr2 = new Field("Expr2", "vw_Cschedule", "Expr2");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Ctype = new Field("ctype", "vw_Cschedule", "ctype");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PSID2 = new Field("PSID2", "vw_Cschedule", "PSID2");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PSID3 = new Field("PSID3", "vw_Cschedule", "PSID3");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Period = new Field("Period", "vw_Cschedule", "Period");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Prelect = new Field("Prelect", "vw_Cschedule", "Prelect");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Experiment = new Field("Experiment", "vw_Cschedule", "Experiment");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field OnComputer = new Field("OnComputer", "vw_Cschedule", "OnComputer");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ATName = new Field("ATName", "vw_Cschedule", "ATName");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Source = new Field("Source", "vw_Cschedule", "Source");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Other = new Field("Other", "vw_Cschedule", "Other");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TTName = new Field("TTName", "vw_Cschedule", "TTName");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Sex = new Field("Sex", "vw_Cschedule", "Sex");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Birthday = new Field("Birthday", "vw_Cschedule", "Birthday");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PSNameB = new Field("PSNameB", "vw_Cschedule", "PSNameB");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PSNameC = new Field("PSNameC", "vw_Cschedule", "PSNameC");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Csort = new Field("Csort", "vw_Cschedule", "Csort");
        }
        #endregion


    }
}

