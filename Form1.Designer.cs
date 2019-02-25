namespace MasterDev_ClientTemplate
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_SyncResults = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_SyncTotalTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_Sync = new System.Windows.Forms.ProgressBar();
            this.btn_ParallelAsync = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_ParallelAsyncResult = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_ParallelAsync = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pb_ParallelAsync = new System.Windows.Forms.ProgressBar();
            this.btn_ProcessAsync = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_AsyncResult = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_AsyncTotalTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pb_Async = new System.Windows.Forms.ProgressBar();
            this.btn_ProcessSync = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ProcessTimeMs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_AppCount = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_AdvancedOutput = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_AdvancedTotalTime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pb_AdvancedParallelAsync = new System.Windows.Forms.ProgressBar();
            this.btn_AdvancedParalleAsync = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_AdvancedProcessTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_AdvancedAppsToSubmit = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SyncResults)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ParallelAsyncResult)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AsyncResult)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AdvancedOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 443);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btn_ParallelAsync);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btn_ProcessAsync);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btn_ProcessSync);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tb_ProcessTimeMs);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_AppCount);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(844, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Initial";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_SyncResults);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_SyncTotalTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pb_Sync);
            this.groupBox1.Location = new System.Drawing.Point(7, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 316);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process Sync";
            // 
            // dgv_SyncResults
            // 
            this.dgv_SyncResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_SyncResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SyncResults.Location = new System.Drawing.Point(10, 66);
            this.dgv_SyncResults.Name = "dgv_SyncResults";
            this.dgv_SyncResults.Size = new System.Drawing.Size(247, 244);
            this.dgv_SyncResults.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Time:";
            // 
            // tb_SyncTotalTime
            // 
            this.tb_SyncTotalTime.Location = new System.Drawing.Point(205, 36);
            this.tb_SyncTotalTime.Name = "tb_SyncTotalTime";
            this.tb_SyncTotalTime.Size = new System.Drawing.Size(52, 20);
            this.tb_SyncTotalTime.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Progress";
            // 
            // pb_Sync
            // 
            this.pb_Sync.Location = new System.Drawing.Point(10, 36);
            this.pb_Sync.Name = "pb_Sync";
            this.pb_Sync.Size = new System.Drawing.Size(189, 23);
            this.pb_Sync.TabIndex = 7;
            // 
            // btn_ParallelAsync
            // 
            this.btn_ParallelAsync.Location = new System.Drawing.Point(281, 51);
            this.btn_ParallelAsync.Name = "btn_ParallelAsync";
            this.btn_ParallelAsync.Size = new System.Drawing.Size(141, 23);
            this.btn_ParallelAsync.TabIndex = 6;
            this.btn_ParallelAsync.Text = "Process Parallel Async";
            this.btn_ParallelAsync.UseVisualStyleBackColor = true;
            this.btn_ParallelAsync.Click += new System.EventHandler(this.btn_ParallelAsync_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_ParallelAsyncResult);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tb_ParallelAsync);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.pb_ParallelAsync);
            this.groupBox3.Location = new System.Drawing.Point(571, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 316);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Process Parallel Async";
            // 
            // dgv_ParallelAsyncResult
            // 
            this.dgv_ParallelAsyncResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ParallelAsyncResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ParallelAsyncResult.Location = new System.Drawing.Point(10, 66);
            this.dgv_ParallelAsyncResult.Name = "dgv_ParallelAsyncResult";
            this.dgv_ParallelAsyncResult.Size = new System.Drawing.Size(247, 244);
            this.dgv_ParallelAsyncResult.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Time:";
            // 
            // tb_ParallelAsync
            // 
            this.tb_ParallelAsync.Location = new System.Drawing.Point(205, 36);
            this.tb_ParallelAsync.Name = "tb_ParallelAsync";
            this.tb_ParallelAsync.Size = new System.Drawing.Size(52, 20);
            this.tb_ParallelAsync.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Progress";
            // 
            // pb_ParallelAsync
            // 
            this.pb_ParallelAsync.Location = new System.Drawing.Point(10, 36);
            this.pb_ParallelAsync.Name = "pb_ParallelAsync";
            this.pb_ParallelAsync.Size = new System.Drawing.Size(189, 23);
            this.pb_ParallelAsync.TabIndex = 7;
            // 
            // btn_ProcessAsync
            // 
            this.btn_ProcessAsync.Location = new System.Drawing.Point(144, 51);
            this.btn_ProcessAsync.Name = "btn_ProcessAsync";
            this.btn_ProcessAsync.Size = new System.Drawing.Size(111, 23);
            this.btn_ProcessAsync.TabIndex = 5;
            this.btn_ProcessAsync.Text = "Process Async";
            this.btn_ProcessAsync.UseVisualStyleBackColor = true;
            this.btn_ProcessAsync.Click += new System.EventHandler(this.btn_ProcessAsync_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_AsyncResult);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_AsyncTotalTime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pb_Async);
            this.groupBox2.Location = new System.Drawing.Point(289, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 316);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process Async";
            // 
            // dgv_AsyncResult
            // 
            this.dgv_AsyncResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_AsyncResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AsyncResult.Location = new System.Drawing.Point(10, 66);
            this.dgv_AsyncResult.Name = "dgv_AsyncResult";
            this.dgv_AsyncResult.Size = new System.Drawing.Size(247, 244);
            this.dgv_AsyncResult.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Time:";
            // 
            // tb_AsyncTotalTime
            // 
            this.tb_AsyncTotalTime.Location = new System.Drawing.Point(205, 36);
            this.tb_AsyncTotalTime.Name = "tb_AsyncTotalTime";
            this.tb_AsyncTotalTime.Size = new System.Drawing.Size(52, 20);
            this.tb_AsyncTotalTime.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Progress";
            // 
            // pb_Async
            // 
            this.pb_Async.Location = new System.Drawing.Point(10, 36);
            this.pb_Async.Name = "pb_Async";
            this.pb_Async.Size = new System.Drawing.Size(189, 23);
            this.pb_Async.TabIndex = 7;
            // 
            // btn_ProcessSync
            // 
            this.btn_ProcessSync.Location = new System.Drawing.Point(13, 51);
            this.btn_ProcessSync.Name = "btn_ProcessSync";
            this.btn_ProcessSync.Size = new System.Drawing.Size(111, 23);
            this.btn_ProcessSync.TabIndex = 4;
            this.btn_ProcessSync.Text = "Process Sync";
            this.btn_ProcessSync.UseVisualStyleBackColor = true;
            this.btn_ProcessSync.Click += new System.EventHandler(this.btn_ProcessSync_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Processing time in Milliseconds:";
            // 
            // tb_ProcessTimeMs
            // 
            this.tb_ProcessTimeMs.Location = new System.Drawing.Point(467, 17);
            this.tb_ProcessTimeMs.Name = "tb_ProcessTimeMs";
            this.tb_ProcessTimeMs.Size = new System.Drawing.Size(100, 20);
            this.tb_ProcessTimeMs.TabIndex = 3;
            this.tb_ProcessTimeMs.Text = "250";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Applications to Submit:";
            // 
            // tb_AppCount
            // 
            this.tb_AppCount.Location = new System.Drawing.Point(144, 14);
            this.tb_AppCount.Name = "tb_AppCount";
            this.tb_AppCount.Size = new System.Drawing.Size(100, 20);
            this.tb_AppCount.TabIndex = 1;
            this.tb_AppCount.Text = "10";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.btn_AdvancedParalleAsync);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tb_AdvancedProcessTime);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tb_AdvancedAppsToSubmit);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(844, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_AdvancedOutput);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.tb_AdvancedTotalTime);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.pb_AdvancedParallelAsync);
            this.groupBox4.Location = new System.Drawing.Point(12, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(829, 316);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Process Parallel Async";
            // 
            // dgv_AdvancedOutput
            // 
            this.dgv_AdvancedOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_AdvancedOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AdvancedOutput.Location = new System.Drawing.Point(10, 66);
            this.dgv_AdvancedOutput.Name = "dgv_AdvancedOutput";
            this.dgv_AdvancedOutput.Size = new System.Drawing.Size(813, 244);
            this.dgv_AdvancedOutput.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(205, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Time:";
            // 
            // tb_AdvancedTotalTime
            // 
            this.tb_AdvancedTotalTime.Location = new System.Drawing.Point(205, 36);
            this.tb_AdvancedTotalTime.Name = "tb_AdvancedTotalTime";
            this.tb_AdvancedTotalTime.Size = new System.Drawing.Size(52, 20);
            this.tb_AdvancedTotalTime.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Progress";
            // 
            // pb_AdvancedParallelAsync
            // 
            this.pb_AdvancedParallelAsync.Location = new System.Drawing.Point(10, 36);
            this.pb_AdvancedParallelAsync.Name = "pb_AdvancedParallelAsync";
            this.pb_AdvancedParallelAsync.Size = new System.Drawing.Size(189, 23);
            this.pb_AdvancedParallelAsync.TabIndex = 7;
            // 
            // btn_AdvancedParalleAsync
            // 
            this.btn_AdvancedParalleAsync.Location = new System.Drawing.Point(12, 35);
            this.btn_AdvancedParalleAsync.Name = "btn_AdvancedParalleAsync";
            this.btn_AdvancedParalleAsync.Size = new System.Drawing.Size(199, 23);
            this.btn_AdvancedParalleAsync.TabIndex = 11;
            this.btn_AdvancedParalleAsync.Text = "Advanced Process Parallel Async";
            this.btn_AdvancedParalleAsync.UseVisualStyleBackColor = true;
            this.btn_AdvancedParalleAsync.Click += new System.EventHandler(this.btn_AdvancedParalleAsync_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Processing time in Milliseconds:";
            // 
            // tb_AdvancedProcessTime
            // 
            this.tb_AdvancedProcessTime.Location = new System.Drawing.Point(468, 12);
            this.tb_AdvancedProcessTime.Name = "tb_AdvancedProcessTime";
            this.tb_AdvancedProcessTime.Size = new System.Drawing.Size(100, 20);
            this.tb_AdvancedProcessTime.TabIndex = 10;
            this.tb_AdvancedProcessTime.Text = "250";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Applications to Submit:";
            // 
            // tb_AdvancedAppsToSubmit
            // 
            this.tb_AdvancedAppsToSubmit.Location = new System.Drawing.Point(145, 12);
            this.tb_AdvancedAppsToSubmit.Name = "tb_AdvancedAppsToSubmit";
            this.tb_AdvancedAppsToSubmit.Size = new System.Drawing.Size(100, 20);
            this.tb_AdvancedAppsToSubmit.TabIndex = 8;
            this.tb_AdvancedAppsToSubmit.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 443);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SyncResults)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ParallelAsyncResult)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AsyncResult)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AdvancedOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_SyncResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_SyncTotalTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pb_Sync;
        private System.Windows.Forms.Button btn_ParallelAsync;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_ParallelAsyncResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_ParallelAsync;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar pb_ParallelAsync;
        private System.Windows.Forms.Button btn_ProcessAsync;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_AsyncResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_AsyncTotalTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar pb_Async;
        private System.Windows.Forms.Button btn_ProcessSync;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ProcessTimeMs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_AppCount;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_AdvancedOutput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_AdvancedTotalTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar pb_AdvancedParallelAsync;
        private System.Windows.Forms.Button btn_AdvancedParalleAsync;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_AdvancedProcessTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_AdvancedAppsToSubmit;
    }
}

