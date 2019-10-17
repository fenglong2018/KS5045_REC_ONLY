using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace KS5045上位机
{
     public class disp_list
    {
         KS5045上位机.ListViewFN my_list_view = new KS5045上位机.ListViewFN();
        class colums_info
        {


        }

        public void set_list_view(KS5045上位机.ListViewFN m_list_view)
        {
            my_list_view = m_list_view;
        }

        public class COLUMS_INFO
        {
            public int info_id { get; set; }
            public string Length { get; set; }
            public string Name { get; set; }
            public string Value { get; set; }
            public string Uints { get; set; }

            public string getName()
            {
                return Name;
            }

            public string getLength()
            {
                return Length;
            }

            public string getUints()
            {
                return Uints;
            }

            public string getValue()
            {
                return Value;
            }


            public void setValue(string val)
            {
                this.Value = val;
            }
        }


        public List<COLUMS_INFO> users = new List<COLUMS_INFO>
        {

            new COLUMS_INFO{ info_id=0x00, Name="BMS协议版本号",                     Length="2",         Value=" ",  Uints="hex"},
            new COLUMS_INFO{ info_id=0x01, Name="电池包充电电压限制",                Length="2",         Value=" ",  Uints="10mV"},
            new COLUMS_INFO{ info_id=0x02, Name="电池包SOC10%对应电压",              Length="2",         Value=" ",  Uints="10mV"},
            new COLUMS_INFO{ info_id=0x03, Name="电池包充电电流限制",                Length="2",         Value=" ",  Uints="0.1A"},
            new COLUMS_INFO{ info_id=0x04, Name="电池包额定容量",                    Length="2",         Value=" ",  Uints="0.1AH"},
            new COLUMS_INFO{ info_id=0x05, Name="电池包允许使用最高温度",            Length="2",          Value=" ",  Uints="℃"},
            new COLUMS_INFO{ info_id=0x06, Name="电池包允许使用最低温度",            Length="2",          Value=" ",  Uints="℃"},
            new COLUMS_INFO{ info_id=0x07, Name="电池包额定充放电次数",              Length="2",          Value=" ",  Uints="次"},

            new COLUMS_INFO{ info_id=0x08, Name="电池包电芯数",                      Length="2",          Value=" ",  Uints="个"},
            new COLUMS_INFO{ info_id=0x09, Name="电池包温度传感器个数",              Length="2",          Value=" ",  Uints="个"},

            new COLUMS_INFO{ info_id=0x0A, Name="充电MOS温度",                       Length="2",          Value=" ",  Uints="℃"},
            new COLUMS_INFO{ info_id=0x0B, Name="放电MOS温度",                       Length="2",          Value=" ",  Uints="℃"},

            new COLUMS_INFO{ info_id=0x10, Name="电芯类型",                           Length="2",          Value=" ",  Uints=""},

            new COLUMS_INFO{ info_id=0x11, Name="SOC",                                Length="2",          Value=" ",  Uints="1%"},
            new COLUMS_INFO{ info_id=0x12, Name="电池包容量",                         Length="2",          Value=" ",  Uints="0.1AH"},
            new COLUMS_INFO{ info_id=0x13, Name="电池总电压",                         Length="2",          Value=" ",  Uints="10mV"},
            new COLUMS_INFO{ info_id=0x14, Name="电芯压差",                           Length="2",          Value=" ",  Uints="10mV"},
            new COLUMS_INFO{ info_id=0x15, Name="最大电压",                           Length="2",          Value=" ",  Uints="1mV"},
            new COLUMS_INFO{ info_id=0x16, Name="最小电压",                           Length="2",          Value=" ",  Uints="10mV"},
            new COLUMS_INFO{ info_id=0x17, Name="电流",                               Length="2",          Value=" ",  Uints="0.1A"},

            new COLUMS_INFO{ info_id=0x18, Name="环境温度",                           Length="2",          Value=" ",  Uints="℃"},
            new COLUMS_INFO{ info_id=0x19, Name="BMS板温度",                          Length="2",          Value=" ",  Uints="℃"},
            new COLUMS_INFO{ info_id=0x1A, Name="电芯最高温度",                       Length="2",          Value=" ",  Uints="℃"},
            new COLUMS_INFO{ info_id=0x1B, Name="电芯最低温度",                       Length="2",          Value=" ",  Uints="℃"},
            new COLUMS_INFO{ info_id=0x1C, Name="充放电次数",                         Length="2",          Value=" ",  Uints="次"},
            new COLUMS_INFO{ info_id=0x1D, Name="一级告警",                           Length="2",          Value=" ",  Uints=""},

            new COLUMS_INFO{ info_id=0x1E, Name="二级告警",                           Length="2",          Value=" ",  Uints=""},
            new COLUMS_INFO{ info_id=0x1F, Name="二级故障记录",                       Length="2",          Value=" ",  Uints=""},

            new COLUMS_INFO{ info_id=0x20, Name="充电状态",                           Length="2",          Value=" ",  Uints=""},

            new COLUMS_INFO{ info_id=0x50, Name="CELL1电压",                          Length="2",          Value=" ",  Uints="mV"},
            new COLUMS_INFO{ info_id=0x51, Name="CELL2电压",                          Length="2",          Value=" ",  Uints="mV"},
            new COLUMS_INFO{ info_id=0x52, Name="CELL3电压",                          Length="2",          Value=" ",  Uints="mV"},
            new COLUMS_INFO{ info_id=0x53, Name="CELL4电压",                          Length="2",          Value=" ",  Uints="mV"},
            new COLUMS_INFO{ info_id=0x54, Name="CELL5电压",                          Length="2",          Value=" ",  Uints="mV"},
            new COLUMS_INFO{ info_id=0x55, Name="CELL6电压",                          Length="2",          Value=" ",  Uints="mV"},
            new COLUMS_INFO{ info_id=0x56, Name="CELL7电压",                          Length="2",          Value=" ",  Uints="mV"},
            new COLUMS_INFO{ info_id=0x57, Name="CELL8电压",                          Length="2",          Value=" ",  Uints="mV"},

            new COLUMS_INFO{ info_id=0x58, Name="CELL9电压",                          Length="2",          Value=" ",  Uints="mV"},
            new COLUMS_INFO{ info_id=0x59, Name="CELL10电压",                         Length="2",          Value=" ",  Uints="mV"},
            new COLUMS_INFO{ info_id=0x5A, Name="CELL11电压",                         Length="2",          Value=" ",  Uints="mV"},
            new COLUMS_INFO{ info_id=0x5B, Name="CELL12电压",                         Length="2",          Value=" ",  Uints="mV"},
            new COLUMS_INFO{ info_id=0x5C, Name="CELL13电压",                         Length="2",          Value=" ",  Uints="mV"},
            new COLUMS_INFO{ info_id=0x5D, Name="CELL14电压",                         Length="2",          Value=" ",  Uints="mV"},

            new COLUMS_INFO{ info_id=0x90, Name="CELL1温度",                          Length="2",          Value=" ",  Uints="℃"},
            new COLUMS_INFO{ info_id=0x91, Name="CELL2温度",                          Length="2",          Value=" ",  Uints="℃"},
            new COLUMS_INFO{ info_id=0x92, Name="CELL3温度",                          Length="2",          Value=" ",  Uints="℃"},
            new COLUMS_INFO{ info_id=0x93, Name="CELL4温度",                          Length="2",          Value=" ",  Uints="℃"},
            new COLUMS_INFO{ info_id=0x94, Name="CELL5温度",                          Length="2",          Value=" ",  Uints="℃"},
            new COLUMS_INFO{ info_id=0x95, Name="CELL6温度",                          Length="2",          Value=" ",  Uints="℃"},

            new COLUMS_INFO{ info_id=0x9F, Name="电池厂家",                           Length="2",         Value=" ",  Uints=""},

            new COLUMS_INFO{ info_id=0xA0, Name="硬件版本号",                         Length="2",          Value=" ",  Uints=""},
            new COLUMS_INFO{ info_id=0xA1, Name="应用软件版本号",                     Length="2",          Value=" ",  Uints=""},
            new COLUMS_INFO{ info_id=0xA2, Name="Boot版本号",                         Length="2",          Value=" ",  Uints=""},

    };


        public void clearList()
        {
            foreach (COLUMS_INFO item in users)
            {
                item.Value = " ";
            }
        }


        public void set_value(int id, string value)
        {
            int find_index = users.FindIndex(o => o.info_id == id);
            if (find_index >= 0)
            {
                users[find_index].Value = value;
            }
        }


        public string get_value(int id)
        {
            int find_index = users.FindIndex(o => o.info_id == id);
            if (find_index >= 0)
            {
                return users[find_index].Value;
            }
            else
            {
                return "";
            }
        }



        public string get_length(int id)
        {
            int find_index = users.FindIndex(o => o.info_id == id);
            if (find_index >= 0)
            {
                return users[find_index].Length;
            }
            else
            {
                return "";
            }
        }

        public List<COLUMS_INFO> GetTUserList(int id)
        {
            List<COLUMS_INFO> userList = users.FindAll(o => o.info_id == id);
            if (userList != null)
            {

            }
            return userList;
        }


        public void disp_init()
        {
            this.my_list_view.View = System.Windows.Forms.View.Details;

            this.my_list_view.Columns.Add("BMS ID", 80, HorizontalAlignment.Left);
            this.my_list_view.Columns.Add("Name", 180, HorizontalAlignment.Left);
            this.my_list_view.Columns.Add("DLC", 60, HorizontalAlignment.Center);
            this.my_list_view.Columns.Add("Data1", 80, HorizontalAlignment.Left);
            this.my_list_view.Columns.Add("Data2", 80, HorizontalAlignment.Left);
            this.my_list_view.Columns.Add("Data3", 80, HorizontalAlignment.Left);
            this.my_list_view.Columns.Add("Data4", 80, HorizontalAlignment.Left);
            this.my_list_view.Columns.Add("Data5", 80, HorizontalAlignment.Left);
            this.my_list_view.Columns.Add("Data6", 80, HorizontalAlignment.Left);
            this.my_list_view.Columns.Add("Data7", 80, HorizontalAlignment.Left);
            this.my_list_view.Columns.Add("Data8", 80, HorizontalAlignment.Left);

            ImageList imgList = new ImageList();

            imgList.ImageSize = new Size(3, 3);// 设置行高 20 //分别是宽和高

            my_list_view.SmallImageList = imgList; //这里设置listView的SmallImageList ,用imgList将其撑大

            this.my_list_view.GridLines = true;


        }
        //整体更新listview 若出现 下拉条,刷新时无法下拉
        //单行更新功能
        //public void list_view_update()
        //{

        //    this.my_list_view.Invoke(new EventHandler(delegate
        //    {
        //        this.my_list_view.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
        //        //int j = 0;
        //        this.my_list_view.Items.Clear();

        //        foreach (COLUMS_INFO item in users)
        //        {

        //            ListViewItem l_id = new ListViewItem(item.info_id.ToString("X2").ToUpper());//item.info_id.ToString("X2").ToUpper()

        //            l_id.SubItems.Add(item.Name);
        //            l_id.SubItems.Add(item.Length);
        //            l_id.SubItems.Add(item.Value1);
        //            l_id.SubItems.Add(item.Value2);
        //            l_id.SubItems.Add(item.Value3);
        //            l_id.SubItems.Add(item.Value4);
        //            l_id.SubItems.Add(item.Value5);
        //            l_id.SubItems.Add(item.Value6);
        //            l_id.SubItems.Add(item.Value7);
        //            l_id.SubItems.Add(item.Value8);
        //            //my_list_view.Items[j] = l_id;
        //            //j++;
        //            //my_list_view.Items.AddRange(l_id);
        //            my_list_view.Items.Add(l_id);
        //        }

        //        this.my_list_view.EndUpdate();  //结束数据处理，UI界面一次性绘制。
        //    }));


        //}
        //public string save_list_view()
        //{
        //    String save_line = "";
        //    this.my_list_view.Invoke(new EventHandler(delegate
        //    {
        //        foreach (COLUMS_INFO item in users)
        //        {
        //            save_line += item.Value1 + '\t' + item.Value2 + '\t' + item.Value3 + '\t'
        //                 + item.Value4 + '\t' + item.Value5 + '\t' + item.Value6 + '\t'
        //                  + item.Value7 + '\t' + item.Value8 + '\t';
        //        }
        //    }));

        //    return save_line;
        //    //}
        //    public string save_list_name()
        //    {
        //        String save_line = "";
        //        this.my_list_view.Invoke(new EventHandler(delegate
        //        {
        //            foreach (COLUMS_INFO item in users)
        //            {
        //                save_line += item.Name + '\t';
        //            }
        //        }));

        //        return save_line;
        //    }
    }
}
