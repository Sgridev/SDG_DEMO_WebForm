#region Testatina
// ---------------------------------------------------------------------------
// Progetto:    Gestione Utenti
// Nome File:   frm_MSE_IND_UTE.aspx
//
// Namespace:   SDG.GestioneUtenti
// Descrizione: Classe di CodeBehind  della pagina
//
// Autore:      AG - SDG srl
// Data:        27/03/2020
// ---------------------------------------------------------------------------
// Storia delle revisioni
// Autore:  
// Data:     
// Motivo:   
// Rif. ECR:
// ---------------------------------------------------------------------------
#endregion

using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using SDG.GestioneUtenti;
using SDG.GestioneUtenti.Web;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using SDG.WorkFlow;
using SDG_DEMO.BusinessObjects;

public partial class Web_Ruoli_frm_MSE_IND_UTE : BasePage
{
    #region Web Form Control declarations
    protected Ruoli objRuoli;
    protected Utente objUtente;
    protected RuoliUtente objRuoli_utente;
    protected Workflow objWorkflow;

    //PAGE VARIABLES
    //protected int qRUL_ID_RUOLO;
    protected int qUTE_ID_UTENTE;
    protected int qURL_ID_RUOLI_UTENTE;
    protected string qPROVENIENZA;
    protected DataSet dsUtenti;

    #endregion

    #region PageLoad
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            qMODALITA = Request.QueryString["MODALITA"];
            qPROVENIENZA = Request.QueryString["PROVENIENZA"];

            //qRUL_ID_RUOLO = Convert.ToInt32(Request.QueryString["RUL_ID_RUOLO"]);
            qUTE_ID_UTENTE = Convert.ToInt32(Request.QueryString["UTE_ID_UTENTE"]);

            if (Request.QueryString["URL_ID_RUOLI_UTENTE"] != null)
                qURL_ID_RUOLI_UTENTE = Convert.ToInt32(Request.QueryString["URL_ID_RUOLI_UTENTE"]);

            SetPageControlAccess();

            //Set controlli per i permessi
            //Prima di effettuare eventuali disabilitazioni di altro genere
            BaseEnableControls(Page.Controls, allowEdit);

            if (!IsPostBack)
            {
                objUtente.Ute_id_utente = qUTE_ID_UTENTE;
                objUtente.Read();

                LabelTitolo.InnerText = GetValueDizionarioUI("INDIRIZZI");
                Label_indirizzo.InnerText = GetValueDizionarioUI("INDIRIZZO");
                ButtonSalva.Text = GetValueDizionarioUI("SALVA");
                ButtonAnnulla.Text = GetValueDizionarioUI("USCITA");
                Label_numero_civico.InnerText = GetValueDizionarioUI("NUMERO_CIVICO");
                Label_tipologia_indirizzo.InnerText = GetValueDizionarioUI("TIPOLOGIA_INDIRIZZO");
                Label_data_disattivazione.InnerText = GetValueDizionarioUI("DATA_DISABILITAZIONE");
                Label_attivo.InnerText = GetValueDizionarioUI("ATTIVO");
                Label_note.InnerText = GetValueDizionarioUI("NOTE");

                Lookup_tipo_indirizzo lookup_Tipo_Indirizzo = new Lookup_tipo_indirizzo();
                Dropdown_tipologia_indirizzo.DataSource = lookup_Tipo_Indirizzo.GetLookupTipoIndirizzo("LOOKUP_TIPO_INDIRIZZO");
                Dropdown_tipologia_indirizzo.DataValueField = "LTI_TIPO_INDIRIZZO";
                Dropdown_tipologia_indirizzo.DataTextField = "LTI_TIPO_INDIRIZZO";
                Dropdown_tipologia_indirizzo.DataBind();




            }


            //Registrazioni javascript                
            Page.ClientScript.RegisterStartupScript(this.GetType(), "varMODALITA", "var modalita = '" + qMODALITA + "';", true);
        }
        catch (Exception ex)
        {
            // Gestione messaggistica all'utente e trace in DB dell'errore
            ExceptionPolicy.HandleException(ex, "Propagate Policy");
        }

    }
    #endregion

    #region Access Control
    private void SetPageControlAccess()
    {
        SetPageControlAccess("UTERUL");
    }
    #endregion 

    #region DataBinding
    private void BindData()
    {
        try
        {
            //if (qRUL_ID_RUOLO != 0) objRuoli_utente.Rul_id_ruolo = qRUL_ID_RUOLO;
            if (qUTE_ID_UTENTE != 0) objRuoli_utente.Ute_id_utente = qUTE_ID_UTENTE;
            if (qURL_ID_RUOLI_UTENTE != 0) objRuoli_utente.Url_id_ruoli_utente = qURL_ID_RUOLI_UTENTE;
            objRuoli_utente.Read();
            GetValues();


        }
        catch (Exception ex)
        {
            // Gestione messaggistica all'utente e trace in DB dell'errore
            ExceptionPolicy.HandleException(ex, "Propagate Policy");
        }
    }
    #endregion

    #region OnInit
    override protected void OnInit(EventArgs e)
    {
        InitializeMyComponents();
        objRuoli = new Ruoli();
        objUtente = new Utente();
        objRuoli_utente = new RuoliUtente();
        objWorkflow = new Workflow();

        base.OnInit(e);
    }

    private void InitializeMyComponents()
    {
        this.PreRender += new System.EventHandler(this.frm_MSE_RUL_UTE_PreRender);
    }
    #endregion

    #region Web Form GET & SET Values
    /// <summary>
    /// Scrive i valori recuperati dal form negli attributi di classe
    /// </summary>
    private void SetValues()
    {


        objRuoli_utente.Ute_id_utente_aggiornato = Convert.ToInt32(Session["UTE_ID_UTENTE"].ToString());
        objRuoli_utente.Ute_id_utente_creato = Convert.ToInt32(Session["UTE_ID_UTENTE"].ToString());
        if (qURL_ID_RUOLI_UTENTE != 0) objRuoli_utente.Url_id_ruoli_utente = qURL_ID_RUOLI_UTENTE;
    }

    /// <summary>
    /// Ripresa valori da classe per visualizzazione in form maschera
    /// </summary>
    private void GetValues()
    {

    }
    #endregion

    #region Web Form Event Handler   

    protected void ButtonSalva_Click(object sender, EventArgs e)
    {


    }

    #endregion

    #region Web Form Menu JScriptFunctions
    /// <summary>
    /// Per refresh chiamante
    /// </summary>
    /// <returns></returns>


    public string CloseDialog_Js()
    {
        string js = @"
                <script type='text/javascript'>                    
				    self.parent.hideEditorDialog();                                                          
                    $('#ButtonRuoli',parent.frames['frameContent'].document).click();
				</script>";
        return js;
    }

    #endregion

    #region Web Form PreRender
    private void frm_MSE_RUL_UTE_PreRender(object sender, EventArgs e)
    {
        try
        {
            // ...
        }
        catch (Exception ex)
        {
            // Gestione messaggistica all'utente e trace in DB dell'errore
            ExceptionPolicy.HandleException(ex, "Propagate Policy");
        }
    }
    #endregion
}
