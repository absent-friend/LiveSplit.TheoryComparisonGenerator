﻿
namespace LiveSplit.UI.Components
{
    partial class ComparisonSettings
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupComparison = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAltName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnRemoveColumn = new System.Windows.Forms.Button();
            this.txtTargetTime = new System.Windows.Forms.MaskedTextBox();
            this.btnAttachToSplits = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBalanced = new System.Windows.Forms.CheckBox();
            this.groupComparison.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupComparison
            // 
            this.groupComparison.Controls.Add(this.tableLayoutPanel1);
            this.groupComparison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupComparison.Location = new System.Drawing.Point(0, 0);
            this.groupComparison.Margin = new System.Windows.Forms.Padding(4);
            this.groupComparison.Name = "groupComparison";
            this.groupComparison.Padding = new System.Windows.Forms.Padding(4);
            this.groupComparison.Size = new System.Drawing.Size(569, 203);
            this.groupComparison.TabIndex = 0;
            this.groupComparison.TabStop = false;
            this.groupComparison.Text = "Comparison";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.67816F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.32184F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAltName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRemoveColumn, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTargetTime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAttachToSplits, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMoveUp, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMoveDown, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBalanced, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.28767F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.0274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(561, 180);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 34);
            this.label3.TabIndex = 47;
            this.label3.Text = "Goal Time:";
            // 
            // txtAltName
            // 
            this.txtAltName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtAltName, 4);
            this.txtAltName.Location = new System.Drawing.Point(83, 55);
            this.txtAltName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAltName.Name = "txtAltName";
            this.txtAltName.Size = new System.Drawing.Size(474, 22);
            this.txtAltName.TabIndex = 46;
            this.txtAltName.TextChanged += new System.EventHandler(this.txtAltName_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 42);
            this.label2.TabIndex = 45;
            this.label2.Text = "Display Name:\r\n(optional)";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 34);
            this.label1.TabIndex = 43;
            this.label1.Text = "Splits File:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtName, 4);
            this.txtName.Location = new System.Drawing.Point(83, 11);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(474, 22);
            this.txtName.TabIndex = 44;
            // 
            // btnRemoveColumn
            // 
            this.btnRemoveColumn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveColumn.Location = new System.Drawing.Point(467, 143);
            this.btnRemoveColumn.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveColumn.Name = "btnRemoveColumn";
            this.btnRemoveColumn.Size = new System.Drawing.Size(76, 28);
            this.btnRemoveColumn.TabIndex = 59;
            this.btnRemoveColumn.Text = "Remove";
            this.btnRemoveColumn.UseVisualStyleBackColor = true;
            this.btnRemoveColumn.Click += new System.EventHandler(this.btnRemoveColumn_Click);
            // 
            // txtTargetTime
            // 
            this.txtTargetTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTargetTime.Location = new System.Drawing.Point(83, 99);
            this.txtTargetTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTargetTime.Mask = "00:00:00.000";
            this.txtTargetTime.Name = "txtTargetTime";
            this.txtTargetTime.Size = new System.Drawing.Size(94, 22);
            this.txtTargetTime.TabIndex = 47;
            this.txtTargetTime.Text = "000000000";
            this.txtTargetTime.TextChanged += new System.EventHandler(this.txtTargetTime_TextChanged);
            // 
            // btnAttachToSplits
            // 
            this.btnAttachToSplits.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAttachToSplits.Location = new System.Drawing.Point(274, 143);
            this.btnAttachToSplits.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttachToSplits.Name = "btnAttachToSplits";
            this.btnAttachToSplits.Size = new System.Drawing.Size(171, 28);
            this.btnAttachToSplits.TabIndex = 58;
            this.btnAttachToSplits.Text = "Attach to Current Splits";
            this.btnAttachToSplits.UseVisualStyleBackColor = true;
            this.btnAttachToSplits.Click += new System.EventHandler(this.btnAttachToSplits_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMoveUp.Location = new System.Drawing.Point(110, 143);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(67, 28);
            this.btnMoveUp.TabIndex = 56;
            this.btnMoveUp.Text = "Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMoveDown.Location = new System.Drawing.Point(186, 143);
            this.btnMoveDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(80, 28);
            this.btnMoveDown.TabIndex = 57;
            this.btnMoveDown.Text = "Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(185, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 47);
            this.label4.TabIndex = 58;
            this.label4.Text = "(hh:mm:ss.ms)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkBalanced
            // 
            this.checkBalanced.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBalanced.AutoSize = true;
            this.checkBalanced.Location = new System.Drawing.Point(460, 100);
            this.checkBalanced.Name = "checkBalanced";
            this.checkBalanced.Size = new System.Drawing.Size(89, 21);
            this.checkBalanced.TabIndex = 60;
            this.checkBalanced.Text = "Balanced";
            this.checkBalanced.UseVisualStyleBackColor = true;
            this.checkBalanced.CheckedChanged += new System.EventHandler(this.checkBalanced_CheckedChanged);
            // 
            // ComparisonSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupComparison);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ComparisonSettings";
            this.Size = new System.Drawing.Size(569, 203);
            this.Load += new System.EventHandler(this.ComparisonSettings_Load);
            this.groupComparison.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupComparison;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAltName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveColumn;
        private System.Windows.Forms.Button btnAttachToSplits;
        private System.Windows.Forms.MaskedTextBox txtTargetTime;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBalanced;
    }
}
