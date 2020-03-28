#region Testatina
// ---------------------------------------------------------------------------
// Progetto:    TRF
// Nome File:   Lookup_tipo_indirizzo.cs
//
// Namespace:   SDG_DEMO.BusinessObjects
// Descrizione: Classe per LOOKUP_TIPO_INDIRIZZO
//
// Autore:      AG - SDG srl
// Data:        28/03/2020
// ---------------------------------------------------------------------------
// Storia delle revisioni
// Autore:      
// Data:        
// Motivo:
// Rif. ECR:
// ---------------------------------------------------------------------------
#endregion
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using SDG.ExceptionHandling;
using System;
using System.Data;
using System.Data.Common;
using System.Text;

namespace SDG_DEMO.BusinessObjects
{
    ///<summary>
    ///summary description for LOOKUP CLASS
    ///</summary>
    ///<remarks>
    ///comment here.
    ///</remarks>
    ///
    public class Lookup_tipo_indirizzo
    {
        #region Attributi e Variabili
        /// <value>
        /// Where Clause condition
        /// </value>
        public string SqlWhereClause { get; set; } = "";

        #endregion

        #region  Costruttori
        public Lookup_tipo_indirizzo()
        {
        }
        #endregion

        #region METODI
        /// <summary>
        /// getLookupTipoDocumento
        /// </summary>
        /// <returns>iDataReader:,_DESCRIZIONE</returns>
        public DataSet GetLookupTipoIndirizzo(string tableName)
        {
            string sqlCommand = null;
            StringBuilder sb = new StringBuilder(2000);
            DbCommand dbCommand = null;
            DataSet ds = new DataSet();
            try
            {
                Database db = DatabaseFactory.CreateDatabase("CONNECTION_STRING");

                sb.Append(" SELECT ");
                sb.Append(" LTI_TIPO_INDIRIZZO ");
                sb.Append(" FROM LOOKUP_TIPO_INDIRIZZO ");
                sb.Append(SqlWhereClause);

                sqlCommand = sb.ToString();
                dbCommand = db.GetSqlStringCommand(sqlCommand);
                db.AddInParameter(dbCommand, "sqlWhereClause", DbType.String, SqlWhereClause);
                db.LoadDataSet(dbCommand, ds, tableName);

            }

            catch (Exception ex)
            {
                ex.Data.Add("Class.Method", "LookupTipoDocumento.getLookupTipoDocumento.");
                ex.Data.Add("SQL", GenericError.SubstituteParameters(dbCommand.CommandText, dbCommand.Parameters));

                // Gestione messaggistica all'utente e trace in DB dell'errore
                ExceptionPolicy.HandleException(ex, "Direct Data Access Policy");

            
            }

                return ds;

        }
        #endregion
    }
}