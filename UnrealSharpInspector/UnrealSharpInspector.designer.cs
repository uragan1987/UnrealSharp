﻿
namespace UnrealSharpInspector
{
    partial class UnrealSharpInspector
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inspectProcess = new System.Windows.Forms.Button();
            this.dump = new System.Windows.Forms.Button();
            this.actorList = new System.Windows.Forms.ListBox();
            this.actorInfo = new System.Windows.Forms.ListBox();
            this.showOverlay = new System.Windows.Forms.CheckBox();
            this.btnDumpGnames = new System.Windows.Forms.Button();
            this.btnDumpGObjects = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inspectProcess
            // 
            this.inspectProcess.Location = new System.Drawing.Point(11, 11);
            this.inspectProcess.Name = "inspectProcess";
            this.inspectProcess.Size = new System.Drawing.Size(96, 20);
            this.inspectProcess.TabIndex = 2;
            this.inspectProcess.Text = "Inspect Process";
            this.inspectProcess.UseVisualStyleBackColor = true;
            this.inspectProcess.Click += new System.EventHandler(this.inspectProcess_Click);
            // 
            // dump
            // 
            this.dump.Location = new System.Drawing.Point(113, 10);
            this.dump.Name = "dump";
            this.dump.Size = new System.Drawing.Size(103, 20);
            this.dump.TabIndex = 3;
            this.dump.Text = "Dump SDK";
            this.dump.UseVisualStyleBackColor = true;
            this.dump.Click += new System.EventHandler(this.dump_Click);
            // 
            // actorList
            // 
            this.actorList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actorList.FormattingEnabled = true;
            this.actorList.Location = new System.Drawing.Point(10, 66);
            this.actorList.Name = "actorList";
            this.actorList.Size = new System.Drawing.Size(318, 316);
            this.actorList.TabIndex = 7;
            this.actorList.SelectedIndexChanged += new System.EventHandler(this.actorList_SelectedIndexChanged);
            // 
            // actorInfo
            // 
            this.actorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actorInfo.FormattingEnabled = true;
            this.actorInfo.Location = new System.Drawing.Point(334, 14);
            this.actorInfo.Name = "actorInfo";
            this.actorInfo.Size = new System.Drawing.Size(454, 368);
            this.actorInfo.TabIndex = 8;
            this.actorInfo.SelectedIndexChanged += new System.EventHandler(this.actorInfo_SelectedIndexChanged);
            // 
            // showOverlay
            // 
            this.showOverlay.AutoSize = true;
            this.showOverlay.Location = new System.Drawing.Point(236, 13);
            this.showOverlay.Name = "showOverlay";
            this.showOverlay.Size = new System.Drawing.Size(92, 17);
            this.showOverlay.TabIndex = 9;
            this.showOverlay.Text = "Show Overlay";
            this.showOverlay.UseVisualStyleBackColor = true;
            // 
            // btnDumpGnames
            // 
            this.btnDumpGnames.Location = new System.Drawing.Point(113, 36);
            this.btnDumpGnames.Name = "btnDumpGnames";
            this.btnDumpGnames.Size = new System.Drawing.Size(103, 20);
            this.btnDumpGnames.TabIndex = 10;
            this.btnDumpGnames.Text = "Dump GNames";
            this.btnDumpGnames.UseVisualStyleBackColor = true;
            this.btnDumpGnames.Click += new System.EventHandler(this.btnDumpGnames_Click);
            // 
            // btnDumpGObjects
            // 
            this.btnDumpGObjects.Location = new System.Drawing.Point(10, 36);
            this.btnDumpGObjects.Name = "btnDumpGObjects";
            this.btnDumpGObjects.Size = new System.Drawing.Size(97, 20);
            this.btnDumpGObjects.TabIndex = 11;
            this.btnDumpGObjects.Text = "Dump GObject";
            this.btnDumpGObjects.UseVisualStyleBackColor = true;
            this.btnDumpGObjects.Click += new System.EventHandler(this.btnDumpGObjects_Click);
            // 
            // UnrealSharpInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 391);
            this.Controls.Add(this.btnDumpGObjects);
            this.Controls.Add(this.btnDumpGnames);
            this.Controls.Add(this.showOverlay);
            this.Controls.Add(this.actorInfo);
            this.Controls.Add(this.actorList);
            this.Controls.Add(this.dump);
            this.Controls.Add(this.inspectProcess);
            this.Name = "UnrealSharpInspector";
            this.Text = "UnrealSharp [by shalzuth]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button inspectProcess;
        private System.Windows.Forms.Button dump;
        private System.Windows.Forms.ListBox actorList;
        private System.Windows.Forms.ListBox actorInfo;
        private System.Windows.Forms.CheckBox showOverlay;
        private System.Windows.Forms.Button btnDumpGnames;
        private System.Windows.Forms.Button btnDumpGObjects;
    }
}

