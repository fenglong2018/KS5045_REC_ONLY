namespace KS5045上位机
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.SYSTEM = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenPortTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ClosePortTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ReseachTool = new System.Windows.Forms.ToolStripMenuItem();
            this.combps = new System.Windows.Forms.ToolStripComboBox();
            this.HelpTool = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMeTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitTool = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SysStatu = new System.Windows.Forms.ToolStripStatusLabel();
            this.CommStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.nulllabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sComm2 = new System.IO.Ports.SerialPort(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SAVE_DATA = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label95 = new System.Windows.Forms.Label();
            this.BAT_BMS_APP_SW_VER = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.BAT_BMS_UN_SW_VER = new System.Windows.Forms.Label();
            this.BAT_BMS_CP_VER = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.BAT_BMS_HW_VER = new System.Windows.Forms.Label();
            this.BAT_MAX_CHARGING_VOLTAGE = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.BAT_MIN_DISCHARGING_VOLTAGE = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.BAT_MAX_TEMP = new System.Windows.Forms.Label();
            this.BAT_RATED_CAPACITY = new System.Windows.Forms.Label();
            this.BAT_MAX_CHARGING_CURRENT = new System.Windows.Forms.Label();
            this.BAT_SUPPLIER = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.label125 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.BAT_RATED_CYCLE_INDEX = new System.Windows.Forms.Label();
            this.BAT_CELLS_NUM = new System.Windows.Forms.Label();
            this.BAT_TEMP_SENSOR_NUM = new System.Windows.Forms.Label();
            this.BAT_TYPE = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.BAT_MIN_TEMP = new System.Windows.Forms.Label();
            this.CHGSysStates = new System.Windows.Forms.TableLayoutPanel();
            this.SysCharging = new System.Windows.Forms.Label();
            this.SysHeating = new System.Windows.Forms.Label();
            this.SysStopHeating = new System.Windows.Forms.Label();
            this.SysOcc3A = new System.Windows.Forms.Label();
            this.SysHeatCharging = new System.Windows.Forms.Label();
            this.SysNoCharging = new System.Windows.Forms.Label();
            this.SecondWarning = new System.Windows.Forms.TableLayoutPanel();
            this.BqScd = new System.Windows.Forms.Label();
            this.BqUt = new System.Windows.Forms.Label();
            this.BqOv = new System.Windows.Forms.Label();
            this.BqUv = new System.Windows.Forms.Label();
            this.BqOt = new System.Windows.Forms.Label();
            this.BqOcc = new System.Windows.Forms.Label();
            this.BqOcd = new System.Windows.Forms.Label();
            this.BqUSoc = new System.Windows.Forms.Label();
            this.BqROc = new System.Windows.Forms.Label();
            this.BqImT = new System.Windows.Forms.Label();
            this.BqErr = new System.Windows.Forms.Label();
            this.BqVima = new System.Windows.Forms.Label();
            this.BqSUv = new System.Windows.Forms.Label();
            this.SecondStorage = new System.Windows.Forms.TableLayoutPanel();
            this.RecOv = new System.Windows.Forms.Label();
            this.RecUv = new System.Windows.Forms.Label();
            this.RecOcc = new System.Windows.Forms.Label();
            this.RecOcd = new System.Windows.Forms.Label();
            this.RecOt = new System.Windows.Forms.Label();
            this.RecUSoc = new System.Windows.Forms.Label();
            this.RecImT = new System.Windows.Forms.Label();
            this.RecROc = new System.Windows.Forms.Label();
            this.RecErr = new System.Windows.Forms.Label();
            this.RecScd = new System.Windows.Forms.Label();
            this.RecVima = new System.Windows.Forms.Label();
            this.RecUt = new System.Windows.Forms.Label();
            this.RecSUv = new System.Windows.Forms.Label();
            this.SoftWarning = new System.Windows.Forms.TableLayoutPanel();
            this.SoftUt = new System.Windows.Forms.Label();
            this.SoftOv = new System.Windows.Forms.Label();
            this.SoftUv = new System.Windows.Forms.Label();
            this.SoftOt = new System.Windows.Forms.Label();
            this.SoftOcc = new System.Windows.Forms.Label();
            this.softOcd = new System.Windows.Forms.Label();
            this.SoftUSoc = new System.Windows.Forms.Label();
            this.SoftROc = new System.Windows.Forms.Label();
            this.SoftVima = new System.Windows.Forms.Label();
            this.SoftImT = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CHG_temp_mosfet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lifetimes = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.CELL_MIX_VOLTAGE = new System.Windows.Forms.Label();
            this.CELL_MAX_VOLTAGE = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cell3 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cell4 = new System.Windows.Forms.Label();
            this.cell5 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.cell2 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.cell1 = new System.Windows.Forms.Label();
            this.soc = new System.Windows.Forms.Label();
            this.current = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cell13 = new System.Windows.Forms.Label();
            this.cell14 = new System.Windows.Forms.Label();
            this.cell6 = new System.Windows.Forms.Label();
            this.cell7 = new System.Windows.Forms.Label();
            this.cell8 = new System.Windows.Forms.Label();
            this.cell9 = new System.Windows.Forms.Label();
            this.cell10 = new System.Windows.Forms.Label();
            this.cell11 = new System.Windows.Forms.Label();
            this.cell12 = new System.Windows.Forms.Label();
            this.voltage = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.temp_1 = new System.Windows.Forms.Label();
            this.temp_2 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.temp_3 = new System.Windows.Forms.Label();
            this.temp_4 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.BAT_Capacity = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.VDiff = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.CELL_MAX_TEMP = new System.Windows.Forms.Label();
            this.CELL_MIN_TEMP = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.temp_5 = new System.Windows.Forms.Label();
            this.temp_6 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.envtemp = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.temp_mosfet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DSC_temp_mosfet = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Test_PCM_dischargecurrent = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.Test_taillight = new System.Windows.Forms.Button();
            this.label51 = new System.Windows.Forms.Label();
            this.label195 = new System.Windows.Forms.Label();
            this.label194 = new System.Windows.Forms.Label();
            this.label193 = new System.Windows.Forms.Label();
            this.label192 = new System.Windows.Forms.Label();
            this.label191 = new System.Windows.Forms.Label();
            this.label190 = new System.Windows.Forms.Label();
            this.label189 = new System.Windows.Forms.Label();
            this.label188 = new System.Windows.Forms.Label();
            this.label187 = new System.Windows.Forms.Label();
            this.label186 = new System.Windows.Forms.Label();
            this.label185 = new System.Windows.Forms.Label();
            this.label184 = new System.Windows.Forms.Label();
            this.label183 = new System.Windows.Forms.Label();
            this.label182 = new System.Windows.Forms.Label();
            this.label181 = new System.Windows.Forms.Label();
            this.label180 = new System.Windows.Forms.Label();
            this.label179 = new System.Windows.Forms.Label();
            this.label178 = new System.Windows.Forms.Label();
            this.label177 = new System.Windows.Forms.Label();
            this.label176 = new System.Windows.Forms.Label();
            this.label175 = new System.Windows.Forms.Label();
            this.label174 = new System.Windows.Forms.Label();
            this.label173 = new System.Windows.Forms.Label();
            this.label172 = new System.Windows.Forms.Label();
            this.label171 = new System.Windows.Forms.Label();
            this.label170 = new System.Windows.Forms.Label();
            this.label169 = new System.Windows.Forms.Label();
            this.label168 = new System.Windows.Forms.Label();
            this.label167 = new System.Windows.Forms.Label();
            this.label166 = new System.Windows.Forms.Label();
            this.label165 = new System.Windows.Forms.Label();
            this.label164 = new System.Windows.Forms.Label();
            this.label163 = new System.Windows.Forms.Label();
            this.label162 = new System.Windows.Forms.Label();
            this.label161 = new System.Windows.Forms.Label();
            this.label160 = new System.Windows.Forms.Label();
            this.label159 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.label157 = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.label155 = new System.Windows.Forms.Label();
            this.label154 = new System.Windows.Forms.Label();
            this.label153 = new System.Windows.Forms.Label();
            this.label152 = new System.Windows.Forms.Label();
            this.label151 = new System.Windows.Forms.Label();
            this.label150 = new System.Windows.Forms.Label();
            this.label149 = new System.Windows.Forms.Label();
            this.label148 = new System.Windows.Forms.Label();
            this.label147 = new System.Windows.Forms.Label();
            this.label146 = new System.Windows.Forms.Label();
            this.label145 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.label141 = new System.Windows.Forms.Label();
            this.label140 = new System.Windows.Forms.Label();
            this.label139 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.label137 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.label135 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label269 = new System.Windows.Forms.Label();
            this.label268 = new System.Windows.Forms.Label();
            this.label267 = new System.Windows.Forms.Label();
            this.label266 = new System.Windows.Forms.Label();
            this.label265 = new System.Windows.Forms.Label();
            this.label264 = new System.Windows.Forms.Label();
            this.label263 = new System.Windows.Forms.Label();
            this.label262 = new System.Windows.Forms.Label();
            this.label261 = new System.Windows.Forms.Label();
            this.label260 = new System.Windows.Forms.Label();
            this.label259 = new System.Windows.Forms.Label();
            this.label258 = new System.Windows.Forms.Label();
            this.label257 = new System.Windows.Forms.Label();
            this.label256 = new System.Windows.Forms.Label();
            this.label255 = new System.Windows.Forms.Label();
            this.label254 = new System.Windows.Forms.Label();
            this.label253 = new System.Windows.Forms.Label();
            this.label252 = new System.Windows.Forms.Label();
            this.label251 = new System.Windows.Forms.Label();
            this.label250 = new System.Windows.Forms.Label();
            this.label249 = new System.Windows.Forms.Label();
            this.label248 = new System.Windows.Forms.Label();
            this.label247 = new System.Windows.Forms.Label();
            this.label246 = new System.Windows.Forms.Label();
            this.label245 = new System.Windows.Forms.Label();
            this.label244 = new System.Windows.Forms.Label();
            this.label243 = new System.Windows.Forms.Label();
            this.label242 = new System.Windows.Forms.Label();
            this.label241 = new System.Windows.Forms.Label();
            this.label240 = new System.Windows.Forms.Label();
            this.label239 = new System.Windows.Forms.Label();
            this.label238 = new System.Windows.Forms.Label();
            this.label237 = new System.Windows.Forms.Label();
            this.label236 = new System.Windows.Forms.Label();
            this.label235 = new System.Windows.Forms.Label();
            this.label234 = new System.Windows.Forms.Label();
            this.label233 = new System.Windows.Forms.Label();
            this.label232 = new System.Windows.Forms.Label();
            this.label231 = new System.Windows.Forms.Label();
            this.label230 = new System.Windows.Forms.Label();
            this.label229 = new System.Windows.Forms.Label();
            this.label228 = new System.Windows.Forms.Label();
            this.label227 = new System.Windows.Forms.Label();
            this.label226 = new System.Windows.Forms.Label();
            this.label225 = new System.Windows.Forms.Label();
            this.label224 = new System.Windows.Forms.Label();
            this.label223 = new System.Windows.Forms.Label();
            this.label222 = new System.Windows.Forms.Label();
            this.label221 = new System.Windows.Forms.Label();
            this.label220 = new System.Windows.Forms.Label();
            this.label219 = new System.Windows.Forms.Label();
            this.label218 = new System.Windows.Forms.Label();
            this.label217 = new System.Windows.Forms.Label();
            this.label216 = new System.Windows.Forms.Label();
            this.label215 = new System.Windows.Forms.Label();
            this.label214 = new System.Windows.Forms.Label();
            this.label213 = new System.Windows.Forms.Label();
            this.label212 = new System.Windows.Forms.Label();
            this.label211 = new System.Windows.Forms.Label();
            this.label210 = new System.Windows.Forms.Label();
            this.label209 = new System.Windows.Forms.Label();
            this.label208 = new System.Windows.Forms.Label();
            this.label207 = new System.Windows.Forms.Label();
            this.label206 = new System.Windows.Forms.Label();
            this.label205 = new System.Windows.Forms.Label();
            this.label204 = new System.Windows.Forms.Label();
            this.label203 = new System.Windows.Forms.Label();
            this.label202 = new System.Windows.Forms.Label();
            this.label201 = new System.Windows.Forms.Label();
            this.label200 = new System.Windows.Forms.Label();
            this.label199 = new System.Windows.Forms.Label();
            this.label198 = new System.Windows.Forms.Label();
            this.label197 = new System.Windows.Forms.Label();
            this.label196 = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.msMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.CHGSysStates.SuspendLayout();
            this.SecondWarning.SuspendLayout();
            this.SecondStorage.SuspendLayout();
            this.SoftWarning.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer3
            // 
            this.timer3.Interval = 8000;
            this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.SystemColors.Control;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SYSTEM,
            this.combps,
            this.HelpTool});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(9, 1, 0, 1);
            this.msMenu.Size = new System.Drawing.Size(1032, 27);
            this.msMenu.TabIndex = 8;
            this.msMenu.Text = "menuStrip1";
            // 
            // SYSTEM
            // 
            this.SYSTEM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenPortTool,
            this.ClosePortTool,
            this.ReseachTool});
            this.SYSTEM.Name = "SYSTEM";
            this.SYSTEM.Size = new System.Drawing.Size(82, 25);
            this.SYSTEM.Text = "CAN卡操作";
            // 
            // OpenPortTool
            // 
            this.OpenPortTool.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OpenPortTool.Name = "OpenPortTool";
            this.OpenPortTool.Size = new System.Drawing.Size(180, 22);
            this.OpenPortTool.Text = "Open[&O]";
            this.OpenPortTool.Click += new System.EventHandler(this.OpenPortTool_Click);
            // 
            // ClosePortTool
            // 
            this.ClosePortTool.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClosePortTool.Name = "ClosePortTool";
            this.ClosePortTool.Size = new System.Drawing.Size(180, 22);
            this.ClosePortTool.Text = "Close[&C]";
            this.ClosePortTool.Click += new System.EventHandler(this.ClosePortTool_Click);
            // 
            // ReseachTool
            // 
            this.ReseachTool.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ReseachTool.Name = "ReseachTool";
            this.ReseachTool.Size = new System.Drawing.Size(180, 22);
            this.ReseachTool.Text = "Research[&R]";
            // 
            // combps
            // 
            this.combps.BackColor = System.Drawing.SystemColors.Control;
            this.combps.Items.AddRange(new object[] {
            "125k bps",
            "250k bps",
            "500k bps",
            "1M bps"});
            this.combps.Name = "combps";
            this.combps.Size = new System.Drawing.Size(133, 25);
            this.combps.Text = "250k bps";
            // 
            // HelpTool
            // 
            this.HelpTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMeTool,
            this.ExitTool});
            this.HelpTool.Name = "HelpTool";
            this.HelpTool.Size = new System.Drawing.Size(64, 25);
            this.HelpTool.Text = "Help[&H]";
            // 
            // AboutMeTool
            // 
            this.AboutMeTool.Name = "AboutMeTool";
            this.AboutMeTool.Size = new System.Drawing.Size(111, 22);
            // 
            // ExitTool
            // 
            this.ExitTool.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExitTool.Name = "ExitTool";
            this.ExitTool.Size = new System.Drawing.Size(111, 22);
            this.ExitTool.Text = "Exit[&E]";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SysStatu,
            this.CommStatus,
            this.tsslDate,
            this.nulllabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 754);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1032, 22);
            this.statusStrip1.TabIndex = 74;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SysStatu
            // 
            this.SysStatu.Name = "SysStatu";
            this.SysStatu.Size = new System.Drawing.Size(0, 17);
            // 
            // CommStatus
            // 
            this.CommStatus.Name = "CommStatus";
            this.CommStatus.Size = new System.Drawing.Size(11, 17);
            this.CommStatus.Text = "|";
            // 
            // tsslDate
            // 
            this.tsslDate.Name = "tsslDate";
            this.tsslDate.Size = new System.Drawing.Size(0, 17);
            // 
            // nulllabel
            // 
            this.nulllabel.Name = "nulllabel";
            this.nulllabel.Size = new System.Drawing.Size(404, 17);
            this.nulllabel.Text = "                                                                                 " +
    "                  ";
            // 
            // sComm2
            // 
            this.sComm2.ParityReplace = ((byte)(0));
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.SAVE_DATA);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.tableLayoutPanel8);
            this.tabPage1.Controls.Add(this.CHGSysStates);
            this.tabPage1.Controls.Add(this.SecondWarning);
            this.tabPage1.Controls.Add(this.SecondStorage);
            this.tabPage1.Controls.Add(this.SoftWarning);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1012, 671);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "电池信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.checkBox1.Location = new System.Drawing.Point(829, 557);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 24);
            this.checkBox1.TabIndex = 141;
            this.checkBox1.Text = "保存定值数据";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SAVE_DATA
            // 
            this.SAVE_DATA.AutoSize = true;
            this.SAVE_DATA.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.SAVE_DATA.Location = new System.Drawing.Point(829, 515);
            this.SAVE_DATA.Name = "SAVE_DATA";
            this.SAVE_DATA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SAVE_DATA.Size = new System.Drawing.Size(112, 24);
            this.SAVE_DATA.TabIndex = 140;
            this.SAVE_DATA.Text = "保存实时数据";
            this.SAVE_DATA.UseVisualStyleBackColor = true;
            this.SAVE_DATA.CheckedChanged += new System.EventHandler(this.SAVE_DATA_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 139;
            this.label6.Text = "记录故障";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 138;
            this.label5.Text = "二级故障";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 137;
            this.label4.Text = "一级故障";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(829, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 41);
            this.button3.TabIndex = 136;
            this.button3.Text = "开启充电";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(829, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 38);
            this.button2.TabIndex = 136;
            this.button2.Text = "停止充电";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(829, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 49);
            this.button1.TabIndex = 135;
            this.button1.Text = "清除故障记录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel8.ColumnCount = 6;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.2F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.8F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel8.Controls.Add(this.label95, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.BAT_BMS_APP_SW_VER, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.label100, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.label101, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.label102, 2, 3);
            this.tableLayoutPanel8.Controls.Add(this.BAT_BMS_UN_SW_VER, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.BAT_BMS_CP_VER, 1, 4);
            this.tableLayoutPanel8.Controls.Add(this.label105, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.label108, 2, 4);
            this.tableLayoutPanel8.Controls.Add(this.label111, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.BAT_BMS_HW_VER, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.BAT_MAX_CHARGING_VOLTAGE, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.label114, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.label115, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.BAT_MIN_DISCHARGING_VOLTAGE, 3, 1);
            this.tableLayoutPanel8.Controls.Add(this.label118, 2, 2);
            this.tableLayoutPanel8.Controls.Add(this.BAT_MAX_TEMP, 3, 4);
            this.tableLayoutPanel8.Controls.Add(this.BAT_RATED_CAPACITY, 3, 3);
            this.tableLayoutPanel8.Controls.Add(this.BAT_MAX_CHARGING_CURRENT, 3, 2);
            this.tableLayoutPanel8.Controls.Add(this.BAT_SUPPLIER, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label123, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.label124, 4, 1);
            this.tableLayoutPanel8.Controls.Add(this.label125, 4, 2);
            this.tableLayoutPanel8.Controls.Add(this.label126, 4, 3);
            this.tableLayoutPanel8.Controls.Add(this.BAT_RATED_CYCLE_INDEX, 5, 0);
            this.tableLayoutPanel8.Controls.Add(this.BAT_CELLS_NUM, 5, 1);
            this.tableLayoutPanel8.Controls.Add(this.BAT_TEMP_SENSOR_NUM, 5, 2);
            this.tableLayoutPanel8.Controls.Add(this.BAT_TYPE, 5, 3);
            this.tableLayoutPanel8.Controls.Add(this.label132, 2, 5);
            this.tableLayoutPanel8.Controls.Add(this.BAT_MIN_TEMP, 3, 5);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(34, 515);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 6;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(762, 156);
            this.tableLayoutPanel8.TabIndex = 134;
            // 
            // label95
            // 
            this.label95.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label95.Location = new System.Drawing.Point(38, 6);
            this.label95.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(56, 17);
            this.label95.TabIndex = 115;
            this.label95.Text = "电池厂家";
            // 
            // BAT_BMS_APP_SW_VER
            // 
            this.BAT_BMS_APP_SW_VER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BAT_BMS_APP_SW_VER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAT_BMS_APP_SW_VER.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BAT_BMS_APP_SW_VER.Location = new System.Drawing.Point(150, 56);
            this.BAT_BMS_APP_SW_VER.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BAT_BMS_APP_SW_VER.Name = "BAT_BMS_APP_SW_VER";
            this.BAT_BMS_APP_SW_VER.Size = new System.Drawing.Size(72, 21);
            this.BAT_BMS_APP_SW_VER.TabIndex = 131;
            this.BAT_BMS_APP_SW_VER.Text = "N";
            this.BAT_BMS_APP_SW_VER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label100
            // 
            this.label100.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label100.Location = new System.Drawing.Point(7, 58);
            this.label100.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(119, 17);
            this.label100.TabIndex = 132;
            this.label100.Text = "BMS应用软件版本号";
            // 
            // label101
            // 
            this.label101.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label101.Location = new System.Drawing.Point(7, 84);
            this.label101.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(119, 17);
            this.label101.TabIndex = 144;
            this.label101.Text = "BMS引导软件版本号";
            // 
            // label102
            // 
            this.label102.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label102.AutoSize = true;
            this.label102.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label102.Location = new System.Drawing.Point(281, 84);
            this.label102.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(89, 17);
            this.label102.TabIndex = 145;
            this.label102.Text = "额定容量(0.1A)";
            // 
            // BAT_BMS_UN_SW_VER
            // 
            this.BAT_BMS_UN_SW_VER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BAT_BMS_UN_SW_VER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAT_BMS_UN_SW_VER.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BAT_BMS_UN_SW_VER.Location = new System.Drawing.Point(150, 82);
            this.BAT_BMS_UN_SW_VER.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BAT_BMS_UN_SW_VER.Name = "BAT_BMS_UN_SW_VER";
            this.BAT_BMS_UN_SW_VER.Size = new System.Drawing.Size(72, 21);
            this.BAT_BMS_UN_SW_VER.TabIndex = 147;
            this.BAT_BMS_UN_SW_VER.Text = "N";
            this.BAT_BMS_UN_SW_VER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BAT_BMS_CP_VER
            // 
            this.BAT_BMS_CP_VER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BAT_BMS_CP_VER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAT_BMS_CP_VER.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BAT_BMS_CP_VER.Location = new System.Drawing.Point(150, 108);
            this.BAT_BMS_CP_VER.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BAT_BMS_CP_VER.Name = "BAT_BMS_CP_VER";
            this.BAT_BMS_CP_VER.Size = new System.Drawing.Size(72, 21);
            this.BAT_BMS_CP_VER.TabIndex = 162;
            this.BAT_BMS_CP_VER.Text = "N";
            this.BAT_BMS_CP_VER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label105
            // 
            this.label105.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label105.AutoSize = true;
            this.label105.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label105.Location = new System.Drawing.Point(19, 110);
            this.label105.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(95, 17);
            this.label105.TabIndex = 158;
            this.label105.Text = "BMS协议版本号";
            // 
            // label108
            // 
            this.label108.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label108.AutoSize = true;
            this.label108.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label108.Location = new System.Drawing.Point(285, 110);
            this.label108.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(80, 17);
            this.label108.TabIndex = 165;
            this.label108.Text = "允许最高温度";
            // 
            // label111
            // 
            this.label111.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label111.Location = new System.Drawing.Point(19, 32);
            this.label111.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(95, 17);
            this.label111.TabIndex = 126;
            this.label111.Text = "BMS硬件版本号";
            // 
            // BAT_BMS_HW_VER
            // 
            this.BAT_BMS_HW_VER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BAT_BMS_HW_VER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAT_BMS_HW_VER.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BAT_BMS_HW_VER.Location = new System.Drawing.Point(150, 30);
            this.BAT_BMS_HW_VER.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BAT_BMS_HW_VER.Name = "BAT_BMS_HW_VER";
            this.BAT_BMS_HW_VER.Size = new System.Drawing.Size(72, 21);
            this.BAT_BMS_HW_VER.TabIndex = 148;
            this.BAT_BMS_HW_VER.Text = "N";
            this.BAT_BMS_HW_VER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BAT_MAX_CHARGING_VOLTAGE
            // 
            this.BAT_MAX_CHARGING_VOLTAGE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BAT_MAX_CHARGING_VOLTAGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAT_MAX_CHARGING_VOLTAGE.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BAT_MAX_CHARGING_VOLTAGE.Location = new System.Drawing.Point(429, 4);
            this.BAT_MAX_CHARGING_VOLTAGE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BAT_MAX_CHARGING_VOLTAGE.Name = "BAT_MAX_CHARGING_VOLTAGE";
            this.BAT_MAX_CHARGING_VOLTAGE.Size = new System.Drawing.Size(70, 21);
            this.BAT_MAX_CHARGING_VOLTAGE.TabIndex = 129;
            this.BAT_MAX_CHARGING_VOLTAGE.Text = "N";
            this.BAT_MAX_CHARGING_VOLTAGE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label114
            // 
            this.label114.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label114.AutoSize = true;
            this.label114.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label114.Location = new System.Drawing.Point(252, 32);
            this.label114.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(147, 17);
            this.label114.TabIndex = 135;
            this.label114.Text = "SOC10%对应电压(10mV)";
            this.label114.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label115
            // 
            this.label115.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label115.AutoSize = true;
            this.label115.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label115.Location = new System.Drawing.Point(247, 6);
            this.label115.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(157, 17);
            this.label115.TabIndex = 134;
            this.label115.Text = "电池包充电限制电压(10mV)";
            // 
            // BAT_MIN_DISCHARGING_VOLTAGE
            // 
            this.BAT_MIN_DISCHARGING_VOLTAGE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BAT_MIN_DISCHARGING_VOLTAGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAT_MIN_DISCHARGING_VOLTAGE.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BAT_MIN_DISCHARGING_VOLTAGE.Location = new System.Drawing.Point(428, 30);
            this.BAT_MIN_DISCHARGING_VOLTAGE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BAT_MIN_DISCHARGING_VOLTAGE.Name = "BAT_MIN_DISCHARGING_VOLTAGE";
            this.BAT_MIN_DISCHARGING_VOLTAGE.Size = new System.Drawing.Size(71, 21);
            this.BAT_MIN_DISCHARGING_VOLTAGE.TabIndex = 154;
            this.BAT_MIN_DISCHARGING_VOLTAGE.Text = "N";
            this.BAT_MIN_DISCHARGING_VOLTAGE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label118
            // 
            this.label118.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label118.AutoSize = true;
            this.label118.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label118.Location = new System.Drawing.Point(257, 58);
            this.label118.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(137, 17);
            this.label118.TabIndex = 137;
            this.label118.Text = "加热充电限制电流(0.1A)";
            // 
            // BAT_MAX_TEMP
            // 
            this.BAT_MAX_TEMP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BAT_MAX_TEMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAT_MAX_TEMP.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BAT_MAX_TEMP.Location = new System.Drawing.Point(428, 108);
            this.BAT_MAX_TEMP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BAT_MAX_TEMP.Name = "BAT_MAX_TEMP";
            this.BAT_MAX_TEMP.Size = new System.Drawing.Size(71, 21);
            this.BAT_MAX_TEMP.TabIndex = 143;
            this.BAT_MAX_TEMP.Text = "N";
            this.BAT_MAX_TEMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BAT_RATED_CAPACITY
            // 
            this.BAT_RATED_CAPACITY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BAT_RATED_CAPACITY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAT_RATED_CAPACITY.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BAT_RATED_CAPACITY.Location = new System.Drawing.Point(428, 82);
            this.BAT_RATED_CAPACITY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BAT_RATED_CAPACITY.Name = "BAT_RATED_CAPACITY";
            this.BAT_RATED_CAPACITY.Size = new System.Drawing.Size(71, 21);
            this.BAT_RATED_CAPACITY.TabIndex = 153;
            this.BAT_RATED_CAPACITY.Text = "N";
            this.BAT_RATED_CAPACITY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BAT_MAX_CHARGING_CURRENT
            // 
            this.BAT_MAX_CHARGING_CURRENT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BAT_MAX_CHARGING_CURRENT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAT_MAX_CHARGING_CURRENT.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BAT_MAX_CHARGING_CURRENT.Location = new System.Drawing.Point(428, 56);
            this.BAT_MAX_CHARGING_CURRENT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BAT_MAX_CHARGING_CURRENT.Name = "BAT_MAX_CHARGING_CURRENT";
            this.BAT_MAX_CHARGING_CURRENT.Size = new System.Drawing.Size(71, 21);
            this.BAT_MAX_CHARGING_CURRENT.TabIndex = 155;
            this.BAT_MAX_CHARGING_CURRENT.Text = "N";
            this.BAT_MAX_CHARGING_CURRENT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BAT_SUPPLIER
            // 
            this.BAT_SUPPLIER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BAT_SUPPLIER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAT_SUPPLIER.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BAT_SUPPLIER.Location = new System.Drawing.Point(150, 4);
            this.BAT_SUPPLIER.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BAT_SUPPLIER.Name = "BAT_SUPPLIER";
            this.BAT_SUPPLIER.Size = new System.Drawing.Size(72, 21);
            this.BAT_SUPPLIER.TabIndex = 125;
            this.BAT_SUPPLIER.Text = "N";
            this.BAT_SUPPLIER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label123
            // 
            this.label123.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label123.AutoSize = true;
            this.label123.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label123.Location = new System.Drawing.Point(536, 6);
            this.label123.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(92, 17);
            this.label123.TabIndex = 134;
            this.label123.Text = "额定充放电次数";
            // 
            // label124
            // 
            this.label124.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label124.AutoSize = true;
            this.label124.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label124.Location = new System.Drawing.Point(560, 32);
            this.label124.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(44, 17);
            this.label124.TabIndex = 134;
            this.label124.Text = "电芯数";
            // 
            // label125
            // 
            this.label125.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label125.AutoSize = true;
            this.label125.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label125.Location = new System.Drawing.Point(524, 58);
            this.label125.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(116, 17);
            this.label125.TabIndex = 134;
            this.label125.Text = "电芯温度传感器个数";
            // 
            // label126
            // 
            this.label126.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label126.AutoSize = true;
            this.label126.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label126.Location = new System.Drawing.Point(548, 84);
            this.label126.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(68, 17);
            this.label126.TabIndex = 134;
            this.label126.Text = "电池包类型";
            // 
            // BAT_RATED_CYCLE_INDEX
            // 
            this.BAT_RATED_CYCLE_INDEX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BAT_RATED_CYCLE_INDEX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAT_RATED_CYCLE_INDEX.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BAT_RATED_CYCLE_INDEX.Location = new System.Drawing.Point(666, 4);
            this.BAT_RATED_CYCLE_INDEX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BAT_RATED_CYCLE_INDEX.Name = "BAT_RATED_CYCLE_INDEX";
            this.BAT_RATED_CYCLE_INDEX.Size = new System.Drawing.Size(74, 21);
            this.BAT_RATED_CYCLE_INDEX.TabIndex = 129;
            this.BAT_RATED_CYCLE_INDEX.Text = "N";
            this.BAT_RATED_CYCLE_INDEX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BAT_CELLS_NUM
            // 
            this.BAT_CELLS_NUM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BAT_CELLS_NUM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAT_CELLS_NUM.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BAT_CELLS_NUM.Location = new System.Drawing.Point(666, 30);
            this.BAT_CELLS_NUM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BAT_CELLS_NUM.Name = "BAT_CELLS_NUM";
            this.BAT_CELLS_NUM.Size = new System.Drawing.Size(74, 21);
            this.BAT_CELLS_NUM.TabIndex = 129;
            this.BAT_CELLS_NUM.Text = "N";
            this.BAT_CELLS_NUM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BAT_TEMP_SENSOR_NUM
            // 
            this.BAT_TEMP_SENSOR_NUM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BAT_TEMP_SENSOR_NUM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAT_TEMP_SENSOR_NUM.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BAT_TEMP_SENSOR_NUM.Location = new System.Drawing.Point(666, 56);
            this.BAT_TEMP_SENSOR_NUM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BAT_TEMP_SENSOR_NUM.Name = "BAT_TEMP_SENSOR_NUM";
            this.BAT_TEMP_SENSOR_NUM.Size = new System.Drawing.Size(74, 21);
            this.BAT_TEMP_SENSOR_NUM.TabIndex = 129;
            this.BAT_TEMP_SENSOR_NUM.Text = "N";
            this.BAT_TEMP_SENSOR_NUM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BAT_TYPE
            // 
            this.BAT_TYPE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BAT_TYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAT_TYPE.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BAT_TYPE.Location = new System.Drawing.Point(666, 82);
            this.BAT_TYPE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BAT_TYPE.Name = "BAT_TYPE";
            this.BAT_TYPE.Size = new System.Drawing.Size(74, 21);
            this.BAT_TYPE.TabIndex = 129;
            this.BAT_TYPE.Text = "N";
            this.BAT_TYPE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label132
            // 
            this.label132.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label132.AutoSize = true;
            this.label132.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label132.Location = new System.Drawing.Point(285, 134);
            this.label132.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(80, 17);
            this.label132.TabIndex = 158;
            this.label132.Text = "允许最低温度";
            // 
            // BAT_MIN_TEMP
            // 
            this.BAT_MIN_TEMP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BAT_MIN_TEMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAT_MIN_TEMP.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BAT_MIN_TEMP.Location = new System.Drawing.Point(428, 133);
            this.BAT_MIN_TEMP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BAT_MIN_TEMP.Name = "BAT_MIN_TEMP";
            this.BAT_MIN_TEMP.Size = new System.Drawing.Size(71, 20);
            this.BAT_MIN_TEMP.TabIndex = 162;
            this.BAT_MIN_TEMP.Text = "N";
            this.BAT_MIN_TEMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CHGSysStates
            // 
            this.CHGSysStates.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.CHGSysStates.ColumnCount = 3;
            this.CHGSysStates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CHGSysStates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CHGSysStates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CHGSysStates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CHGSysStates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CHGSysStates.Controls.Add(this.SysCharging, 0, 0);
            this.CHGSysStates.Controls.Add(this.SysHeating, 0, 1);
            this.CHGSysStates.Controls.Add(this.SysStopHeating, 1, 1);
            this.CHGSysStates.Controls.Add(this.SysOcc3A, 2, 1);
            this.CHGSysStates.Controls.Add(this.SysHeatCharging, 2, 0);
            this.CHGSysStates.Controls.Add(this.SysNoCharging, 1, 0);
            this.CHGSysStates.Location = new System.Drawing.Point(431, 374);
            this.CHGSysStates.Margin = new System.Windows.Forms.Padding(4);
            this.CHGSysStates.Name = "CHGSysStates";
            this.CHGSysStates.RowCount = 2;
            this.CHGSysStates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CHGSysStates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CHGSysStates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CHGSysStates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CHGSysStates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CHGSysStates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CHGSysStates.Size = new System.Drawing.Size(365, 110);
            this.CHGSysStates.TabIndex = 132;
            // 
            // SysCharging
            // 
            this.SysCharging.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SysCharging.AutoSize = true;
            this.SysCharging.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SysCharging.ForeColor = System.Drawing.Color.Green;
            this.SysCharging.Location = new System.Drawing.Point(33, 19);
            this.SysCharging.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SysCharging.Name = "SysCharging";
            this.SysCharging.Size = new System.Drawing.Size(56, 17);
            this.SysCharging.TabIndex = 115;
            this.SysCharging.Text = "充电状态";
            // 
            // SysHeating
            // 
            this.SysHeating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SysHeating.AutoSize = true;
            this.SysHeating.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SysHeating.ForeColor = System.Drawing.Color.Green;
            this.SysHeating.Location = new System.Drawing.Point(33, 73);
            this.SysHeating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SysHeating.Name = "SysHeating";
            this.SysHeating.Size = new System.Drawing.Size(56, 17);
            this.SysHeating.TabIndex = 126;
            this.SysHeating.Text = "加热状态";
            // 
            // SysStopHeating
            // 
            this.SysStopHeating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SysStopHeating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SysStopHeating.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SysStopHeating.ForeColor = System.Drawing.Color.Green;
            this.SysStopHeating.Location = new System.Drawing.Point(145, 71);
            this.SysStopHeating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SysStopHeating.Name = "SysStopHeating";
            this.SysStopHeating.Size = new System.Drawing.Size(72, 21);
            this.SysStopHeating.TabIndex = 148;
            this.SysStopHeating.Text = "停止加热状态";
            this.SysStopHeating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SysOcc3A
            // 
            this.SysOcc3A.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SysOcc3A.AutoSize = true;
            this.SysOcc3A.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SysOcc3A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SysOcc3A.Location = new System.Drawing.Point(255, 73);
            this.SysOcc3A.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SysOcc3A.Name = "SysOcc3A";
            this.SysOcc3A.Size = new System.Drawing.Size(95, 17);
            this.SysOcc3A.TabIndex = 135;
            this.SysOcc3A.Text = "充电电流超出3A";
            this.SysOcc3A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SysHeatCharging
            // 
            this.SysHeatCharging.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SysHeatCharging.AutoSize = true;
            this.SysHeatCharging.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SysHeatCharging.ForeColor = System.Drawing.Color.Green;
            this.SysHeatCharging.Location = new System.Drawing.Point(262, 19);
            this.SysHeatCharging.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SysHeatCharging.Name = "SysHeatCharging";
            this.SysHeatCharging.Size = new System.Drawing.Size(80, 17);
            this.SysHeatCharging.TabIndex = 134;
            this.SysHeatCharging.Text = "边充电边加热";
            // 
            // SysNoCharging
            // 
            this.SysNoCharging.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SysNoCharging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SysNoCharging.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SysNoCharging.ForeColor = System.Drawing.Color.Green;
            this.SysNoCharging.Location = new System.Drawing.Point(145, 17);
            this.SysNoCharging.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SysNoCharging.Name = "SysNoCharging";
            this.SysNoCharging.Size = new System.Drawing.Size(72, 21);
            this.SysNoCharging.TabIndex = 125;
            this.SysNoCharging.Text = "非充电状态";
            this.SysNoCharging.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondWarning
            // 
            this.SecondWarning.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.SecondWarning.ColumnCount = 4;
            this.SecondWarning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondWarning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondWarning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondWarning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondWarning.Controls.Add(this.BqScd, 3, 0);
            this.SecondWarning.Controls.Add(this.BqUt, 0, 3);
            this.SecondWarning.Controls.Add(this.BqOv, 0, 0);
            this.SecondWarning.Controls.Add(this.BqUv, 0, 1);
            this.SecondWarning.Controls.Add(this.BqOt, 0, 2);
            this.SecondWarning.Controls.Add(this.BqOcc, 1, 0);
            this.SecondWarning.Controls.Add(this.BqOcd, 1, 1);
            this.SecondWarning.Controls.Add(this.BqUSoc, 1, 2);
            this.SecondWarning.Controls.Add(this.BqROc, 2, 1);
            this.SecondWarning.Controls.Add(this.BqImT, 2, 0);
            this.SecondWarning.Controls.Add(this.BqErr, 2, 2);
            this.SecondWarning.Controls.Add(this.BqVima, 1, 3);
            this.SecondWarning.Controls.Add(this.BqSUv, 2, 3);
            this.SecondWarning.Location = new System.Drawing.Point(34, 377);
            this.SecondWarning.Name = "SecondWarning";
            this.SecondWarning.RowCount = 4;
            this.SecondWarning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondWarning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondWarning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondWarning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondWarning.Size = new System.Drawing.Size(365, 110);
            this.SecondWarning.TabIndex = 131;
            // 
            // BqScd
            // 
            this.BqScd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BqScd.AutoSize = true;
            this.BqScd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BqScd.ForeColor = System.Drawing.Color.Red;
            this.BqScd.Location = new System.Drawing.Point(289, 6);
            this.BqScd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BqScd.Name = "BqScd";
            this.BqScd.Size = new System.Drawing.Size(56, 17);
            this.BqScd.TabIndex = 182;
            this.BqScd.Text = "短路保护";
            // 
            // BqUt
            // 
            this.BqUt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BqUt.AutoSize = true;
            this.BqUt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BqUt.ForeColor = System.Drawing.Color.Red;
            this.BqUt.Location = new System.Drawing.Point(30, 85);
            this.BqUt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BqUt.Name = "BqUt";
            this.BqUt.Size = new System.Drawing.Size(32, 17);
            this.BqUt.TabIndex = 179;
            this.BqUt.Text = "欠温";
            // 
            // BqOv
            // 
            this.BqOv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BqOv.AutoSize = true;
            this.BqOv.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BqOv.ForeColor = System.Drawing.Color.Red;
            this.BqOv.Location = new System.Drawing.Point(18, 6);
            this.BqOv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BqOv.Name = "BqOv";
            this.BqOv.Size = new System.Drawing.Size(56, 17);
            this.BqOv.TabIndex = 168;
            this.BqOv.Text = "充电过压";
            // 
            // BqUv
            // 
            this.BqUv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BqUv.AutoSize = true;
            this.BqUv.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BqUv.ForeColor = System.Drawing.Color.Red;
            this.BqUv.Location = new System.Drawing.Point(18, 32);
            this.BqUv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BqUv.Name = "BqUv";
            this.BqUv.Size = new System.Drawing.Size(56, 17);
            this.BqUv.TabIndex = 169;
            this.BqUv.Text = "放电欠压";
            // 
            // BqOt
            // 
            this.BqOt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BqOt.AutoSize = true;
            this.BqOt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BqOt.ForeColor = System.Drawing.Color.Red;
            this.BqOt.Location = new System.Drawing.Point(30, 58);
            this.BqOt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BqOt.Name = "BqOt";
            this.BqOt.Size = new System.Drawing.Size(32, 17);
            this.BqOt.TabIndex = 170;
            this.BqOt.Text = "过温";
            // 
            // BqOcc
            // 
            this.BqOcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BqOcc.AutoSize = true;
            this.BqOcc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BqOcc.ForeColor = System.Drawing.Color.Red;
            this.BqOcc.Location = new System.Drawing.Point(108, 6);
            this.BqOcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BqOcc.Name = "BqOcc";
            this.BqOcc.Size = new System.Drawing.Size(56, 17);
            this.BqOcc.TabIndex = 171;
            this.BqOcc.Text = "充电过流";
            // 
            // BqOcd
            // 
            this.BqOcd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BqOcd.AutoSize = true;
            this.BqOcd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BqOcd.ForeColor = System.Drawing.Color.Red;
            this.BqOcd.Location = new System.Drawing.Point(108, 32);
            this.BqOcd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BqOcd.Name = "BqOcd";
            this.BqOcd.Size = new System.Drawing.Size(56, 17);
            this.BqOcd.TabIndex = 172;
            this.BqOcd.Text = "放电过流";
            // 
            // BqUSoc
            // 
            this.BqUSoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BqUSoc.AutoSize = true;
            this.BqUSoc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BqUSoc.ForeColor = System.Drawing.Color.Red;
            this.BqUSoc.Location = new System.Drawing.Point(108, 58);
            this.BqUSoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BqUSoc.Name = "BqUSoc";
            this.BqUSoc.Size = new System.Drawing.Size(57, 17);
            this.BqUSoc.TabIndex = 173;
            this.BqUSoc.Text = "SOC低容";
            // 
            // BqROc
            // 
            this.BqROc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BqROc.AutoSize = true;
            this.BqROc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BqROc.ForeColor = System.Drawing.Color.Red;
            this.BqROc.Location = new System.Drawing.Point(192, 29);
            this.BqROc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BqROc.Name = "BqROc";
            this.BqROc.Size = new System.Drawing.Size(68, 23);
            this.BqROc.TabIndex = 176;
            this.BqROc.Text = "请求电流超限";
            // 
            // BqImT
            // 
            this.BqImT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BqImT.AutoSize = true;
            this.BqImT.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BqImT.ForeColor = System.Drawing.Color.Red;
            this.BqImT.Location = new System.Drawing.Point(198, 6);
            this.BqImT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BqImT.Name = "BqImT";
            this.BqImT.Size = new System.Drawing.Size(56, 17);
            this.BqImT.TabIndex = 178;
            this.BqImT.Text = "温度不均";
            // 
            // BqErr
            // 
            this.BqErr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BqErr.AutoSize = true;
            this.BqErr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BqErr.ForeColor = System.Drawing.Color.Red;
            this.BqErr.Location = new System.Drawing.Point(198, 58);
            this.BqErr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BqErr.Name = "BqErr";
            this.BqErr.Size = new System.Drawing.Size(56, 17);
            this.BqErr.TabIndex = 174;
            this.BqErr.Text = "硬件异常";
            // 
            // BqVima
            // 
            this.BqVima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BqVima.AutoSize = true;
            this.BqVima.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BqVima.ForeColor = System.Drawing.Color.Red;
            this.BqVima.Location = new System.Drawing.Point(102, 81);
            this.BqVima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BqVima.Name = "BqVima";
            this.BqVima.Size = new System.Drawing.Size(68, 26);
            this.BqVima.TabIndex = 180;
            this.BqVima.Text = "电芯压差超限";
            // 
            // BqSUv
            // 
            this.BqSUv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BqSUv.AutoSize = true;
            this.BqSUv.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BqSUv.ForeColor = System.Drawing.Color.Red;
            this.BqSUv.Location = new System.Drawing.Point(192, 81);
            this.BqSUv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BqSUv.Name = "BqSUv";
            this.BqSUv.Size = new System.Drawing.Size(68, 26);
            this.BqSUv.TabIndex = 181;
            this.BqSUv.Text = "放电欠压三级";
            // 
            // SecondStorage
            // 
            this.SecondStorage.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.SecondStorage.ColumnCount = 4;
            this.SecondStorage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondStorage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondStorage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondStorage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondStorage.Controls.Add(this.RecOv, 0, 0);
            this.SecondStorage.Controls.Add(this.RecUv, 0, 1);
            this.SecondStorage.Controls.Add(this.RecOcc, 1, 0);
            this.SecondStorage.Controls.Add(this.RecOcd, 1, 1);
            this.SecondStorage.Controls.Add(this.RecOt, 0, 2);
            this.SecondStorage.Controls.Add(this.RecUSoc, 1, 2);
            this.SecondStorage.Controls.Add(this.RecImT, 2, 0);
            this.SecondStorage.Controls.Add(this.RecROc, 2, 1);
            this.SecondStorage.Controls.Add(this.RecErr, 2, 2);
            this.SecondStorage.Controls.Add(this.RecScd, 3, 0);
            this.SecondStorage.Controls.Add(this.RecVima, 1, 3);
            this.SecondStorage.Controls.Add(this.RecUt, 0, 3);
            this.SecondStorage.Controls.Add(this.RecSUv, 2, 3);
            this.SecondStorage.Location = new System.Drawing.Point(431, 237);
            this.SecondStorage.Name = "SecondStorage";
            this.SecondStorage.RowCount = 4;
            this.SecondStorage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondStorage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondStorage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondStorage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondStorage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SecondStorage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SecondStorage.Size = new System.Drawing.Size(365, 110);
            this.SecondStorage.TabIndex = 130;
            // 
            // RecOv
            // 
            this.RecOv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecOv.AutoSize = true;
            this.RecOv.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecOv.ForeColor = System.Drawing.Color.Red;
            this.RecOv.Location = new System.Drawing.Point(18, 6);
            this.RecOv.Name = "RecOv";
            this.RecOv.Size = new System.Drawing.Size(56, 17);
            this.RecOv.TabIndex = 19;
            this.RecOv.Text = "充电过压";
            this.RecOv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecUv
            // 
            this.RecUv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecUv.AutoSize = true;
            this.RecUv.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecUv.ForeColor = System.Drawing.Color.Red;
            this.RecUv.Location = new System.Drawing.Point(18, 32);
            this.RecUv.Name = "RecUv";
            this.RecUv.Size = new System.Drawing.Size(56, 17);
            this.RecUv.TabIndex = 20;
            this.RecUv.Text = "放电欠压";
            this.RecUv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecOcc
            // 
            this.RecOcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecOcc.AutoSize = true;
            this.RecOcc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecOcc.ForeColor = System.Drawing.Color.Red;
            this.RecOcc.Location = new System.Drawing.Point(108, 6);
            this.RecOcc.Name = "RecOcc";
            this.RecOcc.Size = new System.Drawing.Size(56, 17);
            this.RecOcc.TabIndex = 22;
            this.RecOcc.Text = "充电过流";
            this.RecOcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecOcd
            // 
            this.RecOcd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecOcd.AutoSize = true;
            this.RecOcd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecOcd.ForeColor = System.Drawing.Color.Red;
            this.RecOcd.Location = new System.Drawing.Point(108, 32);
            this.RecOcd.Name = "RecOcd";
            this.RecOcd.Size = new System.Drawing.Size(56, 17);
            this.RecOcd.TabIndex = 21;
            this.RecOcd.Text = "放电过流";
            this.RecOcd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecOt
            // 
            this.RecOt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecOt.AutoSize = true;
            this.RecOt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecOt.ForeColor = System.Drawing.Color.Red;
            this.RecOt.Location = new System.Drawing.Point(30, 58);
            this.RecOt.Name = "RecOt";
            this.RecOt.Size = new System.Drawing.Size(32, 17);
            this.RecOt.TabIndex = 23;
            this.RecOt.Text = "过温";
            this.RecOt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecUSoc
            // 
            this.RecUSoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecUSoc.AutoSize = true;
            this.RecUSoc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecUSoc.ForeColor = System.Drawing.Color.Red;
            this.RecUSoc.Location = new System.Drawing.Point(108, 58);
            this.RecUSoc.Name = "RecUSoc";
            this.RecUSoc.Size = new System.Drawing.Size(57, 17);
            this.RecUSoc.TabIndex = 24;
            this.RecUSoc.Text = "SOC低容";
            this.RecUSoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecImT
            // 
            this.RecImT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecImT.AutoSize = true;
            this.RecImT.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecImT.ForeColor = System.Drawing.Color.Red;
            this.RecImT.Location = new System.Drawing.Point(198, 6);
            this.RecImT.Name = "RecImT";
            this.RecImT.Size = new System.Drawing.Size(56, 17);
            this.RecImT.TabIndex = 25;
            this.RecImT.Text = "温度不均";
            this.RecImT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecROc
            // 
            this.RecROc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecROc.AutoSize = true;
            this.RecROc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecROc.ForeColor = System.Drawing.Color.Red;
            this.RecROc.Location = new System.Drawing.Point(186, 32);
            this.RecROc.Name = "RecROc";
            this.RecROc.Size = new System.Drawing.Size(80, 17);
            this.RecROc.TabIndex = 28;
            this.RecROc.Text = "请求电流超限";
            this.RecROc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecErr
            // 
            this.RecErr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecErr.AutoSize = true;
            this.RecErr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecErr.ForeColor = System.Drawing.Color.Red;
            this.RecErr.Location = new System.Drawing.Point(198, 58);
            this.RecErr.Name = "RecErr";
            this.RecErr.Size = new System.Drawing.Size(56, 17);
            this.RecErr.TabIndex = 26;
            this.RecErr.Text = "硬件异常";
            this.RecErr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecScd
            // 
            this.RecScd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecScd.AutoSize = true;
            this.RecScd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecScd.ForeColor = System.Drawing.Color.Red;
            this.RecScd.Location = new System.Drawing.Point(289, 6);
            this.RecScd.Name = "RecScd";
            this.RecScd.Size = new System.Drawing.Size(56, 17);
            this.RecScd.TabIndex = 27;
            this.RecScd.Text = "短路保护";
            this.RecScd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecVima
            // 
            this.RecVima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecVima.AutoSize = true;
            this.RecVima.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecVima.ForeColor = System.Drawing.Color.Red;
            this.RecVima.Location = new System.Drawing.Point(96, 85);
            this.RecVima.Name = "RecVima";
            this.RecVima.Size = new System.Drawing.Size(80, 17);
            this.RecVima.TabIndex = 32;
            this.RecVima.Text = "电芯压差超限";
            this.RecVima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecUt
            // 
            this.RecUt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecUt.AutoSize = true;
            this.RecUt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecUt.ForeColor = System.Drawing.Color.Red;
            this.RecUt.Location = new System.Drawing.Point(30, 85);
            this.RecUt.Name = "RecUt";
            this.RecUt.Size = new System.Drawing.Size(32, 17);
            this.RecUt.TabIndex = 33;
            this.RecUt.Text = "欠温";
            this.RecUt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecSUv
            // 
            this.RecSUv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecSUv.AutoSize = true;
            this.RecSUv.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecSUv.ForeColor = System.Drawing.Color.Red;
            this.RecSUv.Location = new System.Drawing.Point(186, 85);
            this.RecSUv.Name = "RecSUv";
            this.RecSUv.Size = new System.Drawing.Size(80, 17);
            this.RecSUv.TabIndex = 34;
            this.RecSUv.Text = "放电欠压三级";
            this.RecSUv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SoftWarning
            // 
            this.SoftWarning.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.SoftWarning.ColumnCount = 4;
            this.SoftWarning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SoftWarning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SoftWarning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SoftWarning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SoftWarning.Controls.Add(this.SoftUt, 0, 3);
            this.SoftWarning.Controls.Add(this.SoftOv, 0, 0);
            this.SoftWarning.Controls.Add(this.SoftUv, 0, 1);
            this.SoftWarning.Controls.Add(this.SoftOt, 0, 2);
            this.SoftWarning.Controls.Add(this.SoftOcc, 1, 0);
            this.SoftWarning.Controls.Add(this.softOcd, 1, 1);
            this.SoftWarning.Controls.Add(this.SoftUSoc, 1, 2);
            this.SoftWarning.Controls.Add(this.SoftROc, 2, 1);
            this.SoftWarning.Controls.Add(this.SoftVima, 1, 3);
            this.SoftWarning.Controls.Add(this.SoftImT, 2, 0);
            this.SoftWarning.Location = new System.Drawing.Point(34, 237);
            this.SoftWarning.Name = "SoftWarning";
            this.SoftWarning.RowCount = 4;
            this.SoftWarning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SoftWarning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SoftWarning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SoftWarning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SoftWarning.Size = new System.Drawing.Size(365, 110);
            this.SoftWarning.TabIndex = 129;
            // 
            // SoftUt
            // 
            this.SoftUt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SoftUt.AutoSize = true;
            this.SoftUt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SoftUt.ForeColor = System.Drawing.Color.Red;
            this.SoftUt.Location = new System.Drawing.Point(30, 85);
            this.SoftUt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SoftUt.Name = "SoftUt";
            this.SoftUt.Size = new System.Drawing.Size(32, 17);
            this.SoftUt.TabIndex = 179;
            this.SoftUt.Text = "欠温";
            // 
            // SoftOv
            // 
            this.SoftOv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SoftOv.AutoSize = true;
            this.SoftOv.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SoftOv.ForeColor = System.Drawing.Color.Red;
            this.SoftOv.Location = new System.Drawing.Point(18, 6);
            this.SoftOv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SoftOv.Name = "SoftOv";
            this.SoftOv.Size = new System.Drawing.Size(56, 17);
            this.SoftOv.TabIndex = 168;
            this.SoftOv.Text = "充电过压";
            // 
            // SoftUv
            // 
            this.SoftUv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SoftUv.AutoSize = true;
            this.SoftUv.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SoftUv.ForeColor = System.Drawing.Color.Red;
            this.SoftUv.Location = new System.Drawing.Point(18, 32);
            this.SoftUv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SoftUv.Name = "SoftUv";
            this.SoftUv.Size = new System.Drawing.Size(56, 17);
            this.SoftUv.TabIndex = 169;
            this.SoftUv.Text = "放电欠压";
            // 
            // SoftOt
            // 
            this.SoftOt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SoftOt.AutoSize = true;
            this.SoftOt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SoftOt.ForeColor = System.Drawing.Color.Red;
            this.SoftOt.Location = new System.Drawing.Point(30, 58);
            this.SoftOt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SoftOt.Name = "SoftOt";
            this.SoftOt.Size = new System.Drawing.Size(32, 17);
            this.SoftOt.TabIndex = 170;
            this.SoftOt.Text = "过温";
            // 
            // SoftOcc
            // 
            this.SoftOcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SoftOcc.AutoSize = true;
            this.SoftOcc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SoftOcc.ForeColor = System.Drawing.Color.Red;
            this.SoftOcc.Location = new System.Drawing.Point(108, 6);
            this.SoftOcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SoftOcc.Name = "SoftOcc";
            this.SoftOcc.Size = new System.Drawing.Size(56, 17);
            this.SoftOcc.TabIndex = 171;
            this.SoftOcc.Text = "充电过流";
            // 
            // softOcd
            // 
            this.softOcd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.softOcd.AutoSize = true;
            this.softOcd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.softOcd.ForeColor = System.Drawing.Color.Red;
            this.softOcd.Location = new System.Drawing.Point(108, 32);
            this.softOcd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.softOcd.Name = "softOcd";
            this.softOcd.Size = new System.Drawing.Size(56, 17);
            this.softOcd.TabIndex = 172;
            this.softOcd.Text = "放电过流";
            // 
            // SoftUSoc
            // 
            this.SoftUSoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SoftUSoc.AutoSize = true;
            this.SoftUSoc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SoftUSoc.ForeColor = System.Drawing.Color.Red;
            this.SoftUSoc.Location = new System.Drawing.Point(108, 58);
            this.SoftUSoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SoftUSoc.Name = "SoftUSoc";
            this.SoftUSoc.Size = new System.Drawing.Size(57, 17);
            this.SoftUSoc.TabIndex = 173;
            this.SoftUSoc.Text = "SOC低容";
            // 
            // SoftROc
            // 
            this.SoftROc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SoftROc.AutoSize = true;
            this.SoftROc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SoftROc.ForeColor = System.Drawing.Color.Red;
            this.SoftROc.Location = new System.Drawing.Point(192, 29);
            this.SoftROc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SoftROc.Name = "SoftROc";
            this.SoftROc.Size = new System.Drawing.Size(68, 23);
            this.SoftROc.TabIndex = 176;
            this.SoftROc.Text = "请求电流超限";
            // 
            // SoftVima
            // 
            this.SoftVima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SoftVima.AutoSize = true;
            this.SoftVima.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SoftVima.ForeColor = System.Drawing.Color.Red;
            this.SoftVima.Location = new System.Drawing.Point(102, 81);
            this.SoftVima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SoftVima.Name = "SoftVima";
            this.SoftVima.Size = new System.Drawing.Size(68, 26);
            this.SoftVima.TabIndex = 174;
            this.SoftVima.Text = "电芯压差超限";
            // 
            // SoftImT
            // 
            this.SoftImT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SoftImT.AutoSize = true;
            this.SoftImT.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SoftImT.ForeColor = System.Drawing.Color.Red;
            this.SoftImT.Location = new System.Drawing.Point(198, 6);
            this.SoftImT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SoftImT.Name = "SoftImT";
            this.SoftImT.Size = new System.Drawing.Size(56, 17);
            this.SoftImT.TabIndex = 178;
            this.SoftImT.Text = "温度不均";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.Controls.Add(this.CHG_temp_mosfet, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.lifetimes, 9, 4);
            this.tableLayoutPanel1.Controls.Add(this.label59, 8, 4);
            this.tableLayoutPanel1.Controls.Add(this.CELL_MIX_VOLTAGE, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.CELL_MAX_VOLTAGE, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.label56, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.label41, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label42, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cell3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label25, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label26, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cell4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cell5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label36, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label37, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label38, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cell2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label46, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cell1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.soc, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.current, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.label24, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label29, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.label23, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label19, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label21, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.cell13, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.cell14, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.cell6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cell7, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cell8, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cell9, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cell10, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cell11, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cell12, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.voltage, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.label32, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label34, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.temp_1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.temp_2, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label43, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.temp_3, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.temp_4, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.label30, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.label40, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.BAT_Capacity, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.VDiff, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.label48, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.label49, 8, 3);
            this.tableLayoutPanel1.Controls.Add(this.CELL_MAX_TEMP, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.CELL_MIN_TEMP, 9, 3);
            this.tableLayoutPanel1.Controls.Add(this.label55, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.label44, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.label60, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label61, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.temp_5, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.temp_6, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.label52, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.envtemp, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.label47, 8, 6);
            this.tableLayoutPanel1.Controls.Add(this.temp_mosfet, 9, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.DSC_temp_mosfet, 7, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(905, 186);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // CHG_temp_mosfet
            // 
            this.CHG_temp_mosfet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CHG_temp_mosfet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHG_temp_mosfet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CHG_temp_mosfet.Location = new System.Drawing.Point(668, 134);
            this.CHG_temp_mosfet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CHG_temp_mosfet.Name = "CHG_temp_mosfet";
            this.CHG_temp_mosfet.Size = new System.Drawing.Size(43, 21);
            this.CHG_temp_mosfet.TabIndex = 194;
            this.CHG_temp_mosfet.Text = "N";
            this.CHG_temp_mosfet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(557, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 135;
            this.label2.Text = "充电MOS温度";
            // 
            // lifetimes
            // 
            this.lifetimes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lifetimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lifetimes.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lifetimes.Location = new System.Drawing.Point(847, 108);
            this.lifetimes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lifetimes.Name = "lifetimes";
            this.lifetimes.Size = new System.Drawing.Size(47, 21);
            this.lifetimes.TabIndex = 192;
            this.lifetimes.Text = "N";
            this.lifetimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label59
            // 
            this.label59.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label59.Location = new System.Drawing.Point(745, 110);
            this.label59.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(68, 17);
            this.label59.TabIndex = 191;
            this.label59.Text = "充放电次数";
            // 
            // CELL_MIX_VOLTAGE
            // 
            this.CELL_MIX_VOLTAGE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CELL_MIX_VOLTAGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CELL_MIX_VOLTAGE.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CELL_MIX_VOLTAGE.Location = new System.Drawing.Point(847, 30);
            this.CELL_MIX_VOLTAGE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CELL_MIX_VOLTAGE.Name = "CELL_MIX_VOLTAGE";
            this.CELL_MIX_VOLTAGE.Size = new System.Drawing.Size(47, 21);
            this.CELL_MIX_VOLTAGE.TabIndex = 190;
            this.CELL_MIX_VOLTAGE.Text = "N";
            this.CELL_MIX_VOLTAGE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CELL_MAX_VOLTAGE
            // 
            this.CELL_MAX_VOLTAGE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CELL_MAX_VOLTAGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CELL_MAX_VOLTAGE.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CELL_MAX_VOLTAGE.Location = new System.Drawing.Point(847, 4);
            this.CELL_MAX_VOLTAGE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CELL_MAX_VOLTAGE.Name = "CELL_MAX_VOLTAGE";
            this.CELL_MAX_VOLTAGE.Size = new System.Drawing.Size(47, 21);
            this.CELL_MAX_VOLTAGE.TabIndex = 189;
            this.CELL_MAX_VOLTAGE.Text = "N";
            this.CELL_MAX_VOLTAGE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label56
            // 
            this.label56.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label56.Location = new System.Drawing.Point(739, 6);
            this.label56.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(80, 17);
            this.label56.TabIndex = 188;
            this.label56.Text = "电芯最高电压";
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label41.Location = new System.Drawing.Point(186, 6);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(97, 17);
            this.label41.TabIndex = 177;
            this.label41.Text = "单节电压08(mV)";
            // 
            // label42
            // 
            this.label42.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label42.Location = new System.Drawing.Point(186, 32);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(97, 17);
            this.label42.TabIndex = 176;
            this.label42.Text = "单节电压09(mV)";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 115;
            this.label1.Text = "单节电压1(mV)";
            // 
            // cell3
            // 
            this.cell3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cell3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cell3.Location = new System.Drawing.Point(119, 56);
            this.cell3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cell3.Name = "cell3";
            this.cell3.Size = new System.Drawing.Size(43, 21);
            this.cell3.TabIndex = 131;
            this.cell3.Text = "N";
            this.cell3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(10, 58);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 17);
            this.label20.TabIndex = 132;
            this.label20.Text = "单节电压3(mV)";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(10, 84);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(90, 17);
            this.label25.TabIndex = 144;
            this.label25.Text = "单节电压4(mV)";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.Location = new System.Drawing.Point(186, 84);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(97, 17);
            this.label26.TabIndex = 145;
            this.label26.Text = "单节电压11(mV)";
            // 
            // cell4
            // 
            this.cell4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cell4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cell4.Location = new System.Drawing.Point(119, 82);
            this.cell4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cell4.Name = "cell4";
            this.cell4.Size = new System.Drawing.Size(43, 21);
            this.cell4.TabIndex = 147;
            this.cell4.Text = "N";
            this.cell4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell5
            // 
            this.cell5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cell5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cell5.Location = new System.Drawing.Point(119, 107);
            this.cell5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cell5.Name = "cell5";
            this.cell5.Size = new System.Drawing.Size(43, 22);
            this.cell5.TabIndex = 162;
            this.cell5.Text = "N";
            this.cell5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label36.Location = new System.Drawing.Point(10, 110);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(90, 17);
            this.label36.TabIndex = 158;
            this.label36.Text = "单节电压5(mV)";
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label37.Location = new System.Drawing.Point(186, 110);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(97, 17);
            this.label37.TabIndex = 165;
            this.label37.Text = "单节电压12(mV)";
            // 
            // label38
            // 
            this.label38.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label38.Location = new System.Drawing.Point(10, 32);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(90, 17);
            this.label38.TabIndex = 126;
            this.label38.Text = "单节电压2(mV)";
            // 
            // cell2
            // 
            this.cell2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cell2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cell2.Location = new System.Drawing.Point(119, 29);
            this.cell2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cell2.Name = "cell2";
            this.cell2.Size = new System.Drawing.Size(43, 23);
            this.cell2.TabIndex = 148;
            this.cell2.Text = "N";
            this.cell2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label46
            // 
            this.label46.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label46.Location = new System.Drawing.Point(186, 58);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(97, 17);
            this.label46.TabIndex = 137;
            this.label46.Text = "单节电压10(mV)";
            // 
            // cell1
            // 
            this.cell1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cell1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cell1.Location = new System.Drawing.Point(119, 4);
            this.cell1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cell1.Name = "cell1";
            this.cell1.Size = new System.Drawing.Size(43, 21);
            this.cell1.TabIndex = 125;
            this.cell1.Text = "N";
            this.cell1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soc
            // 
            this.soc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.soc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.soc.Location = new System.Drawing.Point(668, 4);
            this.soc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.soc.Name = "soc";
            this.soc.Size = new System.Drawing.Size(43, 21);
            this.soc.TabIndex = 129;
            this.soc.Text = "N";
            this.soc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // current
            // 
            this.current.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.current.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.current.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.current.Location = new System.Drawing.Point(668, 29);
            this.current.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(43, 23);
            this.current.TabIndex = 129;
            this.current.Text = "N";
            this.current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(573, 6);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 17);
            this.label24.TabIndex = 134;
            this.label24.Text = "SOC(%)";
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.Location = new System.Drawing.Point(567, 32);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(65, 17);
            this.label29.TabIndex = 134;
            this.label29.Text = "current(A)";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(10, 136);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 17);
            this.label23.TabIndex = 178;
            this.label23.Text = "单节电压6(mV)";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(10, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 167;
            this.label9.Text = "单节电压7(mV)";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(186, 136);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 17);
            this.label19.TabIndex = 168;
            this.label19.Text = "单节电压13(mV)";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(186, 162);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 17);
            this.label21.TabIndex = 169;
            this.label21.Text = "单节电压14(mV)";
            // 
            // cell13
            // 
            this.cell13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cell13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cell13.Location = new System.Drawing.Point(308, 134);
            this.cell13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cell13.Name = "cell13";
            this.cell13.Size = new System.Drawing.Size(43, 21);
            this.cell13.TabIndex = 174;
            this.cell13.Text = "N";
            this.cell13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell14
            // 
            this.cell14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cell14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cell14.Location = new System.Drawing.Point(308, 160);
            this.cell14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cell14.Name = "cell14";
            this.cell14.Size = new System.Drawing.Size(43, 21);
            this.cell14.TabIndex = 175;
            this.cell14.Text = "N";
            this.cell14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell6
            // 
            this.cell6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cell6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cell6.Location = new System.Drawing.Point(119, 134);
            this.cell6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cell6.Name = "cell6";
            this.cell6.Size = new System.Drawing.Size(43, 21);
            this.cell6.TabIndex = 129;
            this.cell6.Text = "N";
            this.cell6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell7
            // 
            this.cell7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cell7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cell7.Location = new System.Drawing.Point(119, 159);
            this.cell7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cell7.Name = "cell7";
            this.cell7.Size = new System.Drawing.Size(43, 24);
            this.cell7.TabIndex = 154;
            this.cell7.Text = "N";
            this.cell7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell8
            // 
            this.cell8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cell8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cell8.Location = new System.Drawing.Point(308, 4);
            this.cell8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cell8.Name = "cell8";
            this.cell8.Size = new System.Drawing.Size(43, 21);
            this.cell8.TabIndex = 155;
            this.cell8.Text = "N";
            this.cell8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell9
            // 
            this.cell9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cell9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cell9.Location = new System.Drawing.Point(308, 30);
            this.cell9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cell9.Name = "cell9";
            this.cell9.Size = new System.Drawing.Size(43, 21);
            this.cell9.TabIndex = 153;
            this.cell9.Text = "N";
            this.cell9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell10
            // 
            this.cell10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cell10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cell10.Location = new System.Drawing.Point(308, 55);
            this.cell10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cell10.Name = "cell10";
            this.cell10.Size = new System.Drawing.Size(43, 22);
            this.cell10.TabIndex = 143;
            this.cell10.Text = "N";
            this.cell10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell11
            // 
            this.cell11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cell11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cell11.Location = new System.Drawing.Point(308, 82);
            this.cell11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cell11.Name = "cell11";
            this.cell11.Size = new System.Drawing.Size(43, 21);
            this.cell11.TabIndex = 172;
            this.cell11.Text = "N";
            this.cell11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell12
            // 
            this.cell12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cell12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cell12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cell12.Location = new System.Drawing.Point(308, 108);
            this.cell12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cell12.Name = "cell12";
            this.cell12.Size = new System.Drawing.Size(43, 21);
            this.cell12.TabIndex = 173;
            this.cell12.Text = "N";
            this.cell12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // voltage
            // 
            this.voltage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.voltage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.voltage.Location = new System.Drawing.Point(668, 56);
            this.voltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.voltage.Name = "voltage";
            this.voltage.Size = new System.Drawing.Size(43, 21);
            this.voltage.TabIndex = 129;
            this.voltage.Text = "N";
            this.voltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label32.Location = new System.Drawing.Point(385, 6);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(68, 17);
            this.label32.TabIndex = 134;
            this.label32.Text = "电芯温度_1";
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.Location = new System.Drawing.Point(385, 32);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(68, 17);
            this.label34.TabIndex = 134;
            this.label34.Text = "电芯温度_2";
            // 
            // temp_1
            // 
            this.temp_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temp_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temp_1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temp_1.Location = new System.Drawing.Point(488, 3);
            this.temp_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temp_1.Name = "temp_1";
            this.temp_1.Size = new System.Drawing.Size(43, 22);
            this.temp_1.TabIndex = 129;
            this.temp_1.Text = "N";
            this.temp_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temp_2
            // 
            this.temp_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temp_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temp_2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temp_2.Location = new System.Drawing.Point(488, 30);
            this.temp_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temp_2.Name = "temp_2";
            this.temp_2.Size = new System.Drawing.Size(43, 21);
            this.temp_2.TabIndex = 129;
            this.temp_2.Text = "N";
            this.temp_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label43.Location = new System.Drawing.Point(385, 58);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(68, 17);
            this.label43.TabIndex = 134;
            this.label43.Text = "电芯温度_3";
            // 
            // temp_3
            // 
            this.temp_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temp_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temp_3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temp_3.Location = new System.Drawing.Point(488, 55);
            this.temp_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temp_3.Name = "temp_3";
            this.temp_3.Size = new System.Drawing.Size(43, 23);
            this.temp_3.TabIndex = 129;
            this.temp_3.Text = "N";
            this.temp_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temp_4
            // 
            this.temp_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temp_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temp_4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temp_4.Location = new System.Drawing.Point(488, 82);
            this.temp_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temp_4.Name = "temp_4";
            this.temp_4.Size = new System.Drawing.Size(43, 21);
            this.temp_4.TabIndex = 129;
            this.temp_4.Text = "N";
            this.temp_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.Location = new System.Drawing.Point(565, 55);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(68, 23);
            this.label30.TabIndex = 134;
            this.label30.Text = "电池总电压(10mV)";
            // 
            // label40
            // 
            this.label40.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label40.Location = new System.Drawing.Point(565, 81);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(68, 23);
            this.label40.TabIndex = 181;
            this.label40.Text = "电池包容量(0.1AH)";
            // 
            // BAT_Capacity
            // 
            this.BAT_Capacity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BAT_Capacity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAT_Capacity.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BAT_Capacity.Location = new System.Drawing.Point(668, 82);
            this.BAT_Capacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BAT_Capacity.Name = "BAT_Capacity";
            this.BAT_Capacity.Size = new System.Drawing.Size(43, 21);
            this.BAT_Capacity.TabIndex = 182;
            this.BAT_Capacity.Text = "N";
            this.BAT_Capacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(562, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 179;
            this.label8.Text = "压差（mV）";
            // 
            // VDiff
            // 
            this.VDiff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VDiff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VDiff.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VDiff.Location = new System.Drawing.Point(668, 108);
            this.VDiff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VDiff.Name = "VDiff";
            this.VDiff.Size = new System.Drawing.Size(43, 21);
            this.VDiff.TabIndex = 180;
            this.VDiff.Text = "N";
            this.VDiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label48
            // 
            this.label48.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label48.Location = new System.Drawing.Point(739, 58);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(80, 17);
            this.label48.TabIndex = 183;
            this.label48.Text = "电芯最高温度";
            // 
            // label49
            // 
            this.label49.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label49.Location = new System.Drawing.Point(739, 84);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(80, 17);
            this.label49.TabIndex = 184;
            this.label49.Text = "电芯最低温度";
            // 
            // CELL_MAX_TEMP
            // 
            this.CELL_MAX_TEMP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CELL_MAX_TEMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CELL_MAX_TEMP.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CELL_MAX_TEMP.Location = new System.Drawing.Point(847, 56);
            this.CELL_MAX_TEMP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CELL_MAX_TEMP.Name = "CELL_MAX_TEMP";
            this.CELL_MAX_TEMP.Size = new System.Drawing.Size(47, 21);
            this.CELL_MAX_TEMP.TabIndex = 185;
            this.CELL_MAX_TEMP.Text = "N";
            this.CELL_MAX_TEMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CELL_MIN_TEMP
            // 
            this.CELL_MIN_TEMP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CELL_MIN_TEMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CELL_MIN_TEMP.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CELL_MIN_TEMP.Location = new System.Drawing.Point(847, 82);
            this.CELL_MIN_TEMP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CELL_MIN_TEMP.Name = "CELL_MIN_TEMP";
            this.CELL_MIN_TEMP.Size = new System.Drawing.Size(47, 21);
            this.CELL_MIN_TEMP.TabIndex = 186;
            this.CELL_MIN_TEMP.Text = "N";
            this.CELL_MIN_TEMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label55
            // 
            this.label55.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label55.Location = new System.Drawing.Point(739, 32);
            this.label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(80, 17);
            this.label55.TabIndex = 187;
            this.label55.Text = "电芯最低电压";
            // 
            // label44
            // 
            this.label44.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label44.Location = new System.Drawing.Point(385, 110);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(68, 17);
            this.label44.TabIndex = 134;
            this.label44.Text = "电芯温度_5";
            // 
            // label60
            // 
            this.label60.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label60.Location = new System.Drawing.Point(385, 84);
            this.label60.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(68, 17);
            this.label60.TabIndex = 134;
            this.label60.Text = "电芯温度_4";
            // 
            // label61
            // 
            this.label61.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label61.Location = new System.Drawing.Point(385, 136);
            this.label61.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(68, 17);
            this.label61.TabIndex = 134;
            this.label61.Text = "电芯温度_6";
            // 
            // temp_5
            // 
            this.temp_5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temp_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temp_5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temp_5.Location = new System.Drawing.Point(488, 108);
            this.temp_5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temp_5.Name = "temp_5";
            this.temp_5.Size = new System.Drawing.Size(43, 21);
            this.temp_5.TabIndex = 129;
            this.temp_5.Text = "N";
            this.temp_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temp_6
            // 
            this.temp_6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temp_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temp_6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temp_6.Location = new System.Drawing.Point(488, 134);
            this.temp_6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temp_6.Name = "temp_6";
            this.temp_6.Size = new System.Drawing.Size(43, 21);
            this.temp_6.TabIndex = 129;
            this.temp_6.Text = "N";
            this.temp_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            this.label52.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label52.Location = new System.Drawing.Point(391, 162);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(56, 17);
            this.label52.TabIndex = 134;
            this.label52.Text = "环境温度";
            // 
            // envtemp
            // 
            this.envtemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.envtemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.envtemp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.envtemp.Location = new System.Drawing.Point(488, 160);
            this.envtemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.envtemp.Name = "envtemp";
            this.envtemp.Size = new System.Drawing.Size(43, 22);
            this.envtemp.TabIndex = 129;
            this.envtemp.Text = "N";
            this.envtemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label47
            // 
            this.label47.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label47.Location = new System.Drawing.Point(748, 162);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(63, 17);
            this.label47.TabIndex = 134;
            this.label47.Text = "温度_Mos";
            // 
            // temp_mosfet
            // 
            this.temp_mosfet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temp_mosfet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temp_mosfet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temp_mosfet.Location = new System.Drawing.Point(849, 160);
            this.temp_mosfet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temp_mosfet.Name = "temp_mosfet";
            this.temp_mosfet.Size = new System.Drawing.Size(43, 21);
            this.temp_mosfet.TabIndex = 129;
            this.temp_mosfet.Text = "N";
            this.temp_mosfet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(557, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 193;
            this.label3.Text = "放电MOS温度";
            // 
            // DSC_temp_mosfet
            // 
            this.DSC_temp_mosfet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DSC_temp_mosfet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DSC_temp_mosfet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DSC_temp_mosfet.Location = new System.Drawing.Point(668, 160);
            this.DSC_temp_mosfet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DSC_temp_mosfet.Name = "DSC_temp_mosfet";
            this.DSC_temp_mosfet.Size = new System.Drawing.Size(43, 21);
            this.DSC_temp_mosfet.TabIndex = 195;
            this.DSC_temp_mosfet.Text = "N";
            this.DSC_temp_mosfet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1020, 701);
            this.tabControl1.TabIndex = 93;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(92, 63);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 21);
            this.textBox9.TabIndex = 117;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(92, 100);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 21);
            this.textBox10.TabIndex = 117;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(92, 31);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 21);
            this.textBox8.TabIndex = 117;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 17);
            this.label16.TabIndex = 118;
            // 
            // Test_PCM_dischargecurrent
            // 
            this.Test_PCM_dischargecurrent.Location = new System.Drawing.Point(19, 291);
            this.Test_PCM_dischargecurrent.Name = "Test_PCM_dischargecurrent";
            this.Test_PCM_dischargecurrent.Size = new System.Drawing.Size(179, 48);
            this.Test_PCM_dischargecurrent.TabIndex = 115;
            this.Test_PCM_dischargecurrent.Text = "Test_PCM_dischargecurrent";
            this.Test_PCM_dischargecurrent.UseVisualStyleBackColor = true;
            this.Test_PCM_dischargecurrent.Click += new System.EventHandler(this.Test_PCM_dischargecurrent_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 69);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 17);
            this.label18.TabIndex = 118;
            // 
            // Test_taillight
            // 
            this.Test_taillight.Location = new System.Drawing.Point(19, 222);
            this.Test_taillight.Name = "Test_taillight";
            this.Test_taillight.Size = new System.Drawing.Size(179, 48);
            this.Test_taillight.TabIndex = 114;
            this.Test_taillight.Text = "Test_taillight";
            this.Test_taillight.UseVisualStyleBackColor = true;
            this.Test_taillight.Click += new System.EventHandler(this.Test_taillight_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(16, 100);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(43, 17);
            this.label51.TabIndex = 118;
            // 
            // label195
            // 
            this.label195.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label195.AutoSize = true;
            this.label195.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label195.Location = new System.Drawing.Point(614, 32);
            this.label195.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label195.Name = "label195";
            this.label195.Size = new System.Drawing.Size(80, 17);
            this.label195.TabIndex = 187;
            // 
            // label194
            // 
            this.label194.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label194.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label194.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label194.Location = new System.Drawing.Point(708, 82);
            this.label194.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label194.Name = "label194";
            this.label194.Size = new System.Drawing.Size(47, 21);
            this.label194.TabIndex = 186;
            this.label194.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label193
            // 
            this.label193.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label193.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label193.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label193.Location = new System.Drawing.Point(708, 56);
            this.label193.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label193.Name = "label193";
            this.label193.Size = new System.Drawing.Size(47, 21);
            this.label193.TabIndex = 185;
            this.label193.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label192
            // 
            this.label192.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label192.AutoSize = true;
            this.label192.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label192.Location = new System.Drawing.Point(614, 84);
            this.label192.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label192.Name = "label192";
            this.label192.Size = new System.Drawing.Size(80, 17);
            this.label192.TabIndex = 184;
            // 
            // label191
            // 
            this.label191.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label191.AutoSize = true;
            this.label191.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label191.Location = new System.Drawing.Point(614, 58);
            this.label191.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label191.Name = "label191";
            this.label191.Size = new System.Drawing.Size(80, 17);
            this.label191.TabIndex = 183;
            // 
            // label190
            // 
            this.label190.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label190.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label190.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label190.Location = new System.Drawing.Point(557, 108);
            this.label190.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label190.Name = "label190";
            this.label190.Size = new System.Drawing.Size(43, 21);
            this.label190.TabIndex = 180;
            this.label190.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label189
            // 
            this.label189.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label189.AutoSize = true;
            this.label189.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label189.Location = new System.Drawing.Point(471, 110);
            this.label189.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label189.Name = "label189";
            this.label189.Size = new System.Drawing.Size(64, 17);
            this.label189.TabIndex = 179;
            // 
            // label188
            // 
            this.label188.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label188.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label188.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label188.Location = new System.Drawing.Point(557, 82);
            this.label188.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label188.Name = "label188";
            this.label188.Size = new System.Drawing.Size(43, 21);
            this.label188.TabIndex = 182;
            this.label188.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label187
            // 
            this.label187.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label187.AutoSize = true;
            this.label187.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label187.Location = new System.Drawing.Point(469, 81);
            this.label187.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label187.Name = "label187";
            this.label187.Size = new System.Drawing.Size(68, 23);
            this.label187.TabIndex = 181;
            // 
            // label186
            // 
            this.label186.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label186.AutoSize = true;
            this.label186.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label186.Location = new System.Drawing.Point(320, 136);
            this.label186.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label186.Name = "label186";
            this.label186.Size = new System.Drawing.Size(63, 17);
            this.label186.TabIndex = 134;
            // 
            // label185
            // 
            this.label185.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label185.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label185.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label185.Location = new System.Drawing.Point(406, 134);
            this.label185.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label185.Name = "label185";
            this.label185.Size = new System.Drawing.Size(43, 21);
            this.label185.TabIndex = 129;
            this.label185.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label184
            // 
            this.label184.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label184.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label184.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label184.Location = new System.Drawing.Point(406, 107);
            this.label184.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label184.Name = "label184";
            this.label184.Size = new System.Drawing.Size(43, 22);
            this.label184.TabIndex = 129;
            this.label184.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label183
            // 
            this.label183.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label183.AutoSize = true;
            this.label183.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label183.Location = new System.Drawing.Point(324, 110);
            this.label183.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label183.Name = "label183";
            this.label183.Size = new System.Drawing.Size(56, 17);
            this.label183.TabIndex = 134;
            // 
            // label182
            // 
            this.label182.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label182.AutoSize = true;
            this.label182.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label182.Location = new System.Drawing.Point(461, 58);
            this.label182.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label182.Name = "label182";
            this.label182.Size = new System.Drawing.Size(84, 17);
            this.label182.TabIndex = 134;
            // 
            // label181
            // 
            this.label181.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label181.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label181.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label181.Location = new System.Drawing.Point(708, 160);
            this.label181.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label181.Name = "label181";
            this.label181.Size = new System.Drawing.Size(47, 21);
            this.label181.TabIndex = 129;
            this.label181.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label180
            // 
            this.label180.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label180.AutoSize = true;
            this.label180.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label180.Location = new System.Drawing.Point(616, 162);
            this.label180.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label180.Name = "label180";
            this.label180.Size = new System.Drawing.Size(76, 17);
            this.label180.TabIndex = 134;
            // 
            // label179
            // 
            this.label179.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label179.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label179.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label179.Location = new System.Drawing.Point(406, 82);
            this.label179.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label179.Name = "label179";
            this.label179.Size = new System.Drawing.Size(43, 21);
            this.label179.TabIndex = 129;
            this.label179.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label178
            // 
            this.label178.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label178.AutoSize = true;
            this.label178.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label178.Location = new System.Drawing.Point(318, 84);
            this.label178.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label178.Name = "label178";
            this.label178.Size = new System.Drawing.Size(68, 17);
            this.label178.TabIndex = 134;
            // 
            // label177
            // 
            this.label177.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label177.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label177.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label177.Location = new System.Drawing.Point(406, 55);
            this.label177.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label177.Name = "label177";
            this.label177.Size = new System.Drawing.Size(43, 23);
            this.label177.TabIndex = 129;
            this.label177.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label176
            // 
            this.label176.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label176.AutoSize = true;
            this.label176.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label176.Location = new System.Drawing.Point(318, 58);
            this.label176.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label176.Name = "label176";
            this.label176.Size = new System.Drawing.Size(68, 17);
            this.label176.TabIndex = 134;
            // 
            // label175
            // 
            this.label175.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label175.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label175.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label175.Location = new System.Drawing.Point(406, 30);
            this.label175.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(43, 21);
            this.label175.TabIndex = 129;
            this.label175.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label174
            // 
            this.label174.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label174.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label174.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label174.Location = new System.Drawing.Point(406, 3);
            this.label174.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label174.Name = "label174";
            this.label174.Size = new System.Drawing.Size(43, 22);
            this.label174.TabIndex = 129;
            this.label174.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label173
            // 
            this.label173.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label173.AutoSize = true;
            this.label173.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label173.Location = new System.Drawing.Point(318, 32);
            this.label173.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label173.Name = "label173";
            this.label173.Size = new System.Drawing.Size(68, 17);
            this.label173.TabIndex = 134;
            // 
            // label172
            // 
            this.label172.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label172.AutoSize = true;
            this.label172.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label172.Location = new System.Drawing.Point(318, 6);
            this.label172.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(68, 17);
            this.label172.TabIndex = 134;
            // 
            // label171
            // 
            this.label171.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label171.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label171.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label171.Location = new System.Drawing.Point(557, 56);
            this.label171.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label171.Name = "label171";
            this.label171.Size = new System.Drawing.Size(43, 21);
            this.label171.TabIndex = 129;
            this.label171.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label170
            // 
            this.label170.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label170.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label170.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label170.Location = new System.Drawing.Point(255, 108);
            this.label170.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label170.Name = "label170";
            this.label170.Size = new System.Drawing.Size(43, 21);
            this.label170.TabIndex = 173;
            this.label170.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label169
            // 
            this.label169.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label169.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label169.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label169.Location = new System.Drawing.Point(255, 82);
            this.label169.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label169.Name = "label169";
            this.label169.Size = new System.Drawing.Size(43, 21);
            this.label169.TabIndex = 172;
            this.label169.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label168
            // 
            this.label168.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label168.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label168.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label168.Location = new System.Drawing.Point(255, 55);
            this.label168.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(43, 22);
            this.label168.TabIndex = 143;
            this.label168.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label167
            // 
            this.label167.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label167.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label167.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label167.Location = new System.Drawing.Point(255, 30);
            this.label167.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(43, 21);
            this.label167.TabIndex = 153;
            this.label167.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label166
            // 
            this.label166.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label166.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label166.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label166.Location = new System.Drawing.Point(255, 4);
            this.label166.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(43, 21);
            this.label166.TabIndex = 155;
            this.label166.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label165
            // 
            this.label165.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label165.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label165.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label165.Location = new System.Drawing.Point(104, 159);
            this.label165.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(43, 24);
            this.label165.TabIndex = 154;
            this.label165.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label164
            // 
            this.label164.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label164.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label164.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label164.Location = new System.Drawing.Point(104, 134);
            this.label164.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(43, 21);
            this.label164.TabIndex = 129;
            this.label164.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label163
            // 
            this.label163.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label163.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label163.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label163.Location = new System.Drawing.Point(255, 160);
            this.label163.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(43, 21);
            this.label163.TabIndex = 175;
            this.label163.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label162
            // 
            this.label162.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label162.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label162.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label162.Location = new System.Drawing.Point(255, 134);
            this.label162.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(43, 21);
            this.label162.TabIndex = 174;
            this.label162.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label161
            // 
            this.label161.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label161.AutoSize = true;
            this.label161.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label161.Location = new System.Drawing.Point(158, 162);
            this.label161.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(86, 17);
            this.label161.TabIndex = 169;
            // 
            // label160
            // 
            this.label160.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label160.AutoSize = true;
            this.label160.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label160.Location = new System.Drawing.Point(158, 136);
            this.label160.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(86, 17);
            this.label160.TabIndex = 168;
            // 
            // label159
            // 
            this.label159.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label159.AutoSize = true;
            this.label159.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label159.Location = new System.Drawing.Point(10, 162);
            this.label159.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(79, 17);
            this.label159.TabIndex = 167;
            // 
            // label158
            // 
            this.label158.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label158.AutoSize = true;
            this.label158.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label158.Location = new System.Drawing.Point(10, 136);
            this.label158.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(79, 17);
            this.label158.TabIndex = 178;
            // 
            // label157
            // 
            this.label157.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label157.AutoSize = true;
            this.label157.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label157.Location = new System.Drawing.Point(470, 32);
            this.label157.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(65, 17);
            this.label157.TabIndex = 134;
            // 
            // label156
            // 
            this.label156.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label156.AutoSize = true;
            this.label156.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label156.Location = new System.Drawing.Point(477, 6);
            this.label156.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(52, 17);
            this.label156.TabIndex = 134;
            // 
            // label155
            // 
            this.label155.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label155.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label155.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label155.Location = new System.Drawing.Point(557, 29);
            this.label155.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(43, 23);
            this.label155.TabIndex = 129;
            this.label155.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label154
            // 
            this.label154.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label154.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label154.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label154.Location = new System.Drawing.Point(557, 4);
            this.label154.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(43, 21);
            this.label154.TabIndex = 129;
            this.label154.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label153
            // 
            this.label153.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label153.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label153.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label153.Location = new System.Drawing.Point(104, 4);
            this.label153.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(43, 21);
            this.label153.TabIndex = 125;
            this.label153.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label152
            // 
            this.label152.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label152.AutoSize = true;
            this.label152.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label152.Location = new System.Drawing.Point(158, 58);
            this.label152.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(86, 17);
            this.label152.TabIndex = 137;
            // 
            // label151
            // 
            this.label151.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label151.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label151.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label151.Location = new System.Drawing.Point(104, 29);
            this.label151.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(43, 23);
            this.label151.TabIndex = 148;
            this.label151.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label150
            // 
            this.label150.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label150.AutoSize = true;
            this.label150.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label150.Location = new System.Drawing.Point(7, 32);
            this.label150.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(86, 17);
            this.label150.TabIndex = 126;
            // 
            // label149
            // 
            this.label149.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label149.AutoSize = true;
            this.label149.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label149.Location = new System.Drawing.Point(158, 110);
            this.label149.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(86, 17);
            this.label149.TabIndex = 165;
            // 
            // label148
            // 
            this.label148.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label148.AutoSize = true;
            this.label148.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label148.Location = new System.Drawing.Point(7, 110);
            this.label148.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(86, 17);
            this.label148.TabIndex = 158;
            // 
            // label147
            // 
            this.label147.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label147.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label147.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label147.Location = new System.Drawing.Point(104, 107);
            this.label147.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(43, 22);
            this.label147.TabIndex = 162;
            this.label147.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label146
            // 
            this.label146.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label146.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label146.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label146.Location = new System.Drawing.Point(104, 82);
            this.label146.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(43, 21);
            this.label146.TabIndex = 147;
            this.label146.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label145
            // 
            this.label145.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label145.AutoSize = true;
            this.label145.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label145.Location = new System.Drawing.Point(158, 84);
            this.label145.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(86, 17);
            this.label145.TabIndex = 145;
            // 
            // label144
            // 
            this.label144.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label144.AutoSize = true;
            this.label144.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label144.Location = new System.Drawing.Point(7, 84);
            this.label144.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(86, 17);
            this.label144.TabIndex = 144;
            // 
            // label143
            // 
            this.label143.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label143.AutoSize = true;
            this.label143.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label143.Location = new System.Drawing.Point(7, 58);
            this.label143.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(86, 17);
            this.label143.TabIndex = 132;
            // 
            // label142
            // 
            this.label142.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label142.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label142.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label142.Location = new System.Drawing.Point(104, 56);
            this.label142.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(43, 21);
            this.label142.TabIndex = 131;
            this.label142.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label141
            // 
            this.label141.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label141.AutoSize = true;
            this.label141.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label141.Location = new System.Drawing.Point(7, 6);
            this.label141.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(86, 17);
            this.label141.TabIndex = 115;
            // 
            // label140
            // 
            this.label140.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label140.AutoSize = true;
            this.label140.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label140.Location = new System.Drawing.Point(158, 32);
            this.label140.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(86, 17);
            this.label140.TabIndex = 176;
            // 
            // label139
            // 
            this.label139.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label139.AutoSize = true;
            this.label139.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label139.Location = new System.Drawing.Point(158, 6);
            this.label139.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(86, 17);
            this.label139.TabIndex = 177;
            // 
            // label138
            // 
            this.label138.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label138.AutoSize = true;
            this.label138.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label138.Location = new System.Drawing.Point(614, 6);
            this.label138.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(80, 17);
            this.label138.TabIndex = 188;
            // 
            // label137
            // 
            this.label137.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label137.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label137.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label137.Location = new System.Drawing.Point(708, 4);
            this.label137.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(47, 21);
            this.label137.TabIndex = 189;
            this.label137.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label136
            // 
            this.label136.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label136.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label136.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label136.Location = new System.Drawing.Point(708, 30);
            this.label136.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(47, 21);
            this.label136.TabIndex = 190;
            this.label136.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label135
            // 
            this.label135.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label135.AutoSize = true;
            this.label135.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label135.Location = new System.Drawing.Point(620, 110);
            this.label135.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(68, 17);
            this.label135.TabIndex = 191;
            // 
            // label50
            // 
            this.label50.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label50.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label50.Location = new System.Drawing.Point(708, 108);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(47, 21);
            this.label50.TabIndex = 192;
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label269
            // 
            this.label269.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label269.AutoSize = true;
            this.label269.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label269.ForeColor = System.Drawing.Color.Red;
            this.label269.Location = new System.Drawing.Point(199, 5);
            this.label269.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label269.Name = "label269";
            this.label269.Size = new System.Drawing.Size(56, 17);
            this.label269.TabIndex = 178;
            // 
            // label268
            // 
            this.label268.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label268.AutoSize = true;
            this.label268.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label268.ForeColor = System.Drawing.Color.Red;
            this.label268.Location = new System.Drawing.Point(96, 87);
            this.label268.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label268.Name = "label268";
            this.label268.Size = new System.Drawing.Size(80, 17);
            this.label268.TabIndex = 174;
            // 
            // label267
            // 
            this.label267.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label267.AutoSize = true;
            this.label267.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label267.ForeColor = System.Drawing.Color.Red;
            this.label267.Location = new System.Drawing.Point(187, 32);
            this.label267.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label267.Name = "label267";
            this.label267.Size = new System.Drawing.Size(80, 17);
            this.label267.TabIndex = 176;
            // 
            // label266
            // 
            this.label266.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label266.AutoSize = true;
            this.label266.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label266.ForeColor = System.Drawing.Color.Red;
            this.label266.Location = new System.Drawing.Point(108, 59);
            this.label266.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label266.Name = "label266";
            this.label266.Size = new System.Drawing.Size(57, 17);
            this.label266.TabIndex = 173;
            // 
            // label265
            // 
            this.label265.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label265.AutoSize = true;
            this.label265.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label265.ForeColor = System.Drawing.Color.Red;
            this.label265.Location = new System.Drawing.Point(108, 32);
            this.label265.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label265.Name = "label265";
            this.label265.Size = new System.Drawing.Size(56, 17);
            this.label265.TabIndex = 172;
            // 
            // label264
            // 
            this.label264.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label264.AutoSize = true;
            this.label264.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label264.ForeColor = System.Drawing.Color.Red;
            this.label264.Location = new System.Drawing.Point(108, 5);
            this.label264.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label264.Name = "label264";
            this.label264.Size = new System.Drawing.Size(56, 17);
            this.label264.TabIndex = 171;
            // 
            // label263
            // 
            this.label263.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label263.AutoSize = true;
            this.label263.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label263.ForeColor = System.Drawing.Color.Red;
            this.label263.Location = new System.Drawing.Point(29, 59);
            this.label263.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label263.Name = "label263";
            this.label263.Size = new System.Drawing.Size(32, 17);
            this.label263.TabIndex = 170;
            // 
            // label262
            // 
            this.label262.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label262.AutoSize = true;
            this.label262.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label262.ForeColor = System.Drawing.Color.Red;
            this.label262.Location = new System.Drawing.Point(17, 32);
            this.label262.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label262.Name = "label262";
            this.label262.Size = new System.Drawing.Size(56, 17);
            this.label262.TabIndex = 169;
            // 
            // label261
            // 
            this.label261.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label261.AutoSize = true;
            this.label261.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label261.ForeColor = System.Drawing.Color.Red;
            this.label261.Location = new System.Drawing.Point(17, 5);
            this.label261.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label261.Name = "label261";
            this.label261.Size = new System.Drawing.Size(56, 17);
            this.label261.TabIndex = 168;
            // 
            // label260
            // 
            this.label260.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label260.AutoSize = true;
            this.label260.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label260.ForeColor = System.Drawing.Color.Red;
            this.label260.Location = new System.Drawing.Point(29, 87);
            this.label260.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label260.Name = "label260";
            this.label260.Size = new System.Drawing.Size(32, 17);
            this.label260.TabIndex = 179;
            // 
            // label259
            // 
            this.label259.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label259.AutoSize = true;
            this.label259.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label259.ForeColor = System.Drawing.Color.Red;
            this.label259.Location = new System.Drawing.Point(291, 5);
            this.label259.Name = "label259";
            this.label259.Size = new System.Drawing.Size(56, 17);
            this.label259.TabIndex = 27;
            this.label259.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label258
            // 
            this.label258.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label258.AutoSize = true;
            this.label258.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label258.ForeColor = System.Drawing.Color.Red;
            this.label258.Location = new System.Drawing.Point(199, 59);
            this.label258.Name = "label258";
            this.label258.Size = new System.Drawing.Size(56, 17);
            this.label258.TabIndex = 26;
            this.label258.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label257
            // 
            this.label257.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label257.AutoSize = true;
            this.label257.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label257.ForeColor = System.Drawing.Color.Red;
            this.label257.Location = new System.Drawing.Point(187, 32);
            this.label257.Name = "label257";
            this.label257.Size = new System.Drawing.Size(80, 17);
            this.label257.TabIndex = 28;
            this.label257.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label256
            // 
            this.label256.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label256.AutoSize = true;
            this.label256.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label256.ForeColor = System.Drawing.Color.Red;
            this.label256.Location = new System.Drawing.Point(199, 5);
            this.label256.Name = "label256";
            this.label256.Size = new System.Drawing.Size(56, 17);
            this.label256.TabIndex = 25;
            this.label256.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label255
            // 
            this.label255.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label255.AutoSize = true;
            this.label255.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label255.ForeColor = System.Drawing.Color.Red;
            this.label255.Location = new System.Drawing.Point(108, 59);
            this.label255.Name = "label255";
            this.label255.Size = new System.Drawing.Size(57, 17);
            this.label255.TabIndex = 24;
            this.label255.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label254
            // 
            this.label254.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label254.AutoSize = true;
            this.label254.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label254.ForeColor = System.Drawing.Color.Red;
            this.label254.Location = new System.Drawing.Point(29, 59);
            this.label254.Name = "label254";
            this.label254.Size = new System.Drawing.Size(32, 17);
            this.label254.TabIndex = 23;
            this.label254.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label253
            // 
            this.label253.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label253.AutoSize = true;
            this.label253.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label253.ForeColor = System.Drawing.Color.Red;
            this.label253.Location = new System.Drawing.Point(108, 32);
            this.label253.Name = "label253";
            this.label253.Size = new System.Drawing.Size(56, 17);
            this.label253.TabIndex = 21;
            this.label253.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label252
            // 
            this.label252.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label252.AutoSize = true;
            this.label252.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label252.ForeColor = System.Drawing.Color.Red;
            this.label252.Location = new System.Drawing.Point(108, 5);
            this.label252.Name = "label252";
            this.label252.Size = new System.Drawing.Size(56, 17);
            this.label252.TabIndex = 22;
            this.label252.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label251
            // 
            this.label251.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label251.AutoSize = true;
            this.label251.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label251.ForeColor = System.Drawing.Color.Red;
            this.label251.Location = new System.Drawing.Point(17, 32);
            this.label251.Name = "label251";
            this.label251.Size = new System.Drawing.Size(56, 17);
            this.label251.TabIndex = 20;
            this.label251.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label250
            // 
            this.label250.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label250.AutoSize = true;
            this.label250.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label250.ForeColor = System.Drawing.Color.Red;
            this.label250.Location = new System.Drawing.Point(17, 5);
            this.label250.Name = "label250";
            this.label250.Size = new System.Drawing.Size(56, 17);
            this.label250.TabIndex = 19;
            this.label250.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label249
            // 
            this.label249.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label249.AutoSize = true;
            this.label249.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label249.ForeColor = System.Drawing.Color.Red;
            this.label249.Location = new System.Drawing.Point(96, 87);
            this.label249.Name = "label249";
            this.label249.Size = new System.Drawing.Size(80, 17);
            this.label249.TabIndex = 32;
            this.label249.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label248
            // 
            this.label248.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label248.AutoSize = true;
            this.label248.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label248.ForeColor = System.Drawing.Color.Red;
            this.label248.Location = new System.Drawing.Point(211, 87);
            this.label248.Name = "label248";
            this.label248.Size = new System.Drawing.Size(32, 17);
            this.label248.TabIndex = 33;
            this.label248.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label247
            // 
            this.label247.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label247.AutoSize = true;
            this.label247.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label247.ForeColor = System.Drawing.Color.Red;
            this.label247.Location = new System.Drawing.Point(5, 87);
            this.label247.Name = "label247";
            this.label247.Size = new System.Drawing.Size(80, 17);
            this.label247.TabIndex = 34;
            this.label247.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label246
            // 
            this.label246.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label246.AutoSize = true;
            this.label246.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label246.ForeColor = System.Drawing.Color.Red;
            this.label246.Location = new System.Drawing.Point(187, 87);
            this.label246.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label246.Name = "label246";
            this.label246.Size = new System.Drawing.Size(80, 17);
            this.label246.TabIndex = 181;
            // 
            // label245
            // 
            this.label245.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label245.AutoSize = true;
            this.label245.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label245.ForeColor = System.Drawing.Color.Red;
            this.label245.Location = new System.Drawing.Point(96, 87);
            this.label245.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label245.Name = "label245";
            this.label245.Size = new System.Drawing.Size(80, 17);
            this.label245.TabIndex = 180;
            // 
            // label244
            // 
            this.label244.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label244.AutoSize = true;
            this.label244.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label244.ForeColor = System.Drawing.Color.Red;
            this.label244.Location = new System.Drawing.Point(199, 59);
            this.label244.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label244.Name = "label244";
            this.label244.Size = new System.Drawing.Size(56, 17);
            this.label244.TabIndex = 174;
            // 
            // label243
            // 
            this.label243.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label243.AutoSize = true;
            this.label243.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label243.ForeColor = System.Drawing.Color.Red;
            this.label243.Location = new System.Drawing.Point(199, 5);
            this.label243.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label243.Name = "label243";
            this.label243.Size = new System.Drawing.Size(56, 17);
            this.label243.TabIndex = 178;
            // 
            // label242
            // 
            this.label242.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label242.AutoSize = true;
            this.label242.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label242.ForeColor = System.Drawing.Color.Red;
            this.label242.Location = new System.Drawing.Point(187, 32);
            this.label242.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label242.Name = "label242";
            this.label242.Size = new System.Drawing.Size(80, 17);
            this.label242.TabIndex = 176;
            // 
            // label241
            // 
            this.label241.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label241.AutoSize = true;
            this.label241.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label241.ForeColor = System.Drawing.Color.Red;
            this.label241.Location = new System.Drawing.Point(108, 59);
            this.label241.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label241.Name = "label241";
            this.label241.Size = new System.Drawing.Size(57, 17);
            this.label241.TabIndex = 173;
            // 
            // label240
            // 
            this.label240.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label240.AutoSize = true;
            this.label240.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label240.ForeColor = System.Drawing.Color.Red;
            this.label240.Location = new System.Drawing.Point(108, 32);
            this.label240.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label240.Name = "label240";
            this.label240.Size = new System.Drawing.Size(56, 17);
            this.label240.TabIndex = 172;
            // 
            // label239
            // 
            this.label239.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label239.AutoSize = true;
            this.label239.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label239.ForeColor = System.Drawing.Color.Red;
            this.label239.Location = new System.Drawing.Point(108, 5);
            this.label239.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label239.Name = "label239";
            this.label239.Size = new System.Drawing.Size(56, 17);
            this.label239.TabIndex = 171;
            // 
            // label238
            // 
            this.label238.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label238.AutoSize = true;
            this.label238.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label238.ForeColor = System.Drawing.Color.Red;
            this.label238.Location = new System.Drawing.Point(29, 59);
            this.label238.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label238.Name = "label238";
            this.label238.Size = new System.Drawing.Size(32, 17);
            this.label238.TabIndex = 170;
            // 
            // label237
            // 
            this.label237.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label237.AutoSize = true;
            this.label237.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label237.ForeColor = System.Drawing.Color.Red;
            this.label237.Location = new System.Drawing.Point(17, 32);
            this.label237.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label237.Name = "label237";
            this.label237.Size = new System.Drawing.Size(56, 17);
            this.label237.TabIndex = 169;
            // 
            // label236
            // 
            this.label236.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label236.AutoSize = true;
            this.label236.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label236.ForeColor = System.Drawing.Color.Red;
            this.label236.Location = new System.Drawing.Point(17, 5);
            this.label236.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label236.Name = "label236";
            this.label236.Size = new System.Drawing.Size(56, 17);
            this.label236.TabIndex = 168;
            // 
            // label235
            // 
            this.label235.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label235.AutoSize = true;
            this.label235.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label235.ForeColor = System.Drawing.Color.Red;
            this.label235.Location = new System.Drawing.Point(29, 87);
            this.label235.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label235.Name = "label235";
            this.label235.Size = new System.Drawing.Size(32, 17);
            this.label235.TabIndex = 179;
            // 
            // label234
            // 
            this.label234.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label234.AutoSize = true;
            this.label234.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label234.ForeColor = System.Drawing.Color.Red;
            this.label234.Location = new System.Drawing.Point(291, 5);
            this.label234.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label234.Name = "label234";
            this.label234.Size = new System.Drawing.Size(56, 17);
            this.label234.TabIndex = 182;
            // 
            // label233
            // 
            this.label233.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label233.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label233.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label233.ForeColor = System.Drawing.Color.Green;
            this.label233.Location = new System.Drawing.Point(145, 17);
            this.label233.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label233.Name = "label233";
            this.label233.Size = new System.Drawing.Size(72, 21);
            this.label233.TabIndex = 125;
            this.label233.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label232
            // 
            this.label232.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label232.AutoSize = true;
            this.label232.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label232.ForeColor = System.Drawing.Color.Green;
            this.label232.Location = new System.Drawing.Point(262, 19);
            this.label232.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label232.Name = "label232";
            this.label232.Size = new System.Drawing.Size(80, 17);
            this.label232.TabIndex = 134;
            // 
            // label231
            // 
            this.label231.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label231.AutoSize = true;
            this.label231.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label231.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label231.Location = new System.Drawing.Point(255, 73);
            this.label231.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label231.Name = "label231";
            this.label231.Size = new System.Drawing.Size(95, 17);
            this.label231.TabIndex = 135;
            this.label231.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label230
            // 
            this.label230.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label230.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label230.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label230.ForeColor = System.Drawing.Color.Green;
            this.label230.Location = new System.Drawing.Point(145, 71);
            this.label230.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label230.Name = "label230";
            this.label230.Size = new System.Drawing.Size(72, 21);
            this.label230.TabIndex = 148;
            this.label230.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label229
            // 
            this.label229.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label229.AutoSize = true;
            this.label229.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label229.ForeColor = System.Drawing.Color.Green;
            this.label229.Location = new System.Drawing.Point(33, 73);
            this.label229.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label229.Name = "label229";
            this.label229.Size = new System.Drawing.Size(56, 17);
            this.label229.TabIndex = 126;
            // 
            // label228
            // 
            this.label228.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label228.AutoSize = true;
            this.label228.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label228.ForeColor = System.Drawing.Color.Green;
            this.label228.Location = new System.Drawing.Point(33, 19);
            this.label228.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label228.Name = "label228";
            this.label228.Size = new System.Drawing.Size(56, 17);
            this.label228.TabIndex = 115;
            // 
            // label227
            // 
            this.label227.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label227.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label227.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label227.Location = new System.Drawing.Point(666, 133);
            this.label227.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label227.Name = "label227";
            this.label227.Size = new System.Drawing.Size(74, 20);
            this.label227.TabIndex = 162;
            this.label227.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label226
            // 
            this.label226.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label226.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label226.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label226.Location = new System.Drawing.Point(428, 133);
            this.label226.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label226.Name = "label226";
            this.label226.Size = new System.Drawing.Size(71, 20);
            this.label226.TabIndex = 162;
            this.label226.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label225
            // 
            this.label225.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label225.AutoSize = true;
            this.label225.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label225.Location = new System.Drawing.Point(285, 134);
            this.label225.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label225.Name = "label225";
            this.label225.Size = new System.Drawing.Size(80, 17);
            this.label225.TabIndex = 158;
            // 
            // label224
            // 
            this.label224.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label224.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label224.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label224.Location = new System.Drawing.Point(666, 108);
            this.label224.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label224.Name = "label224";
            this.label224.Size = new System.Drawing.Size(74, 21);
            this.label224.TabIndex = 129;
            this.label224.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label223
            // 
            this.label223.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label223.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label223.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label223.Location = new System.Drawing.Point(666, 82);
            this.label223.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label223.Name = "label223";
            this.label223.Size = new System.Drawing.Size(74, 21);
            this.label223.TabIndex = 129;
            this.label223.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label222
            // 
            this.label222.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label222.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label222.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label222.Location = new System.Drawing.Point(666, 56);
            this.label222.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label222.Name = "label222";
            this.label222.Size = new System.Drawing.Size(74, 21);
            this.label222.TabIndex = 129;
            this.label222.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label221
            // 
            this.label221.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label221.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label221.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label221.Location = new System.Drawing.Point(666, 30);
            this.label221.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label221.Name = "label221";
            this.label221.Size = new System.Drawing.Size(74, 21);
            this.label221.TabIndex = 129;
            this.label221.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label220
            // 
            this.label220.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label220.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label220.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label220.Location = new System.Drawing.Point(666, 4);
            this.label220.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label220.Name = "label220";
            this.label220.Size = new System.Drawing.Size(74, 21);
            this.label220.TabIndex = 129;
            this.label220.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label219
            // 
            this.label219.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label219.AutoSize = true;
            this.label219.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label219.Location = new System.Drawing.Point(548, 84);
            this.label219.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label219.Name = "label219";
            this.label219.Size = new System.Drawing.Size(68, 17);
            this.label219.TabIndex = 134;
            // 
            // label218
            // 
            this.label218.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label218.AutoSize = true;
            this.label218.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label218.Location = new System.Drawing.Point(524, 58);
            this.label218.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label218.Name = "label218";
            this.label218.Size = new System.Drawing.Size(116, 17);
            this.label218.TabIndex = 134;
            // 
            // label217
            // 
            this.label217.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label217.AutoSize = true;
            this.label217.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label217.Location = new System.Drawing.Point(560, 32);
            this.label217.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label217.Name = "label217";
            this.label217.Size = new System.Drawing.Size(44, 17);
            this.label217.TabIndex = 134;
            // 
            // label216
            // 
            this.label216.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label216.AutoSize = true;
            this.label216.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label216.Location = new System.Drawing.Point(536, 6);
            this.label216.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label216.Name = "label216";
            this.label216.Size = new System.Drawing.Size(92, 17);
            this.label216.TabIndex = 134;
            // 
            // label215
            // 
            this.label215.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label215.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label215.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label215.Location = new System.Drawing.Point(150, 4);
            this.label215.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label215.Name = "label215";
            this.label215.Size = new System.Drawing.Size(72, 21);
            this.label215.TabIndex = 125;
            this.label215.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label214
            // 
            this.label214.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label214.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label214.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label214.Location = new System.Drawing.Point(428, 56);
            this.label214.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label214.Name = "label214";
            this.label214.Size = new System.Drawing.Size(71, 21);
            this.label214.TabIndex = 155;
            this.label214.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label213
            // 
            this.label213.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label213.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label213.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label213.Location = new System.Drawing.Point(428, 82);
            this.label213.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label213.Name = "label213";
            this.label213.Size = new System.Drawing.Size(71, 21);
            this.label213.TabIndex = 153;
            this.label213.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label212
            // 
            this.label212.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label212.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label212.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label212.Location = new System.Drawing.Point(428, 108);
            this.label212.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label212.Name = "label212";
            this.label212.Size = new System.Drawing.Size(71, 21);
            this.label212.TabIndex = 143;
            this.label212.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label211
            // 
            this.label211.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label211.AutoSize = true;
            this.label211.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label211.Location = new System.Drawing.Point(257, 58);
            this.label211.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label211.Name = "label211";
            this.label211.Size = new System.Drawing.Size(137, 17);
            this.label211.TabIndex = 137;
            // 
            // label210
            // 
            this.label210.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label210.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label210.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label210.Location = new System.Drawing.Point(428, 30);
            this.label210.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label210.Name = "label210";
            this.label210.Size = new System.Drawing.Size(71, 21);
            this.label210.TabIndex = 154;
            this.label210.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label209
            // 
            this.label209.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label209.AutoSize = true;
            this.label209.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label209.Location = new System.Drawing.Point(247, 6);
            this.label209.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label209.Name = "label209";
            this.label209.Size = new System.Drawing.Size(157, 17);
            this.label209.TabIndex = 134;
            // 
            // label208
            // 
            this.label208.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label208.AutoSize = true;
            this.label208.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label208.Location = new System.Drawing.Point(252, 32);
            this.label208.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label208.Name = "label208";
            this.label208.Size = new System.Drawing.Size(147, 17);
            this.label208.TabIndex = 135;
            this.label208.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label207
            // 
            this.label207.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label207.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label207.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label207.Location = new System.Drawing.Point(429, 4);
            this.label207.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label207.Name = "label207";
            this.label207.Size = new System.Drawing.Size(70, 21);
            this.label207.TabIndex = 129;
            this.label207.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label206
            // 
            this.label206.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label206.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label206.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label206.Location = new System.Drawing.Point(150, 30);
            this.label206.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label206.Name = "label206";
            this.label206.Size = new System.Drawing.Size(72, 21);
            this.label206.TabIndex = 148;
            this.label206.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label205
            // 
            this.label205.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label205.AutoSize = true;
            this.label205.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label205.Location = new System.Drawing.Point(19, 32);
            this.label205.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label205.Name = "label205";
            this.label205.Size = new System.Drawing.Size(95, 17);
            this.label205.TabIndex = 126;
            // 
            // label204
            // 
            this.label204.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label204.AutoSize = true;
            this.label204.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label204.Location = new System.Drawing.Point(285, 110);
            this.label204.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label204.Name = "label204";
            this.label204.Size = new System.Drawing.Size(80, 17);
            this.label204.TabIndex = 165;
            // 
            // label203
            // 
            this.label203.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label203.AutoSize = true;
            this.label203.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label203.Location = new System.Drawing.Point(19, 110);
            this.label203.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label203.Name = "label203";
            this.label203.Size = new System.Drawing.Size(95, 17);
            this.label203.TabIndex = 158;
            // 
            // label202
            // 
            this.label202.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label202.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label202.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label202.Location = new System.Drawing.Point(150, 108);
            this.label202.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label202.Name = "label202";
            this.label202.Size = new System.Drawing.Size(72, 21);
            this.label202.TabIndex = 162;
            this.label202.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label201
            // 
            this.label201.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label201.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label201.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label201.Location = new System.Drawing.Point(150, 82);
            this.label201.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label201.Name = "label201";
            this.label201.Size = new System.Drawing.Size(72, 21);
            this.label201.TabIndex = 147;
            this.label201.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label200
            // 
            this.label200.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label200.AutoSize = true;
            this.label200.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label200.Location = new System.Drawing.Point(281, 84);
            this.label200.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label200.Name = "label200";
            this.label200.Size = new System.Drawing.Size(89, 17);
            this.label200.TabIndex = 145;
            // 
            // label199
            // 
            this.label199.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label199.AutoSize = true;
            this.label199.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label199.Location = new System.Drawing.Point(7, 84);
            this.label199.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label199.Name = "label199";
            this.label199.Size = new System.Drawing.Size(119, 17);
            this.label199.TabIndex = 144;
            // 
            // label198
            // 
            this.label198.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label198.AutoSize = true;
            this.label198.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label198.Location = new System.Drawing.Point(7, 58);
            this.label198.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label198.Name = "label198";
            this.label198.Size = new System.Drawing.Size(119, 17);
            this.label198.TabIndex = 132;
            // 
            // label197
            // 
            this.label197.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label197.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label197.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label197.Location = new System.Drawing.Point(150, 56);
            this.label197.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label197.Name = "label197";
            this.label197.Size = new System.Drawing.Size(72, 21);
            this.label197.TabIndex = 131;
            this.label197.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label196
            // 
            this.label196.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label196.AutoSize = true;
            this.label196.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label196.Location = new System.Drawing.Point(38, 6);
            this.label196.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label196.Name = "label196";
            this.label196.Size = new System.Drawing.Size(56, 17);
            this.label196.TabIndex = 115;
            // 
            // timer4
            // 
            this.timer4.Interval = 2000;
            this.timer4.Tick += new System.EventHandler(this.Timer4_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1032, 776);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KS5045上位机";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.CHGSysStates.ResumeLayout(false);
            this.CHGSysStates.PerformLayout();
            this.SecondWarning.ResumeLayout(false);
            this.SecondWarning.PerformLayout();
            this.SecondStorage.ResumeLayout(false);
            this.SecondStorage.PerformLayout();
            this.SoftWarning.ResumeLayout(false);
            this.SoftWarning.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem SYSTEM;
        private System.Windows.Forms.ToolStripMenuItem OpenPortTool;
        private System.Windows.Forms.ToolStripMenuItem ClosePortTool;
        private System.Windows.Forms.ToolStripMenuItem ReseachTool;
 //       private System.Windows.Forms.ToolStripComboBox cmPort;
        private System.Windows.Forms.ToolStripMenuItem HelpTool;
        private System.Windows.Forms.ToolStripMenuItem AboutMeTool;
        private System.Windows.Forms.ToolStripMenuItem ExitTool;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SysStatu;
        private System.Windows.Forms.ToolStripStatusLabel CommStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslDate;
        private System.Windows.Forms.ToolStripStatusLabel nulllabel;
        private System.IO.Ports.SerialPort sComm2;
        private System.Windows.Forms.ToolStripComboBox combps;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label BAT_BMS_APP_SW_VER;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label BAT_BMS_UN_SW_VER;
        private System.Windows.Forms.Label BAT_BMS_CP_VER;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label BAT_BMS_HW_VER;
        private System.Windows.Forms.Label BAT_MAX_CHARGING_VOLTAGE;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label BAT_MIN_DISCHARGING_VOLTAGE;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.Label BAT_MAX_TEMP;
        private System.Windows.Forms.Label BAT_RATED_CAPACITY;
        private System.Windows.Forms.Label BAT_MAX_CHARGING_CURRENT;
        private System.Windows.Forms.Label BAT_SUPPLIER;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.Label BAT_RATED_CYCLE_INDEX;
        private System.Windows.Forms.Label BAT_CELLS_NUM;
        private System.Windows.Forms.Label BAT_TEMP_SENSOR_NUM;
        private System.Windows.Forms.Label BAT_TYPE;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.Label BAT_MIN_TEMP;
        private System.Windows.Forms.TableLayoutPanel CHGSysStates;
        private System.Windows.Forms.Label SysCharging;
        private System.Windows.Forms.Label SysHeating;
        private System.Windows.Forms.Label SysStopHeating;
        private System.Windows.Forms.Label SysOcc3A;
        private System.Windows.Forms.Label SysHeatCharging;
        private System.Windows.Forms.Label SysNoCharging;
        private System.Windows.Forms.TableLayoutPanel SecondWarning;
        private System.Windows.Forms.Label BqScd;
        private System.Windows.Forms.Label BqUt;
        private System.Windows.Forms.Label BqOv;
        private System.Windows.Forms.Label BqUv;
        private System.Windows.Forms.Label BqOt;
        private System.Windows.Forms.Label BqOcc;
        private System.Windows.Forms.Label BqOcd;
        private System.Windows.Forms.Label BqUSoc;
        private System.Windows.Forms.Label BqROc;
        private System.Windows.Forms.Label BqImT;
        private System.Windows.Forms.Label BqErr;
        private System.Windows.Forms.Label BqVima;
        private System.Windows.Forms.Label BqSUv;
        private System.Windows.Forms.TableLayoutPanel SecondStorage;
        private System.Windows.Forms.Label RecOv;
        private System.Windows.Forms.Label RecUv;
        private System.Windows.Forms.Label RecOcc;
        private System.Windows.Forms.Label RecOcd;
        private System.Windows.Forms.Label RecOt;
        private System.Windows.Forms.Label RecUSoc;
        private System.Windows.Forms.Label RecImT;
        private System.Windows.Forms.Label RecROc;
        private System.Windows.Forms.Label RecErr;
        private System.Windows.Forms.Label RecScd;
        private System.Windows.Forms.Label RecVima;
        private System.Windows.Forms.Label RecUt;
        private System.Windows.Forms.Label RecSUv;
        private System.Windows.Forms.TableLayoutPanel SoftWarning;
        private System.Windows.Forms.Label SoftUt;
        private System.Windows.Forms.Label SoftOv;
        private System.Windows.Forms.Label SoftUv;
        private System.Windows.Forms.Label SoftOt;
        private System.Windows.Forms.Label SoftOcc;
        private System.Windows.Forms.Label softOcd;
        private System.Windows.Forms.Label SoftUSoc;
        private System.Windows.Forms.Label SoftROc;
        private System.Windows.Forms.Label SoftVima;
        private System.Windows.Forms.Label SoftImT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lifetimes;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label CELL_MIX_VOLTAGE;
        private System.Windows.Forms.Label CELL_MAX_VOLTAGE;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cell3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label cell4;
        private System.Windows.Forms.Label cell5;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label cell2;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label cell1;
        private System.Windows.Forms.Label soc;
        private System.Windows.Forms.Label current;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label cell13;
        private System.Windows.Forms.Label cell14;
        private System.Windows.Forms.Label cell6;
        private System.Windows.Forms.Label cell7;
        private System.Windows.Forms.Label cell8;
        private System.Windows.Forms.Label cell9;
        private System.Windows.Forms.Label cell10;
        private System.Windows.Forms.Label cell11;
        private System.Windows.Forms.Label cell12;
        private System.Windows.Forms.Label voltage;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label temp_1;
        private System.Windows.Forms.Label temp_2;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label temp_3;
        private System.Windows.Forms.Label temp_4;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label BAT_Capacity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label VDiff;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label CELL_MAX_TEMP;
        private System.Windows.Forms.Label CELL_MIN_TEMP;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label temp_mosfet;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label temp_5;
        private System.Windows.Forms.Label temp_6;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label envtemp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Test_PCM_dischargecurrent;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button Test_taillight;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label195;
        private System.Windows.Forms.Label label194;
        private System.Windows.Forms.Label label193;
        private System.Windows.Forms.Label label192;
        private System.Windows.Forms.Label label191;
        private System.Windows.Forms.Label label190;
        private System.Windows.Forms.Label label189;
        private System.Windows.Forms.Label label188;
        private System.Windows.Forms.Label label187;
        private System.Windows.Forms.Label label186;
        private System.Windows.Forms.Label label185;
        private System.Windows.Forms.Label label184;
        private System.Windows.Forms.Label label183;
        private System.Windows.Forms.Label label182;
        private System.Windows.Forms.Label label181;
        private System.Windows.Forms.Label label180;
        private System.Windows.Forms.Label label179;
        private System.Windows.Forms.Label label178;
        private System.Windows.Forms.Label label177;
        private System.Windows.Forms.Label label176;
        private System.Windows.Forms.Label label175;
        private System.Windows.Forms.Label label174;
        private System.Windows.Forms.Label label173;
        private System.Windows.Forms.Label label172;
        private System.Windows.Forms.Label label171;
        private System.Windows.Forms.Label label170;
        private System.Windows.Forms.Label label169;
        private System.Windows.Forms.Label label168;
        private System.Windows.Forms.Label label167;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.Label label165;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.Label label163;
        private System.Windows.Forms.Label label162;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.Label label159;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.Label label154;
        private System.Windows.Forms.Label label153;
        private System.Windows.Forms.Label label152;
        private System.Windows.Forms.Label label151;
        private System.Windows.Forms.Label label150;
        private System.Windows.Forms.Label label149;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.Label label146;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.Label label138;
        private System.Windows.Forms.Label label137;
        private System.Windows.Forms.Label label136;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label269;
        private System.Windows.Forms.Label label268;
        private System.Windows.Forms.Label label267;
        private System.Windows.Forms.Label label266;
        private System.Windows.Forms.Label label265;
        private System.Windows.Forms.Label label264;
        private System.Windows.Forms.Label label263;
        private System.Windows.Forms.Label label262;
        private System.Windows.Forms.Label label261;
        private System.Windows.Forms.Label label260;
        private System.Windows.Forms.Label label259;
        private System.Windows.Forms.Label label258;
        private System.Windows.Forms.Label label257;
        private System.Windows.Forms.Label label256;
        private System.Windows.Forms.Label label255;
        private System.Windows.Forms.Label label254;
        private System.Windows.Forms.Label label253;
        private System.Windows.Forms.Label label252;
        private System.Windows.Forms.Label label251;
        private System.Windows.Forms.Label label250;
        private System.Windows.Forms.Label label249;
        private System.Windows.Forms.Label label248;
        private System.Windows.Forms.Label label247;
        private System.Windows.Forms.Label label246;
        private System.Windows.Forms.Label label245;
        private System.Windows.Forms.Label label244;
        private System.Windows.Forms.Label label243;
        private System.Windows.Forms.Label label242;
        private System.Windows.Forms.Label label241;
        private System.Windows.Forms.Label label240;
        private System.Windows.Forms.Label label239;
        private System.Windows.Forms.Label label238;
        private System.Windows.Forms.Label label237;
        private System.Windows.Forms.Label label236;
        private System.Windows.Forms.Label label235;
        private System.Windows.Forms.Label label234;
        private System.Windows.Forms.Label label233;
        private System.Windows.Forms.Label label232;
        private System.Windows.Forms.Label label231;
        private System.Windows.Forms.Label label230;
        private System.Windows.Forms.Label label229;
        private System.Windows.Forms.Label label228;
        private System.Windows.Forms.Label label227;
        private System.Windows.Forms.Label label226;
        private System.Windows.Forms.Label label225;
        private System.Windows.Forms.Label label224;
        private System.Windows.Forms.Label label223;
        private System.Windows.Forms.Label label222;
        private System.Windows.Forms.Label label221;
        private System.Windows.Forms.Label label220;
        private System.Windows.Forms.Label label219;
        private System.Windows.Forms.Label label218;
        private System.Windows.Forms.Label label217;
        private System.Windows.Forms.Label label216;
        private System.Windows.Forms.Label label215;
        private System.Windows.Forms.Label label214;
        private System.Windows.Forms.Label label213;
        private System.Windows.Forms.Label label212;
        private System.Windows.Forms.Label label211;
        private System.Windows.Forms.Label label210;
        private System.Windows.Forms.Label label209;
        private System.Windows.Forms.Label label208;
        private System.Windows.Forms.Label label207;
        private System.Windows.Forms.Label label206;
        private System.Windows.Forms.Label label205;
        private System.Windows.Forms.Label label204;
        private System.Windows.Forms.Label label203;
        private System.Windows.Forms.Label label202;
        private System.Windows.Forms.Label label201;
        private System.Windows.Forms.Label label200;
        private System.Windows.Forms.Label label199;
        private System.Windows.Forms.Label label198;
        private System.Windows.Forms.Label label197;
        private System.Windows.Forms.Label label196;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label CHG_temp_mosfet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DSC_temp_mosfet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox SAVE_DATA;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

