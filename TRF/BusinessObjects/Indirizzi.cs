#region Testatina
// ---------------------------------------------------------------------------
// Progetto:    TAF
// Nome File:   Indirizzi.cs
//
// Namespace:   SDG_DEMO.BusinessObjects
// Descrizione: Classe per INDIRIZZI
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


using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace SDG_DEMO.BusinessObjects
{
    public class Indirizzi
    {
        #region Proprietà
        public SqlInt32 Ind_id_indirizzi { get; set; } = SqlInt32.Null;
        public SqlString Ind_indirizzo { get; set; } = SqlString.Null;
        public SqlInt32 Ind_numero_civico { get; set; } = SqlInt32.Null;
        public SqlInt32 Ind_tipologia_indirizzo { get; set; } = SqlInt32.Null;
        public SqlInt32 Ind_attivo { get; set; } = SqlInt32.Null;
        public SqlInt32 Ind_data_disattivazione { get; set; } = SqlInt32.Null;
        public SqlString Ind_note { get; set; } = SqlString.Null;
        public SqlInt32 Ind_creato_da { get; set; } = SqlInt32.Null;
        public SqlInt32 Ind_aggiornato_da { get; set; } = SqlInt32.Null;
        public SqlInt32 Ind_eliminato_da { get; set; } = SqlInt32.Null;
        public SqlDateTime Ind_data_creazione { get; set; } = SqlDateTime.Null;
        public SqlDateTime Ind_data_aggiornamento { get; set; } = SqlDateTime.Null;
        public SqlInt32 Ind_flag_eliminato { get; set; } = SqlInt32.Null;
        #endregion
    }
}