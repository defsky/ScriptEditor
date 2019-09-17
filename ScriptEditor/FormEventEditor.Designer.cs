namespace ScriptEditor
{
    partial class FormEventEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEventEditor));
            this.lstEvents = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCreatureId = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblCreatureId = new System.Windows.Forms.Label();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.btnEventPhaseMask = new System.Windows.Forms.Button();
            this.lblEventComment = new System.Windows.Forms.Label();
            this.txtEventComment = new System.Windows.Forms.TextBox();
            this.lblScriptId3 = new System.Windows.Forms.Label();
            this.lblScriptId2 = new System.Windows.Forms.Label();
            this.lblScriptId1 = new System.Windows.Forms.Label();
            this.grpEventFlags = new System.Windows.Forms.GroupBox();
            this.chkEventFlag4 = new System.Windows.Forms.CheckBox();
            this.chkEventFlag2 = new System.Windows.Forms.CheckBox();
            this.chkEventFlag1 = new System.Windows.Forms.CheckBox();
            this.btnEditScript3 = new System.Windows.Forms.Button();
            this.btnEditScript2 = new System.Windows.Forms.Button();
            this.btnEditScript1 = new System.Windows.Forms.Button();
            this.txtScriptId3 = new System.Windows.Forms.TextBox();
            this.txtScriptId2 = new System.Windows.Forms.TextBox();
            this.txtScriptId1 = new System.Windows.Forms.TextBox();
            this.lblEventCondition = new System.Windows.Forms.Label();
            this.btnEventCondition = new System.Windows.Forms.Button();
            this.lblEventPhaseMask = new System.Windows.Forms.Label();
            this.lblEventChance = new System.Windows.Forms.Label();
            this.txtEventChance = new System.Windows.Forms.TextBox();
            this.cmbEventType = new System.Windows.Forms.ComboBox();
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblEventId = new System.Windows.Forms.Label();
            this.txtEventId = new System.Windows.Forms.TextBox();
            this.frmEventTimerCombat = new System.Windows.Forms.Panel();
            this.txtTimerRepeatMax = new System.Windows.Forms.TextBox();
            this.lblTimerRepeatMax = new System.Windows.Forms.Label();
            this.txtTimerRepeatMin = new System.Windows.Forms.TextBox();
            this.txtTimerInitialMax = new System.Windows.Forms.TextBox();
            this.txtTimerInitialMin = new System.Windows.Forms.TextBox();
            this.lblTimerRepeatMin = new System.Windows.Forms.Label();
            this.lblTimerInitialMin = new System.Windows.Forms.Label();
            this.lblTimerInitialMax = new System.Windows.Forms.Label();
            this.lblEventTimerCombatTooltip = new System.Windows.Forms.Label();
            this.lblCurrentCreature = new System.Windows.Forms.Label();
            this.btnEventCopy = new System.Windows.Forms.Button();
            this.btnEventAdd = new System.Windows.Forms.Button();
            this.btnEventDelete = new System.Windows.Forms.Button();
            this.btnViewRaw = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNoEvent = new System.Windows.Forms.Label();
            this.frmEventAggro = new System.Windows.Forms.Panel();
            this.lblEventAggroTooltip = new System.Windows.Forms.Label();
            this.frmEventSpellHit = new System.Windows.Forms.Panel();
            this.btnSpellHitSpellId = new System.Windows.Forms.Button();
            this.txtSpellHitRepeatMax = new System.Windows.Forms.TextBox();
            this.lblSpellHitRepeatMax = new System.Windows.Forms.Label();
            this.txtSpellHitRepeatMin = new System.Windows.Forms.TextBox();
            this.txtSpellHitSchoolMask = new System.Windows.Forms.TextBox();
            this.lblSpellHitRepeatMin = new System.Windows.Forms.Label();
            this.lblSpellHitSpellId = new System.Windows.Forms.Label();
            this.lblSpellHitSchoolMask = new System.Windows.Forms.Label();
            this.lblEventSpellHitTooltip = new System.Windows.Forms.Label();
            this.frmEventEnterLOS = new System.Windows.Forms.Panel();
            this.cmbEnterLOSFaction = new System.Windows.Forms.ComboBox();
            this.txtEnterLOSRepeatMax = new System.Windows.Forms.TextBox();
            this.lblEnterLOSRepeatMax = new System.Windows.Forms.Label();
            this.txtEnterLOSRepeatMin = new System.Windows.Forms.TextBox();
            this.txtEnterLOSDistance = new System.Windows.Forms.TextBox();
            this.lblEnterLOSRepeatMin = new System.Windows.Forms.Label();
            this.lblEnterLOSFaction = new System.Windows.Forms.Label();
            this.lblEnterLOSDistance = new System.Windows.Forms.Label();
            this.lblEventEnterLOSTooltip = new System.Windows.Forms.Label();
            this.frmEventSummonedUnit = new System.Windows.Forms.Panel();
            this.btnSummonedUnitId = new System.Windows.Forms.Button();
            this.txtSummonedUnitRepeatMax = new System.Windows.Forms.TextBox();
            this.txtSummonedUnitRepeatMin = new System.Windows.Forms.TextBox();
            this.lblSummonedUnitRepeatMax = new System.Windows.Forms.Label();
            this.lblSummonedUnitId = new System.Windows.Forms.Label();
            this.lblSummonedUnitRepeatMin = new System.Windows.Forms.Label();
            this.lblEventSummonedUnitTooltip = new System.Windows.Forms.Label();
            this.frmEventReceiveEmote = new System.Windows.Forms.Panel();
            this.cmbReceiveEmoteId = new System.Windows.Forms.ComboBox();
            this.lblReceiveEmoteId = new System.Windows.Forms.Label();
            this.lblEventReceiveEmoteTooltip = new System.Windows.Forms.Label();
            this.frmEventMovementInform = new System.Windows.Forms.Panel();
            this.txtMovementInformType = new System.Windows.Forms.TextBox();
            this.cmbMovementInformType = new System.Windows.Forms.ComboBox();
            this.txtMovementInformRepeatMax = new System.Windows.Forms.TextBox();
            this.lblMovementInformRepeatMax = new System.Windows.Forms.Label();
            this.txtMovementInformRepeatMin = new System.Windows.Forms.TextBox();
            this.txtMovementInformPoint = new System.Windows.Forms.TextBox();
            this.lblMovementInformRepeatMin = new System.Windows.Forms.Label();
            this.lblMovementInformType = new System.Windows.Forms.Label();
            this.lblMovementInformPoint = new System.Windows.Forms.Label();
            this.lblEventMovementInformTooltip = new System.Windows.Forms.Label();
            this.frmEventGroupMemberDied = new System.Windows.Forms.Panel();
            this.cmbGroupMemberDiedIsLeader = new System.Windows.Forms.ComboBox();
            this.btnGroupMemberDiedCreatureId = new System.Windows.Forms.Button();
            this.lblGroupMemberDiedCreatureId = new System.Windows.Forms.Label();
            this.lblGroupMemberDiedIsLeader = new System.Windows.Forms.Label();
            this.lblGroupMemberDiedTooltip = new System.Windows.Forms.Label();
            this.grpGeneral.SuspendLayout();
            this.grpEventFlags.SuspendLayout();
            this.frmEventTimerCombat.SuspendLayout();
            this.frmEventAggro.SuspendLayout();
            this.frmEventSpellHit.SuspendLayout();
            this.frmEventEnterLOS.SuspendLayout();
            this.frmEventSummonedUnit.SuspendLayout();
            this.frmEventReceiveEmote.SuspendLayout();
            this.frmEventMovementInform.SuspendLayout();
            this.frmEventGroupMemberDied.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEvents
            // 
            this.lstEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnType,
            this.columnComment});
            this.lstEvents.FullRowSelect = true;
            this.lstEvents.GridLines = true;
            this.lstEvents.HideSelection = false;
            this.lstEvents.Location = new System.Drawing.Point(12, 50);
            this.lstEvents.MultiSelect = false;
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(390, 471);
            this.lstEvents.TabIndex = 0;
            this.lstEvents.UseCompatibleStateImageBehavior = false;
            this.lstEvents.View = System.Windows.Forms.View.Details;
            this.lstEvents.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstEvents_ColumnClick);
            this.lstEvents.SelectedIndexChanged += new System.EventHandler(this.lstEvents_SelectedIndexChanged);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            this.columnType.Width = 100;
            // 
            // columnComment
            // 
            this.columnComment.Text = "Comment";
            this.columnComment.Width = 225;
            // 
            // txtCreatureId
            // 
            this.txtCreatureId.Location = new System.Drawing.Point(657, 26);
            this.txtCreatureId.Name = "txtCreatureId";
            this.txtCreatureId.Size = new System.Drawing.Size(190, 21);
            this.txtCreatureId.TabIndex = 1;
            this.txtCreatureId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreatureId_KeyPress);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(853, 24);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 21);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblCreatureId
            // 
            this.lblCreatureId.AutoSize = true;
            this.lblCreatureId.Location = new System.Drawing.Point(571, 30);
            this.lblCreatureId.Name = "lblCreatureId";
            this.lblCreatureId.Size = new System.Drawing.Size(77, 12);
            this.lblCreatureId.TabIndex = 3;
            this.lblCreatureId.Text = "Creature Id:";
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.btnEventPhaseMask);
            this.grpGeneral.Controls.Add(this.lblEventComment);
            this.grpGeneral.Controls.Add(this.txtEventComment);
            this.grpGeneral.Controls.Add(this.lblScriptId3);
            this.grpGeneral.Controls.Add(this.lblScriptId2);
            this.grpGeneral.Controls.Add(this.lblScriptId1);
            this.grpGeneral.Controls.Add(this.grpEventFlags);
            this.grpGeneral.Controls.Add(this.btnEditScript3);
            this.grpGeneral.Controls.Add(this.btnEditScript2);
            this.grpGeneral.Controls.Add(this.btnEditScript1);
            this.grpGeneral.Controls.Add(this.txtScriptId3);
            this.grpGeneral.Controls.Add(this.txtScriptId2);
            this.grpGeneral.Controls.Add(this.txtScriptId1);
            this.grpGeneral.Controls.Add(this.lblEventCondition);
            this.grpGeneral.Controls.Add(this.btnEventCondition);
            this.grpGeneral.Controls.Add(this.lblEventPhaseMask);
            this.grpGeneral.Controls.Add(this.lblEventChance);
            this.grpGeneral.Controls.Add(this.txtEventChance);
            this.grpGeneral.Controls.Add(this.cmbEventType);
            this.grpGeneral.Controls.Add(this.lblEventType);
            this.grpGeneral.Controls.Add(this.lblEventId);
            this.grpGeneral.Controls.Add(this.txtEventId);
            this.grpGeneral.Enabled = false;
            this.grpGeneral.Location = new System.Drawing.Point(433, 51);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(495, 210);
            this.grpGeneral.TabIndex = 4;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General Settings";
            // 
            // btnEventPhaseMask
            // 
            this.btnEventPhaseMask.Location = new System.Drawing.Point(328, 118);
            this.btnEventPhaseMask.Name = "btnEventPhaseMask";
            this.btnEventPhaseMask.Size = new System.Drawing.Size(145, 21);
            this.btnEventPhaseMask.TabIndex = 35;
            this.btnEventPhaseMask.Text = "-NONE-";
            this.btnEventPhaseMask.UseVisualStyleBackColor = true;
            this.btnEventPhaseMask.Click += new System.EventHandler(this.btnEventPhaseMask_Click);
            // 
            // lblEventComment
            // 
            this.lblEventComment.AutoSize = true;
            this.lblEventComment.Location = new System.Drawing.Point(20, 182);
            this.lblEventComment.Name = "lblEventComment";
            this.lblEventComment.Size = new System.Drawing.Size(53, 12);
            this.lblEventComment.TabIndex = 34;
            this.lblEventComment.Text = "Comment:";
            // 
            // txtEventComment
            // 
            this.txtEventComment.Location = new System.Drawing.Point(92, 179);
            this.txtEventComment.Name = "txtEventComment";
            this.txtEventComment.Size = new System.Drawing.Size(381, 21);
            this.txtEventComment.TabIndex = 33;
            this.txtEventComment.Leave += new System.EventHandler(this.txtEventComment_Leave);
            // 
            // lblScriptId3
            // 
            this.lblScriptId3.AutoSize = true;
            this.lblScriptId3.Location = new System.Drawing.Point(20, 152);
            this.lblScriptId3.Name = "lblScriptId3";
            this.lblScriptId3.Size = new System.Drawing.Size(59, 12);
            this.lblScriptId3.TabIndex = 32;
            this.lblScriptId3.Text = "Script 3:";
            // 
            // lblScriptId2
            // 
            this.lblScriptId2.AutoSize = true;
            this.lblScriptId2.Location = new System.Drawing.Point(20, 122);
            this.lblScriptId2.Name = "lblScriptId2";
            this.lblScriptId2.Size = new System.Drawing.Size(59, 12);
            this.lblScriptId2.TabIndex = 31;
            this.lblScriptId2.Text = "Script 2:";
            // 
            // lblScriptId1
            // 
            this.lblScriptId1.AutoSize = true;
            this.lblScriptId1.Location = new System.Drawing.Point(20, 90);
            this.lblScriptId1.Name = "lblScriptId1";
            this.lblScriptId1.Size = new System.Drawing.Size(59, 12);
            this.lblScriptId1.TabIndex = 30;
            this.lblScriptId1.Text = "Script 1:";
            // 
            // grpEventFlags
            // 
            this.grpEventFlags.Controls.Add(this.chkEventFlag4);
            this.grpEventFlags.Controls.Add(this.chkEventFlag2);
            this.grpEventFlags.Controls.Add(this.chkEventFlag1);
            this.grpEventFlags.Location = new System.Drawing.Point(259, 18);
            this.grpEventFlags.Name = "grpEventFlags";
            this.grpEventFlags.Size = new System.Drawing.Size(214, 66);
            this.grpEventFlags.TabIndex = 10;
            this.grpEventFlags.TabStop = false;
            this.grpEventFlags.Text = "Event Flags";
            // 
            // chkEventFlag4
            // 
            this.chkEventFlag4.AutoSize = true;
            this.chkEventFlag4.Location = new System.Drawing.Point(116, 18);
            this.chkEventFlag4.Name = "chkEventFlag4";
            this.chkEventFlag4.Size = new System.Drawing.Size(84, 16);
            this.chkEventFlag4.TabIndex = 2;
            this.chkEventFlag4.Text = "Debug Only";
            this.chkEventFlag4.UseVisualStyleBackColor = true;
            this.chkEventFlag4.CheckedChanged += new System.EventHandler(this.chkEventFlag4_CheckedChanged);
            // 
            // chkEventFlag2
            // 
            this.chkEventFlag2.AutoSize = true;
            this.chkEventFlag2.Location = new System.Drawing.Point(6, 40);
            this.chkEventFlag2.Name = "chkEventFlag2";
            this.chkEventFlag2.Size = new System.Drawing.Size(150, 16);
            this.chkEventFlag2.TabIndex = 1;
            this.chkEventFlag2.Text = "Chooses Random Script";
            this.chkEventFlag2.UseVisualStyleBackColor = true;
            this.chkEventFlag2.CheckedChanged += new System.EventHandler(this.chkEventFlag2_CheckedChanged);
            // 
            // chkEventFlag1
            // 
            this.chkEventFlag1.AutoSize = true;
            this.chkEventFlag1.Location = new System.Drawing.Point(6, 18);
            this.chkEventFlag1.Name = "chkEventFlag1";
            this.chkEventFlag1.Size = new System.Drawing.Size(84, 16);
            this.chkEventFlag1.TabIndex = 0;
            this.chkEventFlag1.Text = "Repeatable";
            this.chkEventFlag1.UseVisualStyleBackColor = true;
            this.chkEventFlag1.CheckedChanged += new System.EventHandler(this.chkEventFlag1_CheckedChanged);
            // 
            // btnEditScript3
            // 
            this.btnEditScript3.Location = new System.Drawing.Point(191, 146);
            this.btnEditScript3.Name = "btnEditScript3";
            this.btnEditScript3.Size = new System.Drawing.Size(44, 20);
            this.btnEditScript3.TabIndex = 29;
            this.btnEditScript3.Text = "Edit";
            this.btnEditScript3.UseVisualStyleBackColor = true;
            this.btnEditScript3.Click += new System.EventHandler(this.btnEditScript3_Click);
            // 
            // btnEditScript2
            // 
            this.btnEditScript2.Location = new System.Drawing.Point(191, 115);
            this.btnEditScript2.Name = "btnEditScript2";
            this.btnEditScript2.Size = new System.Drawing.Size(44, 20);
            this.btnEditScript2.TabIndex = 28;
            this.btnEditScript2.Text = "Edit";
            this.btnEditScript2.UseVisualStyleBackColor = true;
            this.btnEditScript2.Click += new System.EventHandler(this.btnEditScript2_Click);
            // 
            // btnEditScript1
            // 
            this.btnEditScript1.Location = new System.Drawing.Point(192, 85);
            this.btnEditScript1.Name = "btnEditScript1";
            this.btnEditScript1.Size = new System.Drawing.Size(44, 20);
            this.btnEditScript1.TabIndex = 27;
            this.btnEditScript1.Text = "Edit";
            this.btnEditScript1.UseVisualStyleBackColor = true;
            this.btnEditScript1.Click += new System.EventHandler(this.btnEditScript1_Click);
            // 
            // txtScriptId3
            // 
            this.txtScriptId3.Location = new System.Drawing.Point(92, 146);
            this.txtScriptId3.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtScriptId3.Name = "txtScriptId3";
            this.txtScriptId3.Size = new System.Drawing.Size(90, 21);
            this.txtScriptId3.TabIndex = 26;
            this.txtScriptId3.Leave += new System.EventHandler(this.txtScriptId3_Leave);
            // 
            // txtScriptId2
            // 
            this.txtScriptId2.Location = new System.Drawing.Point(92, 115);
            this.txtScriptId2.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtScriptId2.Name = "txtScriptId2";
            this.txtScriptId2.Size = new System.Drawing.Size(90, 21);
            this.txtScriptId2.TabIndex = 25;
            this.txtScriptId2.Leave += new System.EventHandler(this.txtScriptId2_Leave);
            // 
            // txtScriptId1
            // 
            this.txtScriptId1.Location = new System.Drawing.Point(92, 85);
            this.txtScriptId1.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtScriptId1.Name = "txtScriptId1";
            this.txtScriptId1.Size = new System.Drawing.Size(90, 21);
            this.txtScriptId1.TabIndex = 24;
            this.txtScriptId1.Leave += new System.EventHandler(this.txtScriptId1_Leave);
            // 
            // lblEventCondition
            // 
            this.lblEventCondition.AutoSize = true;
            this.lblEventCondition.Location = new System.Drawing.Point(250, 150);
            this.lblEventCondition.Name = "lblEventCondition";
            this.lblEventCondition.Size = new System.Drawing.Size(65, 12);
            this.lblEventCondition.TabIndex = 9;
            this.lblEventCondition.Text = "Condition:";
            // 
            // btnEventCondition
            // 
            this.btnEventCondition.Location = new System.Drawing.Point(328, 146);
            this.btnEventCondition.Name = "btnEventCondition";
            this.btnEventCondition.Size = new System.Drawing.Size(145, 21);
            this.btnEventCondition.TabIndex = 8;
            this.btnEventCondition.Text = "-NONE-";
            this.btnEventCondition.UseVisualStyleBackColor = true;
            this.btnEventCondition.Click += new System.EventHandler(this.btnEventCondition_Click);
            // 
            // lblEventPhaseMask
            // 
            this.lblEventPhaseMask.AutoSize = true;
            this.lblEventPhaseMask.Location = new System.Drawing.Point(244, 121);
            this.lblEventPhaseMask.Name = "lblEventPhaseMask";
            this.lblEventPhaseMask.Size = new System.Drawing.Size(71, 12);
            this.lblEventPhaseMask.TabIndex = 7;
            this.lblEventPhaseMask.Text = "Phase Mask:";
            // 
            // lblEventChance
            // 
            this.lblEventChance.AutoSize = true;
            this.lblEventChance.Location = new System.Drawing.Point(268, 92);
            this.lblEventChance.Name = "lblEventChance";
            this.lblEventChance.Size = new System.Drawing.Size(47, 12);
            this.lblEventChance.TabIndex = 5;
            this.lblEventChance.Text = "Chance:";
            // 
            // txtEventChance
            // 
            this.txtEventChance.Location = new System.Drawing.Point(328, 90);
            this.txtEventChance.Name = "txtEventChance";
            this.txtEventChance.Size = new System.Drawing.Size(145, 21);
            this.txtEventChance.TabIndex = 4;
            this.txtEventChance.Leave += new System.EventHandler(this.txtEventChance_Leave);
            // 
            // cmbEventType
            // 
            this.cmbEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventType.FormattingEnabled = true;
            this.cmbEventType.Location = new System.Drawing.Point(92, 55);
            this.cmbEventType.Name = "cmbEventType";
            this.cmbEventType.Size = new System.Drawing.Size(145, 20);
            this.cmbEventType.TabIndex = 3;
            this.cmbEventType.SelectedIndexChanged += new System.EventHandler(this.cmbEventType_SelectedIndexChanged);
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(44, 58);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(35, 12);
            this.lblEventType.TabIndex = 2;
            this.lblEventType.Text = "Type:";
            // 
            // lblEventId
            // 
            this.lblEventId.AutoSize = true;
            this.lblEventId.Location = new System.Drawing.Point(56, 30);
            this.lblEventId.Name = "lblEventId";
            this.lblEventId.Size = new System.Drawing.Size(23, 12);
            this.lblEventId.TabIndex = 1;
            this.lblEventId.Text = "Id:";
            // 
            // txtEventId
            // 
            this.txtEventId.Location = new System.Drawing.Point(92, 27);
            this.txtEventId.Name = "txtEventId";
            this.txtEventId.Size = new System.Drawing.Size(145, 21);
            this.txtEventId.TabIndex = 0;
            this.txtEventId.Leave += new System.EventHandler(this.txtEventId_Leave);
            // 
            // frmEventTimerCombat
            // 
            this.frmEventTimerCombat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmEventTimerCombat.Controls.Add(this.txtTimerRepeatMax);
            this.frmEventTimerCombat.Controls.Add(this.lblTimerRepeatMax);
            this.frmEventTimerCombat.Controls.Add(this.txtTimerRepeatMin);
            this.frmEventTimerCombat.Controls.Add(this.txtTimerInitialMax);
            this.frmEventTimerCombat.Controls.Add(this.txtTimerInitialMin);
            this.frmEventTimerCombat.Controls.Add(this.lblTimerRepeatMin);
            this.frmEventTimerCombat.Controls.Add(this.lblTimerInitialMin);
            this.frmEventTimerCombat.Controls.Add(this.lblTimerInitialMax);
            this.frmEventTimerCombat.Controls.Add(this.lblEventTimerCombatTooltip);
            this.frmEventTimerCombat.Location = new System.Drawing.Point(433, 267);
            this.frmEventTimerCombat.Name = "frmEventTimerCombat";
            this.frmEventTimerCombat.Size = new System.Drawing.Size(495, 254);
            this.frmEventTimerCombat.TabIndex = 54;
            this.frmEventTimerCombat.Visible = false;
            // 
            // txtTimerRepeatMax
            // 
            this.txtTimerRepeatMax.Location = new System.Drawing.Point(99, 137);
            this.txtTimerRepeatMax.Name = "txtTimerRepeatMax";
            this.txtTimerRepeatMax.Size = new System.Drawing.Size(374, 21);
            this.txtTimerRepeatMax.TabIndex = 12;
            this.txtTimerRepeatMax.Leave += new System.EventHandler(this.txtTimerRepeatMax_Leave);
            // 
            // lblTimerRepeatMax
            // 
            this.lblTimerRepeatMax.AutoSize = true;
            this.lblTimerRepeatMax.Location = new System.Drawing.Point(30, 139);
            this.lblTimerRepeatMax.Name = "lblTimerRepeatMax";
            this.lblTimerRepeatMax.Size = new System.Drawing.Size(71, 12);
            this.lblTimerRepeatMax.TabIndex = 11;
            this.lblTimerRepeatMax.Text = "Repeat Max:";
            // 
            // txtTimerRepeatMin
            // 
            this.txtTimerRepeatMin.Location = new System.Drawing.Point(99, 109);
            this.txtTimerRepeatMin.Name = "txtTimerRepeatMin";
            this.txtTimerRepeatMin.Size = new System.Drawing.Size(374, 21);
            this.txtTimerRepeatMin.TabIndex = 10;
            this.txtTimerRepeatMin.Leave += new System.EventHandler(this.txtTimerRepeatMin_Leave);
            // 
            // txtTimerInitialMax
            // 
            this.txtTimerInitialMax.Location = new System.Drawing.Point(99, 81);
            this.txtTimerInitialMax.Name = "txtTimerInitialMax";
            this.txtTimerInitialMax.Size = new System.Drawing.Size(374, 21);
            this.txtTimerInitialMax.TabIndex = 9;
            this.txtTimerInitialMax.Leave += new System.EventHandler(this.txtTimerInitialMax_Leave);
            // 
            // txtTimerInitialMin
            // 
            this.txtTimerInitialMin.Location = new System.Drawing.Point(99, 54);
            this.txtTimerInitialMin.Name = "txtTimerInitialMin";
            this.txtTimerInitialMin.Size = new System.Drawing.Size(374, 21);
            this.txtTimerInitialMin.TabIndex = 8;
            this.txtTimerInitialMin.Leave += new System.EventHandler(this.txtTimerInitialMin_Leave);
            // 
            // lblTimerRepeatMin
            // 
            this.lblTimerRepeatMin.AutoSize = true;
            this.lblTimerRepeatMin.Location = new System.Drawing.Point(33, 112);
            this.lblTimerRepeatMin.Name = "lblTimerRepeatMin";
            this.lblTimerRepeatMin.Size = new System.Drawing.Size(71, 12);
            this.lblTimerRepeatMin.TabIndex = 6;
            this.lblTimerRepeatMin.Text = "Repeat Min:";
            // 
            // lblTimerInitialMin
            // 
            this.lblTimerInitialMin.AutoSize = true;
            this.lblTimerInitialMin.Location = new System.Drawing.Point(44, 56);
            this.lblTimerInitialMin.Name = "lblTimerInitialMin";
            this.lblTimerInitialMin.Size = new System.Drawing.Size(77, 12);
            this.lblTimerInitialMin.TabIndex = 4;
            this.lblTimerInitialMin.Text = "Initial Min:";
            // 
            // lblTimerInitialMax
            // 
            this.lblTimerInitialMax.AutoSize = true;
            this.lblTimerInitialMax.Location = new System.Drawing.Point(41, 84);
            this.lblTimerInitialMax.Name = "lblTimerInitialMax";
            this.lblTimerInitialMax.Size = new System.Drawing.Size(77, 12);
            this.lblTimerInitialMax.TabIndex = 3;
            this.lblTimerInitialMax.Text = "Initial Max:";
            // 
            // lblEventTimerCombatTooltip
            // 
            this.lblEventTimerCombatTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEventTimerCombatTooltip.Location = new System.Drawing.Point(20, 9);
            this.lblEventTimerCombatTooltip.Name = "lblEventTimerCombatTooltip";
            this.lblEventTimerCombatTooltip.Size = new System.Drawing.Size(453, 30);
            this.lblEventTimerCombatTooltip.TabIndex = 0;
            this.lblEventTimerCombatTooltip.Text = "A timed event that expires after the specified amount of miliseconds have passed." +
    " Only while the creature is in combat.";
            // 
            // lblCurrentCreature
            // 
            this.lblCurrentCreature.AutoSize = true;
            this.lblCurrentCreature.Location = new System.Drawing.Point(12, 29);
            this.lblCurrentCreature.Name = "lblCurrentCreature";
            this.lblCurrentCreature.Size = new System.Drawing.Size(131, 12);
            this.lblCurrentCreature.TabIndex = 55;
            this.lblCurrentCreature.Text = "No event list loaded.";
            // 
            // btnEventCopy
            // 
            this.btnEventCopy.Location = new System.Drawing.Point(245, 527);
            this.btnEventCopy.Name = "btnEventCopy";
            this.btnEventCopy.Size = new System.Drawing.Size(75, 21);
            this.btnEventCopy.TabIndex = 58;
            this.btnEventCopy.Text = "Copy";
            this.btnEventCopy.UseVisualStyleBackColor = true;
            this.btnEventCopy.Click += new System.EventHandler(this.btnEventCopy_Click);
            // 
            // btnEventAdd
            // 
            this.btnEventAdd.Location = new System.Drawing.Point(164, 527);
            this.btnEventAdd.Name = "btnEventAdd";
            this.btnEventAdd.Size = new System.Drawing.Size(75, 21);
            this.btnEventAdd.TabIndex = 57;
            this.btnEventAdd.Text = "Add";
            this.btnEventAdd.UseVisualStyleBackColor = true;
            this.btnEventAdd.Click += new System.EventHandler(this.btnEventAdd_Click);
            // 
            // btnEventDelete
            // 
            this.btnEventDelete.Location = new System.Drawing.Point(326, 527);
            this.btnEventDelete.Name = "btnEventDelete";
            this.btnEventDelete.Size = new System.Drawing.Size(75, 21);
            this.btnEventDelete.TabIndex = 56;
            this.btnEventDelete.Text = "Delete";
            this.btnEventDelete.UseVisualStyleBackColor = true;
            this.btnEventDelete.Click += new System.EventHandler(this.btnEventDelete_Click);
            // 
            // btnViewRaw
            // 
            this.btnViewRaw.Location = new System.Drawing.Point(773, 527);
            this.btnViewRaw.Name = "btnViewRaw";
            this.btnViewRaw.Size = new System.Drawing.Size(75, 21);
            this.btnViewRaw.TabIndex = 60;
            this.btnViewRaw.Text = "View Raw";
            this.btnViewRaw.UseVisualStyleBackColor = true;
            this.btnViewRaw.Click += new System.EventHandler(this.btnViewRaw_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(853, 527);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 21);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNoEvent
            // 
            this.lblNoEvent.AutoSize = true;
            this.lblNoEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoEvent.Location = new System.Drawing.Point(601, 384);
            this.lblNoEvent.Name = "lblNoEvent";
            this.lblNoEvent.Size = new System.Drawing.Size(158, 20);
            this.lblNoEvent.TabIndex = 61;
            this.lblNoEvent.Text = "No Event Selected";
            // 
            // frmEventAggro
            // 
            this.frmEventAggro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmEventAggro.Controls.Add(this.lblEventAggroTooltip);
            this.frmEventAggro.Location = new System.Drawing.Point(433, 267);
            this.frmEventAggro.Name = "frmEventAggro";
            this.frmEventAggro.Size = new System.Drawing.Size(495, 254);
            this.frmEventAggro.TabIndex = 62;
            this.frmEventAggro.Visible = false;
            // 
            // lblEventAggroTooltip
            // 
            this.lblEventAggroTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEventAggroTooltip.Location = new System.Drawing.Point(20, 9);
            this.lblEventAggroTooltip.Name = "lblEventAggroTooltip";
            this.lblEventAggroTooltip.Size = new System.Drawing.Size(453, 30);
            this.lblEventAggroTooltip.TabIndex = 0;
            this.lblEventAggroTooltip.Text = "Expires upon initial aggro, does not repeat. This event has no additional paramet" +
    "ers.";
            // 
            // frmEventSpellHit
            // 
            this.frmEventSpellHit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmEventSpellHit.Controls.Add(this.btnSpellHitSpellId);
            this.frmEventSpellHit.Controls.Add(this.txtSpellHitRepeatMax);
            this.frmEventSpellHit.Controls.Add(this.lblSpellHitRepeatMax);
            this.frmEventSpellHit.Controls.Add(this.txtSpellHitRepeatMin);
            this.frmEventSpellHit.Controls.Add(this.txtSpellHitSchoolMask);
            this.frmEventSpellHit.Controls.Add(this.lblSpellHitRepeatMin);
            this.frmEventSpellHit.Controls.Add(this.lblSpellHitSpellId);
            this.frmEventSpellHit.Controls.Add(this.lblSpellHitSchoolMask);
            this.frmEventSpellHit.Controls.Add(this.lblEventSpellHitTooltip);
            this.frmEventSpellHit.Location = new System.Drawing.Point(433, 267);
            this.frmEventSpellHit.Name = "frmEventSpellHit";
            this.frmEventSpellHit.Size = new System.Drawing.Size(495, 254);
            this.frmEventSpellHit.TabIndex = 63;
            this.frmEventSpellHit.Visible = false;
            // 
            // btnSpellHitSpellId
            // 
            this.btnSpellHitSpellId.Location = new System.Drawing.Point(99, 54);
            this.btnSpellHitSpellId.Name = "btnSpellHitSpellId";
            this.btnSpellHitSpellId.Size = new System.Drawing.Size(374, 21);
            this.btnSpellHitSpellId.TabIndex = 13;
            this.btnSpellHitSpellId.Text = "-NONE-";
            this.btnSpellHitSpellId.UseVisualStyleBackColor = true;
            this.btnSpellHitSpellId.Click += new System.EventHandler(this.btnSpellHitSpellId_Click);
            // 
            // txtSpellHitRepeatMax
            // 
            this.txtSpellHitRepeatMax.Location = new System.Drawing.Point(99, 137);
            this.txtSpellHitRepeatMax.Name = "txtSpellHitRepeatMax";
            this.txtSpellHitRepeatMax.Size = new System.Drawing.Size(374, 21);
            this.txtSpellHitRepeatMax.TabIndex = 12;
            this.txtSpellHitRepeatMax.Leave += new System.EventHandler(this.txtSpellHitRepeatMax_Leave);
            // 
            // lblSpellHitRepeatMax
            // 
            this.lblSpellHitRepeatMax.AutoSize = true;
            this.lblSpellHitRepeatMax.Location = new System.Drawing.Point(27, 139);
            this.lblSpellHitRepeatMax.Name = "lblSpellHitRepeatMax";
            this.lblSpellHitRepeatMax.Size = new System.Drawing.Size(71, 12);
            this.lblSpellHitRepeatMax.TabIndex = 11;
            this.lblSpellHitRepeatMax.Text = "Repeat Max:";
            // 
            // txtSpellHitRepeatMin
            // 
            this.txtSpellHitRepeatMin.Location = new System.Drawing.Point(99, 109);
            this.txtSpellHitRepeatMin.Name = "txtSpellHitRepeatMin";
            this.txtSpellHitRepeatMin.Size = new System.Drawing.Size(374, 21);
            this.txtSpellHitRepeatMin.TabIndex = 10;
            this.txtSpellHitRepeatMin.Leave += new System.EventHandler(this.txtSpellHitRepeatMin_Leave);
            // 
            // txtSpellHitSchoolMask
            // 
            this.txtSpellHitSchoolMask.Location = new System.Drawing.Point(99, 81);
            this.txtSpellHitSchoolMask.Name = "txtSpellHitSchoolMask";
            this.txtSpellHitSchoolMask.Size = new System.Drawing.Size(374, 21);
            this.txtSpellHitSchoolMask.TabIndex = 9;
            this.txtSpellHitSchoolMask.Leave += new System.EventHandler(this.txtSpellHitSchoolMask_Leave);
            // 
            // lblSpellHitRepeatMin
            // 
            this.lblSpellHitRepeatMin.AutoSize = true;
            this.lblSpellHitRepeatMin.Location = new System.Drawing.Point(30, 112);
            this.lblSpellHitRepeatMin.Name = "lblSpellHitRepeatMin";
            this.lblSpellHitRepeatMin.Size = new System.Drawing.Size(71, 12);
            this.lblSpellHitRepeatMin.TabIndex = 6;
            this.lblSpellHitRepeatMin.Text = "Repeat Min:";
            // 
            // lblSpellHitSpellId
            // 
            this.lblSpellHitSpellId.AutoSize = true;
            this.lblSpellHitSpellId.Location = new System.Drawing.Point(50, 56);
            this.lblSpellHitSpellId.Name = "lblSpellHitSpellId";
            this.lblSpellHitSpellId.Size = new System.Drawing.Size(59, 12);
            this.lblSpellHitSpellId.TabIndex = 4;
            this.lblSpellHitSpellId.Text = "Spell Id:";
            // 
            // lblSpellHitSchoolMask
            // 
            this.lblSpellHitSchoolMask.AutoSize = true;
            this.lblSpellHitSchoolMask.Location = new System.Drawing.Point(23, 84);
            this.lblSpellHitSchoolMask.Name = "lblSpellHitSchoolMask";
            this.lblSpellHitSchoolMask.Size = new System.Drawing.Size(77, 12);
            this.lblSpellHitSchoolMask.TabIndex = 3;
            this.lblSpellHitSchoolMask.Text = "School Mask:";
            // 
            // lblEventSpellHitTooltip
            // 
            this.lblEventSpellHitTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEventSpellHitTooltip.Location = new System.Drawing.Point(20, 9);
            this.lblEventSpellHitTooltip.Name = "lblEventSpellHitTooltip";
            this.lblEventSpellHitTooltip.Size = new System.Drawing.Size(453, 30);
            this.lblEventSpellHitTooltip.TabIndex = 0;
            this.lblEventSpellHitTooltip.Text = "Expires when the creature is hit by a spell. If a spell Id is set, it will only e" +
    "xpire when hit by that spell. Same logic applies when a school mask is set.";
            // 
            // frmEventEnterLOS
            // 
            this.frmEventEnterLOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmEventEnterLOS.Controls.Add(this.cmbEnterLOSFaction);
            this.frmEventEnterLOS.Controls.Add(this.txtEnterLOSRepeatMax);
            this.frmEventEnterLOS.Controls.Add(this.lblEnterLOSRepeatMax);
            this.frmEventEnterLOS.Controls.Add(this.txtEnterLOSRepeatMin);
            this.frmEventEnterLOS.Controls.Add(this.txtEnterLOSDistance);
            this.frmEventEnterLOS.Controls.Add(this.lblEnterLOSRepeatMin);
            this.frmEventEnterLOS.Controls.Add(this.lblEnterLOSFaction);
            this.frmEventEnterLOS.Controls.Add(this.lblEnterLOSDistance);
            this.frmEventEnterLOS.Controls.Add(this.lblEventEnterLOSTooltip);
            this.frmEventEnterLOS.Location = new System.Drawing.Point(433, 267);
            this.frmEventEnterLOS.Name = "frmEventEnterLOS";
            this.frmEventEnterLOS.Size = new System.Drawing.Size(495, 254);
            this.frmEventEnterLOS.TabIndex = 64;
            this.frmEventEnterLOS.Visible = false;
            // 
            // cmbEnterLOSFaction
            // 
            this.cmbEnterLOSFaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnterLOSFaction.FormattingEnabled = true;
            this.cmbEnterLOSFaction.Items.AddRange(new object[] {
            "Hostile",
            "Friendly"});
            this.cmbEnterLOSFaction.Location = new System.Drawing.Point(99, 54);
            this.cmbEnterLOSFaction.Name = "cmbEnterLOSFaction";
            this.cmbEnterLOSFaction.Size = new System.Drawing.Size(374, 20);
            this.cmbEnterLOSFaction.TabIndex = 14;
            this.cmbEnterLOSFaction.SelectedIndexChanged += new System.EventHandler(this.cmbEnterLOSFaction_SelectedIndexChanged);
            // 
            // txtEnterLOSRepeatMax
            // 
            this.txtEnterLOSRepeatMax.Location = new System.Drawing.Point(99, 137);
            this.txtEnterLOSRepeatMax.Name = "txtEnterLOSRepeatMax";
            this.txtEnterLOSRepeatMax.Size = new System.Drawing.Size(374, 21);
            this.txtEnterLOSRepeatMax.TabIndex = 12;
            this.txtEnterLOSRepeatMax.Leave += new System.EventHandler(this.txtEnterLOSRepeatMax_Leave);
            // 
            // lblEnterLOSRepeatMax
            // 
            this.lblEnterLOSRepeatMax.AutoSize = true;
            this.lblEnterLOSRepeatMax.Location = new System.Drawing.Point(27, 139);
            this.lblEnterLOSRepeatMax.Name = "lblEnterLOSRepeatMax";
            this.lblEnterLOSRepeatMax.Size = new System.Drawing.Size(71, 12);
            this.lblEnterLOSRepeatMax.TabIndex = 11;
            this.lblEnterLOSRepeatMax.Text = "Repeat Max:";
            // 
            // txtEnterLOSRepeatMin
            // 
            this.txtEnterLOSRepeatMin.Location = new System.Drawing.Point(99, 109);
            this.txtEnterLOSRepeatMin.Name = "txtEnterLOSRepeatMin";
            this.txtEnterLOSRepeatMin.Size = new System.Drawing.Size(374, 21);
            this.txtEnterLOSRepeatMin.TabIndex = 10;
            this.txtEnterLOSRepeatMin.Leave += new System.EventHandler(this.txtEnterLOSRepeatMin_Leave);
            // 
            // txtEnterLOSDistance
            // 
            this.txtEnterLOSDistance.Location = new System.Drawing.Point(99, 81);
            this.txtEnterLOSDistance.Name = "txtEnterLOSDistance";
            this.txtEnterLOSDistance.Size = new System.Drawing.Size(374, 21);
            this.txtEnterLOSDistance.TabIndex = 9;
            this.txtEnterLOSDistance.Leave += new System.EventHandler(this.txtEnterLOSDistance_Leave);
            // 
            // lblEnterLOSRepeatMin
            // 
            this.lblEnterLOSRepeatMin.AutoSize = true;
            this.lblEnterLOSRepeatMin.Location = new System.Drawing.Point(30, 112);
            this.lblEnterLOSRepeatMin.Name = "lblEnterLOSRepeatMin";
            this.lblEnterLOSRepeatMin.Size = new System.Drawing.Size(71, 12);
            this.lblEnterLOSRepeatMin.TabIndex = 6;
            this.lblEnterLOSRepeatMin.Text = "Repeat Min:";
            // 
            // lblEnterLOSFaction
            // 
            this.lblEnterLOSFaction.AutoSize = true;
            this.lblEnterLOSFaction.Location = new System.Drawing.Point(50, 56);
            this.lblEnterLOSFaction.Name = "lblEnterLOSFaction";
            this.lblEnterLOSFaction.Size = new System.Drawing.Size(53, 12);
            this.lblEnterLOSFaction.TabIndex = 4;
            this.lblEnterLOSFaction.Text = "Faction:";
            // 
            // lblEnterLOSDistance
            // 
            this.lblEnterLOSDistance.AutoSize = true;
            this.lblEnterLOSDistance.Location = new System.Drawing.Point(43, 84);
            this.lblEnterLOSDistance.Name = "lblEnterLOSDistance";
            this.lblEnterLOSDistance.Size = new System.Drawing.Size(59, 12);
            this.lblEnterLOSDistance.TabIndex = 3;
            this.lblEnterLOSDistance.Text = "Distance:";
            // 
            // lblEventEnterLOSTooltip
            // 
            this.lblEventEnterLOSTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEventEnterLOSTooltip.Location = new System.Drawing.Point(20, 9);
            this.lblEventEnterLOSTooltip.Name = "lblEventEnterLOSTooltip";
            this.lblEventEnterLOSTooltip.Size = new System.Drawing.Size(453, 30);
            this.lblEventEnterLOSTooltip.TabIndex = 0;
            this.lblEventEnterLOSTooltip.Text = "Expires when an unit moves within visible distance of the creature. Only while th" +
    "e creature is out of combat.";
            // 
            // frmEventSummonedUnit
            // 
            this.frmEventSummonedUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmEventSummonedUnit.Controls.Add(this.btnSummonedUnitId);
            this.frmEventSummonedUnit.Controls.Add(this.txtSummonedUnitRepeatMax);
            this.frmEventSummonedUnit.Controls.Add(this.txtSummonedUnitRepeatMin);
            this.frmEventSummonedUnit.Controls.Add(this.lblSummonedUnitRepeatMax);
            this.frmEventSummonedUnit.Controls.Add(this.lblSummonedUnitId);
            this.frmEventSummonedUnit.Controls.Add(this.lblSummonedUnitRepeatMin);
            this.frmEventSummonedUnit.Controls.Add(this.lblEventSummonedUnitTooltip);
            this.frmEventSummonedUnit.Location = new System.Drawing.Point(433, 267);
            this.frmEventSummonedUnit.Name = "frmEventSummonedUnit";
            this.frmEventSummonedUnit.Size = new System.Drawing.Size(495, 254);
            this.frmEventSummonedUnit.TabIndex = 65;
            this.frmEventSummonedUnit.Visible = false;
            // 
            // btnSummonedUnitId
            // 
            this.btnSummonedUnitId.Location = new System.Drawing.Point(99, 54);
            this.btnSummonedUnitId.Name = "btnSummonedUnitId";
            this.btnSummonedUnitId.Size = new System.Drawing.Size(374, 21);
            this.btnSummonedUnitId.TabIndex = 13;
            this.btnSummonedUnitId.Text = "-NONE-";
            this.btnSummonedUnitId.UseVisualStyleBackColor = true;
            this.btnSummonedUnitId.Click += new System.EventHandler(this.btnSummonedUnitId_Click);
            // 
            // txtSummonedUnitRepeatMax
            // 
            this.txtSummonedUnitRepeatMax.Location = new System.Drawing.Point(99, 109);
            this.txtSummonedUnitRepeatMax.Name = "txtSummonedUnitRepeatMax";
            this.txtSummonedUnitRepeatMax.Size = new System.Drawing.Size(374, 21);
            this.txtSummonedUnitRepeatMax.TabIndex = 10;
            this.txtSummonedUnitRepeatMax.Leave += new System.EventHandler(this.txtSummonedUnitRepeatMax_Leave);
            // 
            // txtSummonedUnitRepeatMin
            // 
            this.txtSummonedUnitRepeatMin.Location = new System.Drawing.Point(99, 81);
            this.txtSummonedUnitRepeatMin.Name = "txtSummonedUnitRepeatMin";
            this.txtSummonedUnitRepeatMin.Size = new System.Drawing.Size(374, 21);
            this.txtSummonedUnitRepeatMin.TabIndex = 9;
            this.txtSummonedUnitRepeatMin.Leave += new System.EventHandler(this.txtSummonedUnitRepeatMin_Leave);
            // 
            // lblSummonedUnitRepeatMax
            // 
            this.lblSummonedUnitRepeatMax.AutoSize = true;
            this.lblSummonedUnitRepeatMax.Location = new System.Drawing.Point(27, 112);
            this.lblSummonedUnitRepeatMax.Name = "lblSummonedUnitRepeatMax";
            this.lblSummonedUnitRepeatMax.Size = new System.Drawing.Size(71, 12);
            this.lblSummonedUnitRepeatMax.TabIndex = 6;
            this.lblSummonedUnitRepeatMax.Text = "Repeat Max:";
            // 
            // lblSummonedUnitId
            // 
            this.lblSummonedUnitId.AutoSize = true;
            this.lblSummonedUnitId.Location = new System.Drawing.Point(33, 56);
            this.lblSummonedUnitId.Name = "lblSummonedUnitId";
            this.lblSummonedUnitId.Size = new System.Drawing.Size(77, 12);
            this.lblSummonedUnitId.TabIndex = 4;
            this.lblSummonedUnitId.Text = "Creature Id:";
            // 
            // lblSummonedUnitRepeatMin
            // 
            this.lblSummonedUnitRepeatMin.AutoSize = true;
            this.lblSummonedUnitRepeatMin.Location = new System.Drawing.Point(30, 84);
            this.lblSummonedUnitRepeatMin.Name = "lblSummonedUnitRepeatMin";
            this.lblSummonedUnitRepeatMin.Size = new System.Drawing.Size(71, 12);
            this.lblSummonedUnitRepeatMin.TabIndex = 3;
            this.lblSummonedUnitRepeatMin.Text = "Repeat Min:";
            // 
            // lblEventSummonedUnitTooltip
            // 
            this.lblEventSummonedUnitTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEventSummonedUnitTooltip.Location = new System.Drawing.Point(20, 9);
            this.lblEventSummonedUnitTooltip.Name = "lblEventSummonedUnitTooltip";
            this.lblEventSummonedUnitTooltip.Size = new System.Drawing.Size(453, 30);
            this.lblEventSummonedUnitTooltip.TabIndex = 0;
            this.lblEventSummonedUnitTooltip.Text = "Expires after summoning another creature with the given Id.";
            // 
            // frmEventReceiveEmote
            // 
            this.frmEventReceiveEmote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmEventReceiveEmote.Controls.Add(this.cmbReceiveEmoteId);
            this.frmEventReceiveEmote.Controls.Add(this.lblReceiveEmoteId);
            this.frmEventReceiveEmote.Controls.Add(this.lblEventReceiveEmoteTooltip);
            this.frmEventReceiveEmote.Location = new System.Drawing.Point(433, 267);
            this.frmEventReceiveEmote.Name = "frmEventReceiveEmote";
            this.frmEventReceiveEmote.Size = new System.Drawing.Size(495, 254);
            this.frmEventReceiveEmote.TabIndex = 66;
            this.frmEventReceiveEmote.Visible = false;
            // 
            // cmbReceiveEmoteId
            // 
            this.cmbReceiveEmoteId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReceiveEmoteId.FormattingEnabled = true;
            this.cmbReceiveEmoteId.Items.AddRange(new object[] {
            "Hostile",
            "Friendly"});
            this.cmbReceiveEmoteId.Location = new System.Drawing.Point(99, 54);
            this.cmbReceiveEmoteId.Name = "cmbReceiveEmoteId";
            this.cmbReceiveEmoteId.Size = new System.Drawing.Size(375, 20);
            this.cmbReceiveEmoteId.TabIndex = 14;
            this.cmbReceiveEmoteId.SelectedIndexChanged += new System.EventHandler(this.cmbReceiveEmoteId_SelectedIndexChanged);
            // 
            // lblReceiveEmoteId
            // 
            this.lblReceiveEmoteId.AutoSize = true;
            this.lblReceiveEmoteId.Location = new System.Drawing.Point(45, 56);
            this.lblReceiveEmoteId.Name = "lblReceiveEmoteId";
            this.lblReceiveEmoteId.Size = new System.Drawing.Size(59, 12);
            this.lblReceiveEmoteId.TabIndex = 4;
            this.lblReceiveEmoteId.Text = "Emote Id:";
            // 
            // lblEventReceiveEmoteTooltip
            // 
            this.lblEventReceiveEmoteTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEventReceiveEmoteTooltip.Location = new System.Drawing.Point(20, 9);
            this.lblEventReceiveEmoteTooltip.Name = "lblEventReceiveEmoteTooltip";
            this.lblEventReceiveEmoteTooltip.Size = new System.Drawing.Size(453, 30);
            this.lblEventReceiveEmoteTooltip.TabIndex = 0;
            this.lblEventReceiveEmoteTooltip.Text = "Expires when the creature receives a text emote with the specified id.";
            // 
            // frmEventMovementInform
            // 
            this.frmEventMovementInform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmEventMovementInform.Controls.Add(this.txtMovementInformType);
            this.frmEventMovementInform.Controls.Add(this.cmbMovementInformType);
            this.frmEventMovementInform.Controls.Add(this.txtMovementInformRepeatMax);
            this.frmEventMovementInform.Controls.Add(this.lblMovementInformRepeatMax);
            this.frmEventMovementInform.Controls.Add(this.txtMovementInformRepeatMin);
            this.frmEventMovementInform.Controls.Add(this.txtMovementInformPoint);
            this.frmEventMovementInform.Controls.Add(this.lblMovementInformRepeatMin);
            this.frmEventMovementInform.Controls.Add(this.lblMovementInformType);
            this.frmEventMovementInform.Controls.Add(this.lblMovementInformPoint);
            this.frmEventMovementInform.Controls.Add(this.lblEventMovementInformTooltip);
            this.frmEventMovementInform.Location = new System.Drawing.Point(433, 267);
            this.frmEventMovementInform.Name = "frmEventMovementInform";
            this.frmEventMovementInform.Size = new System.Drawing.Size(495, 254);
            this.frmEventMovementInform.TabIndex = 67;
            this.frmEventMovementInform.Visible = false;
            // 
            // txtMovementInformType
            // 
            this.txtMovementInformType.Location = new System.Drawing.Point(99, 54);
            this.txtMovementInformType.MinimumSize = new System.Drawing.Size(82, 21);
            this.txtMovementInformType.Name = "txtMovementInformType";
            this.txtMovementInformType.Size = new System.Drawing.Size(118, 21);
            this.txtMovementInformType.TabIndex = 15;
            this.txtMovementInformType.Leave += new System.EventHandler(this.txtMovementInformType_Leave);
            // 
            // cmbMovementInformType
            // 
            this.cmbMovementInformType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovementInformType.FormattingEnabled = true;
            this.cmbMovementInformType.Location = new System.Drawing.Point(223, 54);
            this.cmbMovementInformType.Name = "cmbMovementInformType";
            this.cmbMovementInformType.Size = new System.Drawing.Size(250, 20);
            this.cmbMovementInformType.TabIndex = 14;
            this.cmbMovementInformType.SelectedIndexChanged += new System.EventHandler(this.cmbMovementInformType_SelectedIndexChanged);
            // 
            // txtMovementInformRepeatMax
            // 
            this.txtMovementInformRepeatMax.Location = new System.Drawing.Point(99, 137);
            this.txtMovementInformRepeatMax.Name = "txtMovementInformRepeatMax";
            this.txtMovementInformRepeatMax.Size = new System.Drawing.Size(374, 21);
            this.txtMovementInformRepeatMax.TabIndex = 12;
            this.txtMovementInformRepeatMax.Leave += new System.EventHandler(this.txtMovementInformRepeatMax_Leave);
            // 
            // lblMovementInformRepeatMax
            // 
            this.lblMovementInformRepeatMax.AutoSize = true;
            this.lblMovementInformRepeatMax.Location = new System.Drawing.Point(27, 139);
            this.lblMovementInformRepeatMax.Name = "lblMovementInformRepeatMax";
            this.lblMovementInformRepeatMax.Size = new System.Drawing.Size(71, 12);
            this.lblMovementInformRepeatMax.TabIndex = 11;
            this.lblMovementInformRepeatMax.Text = "Repeat Max:";
            // 
            // txtMovementInformRepeatMin
            // 
            this.txtMovementInformRepeatMin.Location = new System.Drawing.Point(99, 109);
            this.txtMovementInformRepeatMin.Name = "txtMovementInformRepeatMin";
            this.txtMovementInformRepeatMin.Size = new System.Drawing.Size(374, 21);
            this.txtMovementInformRepeatMin.TabIndex = 10;
            this.txtMovementInformRepeatMin.Leave += new System.EventHandler(this.txtMovementInformRepeatMin_Leave);
            // 
            // txtMovementInformPoint
            // 
            this.txtMovementInformPoint.Location = new System.Drawing.Point(99, 81);
            this.txtMovementInformPoint.Name = "txtMovementInformPoint";
            this.txtMovementInformPoint.Size = new System.Drawing.Size(374, 21);
            this.txtMovementInformPoint.TabIndex = 9;
            this.txtMovementInformPoint.Leave += new System.EventHandler(this.txtMovementInformPoint_Leave);
            // 
            // lblMovementInformRepeatMin
            // 
            this.lblMovementInformRepeatMin.AutoSize = true;
            this.lblMovementInformRepeatMin.Location = new System.Drawing.Point(30, 112);
            this.lblMovementInformRepeatMin.Name = "lblMovementInformRepeatMin";
            this.lblMovementInformRepeatMin.Size = new System.Drawing.Size(71, 12);
            this.lblMovementInformRepeatMin.TabIndex = 6;
            this.lblMovementInformRepeatMin.Text = "Repeat Min:";
            // 
            // lblMovementInformType
            // 
            this.lblMovementInformType.AutoSize = true;
            this.lblMovementInformType.Location = new System.Drawing.Point(26, 56);
            this.lblMovementInformType.Name = "lblMovementInformType";
            this.lblMovementInformType.Size = new System.Drawing.Size(77, 12);
            this.lblMovementInformType.TabIndex = 4;
            this.lblMovementInformType.Text = "Motion Type:";
            // 
            // lblMovementInformPoint
            // 
            this.lblMovementInformPoint.AutoSize = true;
            this.lblMovementInformPoint.Location = new System.Drawing.Point(49, 84);
            this.lblMovementInformPoint.Name = "lblMovementInformPoint";
            this.lblMovementInformPoint.Size = new System.Drawing.Size(59, 12);
            this.lblMovementInformPoint.TabIndex = 3;
            this.lblMovementInformPoint.Text = "Point Id:";
            // 
            // lblEventMovementInformTooltip
            // 
            this.lblEventMovementInformTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEventMovementInformTooltip.Location = new System.Drawing.Point(20, 9);
            this.lblEventMovementInformTooltip.Name = "lblEventMovementInformTooltip";
            this.lblEventMovementInformTooltip.Size = new System.Drawing.Size(453, 30);
            this.lblEventMovementInformTooltip.TabIndex = 0;
            this.lblEventMovementInformTooltip.Text = "Expires upon reaching a waypoint or finishing point movement. For special waypoin" +
    "ts, the provided path Id is added to the motion type.";
            // 
            // frmEventGroupMemberDied
            // 
            this.frmEventGroupMemberDied.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmEventGroupMemberDied.Controls.Add(this.cmbGroupMemberDiedIsLeader);
            this.frmEventGroupMemberDied.Controls.Add(this.btnGroupMemberDiedCreatureId);
            this.frmEventGroupMemberDied.Controls.Add(this.lblGroupMemberDiedCreatureId);
            this.frmEventGroupMemberDied.Controls.Add(this.lblGroupMemberDiedIsLeader);
            this.frmEventGroupMemberDied.Controls.Add(this.lblGroupMemberDiedTooltip);
            this.frmEventGroupMemberDied.Location = new System.Drawing.Point(433, 267);
            this.frmEventGroupMemberDied.Name = "frmEventGroupMemberDied";
            this.frmEventGroupMemberDied.Size = new System.Drawing.Size(495, 254);
            this.frmEventGroupMemberDied.TabIndex = 68;
            this.frmEventGroupMemberDied.Visible = false;
            // 
            // cmbGroupMemberDiedIsLeader
            // 
            this.cmbGroupMemberDiedIsLeader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroupMemberDiedIsLeader.FormattingEnabled = true;
            this.cmbGroupMemberDiedIsLeader.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbGroupMemberDiedIsLeader.Location = new System.Drawing.Point(99, 81);
            this.cmbGroupMemberDiedIsLeader.Name = "cmbGroupMemberDiedIsLeader";
            this.cmbGroupMemberDiedIsLeader.Size = new System.Drawing.Size(374, 20);
            this.cmbGroupMemberDiedIsLeader.TabIndex = 14;
            this.cmbGroupMemberDiedIsLeader.SelectedIndexChanged += new System.EventHandler(this.cmbGroupMemberDiedIsLeader_SelectedIndexChanged);
            // 
            // btnGroupMemberDiedCreatureId
            // 
            this.btnGroupMemberDiedCreatureId.Location = new System.Drawing.Point(99, 54);
            this.btnGroupMemberDiedCreatureId.Name = "btnGroupMemberDiedCreatureId";
            this.btnGroupMemberDiedCreatureId.Size = new System.Drawing.Size(374, 21);
            this.btnGroupMemberDiedCreatureId.TabIndex = 13;
            this.btnGroupMemberDiedCreatureId.Text = "-NONE-";
            this.btnGroupMemberDiedCreatureId.UseVisualStyleBackColor = true;
            this.btnGroupMemberDiedCreatureId.Click += new System.EventHandler(this.btnGroupMemberDiedCreatureId_Click);
            // 
            // lblGroupMemberDiedCreatureId
            // 
            this.lblGroupMemberDiedCreatureId.AutoSize = true;
            this.lblGroupMemberDiedCreatureId.Location = new System.Drawing.Point(18, 56);
            this.lblGroupMemberDiedCreatureId.Name = "lblGroupMemberDiedCreatureId";
            this.lblGroupMemberDiedCreatureId.Size = new System.Drawing.Size(77, 12);
            this.lblGroupMemberDiedCreatureId.TabIndex = 4;
            this.lblGroupMemberDiedCreatureId.Text = "Creature Id:";
            // 
            // lblGroupMemberDiedIsLeader
            // 
            this.lblGroupMemberDiedIsLeader.AutoSize = true;
            this.lblGroupMemberDiedIsLeader.Location = new System.Drawing.Point(29, 84);
            this.lblGroupMemberDiedIsLeader.Name = "lblGroupMemberDiedIsLeader";
            this.lblGroupMemberDiedIsLeader.Size = new System.Drawing.Size(65, 12);
            this.lblGroupMemberDiedIsLeader.TabIndex = 3;
            this.lblGroupMemberDiedIsLeader.Text = "Is Leader:";
            // 
            // lblGroupMemberDiedTooltip
            // 
            this.lblGroupMemberDiedTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGroupMemberDiedTooltip.Location = new System.Drawing.Point(20, 9);
            this.lblGroupMemberDiedTooltip.Name = "lblGroupMemberDiedTooltip";
            this.lblGroupMemberDiedTooltip.Size = new System.Drawing.Size(453, 30);
            this.lblGroupMemberDiedTooltip.TabIndex = 0;
            this.lblGroupMemberDiedTooltip.Text = "Expires when a member of the creature\'s group dies. The group must have the appop" +
    "riate flag for the event to trigger.";
            // 
            // FormEventEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(944, 554);
            this.Controls.Add(this.frmEventGroupMemberDied);
            this.Controls.Add(this.frmEventMovementInform);
            this.Controls.Add(this.frmEventReceiveEmote);
            this.Controls.Add(this.frmEventSummonedUnit);
            this.Controls.Add(this.frmEventEnterLOS);
            this.Controls.Add(this.frmEventSpellHit);
            this.Controls.Add(this.frmEventAggro);
            this.Controls.Add(this.btnViewRaw);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEventCopy);
            this.Controls.Add(this.btnEventAdd);
            this.Controls.Add(this.btnEventDelete);
            this.Controls.Add(this.lblCurrentCreature);
            this.Controls.Add(this.frmEventTimerCombat);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.lblCreatureId);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtCreatureId);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.lblNoEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEventEditor";
            this.Text = "Event Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEventEditor_FormClosing);
            this.Load += new System.EventHandler(this.FormEventEditor_Load);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpEventFlags.ResumeLayout(false);
            this.grpEventFlags.PerformLayout();
            this.frmEventTimerCombat.ResumeLayout(false);
            this.frmEventTimerCombat.PerformLayout();
            this.frmEventAggro.ResumeLayout(false);
            this.frmEventSpellHit.ResumeLayout(false);
            this.frmEventSpellHit.PerformLayout();
            this.frmEventEnterLOS.ResumeLayout(false);
            this.frmEventEnterLOS.PerformLayout();
            this.frmEventSummonedUnit.ResumeLayout(false);
            this.frmEventSummonedUnit.PerformLayout();
            this.frmEventReceiveEmote.ResumeLayout(false);
            this.frmEventReceiveEmote.PerformLayout();
            this.frmEventMovementInform.ResumeLayout(false);
            this.frmEventMovementInform.PerformLayout();
            this.frmEventGroupMemberDied.ResumeLayout(false);
            this.frmEventGroupMemberDied.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstEvents;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnComment;
        private System.Windows.Forms.TextBox txtCreatureId;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblCreatureId;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.Label lblEventId;
        private System.Windows.Forms.TextBox txtEventId;
        private System.Windows.Forms.Button btnEventCondition;
        private System.Windows.Forms.Label lblEventPhaseMask;
        private System.Windows.Forms.Label lblEventChance;
        private System.Windows.Forms.TextBox txtEventChance;
        private System.Windows.Forms.ComboBox cmbEventType;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.Label lblEventCondition;
        private System.Windows.Forms.GroupBox grpEventFlags;
        private System.Windows.Forms.Button btnEditScript3;
        private System.Windows.Forms.Button btnEditScript2;
        private System.Windows.Forms.Button btnEditScript1;
        private System.Windows.Forms.TextBox txtScriptId3;
        private System.Windows.Forms.TextBox txtScriptId2;
        private System.Windows.Forms.TextBox txtScriptId1;
        private System.Windows.Forms.Label lblEventComment;
        private System.Windows.Forms.TextBox txtEventComment;
        private System.Windows.Forms.Label lblScriptId3;
        private System.Windows.Forms.Label lblScriptId2;
        private System.Windows.Forms.Label lblScriptId1;
        private System.Windows.Forms.CheckBox chkEventFlag1;
        private System.Windows.Forms.CheckBox chkEventFlag4;
        private System.Windows.Forms.CheckBox chkEventFlag2;
        private System.Windows.Forms.Panel frmEventTimerCombat;
        private System.Windows.Forms.Label lblTimerRepeatMin;
        private System.Windows.Forms.Label lblTimerInitialMin;
        private System.Windows.Forms.Label lblTimerInitialMax;
        private System.Windows.Forms.Label lblEventTimerCombatTooltip;
        private System.Windows.Forms.Label lblCurrentCreature;
        private System.Windows.Forms.Button btnEventCopy;
        private System.Windows.Forms.Button btnEventAdd;
        private System.Windows.Forms.Button btnEventDelete;
        private System.Windows.Forms.Button btnViewRaw;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTimerInitialMin;
        private System.Windows.Forms.TextBox txtTimerRepeatMin;
        private System.Windows.Forms.TextBox txtTimerInitialMax;
        private System.Windows.Forms.TextBox txtTimerRepeatMax;
        private System.Windows.Forms.Label lblTimerRepeatMax;
        private System.Windows.Forms.Label lblNoEvent;
        private System.Windows.Forms.Panel frmEventAggro;
        private System.Windows.Forms.Label lblEventAggroTooltip;
        private System.Windows.Forms.Panel frmEventSpellHit;
        private System.Windows.Forms.Button btnSpellHitSpellId;
        private System.Windows.Forms.TextBox txtSpellHitRepeatMax;
        private System.Windows.Forms.Label lblSpellHitRepeatMax;
        private System.Windows.Forms.TextBox txtSpellHitRepeatMin;
        private System.Windows.Forms.TextBox txtSpellHitSchoolMask;
        private System.Windows.Forms.Label lblSpellHitRepeatMin;
        private System.Windows.Forms.Label lblSpellHitSpellId;
        private System.Windows.Forms.Label lblSpellHitSchoolMask;
        private System.Windows.Forms.Label lblEventSpellHitTooltip;
        private System.Windows.Forms.Button btnEventPhaseMask;
        private System.Windows.Forms.Panel frmEventEnterLOS;
        private System.Windows.Forms.ComboBox cmbEnterLOSFaction;
        private System.Windows.Forms.TextBox txtEnterLOSRepeatMax;
        private System.Windows.Forms.Label lblEnterLOSRepeatMax;
        private System.Windows.Forms.TextBox txtEnterLOSRepeatMin;
        private System.Windows.Forms.TextBox txtEnterLOSDistance;
        private System.Windows.Forms.Label lblEnterLOSRepeatMin;
        private System.Windows.Forms.Label lblEnterLOSFaction;
        private System.Windows.Forms.Label lblEnterLOSDistance;
        private System.Windows.Forms.Label lblEventEnterLOSTooltip;
        private System.Windows.Forms.Panel frmEventSummonedUnit;
        private System.Windows.Forms.Button btnSummonedUnitId;
        private System.Windows.Forms.TextBox txtSummonedUnitRepeatMax;
        private System.Windows.Forms.TextBox txtSummonedUnitRepeatMin;
        private System.Windows.Forms.Label lblSummonedUnitRepeatMax;
        private System.Windows.Forms.Label lblSummonedUnitId;
        private System.Windows.Forms.Label lblSummonedUnitRepeatMin;
        private System.Windows.Forms.Label lblEventSummonedUnitTooltip;
        private System.Windows.Forms.Panel frmEventReceiveEmote;
        private System.Windows.Forms.ComboBox cmbReceiveEmoteId;
        private System.Windows.Forms.Label lblReceiveEmoteId;
        private System.Windows.Forms.Label lblEventReceiveEmoteTooltip;
        private System.Windows.Forms.Panel frmEventMovementInform;
        private System.Windows.Forms.ComboBox cmbMovementInformType;
        private System.Windows.Forms.TextBox txtMovementInformRepeatMax;
        private System.Windows.Forms.Label lblMovementInformRepeatMax;
        private System.Windows.Forms.TextBox txtMovementInformRepeatMin;
        private System.Windows.Forms.TextBox txtMovementInformPoint;
        private System.Windows.Forms.Label lblMovementInformRepeatMin;
        private System.Windows.Forms.Label lblMovementInformType;
        private System.Windows.Forms.Label lblMovementInformPoint;
        private System.Windows.Forms.Label lblEventMovementInformTooltip;
        private System.Windows.Forms.TextBox txtMovementInformType;
        private System.Windows.Forms.Panel frmEventGroupMemberDied;
        private System.Windows.Forms.ComboBox cmbGroupMemberDiedIsLeader;
        private System.Windows.Forms.Button btnGroupMemberDiedCreatureId;
        private System.Windows.Forms.Label lblGroupMemberDiedCreatureId;
        private System.Windows.Forms.Label lblGroupMemberDiedIsLeader;
        private System.Windows.Forms.Label lblGroupMemberDiedTooltip;
    }
}