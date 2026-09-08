using HausaufgabenManagerUI_WinForm.Repository;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HausaufgabenManagerUI_WinForm
{
    public partial class FormHUVerwwaltung : Form
    {
        HausuebungenRepository repository = new HausuebungenRepository("Server=localhost;Database=huverwaltung;Uid=root;Pwd=123schule123;");
        public FormHUVerwwaltung()
        {
            InitializeComponent();
            ConfigurateDtp();
            ConfigurateButtons();
            ConfigurateDgv();

            Load += async (s, e) => await LoadDgv();
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

        async Task LoadDgv()
        {
            try
            {
                var list = await repository.GetAll();

                if (list.Count <= 0)
                {
                    MessageBox.Show("gdfgfdgfdgfdg", "Fehler 500", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dataGridViewHausuafgabe.DataSource = list;
            }
            catch (MySqlConnector.MySqlException ex)
            {
                MessageBox.Show("Datenbank ist nicht erreichbar", "Fehler 500", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
