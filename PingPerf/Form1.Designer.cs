namespace PingPerf
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menu_Status = new System.Windows.Forms.StatusStrip();
            this.menu_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_panel = new System.Windows.Forms.TabControl();
            this.tab_icmp = new System.Windows.Forms.TabPage();
            this.chart_reply_loss = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.text_ping_count = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chart_reply_left = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_STOP = new System.Windows.Forms.Button();
            this.text_debug = new System.Windows.Forms.RichTextBox();
            this.button_Go = new System.Windows.Forms.Button();
            this.text_hostname_l = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menu_Main.SuspendLayout();
            this.tab_panel.SuspendLayout();
            this.tab_icmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_reply_loss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_reply_left)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_Status
            // 
            this.menu_Status.Location = new System.Drawing.Point(0, 626);
            this.menu_Status.Name = "menu_Status";
            this.menu_Status.Size = new System.Drawing.Size(846, 22);
            this.menu_Status.TabIndex = 0;
            this.menu_Status.Text = "statusStrip1";
            // 
            // menu_Main
            // 
            this.menu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menu_Main.Location = new System.Drawing.Point(0, 0);
            this.menu_Main.Name = "menu_Main";
            this.menu_Main.Size = new System.Drawing.Size(846, 24);
            this.menu_Main.TabIndex = 2;
            this.menu_Main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tab_panel
            // 
            this.tab_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_panel.Controls.Add(this.tab_icmp);
            this.tab_panel.Location = new System.Drawing.Point(0, 27);
            this.tab_panel.Name = "tab_panel";
            this.tab_panel.SelectedIndex = 0;
            this.tab_panel.Size = new System.Drawing.Size(846, 609);
            this.tab_panel.TabIndex = 3;
            // 
            // tab_icmp
            // 
            this.tab_icmp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tab_icmp.Controls.Add(this.chart_reply_loss);
            this.tab_icmp.Controls.Add(this.text_ping_count);
            this.tab_icmp.Controls.Add(this.label2);
            this.tab_icmp.Controls.Add(this.chart_reply_left);
            this.tab_icmp.Controls.Add(this.button_STOP);
            this.tab_icmp.Controls.Add(this.text_debug);
            this.tab_icmp.Controls.Add(this.button_Go);
            this.tab_icmp.Controls.Add(this.text_hostname_l);
            this.tab_icmp.Controls.Add(this.label1);
            this.tab_icmp.Location = new System.Drawing.Point(4, 22);
            this.tab_icmp.Name = "tab_icmp";
            this.tab_icmp.Padding = new System.Windows.Forms.Padding(3);
            this.tab_icmp.Size = new System.Drawing.Size(838, 583);
            this.tab_icmp.TabIndex = 0;
            this.tab_icmp.Text = "ICMP";
            // 
            // chart_reply_loss
            // 
            this.chart_reply_loss.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_reply_loss.BackColor = System.Drawing.SystemColors.Control;
            this.chart_reply_loss.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 1D;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart_reply_loss.ChartAreas.Add(chartArea1);
            this.chart_reply_loss.Location = new System.Drawing.Point(12, 351);
            this.chart_reply_loss.Name = "chart_reply_loss";
            this.chart_reply_loss.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.MarkerSize = 0;
            series1.Name = "Series1";
            this.chart_reply_loss.Series.Add(series1);
            this.chart_reply_loss.Size = new System.Drawing.Size(812, 121);
            this.chart_reply_loss.TabIndex = 13;
            this.chart_reply_loss.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Packet loss";
            this.chart_reply_loss.Titles.Add(title1);
            // 
            // text_ping_count
            // 
            this.text_ping_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_ping_count.Location = new System.Drawing.Point(73, 3);
            this.text_ping_count.Name = "text_ping_count";
            this.text_ping_count.Size = new System.Drawing.Size(69, 26);
            this.text_ping_count.TabIndex = 11;
            this.text_ping_count.Text = "1000";
            this.text_ping_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Count";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chart_reply_left
            // 
            this.chart_reply_left.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_reply_left.BackColor = System.Drawing.SystemColors.Control;
            this.chart_reply_left.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX.Maximum = 100D;
            chartArea2.AxisX.Minimum = 1D;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX2.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chart_reply_left.ChartAreas.Add(chartArea2);
            this.chart_reply_left.Location = new System.Drawing.Point(12, 97);
            this.chart_reply_left.Name = "chart_reply_left";
            this.chart_reply_left.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.MarkerSize = 0;
            series2.Name = "Series1";
            this.chart_reply_left.Series.Add(series2);
            this.chart_reply_left.Size = new System.Drawing.Size(812, 248);
            this.chart_reply_left.TabIndex = 9;
            this.chart_reply_left.Text = "chart_reply_left";
            title2.Name = "Title1";
            title2.Text = "Reply time (ms)";
            this.chart_reply_left.Titles.Add(title2);
            // 
            // button_STOP
            // 
            this.button_STOP.Enabled = false;
            this.button_STOP.Location = new System.Drawing.Point(693, 12);
            this.button_STOP.Name = "button_STOP";
            this.button_STOP.Size = new System.Drawing.Size(75, 23);
            this.button_STOP.TabIndex = 8;
            this.button_STOP.Text = "Stop";
            this.button_STOP.UseVisualStyleBackColor = true;
            this.button_STOP.Click += new System.EventHandler(this.button_STOP_Click);
            // 
            // text_debug
            // 
            this.text_debug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.text_debug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_debug.Location = new System.Drawing.Point(12, 478);
            this.text_debug.Name = "text_debug";
            this.text_debug.Size = new System.Drawing.Size(812, 96);
            this.text_debug.TabIndex = 7;
            this.text_debug.Text = "";
            // 
            // button_Go
            // 
            this.button_Go.Location = new System.Drawing.Point(612, 12);
            this.button_Go.Name = "button_Go";
            this.button_Go.Size = new System.Drawing.Size(75, 23);
            this.button_Go.TabIndex = 6;
            this.button_Go.Text = "Go";
            this.button_Go.UseVisualStyleBackColor = true;
            this.button_Go.Click += new System.EventHandler(this.button_Go_Click);
            // 
            // text_hostname_l
            // 
            this.text_hostname_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_hostname_l.Location = new System.Drawing.Point(73, 65);
            this.text_hostname_l.Name = "text_hostname_l";
            this.text_hostname_l.Size = new System.Drawing.Size(153, 26);
            this.text_hostname_l.TabIndex = 1;
            this.text_hostname_l.Text = "192.168.1.1";
            this.text_hostname_l.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 648);
            this.Controls.Add(this.tab_panel);
            this.Controls.Add(this.menu_Status);
            this.Controls.Add(this.menu_Main);
            this.MainMenuStrip = this.menu_Main;
            this.Name = "Form1";
            this.Text = "Ping Perf";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menu_Main.ResumeLayout(false);
            this.menu_Main.PerformLayout();
            this.tab_panel.ResumeLayout(false);
            this.tab_icmp.ResumeLayout(false);
            this.tab_icmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_reply_loss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_reply_left)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip menu_Status;
        private System.Windows.Forms.MenuStrip menu_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tab_panel;
        private System.Windows.Forms.TabPage tab_icmp;
        private System.Windows.Forms.TextBox text_hostname_l;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox text_debug;
        private System.Windows.Forms.Button button_Go;
        private System.Windows.Forms.Button button_STOP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_reply_left;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_ping_count;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_reply_loss;
    }
}

