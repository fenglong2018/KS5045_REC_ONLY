using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.IO.Ports;
using System.Data.OleDb;
using System.Reflection; // 引用这个才能使用Missing字段 
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace KS5045上位机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private static ushort[] CRC16_TAB = new ushort[]{
//        public const  UInt16[] CRC16_TAB =
//        {
            0x0000, 0x1021, 0x2042, 0x3063, 0x4084, 0x50a5, 0x60c6, 0x70e7,
            0x8108, 0x9129, 0xa14a, 0xb16b, 0xc18c, 0xd1ad, 0xe1ce, 0xf1ef,
            0x1231, 0x0210, 0x3273, 0x2252, 0x52b5, 0x4294, 0x72f7, 0x62d6,
            0x9339, 0x8318, 0xb37b, 0xa35a, 0xd3bd, 0xc39c, 0xf3ff, 0xe3de,
            0x2462, 0x3443, 0x0420, 0x1401, 0x64e6, 0x74c7, 0x44a4, 0x5485,
            0xa56a, 0xb54b, 0x8528, 0x9509, 0xe5ee, 0xf5cf, 0xc5ac, 0xd58d,
            0x3653, 0x2672, 0x1611, 0x0630, 0x76d7, 0x66f6, 0x5695, 0x46b4,
            0xb75b, 0xa77a, 0x9719, 0x8738, 0xf7df, 0xe7fe, 0xd79d, 0xc7bc,
            0x48c4, 0x58e5, 0x6886, 0x78a7, 0x0840, 0x1861, 0x2802, 0x3823,
            0xc9cc, 0xd9ed, 0xe98e, 0xf9af, 0x8948, 0x9969, 0xa90a, 0xb92b,
            0x5af5, 0x4ad4, 0x7ab7, 0x6a96, 0x1a71, 0x0a50, 0x3a33, 0x2a12,
            0xdbfd, 0xcbdc, 0xfbbf, 0xeb9e, 0x9b79, 0x8b58, 0xbb3b, 0xab1a,
            0x6ca6, 0x7c87, 0x4ce4, 0x5cc5, 0x2c22, 0x3c03, 0x0c60, 0x1c41,
            0xedae, 0xfd8f, 0xcdec, 0xddcd, 0xad2a, 0xbd0b, 0x8d68, 0x9d49,
            0x7e97, 0x6eb6, 0x5ed5, 0x4ef4, 0x3e13, 0x2e32, 0x1e51, 0x0e70,
            0xff9f, 0xefbe, 0xdfdd, 0xcffc, 0xbf1b, 0xaf3a, 0x9f59, 0x8f78,
            0x9188, 0x81a9, 0xb1ca, 0xa1eb, 0xd10c, 0xc12d, 0xf14e, 0xe16f,
            0x1080, 0x00a1, 0x30c2, 0x20e3, 0x5004, 0x4025, 0x7046, 0x6067,
            0x83b9, 0x9398, 0xa3fb, 0xb3da, 0xc33d, 0xd31c, 0xe37f, 0xf35e,
            0x02b1, 0x1290, 0x22f3, 0x32d2, 0x4235, 0x5214, 0x6277, 0x7256,
            0xb5ea, 0xa5cb, 0x95a8, 0x8589, 0xf56e, 0xe54f, 0xd52c, 0xc50d,
            0x34e2, 0x24c3, 0x14a0, 0x0481, 0x7466, 0x6447, 0x5424, 0x4405,
            0xa7db, 0xb7fa, 0x8799, 0x97b8, 0xe75f, 0xf77e, 0xc71d, 0xd73c,
            0x26d3, 0x36f2, 0x0691, 0x16b0, 0x6657, 0x7676, 0x4615, 0x5634,
            0xd94c, 0xc96d, 0xf90e, 0xe92f, 0x99c8, 0x89e9, 0xb98a, 0xa9ab,
            0x5844, 0x4865, 0x7806, 0x6827, 0x18c0, 0x08e1, 0x3882, 0x28a3,
            0xcb7d, 0xdb5c, 0xeb3f, 0xfb1e, 0x8bf9, 0x9bd8, 0xabbb, 0xbb9a,
            0x4a75, 0x5a54, 0x6a37, 0x7a16, 0x0af1, 0x1ad0, 0x2ab3, 0x3a92,
            0xfd2e, 0xed0f, 0xdd6c, 0xcd4d, 0xbdaa, 0xad8b, 0x9de8, 0x8dc9,
            0x7c26, 0x6c07, 0x5c64, 0x4c45, 0x3ca2, 0x2c83, 0x1ce0, 0x0cc1,
            0xef1f, 0xff3e, 0xcf5d, 0xdf7c, 0xaf9b, 0xbfba, 0x8fd9, 0x9ff8,
            0x6e17, 0x7e36, 0x4e55, 0x5e74, 0x2e93, 0x3eb2, 0x0ed1, 0x1ef0,
        };



        KS5045上位机.disp_list disp = new KS5045上位机.disp_list();
        //Int32 test_current = 1;//写定的电流值
        bool CanRunning = false;
        bool CanSending = false;
        bool CanWriteClr = false;
        bool CanStopChg = false;
        bool CanStartChg = false;
        bool STA_PRA_sended = false;
        bool SAVE_DATA_flg = false;
        
        //int cansendtime = 0;
 //       string SaveTime = null;
        int send_cnt = 0;
        byte [] send_buffer = new byte[8];
        byte[] tx_buffer = new byte[8];
        int overtime = 0;//超时计数
        UInt16[] cell_volt = new UInt16[14];//单节电压  10改14 fenglong 20190920
        byte[] Cell_Balance = new byte[14];//单节均衡   10改14 fenglong 20190920
        byte[] Can_Rev_Buf = new byte[8];
        int type = 0;
        byte []data_state = new byte[8];





        //测试标准
        ////bool test_voltage = false;
        //bool test_current = false;
        //bool test_temp = false;
        //bool test_waring = false;
        //bool test_voltagepressure = false;

        //fenglong 20190921
        //bool step1_pass = false;  //校准步骤发送 201 指令 返回成功为true
        //bool step2_pass = false;  //校准步骤发送 203 指令 返回成功为true
        //bool step3_pass = false;  //校准步骤发送 205 指令 返回成功为true
        //int step4_pass = 0;  //校准步骤发送 207 指令 返回成功为1 不成功为2
        //bool step5_pass = false;  //校准步骤发送 206 指令 返回成功为true


        KS5045上位机.CanManager loadercan;
        KS5045上位机.CanManager.VCI_CAN_OBJ[] ReceiveBuffer = new KS5045上位机.CanManager.VCI_CAN_OBJ[1000];


