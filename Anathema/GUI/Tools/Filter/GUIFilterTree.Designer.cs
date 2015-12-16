﻿namespace Anathema
{
    partial class GUIFilterTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIFilterTree));
            this.MemorySizeValueLabel = new System.Windows.Forms.Label();
            this.HashSizeLabel = new System.Windows.Forms.Label();
            this.VariableSizeValueLabel = new System.Windows.Forms.Label();
            this.VariableSizeLabel = new System.Windows.Forms.Label();
            this.VariableSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.StopScanButton = new System.Windows.Forms.ToolStripButton();
            this.StartScanButton = new System.Windows.Forms.ToolStripButton();
            this.ScanToolStrip = new System.Windows.Forms.ToolStrip();
            this.MaxChangesValueLabel = new System.Windows.Forms.Label();
            this.MaxChangesLabel = new System.Windows.Forms.Label();
            this.MaxChangesTrackBar = new System.Windows.Forms.TrackBar();
            this.MinChangesValueLabel = new System.Windows.Forms.Label();
            this.MinChangesLabel = new System.Windows.Forms.Label();
            this.MinChangesTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.VariableSizeTrackBar)).BeginInit();
            this.ScanToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxChangesTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinChangesTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // MemorySizeValueLabel
            // 
            this.MemorySizeValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MemorySizeValueLabel.AutoSize = true;
            this.MemorySizeValueLabel.Location = new System.Drawing.Point(67, 26);
            this.MemorySizeValueLabel.Name = "MemorySizeValueLabel";
            this.MemorySizeValueLabel.Size = new System.Drawing.Size(20, 13);
            this.MemorySizeValueLabel.TabIndex = 152;
            this.MemorySizeValueLabel.Text = "0B";
            // 
            // HashSizeLabel
            // 
            this.HashSizeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HashSizeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HashSizeLabel.Location = new System.Drawing.Point(0, 25);
            this.HashSizeLabel.Name = "HashSizeLabel";
            this.HashSizeLabel.Size = new System.Drawing.Size(266, 15);
            this.HashSizeLabel.TabIndex = 151;
            this.HashSizeLabel.Text = "Memory Size:";
            // 
            // VariableSizeValueLabel
            // 
            this.VariableSizeValueLabel.AutoSize = true;
            this.VariableSizeValueLabel.Location = new System.Drawing.Point(96, 126);
            this.VariableSizeValueLabel.Name = "VariableSizeValueLabel";
            this.VariableSizeValueLabel.Size = new System.Drawing.Size(20, 13);
            this.VariableSizeValueLabel.TabIndex = 147;
            this.VariableSizeValueLabel.Text = "0B";
            // 
            // VariableSizeLabel
            // 
            this.VariableSizeLabel.AutoSize = true;
            this.VariableSizeLabel.Location = new System.Drawing.Point(6, 126);
            this.VariableSizeLabel.Name = "VariableSizeLabel";
            this.VariableSizeLabel.Size = new System.Drawing.Size(94, 13);
            this.VariableSizeLabel.TabIndex = 146;
            this.VariableSizeLabel.Text = "Max Variable Size:";
            // 
            // VariableSizeTrackBar
            // 
            this.VariableSizeTrackBar.LargeChange = 4;
            this.VariableSizeTrackBar.Location = new System.Drawing.Point(4, 94);
            this.VariableSizeTrackBar.Maximum = 3;
            this.VariableSizeTrackBar.Name = "VariableSizeTrackBar";
            this.VariableSizeTrackBar.Size = new System.Drawing.Size(132, 45);
            this.VariableSizeTrackBar.TabIndex = 145;
            this.VariableSizeTrackBar.Value = 3;
            this.VariableSizeTrackBar.Scroll += new System.EventHandler(this.VariableSizeTrackBar_Scroll);
            // 
            // StopScanButton
            // 
            this.StopScanButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StopScanButton.Image = ((System.Drawing.Image)(resources.GetObject("StopScanButton.Image")));
            this.StopScanButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopScanButton.Name = "StopScanButton";
            this.StopScanButton.Size = new System.Drawing.Size(23, 22);
            this.StopScanButton.Text = "Stop";
            this.StopScanButton.ToolTipText = "Stop Tree Scan";
            this.StopScanButton.Click += new System.EventHandler(this.StopScanButton_Click);
            // 
            // StartScanButton
            // 
            this.StartScanButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StartScanButton.Image = ((System.Drawing.Image)(resources.GetObject("StartScanButton.Image")));
            this.StartScanButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartScanButton.Name = "StartScanButton";
            this.StartScanButton.Size = new System.Drawing.Size(23, 22);
            this.StartScanButton.Text = "Start Tree Scan";
            this.StartScanButton.Click += new System.EventHandler(this.StartScanButton_Click);
            // 
            // ScanToolStrip
            // 
            this.ScanToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ScanToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartScanButton,
            this.StopScanButton});
            this.ScanToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ScanToolStrip.Name = "ScanToolStrip";
            this.ScanToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ScanToolStrip.Size = new System.Drawing.Size(266, 25);
            this.ScanToolStrip.TabIndex = 149;
            this.ScanToolStrip.Text = "toolStrip1";
            // 
            // MaxChangesValueLabel
            // 
            this.MaxChangesValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxChangesValueLabel.AutoSize = true;
            this.MaxChangesValueLabel.Location = new System.Drawing.Point(223, 75);
            this.MaxChangesValueLabel.Name = "MaxChangesValueLabel";
            this.MaxChangesValueLabel.Size = new System.Drawing.Size(37, 13);
            this.MaxChangesValueLabel.TabIndex = 158;
            this.MaxChangesValueLabel.Text = "Infinity";
            // 
            // MaxChangesLabel
            // 
            this.MaxChangesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxChangesLabel.AutoSize = true;
            this.MaxChangesLabel.Location = new System.Drawing.Point(152, 75);
            this.MaxChangesLabel.Name = "MaxChangesLabel";
            this.MaxChangesLabel.Size = new System.Drawing.Size(75, 13);
            this.MaxChangesLabel.TabIndex = 157;
            this.MaxChangesLabel.Text = "Max Changes:";
            // 
            // MaxChangesTrackBar
            // 
            this.MaxChangesTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxChangesTrackBar.LargeChange = 4;
            this.MaxChangesTrackBar.Location = new System.Drawing.Point(128, 43);
            this.MaxChangesTrackBar.Maximum = 17;
            this.MaxChangesTrackBar.Minimum = 1;
            this.MaxChangesTrackBar.Name = "MaxChangesTrackBar";
            this.MaxChangesTrackBar.Size = new System.Drawing.Size(132, 45);
            this.MaxChangesTrackBar.TabIndex = 156;
            this.MaxChangesTrackBar.Value = 17;
            this.MaxChangesTrackBar.Scroll += new System.EventHandler(this.MaxChangesTrackBar_Scroll);
            // 
            // MinChangesValueLabel
            // 
            this.MinChangesValueLabel.AutoSize = true;
            this.MinChangesValueLabel.Location = new System.Drawing.Point(74, 75);
            this.MinChangesValueLabel.Name = "MinChangesValueLabel";
            this.MinChangesValueLabel.Size = new System.Drawing.Size(13, 13);
            this.MinChangesValueLabel.TabIndex = 155;
            this.MinChangesValueLabel.Text = "0";
            // 
            // MinChangesLabel
            // 
            this.MinChangesLabel.AutoSize = true;
            this.MinChangesLabel.Location = new System.Drawing.Point(6, 75);
            this.MinChangesLabel.Name = "MinChangesLabel";
            this.MinChangesLabel.Size = new System.Drawing.Size(72, 13);
            this.MinChangesLabel.TabIndex = 154;
            this.MinChangesLabel.Text = "Min Changes:";
            // 
            // MinChangesTrackBar
            // 
            this.MinChangesTrackBar.LargeChange = 4;
            this.MinChangesTrackBar.Location = new System.Drawing.Point(0, 43);
            this.MinChangesTrackBar.Maximum = 16;
            this.MinChangesTrackBar.Minimum = 1;
            this.MinChangesTrackBar.Name = "MinChangesTrackBar";
            this.MinChangesTrackBar.Size = new System.Drawing.Size(136, 45);
            this.MinChangesTrackBar.TabIndex = 153;
            this.MinChangesTrackBar.Value = 1;
            this.MinChangesTrackBar.Scroll += new System.EventHandler(this.MinChangesTrackBar_Scroll);
            // 
            // GUIFilterTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 173);
            this.Controls.Add(this.VariableSizeValueLabel);
            this.Controls.Add(this.MaxChangesValueLabel);
            this.Controls.Add(this.VariableSizeLabel);
            this.Controls.Add(this.MaxChangesLabel);
            this.Controls.Add(this.MinChangesValueLabel);
            this.Controls.Add(this.MinChangesLabel);
            this.Controls.Add(this.VariableSizeTrackBar);
            this.Controls.Add(this.MemorySizeValueLabel);
            this.Controls.Add(this.HashSizeLabel);
            this.Controls.Add(this.ScanToolStrip);
            this.Controls.Add(this.MaxChangesTrackBar);
            this.Controls.Add(this.MinChangesTrackBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GUIFilterTree";
            this.Text = "Tree Scanner";
            this.Resize += new System.EventHandler(this.GUIFilterTree_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.VariableSizeTrackBar)).EndInit();
            this.ScanToolStrip.ResumeLayout(false);
            this.ScanToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxChangesTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinChangesTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MemorySizeValueLabel;
        private System.Windows.Forms.Label HashSizeLabel;
        private System.Windows.Forms.Label VariableSizeValueLabel;
        private System.Windows.Forms.Label VariableSizeLabel;
        private System.Windows.Forms.TrackBar VariableSizeTrackBar;
        private System.Windows.Forms.ToolStripButton StopScanButton;
        private System.Windows.Forms.ToolStripButton StartScanButton;
        private System.Windows.Forms.ToolStrip ScanToolStrip;
        private System.Windows.Forms.Label MaxChangesValueLabel;
        private System.Windows.Forms.Label MaxChangesLabel;
        private System.Windows.Forms.TrackBar MaxChangesTrackBar;
        private System.Windows.Forms.Label MinChangesValueLabel;
        private System.Windows.Forms.Label MinChangesLabel;
        private System.Windows.Forms.TrackBar MinChangesTrackBar;
    }
}