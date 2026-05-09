<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestionStock
    Inherits System.Windows.Forms.Form

    'Nettoyage des composants
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestionStock))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnVoirClients = New System.Windows.Forms.Button()
        Me.btnVider = New System.Windows.Forms.Button()
        Me.btnVente = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.cmbCategorie = New System.Windows.Forms.ComboBox()
        Me.txtQuantite = New System.Windows.Forms.TextBox()
        Me.txtLibelle = New System.Windows.Forms.TextBox()
        Me.txtPrix = New System.Windows.Forms.TextBox()
        Me.txtIdProduit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDeconnexion = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.txtRecherche = New System.Windows.Forms.TextBox()
        Me.dgvVentes = New System.Windows.Forms.DataGridView()
        Me.dgvProduits = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gbClient = New System.Windows.Forms.GroupBox()
        Me.btnAnnulerClient = New System.Windows.Forms.Button()
        Me.btnValiderVente = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrenomClient = New System.Windows.Forms.TextBox()
        Me.txtNomClient = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvVentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProduits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbClient.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnVoirClients)
        Me.GroupBox1.Controls.Add(Me.btnVider)
        Me.GroupBox1.Controls.Add(Me.btnVente)
        Me.GroupBox1.Controls.Add(Me.btnSupprimer)
        Me.GroupBox1.Controls.Add(Me.btnModifier)
        Me.GroupBox1.Controls.Add(Me.btnAjouter)
        Me.GroupBox1.Controls.Add(Me.cmbCategorie)
        Me.GroupBox1.Controls.Add(Me.txtQuantite)
        Me.GroupBox1.Controls.Add(Me.txtLibelle)
        Me.GroupBox1.Controls.Add(Me.txtPrix)
        Me.GroupBox1.Controls.Add(Me.txtIdProduit)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(920, 160)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Détails des Produits"
        '
        'btnVoirClients
        '
        Me.btnVoirClients.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnVoirClients.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.28!)
        Me.btnVoirClients.ForeColor = System.Drawing.Color.White
        Me.btnVoirClients.Location = New System.Drawing.Point(756, 113)
        Me.btnVoirClients.Name = "btnVoirClients"
        Me.btnVoirClients.Size = New System.Drawing.Size(100, 40)
        Me.btnVoirClients.TabIndex = 17
        Me.btnVoirClients.Text = "Voir Client"
        Me.btnVoirClients.UseVisualStyleBackColor = False
        '
        'btnVider
        '
        Me.btnVider.BackColor = System.Drawing.Color.DarkOrange
        Me.btnVider.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVider.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.28!)
        Me.btnVider.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVider.Location = New System.Drawing.Point(650, 110)
        Me.btnVider.Name = "btnVider"
        Me.btnVider.Size = New System.Drawing.Size(100, 44)
        Me.btnVider.TabIndex = 16
        Me.btnVider.Text = "Vider L'historique"
        Me.btnVider.UseVisualStyleBackColor = False
        '
        'btnVente
        '
        Me.btnVente.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnVente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btnVente.ForeColor = System.Drawing.Color.White
        Me.btnVente.Location = New System.Drawing.Point(650, 59)
        Me.btnVente.Name = "btnVente"
        Me.btnVente.Size = New System.Drawing.Size(100, 40)
        Me.btnVente.TabIndex = 0
        Me.btnVente.Text = "Vendre"
        Me.btnVente.UseVisualStyleBackColor = False
        '
        'btnSupprimer
        '
        Me.btnSupprimer.BackColor = System.Drawing.Color.Crimson
        Me.btnSupprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btnSupprimer.ForeColor = System.Drawing.Color.White
        Me.btnSupprimer.Location = New System.Drawing.Point(756, 59)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(100, 40)
        Me.btnSupprimer.TabIndex = 1
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = False
        '
        'btnModifier
        '
        Me.btnModifier.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btnModifier.ForeColor = System.Drawing.Color.White
        Me.btnModifier.Location = New System.Drawing.Point(756, 13)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(100, 40)
        Me.btnModifier.TabIndex = 2
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = False
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.Location = New System.Drawing.Point(650, 13)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(100, 40)
        Me.btnAjouter.TabIndex = 3
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'cmbCategorie
        '
        Me.cmbCategorie.Location = New System.Drawing.Point(100, 67)
        Me.cmbCategorie.Name = "cmbCategorie"
        Me.cmbCategorie.Size = New System.Drawing.Size(150, 21)
        Me.cmbCategorie.TabIndex = 6
        '
        'txtQuantite
        '
        Me.txtQuantite.Location = New System.Drawing.Point(380, 67)
        Me.txtQuantite.Name = "txtQuantite"
        Me.txtQuantite.Size = New System.Drawing.Size(200, 20)
        Me.txtQuantite.TabIndex = 7
        '
        'txtLibelle
        '
        Me.txtLibelle.Location = New System.Drawing.Point(380, 27)
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.Size = New System.Drawing.Size(200, 20)
        Me.txtLibelle.TabIndex = 8
        '
        'txtPrix
        '
        Me.txtPrix.Location = New System.Drawing.Point(100, 107)
        Me.txtPrix.Name = "txtPrix"
        Me.txtPrix.Size = New System.Drawing.Size(150, 20)
        Me.txtPrix.TabIndex = 9
        '
        'txtIdProduit
        '
        Me.txtIdProduit.Location = New System.Drawing.Point(100, 27)
        Me.txtIdProduit.Name = "txtIdProduit"
        Me.txtIdProduit.Size = New System.Drawing.Size(150, 20)
        Me.txtIdProduit.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(300, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Quantité"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(300, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Libellé"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Prix"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Catégorie"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "ID Produit"
        '
        'btnDeconnexion
        '
        Me.btnDeconnexion.BackColor = System.Drawing.Color.DarkRed
        Me.btnDeconnexion.ForeColor = System.Drawing.Color.White
        Me.btnDeconnexion.Location = New System.Drawing.Point(838, 5)
        Me.btnDeconnexion.Name = "btnDeconnexion"
        Me.btnDeconnexion.Size = New System.Drawing.Size(100, 30)
        Me.btnDeconnexion.TabIndex = 5
        Me.btnDeconnexion.Text = "Déconnexion"
        Me.btnDeconnexion.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRechercher)
        Me.GroupBox2.Controls.Add(Me.txtRecherche)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 210)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(920, 60)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recherche des Produits"
        '
        'btnRechercher
        '
        Me.btnRechercher.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRechercher.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRechercher.Location = New System.Drawing.Point(519, 18)
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(140, 30)
        Me.btnRechercher.TabIndex = 0
        Me.btnRechercher.Text = "Rechercher"
        Me.btnRechercher.UseVisualStyleBackColor = False
        '
        'txtRecherche
        '
        Me.txtRecherche.Location = New System.Drawing.Point(87, 19)
        Me.txtRecherche.Multiline = True
        Me.txtRecherche.Name = "txtRecherche"
        Me.txtRecherche.Size = New System.Drawing.Size(412, 29)
        Me.txtRecherche.TabIndex = 1
        '
        'dgvVentes
        '
        Me.dgvVentes.BackgroundColor = System.Drawing.Color.SeaShell
        Me.dgvVentes.Location = New System.Drawing.Point(54, 490)
        Me.dgvVentes.Name = "dgvVentes"
        Me.dgvVentes.Size = New System.Drawing.Size(544, 178)
        Me.dgvVentes.TabIndex = 3
        '
        'dgvProduits
        '
        Me.dgvProduits.BackgroundColor = System.Drawing.Color.SeaShell
        Me.dgvProduits.Location = New System.Drawing.Point(54, 295)
        Me.dgvProduits.Name = "dgvProduits"
        Me.dgvProduits.Size = New System.Drawing.Size(544, 172)
        Me.dgvProduits.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(30, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Stock Actuel :"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(18, 470)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Historique des Ventes :"
        '
        'gbClient
        '
        Me.gbClient.BackColor = System.Drawing.Color.SeaShell
        Me.gbClient.Controls.Add(Me.btnAnnulerClient)
        Me.gbClient.Controls.Add(Me.btnValiderVente)
        Me.gbClient.Controls.Add(Me.Label10)
        Me.gbClient.Controls.Add(Me.Label1)
        Me.gbClient.Controls.Add(Me.txtPrenomClient)
        Me.gbClient.Controls.Add(Me.txtNomClient)
        Me.gbClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.gbClient.ForeColor = System.Drawing.Color.Maroon
        Me.gbClient.Location = New System.Drawing.Point(614, 295)
        Me.gbClient.Name = "gbClient"
        Me.gbClient.Size = New System.Drawing.Size(334, 222)
        Me.gbClient.TabIndex = 6
        Me.gbClient.TabStop = False
        Me.gbClient.Text = "Enregistrement Client"
        '
        'btnAnnulerClient
        '
        Me.btnAnnulerClient.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAnnulerClient.ForeColor = System.Drawing.Color.White
        Me.btnAnnulerClient.Location = New System.Drawing.Point(32, 169)
        Me.btnAnnulerClient.Name = "btnAnnulerClient"
        Me.btnAnnulerClient.Size = New System.Drawing.Size(117, 32)
        Me.btnAnnulerClient.TabIndex = 6
        Me.btnAnnulerClient.Text = "Annuler vente"
        Me.btnAnnulerClient.UseVisualStyleBackColor = False
        '
        'btnValiderVente
        '
        Me.btnValiderVente.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnValiderVente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnValiderVente.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnValiderVente.Location = New System.Drawing.Point(160, 169)
        Me.btnValiderVente.Name = "btnValiderVente"
        Me.btnValiderVente.Size = New System.Drawing.Size(119, 32)
        Me.btnValiderVente.TabIndex = 5
        Me.btnValiderVente.Text = "Valider la Vente"
        Me.btnValiderVente.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(46, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 17)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Prenom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(66, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nom"
        '
        'txtPrenomClient
        '
        Me.txtPrenomClient.Location = New System.Drawing.Point(109, 107)
        Me.txtPrenomClient.Multiline = True
        Me.txtPrenomClient.Name = "txtPrenomClient"
        Me.txtPrenomClient.Size = New System.Drawing.Size(139, 26)
        Me.txtPrenomClient.TabIndex = 1
        '
        'txtNomClient
        '
        Me.txtNomClient.Location = New System.Drawing.Point(109, 53)
        Me.txtNomClient.Multiline = True
        Me.txtNomClient.Name = "txtNomClient"
        Me.txtNomClient.Size = New System.Drawing.Size(139, 28)
        Me.txtNomClient.TabIndex = 0
        '
        'FrmGestionStock
        '
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(960, 680)
        Me.Controls.Add(Me.gbClient)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvProduits)
        Me.Controls.Add(Me.dgvVentes)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnDeconnexion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmGestionStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Logiciel de Gestion de Stock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvVentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProduits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbClient.ResumeLayout(False)
        Me.gbClient.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    '--- Déclarations obligatoires ---
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnVente As System.Windows.Forms.Button
    Friend WithEvents btnSupprimer As System.Windows.Forms.Button
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents cmbCategorie As System.Windows.Forms.ComboBox
    Friend WithEvents txtQuantite As System.Windows.Forms.TextBox
    Friend WithEvents txtLibelle As System.Windows.Forms.TextBox
    Friend WithEvents txtPrix As System.Windows.Forms.TextBox
    Friend WithEvents txtIdProduit As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDeconnexion As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRechercher As System.Windows.Forms.Button
    Friend WithEvents txtRecherche As System.Windows.Forms.TextBox
    Friend WithEvents dgvVentes As System.Windows.Forms.DataGridView
    Friend WithEvents dgvProduits As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnVider As System.Windows.Forms.Button
    Friend WithEvents gbClient As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPrenomClient As System.Windows.Forms.TextBox
    Friend WithEvents txtNomClient As System.Windows.Forms.TextBox
    Friend WithEvents btnValiderVente As System.Windows.Forms.Button
    Friend WithEvents btnAnnulerClient As System.Windows.Forms.Button
    Friend WithEvents btnVoirClients As System.Windows.Forms.Button
End Class