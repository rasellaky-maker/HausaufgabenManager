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

        public HausuebungService(Connection connectionType, Label labelInfo, Button btnSpeichern)
        {
            LabelInfo = labelInfo;
            BtnSpeichern = btnSpeichern;
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
                    LabelInfo.Visible = true;
                    LabelInfo.Text = "Keine Hausaufgaben gefunden.";
                }

                dgv.DataSource = list;
                LabelInfo.Visible = true;
                LabelInfo.Text = $"Anzahl der Hausaufgaben: {dgv.RowCount}";
            }
            catch (MySqlException ex)
            {
                MappServerFehler(ex);
            }
        }

        public async Task AddNewHomework(Hausuebung newHomework, Button btnSpeichern)
        {
            try
            {
                var result = await _repository.Add(newHomework);
                if (result == null)
                {
                    LabelInfo.Visible = true;
                    LabelInfo.Text = "Hausaufgabe konnte nicht gespeichert werden.";
                }
                else
                {
                    NewHomeworkList.Add(newHomework);
                    LabelInfo.Visible = true;
                    LabelInfo.Text = "Hausaufgabe wurde erfolgreich gespeichert.";
                }
            }
            catch (MySqlException ex)
            {
                MappServerFehler(ex);
            }
        }

        private void MappServerFehler(MySqlException ex)
        {
            LabelInfo.Visible = true;
            LabelInfo.Text = "Connection...";
            MessageBox.Show("Datenbank ist nicht erreichbar\n" + ex.Message, "Fehler 500", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
