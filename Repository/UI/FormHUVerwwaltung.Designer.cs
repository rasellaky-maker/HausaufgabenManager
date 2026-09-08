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
            richTextBox1 = new RichTextBox();
            dateTimePickerFaellig = new DateTimePicker();
            labelFaelligAm = new Label();
            textBox1 = new TextBox();
            labelFach = new Label();
            labelNeueHausuebungErfassen = new Label();
            dataGridViewHausuafgabe = new DataGridView();
            colFach = new DataGridViewTextBoxColumn();
            colInhalt = new DataGridViewTextBoxColumn();
            colFaellig = new DataGridViewTextBoxColumn();
            colTage = new DataGridViewTextBoxColumn();
            labelOffeneHausaufgaben = new Label();
            buttonNeuLaden = new Button();
            buttonSpeichern = new Button();
            labelInfo = new Label();
            groupBoxErfassen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHausuafgabe).BeginInit();
            SuspendLayout();
            // 
            // groupBoxErfassen
            // 
            groupBoxErfassen.BackColor = Color.White;
            groupBoxErfassen.Controls.Add(labelIhnalt);
            groupBoxErfassen.Controls.Add(buttonHinzufuegen);
            groupBoxErfassen.Controls.Add(labelFehler);
            groupBoxErfassen.Controls.Add(richTextBox1);
            groupBoxErfassen.Controls.Add(dateTimePickerFaellig);
            groupBoxErfassen.Controls.Add(labelFaelligAm);
            groupBoxErfassen.Controls.Add(textBox1);
            groupBoxErfassen.Controls.Add(labelFach);
            groupBoxErfassen.Controls.Add(labelNeueHausuebungErfassen);
            groupBoxErfassen.Dock = DockStyle.Top;
            groupBoxErfassen.FlatStyle = FlatStyle.Popup;
            groupBoxErfassen.Font = new Font("Segoe UI", 0.5F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxErfassen.ImeMode = ImeMode.NoControl;
            groupBoxErfassen.Location = new Point(15, 15);
            groupBoxErfassen.Name = "groupBoxErfassen";
            groupBoxErfassen.Size = new Size(545, 213);
            groupBoxErfassen.TabIndex = 0;
            groupBoxErfassen.TabStop = false;
            // 
            // labelIhnalt
            // 
            labelIhnalt.AutoSize = true;
            labelIhnalt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelIhnalt.Location = new Point(27, 89);
            labelIhnalt.Name = "labelIhnalt";
            labelIhnalt.Size = new Size(42, 17);
            labelIhnalt.TabIndex = 8;
            labelIhnalt.Text = "Inhalt:";
            // 
            // buttonHinzufuegen
            // 
            buttonHinzufuegen.BackColor = Color.RoyalBlue;
            buttonHinzufuegen.FlatStyle = FlatStyle.Flat;
            buttonHinzufuegen.Font = new Font("Segoe UI", 10F);
            buttonHinzufuegen.ForeColor = Color.White;
            buttonHinzufuegen.Location = new Point(378, 167);
            buttonHinzufuegen.Name = "buttonHinzufuegen";
            buttonHinzufuegen.Size = new Size(135, 35);
            buttonHinzufuegen.TabIndex = 7;
            buttonHinzufuegen.Text = "Hinzufuegen";
            buttonHinzufuegen.UseVisualStyleBackColor = false;
            // 
            // labelFehler
            // 
            labelFehler.AutoSize = true;
            labelFehler.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelFehler.ForeColor = Color.Red;
            labelFehler.Location = new Point(27, 167);
            labelFehler.Name = "labelFehler";
            labelFehler.Size = new Size(74, 17);
            labelFehler.TabIndex = 6;
            labelFehler.Text = "Fehler (....)...";
            labelFehler.Visible = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Font = new Font("Segoe UI", 9F);
            richTextBox1.Location = new Point(75, 89);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(438, 72);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // dateTimePickerFaellig
            // 
            dateTimePickerFaellig.CalendarFont = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerFaellig.Font = new Font("Segoe UI", 9F);
            dateTimePickerFaellig.Location = new Point(378, 43);
            dateTimePickerFaellig.MinDate = new DateTime(2026, 9, 8, 15, 35, 1, 0);
            dateTimePickerFaellig.Name = "dateTimePickerFaellig";
            dateTimePickerFaellig.Size = new Size(135, 23);
            dateTimePickerFaellig.TabIndex = 4;
            dateTimePickerFaellig.Value = new DateTime(2026, 9, 8, 15, 35, 1, 0);
            // 
            // labelFaelligAm
            // 
            labelFaelligAm.AutoSize = true;
            labelFaelligAm.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFaelligAm.Location = new Point(309, 47);
            labelFaelligAm.Name = "labelFaelligAm";
            labelFaelligAm.Size = new Size(63, 17);
            labelFaelligAm.TabIndex = 3;
            labelFaelligAm.Text = "Fällig am:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F);
            textBox1.Location = new Point(75, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // labelFach
            // 
            labelFach.AutoSize = true;
            labelFach.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFach.Location = new Point(27, 47);
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
            dataGridViewHausuafgabe.Location = new Point(16, 264);
            dataGridViewHausuafgabe.Name = "dataGridViewHausuafgabe";
            dataGridViewHausuafgabe.ReadOnly = true;
            dataGridViewHausuafgabe.RowHeadersVisible = false;
            dataGridViewHausuafgabe.Size = new Size(545, 150);
            dataGridViewHausuafgabe.TabIndex = 1;
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
            colFaellig.Name = "colFaellig";
            colFaellig.ReadOnly = true;
            // 
            // colTage
            // 
            colTage.DataPropertyName = "TageBisAblauf";
            dataGridViewCellStyle5.ForeColor = Color.Black;
            colTage.DefaultCellStyle = dataGridViewCellStyle5;
            colTage.Frozen = true;
            colTage.HeaderText = "Tage bis Ablauf";
            colTage.Name = "colTage";
            colTage.ReadOnly = true;
            // 
            // labelOffeneHausaufgaben
            // 
            labelOffeneHausaufgaben.AutoSize = true;
            labelOffeneHausaufgaben.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelOffeneHausaufgaben.Location = new Point(26, 235);
            labelOffeneHausaufgaben.Name = "labelOffeneHausaufgaben";
            labelOffeneHausaufgaben.Size = new Size(173, 21);
            labelOffeneHausaufgaben.TabIndex = 2;
            labelOffeneHausaufgaben.Text = "Offene Hausübungen";
            // 
            // buttonNeuLaden
            // 
            buttonNeuLaden.BackColor = Color.DimGray;
            buttonNeuLaden.FlatStyle = FlatStyle.Flat;
            buttonNeuLaden.Font = new Font("Segoe UI", 10F);
            buttonNeuLaden.ForeColor = Color.White;
            buttonNeuLaden.Location = new Point(393, 429);
            buttonNeuLaden.Name = "buttonNeuLaden";
            buttonNeuLaden.Size = new Size(135, 35);
            buttonNeuLaden.TabIndex = 8;
            buttonNeuLaden.Text = "Neu Laden";
            buttonNeuLaden.UseVisualStyleBackColor = false;
            // 
            // buttonSpeichern
            // 
            buttonSpeichern.BackColor = Color.DimGray;
            buttonSpeichern.FlatStyle = FlatStyle.Flat;
            buttonSpeichern.Font = new Font("Segoe UI", 10F);
            buttonSpeichern.ForeColor = Color.White;
            buttonSpeichern.Location = new Point(232, 429);
            buttonSpeichern.Name = "buttonSpeichern";
            buttonSpeichern.Size = new Size(135, 35);
            buttonSpeichern.TabIndex = 9;
            buttonSpeichern.Text = "Speichern";
            buttonSpeichern.UseVisualStyleBackColor = false;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelInfo.ForeColor = Color.Gray;
            labelInfo.Location = new Point(15, 438);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(73, 17);
            labelInfo.TabIndex = 9;
            labelInfo.Text = "Place 4 Info";
            labelInfo.Visible = false;
            // 
            // FormHUVerwwaltung
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(575, 484);
            Controls.Add(labelInfo);
            Controls.Add(buttonSpeichern);
            Controls.Add(buttonNeuLaden);
            Controls.Add(labelOffeneHausaufgaben);
            Controls.Add(dataGridViewHausuafgabe);
            Controls.Add(groupBoxErfassen);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormHUVerwwaltung";
            Padding = new Padding(15, 15, 15, 70);
            Text = "Hausübungsverwaltung";
            groupBoxErfassen.ResumeLayout(false);
            groupBoxErfassen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHausuafgabe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxErfassen;
        private Label labelNeueHausuebungErfassen;
        private TextBox textBox1;
        private Label labelFach;
        private Label labelFaelligAm;
        private DateTimePicker dateTimePickerFaellig;
        private RichTextBox richTextBox1;
        private DataGridView dataGridViewHausuafgabe;
        private Label labelOffeneHausaufgaben;
        private Label labelFehler;
        private Label labelIhnalt;
        private Button buttonHinzufuegen;
        private Button buttonNeuLaden;
        private DataGridViewTextBoxColumn colFach;
        private DataGridViewTextBoxColumn colInhalt;
        private DataGridViewTextBoxColumn colFaellig;
        private DataGridViewTextBoxColumn colTage;
        private Button buttonSpeichern;
        private Label labelInfo;
    }
}
