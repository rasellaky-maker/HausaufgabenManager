using HausaufgabenManagerUI_WinForm.Repository;
using HausaufgabenManagerUI_WinForm.Services;
using System.Drawing.Drawing2D;
using HausaufgabenManagerUI_WinForm.Moduls;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HausaufgabenManagerUI_WinForm
{
    public partial class FormHUVerwwaltung : Form
    {
        private HausuebungService service = null;
        public FormHUVerwwaltung()
        {
            InitializeComponent();

            service = new HausuebungService(Connection.Global, labelInfo, buttonSpeichern, buttonNeuLaden);

            ConfigurateDtp();
            ConfigurateButtons();
            ConfigurateDgv();
            ConfigurateLables();

            Load += async (s, e) => await service.LoadDgv(dataGridViewHausuafgabe);
        }

        private void SetupRoundedButton(Button btn, int radius)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            btn.Paint += (s, e) =>
            {
                Rectangle rect = new Rectangle(0, 0, btn.Width - 1, btn.Height - 1);
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                    path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                    path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                    path.CloseFigure();

                    btn.Region = new Region(path);

                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    using (Pen pen = new Pen(btn.BackColor, 2))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            };
        }
        void ConfigurateDtp()
        {
            dateTimePickerFaellig.MaxDate = DateTime.Today.AddYears(1);
            dateTimePickerFaellig.MinDate = DateTime.Today.AddDays(1);
            dateTimePickerFaellig.Value = dateTimePickerFaellig.MinDate;
        }
        void ConfigurateLables()
        {
            labelInfo.Text = "Connection...";
            labelInfo.Visible = true;
        }
        void ConfigurateButtons()
        {
            SetupRoundedButton(buttonHinzufuegen, 10);
            SetupRoundedButton(buttonNeuLaden, 10);
            SetupRoundedButton(buttonSpeichern, 10);
        }
        void ConfigurateDgv()
        {
            dataGridViewHausuafgabe.AutoGenerateColumns = false;
            dataGridViewHausuafgabe.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }
        void ResetTextBoxes()
        {
            textBoxFach.Text = string.Empty;
            richTextBoxInhalt.Text = string.Empty;
        }

        private void buttonHinzufuegen_Click(object sender, EventArgs e)
        {
            if (textBoxFach.Text.Length < 2)
            {
                labelFehler.Text = "Fehler: Das Fach muss mindestens 2 Zeichen lang sein.";
                labelFehler.Visible = true;

                return;
            }

            var hu = new Hausuebung(
                textBoxFach.Text,
                Convert.ToDateTime(this.dateTimePickerFaellig.Value),
                richTextBoxInhalt.Text);

            service.AddNewHomework(hu);
            labelFehler.Visible = false;
            ResetTextBoxes();
            ConfigurateDtp();
        }

        private async void buttonSpeichern_Click(object sender, EventArgs e)
        {
            if (service.NewHomeworkList.Count > 0)
            {
                await service.Speichern();
                buttonSpeichern.BackColor = Color.DimGray;
                buttonNeuLaden.BackColor = Color.DimGray;
                service.NewHomeworkList.Clear();
                await service.LoadDgv(dataGridViewHausuafgabe);
            }

        }

        private async void buttonNeuLaden_Click(object sender, EventArgs e)
        {
            if (service.NewHomeworkList.Count > 0)
            {
                buttonNeuLaden.BackColor = Color.DimGray;
                await service.LoadDgv(dataGridViewHausuafgabe);
            }
        }
    }
}
