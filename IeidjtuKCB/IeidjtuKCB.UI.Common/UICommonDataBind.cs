using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using IeidjtuKCB.Common;
namespace IeidjtuKCB.UI.Common
{
    public static class UICommonDataBind
    {   /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dGV"></param>
        /// <param name="list"></param>
        /// <param name=""></param>
        public static void BindDataGridView<T>(this DataGridView dGV, IList<T> list, List<string> ColumnNames, List<string> DisplayColumnNames)
        {
            if (ColumnNames.Count == DisplayColumnNames.Count)
            {
                dGV.AutoGenerateColumns = false;
                dGV.DataBindings.Clear();
                dGV.Columns.Clear();
                dGV.DataSource = ListMethod.ListToDataTable<T>(list);
             
                for (int i = 0; i <=ColumnNames.Count-1; i++)
                {
                    DataGridViewTextBoxColumn a = new DataGridViewTextBoxColumn();
                    a.DataPropertyName = ColumnNames[i];
                    a.HeaderText = DisplayColumnNames[i];
                    a.Name = ColumnNames[i];
                    a.DisplayIndex = i;
                    a.Resizable = DataGridViewTriState.False;
                    //a.SortMode = DataGridViewColumnSortMode.Automatic;
                    dGV.Columns.Add(a);
                    
                }
                dGV.AllowUserToOrderColumns = true;        


            }
            else
            {
                MessageBox.Show("要绑定的列与要显示的列标题数量不符");

            }
            


        }
        public static void BindDataGridView<T>(this DataGridView dGV, IList<T> list)
        {
            dGV.DataBindings.Clear();               
            dGV.DataSource = list;
            

        }

        /// <summary>
        /// 为ComboBox绑定数据源并提供下拉提示
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="combox">ComboBox</param>
        /// <param name="list">数据源</param>
        /// <param name="displayMember">显示字段</param>
        /// <param name="valueMember">隐式字段</param>
        /// <param name="displayText">下拉提示文字</param>
        public static void BindComboBox<T>(this ComboBox combox, IList<T> list, string displayMember, string valueMember, string displayText)
        {
            AddItem(list, displayMember, displayText, valueMember);
            combox.DataSource = list;
            combox.DisplayMember = displayMember;
            if (!string.IsNullOrEmpty(valueMember))
                combox.ValueMember = valueMember;
        }

        /// <summary>
        ///向要入ComboBox中加入一个提示用的项，该项的value值为0,提示项为DisplayText
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">泛型</param>
        /// <param name="displayMember">ComboxBox中的displayMember</param>
        /// <param name="displayText">用做提示的字符串</param>
        /// <param name="valueMember">ComboxBox中的valueMember</param>
        private static void AddItem<T>(IList<T> list, string displayMember, string displayText, string valueMember)
        {
            Object _obj = Activator.CreateInstance<T>();
            Type _type = _obj.GetType();

            if (!string.IsNullOrEmpty(displayMember))
            {
                PropertyInfo _displayProperty, _valueProperty;

                _displayProperty = _type.GetProperty(displayMember);
                _valueProperty = _type.GetProperty(valueMember);


                if (((_displayProperty) != null) && ((_valueProperty) != null))
                {
                    _displayProperty.SetValue(_obj, displayText, null);
                    _valueProperty.SetValue(_obj, 0, null);
                }
                else
                {

                    MessageBox.Show("displayMemer参数错误!disPlayMember='" + displayMember + "'");
                }

            }


            list.Insert(0, (T)_obj);
        }


    }
}
