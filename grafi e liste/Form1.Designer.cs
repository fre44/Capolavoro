namespace grafi_e_liste
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.crudliste = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.posizionelim = new System.Windows.Forms.RadioButton();
            this.elimina = new System.Windows.Forms.Button();
            this.valorelim = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.valoredaeliminare = new System.Windows.Forms.TextBox();
            this.boxlista = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.posizionemod = new System.Windows.Forms.RadioButton();
            this.valoremod = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.modifica = new System.Windows.Forms.Button();
            this.txtmodval = new System.Windows.Forms.TextBox();
            this.modificaval = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.carica = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.testagg = new System.Windows.Forms.RadioButton();
            this.codagg = new System.Windows.Forms.RadioButton();
            this.ordinatoagg = new System.Windows.Forms.RadioButton();
            this.posizioneagg = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.valoreagg = new System.Windows.Forms.TextBox();
            this.disegno = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Crud = new System.Windows.Forms.TabControl();
            this.CRUDgrafi = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.modificag = new System.Windows.Forms.Button();
            this.nodopm = new System.Windows.Forms.TextBox();
            this.nodocm = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.caricag = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.bidir = new System.Windows.Forms.CheckBox();
            this.nodop = new System.Windows.Forms.TextBox();
            this.nodoc = new System.Windows.Forms.TextBox();
            this.DFS = new System.Windows.Forms.Button();
            this.listgrafo = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.nodope = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.eleiminag = new System.Windows.Forms.Button();
            this.nodoce = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.BFS = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.crudliste.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Crud.SuspendLayout();
            this.CRUDgrafi.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // crudliste
            // 
            this.crudliste.Controls.Add(this.panel3);
            this.crudliste.Controls.Add(this.boxlista);
            this.crudliste.Controls.Add(this.panel2);
            this.crudliste.Controls.Add(this.panel1);
            this.crudliste.Controls.Add(this.disegno);
            this.crudliste.Controls.Add(this.label1);
            this.crudliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crudliste.Location = new System.Drawing.Point(4, 22);
            this.crudliste.Name = "crudliste";
            this.crudliste.Padding = new System.Windows.Forms.Padding(3);
            this.crudliste.Size = new System.Drawing.Size(716, 478);
            this.crudliste.TabIndex = 0;
            this.crudliste.Text = "CRUD liste";
            this.crudliste.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.posizionelim);
            this.panel3.Controls.Add(this.elimina);
            this.panel3.Controls.Add(this.valorelim);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.valoredaeliminare);
            this.panel3.Location = new System.Drawing.Point(26, 185);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 141);
            this.panel3.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Elimina un elemento:";
            // 
            // posizionelim
            // 
            this.posizionelim.AutoSize = true;
            this.posizionelim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posizionelim.Location = new System.Drawing.Point(15, 38);
            this.posizionelim.Name = "posizionelim";
            this.posizionelim.Size = new System.Drawing.Size(79, 19);
            this.posizionelim.TabIndex = 22;
            this.posizionelim.TabStop = true;
            this.posizionelim.Text = "Posizione";
            this.posizionelim.UseVisualStyleBackColor = true;
            // 
            // elimina
            // 
            this.elimina.BackColor = System.Drawing.Color.Orange;
            this.elimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elimina.Location = new System.Drawing.Point(190, 86);
            this.elimina.Name = "elimina";
            this.elimina.Size = new System.Drawing.Size(103, 25);
            this.elimina.TabIndex = 31;
            this.elimina.Text = "Elimina";
            this.elimina.UseVisualStyleBackColor = false;
            this.elimina.Click += new System.EventHandler(this.elimina_Click_1);
            // 
            // valorelim
            // 
            this.valorelim.AutoSize = true;
            this.valorelim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorelim.Location = new System.Drawing.Point(15, 59);
            this.valorelim.Name = "valorelim";
            this.valorelim.Size = new System.Drawing.Size(60, 19);
            this.valorelim.TabIndex = 23;
            this.valorelim.TabStop = true;
            this.valorelim.Text = "Valore";
            this.valorelim.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(92, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "(selezionare un l\'elemento nella lista)";
            // 
            // valoredaeliminare
            // 
            this.valoredaeliminare.Location = new System.Drawing.Point(75, 58);
            this.valoredaeliminare.Name = "valoredaeliminare";
            this.valoredaeliminare.Size = new System.Drawing.Size(96, 22);
            this.valoredaeliminare.TabIndex = 24;
            // 
            // boxlista
            // 
            this.boxlista.FormattingEnabled = true;
            this.boxlista.ItemHeight = 16;
            this.boxlista.Location = new System.Drawing.Point(364, 231);
            this.boxlista.Name = "boxlista";
            this.boxlista.Size = new System.Drawing.Size(349, 244);
            this.boxlista.TabIndex = 6;
            this.boxlista.SelectedIndexChanged += new System.EventHandler(this.boxlista_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.posizionemod);
            this.panel2.Controls.Add(this.valoremod);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtmodval);
            this.panel2.Controls.Add(this.modificaval);
            this.panel2.Controls.Add(this.modifica);
            this.panel2.Location = new System.Drawing.Point(345, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 172);
            this.panel2.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 30);
            this.label8.TabIndex = 34;
            this.label8.Text = "(seleziona un l\'elemento \r\nnella lista)";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Modifica un elemento:";
            // 
            // posizionemod
            // 
            this.posizionemod.AutoSize = true;
            this.posizionemod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posizionemod.Location = new System.Drawing.Point(10, 55);
            this.posizionemod.Name = "posizionemod";
            this.posizionemod.Size = new System.Drawing.Size(79, 19);
            this.posizionemod.TabIndex = 17;
            this.posizionemod.TabStop = true;
            this.posizionemod.Text = "Posizione";
            this.posizionemod.UseVisualStyleBackColor = true;
            // 
            // valoremod
            // 
            this.valoremod.AutoSize = true;
            this.valoremod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valoremod.Location = new System.Drawing.Point(249, 56);
            this.valoremod.Name = "valoremod";
            this.valoremod.Size = new System.Drawing.Size(60, 19);
            this.valoremod.TabIndex = 18;
            this.valoremod.TabStop = true;
            this.valoremod.Text = "Valore";
            this.valoremod.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 18);
            this.label10.TabIndex = 27;
            this.label10.Text = "Seleziona l\'elemento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(111, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Nuovo valore:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // modifica
            // 
            this.modifica.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.modifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifica.Location = new System.Drawing.Point(219, 137);
            this.modifica.Name = "modifica";
            this.modifica.Size = new System.Drawing.Size(103, 25);
            this.modifica.TabIndex = 30;
            this.modifica.Text = "Modifica";
            this.modifica.UseVisualStyleBackColor = false;
            this.modifica.Click += new System.EventHandler(this.modifica_Click_1);
            // 
            // txtmodval
            // 
            this.txtmodval.Location = new System.Drawing.Point(226, 97);
            this.txtmodval.Name = "txtmodval";
            this.txtmodval.Size = new System.Drawing.Size(96, 22);
            this.txtmodval.TabIndex = 19;
            // 
            // modificaval
            // 
            this.modificaval.Location = new System.Drawing.Point(114, 140);
            this.modificaval.Name = "modificaval";
            this.modificaval.Size = new System.Drawing.Size(96, 22);
            this.modificaval.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.carica);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.testagg);
            this.panel1.Controls.Add(this.codagg);
            this.panel1.Controls.Add(this.ordinatoagg);
            this.panel1.Controls.Add(this.posizioneagg);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.valoreagg);
            this.panel1.Location = new System.Drawing.Point(25, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 132);
            this.panel1.TabIndex = 36;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // carica
            // 
            this.carica.BackColor = System.Drawing.Color.Lime;
            this.carica.Font = new System.Drawing.Font("Noto Serif Lao", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carica.Location = new System.Drawing.Point(191, 46);
            this.carica.Name = "carica";
            this.carica.Size = new System.Drawing.Size(103, 25);
            this.carica.TabIndex = 26;
            this.carica.Text = "Carica";
            this.carica.UseVisualStyleBackColor = false;
            this.carica.Click += new System.EventHandler(this.carica_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "aggiungi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipologia di inserimento:";
            // 
            // testagg
            // 
            this.testagg.AutoSize = true;
            this.testagg.BackColor = System.Drawing.Color.Transparent;
            this.testagg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testagg.Location = new System.Drawing.Point(10, 50);
            this.testagg.Name = "testagg";
            this.testagg.Size = new System.Drawing.Size(55, 19);
            this.testagg.TabIndex = 12;
            this.testagg.TabStop = true;
            this.testagg.Text = "Testa";
            this.testagg.UseVisualStyleBackColor = false;
            // 
            // codagg
            // 
            this.codagg.AutoSize = true;
            this.codagg.BackColor = System.Drawing.Color.Transparent;
            this.codagg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codagg.Location = new System.Drawing.Point(84, 50);
            this.codagg.Name = "codagg";
            this.codagg.Size = new System.Drawing.Size(54, 19);
            this.codagg.TabIndex = 13;
            this.codagg.TabStop = true;
            this.codagg.Text = "Coda";
            this.codagg.UseVisualStyleBackColor = false;
            // 
            // ordinatoagg
            // 
            this.ordinatoagg.AutoSize = true;
            this.ordinatoagg.BackColor = System.Drawing.Color.Transparent;
            this.ordinatoagg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordinatoagg.Location = new System.Drawing.Point(10, 75);
            this.ordinatoagg.Name = "ordinatoagg";
            this.ordinatoagg.Size = new System.Drawing.Size(72, 19);
            this.ordinatoagg.TabIndex = 14;
            this.ordinatoagg.TabStop = true;
            this.ordinatoagg.Text = "Ordinato";
            this.ordinatoagg.UseVisualStyleBackColor = false;
            // 
            // posizioneagg
            // 
            this.posizioneagg.AutoSize = true;
            this.posizioneagg.BackColor = System.Drawing.Color.Transparent;
            this.posizioneagg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posizioneagg.Location = new System.Drawing.Point(84, 75);
            this.posizioneagg.Name = "posizioneagg";
            this.posizioneagg.Size = new System.Drawing.Size(79, 19);
            this.posizioneagg.TabIndex = 15;
            this.posizioneagg.TabStop = true;
            this.posizioneagg.Text = "Posizione";
            this.posizioneagg.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 30);
            this.label7.TabIndex = 20;
            this.label7.Text = "(seleziona un l\'elemento nella lista \r\nper l\'inserimento di posizione )";
            // 
            // valoreagg
            // 
            this.valoreagg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valoreagg.Location = new System.Drawing.Point(84, 4);
            this.valoreagg.Name = "valoreagg";
            this.valoreagg.Size = new System.Drawing.Size(117, 22);
            this.valoreagg.TabIndex = 11;
            // 
            // disegno
            // 
            this.disegno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.disegno.Location = new System.Drawing.Point(9, 341);
            this.disegno.Name = "disegno";
            this.disegno.Size = new System.Drawing.Size(349, 131);
            this.disegno.TabIndex = 32;
            this.disegno.Paint += new System.Windows.Forms.PaintEventHandler(this.disegno_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam CLM", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(311, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste";
            // 
            // Crud
            // 
            this.Crud.Controls.Add(this.crudliste);
            this.Crud.Controls.Add(this.CRUDgrafi);
            this.Crud.Location = new System.Drawing.Point(12, 12);
            this.Crud.Name = "Crud";
            this.Crud.SelectedIndex = 0;
            this.Crud.Size = new System.Drawing.Size(724, 504);
            this.Crud.TabIndex = 0;
            // 
            // CRUDgrafi
            // 
            this.CRUDgrafi.Controls.Add(this.panel5);
            this.CRUDgrafi.Controls.Add(this.panel4);
            this.CRUDgrafi.Controls.Add(this.DFS);
            this.CRUDgrafi.Controls.Add(this.listgrafo);
            this.CRUDgrafi.Controls.Add(this.label13);
            this.CRUDgrafi.Controls.Add(this.panel6);
            this.CRUDgrafi.Controls.Add(this.panel7);
            this.CRUDgrafi.Controls.Add(this.panel8);
            this.CRUDgrafi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CRUDgrafi.Location = new System.Drawing.Point(4, 22);
            this.CRUDgrafi.Name = "CRUDgrafi";
            this.CRUDgrafi.Padding = new System.Windows.Forms.Padding(3);
            this.CRUDgrafi.Size = new System.Drawing.Size(716, 478);
            this.CRUDgrafi.TabIndex = 1;
            this.CRUDgrafi.Text = "CRUD grafi";
            this.CRUDgrafi.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PeachPuff;
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.modificag);
            this.panel5.Controls.Add(this.nodopm);
            this.panel5.Controls.Add(this.nodocm);
            this.panel5.Location = new System.Drawing.Point(6, 165);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(342, 100);
            this.panel5.TabIndex = 61;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(142, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(118, 13);
            this.label24.TabIndex = 51;
            this.label24.Text = "(seleziona un elemento)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(129, 16);
            this.label22.TabIndex = 47;
            this.label22.Text = "Modifica un nodo:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(52, 25);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(79, 13);
            this.label25.TabIndex = 52;
            this.label25.Text = "(nodo pricipale)";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(207, 25);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(79, 13);
            this.label26.TabIndex = 53;
            this.label26.Text = "(nodo collegati)";
            // 
            // modificag
            // 
            this.modificag.BackColor = System.Drawing.Color.Chartreuse;
            this.modificag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificag.Location = new System.Drawing.Point(204, 69);
            this.modificag.Name = "modificag";
            this.modificag.Size = new System.Drawing.Size(103, 25);
            this.modificag.TabIndex = 54;
            this.modificag.Text = "Modifica";
            this.modificag.UseVisualStyleBackColor = false;
            this.modificag.Click += new System.EventHandler(this.modificag_Click);
            // 
            // nodopm
            // 
            this.nodopm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodopm.Location = new System.Drawing.Point(64, 41);
            this.nodopm.Name = "nodopm";
            this.nodopm.Size = new System.Drawing.Size(55, 22);
            this.nodopm.TabIndex = 49;
            // 
            // nodocm
            // 
            this.nodocm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodocm.Location = new System.Drawing.Point(188, 41);
            this.nodocm.Name = "nodocm";
            this.nodocm.Size = new System.Drawing.Size(117, 22);
            this.nodocm.TabIndex = 50;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PeachPuff;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.caricag);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.bidir);
            this.panel4.Controls.Add(this.nodop);
            this.panel4.Controls.Add(this.nodoc);
            this.panel4.Location = new System.Drawing.Point(6, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 113);
            this.panel4.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Aggiungi un nodo:";
            // 
            // caricag
            // 
            this.caricag.BackColor = System.Drawing.Color.Red;
            this.caricag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caricag.Location = new System.Drawing.Point(202, 75);
            this.caricag.Name = "caricag";
            this.caricag.Size = new System.Drawing.Size(103, 25);
            this.caricag.TabIndex = 31;
            this.caricag.Text = "Carica";
            this.caricag.UseVisualStyleBackColor = false;
            this.caricag.Click += new System.EventHandler(this.caricag_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "->";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(50, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "(nodo di partenza)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(205, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "(nodo collegato)";
            // 
            // bidir
            // 
            this.bidir.AutoSize = true;
            this.bidir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bidir.Location = new System.Drawing.Point(41, 75);
            this.bidir.Name = "bidir";
            this.bidir.Size = new System.Drawing.Size(98, 20);
            this.bidir.TabIndex = 37;
            this.bidir.Text = "bidirezionali";
            this.bidir.UseVisualStyleBackColor = true;
            this.bidir.CheckedChanged += new System.EventHandler(this.bidir_CheckedChanged);
            // 
            // nodop
            // 
            this.nodop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodop.Location = new System.Drawing.Point(41, 47);
            this.nodop.Name = "nodop";
            this.nodop.Size = new System.Drawing.Size(117, 22);
            this.nodop.TabIndex = 30;
            this.nodop.TextChanged += new System.EventHandler(this.nodop_TextChanged);
            // 
            // nodoc
            // 
            this.nodoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodoc.Location = new System.Drawing.Point(190, 47);
            this.nodoc.Name = "nodoc";
            this.nodoc.Size = new System.Drawing.Size(117, 22);
            this.nodoc.TabIndex = 32;
            this.nodoc.TextChanged += new System.EventHandler(this.nodoc_TextChanged);
            // 
            // DFS
            // 
            this.DFS.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DFS.Location = new System.Drawing.Point(22, 437);
            this.DFS.Name = "DFS";
            this.DFS.Size = new System.Drawing.Size(103, 25);
            this.DFS.TabIndex = 39;
            this.DFS.Text = "DFS";
            this.DFS.UseVisualStyleBackColor = false;
            this.DFS.Click += new System.EventHandler(this.DFS_Click);
            // 
            // listgrafo
            // 
            this.listgrafo.FormattingEnabled = true;
            this.listgrafo.ItemHeight = 16;
            this.listgrafo.Location = new System.Drawing.Point(354, 15);
            this.listgrafo.Name = "listgrafo";
            this.listgrafo.Size = new System.Drawing.Size(347, 420);
            this.listgrafo.TabIndex = 36;
            this.listgrafo.SelectedIndexChanged += new System.EventHandler(this.listgrafo_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 31);
            this.label13.TabIndex = 27;
            this.label13.Text = "Grafi";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PeachPuff;
            this.panel6.Controls.Add(this.label23);
            this.panel6.Controls.Add(this.nodope);
            this.panel6.Controls.Add(this.label27);
            this.panel6.Controls.Add(this.label28);
            this.panel6.Controls.Add(this.eleiminag);
            this.panel6.Controls.Add(this.nodoce);
            this.panel6.Location = new System.Drawing.Point(6, 269);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(342, 81);
            this.panel6.TabIndex = 62;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(121, 16);
            this.label23.TabIndex = 48;
            this.label23.Text = "Elimina un nodo:";
            // 
            // nodope
            // 
            this.nodope.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodope.Location = new System.Drawing.Point(29, 40);
            this.nodope.Name = "nodope";
            this.nodope.Size = new System.Drawing.Size(55, 22);
            this.nodope.TabIndex = 55;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(17, 24);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(79, 13);
            this.label27.TabIndex = 56;
            this.label27.Text = "(nodo pricipale)";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(111, 24);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(76, 13);
            this.label28.TabIndex = 58;
            this.label28.Text = "(collegamento)";
            // 
            // eleiminag
            // 
            this.eleiminag.BackColor = System.Drawing.Color.Cyan;
            this.eleiminag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eleiminag.Location = new System.Drawing.Point(202, 37);
            this.eleiminag.Name = "eleiminag";
            this.eleiminag.Size = new System.Drawing.Size(103, 25);
            this.eleiminag.TabIndex = 59;
            this.eleiminag.Text = "Elimina";
            this.eleiminag.UseVisualStyleBackColor = false;
            this.eleiminag.Click += new System.EventHandler(this.eleiminag_Click);
            // 
            // nodoce
            // 
            this.nodoce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodoce.Location = new System.Drawing.Point(114, 40);
            this.nodoce.Name = "nodoce";
            this.nodoce.Size = new System.Drawing.Size(55, 22);
            this.nodoce.TabIndex = 57;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.PeachPuff;
            this.panel7.Controls.Add(this.label21);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.BFS);
            this.panel7.Location = new System.Drawing.Point(6, 353);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(342, 57);
            this.panel7.TabIndex = 63;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(142, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(172, 13);
            this.label21.TabIndex = 45;
            this.label21.Text = "(seleziona un elemento da dove far";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(142, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 13);
            this.label18.TabIndex = 46;
            this.label18.Text = "partire la visita)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 16);
            this.label16.TabIndex = 40;
            this.label16.Text = "Visita in ampiezza:";
            // 
            // BFS
            // 
            this.BFS.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFS.Location = new System.Drawing.Point(16, 26);
            this.BFS.Name = "BFS";
            this.BFS.Size = new System.Drawing.Size(103, 25);
            this.BFS.TabIndex = 38;
            this.BFS.Text = "BFS";
            this.BFS.UseVisualStyleBackColor = false;
            this.BFS.Click += new System.EventHandler(this.BFS_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.PeachPuff;
            this.panel8.Controls.Add(this.label20);
            this.panel8.Controls.Add(this.label19);
            this.panel8.Controls.Add(this.label17);
            this.panel8.Location = new System.Drawing.Point(6, 413);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(342, 59);
            this.panel8.TabIndex = 65;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(149, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 13);
            this.label20.TabIndex = 44;
            this.label20.Text = "partire la visita)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(149, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(172, 13);
            this.label19.TabIndex = 43;
            this.label19.Text = "(seleziona un elemento da dove far";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(140, 16);
            this.label17.TabIndex = 41;
            this.label17.Text = "Visita in profondità:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(208, 78);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(127, 13);
            this.label29.TabIndex = 39;
            this.label29.Text = "Valore da modificare:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 528);
            this.Controls.Add(this.Crud);
            this.Name = "Form1";
            this.Text = "Grafi e liste";
            this.crudliste.ResumeLayout(false);
            this.crudliste.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Crud.ResumeLayout(false);
            this.CRUDgrafi.ResumeLayout(false);
            this.CRUDgrafi.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage crudliste;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel disegno;
        private System.Windows.Forms.Button elimina;
        private System.Windows.Forms.Button modifica;
        private System.Windows.Forms.TextBox modificaval;
        private System.Windows.Forms.TextBox valoredaeliminare;
        private System.Windows.Forms.TextBox txtmodval;
        private System.Windows.Forms.TextBox valoreagg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button carica;
        private System.Windows.Forms.RadioButton valorelim;
        private System.Windows.Forms.RadioButton posizionelim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton valoremod;
        private System.Windows.Forms.RadioButton posizionemod;
        private System.Windows.Forms.RadioButton posizioneagg;
        private System.Windows.Forms.RadioButton ordinatoagg;
        private System.Windows.Forms.RadioButton codagg;
        private System.Windows.Forms.RadioButton testagg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox boxlista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Crud;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage CRUDgrafi;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button modificag;
        private System.Windows.Forms.TextBox nodopm;
        private System.Windows.Forms.TextBox nodocm;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button caricag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox bidir;
        private System.Windows.Forms.TextBox nodop;
        private System.Windows.Forms.TextBox nodoc;
        private System.Windows.Forms.Button DFS;
        private System.Windows.Forms.ListBox listgrafo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox nodope;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button eleiminag;
        private System.Windows.Forms.TextBox nodoce;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button BFS;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label29;
    }
}

