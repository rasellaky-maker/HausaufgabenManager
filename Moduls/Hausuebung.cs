namespace HausaufgabenManagerUI_WinForm.Moduls
{
    public class Hausuebung
    {
        public string Fach {  get; set; }
        public DateTime Faelligkeitsdatum { get; set; }
        public string Inhalt { get; set; }
        public int TageBisAblauf { get; set; }

        public override string ToString()
        {
            return $"{Fach} (bis {Faelligkeitsdatum.ToString("dddd.MM")} - {TageBisAblauf})";
        }

        public Hausuebung(string fach, DateTime faelligkeitsdatum, string inhalt)
        {
            Fach = fach;
            Faelligkeitsdatum = faelligkeitsdatum;
            Inhalt = inhalt;
            TageBisAblauf = (faelligkeitsdatum.Date - DateTime.Now.Date).Days;
        }
        public Hausuebung() 
        { }
    }
}
