﻿namespace ScheduleStopWatch
{
    partial class AppForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scheduleInputForm = new ScheduleStopWatch.ScheduleInputForm();
            this.scheduleStopWatchTimerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleStopWatchTimerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleInputForm
            // 
            this.scheduleInputForm.Location = new System.Drawing.Point(12, 12);
            this.scheduleInputForm.Name = "scheduleInputForm";
            this.scheduleInputForm.Size = new System.Drawing.Size(428, 45);
            this.scheduleInputForm.TabIndex = 4;
            // 
            // scheduleStopWatchTimerBindingSource
            // 
            this.scheduleStopWatchTimerBindingSource.DataSource = typeof(ScheduleStopWatch.ScheduleStopWatchTimer);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 75);
            this.Controls.Add(this.scheduleInputForm);
            this.Name = "AppForm";
            this.Text = "ScheduleStopWatch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.saveScheduleDatas);
            this.Load += new System.EventHandler(this.AppForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleStopWatchTimerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource scheduleStopWatchTimerBindingSource;
        private ScheduleInputForm scheduleInputForm;
    }
}

