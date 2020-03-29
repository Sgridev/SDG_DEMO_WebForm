#region Testatina
// ---------------------------------------------------------------------------
// Progetto:    TAF
// Nome File:   CrossUtenteIndirizzi.cs
//
// Namespace:   SDG_DEMO.BusinessObjects
// Descrizione: Classe per CROSSUTENTEINDIRIZZI
//
// Autore:      AG - SDG srl
// Data:        29/03/2020
// ---------------------------------------------------------------------------
// Storia delle revisioni
// Autore:      
// Data:        
// Motivo:
// Rif. ECR:
// ---------------------------------------------------------------------------
#endregion

using System.Data.SqlTypes;

namespace SDG_DEMO.BusinessObjects
{
    public class CrossUtenteIndirizzi
    {
        #region proprietà
        public SqlInt32 Cui_id_cross_utente_indirizzi { get; set; } = SqlInt32.Null;
        public SqlInt32 Ute_id_utente { get; set; } = SqlInt32.Null;
        public SqlInt32 Ind_id_indirizzi { get; set; } = SqlInt32.Null;
        public SqlInt32 Cui_creato_da { get; set; } = SqlInt32.Null;
        public SqlInt32 Cui_aggiornato_da { get; set; } = SqlInt32.Null;
        public SqlInt32 Cui_eliminato_da { get; set; } = SqlInt32.Null;
        public SqlDateTime Cui_data_creazione { get; set; } = SqlDateTime.Null;
        public SqlDateTime Cui_data_aggiornamento { get; set; } = SqlDateTime.Null;
        public SqlInt32 Cui_flag_eliminato { get; set; } = SqlInt32.Null;

        #endregion


    }
}