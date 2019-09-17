﻿namespace ScriptEditor
{
    partial class FormCastFlags
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
            this.grpFlags = new System.Windows.Forms.GroupBox();
            this.chkCastFlag128 = new System.Windows.Forms.CheckBox();
            this.chkCastFlag64 = new System.Windows.Forms.CheckBox();
            this.chkCastFlag32 = new System.Windows.Forms.CheckBox();
            this.chkCastFlag16 = new System.Windows.Forms.CheckBox();
            this.chkCastFlag8 = new System.Windows.Forms.CheckBox();
            this.chkCastFlag4 = new System.Windows.Forms.CheckBox();
            this.chkCastFlag2 = new System.Windows.Forms.CheckBox();
            this.chkCastFlag1 = new System.Windows.Forms.CheckBox();
            this.txtScriptId = new System.Windows.Forms.TextBox();
            this.btnEditScript = new System.Windows.Forms.Button();
            this.lblScriptId = new System.Windows.Forms.Label();
            this.txtTargetParam1 = new System.Windows.Forms.TextBox();
            this.txtTargetParam2 = new System.Windows.Forms.TextBox();
            this.lblTargetParam1 = new System.Windows.Forms.Label();
            this.lblTargetParam2 = new System.Windows.Forms.Label();
            this.grpTargetParams = new System.Windows.Forms.GroupBox();
            this.grpFlags.SuspendLayout();
            this.grpTargetParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFlags
            // 
            this.grpFlags.Controls.Add(this.chkCastFlag128);
            this.grpFlags.Controls.Add(this.chkCastFlag64);
            this.grpFlags.Controls.Add(this.chkCastFlag32);
            this.grpFlags.Controls.Add(this.chkCastFlag16);
            this.grpFlags.Controls.Add(this.chkCastFlag8);
            this.grpFlags.Controls.Add(this.chkCastFlag4);
            this.grpFlags.Controls.Add(this.chkCastFlag2);
            this.grpFlags.Controls.Add(this.chkCastFlag1);
            this.grpFlags.Location = new System.Drawing.Point(12, 9);
            this.grpFlags.Name = "grpFlags";
            this.grpFlags.Size = new System.Drawing.Size(283, 116);
            this.grpFlags.TabIndex = 0;
            this.grpFlags.TabStop = false;
            this.grpFlags.Text = "Cast Flags";
            // 
            // chkCastFlag128
            // 
            this.chkCastFlag128.AutoSize = true;
            this.chkCastFlag128.Location = new System.Drawing.Point(154, 90);
            this.chkCastFlag128.Name = "chkCastFlag128";
            this.chkCastFlag128.Size = new System.Drawing.Size(96, 16);
            this.chkCastFlag128.TabIndex = 7;
            this.chkCastFlag128.Text = "Not In Melee";
            this.chkCastFlag128.UseVisualStyleBackColor = true;
            // 
            // chkCastFlag64
            // 
            this.chkCastFlag64.AutoSize = true;
            this.chkCastFlag64.Location = new System.Drawing.Point(6, 90);
            this.chkCastFlag64.Name = "chkCastFlag64";
            this.chkCastFlag64.Size = new System.Drawing.Size(102, 16);
            this.chkCastFlag64.TabIndex = 6;
            this.chkCastFlag64.Text = "Only In Melee";
            this.chkCastFlag64.UseVisualStyleBackColor = true;
            // 
            // chkCastFlag32
            // 
            this.chkCastFlag32.AutoSize = true;
            this.chkCastFlag32.Location = new System.Drawing.Point(154, 68);
            this.chkCastFlag32.Name = "chkCastFlag32";
            this.chkCastFlag32.Size = new System.Drawing.Size(120, 16);
            this.chkCastFlag32.TabIndex = 5;
            this.chkCastFlag32.Text = "Aura Not Present";
            this.chkCastFlag32.UseVisualStyleBackColor = true;
            // 
            // chkCastFlag16
            // 
            this.chkCastFlag16.AutoSize = true;
            this.chkCastFlag16.Location = new System.Drawing.Point(6, 68);
            this.chkCastFlag16.Name = "chkCastFlag16";
            this.chkCastFlag16.Size = new System.Drawing.Size(132, 16);
            this.chkCastFlag16.TabIndex = 4;
            this.chkCastFlag16.Text = "Target Unreachable";
            this.chkCastFlag16.UseVisualStyleBackColor = true;
            // 
            // chkCastFlag8
            // 
            this.chkCastFlag8.AutoSize = true;
            this.chkCastFlag8.Location = new System.Drawing.Point(6, 47);
            this.chkCastFlag8.Name = "chkCastFlag8";
            this.chkCastFlag8.Size = new System.Drawing.Size(126, 16);
            this.chkCastFlag8.TabIndex = 3;
            this.chkCastFlag8.Text = "Main Ranged Spell";
            this.chkCastFlag8.UseVisualStyleBackColor = true;
            // 
            // chkCastFlag4
            // 
            this.chkCastFlag4.AutoSize = true;
            this.chkCastFlag4.Location = new System.Drawing.Point(154, 47);
            this.chkCastFlag4.Name = "chkCastFlag4";
            this.chkCastFlag4.Size = new System.Drawing.Size(84, 16);
            this.chkCastFlag4.TabIndex = 2;
            this.chkCastFlag4.Text = "Force Cast";
            this.chkCastFlag4.UseVisualStyleBackColor = true;
            // 
            // chkCastFlag2
            // 
            this.chkCastFlag2.AutoSize = true;
            this.chkCastFlag2.Location = new System.Drawing.Point(154, 26);
            this.chkCastFlag2.Name = "chkCastFlag2";
            this.chkCastFlag2.Size = new System.Drawing.Size(78, 16);
            this.chkCastFlag2.TabIndex = 1;
            this.chkCastFlag2.Text = "Triggered";
            this.chkCastFlag2.UseVisualStyleBackColor = true;
            // 
            // chkCastFlag1
            // 
            this.chkCastFlag1.AutoSize = true;
            this.chkCastFlag1.Location = new System.Drawing.Point(6, 26);
            this.chkCastFlag1.Name = "chkCastFlag1";
            this.chkCastFlag1.Size = new System.Drawing.Size(132, 16);
            this.chkCastFlag1.TabIndex = 0;
            this.chkCastFlag1.Text = "Interrupt Previous";
            this.chkCastFlag1.UseVisualStyleBackColor = true;
            // 
            // txtScriptId
            // 
            this.txtScriptId.Location = new System.Drawing.Point(70, 196);
            this.txtScriptId.MinimumSize = new System.Drawing.Size(4, 23);
            this.txtScriptId.Name = "txtScriptId";
            this.txtScriptId.Size = new System.Drawing.Size(136, 21);
            this.txtScriptId.TabIndex = 1;
            // 
            // btnEditScript
            // 
            this.btnEditScript.Location = new System.Drawing.Point(212, 196);
            this.btnEditScript.Name = "btnEditScript";
            this.btnEditScript.Size = new System.Drawing.Size(68, 21);
            this.btnEditScript.TabIndex = 2;
            this.btnEditScript.Text = "Edit";
            this.btnEditScript.UseVisualStyleBackColor = true;
            this.btnEditScript.Click += new System.EventHandler(this.btnEditScript_Click);
            // 
            // lblScriptId
            // 
            this.lblScriptId.AutoSize = true;
            this.lblScriptId.Location = new System.Drawing.Point(17, 199);
            this.lblScriptId.Name = "lblScriptId";
            this.lblScriptId.Size = new System.Drawing.Size(65, 12);
            this.lblScriptId.TabIndex = 3;
            this.lblScriptId.Text = "Script Id:";
            // 
            // txtTargetParam1
            // 
            this.txtTargetParam1.Enabled = false;
            this.txtTargetParam1.Location = new System.Drawing.Point(16, 29);
            this.txtTargetParam1.Name = "txtTargetParam1";
            this.txtTargetParam1.Size = new System.Drawing.Size(110, 21);
            this.txtTargetParam1.TabIndex = 4;
            // 
            // txtTargetParam2
            // 
            this.txtTargetParam2.Location = new System.Drawing.Point(143, 29);
            this.txtTargetParam2.Name = "txtTargetParam2";
            this.txtTargetParam2.Size = new System.Drawing.Size(110, 21);
            this.txtTargetParam2.TabIndex = 5;
            // 
            // lblTargetParam1
            // 
            this.lblTargetParam1.AutoSize = true;
            this.lblTargetParam1.Location = new System.Drawing.Point(13, 13);
            this.lblTargetParam1.Name = "lblTargetParam1";
            this.lblTargetParam1.Size = new System.Drawing.Size(29, 12);
            this.lblTargetParam1.TabIndex = 6;
            this.lblTargetParam1.Text = "N/A:";
            // 
            // lblTargetParam2
            // 
            this.lblTargetParam2.AutoSize = true;
            this.lblTargetParam2.Location = new System.Drawing.Point(140, 14);
            this.lblTargetParam2.Name = "lblTargetParam2";
            this.lblTargetParam2.Size = new System.Drawing.Size(29, 12);
            this.lblTargetParam2.TabIndex = 7;
            this.lblTargetParam2.Text = "N/A:";
            // 
            // grpTargetParams
            // 
            this.grpTargetParams.Controls.Add(this.txtTargetParam1);
            this.grpTargetParams.Controls.Add(this.lblTargetParam2);
            this.grpTargetParams.Controls.Add(this.lblTargetParam1);
            this.grpTargetParams.Controls.Add(this.txtTargetParam2);
            this.grpTargetParams.Enabled = false;
            this.grpTargetParams.Location = new System.Drawing.Point(12, 131);
            this.grpTargetParams.Name = "grpTargetParams";
            this.grpTargetParams.Size = new System.Drawing.Size(283, 55);
            this.grpTargetParams.TabIndex = 8;
            this.grpTargetParams.TabStop = false;
            // 
            // FormCastFlags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 231);
            this.Controls.Add(this.grpTargetParams);
            this.Controls.Add(this.lblScriptId);
            this.Controls.Add(this.btnEditScript);
            this.Controls.Add(this.txtScriptId);
            this.Controls.Add(this.grpFlags);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormCastFlags";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Additional Settings";
            this.grpFlags.ResumeLayout(false);
            this.grpFlags.PerformLayout();
            this.grpTargetParams.ResumeLayout(false);
            this.grpTargetParams.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFlags;
        private System.Windows.Forms.CheckBox chkCastFlag32;
        private System.Windows.Forms.CheckBox chkCastFlag16;
        private System.Windows.Forms.CheckBox chkCastFlag8;
        private System.Windows.Forms.CheckBox chkCastFlag4;
        private System.Windows.Forms.CheckBox chkCastFlag2;
        private System.Windows.Forms.CheckBox chkCastFlag1;
        private System.Windows.Forms.TextBox txtScriptId;
        private System.Windows.Forms.Button btnEditScript;
        private System.Windows.Forms.Label lblScriptId;
        private System.Windows.Forms.TextBox txtTargetParam1;
        private System.Windows.Forms.TextBox txtTargetParam2;
        private System.Windows.Forms.Label lblTargetParam1;
        private System.Windows.Forms.Label lblTargetParam2;
        private System.Windows.Forms.GroupBox grpTargetParams;
        private System.Windows.Forms.CheckBox chkCastFlag128;
        private System.Windows.Forms.CheckBox chkCastFlag64;
    }
}