//        UInt16 aa= CRC16_TAB[3];

        //       UInt32 rx_cnt;

        //Label[] SysDataLabelArr = new Label[20];
        Label[] SysFlagLabelArr = new Label[16];

        Label[] SoftFlagLabelArr = new Label[16];
        Label[] BqFlagLabelArr = new Label[16];
        Label[] RecFlagLabelArr = new Label[16];
        Label[] ChgFlagLabelArr = new Label[6];

        Label[] Cell_Volt = new Label[14];  // 10改14 fenglong 20190920

        //       bool auto_save_flag = false;


        private void Form1_Load(object sender, EventArgs e)
        {
 //           timer1.Enabled = true;
            send_buffer[1] = 0x00;
            SysStatu.Text = "System state：               ";
            CommStatus.Text = "Serial port close                 ";
            CommStatus.ForeColor = Color.Red ;
            //           tsslDate.Text = DateTime.Today.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
            //  nulllabel.Text = "                                                                 ";

            //try
            //{
            //    foreach (string com in System.IO.Ports.SerialPort.GetPortNames())  //自动获取串行口名称
            //        this.cmPort.Items.Add(com);
            //    cmPort.SelectedIndex = 0;
            //}
            //catch
            //{
            //    CommStatus.Text = "No serial port";
            //}




        //public UInt16[] crc16_tab = new UInt16[]

            loadercan = new KS5045上位机.CanManager();
            loadercan.CanId = KS5045上位机.Consts.BAT_CAN_ID;
            combps.Enabled = false;



            Cell_Volt[0] = cell1;
            Cell_Volt[1] = cell2;
            Cell_Volt[2] = cell3;
            Cell_Volt[3] = cell4;
            Cell_Volt[4] = cell5;
            Cell_Volt[5] = cell6;
            Cell_Volt[6] = cell7;
            Cell_Volt[7] = cell8;
            Cell_Volt[8] = cell9;
            Cell_Volt[9] = cell10;
            Cell_Volt[10] = cell11;
            Cell_Volt[11] = cell12;
            Cell_Volt[12] = cell13;
            Cell_Volt[13] = cell14;

            //SysFlagLabelArr[0] = flag1;
            //SysFlagLabelArr[1] = flag2;
            //SysFlagLabelArr[2] = flag3;
            //SysFlagLabelArr[3] = flag4;
            //SysFlagLabelArr[4] = flag5;
            //SysFlagLabelArr[5] = flag6;
            //SysFlagLabelArr[6] = flag7;
            //SysFlagLabelArr[7] = flag8; 
            //SysFlagLabelArr[8] = flag9;
            //SysFlagLabelArr[9] = flag10;
            //SysFlagLabelArr[10] = flag11;
            //SysFlagLabelArr[11] = flag12;
            //SysFlagLabelArr[12] = flag13;
            //SysFlagLabelArr[13] = flag14;
            //SysFlagLabelArr[14] = flag15;
            //SysFlagLabelArr[15] = flag16;

            SoftFlagLabelArr[0] = SoftOv;
            SoftFlagLabelArr[1] = SoftUv;
            SoftFlagLabelArr[2] = SoftOt;
            SoftFlagLabelArr[3] = SoftUt;
            SoftFlagLabelArr[4] = SoftOcc;
            SoftFlagLabelArr[5] = softOcd;
            SoftFlagLabelArr[6] = SoftUSoc;
            SoftFlagLabelArr[7] = SoftVima;
            SoftFlagLabelArr[8] = SoftImT;
            SoftFlagLabelArr[9] = SoftROc;

            BqFlagLabelArr[0] = BqOv;
            BqFlagLabelArr[1] = BqUv;
            BqFlagLabelArr[2] = BqOt;
            BqFlagLabelArr[3] = BqUt;
            BqFlagLabelArr[4] = BqOcc;
            BqFlagLabelArr[5] = BqOcd;
            BqFlagLabelArr[6] = BqUSoc;
            BqFlagLabelArr[7] = BqVima;
            BqFlagLabelArr[8] = BqImT;
            BqFlagLabelArr[9] = BqROc;
            BqFlagLabelArr[10] = BqErr;
            BqFlagLabelArr[11] = BqSUv;
            BqFlagLabelArr[12] = BqScd;

            RecFlagLabelArr[0] = RecOv;
            RecFlagLabelArr[1] = RecUv;
            RecFlagLabelArr[2] = RecOt;
            RecFlagLabelArr[3] = RecUt;
            RecFlagLabelArr[4] = RecOcc;
            RecFlagLabelArr[5] = RecOcd;
            RecFlagLabelArr[6] = RecUSoc;
            RecFlagLabelArr[7] = RecVima;
            RecFlagLabelArr[8] = RecImT;
            RecFlagLabelArr[9] = RecROc;
            RecFlagLabelArr[10] = RecErr;
            RecFlagLabelArr[11] = RecSUv;
            RecFlagLabelArr[12] = RecScd;

            ChgFlagLabelArr[0] = SysCharging;
            ChgFlagLabelArr[1] = SysHeating;
            ChgFlagLabelArr[2] = SysNoCharging;
            ChgFlagLabelArr[3] = SysStopHeating;
            ChgFlagLabelArr[4] = SysHeatCharging;
            ChgFlagLabelArr[5] = SysOcc3A;


            FormInit();
            //data_processing(146);//测试时调用

        }

        private void FormInit()
        {

            

            //for (int i = 0; i < 16; i++)
            //{
            //    SysFlagLabelArr[i].Enabled = false;
            //}
            for (int i = 0; i < 14; i++)
            {
                Cell_Volt[i].Text = "NA";

            }

            for (int i = 0; i < 10; i++)
            {
                SoftFlagLabelArr[i].Enabled = false;
            }

            for (int i = 0; i < 13; i++)
            {
                BqFlagLabelArr[i].Enabled = false;
            }

            for (int i = 0; i < 13; i++)
            {
                RecFlagLabelArr[i].Enabled = false;
            }

            for (int i = 0; i < 6; i++)
            {
                ChgFlagLabelArr[i].Enabled = false;
            }
            
        }

        private void OpenPortTool_Click(object sender, EventArgs e)
        {
            try
            {
                //loadercan.init((UInt32)cmPort.SelectedIndex, 8);
                //               loadercan.init((UInt32)0, 10);//8 = 250k  10 = 500k
  //              loadercan.init((UInt32)0, 8);//8 = 250k  10 = 500k
                //loadercan.init((UInt32)1, 8);//8 = 250k  10 = 500k

                if (loadercan.Open())
                {
                    loadercan.start();
                    timer3.Enabled = true;
 //                   send_buffer[1] = 0x01;
                    can_start();
                }
                else
                {
                    CommStatus.Text = "打开设备失败,请检查设备类型和设备索引号是否正确!";
                    CommStatus.ForeColor = Color.Red;
                    CanRunning = false;
                    //cmPort.Enabled = true;
                    Thread.Sleep(100);
                    loadercan.Close();
                }
            }

            catch (Exception Err)
            {
                loadercan.Close();
                //             TxCmdTimer.Enabled = false;
                CommStatus.Text = "串口出错！                                                                             ";   // 清空状态栏
                MessageBox.Show(Err.Message, "串口打开出错！");

            }
        }

        public void can_start()
        {
            string str_info = "";
            if (CanRunning == false)
            {

                CanRunning = true;
                Thread thread_can = new Thread(new ThreadStart(can_recive));
                thread_can.IsBackground = true;
                thread_can.Start();

                CanSending = true;
                Thread thread_cansend = new Thread(new ThreadStart(can_send));
                thread_cansend.IsBackground = true;
                thread_cansend.Start();

                str_info = " CAN2.0：" + //cmPort.Text +
                 " BPS：250Kbps";
                CommStatus.Text = str_info;
                CommStatus.ForeColor = Color.Blue;
                //cmPort.Enabled = false;
  //              rx_cnt = 0;
            }
            else
            {
                loadercan.Close();
                CanRunning = false;
                CommStatus.Text = "设备：未连接";
         //       cmPort.Enabled = true;
            }
        }

        /// <summary>
        /// 线程接收数据函数
        /// </summary>
        /// 
        unsafe private void can_recive()            
        {
            UInt32 res = new UInt32();
            //UInt32 tmp_id = new UInt32();
            byte cmd;
            byte len;

            byte [] RecCrcData= new byte[2];

            //           timer2.Enabled = true;
            //           timer3.Enabled = true;
            try
            {
                while (CanRunning)
                {
                    this.Invoke(new EventHandler(delegate
                    {                        
                        res = loadercan.GetReceiveNum();
                    }));

                    if ((res > 0) && (res < 4294967295))
                        //if (res >= 800) 
                    {
                        overtime = 0;                       
                        res = loadercan.Receive(ref ReceiveBuffer[0]);

                        //UInt32 u32_id = 0;
                        for (UInt32 i = 0; i < res; i++)
                        {

       //                     u32_id = ReceiveBuffer[i].ID;
                            len = 0;
                            if (ReceiveBuffer[i].RemoteFlag == 0)
                            {
                                len = (byte)(ReceiveBuffer[i].DataLen % 9);

                                fixed (KS5045上位机.CanManager.VCI_CAN_OBJ* m_recobj1 = &ReceiveBuffer[i])
                                {
                                    for (int j = 0; j < len; j++)
                                    {
                                        Can_Rev_Buf[j] = Convert.ToByte(m_recobj1->Data[j]);
                                    }
                                }


                                //以下增加CRC  fenglong 20191025

                                if ((Can_Rev_Buf[0] == 0xAD) && (Can_Rev_Buf[1] == 0xDE))       //判断帧头是否正确
                                {
                                    RecCrcData = CRC(Can_Rev_Buf, 6);
                                    if ( (RecCrcData[0]== Can_Rev_Buf[6]) && (RecCrcData[1] == Can_Rev_Buf[7]) )     //判断校验是否正确
                                    {
                                        cmd = ReceiveBuffer[i].Data[3];//(byte)(u32_id);
                                        data_processing(cmd);//处理返回的指令
                                    }
                                }
                                else if((Can_Rev_Buf[0] == 0x00) && (Can_Rev_Buf[1] == 0x04))
                                {
                                    cmd = RecCrcData[2];
                                    data_processing2(cmd);//处理返回的指令
                                }
                                
                                



                                //tmp_id = u32_id;


                            }

                            //tmp_id = u32_id;
                            //cmd = (byte)(u32_id);
                            //data_processing(tmp_id);//处理返回的指令
                        }

                    }
                }
            }
            catch (Exception e)
            {
                CommStatus.Text = e.Message;
                loadercan.Close();
                loadercan.Open();
            }
        }


        
        private void data_processing2(UInt32 rec_cmd)
        {
            UInt16 tmp_data = 0;
            byte tmp_ver; 
            //byte[] binchar = new byte[] { };
            //float temp_t = 0;
          //  float data_tmp = 0;//方便处理实型数据
          //  int j;

            byte cmd;
            cmd = (byte)rec_cmd;

            switch(cmd)
            {
                case 0x9F:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.BAT_SUPPLIER.Invoke(new EventHandler(delegate
                    {
                        if (tmp_data == 2)
                        {
                            BAT_SUPPLIER.Text = "SCUD";
                        }
                        else
                        {
                            BAT_SUPPLIER.Text = "XX";
                        }


                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)1;//精度0.5
                        //data_tmp -= 40;
                        //temp_6.Text = data_tmp.ToString("F");
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;


                case 0xA0:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.BAT_BMS_HW_VER.Invoke(new EventHandler(delegate
                    {
                        tmp_ver = (byte)(tmp_data >> 12 & 0x000F);
                        BAT_BMS_HW_VER.Text = tmp_ver.ToString();
                        if (tmp_ver == 0)
                        {
                            BAT_BMS_HW_VER.Text = "";
                        }
                        tmp_ver = (byte)(tmp_data >> 8 & 0x000F);

                        BAT_BMS_HW_VER.Text += tmp_ver.ToString();
                        BAT_BMS_HW_VER.Text += ".";

                        tmp_ver = (byte)(tmp_data >> 4 & 0x000F);

                        BAT_BMS_HW_VER.Text += tmp_ver.ToString();
                        BAT_BMS_HW_VER.Text += ".";

                        tmp_ver = (byte)(tmp_data & 0x000F);

                        BAT_BMS_HW_VER.Text += tmp_ver.ToString();


                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0xA1:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.BAT_BMS_APP_SW_VER.Invoke(new EventHandler(delegate
                    {

                        tmp_ver = (byte)(tmp_data >> 12 & 0x000F);
                        BAT_BMS_APP_SW_VER.Text = tmp_ver.ToString();
                        if (tmp_ver == 0)
                        {
                            BAT_BMS_APP_SW_VER.Text = "";
                        }

                        tmp_ver = (byte)(tmp_data >> 8 & 0x000F);

                        BAT_BMS_APP_SW_VER.Text += tmp_ver.ToString();
                        BAT_BMS_APP_SW_VER.Text += ".";

                        tmp_ver = (byte)(tmp_data >> 4 & 0x000F);

                        BAT_BMS_APP_SW_VER.Text += tmp_ver.ToString();
                        BAT_BMS_APP_SW_VER.Text += ".";

                        tmp_ver = (byte)(tmp_data & 0x000F);

                        BAT_BMS_APP_SW_VER.Text += tmp_ver.ToString();


                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0xA2:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.BAT_BMS_UN_SW_VER.Invoke(new EventHandler(delegate
                    {
                        tmp_ver = (byte)(tmp_data >> 12 & 0x000F);
                        BAT_BMS_UN_SW_VER.Text = tmp_ver.ToString();
                        if (tmp_ver == 0)
                        {
                            BAT_BMS_UN_SW_VER.Text = "";
                        }

                        tmp_ver = (byte)(tmp_data >> 8 & 0x000F);

                        BAT_BMS_UN_SW_VER.Text += tmp_ver.ToString();
                        BAT_BMS_UN_SW_VER.Text += ".";

                        tmp_ver = (byte)(tmp_data >> 4 & 0x000F);

                        BAT_BMS_UN_SW_VER.Text += tmp_ver.ToString();
                        BAT_BMS_UN_SW_VER.Text += ".";

                        tmp_ver = (byte)(tmp_data & 0x000F);

                        BAT_BMS_UN_SW_VER.Text += tmp_ver.ToString();

                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                default:

                    break;

            }
        }


                     




        private void data_processing(UInt32 rec_cmd)
        {
            UInt16 tmp_data = 0;
            byte tmp_ver; 
            //byte[] binchar = new byte[] { };
            //float temp_t = 0;
            float data_tmp = 0;//方便处理实型数据
            int j;

            byte cmd;
            cmd = (byte)rec_cmd;

            switch(cmd)
            {
                case 0x00:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];

                    this.BAT_BMS_CP_VER.Invoke(new EventHandler(delegate
                    {

                        tmp_ver = (byte)(tmp_data >> 12 & 0x000F);
                        BAT_BMS_CP_VER.Text = tmp_ver.ToString();
                        if (tmp_ver==0)
                        {
                            BAT_BMS_CP_VER.Text = "";
                        }
                        
                        tmp_ver = (byte)(tmp_data>>8 & 0x000F);

                        BAT_BMS_CP_VER.Text += tmp_ver.ToString();
                        BAT_BMS_CP_VER.Text += ".";

                        tmp_ver = (byte)(tmp_data>>4 & 0x000F);

                        BAT_BMS_CP_VER.Text += tmp_ver.ToString();
                        BAT_BMS_CP_VER.Text += ".";

                        tmp_ver = (byte)(tmp_data & 0x000F);

                        BAT_BMS_CP_VER.Text += tmp_ver.ToString();


                    }));

                    //disp.set_value(0x47, Convert.ToDecimal(temp[k] << 1).ToString());//写入Vbat的值

                    disp.set_value(cmd, BAT_BMS_CP_VER.Text);

                    break;

                case 0x01:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.BAT_MAX_CHARGING_VOLTAGE.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        BAT_MAX_CHARGING_VOLTAGE.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x02:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.BAT_MIN_DISCHARGING_VOLTAGE.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        BAT_MIN_DISCHARGING_VOLTAGE.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x03:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.BAT_MAX_CHARGING_CURRENT.Invoke(new EventHandler(delegate
                    {
                        data_tmp = tmp_data;
                        data_tmp = data_tmp * (float)1;//精度0.5
                        data_tmp -= 4000;
                        BAT_MAX_CHARGING_CURRENT.Text = data_tmp.ToString("F0");
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x04:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.BAT_RATED_CAPACITY.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        BAT_RATED_CAPACITY.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x05:
                    
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.BAT_MAX_TEMP.Invoke(new EventHandler(delegate
                    {
                        data_tmp = tmp_data;
                        data_tmp = data_tmp * (float)1;//精度0.5
                        data_tmp -= 40;
                        BAT_MAX_TEMP.Text = data_tmp.ToString("F0");
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x06:
                    
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.BAT_MIN_TEMP.Invoke(new EventHandler(delegate
                    {
                        data_tmp = tmp_data;
                        data_tmp = data_tmp * (float)1;//精度0.5
                        data_tmp -= 40;
                        BAT_MIN_TEMP.Text = data_tmp.ToString("F0");
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x07:
                    
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.BAT_RATED_CYCLE_INDEX.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        BAT_RATED_CYCLE_INDEX.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;
                case 0x08:
                    
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.BAT_CELLS_NUM.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        BAT_CELLS_NUM.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x09:
                    
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.BAT_TEMP_SENSOR_NUM.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        BAT_TEMP_SENSOR_NUM.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x0A:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.CHG_temp_mosfet.Invoke(new EventHandler(delegate
                    {
                        data_tmp = tmp_data;
                        data_tmp = data_tmp * (float)1;//精度0.5
                        data_tmp -= 40;
                        CHG_temp_mosfet.Text = data_tmp.ToString("F0");
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x0B:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.DSC_temp_mosfet.Invoke(new EventHandler(delegate
                    {
                        data_tmp = tmp_data;
                        data_tmp = data_tmp * (float)1;//精度0.5
                        data_tmp -= 40;
                        DSC_temp_mosfet.Text = data_tmp.ToString("F0");
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;




                case 0x10:
                    
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.BAT_TYPE.Invoke(new EventHandler(delegate
                    {
                        switch(tmp_data)
                        {
                            case 3:
                                BAT_TYPE.Text = "三元锂";
                                break;

                            case 1:
                                BAT_TYPE.Text = "钛酸锂";
                                break;

                            case 2:
                                BAT_TYPE.Text = "三元锂离子";
                                break;
                        }

                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x11:              //BAT_SOC

                    tmp_data = Can_Rev_Buf[4];
                    this.soc.Invoke(new EventHandler(delegate
                    {
                        data_tmp = tmp_data;
                        data_tmp = data_tmp * (float)1;//精度0.5
                        soc.Text = data_tmp.ToString("F0");
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x12://
                    
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.BAT_Capacity.Invoke(new EventHandler(delegate
                    {
                        data_tmp = tmp_data;
                        data_tmp = data_tmp * (float)1;//精度0.5
                        BAT_Capacity.Text = data_tmp.ToString("F0");
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x13://

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.voltage.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        voltage.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x14:
                    //voltage
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.VDiff.Invoke(new EventHandler(delegate
                    {
                        data_tmp = tmp_data;
                        data_tmp = data_tmp * (float)1;//精度0.5
                        VDiff.Text = data_tmp.ToString("F0");
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x15:      //CELL MAX VOLTAGE

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.CELL_MAX_VOLTAGE.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.01;//精度0.5
                        CELL_MAX_VOLTAGE.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x16:  //CELL_MIX_VOLTAGE

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.CELL_MIX_VOLTAGE.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.01;//精度0.5
                        CELL_MIX_VOLTAGE.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;
                case 0x17:          //CURRENT

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.current.Invoke(new EventHandler(delegate
                    {
                        data_tmp = tmp_data;
                        data_tmp = data_tmp * (float)1;//精度0.5
                        data_tmp -= 4000;
                        current.Text = data_tmp.ToString("F0");
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;




                //case 0x18:

                //    tmp_data = Can_Rev_Buf[5];
                //    tmp_data <<= 8;
                //    tmp_data += Can_Rev_Buf[4];
                //    this.envtemp.Invoke(new EventHandler(delegate
                //    {
                //        data_tmp = tmp_data;
                //        data_tmp = data_tmp * (float)1;//精度0.5
                //        data_tmp -= 40;
                //        envtemp.Text = data_tmp.ToString("F0");
                //    }));


                //    disp.set_value(cmd, tmp_data.ToString());

                //    break;


  
                //case 0x19:

                //    tmp_data = Can_Rev_Buf[5];
                //    tmp_data <<= 8;
                //    tmp_data += Can_Rev_Buf[4];
                //    this.temp_mosfet.Invoke(new EventHandler(delegate
                //    {
                //        data_tmp = tmp_data;
                //        data_tmp = data_tmp * (float)1;//精度0.5
                //        data_tmp -= 40;
                //        temp_mosfet.Text = data_tmp.ToString("F0");
                //    }));


                //    disp.set_value(cmd, tmp_data.ToString());

                //    break;


                case 0x1A:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.CELL_MAX_TEMP.Invoke(new EventHandler(delegate
                    {
                        data_tmp = tmp_data;
                        data_tmp = data_tmp * (float)1;//精度0.5
                        data_tmp -= 40;
                        CELL_MAX_TEMP.Text = data_tmp.ToString("F0");
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x1B:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.CELL_MIN_TEMP.Invoke(new EventHandler(delegate
                    {
                        data_tmp = tmp_data;
                        data_tmp = data_tmp * (float)1;//精度0.5
                        data_tmp -= 40;
                        CELL_MIN_TEMP.Text = data_tmp.ToString("F0");
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;


                case 0x1C:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.lifetimes.Invoke(new EventHandler(delegate
                    {
                        data_tmp = tmp_data;
                        data_tmp = data_tmp * (float)1;//精度0.5
                        lifetimes.Text = data_tmp.ToString("F0");
                    }));


                    disp.set_value(cmd, tmp_data.ToString());

                    break;





                case 0x1D:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];

                    for (int i = 0; i < 10; i++)
                    {
                        j = tmp_data;
                        if (((j >> i) &0x01) == 1)//根据返回值决定亮还是不亮
                        {
                            this.SoftFlagLabelArr[i].Invoke(new EventHandler(delegate
                            {
                                SoftFlagLabelArr[i].Enabled = true;
                            }));
                        }
                        else
                        {
                            this.SoftFlagLabelArr[i].Invoke(new EventHandler(delegate
                            {
                                SoftFlagLabelArr[i].Enabled = false;
                            }));
                        }

                    }

                    disp.set_value(cmd, tmp_data.ToString());

                    break;



                case 0x1E:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];

                    for (int i = 0; i < 13; i++)
                    {
                        j = tmp_data;
                        if (((j >> i) & 0x01) == 1)//根据返回值决定亮还是不亮
                        {
                            this.BqFlagLabelArr[i].Invoke(new EventHandler(delegate
                            {
                                BqFlagLabelArr[i].Enabled = true;
                            }));
                        }
                        else
                        {
                            this.BqFlagLabelArr[i].Invoke(new EventHandler(delegate
                            {
                                BqFlagLabelArr[i].Enabled = false;
                            }));
                        }
                    }

                    disp.set_value(cmd, tmp_data.ToString());

                    break;



                case 0x1F:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];

                    for (int i = 0; i < 13; i++)
                    {
                        j = tmp_data;
                        if (((j >> i) & 0x01) == 1)//根据返回值决定亮还是不亮
                        {
                            this.RecFlagLabelArr[i].Invoke(new EventHandler(delegate
                            {
                                RecFlagLabelArr[i].Enabled = true;
                            }));
                        }
                        else
                        {
                            this.RecFlagLabelArr[i].Invoke(new EventHandler(delegate
                            {
                                RecFlagLabelArr[i].Enabled = false;
                            }));
                        }
                    }

                    disp.set_value(cmd, tmp_data.ToString());

                    break;



                case 0x20:


                    break;

               

                case 0x50:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.cell1.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        cell1.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;


                case 0x51:
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.cell2.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        cell2.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x52:
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.cell3.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        cell3.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x53:
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.cell4.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        cell4.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x54:
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.cell5.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        cell5.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x55:
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.cell6.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        cell6.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x56:
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.cell7.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        cell7.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x57:
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.cell8.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        cell8.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x58:
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.cell9.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        cell9.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x59:
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.cell10.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        cell10.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x5A:
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.cell11.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        cell11.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x5B:
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.cell12.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        cell12.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x5C:
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.cell13.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        cell13.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x5D:
                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.cell14.Invoke(new EventHandler(delegate
                    {
                        //data_tmp = tmp_data;
                        //data_tmp = data_tmp * (float)0.1;//精度0.5
                        cell14.Text = tmp_data.ToString();
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x90:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.temp_1.Invoke(new EventHandler(delegate
                    {
                        data_tmp = tmp_data;
                        data_tmp = data_tmp * (float)1;//精度0.5
                        data_tmp -= 40;
                        temp_1.Text = data_tmp.ToString("F0");
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x91:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.temp_2.Invoke(new EventHandler(delegate
                    {
                        data_tmp = tmp_data;
                        data_tmp = data_tmp * (float)1;//精度0.5
                        data_tmp -= 40;
                        temp_2.Text = data_tmp.ToString("F0");
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x92:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.temp_3.Invoke(new EventHandler(delegate
                    {
                        data_tmp = tmp_data;
                        data_tmp = data_tmp * (float)1;//精度0.5
                        data_tmp -= 40;
                        temp_3.Text = data_tmp.ToString("F0");
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x93:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.temp_4.Invoke(new EventHandler(delegate
                    {
                        data_tmp = tmp_data;
                        data_tmp = data_tmp * (float)1;//精度0.5
                        data_tmp -= 40;
                        temp_4.Text = data_tmp.ToString("F0");
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x94:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.temp_5.Invoke(new EventHandler(delegate
                    {
                        data_tmp = tmp_data;
                        data_tmp = data_tmp * (float)1;//精度0.5
                        data_tmp -= 40;
                        temp_5.Text = data_tmp.ToString("F0");
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                case 0x95:

                    tmp_data = Can_Rev_Buf[5];
                    tmp_data <<= 8;
                    tmp_data += Can_Rev_Buf[4];
                    this.temp_6.Invoke(new EventHandler(delegate
                    {
                        data_tmp = tmp_data;
                        data_tmp = data_tmp * (float)1;//精度0.5
                        data_tmp -= 40;
                        temp_6.Text = data_tmp.ToString("F0");
                    }));

                    disp.set_value(cmd, tmp_data.ToString());

                    break;

                default:

                    break;
            }
        }
     
        private void return_mode(int data)//发送校准指令返回值
        {
            int data_return;
            data_return = Can_Rev_Buf[0];
            if (data_return == 1)//若返回成功为1
            {
               /* if (data == 1)
                    step1_pass = true;  //201返回成功为true
                if (data == 3)
                    step2_pass = true;//203返回成功为true
                if (data == 5)
                    step3_pass = true;//205返回成功为true*/
            }
        }

        /// <summary>
        /// 线程发送函数
        /// </summary>
        /// 
        unsafe private void can_send()
        {
            try
            {

                /* while (CanSending)
                 {
                     byte cmd;
                     byte len;
                     byte[] tx_buffer = new byte[8];
                     type = 1;
                     for (int i = 1; i < 13; i++)
                     {
                         len = 0;
                         cmd = (byte)i;
                         tx_buffer[0] = cmd;
                         loadercan.StandardWrite(tx_buffer, cmd, len, type);
                         Thread.Sleep(200);
                     }
                 }*/
                while (CanSending)
                {

                    byte cmd;
                    byte len;
                    byte[] tx_buffer = new byte[8];
                    byte[] SendCrcData = new byte[2];
                    type = 1;
                    len = 8;
                    cmd = (byte)3;

                    tx_buffer[0] = 0xAD;
                    tx_buffer[1] = 0xDE;
                    tx_buffer[2] = 0x23;
                    //tx_buffer[3] = 0x13;
                    tx_buffer[4] = 0x02;
                    tx_buffer[5] = 0x00;

                    //SendCrcData = CRC(tx_buffer, 6);
                    //tx_buffer[6] = 0xE2;
                    //tx_buffer[7] = 0x87;


                    if(STA_PRA_sended == false)
                    {
                        for (byte i = 0x00; i <= 0x09; i++)
                        {
                            tx_buffer[3] = i;
                            //tx_buffer[5] = i;
                            //tx_buffer[5] = 0;
                            SendCrcData = CRC(tx_buffer, 6);
                            tx_buffer[6] = SendCrcData[0];
                            tx_buffer[7] = SendCrcData[1];
                            loadercan.StandardWrite(tx_buffer, cmd, len, type);
                            this.timer2.Enabled = true;
                            Thread.Sleep(Consts.TX_DELAY);
                        }

                        tx_buffer[3] = 0x10;
                        //tx_buffer[5] = i;
                        //tx_buffer[5] = 0;
                        SendCrcData = CRC(tx_buffer, 6);
                        tx_buffer[6] = SendCrcData[0];
                        tx_buffer[7] = SendCrcData[1];
                        loadercan.StandardWrite(tx_buffer, cmd, len, type);
                        this.timer2.Enabled = true;
                        Thread.Sleep(Consts.TX_DELAY);



                        //0x9F~0xA3     通信格式另立，，20191024 fenglong

                        tx_buffer[0] = 0x51;
                        tx_buffer[1] = 0x01;

                        tx_buffer[2] = 0x23;
                        //tx_buffer[3] = 0x13;
                        tx_buffer[4] = 0x00;
                        tx_buffer[5] = 0x00;
                        tx_buffer[6] = 0x00;
                        tx_buffer[7] = 0x00;


                        for (byte i = 0x9F; i <= 0xA2; i++)
                        {
                            tx_buffer[3] = i;
                            //tx_buffer[5] = 0;
                            //SendCrcData = CRC(tx_buffer, 6);
                            //tx_buffer[6] = SendCrcData[0];
                            //tx_buffer[7] = SendCrcData[1];
                            loadercan.StandardWrite(tx_buffer, cmd, len, type);
                            this.timer2.Enabled = true;
                            Thread.Sleep(Consts.TX_DELAY);
                        }

                        STA_PRA_sended = true;

                        //0x9F~0xA3     通信格式另立      20191024 fenglong

                        tx_buffer[0] = 0xAD;
                        tx_buffer[1] = 0xDE;
                        tx_buffer[2] = 0x23;
                        //tx_buffer[3] = 0x13;
                        tx_buffer[4] = 0x02;
                        tx_buffer[5] = 0x00;


                        //timer3.Enabled = true;

                    }

                    for (byte i = 0x0A; i <= 0x0B; i++)
                    {
                        tx_buffer[3] = i;
                        //tx_buffer[5] = i;
                        //tx_buffer[5] = 0;
                        SendCrcData = CRC(tx_buffer, 6);
                        tx_buffer[6] = SendCrcData[0];
                        tx_buffer[7] = SendCrcData[1];
                        loadercan.StandardWrite(tx_buffer, cmd, len, type);
                        this.timer2.Enabled = true;
                        Thread.Sleep(Consts.TX_DELAY);
                    }


                    for (byte i = 0x11; i <= 0x20; i++)
                    {
                        tx_buffer[3] = i;
                        //tx_buffer[5] = 0;
                        SendCrcData = CRC(tx_buffer, 6);
                        tx_buffer[6] = SendCrcData[0];
                        tx_buffer[7] = SendCrcData[1];
                        loadercan.StandardWrite(tx_buffer, cmd, len, type);
                        this.timer2.Enabled = true;
                        Thread.Sleep(Consts.TX_DELAY);
                    }

                    for (byte i = 0x50; i <= 0x5D; i++)
                    {
                        tx_buffer[3] = i;
                        //tx_buffer[5] = i;
                        SendCrcData = CRC(tx_buffer, 6);
                        tx_buffer[6] = SendCrcData[0];
                        tx_buffer[7] = SendCrcData[1];
                        loadercan.StandardWrite(tx_buffer, cmd, len, type);
                        this.timer2.Enabled = true;
                        Thread.Sleep(Consts.TX_DELAY);
                    }

                    for (byte i = 0x90; i <= 0x95; i++)
                    {
                        tx_buffer[3] = i;
                        //tx_buffer[5] = 0;
                        SendCrcData = CRC(tx_buffer, 6);
                        tx_buffer[6] = SendCrcData[0];
                        tx_buffer[7] = SendCrcData[1];
                        loadercan.StandardWrite(tx_buffer, cmd, len, type);
                        this.timer2.Enabled = true;
                        Thread.Sleep(Consts.TX_DELAY);
                    }

                    if (CanWriteClr==true)
                    {
                        CanWriteClr = false;

                        tx_buffer[0] = 0xAD;
                        tx_buffer[1] = 0xDE;
                        tx_buffer[2] = 0x63;
                        tx_buffer[3] = 0x1F;
                        tx_buffer[4] = 0x00;
                        tx_buffer[5] = 0x00;

                        SendCrcData = CRC(tx_buffer, 6);
                        tx_buffer[6] = SendCrcData[0];
                        tx_buffer[7] = SendCrcData[1];
                        loadercan.StandardWrite(tx_buffer, cmd, len, type);
                        button1.ForeColor = Color.Black;
                        Thread.Sleep(Consts.TX_DELAY);
                    }

                    
                    if (CanStopChg == true)
                    {
                        CanStopChg = false;

                        tx_buffer[0] = 0xAD;
                        tx_buffer[1] = 0xDE;
                        tx_buffer[2] = 0xA3;
                        tx_buffer[3] = 0x20;
                        tx_buffer[4] = 0x00;
                        tx_buffer[5] = 0x00;

                        SendCrcData = CRC(tx_buffer, 6);
                        tx_buffer[6] = SendCrcData[0];
                        tx_buffer[7] = SendCrcData[1];
                        loadercan.StandardWrite(tx_buffer, cmd, len, type);
                        button2.ForeColor = Color.Black;
                        Thread.Sleep(Consts.TX_DELAY);
                    }


                    if (CanStartChg == true)
                    {
                        CanStartChg = false;

                        tx_buffer[0] = 0xAD;
                        tx_buffer[1] = 0xDE;
                        tx_buffer[2] = 0xA3;
                        tx_buffer[3] = 0x20;
                        tx_buffer[4] = 0x01;
                        tx_buffer[5] = 0x00;

                        SendCrcData = CRC(tx_buffer, 6);
                        tx_buffer[6] = SendCrcData[0];
                        tx_buffer[7] = SendCrcData[1];
                        loadercan.StandardWrite(tx_buffer, cmd, len, type);
                        button3.ForeColor = Color.Black;
                        Thread.Sleep(Consts.TX_DELAY);
                    }

                }


            }
            catch (Exception e)
            {
                CommStatus.Text = e.Message;
                loadercan.Close();
                loadercan.Open();
            }
        }

        private void ClosePortTool_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = false;
            timer2.Enabled = false;
            overtime = 0;
            CanRunning = false;
            CommStatus.Text = "串口未打开";    // 清空状态栏
            CommStatus.ForeColor= Color.Red;
            //          cmPort.Enabled = true;            // 使能选择串口  
            loadercan.Close();
        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            overtime++;//接收超时计数

            if (CanSending==false)
            {
                timer2.Enabled = false;
                overtime = 0;
            }

            if (overtime > 5)//超时
            {
                overtime = 0;
                //MessageBox.Show("通信超时！");
                CommStatus.Text = "通信超时！";

            }
        }

     

        private void Enter_Caliraton_Test_Mode() //201指令，进入测试模式
        {
            byte cmd;
            byte len;
            byte[] tx_buffer = new byte[8];
            tx_buffer[0] = 0xC5;
            tx_buffer[1] = 0xE2;
            tx_buffer[2] = 0xA2;
            tx_buffer[3] = 0x30;
            tx_buffer[4] = 0xBD;
            tx_buffer[5] = 0x12;
            tx_buffer[6] = 0x5C;
            tx_buffer[7] = 0xC8;
            type = 1;
            len = 8;
            cmd = (byte)1;
            loadercan.StandardWrite(tx_buffer, cmd, len, type);
            Thread.Sleep(50);
        }
        private void Unlock_Calibration_Memory_For_Writing()//203指令
        {
            byte cmd;
            byte len;
            byte[] tx_buffer = new byte[8];
            tx_buffer[0] = 0xF2;
            tx_buffer[1] = 0x9D;
            tx_buffer[2] = 0x89;
            tx_buffer[3] = 0xBE;
            tx_buffer[4] = 0xBB;
            tx_buffer[5] = 0x6C;
            tx_buffer[6] = 0x27;
            tx_buffer[7] = 0x7C;
            type = 1;
            len = 8;
            cmd = (byte)3;
            loadercan.StandardWrite(tx_buffer, cmd, len, type);
            Thread.Sleep(50);
        }

        private void Exit_Calibration_Test_Mode()//退出测试模式
        {
            byte cmd;
            byte len;
            byte[] tx_buffer = new byte[8];
            type = 1;
            len = 0;
            cmd = (byte)2;
            byte[] buffer = new byte[8];
            loadercan.StandardWrite(buffer, cmd, len, type);
            Thread.Sleep(50);
        }

     

        private void Test_taillight_Click(object sender, EventArgs e)
        {
            byte cmd;
            byte len;
            type = 3;
            len = 2;
            cmd = (byte)0;
            byte[] buffer = new byte[8];
            tx_buffer[0] = 0x01;
            tx_buffer[1] = 0xFF;
            loadercan.StandardWrite(buffer, cmd, len, type);
            Thread.Sleep(50);
        }

        private void Test_PCM_dischargecurrent_Click(object sender, EventArgs e)
        {
            byte cmd;
            byte len;
            type = 4;
            len = 8;
            cmd = (byte)4;
            byte[] buffer = new byte[8];
            tx_buffer[0] = 0xC6;
            tx_buffer[1] = 0x28;
            tx_buffer[2] = 0x88;
            tx_buffer[3] = 0xC1;
            tx_buffer[4] = 0x0D;
            tx_buffer[5] = 0x24;
            tx_buffer[6] = 0x46;
            tx_buffer[7] = 0xF2;
            loadercan.StandardWrite(buffer, cmd, len, type);
            Thread.Sleep(50);
        }
       

        private void Timer1_Tick(object sender, EventArgs e)
        {//112个参数要读取，

            if (CanRunning == false)
            {
                MessageBox.Show("请检查CAN！");
            }

            //byte cmd;
            //byte len;
            //byte[] tx_buffer = new byte[8];
            //byte[] SendCrcData = new byte[2];
            //type = 1;
            //len = 8;
            //cmd = (byte)3;

            //tx_buffer[0] = 0xAD;
            //tx_buffer[1] = 0xDE;
            //tx_buffer[2] = 0x23;
            //tx_buffer[3] = 0x13;
            //tx_buffer[4] = 0x02;
            //tx_buffer[5] = 0x00;

            //SendCrcData = CRC(tx_buffer, 6);
            ////tx_buffer[6] = 0xE2;
            ////tx_buffer[7] = 0x87;
            //tx_buffer[6] = SendCrcData[0];
            //tx_buffer[7] = SendCrcData[1];

            //loadercan.StandardWrite(tx_buffer, cmd, len, type);
            //Thread.Sleep(50);






        }












        private byte[] CRC(byte[] x, int len) //CRC校验函数
        {
            byte[] temdata = new byte[2];
            UInt16 crc = 0;
            byte da;
            int i = 0;
            UInt16[] yu = { 0x0000,0x1021,0x2042,0x3063,0x4084,0x50a5,0x60c6,0x70e7,
                            0x8108,0x9129,0xa14a,0xb16b,0xc18c,0xd1ad,0xe1ce,0xf1ef
                            };
            while (len-- != 0)
            {

                da = (byte)(((byte)(crc / 256)) / 16);
                crc <<= 4;
                crc ^= yu[da ^ x[i] / 16];
                da = (byte)(((byte)(crc / 256)) / 16);
                crc <<= 4;
                crc ^= yu[da ^ x[i] & 0x0f];
                i++;
            }
            temdata[0] = (byte)(crc & 0xFF);
            temdata[1] = (byte)(crc >> 8);
            return temdata;
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            STA_PRA_sended = false;

            //


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CanWriteClr = true;
            button1.ForeColor = Color.Gray;

       }

        private void Button2_Click(object sender, EventArgs e)
        {
            CanStopChg = true;
            button2.ForeColor = Color.Gray;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CanStartChg = true;
            button3.ForeColor = Color.Gray;
        }





        private void SAVE_DATA_CheckedChanged(object sender, EventArgs e)
        {

            if (SAVE_DATA.Checked == true)
            {
                SAVE_DATA.ForeColor = Color.Green;
                timer4.Enabled = true;
            }
            else
            {
                SAVE_DATA.ForeColor = Color.Black;
                timer4.Enabled = false;
            }

        }



        string name;
        private void Timer4_Tick(object sender, EventArgs e)
        {
            name = DateTime.Now.ToString("yyyy") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd") + "北京旷世机器人"  + ".xls";

            if (File.Exists(name))
            {

                Save();
            }
            else
            {
                CreatData();
                Save();
            }

        }


        public void CreatData()
        {
            FileStream fs = new FileStream(DateTime.Now.ToString("yyyy") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd") + "北京旷世机器人" +  ".xls", FileMode.Append, FileAccess.Write, FileShare.Write);
            fs.Close();
            String NextLine = "";
            StreamWriter sw = new StreamWriter(DateTime.Now.ToString("yyyy") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd") + "北京旷世机器人" + ".xls", true, Encoding.GetEncoding("GB2312"));

            NextLine = "保存时间" + '\t' + "电池总电压" + '\t' + "电池电流" + '\t' + "SOC" +'\t'+ "电池包容量" + '\t' + "充放电次数" + '\t' +
                       "CELL1" + '\t' + "CELL2" + '\t' + "CELL3"+ '\t' + "CELL4" + '\t' + "CELL5" + '\t' + "CELL6" + '\t' + "CELL7" + '\t' + 
                       "CELL8" + '\t' + "CELL9" + '\t' + "CELL10" + '\t' + "CELL11" + '\t' + "CELL12" + '\t' + "CELL13" + '\t' + "CELL14" + '\t' + "最高电压" + '\t' + "最低电压" + '\t' + "压差" + '\t' +
                       "TEMP1" + '\t' + "TEMP2"+ '\t' + "TEMP3" + '\t' + "TEMP4" + '\t' + "TEMP5" + '\t' + "TEMP6" + '\t' + "最高温度" + '\t' + "最低温度" + '\t' + "充电MOS温度" + '\t' + "放电MOS温度" + '\t' +
                       
                       "一级故障" + '\t' + "二级故障" + '\t' + "记录故障" + '\t' + "充电状态"
                       
                       + "\r\n";
                      
            sw.Write(NextLine);
            sw.Close();
        }

        public void Save()
        {
            StreamWriter sw = new StreamWriter(DateTime.Now.ToString("yyyy") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd") + "北京旷世机器人" +  ".xls", true, Encoding.GetEncoding("GB2312"));
            String NextLine = "";

            //NextLine = DateTime.Now.ToString("HH") + ":" + DateTime.Now.ToString("mm") + ":" + DateTime.Now.ToString("ss") + '\t'
            //+ disp.get_value(0x13) + '\t' + disp.get_value(0x17) + '\t' + disp.get_value(0x11) + '\t' + disp.get_value(0x12) + '\t'
            //+ disp.get_value(0x50) + '\t' + disp.get_value(0x51) + '\t' + disp.get_value(0x52) + '\t' + disp.get_value(0x53) + '\t'
            //+ disp.get_value(0x54) + '\t' + disp.get_value(0x58) + '\t' + disp.get_value(0x56) + '\t' + disp.get_value(0x57) + '\t'
            //+ disp.get_value(0x58) + '\t' + disp.get_value(0x59) + '\t' + disp.get_value(0x5A) + '\t' + disp.get_value(0x5B) + '\t'
            //+ disp.get_value(0x5C) + '\t' + disp.get_value(0x5D) + '\t' + disp.get_value(0x15) + '\t' + disp.get_value(0x16) + '\t'
            //+ disp.get_value(0x14) + '\t' + disp.get_value(0x90) + '\t' + disp.get_value(0x91) + '\t' + disp.get_value(0x92) + '\t'
            //+ disp.get_value(0x93) + '\t' + disp.get_value(0x94) + '\t' + disp.get_value(0x95) + '\t' + disp.get_value(0x1A) + '\t'
            //+ disp.get_value(0x1B) + '\t' + disp.get_value(0x18) + '\t' + disp.get_value(0x0A) + '\t' + disp.get_value(0x0B) + '\t'
            //+ disp.get_value(0x1D) + '\t' + disp.get_value(0x1E) + '\t' + disp.get_value(0x1F) + '\t' + disp.get_value(0x20) + '\t'
            //;

            NextLine = DateTime.Now.ToString("HH") + ":" + DateTime.Now.ToString("mm") + ":" + DateTime.Now.ToString("ss") + '\t'
                + voltage.Text + '\t' + current.Text + '\t' + soc.Text+ '\t' + BAT_Capacity.Text + '\t' + lifetimes.Text + '\t'
                + cell1.Text + '\t' + cell2.Text + '\t' + cell3.Text + '\t' + cell4.Text + '\t' + cell5.Text + '\t' + cell6.Text + '\t' 
                + cell7.Text + '\t' + cell8.Text + '\t' + cell9.Text + '\t' + cell10.Text + '\t' + cell11.Text + '\t' + cell12.Text + '\t' 
                + cell13.Text + '\t' + cell14.Text + '\t' + CELL_MAX_VOLTAGE.Text + '\t' + CELL_MIX_VOLTAGE.Text + '\t' + VDiff.Text + '\t' 
                + temp_1.Text + '\t' + temp_2.Text + '\t' + temp_3.Text + '\t' + temp_4.Text + '\t'+ temp_5.Text + '\t' + temp_6.Text + '\t' 
                + CELL_MAX_TEMP.Text + '\t' + CELL_MIN_TEMP.Text + '\t'  + CHG_temp_mosfet.Text + '\t' + DSC_temp_mosfet.Text + '\t'
                + disp.get_value(0x1D) + '\t' + disp.get_value(0x1E) + '\t' + disp.get_value(0x1F) + '\t' + disp.get_value(0x20) + '\t'
                ;

            sw.Write(NextLine);
            NextLine = "\r\n";
            sw.Write(NextLine);
            sw.Close();

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



        /// <summary>
        /// CRC数据验证
        /// </summary>
        /// <param name="bufout">信息串</param>
        /// <param name="count">接收数据总长度</param>
        /// <returns>true:校验成功,false:校验失败</returns>
        //public static bool DataCRC(ref byte[] bufout, byte count)
        //{
        //    ushort crc16 = 0;
        //    byte i;
        //    for (i = 0; i < (count - 2); i++)
        //        crc16 = xcrc(crc16, bufout[i]);

        //    if ((bufout[count - 2] == (byte)(crc16 >> 8)) && (bufout[count - 1] == (byte)(crc16 & 0xff)))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


    }
}



