namespace WindowsFormsApplication1
{
    partial class BoardAplication_Board
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
            this.panelBoard = new System.Windows.Forms.Panel();
            this.label50 = new System.Windows.Forms.Label();
            this.listBoxComentaryOfSelectedElement = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonChekResolvedCommentary = new System.Windows.Forms.RadioButton();
            this.labelUserResolutor = new System.Windows.Forms.Label();
            this.labelUserCreator = new System.Windows.Forms.Label();
            this.labelCommentaryDescription = new System.Windows.Forms.Label();
            this.buttonNewCommentaryToSelectedElement = new System.Windows.Forms.Button();
            this.buttonNewElementBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelBoard
            // 
            this.panelBoard.Location = new System.Drawing.Point(233, 44);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(728, 570);
            this.panelBoard.TabIndex = 0;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(12, 28);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(90, 13);
            this.label50.TabIndex = 40;
            this.label50.Text = "Lista Comentarios";
            // 
            // listBoxComentaryOfSelectedElement
            // 
            this.listBoxComentaryOfSelectedElement.FormattingEnabled = true;
            this.listBoxComentaryOfSelectedElement.Location = new System.Drawing.Point(12, 44);
            this.listBoxComentaryOfSelectedElement.Name = "listBoxComentaryOfSelectedElement";
            this.listBoxComentaryOfSelectedElement.Size = new System.Drawing.Size(210, 251);
            this.listBoxComentaryOfSelectedElement.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Selected Comentary Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Comentary:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Creator:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Resolved By:";
            // 
            // radioButtonChekResolvedCommentary
            // 
            this.radioButtonChekResolvedCommentary.AutoSize = true;
            this.radioButtonChekResolvedCommentary.Location = new System.Drawing.Point(87, 427);
            this.radioButtonChekResolvedCommentary.Name = "radioButtonChekResolvedCommentary";
            this.radioButtonChekResolvedCommentary.Size = new System.Drawing.Size(98, 17);
            this.radioButtonChekResolvedCommentary.TabIndex = 45;
            this.radioButtonChekResolvedCommentary.TabStop = true;
            this.radioButtonChekResolvedCommentary.Text = "Chek Resolved";
            this.radioButtonChekResolvedCommentary.UseVisualStyleBackColor = true;
            // 
            // labelUserResolutor
            // 
            this.labelUserResolutor.AutoSize = true;
            this.labelUserResolutor.Location = new System.Drawing.Point(95, 403);
            this.labelUserResolutor.Name = "labelUserResolutor";
            this.labelUserResolutor.Size = new System.Drawing.Size(72, 13);
            this.labelUserResolutor.TabIndex = 46;
            this.labelUserResolutor.Text = "userResolutor";
            // 
            // labelUserCreator
            // 
            this.labelUserCreator.AutoSize = true;
            this.labelUserCreator.Location = new System.Drawing.Point(95, 369);
            this.labelUserCreator.Name = "labelUserCreator";
            this.labelUserCreator.Size = new System.Drawing.Size(61, 13);
            this.labelUserCreator.TabIndex = 47;
            this.labelUserCreator.Text = "userCreator";
            // 
            // labelCommentaryDescription
            // 
            this.labelCommentaryDescription.AutoSize = true;
            this.labelCommentaryDescription.Location = new System.Drawing.Point(95, 336);
            this.labelCommentaryDescription.Name = "labelCommentaryDescription";
            this.labelCommentaryDescription.Size = new System.Drawing.Size(58, 13);
            this.labelCommentaryDescription.TabIndex = 48;
            this.labelCommentaryDescription.Text = "description";
            // 
            // buttonNewCommentaryToSelectedElement
            // 
            this.buttonNewCommentaryToSelectedElement.Location = new System.Drawing.Point(15, 515);
            this.buttonNewCommentaryToSelectedElement.Name = "buttonNewCommentaryToSelectedElement";
            this.buttonNewCommentaryToSelectedElement.Size = new System.Drawing.Size(207, 23);
            this.buttonNewCommentaryToSelectedElement.TabIndex = 49;
            this.buttonNewCommentaryToSelectedElement.Text = "New Commentary To Selected Element";
            this.buttonNewCommentaryToSelectedElement.UseVisualStyleBackColor = true;
            // 
            // buttonNewElementBoard
            // 
            this.buttonNewElementBoard.Location = new System.Drawing.Point(15, 565);
            this.buttonNewElementBoard.Name = "buttonNewElementBoard";
            this.buttonNewElementBoard.Size = new System.Drawing.Size(207, 23);
            this.buttonNewElementBoard.TabIndex = 50;
            this.buttonNewElementBoard.Text = "New Element Board";
            this.buttonNewElementBoard.UseVisualStyleBackColor = true;
            // 
            // BoardAplication_Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 626);
            this.Controls.Add(this.buttonNewElementBoard);
            this.Controls.Add(this.buttonNewCommentaryToSelectedElement);
            this.Controls.Add(this.labelCommentaryDescription);
            this.Controls.Add(this.labelUserCreator);
            this.Controls.Add(this.labelUserResolutor);
            this.Controls.Add(this.radioButtonChekResolvedCommentary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.listBoxComentaryOfSelectedElement);
            this.Controls.Add(this.panelBoard);
            this.Name = "BoardAplication_Board";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ListBox listBoxComentaryOfSelectedElement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonChekResolvedCommentary;
        private System.Windows.Forms.Label labelUserResolutor;
        private System.Windows.Forms.Label labelUserCreator;
        private System.Windows.Forms.Label labelCommentaryDescription;
        private System.Windows.Forms.Button buttonNewCommentaryToSelectedElement;
        private System.Windows.Forms.Button buttonNewElementBoard;
    }
}