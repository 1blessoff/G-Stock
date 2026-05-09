Imports MySql.Data.MySqlClient

Public Class FrmGestionStock
    ' Connexion à la base de données
    Dim connString As String = "server=localhost;userid=root;password=;database=gestion_stock"
    Dim conn As New MySqlConnection(connString)

    ' --- CHARGEMENT DU FORMULAIRE ---
    Private Sub FrmGestionStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbCategorie.Items.Clear()
        cmbCategorie.Items.AddRange({"Électronique", "Alimentaire", "Vêtements", "Divers"})

        ' Configuration de l'interface
        txtIdProduit.ReadOnly = True
        txtIdProduit.BackColor = Color.LightGray
        dgvProduits.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvVentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ' Masquer le GroupBox client au démarrage
        gbClient.Visible = False

        ActualiserTout()
    End Sub

    ' --- SÉCURITÉS CLAVIER (BLOQUER LES LETTRES) ---
    Private Sub txtPrix_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrix.KeyPress
        ' Autorise les chiffres, les touches de contrôle et la virgule
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> ","c) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtQuantite_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantite.KeyPress
        ' Autorise uniquement les chiffres et touches de contrôle
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' --- MÉTHODES DE CHARGEMENT ---
    Private Sub ActualiserTout()
        ActualiserGrilleStock()
        ActualiserGrilleVentes()
        PreparerNouvelID()
    End Sub

    Private Sub PreparerNouvelID()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM produits", conn)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            conn.Close()
            txtIdProduit.Text = "PRD-" & (count + 1).ToString()
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub ActualiserGrilleStock()
        Try
            Dim adp As New MySqlDataAdapter("SELECT id_produit, libelle, categorie, prix, quantite FROM produits", conn)
            Dim dt As New DataTable()
            adp.Fill(dt)
            dgvProduits.DataSource = dt
        Catch ex As Exception
            MsgBox("Erreur d'affichage du stock : " & ex.Message)
        End Try
    End Sub

    Private Sub ActualiserGrilleVentes()
        Try
            Dim query As String = "SELECT id_vente, nom_produit_vendu AS Produit, quantite_vendue, prix_vente, client_nom AS Client, date_vente FROM ventes ORDER BY id_vente DESC"
            Dim adp As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adp.Fill(dt)
            dgvVentes.DataSource = dt
            ' Activer le bouton vider seulement s'il y a des ventes
            btnVider.Enabled = (dt.Rows.Count > 0)
        Catch ex As Exception
            MsgBox("Erreur d'affichage de l'historique : " & ex.Message)
        End Try
    End Sub

    ' --- ACTIONS PRODUITS (AJOUTER / MODIFIER / SUPPRIMER) ---

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        ' Vérification : Champs vides ?
        If txtLibelle.Text.Trim() = "" Or cmbCategorie.Text = "" Or txtPrix.Text = "" Or txtQuantite.Text = "" Then
            MsgBox("Veuillez remplir tous les champs avant l'ajout.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Dim p As Decimal = Decimal.Parse(txtPrix.Text)
            Dim q As Integer = Integer.Parse(txtQuantite.Text)

            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO produits (id_produit, libelle, categorie, prix, quantite, date_ajout) VALUES (@id, @lib, @cat, @p, @q, NOW())", conn)
            cmd.Parameters.AddWithValue("@id", txtIdProduit.Text)
            cmd.Parameters.AddWithValue("@lib", txtLibelle.Text.Trim())
            cmd.Parameters.AddWithValue("@cat", cmbCategorie.Text)
            cmd.Parameters.AddWithValue("@p", p)
            cmd.Parameters.AddWithValue("@q", q)
            cmd.ExecuteNonQuery()
            conn.Close()

            MsgBox("Produit ajouté avec succès !")
            ViderChampsEtNouveauID()
            ActualiserTout()
        Catch ex As Exception
            MsgBox("Erreur lors de l'ajout : " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        ' Vérification : Sélection faite ?
        If txtIdProduit.Text = "" Or txtLibelle.Text.Trim() = "" Then
            MsgBox("Veuillez sélectionner un produit à modifier dans le tableau.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Dim p As Decimal = Decimal.Parse(txtPrix.Text)
            Dim q As Integer = Integer.Parse(txtQuantite.Text)

            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE produits SET libelle=@lib, categorie=@cat, prix=@p, quantite=@q WHERE id_produit=@id", conn)
            cmd.Parameters.AddWithValue("@id", txtIdProduit.Text)
            cmd.Parameters.AddWithValue("@lib", txtLibelle.Text.Trim())
            cmd.Parameters.AddWithValue("@cat", cmbCategorie.Text)
            cmd.Parameters.AddWithValue("@p", p)
            cmd.Parameters.AddWithValue("@q", q)
            cmd.ExecuteNonQuery()
            conn.Close()

            MsgBox("Produit mis à jour !")
            ViderChampsEtNouveauID()
            ActualiserTout()
        Catch ex As Exception
            MsgBox("Erreur de modification : " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        ' Vérification : Sélection faite ?
        If txtIdProduit.Text = "" Or txtLibelle.Text.Trim() = "" Then
            MsgBox("Veuillez sélectionner un produit à supprimer.", MsgBoxStyle.Exclamation)
            Return
        End If

        If MsgBox("Voulez-vous vraiment supprimer " & txtLibelle.Text & " ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM produits WHERE id_produit=@id", conn)
                cmd.Parameters.AddWithValue("@id", txtIdProduit.Text)
                cmd.ExecuteNonQuery()
                conn.Close()

                MsgBox("Produit supprimé.")
                ViderChampsEtNouveauID()
                ActualiserTout()
            Catch ex As Exception
                MsgBox("Erreur de suppression : " & ex.Message)
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End If
    End Sub

    ' --- SECTION VENTES ET CLIENTS ---

    Private Sub btnVente_Click(sender As Object, e As EventArgs) Handles btnVente.Click
        ' Vérification : Sélection faite ?
        If txtIdProduit.Text = "" Then
            MsgBox("Sélectionnez un produit pour vendre.", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Vérification : Quantité saisie ?
        If txtQuantite.Text = "" OrElse Val(txtQuantite.Text) <= 0 Then
            MsgBox("Indiquez une quantité à vendre.", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Affichage du GroupBox Client
        gbClient.Visible = True
        txtNomClient.Focus()
    End Sub

    Private Sub btnValiderVente_Click(sender As Object, e As EventArgs) Handles btnValiderVente.Click
        ' Vérification : Nom client saisi ?
        If txtNomClient.Text.Trim() = "" Then
            MsgBox("Le nom du client est obligatoire.", MsgBoxStyle.Critical)
            Return
        End If

        Try
            conn.Open()
            ' 1. Vérifier le stock réel
            Dim cmdStock As New MySqlCommand("SELECT quantite, prix FROM produits WHERE id_produit=@id", conn)
            cmdStock.Parameters.AddWithValue("@id", txtIdProduit.Text)
            Dim reader = cmdStock.ExecuteReader()

            If reader.Read() Then
                Dim stockDispo As Integer = reader.GetInt32(0)
                Dim prixUnitaire As Decimal = reader.GetDecimal(1)
                Dim qteVoulue As Integer = Val(txtQuantite.Text)
                reader.Close()

                ' ALERTE STOCK
                If qteVoulue > stockDispo Then
                    MsgBox("Stock insuffisant ! Il ne reste que " & stockDispo & " article(s).", MsgBoxStyle.Critical)
                    conn.Close()
                    Return
                End If

                ' 2. Enregistrer le client
                Dim cmdC As New MySqlCommand("INSERT INTO clients (nom, prenom, date_enregistrement) VALUES (@n, @p, NOW()) ON DUPLICATE KEY UPDATE nom=nom", conn)
                cmdC.Parameters.AddWithValue("@n", txtNomClient.Text.Trim())
                cmdC.Parameters.AddWithValue("@p", txtPrenomClient.Text.Trim())
                cmdC.ExecuteNonQuery()

                ' 3. Enregistrer la Vente
                Dim total As Decimal = qteVoulue * prixUnitaire
                Dim clientNom As String = (txtPrenomClient.Text & " " & txtNomClient.Text).Trim()

                Dim sqlV As String = "INSERT INTO ventes (id_produit, nom_produit_vendu, quantite_vendue, prix_vente, client_nom, date_vente) VALUES (@id, @lib, @qte, @tot, @cli, NOW())"
                Dim cmdV As New MySqlCommand(sqlV, conn)
                cmdV.Parameters.AddWithValue("@id", txtIdProduit.Text)
                cmdV.Parameters.AddWithValue("@lib", txtLibelle.Text)
                cmdV.Parameters.AddWithValue("@qte", qteVoulue)
                cmdV.Parameters.AddWithValue("@tot", total)
                cmdV.Parameters.AddWithValue("@cli", clientNom)
                cmdV.ExecuteNonQuery()

                ' 4. Déduire du stock
                Dim cmdUp As New MySqlCommand("UPDATE produits SET quantite = quantite - @qte WHERE id_produit=@id", conn)
                cmdUp.Parameters.AddWithValue("@qte", qteVoulue)
                cmdUp.Parameters.AddWithValue("@id", txtIdProduit.Text)
                cmdUp.ExecuteNonQuery()

                MsgBox("Vente validée : " & total & " FCFA")
                gbClient.Visible = False
                ViderChampsEtNouveauID()
                ActualiserTout()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Erreur vente : " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' --- BOUTON VIDER HISTORIQUE ---
    Private Sub btnVider_Click(sender As Object, e As EventArgs) Handles btnVider.Click
        If MsgBox("Voulez-vous vider tout l'historique des ventes ?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical) = MsgBoxResult.Yes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("TRUNCATE TABLE ventes", conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                ActualiserGrilleVentes()
            Catch ex As Exception
                MsgBox("Erreur : " & ex.Message)
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End If
    End Sub

    ' --- UTILITAIRES ---
    Private Sub ViderChampsEtNouveauID()
        txtLibelle.Clear() : txtPrix.Clear() : txtQuantite.Clear()
        txtNomClient.Clear() : txtPrenomClient.Clear()
        cmbCategorie.SelectedIndex = -1
        PreparerNouvelID()
    End Sub

    Private Sub dgvProduits_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduits.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvProduits.Rows(e.RowIndex)
            txtIdProduit.Text = row.Cells(0).Value.ToString()
            txtLibelle.Text = row.Cells(1).Value.ToString()
            cmbCategorie.Text = row.Cells(2).Value.ToString()
            txtPrix.Text = row.Cells(3).Value.ToString()
            txtQuantite.Text = "1"
        End If
    End Sub

    Private Sub btnAnnulerClient_Click(sender As Object, e As EventArgs) Handles btnAnnulerClient.Click
        gbClient.Visible = False
    End Sub

    Private Sub btnDeconnexion_Click(sender As Object, e As EventArgs) Handles btnDeconnexion.Click
        Application.Exit()
    End Sub

    Private Sub txtRecherche_TextChanged(sender As Object, e As EventArgs) Handles txtRecherche.TextChanged
        
    End Sub

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        If txtRecherche.Text.Trim() = "" Then
            ActualiserGrilleStock() ' Si le champ est vide, on réaffiche tout
            Return
        End If

        Try
            conn.Open()
            Dim query As String = "SELECT id_produit, libelle, categorie, prix, quantite FROM produits " & _
                                 "WHERE libelle LIKE @search OR id_produit LIKE @search"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@search", "%" & txtRecherche.Text & "%")

            Dim adp As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adp.Fill(dt)
            dgvProduits.DataSource = dt
            conn.Close()

            If dt.Rows.Count = 0 Then
                MsgBox("Aucun produit trouvé pour cette recherche.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Erreur recherche : " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnVoirClients_Click(sender As Object, e As EventArgs) Handles btnVoirClients.Click
        Try
            ' 1. Récupération des données clients
            Dim dt As New DataTable()
            Dim adp As New MySqlDataAdapter("SELECT nom, prenom FROM clients ORDER BY nom ASC", conn)
            adp.Fill(dt)

            ' 2. Vérifier s'il y a des clients
            If dt.Rows.Count = 0 Then
                MsgBox("Aucun client enregistré pour le moment.", MsgBoxStyle.Information, "Liste Vide")
                Return
            End If

            ' 3. Construire la liste sous forme de texte
            Dim liste As String = "LISTE DES CLIENTS ENREGISTRÉS :" & vbCrLf

            For Each row As DataRow In dt.Rows
                ' On ajoute chaque client ligne par ligne
                liste &= "-" & row("nom").ToString().ToUpper() & " " & row("prenom").ToString() & vbCrLf
            Next

            liste &= vbCrLf & "Nombres de Clients : " & dt.Rows.Count & " client(s)."

            ' 4. Affichage dans le Popup
            MsgBox(liste, MsgBoxStyle.Information, "Liste des Clients")

        Catch ex As Exception
            MsgBox("Erreur lors de l'affichage : " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
End Class