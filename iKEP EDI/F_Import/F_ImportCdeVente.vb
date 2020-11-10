#Disable Warning BC30035 ' Erreur de syntaxe.
Imports System.IO
Imports System.Reflection

#Enable Warning BC30035 ' Erreur de syntaxe.
Public Class F_ImportCdeVente

    Dim ancVal As String
    Dim lImportId As Integer = 0
    Dim nbAnocontrat As Integer = 0
    Dim nbAnoCde As Integer = 0

    Sub listeTiers()
        Dim lers As OleDb.OleDbDataReader

        Me.lTiers.Items.Clear()
        lers = SqlLit("SELECT DISTINCT app.Tiers.TiersNom, app.Tiers.TiersId " _
                      & " FROM app.Tiers INNER JOIN app.TiersUser ON app.Tiers.TiersId = app.TiersUser.TiersId " _
                      & " INNER JOIN app.TiersSiteERP ON app.Tiers.TiersId = app.TiersSiteERP.TiersId " _
                      & " INNER JOIN app.Users ON app.TiersUser.UserLogin = app.Users.UserLogin AND app.TiersSiteERP.SiteCode = app.Users.SiteCode where TiersUser.UserLogin='" & leUser.Login & "'", conSqlEDI)
        While lers.Read
            Me.lTiers.Items.Add(New ListItem(lers("tiersid"), lers("TiersNom")))
        End While
        lers.Close()
    End Sub

    Sub AfficheBilan()
        Dim d1 As Date = Now

        AttenteDemarre("Affichage en-cours")
        Me.TabPage3.Text = "Anomalies Contrat"
        Me.TabPage1.Text = "Contrat"
        Me.TabPage2.Text = "Hors Contrat"
        'affiche le dernier import
        Call StatutBar("Lecture des contrats")
        Call ListeContrat()
        Call StatutBar("Lecture des anomalies contrat")
        Call ListeAnomalieContrat()
        Call StatutBar("Lecture des anomalies Commande")
        Call ListeAnomalieCde()
        Call StatutBar("Lecture des commandes hors contrat")
        Call ListeCommande()
        Call StatutBar("")

        System.Threading.Thread.Sleep(1000)
        AttenteFin()

        '        If Modedebug Then MsgBox("Affichage :" & DateDiff(DateInterval.Second, d1, Now))

        Me.Tableaux.Visible = True
    End Sub

    Sub InitBilan()
        Dim d1 As Date = Now

        Me.TabPage3.Text = "Anomalies Contrat"
        Me.TabPage1.Text = "Contrat"
        Me.TabPage2.Text = "Hors Contrat"

        Me.gContrat.Visible = False
        Me.gContrat.Rows.Clear()
        Me.gAnoCde.Visible = False
        Me.gAnoCde.Rows.Clear()
        Me.gAnoContrat.Visible = False
        Me.gAnoContrat.Rows.Clear()
        Me.gCommande.Visible = False
        Me.gCommande.Rows.Clear()

        Call StatutBar("")
        Me.Tableaux.Visible = True
    End Sub

    Sub ListeAnomalieContrat()
        Dim lers As OleDb.OleDbDataReader
        Dim sSql As String
        Dim filtreMsg As String = ""
        Dim nbligne As Integer = 0

        Me.gAnoContrat.Visible = False
        Me.gAnoContrat.Rows.Clear()

        If Me.OptionA.Checked Then filtreMsg &= " or MsgLigne like '%A%'"
        If Me.optionM.Checked Then filtreMsg &= " or MsgLigne like '%M%'"
        If Me.optionM.Checked Then filtreMsg &= " or MsgLigne like '%T%'"

        If filtreMsg <> "" Then
            filtreMsg = "And (" & filtreMsg.Remove(0, 3) & ")"
            sSql = "SELECT   codeclient, NumContrat, Article,  NumCdeEDI_Tiers, ArtCode_Tiers, ArtDesc_Tiers, DateBesoin, QteBesoin,  " _
            & " NumCde_ERP, ArtCode_ERP, ArtDesc_ERP, QteCde, MsgLigne, DateEmisPrg" _
            & " FROM  CommandeVente_Anomalie" _
            & " WHERE NumContrat <> '' and ImportId=" & lImportId _
            & filtreMsg _
            & " ORDER BY NumContrat,Article"

            lers = SqlLit(sSql, conSqlEDI)
            While lers.Read
                Me.gAnoContrat.Rows.Add(lers("NumContrat"), Nz(lers("Article"), ""), Nz(lers("artDesc_tiers"), ""), Nz(lers("msgLigne"), ""), Date2Grid(lers("DateEmisPrg")))
                nbligne += 1
            End While
            lers.Close()
        End If

        nbAnocontrat = nbligne
        Me.gAnoContrat.Visible = True
        Me.TabPage3.Text = "Anomalies Contrat/Cde (" & nbAnoCde + nbAnocontrat & ")"

    End Sub

    Sub ListeAnomalieCde()
        Dim lers As OleDb.OleDbDataReader
        Dim sSql As String
        Dim filtreMsg As String = ""
        Dim nbligne As Integer = 0

        Me.gAnoCde.Visible = False
        Me.gAnoCde.Rows.Clear()

        If Me.optionP.Checked Then filtreMsg &= " or MsgLigne like '%P%'"
        If Me.optionR.Checked Then filtreMsg &= " or MsgLigne like '%R%'"
        If Me.optionS.Checked Then filtreMsg &= " or MsgLigne like '%S%'"
        If Me.optionU.Checked Then filtreMsg &= " or MsgLigne like '%U%'"

        If filtreMsg <> "" Then
            filtreMsg = "And (" & filtreMsg.Remove(0, 3) & ")"
            sSql = "SELECT   codeclient, NumContrat, Article,  NumCdeEDI_Tiers, ArtCode_Tiers, ArtDesc_Tiers, DateBesoin, QteBesoin,  " _
            & " NumCde_ERP, ArtCode_ERP, ArtDesc_ERP, QteCde, MsgLigne" _
            & " FROM  CommandeVente_Anomalie" _
            & " WHERE NumContrat <> '' and ImportId=" & lImportId _
            & filtreMsg _
            & " ORDER BY NumContrat,Article"
            lers = SqlLit(sSql, conSqlEDI)
            While lers.Read
                Me.gAnoCde.Rows.Add(lers("NumContrat"), Nz(lers("ArtCode_ERP"), ""), Nz(lers("CodeClient"), ""), Nz(lers("NumCde_ERP"), ""), Nz(lers("msgLigne"), ""))
                nbligne += 1
            End While

            lers.Close()
        End If

        nbAnoCde = nbligne
        Me.gAnoCde.Visible = True
        Me.TabPage3.Text = "Anomalies Contrat/Cde (" & nbAnoCde + nbAnocontrat & ")"

    End Sub

    Sub ListeContrat()
        Dim lers As OleDb.OleDbDataReader
        Dim precVal As String = ""
        Dim Cumul As Decimal
        Dim cumulBesoin As Decimal
        Dim CumulBesoinPC As Decimal
        Dim cumulCde As Decimal
        Dim msgCde As String = ""
        Dim ecart As Decimal
        Dim sSql As String
        Dim FiltreMsg As String
        Dim LigDispo As Integer
        Dim i As Integer = 0
        Dim NbContrat As Integer = 0
        Dim d1 As Date = Now

        'My.Settings.HorizonContratDeb = Me.tHorizonContratDeb.Text
        'My.Settings.HorizonContratFin = Me.tHorizonContratFin.Text
        If Me.dModifFin.Checked Then My.Settings.DateModifFin = Me.dModifFin.Value Else My.Settings.DateModifFin = CDate("01/01/2050")

        My.Settings.Save()

        Me.gContrat.Visible = False
        Me.gContrat.Rows.Clear()

        FiltreMsg = ""
        If Me.optionToutContrat.Checked Then FiltreMsg = " or msgLigneCumul =''"
        If Me.optionH.Checked Then FiltreMsg &= " or msgLigneCumul like '%H%'"
        If Me.optionE.Checked Then FiltreMsg &= " or msgLigneCumul like '%E%'"
        If Me.OptionK.Checked Then FiltreMsg &= " or msgLigneCumul like '%K%'"
        If Me.optionAutreMsg.Checked Then FiltreMsg &= " or msgLigneCumul <> ''"

        If FiltreMsg <> "" Then FiltreMsg = "And (" & FiltreMsg.Remove(0, 3) & ")" Else FiltreMsg = " and 1=2 "

        sSql = "SELECT NumContrat, Article, ArtDesc_Tiers, DateBesoin, QteBesoin, ArtCode_ERP, QteCde, NumCde_ERP, CodeClient, TypeBesoin_Tiers, TypeCde_ERP, " _
            & " SoldeQteLigne, MsgLigne, NumCdeEDI_Tiers, NumCdeEDI_ERP, NumLigne_ERP, MsgCde , MsgLigneCumul, LigneDispo_ERP, LignePrec_ERp, LigneSUiv_ERP" _
            & " ,LignePrecDispo_ERp, LigneSuivDispo_ERP,lid,qtecde-qteLivre as qtePTF" _
            & " FROM CommandeVente_Bilan " _
            & " WHERE (NumContrat <> '' and importId=" & lImportId & ") "
        '& " AND (DateBesoin <= '" & Now.AddMonths(Val(Me.tHorizonContratFin.Text)).ToShortDateString & "')"

        If Me.tArticle.Text <> "" Then sSql &= " and (article like '%" & Me.tArticle.Text & "%' or ArtCode_ERP like '%" & Me.tArticle.Text & "%')"
        If Me.tContrat.Text <> "" Then sSql &= " and NumContrat like '%" & Me.tContrat.Text & "%'"
        If Me.dModifFin.Checked Then sSql &= " and date1ereModif<=" & Date2sql(Me.dModifFin.Value)
        'If Val(Me.tHorizonContratDeb.Text) <> 0 Then sSql &= " And (DateBesoin >= '" & Now.AddMonths(Val(Me.tHorizonContratDeb.Text)).ToShortDateString & "')"
        sSql &= " and lid not in ( select lid from commandevente_transfert where numcontrat<>'' and Importid=" & lImportId & " and statutaffiche=1)"
        sSql &= FiltreMsg & " ORDER BY date1ereModif,NumContrat,Article, DateBesoin, ligneid "

        lers = SqlLit(sSql, conSqlEDI)
        While lers.Read
            Call StatutBar("Contrat :" & i)
            If Nz(lers("numcontrat"), "") <> precVal Then
                NbContrat += 1
                precVal = Nz(lers("numcontrat"), "")
                If cumulCde = 0 Then ecart = 0 Else ecart = Math.Round(((cumulBesoin / cumulCde - 1)), 2)
                If Me.gContrat.RowCount > 0 Then
                    Me.gContrat.Rows.Add(False, "", "", "", Me.iML.Images(0), "", "", "", cumulBesoin, cumulCde, "", IIf(ecart = 0, "", ecart.ToString("0%")), "", "", "", "", "", "", "", msgCde)
                    Me.gContrat.Rows(Me.gContrat.RowCount - 1).DefaultCellStyle.BackColor = Color.LightGray
                    Me.gContrat.Rows(Me.gContrat.RowCount - 1).ReadOnly = True
                End If
                Cumul = 0
                cumulBesoin = 0
                cumulCde = 0
                msgCde = ""
            End If

            msgCde = Nz(lers("MsgLigneCumul"), "")
            Cumul += Nz(lers("QteBeSoin"), 0) - Nz(lers("QteCde"), 0)
            cumulBesoin += Nz(lers("QteBesoin"), 0)
            cumulCde += Nz(lers("QteCde"), 0)
            If Nz(lers("NumLigne_ERP"), 0) <> 0 And Nz(lers("QteBesoin"), 0) = 0 Then LigDispo = 1 Else LigDispo = 0

            i += 1
            CumulBesoinPC = 0

            If cumulCde > 0 Then CumulBesoinPC = Math.Round((cumulBesoin / cumulCde - 1) * 100, 0)
            Me.gContrat.Rows.Add(False, lers("NumContrat"), lers("Article"), lers("artDesc_tiers"), Me.iML.Images(0), "", Date2Grid(lers("DateBesoin")), lers("TypeBesoin_Tiers"), lers("QteBesoin"),
                 lers("QteCde"), lers("qtePTF"), lers("TypeCde_ERP"), lers("ArtCode_ERP"), lers("CodeClient"), lers("NumCde_ERP"), lers("NumLigne_ERP"), "", Cumul, CumulBesoinPC, Nz(lers("msgLigne"), ""),
                 Nz(lers("msgLigneCumul"), ""), Nz(lers("msgCde"), ""), lers("LigneDispo_ERP"), lers("LignePrec_ERP"), lers("LignePrecDispo_ERP"), lers("LigneSuiv_ERP"), lers("LigneSuivDispo_ERP"), lers("Lid"))
            'Me.gContrat.Rows(Me.gContrat.RowCount - 1).Cells("Act").Value = "A"

            With Me.gContrat.Rows(Me.gContrat.RowCount - 1)
                If Nz(.Cells("typecde_ERP").Value, "") <> Nz(.Cells("TypeBesoin").Value, "") And Nz(.Cells("typecde_ERP").Value, "") <> "" And Nz(.Cells("TypeBesoin").Value, "") <> "" Then .Cells("TypeBesoin").Style.BackColor = coulModif
                If Nz(.Cells("QteCde").Value, 0) <> Nz(.Cells("QteBesoin").Value, 0) Then .Cells("cumul").Style.BackColor = coulModif
                If Nz(.Cells("QteCde").Value, 0) <> Nz(.Cells("QteBesoin").Value, 0) And Nz(.Cells("QteCde").Value, 0) <> 0 And Nz(.Cells("QteBesoin").Value, 0) <> 0 Then .Cells("Qtebesoin").Style.BackColor = coulModif
            End With
        End While

        'Dernière Ligne
        If cumulCde = 0 Then ecart = 0 Else ecart = Math.Round(((cumulBesoin / cumulCde - 1)), 2)
        Me.gContrat.Rows.Add(False, "", "", "", Me.iML.Images(0), "", "", "", cumulBesoin, cumulCde, "", IIf(ecart = 0, "", ecart.ToString("0%")), "", "", "", "", "", "", "", msgCde)
        Me.gContrat.Rows(Me.gContrat.RowCount - 1).DefaultCellStyle.BackColor = Color.LightGray
        Me.gContrat.Rows(Me.gContrat.RowCount - 1).ReadOnly = True

        lers.Close()

        '        If Modedebug Then MsgBox("Liste Contrat :" & DateDiff(DateInterval.Second, d1, Now))
        Call StatutBar("Numérote")
        Call Numerote()
        Me.gContrat.Visible = True
        Me.TabPage1.Text = "Contrat (" & i & ")"
        Me.tNbContrat.Text = NbContrat & " contrat(s)"
    End Sub

    Private Sub Numerote()
        Dim i As Integer
        Dim NbLigneACreer As Integer
        Dim lepas As Decimal
        Dim j As Integer

        '        Call AfficheContrat()

        Dim d1 As Date = Now
        'Réaffecte les N° de lignes si possible : 
        For i = 0 To Me.gContrat.RowCount - 2
            Call StatutBar("Réattribue N° " & i & " / " & Me.gContrat.RowCount)
            With Me.gContrat.Rows(i)
                .Cells("NumLigne_Prop").Value = ""
                If Nz(.Cells("QteBesoin").Value, 0) <> 0 And Nz(.Cells("Numcontrat_tiers").Value, "") <> "" Then
                    'Ligne à numéroter

                    '1 - Cherche si la ligne ERP est dispo
                    If .Cells("LigDispo").Value Then
                        .Cells("numligne_prop").Value = Nz(.Cells("NumLigneCde_ERP").Value, 0)
                        .Cells("LigDispo").Value = False
                    Else
                        ' si la ligne ERp n'est pas dispo, alors on cherche si la ligne précédente est dispo
                        If .Cells("LigPrecDispo").Value Then
                            .Cells("numligne_prop").Value = .Cells("LigPrec").Value
                            If i > 1 Then Me.gContrat.Rows(i - 1).Cells("LigDispo").Value = False
                            For c = Me.gContrat.Columns("DateBesoin").Index To Me.gContrat.Columns("NumLigne_Prop").Index : .Cells(c).Style.BackColor = coulRecule : Next c
                            If Nz(Me.gContrat.Rows(i - 1).Cells("DateBesoin").Value, "") <> "" Then
                                Me.gContrat.Rows(i - 1).Cells("DateBesoin").Style.BackColor = coulRecule
                                Me.gContrat.Rows(i - 1).Cells("Act").Value = Me.iML.Images(4)
                                Me.gContrat.Rows(i - 1).Cells("Act2").Value = "▼"
                                Me.gContrat.Rows(i - 1).Cells("Act2").Style.ForeColor = Color.FromArgb(255, 50, 255)
                            End If
                        Else
                            ' sinon on cherche si la ligne suivante est dispo
                            If .Cells("LigSuivDispo").Value Then
                                .Cells("numligne_prop").Value = .Cells("LigSuiv").Value
                                For c = Me.gContrat.Columns("DateBesoin").Index To Me.gContrat.Columns("NumLigne_Prop").Index : .Cells(c).Style.BackColor = coulAvance : Next c
                                If Nz(Me.gContrat.Rows(i + 1).Cells("DateBesoin").Value, "") <> "" Then
                                    Me.gContrat.Rows(i + 1).Cells("DateBesoin").Style.BackColor = coulAvance
                                    Me.gContrat.Rows(i + 1).Cells("Act").Value = Me.iML.Images(3)
                                    Me.gContrat.Rows(i + 1).Cells("Act2").Value = "▲"
                                    Me.gContrat.Rows(i + 1).Cells("Act2").Style.ForeColor = Color.FromArgb(255, 100, 0)
                                End If


                                Me.gContrat.Rows(i + 1).Cells("LigDispo").Value = False
                                If i < Me.gContrat.RowCount - 2 AndAlso (Me.gContrat.Rows(i + 1).Cells("Numcontrat_tiers").Value <> "" And Me.gContrat.Rows(i + 2).Cells("Numcontrat_tiers").Value <> "") Then
                                    Me.gContrat.Rows(i + 2).Cells("LigPrecDispo").Value = False
                                End If
                            Else
                                'sinon on doit créer une nouvelle ligne
                                .Cells("numligne_prop").Value = -1
                            End If
                            '
                        End If
                    End If
                End If
            End With
        Next

        '        If Modedebug Then MsgBox("Réattribue" & DateDiff(DateInterval.Second, d1, Now))

        d1 = Now
        'Affecte les num des lignes à creéer et indique les lignes ERP à supprimer
        For i = 0 To Me.gContrat.RowCount - 1
            Call StatutBar("Numérote " & i & " / " & Me.gContrat.RowCount)
            With Me.gContrat.Rows(i)
                If Txt2num(.Cells("numligne_prop").Value) < 0 Then
                    NbLigneACreer += 1
                Else

                    If NbLigneACreer > 0 Then
                        '         Me.gContrat.Rows(i - 1).Cells("numligne_prop").Value = 9000 + NbLigneACreer
                        If Me.gContrat.Rows(i - 1).Cells("LigSuiv").Value = 0 Then lepas = 10 Else lepas = (Me.gContrat.Rows(i - 1).Cells("LigSuiv").Value - Me.gContrat.Rows(i - 1).Cells("LigPrec").Value) / (NbLigneACreer + 1)

                        For j = 1 To NbLigneACreer
                            If lepas > 1 Then
                                Me.gContrat.Rows(i - NbLigneACreer + j - 1).Cells("numligne_prop").Value = Me.gContrat.Rows(i - NbLigneACreer + j - 1).Cells("LigPrec").Value + Math.Round(j * lepas, 0)
                                '                            Me.gContrat.Rows(i - NbLigneACreer + j - 1).Cells("numligne_prop").Style.BackColor = Color.LightBlue

                                For c = Me.gContrat.Columns("DateBesoin").Index To Me.gContrat.Columns("NumLigne_Prop").Index
                                    Me.gContrat.Rows(i - NbLigneACreer + j - 1).Cells(c).Style.BackColor = coulAjout
                                    Me.gContrat.Rows(i - NbLigneACreer + j - 1).Cells("act").Value = iML.Images(1)
                                    Me.gContrat.Rows(i - NbLigneACreer + j - 1).Cells("act2").Value = "+"
                                    Me.gContrat.Rows(i - NbLigneACreer + j - 1).Cells("act2").Style.ForeColor = Color.FromArgb(50, 150, 0)
                                Next c
                            Else
                                Me.gContrat.Rows(i - NbLigneACreer + j - 1).Cells("numligne_prop").Value = "?"
                                Me.gContrat.Rows(i - NbLigneACreer + j - 1).Cells("numligne_prop").Style.BackColor = coulQUestion
                                Me.gContrat.Rows(i - NbLigneACreer + j - 1).Cells("Act").Value = Me.iML.Images(5)
                                Me.gContrat.Rows(i - NbLigneACreer + j - 1).Cells("Act2").Value = "?"
                                Me.gContrat.Rows(i - NbLigneACreer + j - 1).Cells("Act2").Style.ForeColor = Color.FromArgb(200, 150, 0)

                            End If

                        Next
                    End If
                    NbLigneACreer = 0
                End If

                If .Cells("LigDispo").Value Then
                    If Nz(.Cells("qteLivre").Value, 0) <> 0 Then
                        .Cells("NumLigne_Prop").Value = "Clôture"
                        .Cells("act").Value = iML.Images(7)
                        .Cells("act2").Value = "X"
                        .Cells("act2").Style.ForeColor = Color.FromArgb(200, 150, 0)
                    Else
                        .Cells("NumLigne_Prop").Value = "Suppr"
                        .Cells("act").Value = iML.Images(2)
                        .Cells("act2").Value = "⁃"
                        .Cells("act2").Style.ForeColor = Color.FromArgb(200, 50, 0)
                    End If
                    For c = Me.gContrat.Columns("DateBesoin").Index To Me.gContrat.Columns("NumLigne_Prop").Index : .Cells(c).Style.BackColor = coulSuppr : Next c
                End If
            End With
        Next
        '        If Modedebug Then MsgBox("Numérote" & DateDiff(DateInterval.Second, d1, Now))
    End Sub


    Sub ListeCommande()
        Dim lers As OleDb.OleDbDataReader
        Dim i As Integer = 0
        Dim sSql As String = ""

        Me.gCommande.Visible = False
        Me.gCommande.Rows.Clear()
        sSql = "SELECT   NumContrat, Article, ArtDesc_Tiers, DateBesoin, QteBesoin, ArtCode_ERP, QteCde, NumCde_ERP, CodeClient, TypeBesoin_Tiers, TypeCde_ERP, " _
            & " SoldeQteLigne, MsgLigne, NumCdeEDI_Tiers, NumCdeEDI_ERP, NumLigne_ERP, Date_ERP " _
            & " FROM CommandeVente_Bilan " _
            & " WHERE NumContrat= '' and ImportId=" & lImportId

        If Me.tArtCde.Text <> "" Then sSql &= " and (Article like '%" & Me.tArtCde.Text & "%' or ArtCode_ERP like '%" & Me.tArtCde.Text & "%')"
        If Me.tCdeEDI.Text <> "" Then sSql &= " and NumCdeEDI_Tiers like '%" & Me.tCdeEDI.Text & "%'"

        sSql &= " ORDER BY NumCdeEDI_Tiers,article"

        lers = SqlLit(sSql, conSqlEDI)
        While lers.Read
            Me.gCommande.Rows.Add(False, lers("NumCdeEDI_Tiers"), lers("Article"), lers("artDesc_tiers"), Date2Grid(lers("DateBesoin")), lers("TypeBesoin_tiers"), lers("QteBesoin"), Date2Grid(lers("Date_ERP")), lers("TypeCde_ERP"), lers("QteCde"), lers("ArtCode_ERP"), lers("CodeClient"), lers("NumCde_ERP"), lers("NumLigne_ERP"), Nz(lers("msgLigne"), ""))
            i += 1
        End While
        lers.Close()
        Me.gCommande.Visible = True
        Me.TabPage2.Text = "Hors Contrat (" & i & ")"
    End Sub

    Function ImportCdeVente(FichierSource As String) As Integer
        Dim lETL As String
        Dim sSql As String
        Dim leRs As OleDb.OleDbDataReader
        Dim NbLigne As Integer = -1
        Dim lesParam As New List(Of SSISParam)
        Dim leServ As String = ""

        Try
            For Each s As String In conSqlEDI.ConnectionString.Split(";")
                If s.Split("=")(0) = "Server" Then leServ = s.Split("=")(1)
            Next

            StatutBar("Recherche Traitement Tiers...")

            lETL = ""
            sSql = "SELECT ETLCommandeVente_IN FROM app.Tiers where tiersid=" & Me.lTiers.SelectedItem.value
            leRs = SqlLit(sSql, conSqlEDI)
            While leRs.Read
                lETL = Nz(leRs(0), "")
            End While
            leRs.Close()

            If lETL <> "" Then
                StatutBar("Execution Traitement Tiers...")
                lesParam.Clear()
                lesParam.Add(New SSISParam("FichierSource", leUser.RepImport & FichierSource, "PACKAGE"))
                lesParam.Add(New SSISParam("TiersId", Int(Me.lTiers.SelectedItem.value), "PACKAGE"))
                lesParam.Add(New SSISParam("UserLogin", leUser.Login, "PACKAGE"))
                If SSISexecute(leUser.RepSSIS, lETL & ".dtsx", lesParam, "Importation des données") Then
                    leRs = SqlLit("SELECT count(*) as Nb  FROM CommandeVente_EDI where userlogin ='" & leUser.Login & "' and tiersid=" & Me.lTiers.SelectedItem.value, conSqlEDI)
                    While leRs.Read
                        NbLigne = leRs(0)
                    End While
                    leRs.Close()
                End If
            End If
            StatutBar("")

        Catch ex As Exception
            MsgBox(ex.Message)
            Throw New Exception(ex.Message)
        End Try
        Return NbLigne

    End Function


    Function ExecuteBilan() As Boolean
        Dim lesParam As New List(Of SSISParam)
        Try
            lesParam.Clear()
            lesParam.Add(New SSISParam("ImportId", lImportId, "PACKAGE"))
            lesParam.Add(New SSISParam("BaseSilog", leUser.Base, "PROJET"))
            lesParam.Add(New SSISParam("ServSilog", leUser.ServeurERP, "PROJET"))
            lesParam.Add(New SSISParam("TiersId", Int(Me.lTiers.SelectedItem.value), "PACKAGE"))
            lesParam.Add(New SSISParam("UserLogin", leUser.Login, "PACKAGE"))
            lesParam.Add(New SSISParam("NumeroTest", IIf(Me.lTest.Visible, Me.lTest.Text, 0), "PACKAGE"))
            Return SSISexecute(leUser.RepSSIS, "DM_IN_CDV_Compare.dtsx", lesParam, "Analyse des données Importées")

        Catch ex As Exception
            MsgBox(ex.Message)
            Throw New Exception(ex.Message)
            Return False
        End Try

    End Function

    Function ImportNouveau() As Integer
        Dim sSql As String

        sSql = "Insert into app.import (UserLogin, DateImport, SiteCode, TiersId, TypeImport, FichierSource) values (" _
        & "'" & leUser.Login & "','" & Now() & "','" & leUser.Site & "','" & Me.lTiers.SelectedItem.value & "','CdV','')"
        SqlDo(sSql, conSqlEDI)

        Return ImportDernier()
    End Function

    Function ImportDernier() As Integer
        Dim leRs As OleDb.OleDbDataReader
        Dim sSql As String
        Dim lId As Integer = 0
        Dim d As Date

        sSql = "SELECT top 1 ImportId,DateImport,FichierSource FROM app.Import " _
            & " WHERE  ImportId = (SELECT MAX(ImportId) AS ID FROM app.Import where TiersId=" & Me.lTiers.SelectedItem.value & " And UserLogin='" & leUser.Login & "' and sitecode='" & leUser.Site & "')"
        leRs = SqlLit(sSql, conSqlEDI)
        While leRs.Read
            lId = leRs(0)
            d = leRs("DateImport")
            Me.tImport.Text = "Import N° " & lId & " du " & d.ToString("dd/MM/yyyy HH:mm")
            '            Me.tFichierSource.Text = leRs("FIchierSOurce")
        End While
        leRs.Close()
        Return lId
    End Function

    Sub archiveFichier(success As Boolean)
        Dim f2 As String
        Dim f1 As String

        For i = 0 To F_ImportListe.gFichier.RowCount - 1
            f1 = F_ImportListe.gFichier.Rows(i).Cells("FicLocal").Value
            f2 = F_ImportListe.gFichier.Rows(i).Cells("FicServ").Value
            f2 = f2.Substring(f2.LastIndexOf("\"), f2.Length - f2.LastIndexOf("\"))
            If success Then
                Try
                    File.Move(F_ImportListe.gFichier.Rows(i).Cells("FicServ").Value, leUser.RepImport & leUser.RepSuccess & f2)
                    SqlDo("insert into app.importfichier (importid,FichierSource, fichierDest) values(" & lImportId & " ,'" & f1 & "','" & leUser.RepImport & leUser.RepSuccess & f2 & "')", conSqlEDI)
                Catch ex As Exception
                End Try
            Else
                Try
                    File.Delete(F_ImportListe.gFichier.Rows(i).Cells("FicServ").Value)
                Catch ex As Exception
                End Try
            End If
        Next
    End Sub

    Sub ImportBilan()
        Dim Nblignes As Integer
        Dim leRs As OleDb.OleDbDataReader
        '        Dim b As Boolean

        Try
            leRs = SqlLit("SELECT count(*) as Nb  FROM CommandeVente_EDI where userlogin ='" & leUser.Login & "' and tiersid=" & Me.lTiers.SelectedItem.value, conSqlEDI)
            While leRs.Read
                Nblignes = leRs(0)
            End While
            leRs.Close()

            If Nblignes >= 0 Then
                F_Main.Focus()
                If MessageBox.Show(Nblignes & " lignes importées. Continuer ?", "Importation", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
                    StatutBar("Cherche Numéro Import")
                    lImportId = ImportNouveau()
                    If lImportId > 0 Then
                        StatutBar("Exécution Bilan")
                        If ExecuteBilan() Then
                            StatutBar("Archivage Fichier Import")
                            Call archiveFichier(True)
                            F_Main.Focus()
                            MessageBox.Show("Import terminé")
                            Call AfficheBilan()
                        End If
                    End If
                Else
                    Call archiveFichier(False)
                End If
                StatutBar("")
            Else
                F_Main.Focus()
                MessageBox.Show("Erreur Importation")
            End If
            StatutBar("")

        Catch ex As Exception
            F_Main.Focus()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Function ImportSansFichier() As Boolean
        Dim b As Boolean
        Dim lesParam As New List(Of SSISParam)
        Dim lETL As String
        Dim sSql As String
        Dim leRs As OleDb.OleDbDataReader

        b = False
        SqlDo("Delete from commandeVente_EDI where tiersid=" & Me.lTiers.SelectedItem.value & " and userlogin='" & leUser.Login & "'", conSqlEDI)
        Try
            StatutBar("Recherche Traitement Tiers...")

            lETL = ""
            sSql = "select ETL from app.TiersTraitement where CatTraitId=1 and TiersId=" & Me.lTiers.SelectedItem.value
            leRs = SqlLit(sSql, conSqlEDI)
            While leRs.Read : lETL = Nz(leRs(0), "") : End While
            leRs.Close()

            If lETL <> "" Then
                StatutBar("Execution Traitement Tiers...")
                lesParam.Clear()
                lesParam.Add(New SSISParam("TiersId", Int(Me.lTiers.SelectedItem.value), "PACKAGE"))
                lesParam.Add(New SSISParam("UserLogin", leUser.Login, "PACKAGE"))
                If SSISexecute(leUser.RepSSIS, lETL & ".dtsx", lesParam, "Importation des données") Then b = True
            End If
            StatutBar("")
        Catch ex As Exception
            b = False
            MsgBox(ex.Message)
            Throw New Exception(ex.Message)
        End Try
        StatutBar("")
        Return b
    End Function



    Private Sub Import(sender As System.Object, e As System.EventArgs) Handles bImporter.Click
        Dim TiersLoadFile As Boolean = True
        Dim leRs As OleDb.OleDbDataReader
        Dim b As Boolean

        If IsNothing(Me.lTiers.SelectedItem) Then Exit Sub

        leRs = SqlLit("Select tiersLoadfile from app.tiers where tiersid=" & Me.lTiers.SelectedItem.value, conSqlEDI)
        If leRs.HasRows Then
            leRs.Read()
            TiersLoadFile = leRs(0)
        End If
        leRs.Close()

        If TiersLoadFile Then
            F_ImportListe.leTiersId = Me.lTiers.SelectedItem.value
            b = (F_ImportListe.ShowDialog() = DialogResult.OK)
            F_ImportListe.Dispose()
            F_Main.Focus()
        Else
            b = ImportSansFichier()
        End If

        If b Then Call importBilan

    End Sub

    'Private Sub Import_old(sender As System.Object, e As System.EventArgs) 'Handles bImporter.Click
    '    Dim lextension As String = ""
    '    Dim leNomSourceServer As String = ""
    '    Dim Nblignes As Integer

    '    If IsNothing(Me.lTiers.SelectedItem) Then Exit Sub

    '    oFileDialog.FileName = ""
    '    If oFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        Try
    '            StatutBar("Transfert Fichier sur serveur")
    '            AttenteDemarre("Transfert du fichier sur le serveur", 2)
    '            lextension = oFileDialog.FileName.Substring(oFileDialog.FileName.LastIndexOf("."), oFileDialog.FileName.Length - oFileDialog.FileName.LastIndexOf("."))
    '            leNomSourceServer = "\" & Me.lTiers.Text & "_" & Now.ToString("yyyyMMdd_HHmm") & lextension
    '            StatutBar("Transfert du fichier sur serveur")
    '            FileCopy(oFileDialog.FileName, leUser.RepImport & leNomSourceServer)
    '            AttenteFin()

    '            StatutBar("Transfert Fichier sur serveur")

    '            Nblignes = ImportCdeVente(leNomSourceServer)

    '            If Nblignes >= 0 Then
    '                F_Main.Focus()
    '                If MessageBox.Show(Nblignes & " lignes importées. Continuer ?", "Importation", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
    '                    StatutBar("Cherche Numéro Import")
    '                    Call ImportNouveau(leUser.RepImport & leUser.RepSuccess & leNomSourceServer)
    '                    lImportId = ImportDernier()
    '                    If lImportId > 0 Then
    '                        StatutBar("Exécution Bilan")
    '                        If ExecuteBilan() Then
    '                            StatutBar("Archivage Fichier Import")

    '                            File.Move(leUser.RepImport & leNomSourceServer, leUser.RepImport & leUser.RepSuccess & leNomSourceServer)
    '                            F_Main.Focus()
    '                            MessageBox.Show("Import terminé")
    '                            Call AfficheBilan()
    '                        End If
    '                    End If
    '                End If
    '                StatutBar("")
    '            Else
    '                F_Main.Focus()
    '                MessageBox.Show("Erreur Importation")
    '            End If
    '            StatutBar("")
    '        Catch ex As Exception
    '            AttenteFin()
    '            F_Main.Focus()
    '            MessageBox.Show(ex.Message)
    '        End Try

    '        Try
    '            File.Delete(leUser.RepImport & leNomSourceServer)
    '        Catch ex As Exception
    '        End Try
    '        F_Main.Focus()

    '    End If
    'End Sub

    Sub OptionAnoContratInit(b As Boolean)
        Me.OptionA.Checked = b
        Me.optionM.Checked = b
        Me.optionT.Checked = b
    End Sub

    Sub OptionAnoCdeInit(b As Boolean)
        Me.optionP.Checked = b
        Me.optionR.Checked = b
        Me.optionS.Checked = b
        Me.optionU.Checked = b
    End Sub

    Sub OptionContratInit(b As Boolean)
        Me.optionH.Checked = b
        Me.optionE.Checked = b
        Me.OptionK.Checked = b
        Me.optionAutreMsg.Checked = b
    End Sub
    Public Sub MakeGridViewDoubleBuffered(ByVal dgv As DataGridView)
        Dim dgvType As Type = dgv.[GetType]()
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(dgv, True, Nothing)
    End Sub

    Private Sub F_ImportCdeVente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call listeTiers()
        My.Settings.Reload()
        If Year(My.Settings.DateModifFin) < 2050 Then
            Me.dModifFin.Checked = True
            Me.dModifFin.Value = My.Settings.DateModifFin
        Else
            Me.dModifFin.Checked = False
        End If
        MakeGridViewDoubleBuffered(Me.gContrat)
    End Sub

    Private Sub gImportContrat_CellBeginEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles gContrat.CellBeginEdit
        ancVal = Nz(Me.gContrat.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, "").ToString
    End Sub

    Private Sub gImportContrat_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gContrat.CellEndEdit
        Dim cumul As Decimal
        Dim CumulCde As Decimal
        Dim i As Integer
        Dim soldeligne As Decimal
        If e.ColumnIndex > 1 And Nz(Me.gContrat.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, "").ToString <> ancVal Then
            Me.gContrat.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.LightGreen
            If Me.gContrat.Columns(e.ColumnIndex).HeaderText = "Qté Cde" Then
                ' remonte à la 1ere ligne du contrat
                i = e.RowIndex
                While Nz(Me.gContrat.Rows(i - 1).Cells("numcontrat_Tiers").Value, "") <> "" And i > 0
                    Me.gContrat.Rows(i).Cells("SelContrat").Value = True
                    i -= 1
                End While
                'recalcul le cumul
                CumulCde = 0
                cumul = 0
                While Me.gContrat.Rows(i).Cells("numcontrat_Tiers").Value <> "" And i < Me.gContrat.RowCount - 1
                    Me.gContrat.Rows(i).Cells("Cumul").Style.BackColor = Me.gContrat.RowsDefaultCellStyle.BackColor
                    CumulCde += Val(Nz(Me.gContrat.Rows(i).Cells("QteCde").Value, 0))
                    soldeligne = Val(Nz(Me.gContrat.Rows(i).Cells("QteCde").Value, 0)) - Val(Nz(Me.gContrat.Rows(i).Cells("QteBesoin").Value, 0))
                    cumul += soldeligne
                    If soldeligne <> 0 Then Me.gContrat.Rows(i).Cells("Cumul").Style.BackColor = Color.PeachPuff
                    Me.gContrat.Rows(i).Cells("Cumul").Value = cumul
                    Me.gContrat.Rows(i).Cells("SelContrat").Value = True

                    i += 1
                End While
                Me.gContrat.Rows(i).Cells("QteCde").Value = CumulCde

            End If

        End If
    End Sub


    Function TransfertEncours() As Boolean
        Dim sSql As String = ""
        Dim leRs As OleDb.OleDbDataReader
        Dim nbl As Integer = 0
        Dim listeClient As String = "('0'"

        Try
            'regarde d'abord s'il y a des lignes dans MAcro_comc 
            sSql = "select count(*) as NbL from macro_comc where ident ='EDI_JOUR' group by codeclient, nocommande"
            leRs = SqlLit(sSql, conSqlSilog)
            While leRs.Read
                nbl = leRs("Nbl")
            End While
            leRs.Close()

            'S'il y a des lignes dans Macro_Comc, alors on regarde si cela concerne le client sélectionné
            If nbl <> 0 Then
                'cherche les codes ERP du client séléctionné
                sSql = "select codeERP from app.tierssiteERP where tiersid=" & Me.lTiers.SelectedItem.value & " and sitecode='" & leUser.Site & "'"
                leRs = SqlLit(sSql, conSqlEDI)
                While leRs.Read
                    listeClient &= ",'" & leRs("codeERP") & "'"
                End While
                leRs.Close()
                listeClient &= ")"

                nbl = 0
                sSql = "select count(*) as NbL from macro_comc where ident ='EDI_JOUR' and codeclient in " & listeClient & " group by codeclient, nocommande"
                leRs = SqlLit(sSql, conSqlSilog)
                While leRs.Read
                    nbl = leRs("Nbl")
                End While
                leRs.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return (nbl <> 0)
    End Function

    Private Sub retraiter(sender As System.Object, e As System.EventArgs) Handles bRetraiter.Click
        Try
            If TransfertEncours() Then
                MsgBox("Retraitement impossible car des lignes sont en cours de transfert.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Attention")
            Else
                If ExecuteBilan() Then Call AfficheBilan()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Afficher(sender As System.Object, e As System.EventArgs) Handles bAfficher.Click

        AttenteDemarre("Affichage en-cours")
        Call StatutBar("Lecture des contrats")
        Call ListeContrat()
        Call StatutBar("")
        System.Threading.Thread.Sleep(1000)
        AttenteFin()
    End Sub

    Private Sub tHorizonContrat_KeyUp(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then Call ListeContrat()
    End Sub

    Private Sub tHorizonContratFin_KeyUp(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then Call ListeContrat()
    End Sub

    Private Sub GImportContrat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gContrat.CellContentClick
        Dim i As Integer
        Dim b As Boolean

        If e.ColumnIndex < 1 Then
            i = e.RowIndex
            b = Me.gContrat(0, i).Value
            While i > 0 AndAlso Nz(Me.gContrat.Rows(i - 1).Cells("numcontrat_Tiers").Value, "") <> ""
                i -= 1
            End While
            'recalcul le cumul
            While Me.gContrat.Rows(i).Cells("numcontrat_Tiers").Value <> "" And i < Me.gContrat.RowCount - 1
                Me.gContrat.Rows(i).Cells("SelContrat").Value = Not b
                i += 1
            End While
        End If
    End Sub

    Private Sub Archive(sender As Object, e As EventArgs) Handles bArchive.Click
        If Me.lTiers.SelectedIndex < 0 Then Exit Sub
        F_ImportArchive.leTiers = Me.lTiers.SelectedItem.value
        F_ImportArchive.ShowDialog()
        F_ImportArchive.Dispose()

    End Sub

    Private Sub lTiers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lTiers.SelectedIndexChanged

        If Me.lTiers.SelectedIndex >= 0 Then
            If Me.lTiers.Text = "TEST" Then
                lImportId = 1
                Me.tImport.Text = "TEST"
                Me.bImporter.Visible = False
                Me.lTest.Visible = True
                Me.Tableaux.Visible = False

                Call ComboRempli("select distinct numtest from CommandeVente_EDI_DataTest", Me.lTest, conSqlEDI)

            Else
                'récupère le dernier ImportId du Tiers/Utilisateur
                lImportId = ImportDernier()
                Call InitBilan()
                '                If lImportId > 0 Then Call AfficheBilan()
                Me.bImporter.Visible = True
                Me.lTest.Visible = False
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles tArticle.KeyUp, tContrat.KeyUp
        If e.KeyCode = Keys.Enter Then Call ListeContrat()
    End Sub

    Private Sub FiltrerANo(sender As Object, e As EventArgs) Handles bFiltreAno.Click
        Call ListeAnomalieContrat()
    End Sub

    Private Sub ArchiveTransfertContrat()
        Dim lesContrats As String = ""
        Dim sSql As String
        Dim d As Date
        Dim lident As String = "EDI_JOUR"
        Dim StatutLigne As String = ""
        Dim lesEncours As String = ""
        Dim lers As OleDb.OleDbDataReader
        Dim lesEncoursSelect As String = ""

        'Mémorise les lignes 
        sSql = "Select distinct ses_user_erp,R.reserv_record from SILRESERVATIONS R Left Join SILSESSIONS S on S.ses_guid=R.reserv_sessionguid  where reserv_tablename = 'dbo.COMC' or reserv_tablename = 'dbo.COME'"
        lers = SqlLit(sSql, conSqlSilog)
        While lers.Read
            lesEncours &= lers("reserv_record") & "#" & lers("ses_user_erp") & "!"
        End While
        lers.Close()

        For i = 0 To Me.gContrat.RowCount - 2
            If Nz(Me.gContrat.Rows(i).Cells(0).Value, False) = True Then
                If Not lesContrats.Contains(Me.gContrat.Rows(i).Cells("NumContrat_tiers").Value) Then lesContrats += ",'" & Me.gContrat.Rows(i).Cells("NumContrat_tiers").Value & "'"
                'vérifie si la ligne n'est pas en cours
                For Each s In lesEncours.Split("!")
                    If s.Contains(Me.gContrat.Rows(i).Cells("CodeClient").Value & Me.gContrat.Rows(i).Cells("NumCde_ERP").Value & Me.gContrat.Rows(i).Cells("NumLigne_Prop").Value) Then
                        lesEncoursSelect &= Me.gContrat.Rows(i).Cells("CodeClient").Value & "#" & Me.gContrat.Rows(i).Cells("NumCde_ERP").Value & "#" & Me.gContrat.Rows(i).Cells("NumLigne_Prop").Value & "#" & s.Split("#")(1) & "!"
                    End If
                Next
            End If
        Next

        If lesEncoursSelect <> "" Then
            MsgBox("Transfert impossible, des lignes sont vérouillées !", MsgBoxStyle.OkOnly & MsgBoxStyle.Exclamation)
            F_LigneVerouille.lesCde = lesEncoursSelect
            F_LigneVerouille.ShowDialog()
        Else
            If lesContrats = "" Then
                MessageBox.Show("Aucun contrat sélectionné !!")
            Else

                If MsgBox("Transferer" & " les contrats sélectionnés ?", MsgBoxStyle.OkCancel Or MsgBoxStyle.Question) = MsgBoxResult.Ok Then
                    Try
                        For i = 0 To Me.gContrat.RowCount - 2

                            With Me.gContrat.Rows(i)
                                If Nz(.Cells(0).Value, False) = True Then
                                    'Archivage transfert
                                    d = .Cells("DateBesoin").Value
                                    sSql = "Insert into commandeVente_Transfert (lid, ImportId,NumContrat,Article,ArtDesc,TypeBesoin,DateBesoin,QteBesoin,TypeCde_ERP,NumCde_ERP,NumLigne_ERP,QteCde,ArtCode_ERP,NumLigne_Prop,DateTransfert,StatutTransfert,codeclient,statutAffiche)" _
                                    & " values (" _
                                    & "'" & .Cells("lid").Value & "'," _
                                    & lImportId & ",'" & Nz(.Cells("NumContrat_tiers").Value, "") & "','" & Nz(.Cells("ArtCode_Tiers").Value, "") & "','" & Nz(.Cells("ArtDesc_Tiers").Value, "").Replace("'", "''") & "','" _
                                    & Nz(.Cells("TypeBesoin").Value, "") & "','" & d & "','" & Txt2sql(Nz(.Cells("QteBesoin").Value, "0")) & "','" & Nz(.Cells("Typecde_ERP").Value, "") & "','" _
                                    & Nz(.Cells("NumCde_ERP").Value, "") & "','" & Nz(.Cells("NumLigneCde_ERP").Value, "") & "','" & Txt2sql(Nz(.Cells("QteCde").Value, "0")) & "','" _
                                    & Nz(.Cells("ArtCode_ERP").Value, "") & "','" & Nz(.Cells("NumLigne_Prop").Value, "") & "','" & Now & "','D','" & .Cells("CodeClient").Value & "',1)"
                                    SqlDo(sSql, conSqlEDI)
                                End If
                            End With
                        Next i

                        Dim lesParam As New List(Of SSISParam)
                        lesParam.Clear()
                        lesParam.Add(New SSISParam("ImportId", lImportId, "PACKAGE"))
                        lesParam.Add(New SSISParam("BaseSilog", leUser.Base, "PROJET"))
                        lesParam.Add(New SSISParam("ServSilog", leUser.ServeurERP, "PROJET"))
                        lesParam.Add(New SSISParam("UserLogin", leUser.Login, "PACKAGE"))
                        SSISexecute(leUser.RepSSIS, "DM_IN_CDV_Integre.dtsx", lesParam, "Ecriture des données -> ERP")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    Call AfficheBilan()
                End If
            End If
        End If
    End Sub

    Private Sub ArchiveTransfertCde(AvecTransFertSILOG As Boolean)
        Dim NbCde As Integer = 0
        Dim sSql As String
        Dim dEDI As Date, dERP As Date
        Dim lident As String = "EDI_JOUR"
        Dim StatutLigne As String = ""

        For i = 0 To Me.gCommande.RowCount - 2
            If Nz(Me.gCommande.Rows(i).Cells(0).Value, False) = True Then NbCde += 1
        Next

        If NbCde = 0 Then
            MessageBox.Show("Aucune commande sélectionnée !!")
        Else

            If MsgBox(IIf(AvecTransFertSILOG, "Transferer", "Archiver") & " les commandes sélectionnés ?", MsgBoxStyle.OkCancel Or MsgBoxStyle.Question) = MsgBoxResult.Ok Then
                Try
                    For i = 0 To Me.gCommande.RowCount - 1

                        With Me.gCommande.Rows(i)
                            If Nz(.Cells(0).Value, False) = True Then
                                'Archivage transfert
                                If Nz(.Cells("Date_EDI").Value, "") <> "" Then dEDI = Nz(.Cells("Date_EDI").Value, Nothing) Else dEDI = Nothing
                                If Nz(.Cells("Date_CDE").Value, "") <> "" Then dERP = Nz(.Cells("Date_CDE").Value, Nothing) Else dERP = Nothing
                                sSql = "Insert into commandeVente_Transfert (ImportId,NumCdeEDI,Article,TypeBesoin,DateBesoin,QteBesoin,TypeCde_ERP,CodeClient,NumCde_ERP,NumLigne_ERP,ArtCode_ERP" _
                                    & " ,QteCde,DateCde,NumCdeEDI_ERP,DateTransfert,StatutTransfert)" _
                                    & " values (" _
                                    & lImportId & ",'" & Nz(.Cells("NumCdeEDI").Value, "") & "','" & Nz(.Cells("ArtCode_EDI").Value, "") & "','" _
                                    & Nz(.Cells("Type_EDI").Value, "") & "','" & dEDI & "','" & Txt2sql(Nz(.Cells("Qte_EDI").Value, "0")) & "','" & Nz(.Cells("Type_CDE").Value, "") & "','" _
                                    & Nz(.Cells("CodeClient_CDE").Value, "") & "','" & Nz(.Cells("NumCde_CDE").Value, "") & "','" & Nz(.Cells("NumLigne_CDE").Value, "") _
                                    & "','" & Nz(.Cells("ArtCode_CDE").Value, "") & "','" & Txt2sql(Nz(.Cells("Qte_Cde").Value, "0")) & "','" & dERP & "','" & Nz(.Cells("NumCdeEDI_Cde").Value, "") _
                                    & "','" & Now & "','D')"
                                SqlDo(sSql, conSqlEDI)
                            End If
                        End With
                    Next i

                    'Dim lesParam As New List(Of SSISParam)
                    'lesParam.Clear()
                    'lesParam.Add(New SSISParam("ImportId", lImportId))
                    'lesParam.Add(New SSISParam("BaseSilog", leUser.Base))
                    'lesParam.Add(New SSISParam("ServSilog", leUser.ServeurERP))
                    'lesParam.Add(New SSISParam("UserLogin", leUser.Login))
                    'SSISexecute(leUser.RepSSIS, "DM_IN_CDV_Integre.dtsx", lesParam, "Ecriture des données -> ERP")


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                'Call AfficheBilan()
            End If
        End If
    End Sub

    Private Sub gContrat_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gContrat.CellContentDoubleClick
        Call GImportContrat_CellContentClick(sender, e)
    End Sub

    Private Sub TColCache_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles tColCache.LinkClicked
        Me.gContrat.Columns("LigDispo").Visible = (tColCache.Text = "[+]")
        Me.gContrat.Columns("LigPrec").Visible = (tColCache.Text = "[+]")
        Me.gContrat.Columns("LigPrecDispo").Visible = (tColCache.Text = "[+]")
        Me.gContrat.Columns("LigSuiv").Visible = (tColCache.Text = "[+]")
        Me.gContrat.Columns("LigSuivDispo").Visible = (tColCache.Text = "[+]")
        Me.gContrat.Columns("qteLivre").Visible = (tColCache.Text = "[+]")
        tColCache.Text = IIf(tColCache.Text = "[+]", "[-]", "[+]")
    End Sub

    Private Sub BTransfert_Click(sender As Object, e As EventArgs) Handles bTransfert.Click
        Call ArchiveTransfertContrat()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        F_Doc.leTiersid = Me.lTiers.SelectedItem.value
        F_Doc.ShowDialog()
    End Sub

    Private Sub OptionToutAno_CheckedChanged(sender As Object, e As EventArgs) Handles optionToutAnoContrat.CheckedChanged
        Call OptionAnoContratInit(Me.optionToutAnoContrat.Checked)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        F_ImportEncours.ShowDialog()
    End Sub

    Private Sub OptionToutAnoCde_CheckedChanged(sender As Object, e As EventArgs) Handles optionToutAnoCde.CheckedChanged
        Call OptionAnoCdeInit(Me.optionToutAnoCde.Checked)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call ListeAnomalieCde()
    End Sub

    Private Sub OptionToutContrat_CheckedChanged(sender As Object, e As EventArgs) Handles optionToutContrat.CheckedChanged
        Call OptionContratInit(Me.optionToutContrat.Checked)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Try
            If ExecuteBilan() Then Call AfficheBilan()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If Not TransfertEncours() Then
                Dim lesParam As New List(Of SSISParam)
                lesParam.Clear()
                lesParam.Add(New SSISParam("ImportId", lImportId, "PACKAGE"))
                lesParam.Add(New SSISParam("BaseSilog", leUser.Base, "PROJET"))
                lesParam.Add(New SSISParam("ServSilog", leUser.ServeurERP, "PROJET"))
                lesParam.Add(New SSISParam("UserLogin", leUser.Login, "PACKAGE"))
                SSISexecute(leUser.RepSSIS, "DM_IN_CDV_IntegreControl.dtsx", lesParam, "Contrôle Intégration")

                F_Main.Focus()
                F_ImportControlIntegration.limport = lImportId
                F_ImportControlIntegration.ShowDialog()
            Else
                MsgBox("Transfert en cours, Contrôle impossible !")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Call ArchiveTransfertCde(True)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call ListeCommande()
    End Sub

    Private Sub tArtCde_KeyUp(sender As Object, e As KeyEventArgs) Handles tArtCde.KeyUp
        If e.KeyCode = Keys.Enter Then Call ListeCommande()
    End Sub

    Private Sub tCdeEDI_KeyUp(sender As Object, e As KeyEventArgs) Handles tCdeEDI.KeyUp
        If e.KeyCode = Keys.Enter Then Call ListeCommande()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        DocOuvre(Me.tFichierSource.Text)
    End Sub

    Private Sub CSel_CheckedChanged(sender As Object, e As EventArgs) Handles cSel.CheckedChanged
        For i = 0 To Me.gContrat.RowCount - 1
            If Nz(Me.gContrat.Rows(i).Cells("NumContrat_tiers").Value, "") <> "" Then
                Me.gContrat.Rows(i).Cells(0).Value = Me.cSel.Checked
            End If
        Next
    End Sub

    Private Sub tFichierSource_Click(sender As Object, e As EventArgs) Handles tFichierSource.Click

    End Sub


End Class