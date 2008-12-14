
//	Copyright (c) Microsoft Corporation.  All rights reserved.

namespace Microsoft.NodeXL.DesktopApplication
{
    partial class View
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
            this.spcSplitContainer = new System.Windows.Forms.SplitContainer();
            this.oNodeXLControl = new Microsoft.NodeXL.Visualization.NodeXLControl();
            this.oGraphInfoViewer = new Microsoft.NodeXL.ApplicationUtil.GraphInfoViewer();
            this.spcSplitContainer.Panel1.SuspendLayout();
            this.spcSplitContainer.Panel2.SuspendLayout();
            this.spcSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcSplitContainer
            // 
            this.spcSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spcSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.spcSplitContainer.Name = "spcSplitContainer";
            // 
            // spcSplitContainer.Panel1
            // 
            this.spcSplitContainer.Panel1.Controls.Add(this.oNodeXLControl);
            // 
            // spcSplitContainer.Panel2
            // 
            this.spcSplitContainer.Panel2.AutoScroll = true;
            this.spcSplitContainer.Panel2.AutoScrollMinSize = new System.Drawing.Size(136, 425);
            this.spcSplitContainer.Panel2.Controls.Add(this.oGraphInfoViewer);
            this.spcSplitContainer.Size = new System.Drawing.Size(967, 705);
            this.spcSplitContainer.SplitterDistance = 792;
            this.spcSplitContainer.TabIndex = 0;
            // 
            // oNodeXLControl
            // 
            this.oNodeXLControl.AllowVertexDrag = true;
            this.oNodeXLControl.BackColor = System.Drawing.SystemColors.Window;
            this.oNodeXLControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oNodeXLControl.Location = new System.Drawing.Point(0, 0);
            this.oNodeXLControl.Name = "oNodeXLControl";
            this.oNodeXLControl.Size = new System.Drawing.Size(792, 705);
            this.oNodeXLControl.TabIndex = 0;
            this.oNodeXLControl.GraphDrawn += new System.EventHandler(this.oNodeXLControl_GraphDrawn);
            this.oNodeXLControl.SelectionChanged += new System.EventHandler(this.oNodeXLControl_SelectionChanged);
            this.oNodeXLControl.DrawingGraph += new System.EventHandler(this.oNodeXLControl_DrawingGraph);
            // 
            // oGraphInfoViewer
            // 
            this.oGraphInfoViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.oGraphInfoViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oGraphInfoViewer.Enabled = false;
            this.oGraphInfoViewer.Location = new System.Drawing.Point(0, 0);
            this.oGraphInfoViewer.MinimumSize = new System.Drawing.Size(136, 425);
            this.oGraphInfoViewer.Name = "oGraphInfoViewer";
            this.oGraphInfoViewer.Size = new System.Drawing.Size(171, 705);
            this.oGraphInfoViewer.TabIndex = 0;
            this.oGraphInfoViewer.RequestSelection += new Microsoft.NodeXL.ApplicationUtil.RequestSelectionEventHandler(this.oGraphInfoViewer_RequestSelection);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 705);
            this.Controls.Add(this.spcSplitContainer);
            this.Name = "View";
            this.Text = "View";
            this.spcSplitContainer.Panel1.ResumeLayout(false);
            this.spcSplitContainer.Panel2.ResumeLayout(false);
            this.spcSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcSplitContainer;
        private Microsoft.NodeXL.Visualization.NodeXLControl oNodeXLControl;
        private Microsoft.NodeXL.ApplicationUtil.GraphInfoViewer oGraphInfoViewer;

    }
}