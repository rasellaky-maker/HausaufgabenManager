using HausaufgabenManagerUI_WinForm.Moduls;
using HausaufgabenManagerUI_WinForm.Repository;
using MySqlConnector;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

namespace HausaufgabenManagerUI_WinForm.Services
{
    public enum Connection
    {
        Local,
        Global
    }
    public class HausuebungService
    {
        private HausuebungenRepository _repository = null;

        internal List<Hausuebung> NewHomeworkList { get; set; }
        private Label LabelInfo { get; set; }
        private Button BtnSpeichern { get; set; }
        private Button BtnNeuLaden{ get; set; }

        public HausuebungService(Connection connectionType, Label labelInfo, Button btnSpeichern, Button btnNeuLaden)
        {
            LabelInfo = labelInfo;
            BtnSpeichern = btnSpeichern;
            BtnNeuLaden = btnNeuLaden;
            NewHomeworkList = new List<Hausuebung>();
            
            
            if (connectionType == Connection.Local)
                _repository = new HausuebungenRepository(AppConfig.GetLocalConnectionString());
            else if (connectionType == Connection.Global)
                _repository = new HausuebungenRepository(AppConfig.GetGlobaleConnectionString());
            else
                throw new ArgumentException("Invalid connection type.");
        }

        public async Task LoadDgv(DataGridView dgv)
        {
            try
            {
                var list = await _repository.GetAll();

                if (list.Count <= 0)
                {
                    MappWrightInfo("Keine Hausaufgaben gefunden.");
                }

                foreach(var el in this.NewHomeworkList)
                {
                    list.Add(el);
                }

                dgv.DataSource = list;
                ColorDgv(dgv);
                MappWrightInfo($"Anzahl der Hausaufgaben: {dgv.RowCount}");
            }
            catch (MySqlException ex)
            {
                MappServerFehler(ex);
                MappWrightInfo(ex.Message);
            }
        }

        public void AddNewHomework(Hausuebung newHomework)
        {

            this.NewHomeworkList.Add(newHomework);
            MappWrightInfo("Hausaufgabe wurde erfolgreich erstelt.");
            BtnNeuLaden.BackColor = Color.RoyalBlue;
            BtnSpeichern.BackColor = Color.RoyalBlue;

        }

        public async Task Speichern()
        {
            try
            {
                Hausuebung result = null;
                foreach (var el in this.NewHomeworkList)
                {
                    result = await _repository.Add(el);
                }
                if (result == null)
                {
                    MappWrightInfo("Hausaufgabe konnte nicht gespeichert werden.");
                }
                else
                {
                    BtnSpeichern.BackColor = Color.RoyalBlue;
                    MappWrightInfo("Hausaufgabe wurde erfolgreich erstelt.");
                    this.NewHomeworkList.Clear();
                }
            }
            catch (MySqlException ex)
            {
                MappServerFehler(ex);
            }
        }

        void ColorDgv(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (int.TryParse(row.Cells["colTage"].Value?.ToString(), out int value))
                {
                    if (value <= 2)
                        row.Cells["colTage"].Style.ForeColor = Color.Red;
                    else if (value > 5)
                        row.Cells["colTage"].Style.ForeColor = Color.LimeGreen;
                    else
                        row.Cells["colTage"].Style.ForeColor = Color.Gold;
                }
            }
        }
        void MappWrightInfo(string textMessage)
        {
            LabelInfo.Text = textMessage;
            LabelInfo.Visible = true;
        }
        private void MappServerFehler(Exception ex)
        {
            LabelInfo.Visible = true;
            LabelInfo.Text = "Connection...";
            MessageBox.Show("Datenbank ist nicht erreichbar\n" + ex.Message, "Fehler 500", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
