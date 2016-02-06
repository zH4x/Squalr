﻿namespace Anathema
{
    partial class GUIPointerScanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIPointerScanner));
            this.ScanToolStrip = new System.Windows.Forms.ToolStrip();
            this.StartScanButton = new System.Windows.Forms.ToolStripButton();
            this.RebuildPointersButton = new System.Windows.Forms.ToolStripButton();
            this.StopScanButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddSelectedResultsButton = new System.Windows.Forms.ToolStripButton();
            this.TargetAddressTextBox = new System.Windows.Forms.TextBox();
            this.TargetAddressLabel = new System.Windows.Forms.Label();
            this.MaxOffsetLabel = new System.Windows.Forms.Label();
            this.MaxOffsetTextBox = new System.Windows.Forms.TextBox();
            this.MaxLevelTextBox = new System.Windows.Forms.TextBox();
            this.MaxLevelLabel = new System.Windows.Forms.Label();
            this.PointerListView = new Anathema.FlickerFreeListView();
            this.ValueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BaseHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ScanToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScanToolStrip
            // 
            this.ScanToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ScanToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartScanButton,
            this.RebuildPointersButton,
            this.StopScanButton,
            this.toolStripSeparator1,
            this.AddSelectedResultsButton});
            this.ScanToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ScanToolStrip.Name = "ScanToolStrip";
            this.ScanToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ScanToolStrip.Size = new System.Drawing.Size(402, 25);
            this.ScanToolStrip.TabIndex = 149;
            // 
            // StartScanButton
            // 
            this.StartScanButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StartScanButton.Image = global::Anathema.Properties.Resources.RightArrow;
            this.StartScanButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartScanButton.Name = "StartScanButton";
            this.StartScanButton.Size = new System.Drawing.Size(23, 22);
            this.StartScanButton.Text = "Build Pointers";
            this.StartScanButton.Click += new System.EventHandler(this.StartScanButton_Click);
            // 
            // RebuildPointersButton
            // 
            this.RebuildPointersButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RebuildPointersButton.Image = global::Anathema.Properties.Resources.NextScan1;
            this.RebuildPointersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RebuildPointersButton.Name = "RebuildPointersButton";
            this.RebuildPointersButton.Size = new System.Drawing.Size(23, 22);
            this.RebuildPointersButton.Text = "Rebuild Pointers";
            this.RebuildPointersButton.Click += new System.EventHandler(this.RebuildPointersButton_Click);
            // 
            // StopScanButton
            // 
            this.StopScanButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StopScanButton.Image = global::Anathema.Properties.Resources.Stop;
            this.StopScanButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopScanButton.Name = "StopScanButton";
            this.StopScanButton.Size = new System.Drawing.Size(23, 22);
            this.StopScanButton.Text = "Stop Scan";
            this.StopScanButton.ToolTipText = "Stop Scan";
            this.StopScanButton.Click += new System.EventHandler(this.StopScanButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // AddSelectedResultsButton
            // 
            this.AddSelectedResultsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddSelectedResultsButton.Image = global::Anathema.Properties.Resources.DownArrows;
            this.AddSelectedResultsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddSelectedResultsButton.Name = "AddSelectedResultsButton";
            this.AddSelectedResultsButton.Size = new System.Drawing.Size(23, 22);
            this.AddSelectedResultsButton.Text = "Add Selected to Table";
            this.AddSelectedResultsButton.Click += new System.EventHandler(this.AddSelectedResultsButton_Click);
            // 
            // TargetAddressTextBox
            // 
            this.TargetAddressTextBox.Location = new System.Drawing.Point(79, 28);
            this.TargetAddressTextBox.Name = "TargetAddressTextBox";
            this.TargetAddressTextBox.Size = new System.Drawing.Size(134, 20);
            this.TargetAddressTextBox.TabIndex = 0;
            this.TargetAddressTextBox.TextChanged += new System.EventHandler(this.TargetAddressTextBox_TextChanged);
            // 
            // TargetAddressLabel
            // 
            this.TargetAddressLabel.AutoSize = true;
            this.TargetAddressLabel.Location = new System.Drawing.Point(25, 31);
            this.TargetAddressLabel.Name = "TargetAddressLabel";
            this.TargetAddressLabel.Size = new System.Drawing.Size(48, 13);
            this.TargetAddressLabel.TabIndex = 151;
            this.TargetAddressLabel.Text = "Address:";
            // 
            // MaxOffsetLabel
            // 
            this.MaxOffsetLabel.AutoSize = true;
            this.MaxOffsetLabel.Location = new System.Drawing.Point(219, 57);
            this.MaxOffsetLabel.Name = "MaxOffsetLabel";
            this.MaxOffsetLabel.Size = new System.Drawing.Size(61, 13);
            this.MaxOffsetLabel.TabIndex = 153;
            this.MaxOffsetLabel.Text = "Max Offset:";
            // 
            // MaxOffsetTextBox
            // 
            this.MaxOffsetTextBox.Location = new System.Drawing.Point(286, 54);
            this.MaxOffsetTextBox.Name = "MaxOffsetTextBox";
            this.MaxOffsetTextBox.Size = new System.Drawing.Size(109, 20);
            this.MaxOffsetTextBox.TabIndex = 2;
            this.MaxOffsetTextBox.TextChanged += new System.EventHandler(this.MaxOffsetTextBox_TextChanged);
            // 
            // MaxLevelTextBox
            // 
            this.MaxLevelTextBox.Location = new System.Drawing.Point(286, 28);
            this.MaxLevelTextBox.Name = "MaxLevelTextBox";
            this.MaxLevelTextBox.Size = new System.Drawing.Size(109, 20);
            this.MaxLevelTextBox.TabIndex = 1;
            this.MaxLevelTextBox.TextChanged += new System.EventHandler(this.MaxLevelTextBox_TextChanged);
            // 
            // MaxLevelLabel
            // 
            this.MaxLevelLabel.AutoSize = true;
            this.MaxLevelLabel.Location = new System.Drawing.Point(219, 31);
            this.MaxLevelLabel.Name = "MaxLevelLabel";
            this.MaxLevelLabel.Size = new System.Drawing.Size(59, 13);
            this.MaxLevelLabel.TabIndex = 155;
            this.MaxLevelLabel.Text = "Max Level:";
            // 
            // PointerListView
            // 
            this.PointerListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PointerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ValueHeader,
            this.BaseHeader});
            this.PointerListView.FullRowSelect = true;
            this.PointerListView.Location = new System.Drawing.Point(17, 80);
            this.PointerListView.Name = "PointerListView";
            this.PointerListView.Size = new System.Drawing.Size(376, 186);
            this.PointerListView.TabIndex = 157;
            this.PointerListView.UseCompatibleStateImageBehavior = false;
            this.PointerListView.View = System.Windows.Forms.View.Details;
            this.PointerListView.VirtualMode = true;
            this.PointerListView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.PointerListView_RetrieveVirtualItem);
            this.PointerListView.DoubleClick += new System.EventHandler(this.PointerListView_DoubleClick);
            // 
            // ValueHeader
            // 
            this.ValueHeader.Text = "Value";
            this.ValueHeader.Width = 88;
            // 
            // BaseHeader
            // 
            this.BaseHeader.Text = "Base";
            this.BaseHeader.Width = 94;
            // 
            // ValueTypeComboBox
            // 
            this.ValueTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ValueTypeComboBox.FormattingEnabled = true;
            this.ValueTypeComboBox.Location = new System.Drawing.Point(79, 53);
            this.ValueTypeComboBox.Name = "ValueTypeComboBox";
            this.ValueTypeComboBox.Size = new System.Drawing.Size(134, 21);
            this.ValueTypeComboBox.TabIndex = 158;
            this.ValueTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ValueTypeComboBox_SelectedIndexChanged);
            // 
            // GUIPointerScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 278);
            this.Controls.Add(this.ValueTypeComboBox);
            this.Controls.Add(this.PointerListView);
            this.Controls.Add(this.MaxLevelTextBox);
            this.Controls.Add(this.MaxLevelLabel);
            this.Controls.Add(this.MaxOffsetTextBox);
            this.Controls.Add(this.MaxOffsetLabel);
            this.Controls.Add(this.TargetAddressLabel);
            this.Controls.Add(this.TargetAddressTextBox);
            this.Controls.Add(this.ScanToolStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUIPointerScanner";
            this.Text = "Pointer Scanner";
            this.ScanToolStrip.ResumeLayout(false);
            this.ScanToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton StartScanButton;
        private System.Windows.Forms.ToolStrip ScanToolStrip;
        private System.Windows.Forms.ToolStripButton StopScanButton;
        private System.Windows.Forms.TextBox TargetAddressTextBox;
        private System.Windows.Forms.Label TargetAddressLabel;
        private System.Windows.Forms.Label MaxOffsetLabel;
        private System.Windows.Forms.TextBox MaxOffsetTextBox;
        private System.Windows.Forms.TextBox MaxLevelTextBox;
        private System.Windows.Forms.Label MaxLevelLabel;
        private FlickerFreeListView PointerListView;
        private System.Windows.Forms.ColumnHeader ValueHeader;
        private System.Windows.Forms.ToolStripButton RebuildPointersButton;
        private System.Windows.Forms.ColumnHeader BaseHeader;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton AddSelectedResultsButton;
        private System.Windows.Forms.ComboBox ValueTypeComboBox;
    }
}