namespace HausaufgabenManagerUI_WinForm
{
    partial class FormHUVerwwaltung
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHUVerwwaltung));
            groupBoxErfassen = new GroupBox();
            labelIhnalt = new Label();
            buttonHinzufuegen = new Button();
            labelFehler = new Label();
            richTextBoxInhalt = new RichTextBox();
            dateTimePickerFaellig = new DateTimePicker();
            labelFaelligAm = new Label();
            textBoxFach = new TextBox();
            labelFach = new Label();
            labelNeueHausuebungErfassen = new Label();
            labelInfo = new Label();
            panel1 = new Panel();
            labelOffeneHausaufgaben = new Label();
            panel2 = new Panel();
            dataGridViewHausuafgabe = new DataGridView();
            panel3 = new Panel();
            buttonSpeichern = new Button();
            buttonNeuLaden = new Button();
            colFach = new DataGridViewTextBoxColumn();
            colInhalt = new DataGridViewTextBoxColumn();
            colFaellig = new DataGridViewTextBoxColumn();
            colTage = new DataGridViewTextBoxColumn();
            groupBoxErfassen.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHausuafgabe).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxErfassen
            // 
            groupBoxErfassen.BackColor = Color.White;
            groupBoxErfassen.Controls.Add(labelIhnalt);
            groupBoxErfassen.Controls.Add(buttonHinzufuegen);
            groupBoxErfassen.Controls.Add(labelFehler);
            groupBoxErfassen.Controls.Add(richTextBoxInhalt);
            groupBoxErfassen.Controls.Add(dateTimePickerFaellig);
            groupBoxErfassen.Controls.Add(labelFaelligAm);
            groupBoxErfassen.Controls.Add(textBoxFach);
            groupBoxErfassen.Controls.Add(labelFach);
            groupBoxErfassen.Controls.Add(labelNeueHausuebungErfassen);
            groupBoxErfassen.Dock = DockStyle.Top;
            groupBoxErfassen.FlatStyle = FlatStyle.Popup;
            groupBoxErfassen.Font = new Font("Segoe UI", 0.5F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxErfassen.ImeMode = ImeMode.NoControl;
            groupBoxErfassen.Location = new Point(15, 15);
            groupBoxErfassen.Name = "groupBoxErfassen";
            groupBoxErfassen.Size = new Size(586, 213);
            groupBoxErfassen.TabIndex = 0;
            groupBoxErfassen.TabStop = false;
            // 
            // labelIhnalt
            // 
            labelIhnalt.Anchor = AnchorStyles.Left;
            labelIhnalt.AutoSize = true;
            labelIhnalt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelIhnalt.Location = new Point(17, 89);
            labelIhnalt.Name = "labelIhnalt";
            labelIhnalt.Size = new Size(42, 17);
            labelIhnalt.TabIndex = 8;
            labelIhnalt.Text = "Inhalt:";
            // 
            // buttonHinzufuegen
            // 
            buttonHinzufuegen.Anchor = AnchorStyles.Right;
            buttonHinzufuegen.BackColor = Color.RoyalBlue;
            buttonHinzufuegen.FlatStyle = FlatStyle.Flat;
            buttonHinzufuegen.Font = new Font("Segoe UI", 9F);
            buttonHinzufuegen.ForeColor = Color.White;
            buttonHinzufuegen.Location = new Point(419, 167);
            buttonHinzufuegen.Name = "buttonHinzufuegen";
            buttonHinzufuegen.Size = new Size(135, 35);
            buttonHinzufuegen.TabIndex = 7;
            buttonHinzufuegen.Text = "Hinzufuegen";
            buttonHinzufuegen.UseVisualStyleBackColor = false;
            buttonHinzufuegen.Click += buttonHinzufuegen_Click;
            // 
            // labelFehler
            // 
            labelFehler.AutoSize = true;
            labelFehler.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelFehler.ForeColor = Color.Red;
            labelFehler.Location = new Point(17, 167);
            labelFehler.Name = "labelFehler";
            labelFehler.Size = new Size(74, 17);
            labelFehler.TabIndex = 6;
            labelFehler.Text = "Fehler (....)...";
            labelFehler.Visible = false;
            // 
            // richTextBoxInhalt
            // 
            richTextBoxInhalt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxInhalt.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxInhalt.Font = new Font("Segoe UI", 9F);
            richTextBoxInhalt.Location = new Point(88, 89);
            richTextBoxInhalt.Name = "richTextBoxInhalt";
            richTextBoxInhalt.Size = new Size(470, 72);
            richTextBoxInhalt.TabIndex = 5;
            richTextBoxInhalt.Text = "";
            // 
            // dateTimePickerFaellig
            // 
            dateTimePickerFaellig.Anchor = AnchorStyles.Right;
            dateTimePickerFaellig.CalendarFont = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerFaellig.Font = new Font("Segoe UI", 9F);
            dateTimePickerFaellig.Format = DateTimePickerFormat.Short;
            dateTimePickerFaellig.Location = new Point(423, 43);
            dateTimePickerFaellig.MinDate = new DateTime(2026, 9, 8, 15, 35, 1, 0);
            dateTimePickerFaellig.Name = "dateTimePickerFaellig";
            dateTimePickerFaellig.Size = new Size(135, 23);
            dateTimePickerFaellig.TabIndex = 4;
            dateTimePickerFaellig.Value = new DateTime(2026, 9, 8, 15, 35, 1, 0);
            // 
            // labelFaelligAm
            // 
            labelFaelligAm.Anchor = AnchorStyles.Right;
            labelFaelligAm.AutoSize = true;
            labelFaelligAm.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFaelligAm.Location = new Point(323, 45);
            labelFaelligAm.Name = "labelFaelligAm";
            labelFaelligAm.Size = new Size(63, 17);
            labelFaelligAm.TabIndex = 3;
            labelFaelligAm.Text = "Fällig am:";
            // 
            // textBoxFach
            // 
            textBoxFach.Anchor = AnchorStyles.Left;
            textBoxFach.Font = new Font("Segoe UI", 9F);
            textBoxFach.Location = new Point(88, 43);
            textBoxFach.MaxLength = 10;
            textBoxFach.Name = "textBoxFach";
            textBoxFach.Size = new Size(100, 23);
            textBoxFach.TabIndex = 2;
            // 
            // labelFach
            // 
            labelFach.Anchor = AnchorStyles.Left;
            labelFach.AutoSize = true;
            labelFach.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFach.Location = new Point(27, 45);
            labelFach.Name = "labelFach";
            labelFach.Size = new Size(37, 17);
            labelFach.TabIndex = 1;
            labelFach.Text = "Fach:";
            // 
            // labelNeueHausuebungErfassen
            // 
            labelNeueHausuebungErfassen.AutoSize = true;
            labelNeueHausuebungErfassen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelNeueHausuebungErfassen.Location = new Point(6, 4);
            labelNeueHausuebungErfassen.Name = "labelNeueHausuebungErfassen";
            labelNeueHausuebungErfassen.Size = new Size(206, 21);
            labelNeueHausuebungErfassen.TabIndex = 0;
            labelNeueHausuebungErfassen.Text = "Neue HausübungErfassen";
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            labelInfo.ForeColor = Color.Gray;
            labelInfo.Location = new Point(3, 17);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(62, 13);
            labelInfo.TabIndex = 9;
            labelInfo.Text = "Place 4 Info";
            labelInfo.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelOffeneHausaufgaben);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(15, 228);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 42);
            panel1.TabIndex = 10;
            // 
            // labelOffeneHausaufgaben
            // 
            labelOffeneHausaufgaben.AutoSize = true;
            labelOffeneHausaufgaben.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelOffeneHausaufgaben.Location = new Point(9, 10);
            labelOffeneHausaufgaben.Name = "labelOffeneHausaufgaben";
            labelOffeneHausaufgaben.Size = new Size(173, 21);
            labelOffeneHausaufgaben.TabIndex = 3;
            labelOffeneHausaufgaben.Text = "Offene Hausübungen";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewHausuafgabe);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(15, 270);
            panel2.Name = "panel2";
            panel2.Size = new Size(586, 204);
            panel2.TabIndex = 11;
            // 
            // dataGridViewHausuafgabe
            // 
            dataGridViewHausuafgabe.AllowUserToAddRows = false;
            dataGridViewHausuafgabe.AllowUserToDeleteRows = false;
            dataGridViewHausuafgabe.BackgroundColor = Color.White;
            dataGridViewHausuafgabe.BorderStyle = BorderStyle.None;
            dataGridViewHausuafgabe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewHausuafgabe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewHausuafgabe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHausuafgabe.Columns.AddRange(new DataGridViewColumn[] { colFach, colInhalt, colFaellig, colTage });
            dataGridViewHausuafgabe.Dock = DockStyle.Fill;
            dataGridViewHausuafgabe.Location = new Point(0, 0);
            dataGridViewHausuafgabe.Name = "dataGridViewHausuafgabe";
            dataGridViewHausuafgabe.ReadOnly = true;
            dataGridViewHausuafgabe.RowHeadersVisible = false;
            dataGridViewHausuafgabe.RowHeadersWidth = 62;
            dataGridViewHausuafgabe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHausuafgabe.Size = new Size(586, 204);
            dataGridViewHausuafgabe.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonSpeichern);
            panel3.Controls.Add(buttonNeuLaden);
            panel3.Controls.Add(labelInfo);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(15, 421);
            panel3.Name = "panel3";
            panel3.Size = new Size(586, 53);
            panel3.TabIndex = 12;
            // 
            // buttonSpeichern
            // 
            buttonSpeichern.Anchor = AnchorStyles.Right;
            buttonSpeichern.BackColor = Color.DimGray;
            buttonSpeichern.FlatStyle = FlatStyle.Flat;
            buttonSpeichern.Font = new Font("Segoe UI", 9F);
            buttonSpeichern.ForeColor = Color.White;
            buttonSpeichern.Location = new Point(287, 12);
            buttonSpeichern.Name = "buttonSpeichern";
            buttonSpeichern.Size = new Size(135, 35);
            buttonSpeichern.TabIndex = 14;
            buttonSpeichern.Text = "Speichern";
            buttonSpeichern.UseVisualStyleBackColor = false;
            buttonSpeichern.Click += buttonSpeichern_Click;
            // 
            // buttonNeuLaden
            // 
            buttonNeuLaden.Anchor = AnchorStyles.Right;
            buttonNeuLaden.BackColor = Color.DimGray;
            buttonNeuLaden.FlatStyle = FlatStyle.Flat;
            buttonNeuLaden.Font = new Font("Segoe UI", 9F);
            buttonNeuLaden.ForeColor = Color.White;
            buttonNeuLaden.Location = new Point(448, 12);
            buttonNeuLaden.Name = "buttonNeuLaden";
            buttonNeuLaden.Size = new Size(135, 35);
            buttonNeuLaden.TabIndex = 13;
            buttonNeuLaden.Text = "Neu Laden";
            buttonNeuLaden.UseVisualStyleBackColor = false;
            buttonNeuLaden.Click += buttonNeuLaden_Click;
            // 
            // colFach
            // 
            colFach.DataPropertyName = "Fach";
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            colFach.DefaultCellStyle = dataGridViewCellStyle2;
            colFach.Frozen = true;
            colFach.HeaderText = "Fach";
            colFach.MinimumWidth = 8;
            colFach.Name = "colFach";
            colFach.ReadOnly = true;
            colFach.Width = 150;
            // 
            // colInhalt
            // 
            colInhalt.DataPropertyName = "Inhalt";
            dataGridViewCellStyle3.ForeColor = Color.Black;
            colInhalt.DefaultCellStyle = dataGridViewCellStyle3;
            colInhalt.Frozen = true;
            colInhalt.HeaderText = "Inhalt";
            colInhalt.MinimumWidth = 8;
            colInhalt.Name = "colInhalt";
            colInhalt.ReadOnly = true;
            colInhalt.Width = 150;
            // 
            // colFaellig
            // 
            colFaellig.DataPropertyName = "Faelligkeitsdatum";
            dataGridViewCellStyle4.ForeColor = Color.Black;
            colFaellig.DefaultCellStyle = dataGridViewCellStyle4;
            colFaellig.Frozen = true;
            colFaellig.HeaderText = "Fällig am";
            colFaellig.MinimumWidth = 8;
            colFaellig.Name = "colFaellig";
            colFaellig.ReadOnly = true;
            colFaellig.Width = 150;
            // 
            // colTage
            // 
            colTage.DataPropertyName = "TageBisAblauf";
            dataGridViewCellStyle5.ForeColor = Color.Gold;
            colTage.DefaultCellStyle = dataGridViewCellStyle5;
            colTage.Frozen = true;
            colTage.HeaderText = "Tage bis Ablauf";
            colTage.MinimumWidth = 8;
            colTage.Name = "colTage";
            colTage.ReadOnly = true;
            colTage.Width = 150;
            // 
            // FormHUVerwwaltung
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(616, 484);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBoxErfassen);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormHUVerwwaltung";
            Padding = new Padding(15, 15, 15, 10);
            Text = "Hausübungsverwaltung";
            groupBoxErfassen.ResumeLayout(false);
            groupBoxErfassen.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHausuafgabe).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxErfassen;
        private Label labelNeueHausuebungErfassen;
        private TextBox textBoxFach;
        private Label labelFach;
        private Label labelFaelligAm;
        private DateTimePicker dateTimePickerFaellig;
        private RichTextBox richTextBoxInhalt;
        private Label labelFehler;
        private Label labelIhnalt;
        private Button buttonHinzufuegen;
        private Label labelInfo;
        private Panel panel1;
        private Label labelOffeneHausaufgaben;
        private Panel panel2;
        private DataGridView dataGridViewHausuafgabe;
        private Panel panel3;
        private Button buttonSpeichern;
        private Button buttonNeuLaden;
        private DataGridViewTextBoxColumn colFach;
        private DataGridViewTextBoxColumn colInhalt;
        private DataGridViewTextBoxColumn colFaellig;
        private DataGridViewTextBoxColumn colTage;
    }
}
