namespace ElevatorTest
{
    partial class Building
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
            this.components = new System.ComponentModel.Container();
            this.plBuilding = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.elevatorRunTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.plBuilding.SuspendLayout();
            this.SuspendLayout();
            // 
            // plBuilding
            // 
            this.plBuilding.BackColor = System.Drawing.Color.White;
            this.plBuilding.Controls.Add(this.panel5);
            this.plBuilding.Controls.Add(this.panel4);
            this.plBuilding.Controls.Add(this.panel3);
            this.plBuilding.Controls.Add(this.panel2);
            this.plBuilding.Controls.Add(this.panel1);
            this.plBuilding.Location = new System.Drawing.Point(174, 12);
            this.plBuilding.Name = "plBuilding";
            this.plBuilding.Size = new System.Drawing.Size(200, 532);
            this.plBuilding.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 100);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 100);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 100);
            this.panel5.TabIndex = 1;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStop.Location = new System.Drawing.Point(502, 534);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(99, 39);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Start";
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // Building
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 585);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.plBuilding);
            this.Name = "Building";
            this.Text = "Building";
            this.plBuilding.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plBuilding;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer elevatorRunTimer;
        private System.Windows.Forms.Button btnStop;
    }
}