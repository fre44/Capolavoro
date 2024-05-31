using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace grafi_e_liste
{
    public partial class Form1 : Form
    {
        private List<string> lista;
        public Form1(){
            InitializeComponent();
            lista = new List<string>();
            disegno.Paint += new PaintEventHandler(disegno_Paint);

        }        

        private void disegno_Paint(object sender, PaintEventArgs e){
            Graphics a = e.Graphics;
            int radius = 20;
            int x = 20;
            int y = disegno.Height / 2 - radius;

            using (Font font = new Font("Arial", 10)){
                for (int i = 0; i < boxlista.Items.Count; i++){
                    a.FillEllipse(Brushes.Gray, x, y, radius * 2, radius * 2);

                    if (i < boxlista.Items.Count - 1){
                        float arrowStartX = x + radius * 2;
                        float arrowEndX = arrowStartX + radius + 5;
                        float arrowY = y + radius;
                        float arrowLength = 20;
                        float arrowWidth = 10;

                        a.DrawLine(Pens.Black, arrowStartX, arrowY, arrowStartX + arrowLength, arrowY);

                        PointF[] arrowPoints = new PointF[]{
                            new PointF(arrowStartX + arrowLength, arrowY),
                            new PointF(arrowStartX + arrowLength - arrowWidth, arrowY - arrowWidth / 2),
                            new PointF(arrowStartX + arrowLength - arrowWidth, arrowY + arrowWidth / 2)
                        };
                        a.FillPolygon(Brushes.Black, arrowPoints);

                    }

                    string text = boxlista.Items[i].ToString();
                    SizeF textSize = a.MeasureString(text, font);
                    float textX = x + (radius * 2 - textSize.Width) / 2;
                    float textY = y + (radius * 2 - textSize.Height) / 2;
                    a.DrawString(text, font, Brushes.Black, textX, textY);

                    x += radius * 3;
                }
            }
        }


        private void AggiornaListBox(){
            boxlista.Items.Clear();
            foreach (var item in lista){
                boxlista.Items.Add(item);
            }
        }

        private void carica_Click(object sender, EventArgs e)
        {
            string nuovoValore = valoreagg.Text;
            bool esegui = true;

            if (nuovoValore == "")
            {
                MessageBox.Show("Inserisci un valore!");
                esegui = false;
                goto qui;
            }

            if (lista.Contains(nuovoValore))
            {
                MessageBox.Show("L'elemento è già presente nella lista!");
                esegui = false;
                goto qui;
            }

            if (testagg.Checked)
            {
                lista.Insert(0, nuovoValore);
            }
            else if (codagg.Checked)
            {
                lista.Add(nuovoValore);
            }
            else if (ordinatoagg.Checked)
            {
                bool isNumeric = true;
                foreach (string elemento in lista)
                {
                    if (!int.TryParse(elemento, out _))
                    {
                        isNumeric = false;
                        break;
                    }
                }

                if (isNumeric && int.TryParse(nuovoValore, out _))
                {
                    int indice = 0;
                    foreach (string numeri in lista)
                    {
                        if (int.Parse(nuovoValore) < int.Parse(numeri))
                        {
                            break;
                        }
                        indice++;
                    }
                    lista.Insert(indice, nuovoValore);
                }
                else
                {
                    int indice = 0;
                    foreach (string parole in lista)
                    {
                        if (string.Compare(nuovoValore, parole, StringComparison.CurrentCulture) < 0)
                        {
                            break;
                        }
                        indice++;
                    }
                    lista.Insert(indice, nuovoValore);
                }
            }
            else if (posizioneagg.Checked)
            {
                int posizione = boxlista.SelectedIndex;
                if (posizione != -1 && posizione <= lista.Count)
                {
                    lista.Insert(posizione, nuovoValore);
                }
                else
                {
                    MessageBox.Show("Seleziona la posizione nella list box.");
                    esegui = false;
                    goto qui;
                }
            }
            else
            {
                MessageBox.Show("Seleziona un'opzione.");
                esegui = false;
                goto qui;
            }

        qui:
            if (esegui)
            {
                AggiornaListBox();
                valoreagg.Clear();
                disegno.Invalidate();
            }
        }

        private void modifica_Click_1(object sender, EventArgs e)
        {
            bool esegui = true;
            string modificaValore = modificaval.Text;

            if (modificaValore == null)
            {
                MessageBox.Show("Inserisci un valore.");
                esegui = false;
                goto qui;
            }

            if (posizionemod.Checked)
            {
                int posizione = boxlista.SelectedIndex;

                if (posizione != -1 && posizione < lista.Count)
                {
                    string elementoEsistente = lista[posizione];
                    if (!lista.Contains(modificaValore) || modificaValore == elementoEsistente)
                    {
                        lista[posizione] = modificaValore;
                    }
                    else
                    {
                        MessageBox.Show("Il valore inserito è già presente nella lista.");
                        esegui = false;
                        goto qui;
                    }
                }
                else
                {
                    MessageBox.Show("Seleziona una posizione valida nella list box.");
                    esegui = false;
                    goto qui;
                }
            }
            else if (valoremod.Checked)
            {
                string valoreDaModificare = txtmodval.Text;

                if (valoreDaModificare == null)
                {
                    MessageBox.Show("Inserisci un valore da modificare!");
                    esegui = false;
                    goto qui;
                }

                if (!lista.Contains(modificaValore) || modificaValore == valoreDaModificare)
                {
                    if (lista.Contains(valoreDaModificare))
                    {
                        int index = lista.IndexOf(valoreDaModificare);
                        lista[index] = modificaValore;
                    }
                    else
                    {
                        MessageBox.Show("Il valore da modificare non è presente nella lista.");
                        esegui = false;
                        goto qui;
                    }
                }
                else
                {
                    MessageBox.Show("Il valore inserito è già presente nella lista.");
                    esegui = false;
                    goto qui;
                }
            }
            else
            {
                MessageBox.Show("Seleziona un'opzione.");
                esegui = false;
                goto qui;
            }

        qui:
            if (esegui)
            {
                AggiornaListBox();
                modificaval.Clear();
                disegno.Invalidate();
            }
        }


        private void elimina_Click_1(object sender, EventArgs e)
        {
            bool esegui = true;
            if (posizionelim.Checked){
                int posizione = boxlista.SelectedIndex;
                if (posizione != -1 && posizione < lista.Count)
                {
                    lista.RemoveAt(posizione);
                }
                else
                {
                    MessageBox.Show("Seleziona una posizione valida nella list box.");
                    esegui = false;
                    goto qui;
                }
            }
            else if (valorelim.Checked){
                string valoreDaEliminare = valoredaeliminare.Text;
                if (string.IsNullOrEmpty(valoreDaEliminare))
                {
                    MessageBox.Show("Inserisci un valore da eliminare!");
                    esegui = false;
                    goto qui;
                }

                bool eliminato = false;
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i] == valoreDaEliminare)
                    {
                        lista.RemoveAt(i);
                        eliminato = true;
                        break;
                    }
                }

                if (!eliminato){
                    MessageBox.Show("Il valore da eliminare non è presente nella lista.");
                    esegui = false;
                    goto qui;
                }
            }
            else{
                MessageBox.Show("Seleziona un'opzione.");
                esegui = false;
                goto qui;
            }
qui:
            if (esegui==true){
                AggiornaListBox();
                valoredaeliminare.Clear();
                disegno.Invalidate();
            }

        }

        //cose aggiuntive prima scheda
        private void label2_Click(object sender, EventArgs e) {}
        private void crea_Click(object sender, EventArgs e) {}
        private void modifica_Click(object sender, EventArgs e) {}
        private void elimina_Click(object sender, EventArgs e) {}
        private void label3_Click(object sender, EventArgs e) {}
        private void label6_Click(object sender, EventArgs e) {}
        private void label5_Click(object sender, EventArgs e) {}
        private void label8_Click(object sender, EventArgs e) {}
        private void label7_Click(object sender, EventArgs e) {}
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) {}
        private void label9_Click(object sender, EventArgs e) {}
        private void boxlista_SelectedIndexChanged(object sender, EventArgs e) {}
        private void hScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            disegno.Invalidate();
        }





        //crud grafi
        private Grafo grafo = new Grafo();
        public class NodoGrafo{
            private string nome;
            public string Nome{
                get { return nome; }
                set
                {
                    if (value==null)
                    {
                        throw new ArgumentException("Il nome del nodo non può essere vuoto o nullo.");
                    }
                    nome = value;
                }
            }
            public List<NodoGrafo> NodiAdiacenti { get; set; }

            public NodoGrafo(string nome){
                Nome = nome;
                NodiAdiacenti = new List<NodoGrafo>();
            }
        }

        public class Grafo{
            public List<NodoGrafo> Nodi { get; set; }

            public Grafo(){
                Nodi = new List<NodoGrafo>();
            }

            public void AggiungiNodo(string nomeNodo1, string nomeNodo2, bool bidirezionale){
                NodoGrafo nodoPrincipale = TrovaOAggiungiNodo(nomeNodo1);

                if (!string.IsNullOrEmpty(nomeNodo2)){
                    NodoGrafo nodoCollegato = TrovaOAggiungiNodo(nomeNodo2);

                    if (nodoPrincipale != nodoCollegato && !nodoPrincipale.NodiAdiacenti.Contains(nodoCollegato)){
                        nodoPrincipale.NodiAdiacenti.Add(nodoCollegato);
                    }

                    if (bidirezionale && nodoPrincipale != nodoCollegato && !nodoCollegato.NodiAdiacenti.Contains(nodoPrincipale)){
                        nodoCollegato.NodiAdiacenti.Add(nodoPrincipale);
                    }
                }
            }

            private NodoGrafo TrovaOAggiungiNodo(string nome){
                foreach (var nodo in Nodi)
                {
                    if (nodo.Nome == nome)
                    {
                        return nodo;
                    }
                }

                NodoGrafo nuovoNodo = new NodoGrafo(nome);
                Nodi.Add(nuovoNodo);
                return nuovoNodo;
            }
            public void EliminaNodo(string nomeNodo){
                NodoGrafo nodoDaEliminare = Nodi.Find(n => n.Nome == nomeNodo);

                if (nodoDaEliminare != null)
                {
                    Nodi.Remove(nodoDaEliminare);

                    foreach (var nodo in Nodi)
                    {
                        nodo.NodiAdiacenti.Remove(nodoDaEliminare);
                    }
                }
            }

            public void EliminaNodoAdiacente(string nomeNodoPrincipale, string nomeNodoAdiacente)
            {
                NodoGrafo nodoPrincipale = Nodi.Find(n => n.Nome == nomeNodoPrincipale);
                NodoGrafo nodoAdiacente = Nodi.Find(n => n.Nome == nomeNodoAdiacente);

                if (nodoPrincipale != null && nodoAdiacente != null) { 
                    nodoPrincipale.NodiAdiacenti.Remove(nodoAdiacente);
                }
            }
        }

        private void caricag_Click(object sender, EventArgs e)
        {
            string nodoPrincipale = nodop.Text;
            string nodoCollegato = nodoc.Text;
            bool bidirezionale = bidir.Checked;

            if (nodoPrincipale==""){ 
                MessageBox.Show("Il nome del nodo principale non può essere vuoto.");
                return;
            }

            grafo.AggiungiNodo(nodoPrincipale, nodoCollegato, bidirezionale);
            StampaNodiAdiacenti();
            nodop.Clear();
            nodoc.Clear();
        }

        private void StampaNodiAdiacenti()
        {
            listgrafo.Items.Clear();

            foreach (var nodo in grafo.Nodi){
                string output = nodo.Nome + " -> ";
                foreach (var adiacente in nodo.NodiAdiacenti)
                {
                    output += adiacente.Nome + ", ";
                }
                output = output.TrimEnd(',', ' ');
                listgrafo.Items.Add(output);
            }

            if (listgrafo.Items.Count > 0){
                listgrafo.SelectedIndex = 0;
            }
        }

        private void modificag_Click(object sender, EventArgs e)
        {
            if (listgrafo.SelectedItem == null){
                MessageBox.Show("Seleziona un nodo dalla lista per modificare.");
                return;
            }

            string selectedNodeText = listgrafo.SelectedItem.ToString();
            string nodoPrincipaleNome = selectedNodeText.Split(new[] { " -> " }, StringSplitOptions.None)[0];
            NodoGrafo nodoPrincipale = grafo.Nodi.Find(n => n.Nome == nodoPrincipaleNome);

            if (nodoPrincipale == null){
                MessageBox.Show("Nodo principale non trovato.");
                return;
            }

            string nuovoNomeNodoPrincipale = nodopm.Text;
            if (nuovoNomeNodoPrincipale!=null && nuovoNomeNodoPrincipale != nodoPrincipale.Nome)
            {
                foreach (var nodo in grafo.Nodi){
                    for (int i = 0; i < nodo.NodiAdiacenti.Count; i++){
                        if (nodo.NodiAdiacenti[i].Nome == nodoPrincipale.Nome)
                        {
                            nodo.NodiAdiacenti[i].Nome = nuovoNomeNodoPrincipale;
                        }
                    }
                }
                nodoPrincipale.Nome = nuovoNomeNodoPrincipale;
            }

            string nuoviNodiAdiacenti = nodocm.Text;
            List<string> nomiNodiAdiacenti = nuoviNodiAdiacenti.Split(new[] { ", ","," }, StringSplitOptions.RemoveEmptyEntries).ToList();

            nodoPrincipale.NodiAdiacenti.Clear();
            foreach (string nomeNodoAdiacente in nomiNodiAdiacenti){
                NodoGrafo nodoAdiacente = grafo.Nodi.Find(n => n.Nome == nomeNodoAdiacente);
                if (nodoAdiacente == null)
                {
                    nodoAdiacente = new NodoGrafo(nomeNodoAdiacente);
                    grafo.Nodi.Add(nodoAdiacente);
                }
                nodoPrincipale.NodiAdiacenti.Add(nodoAdiacente);
            }

            StampaNodiAdiacenti();
            nodopm.Clear();
            nodocm.Clear();
            nodope.Clear();
        }

        private void listgrafo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listgrafo.SelectedItem == null){
                return;
            }

            string selectedNodeText = listgrafo.SelectedItem.ToString();
            string nodoPrincipaleNome = selectedNodeText.Split(new[] { " -> " }, StringSplitOptions.None)[0];
            NodoGrafo nodoPrincipale = grafo.Nodi.Find(n => n.Nome == nodoPrincipaleNome);

            if (nodoPrincipale != null)
            {
                nodopm.Text = nodoPrincipale.Nome;
                nodocm.Text = nodoPrincipale.NodiAdiacenti.Any() ? string.Join(", ", nodoPrincipale.NodiAdiacenti.Select(n => n.Nome)) : string.Empty;
                nodope.Text = nodoPrincipale.Nome;
            }
        }

        private void eleiminag_Click(object sender, EventArgs e)
        {
            if (listgrafo.SelectedItem == null){
                MessageBox.Show("Seleziona un nodo dalla lista per eliminare.");
                return;
            }

            string selectedNodeText = listgrafo.SelectedItem.ToString();
            string nodoPrincipaleNome = selectedNodeText.Split(new[] { " -> " }, StringSplitOptions.None)[0];
            string nodoCollegatoNome = nodoce.Text;

            if (!string.IsNullOrEmpty(nodoCollegatoNome))
            {
                grafo.EliminaNodoAdiacente(nodoPrincipaleNome, nodoCollegatoNome);
            }
            else
            {
                grafo.EliminaNodo(nodoPrincipaleNome);
            }

            StampaNodiAdiacenti();
            nodopm.Clear();
            nodocm.Clear();
            nodope.Clear();
        }

        private void BFS_Click(object sender, EventArgs e)
        {
            if (listgrafo.SelectedItem == null){
                MessageBox.Show("Seleziona un nodo dalla lista per avviare la visita in ampiezza (BFS).");
                return;
            }

            string selectedNodeText = listgrafo.SelectedItem.ToString();
            string nodoPrincipaleNome = selectedNodeText.Split(new[] { " -> " }, StringSplitOptions.None)[0];
            NodoGrafo nodoPrincipale = grafo.Nodi.Find(n => n.Nome == nodoPrincipaleNome);

            StringBuilder visitedNodes = new StringBuilder();
            Queue<NodoGrafo> queue = new Queue<NodoGrafo>();

            queue.Enqueue(nodoPrincipale);

            while (queue.Count > 0){
                NodoGrafo current = queue.Dequeue();
                visitedNodes.Append($"{current.Nome}, ");

                foreach (var adiacente in current.NodiAdiacenti)
                {
                    if (!queue.Contains(adiacente))
                    {
                        queue.Enqueue(adiacente);
                    }
                }
            }

            if (visitedNodes.Length > 0)
            {
                visitedNodes.Length -= 2;
            }

            MessageBox.Show("Visiti: " + visitedNodes.ToString());
        }

        private void DFS_Click(object sender, EventArgs e){
            if (listgrafo.SelectedItem == null){
                MessageBox.Show("Seleziona un nodo dalla lista per avviare la visita in profondità (DFS).");
                return;
            }

            string selectedNodeText = listgrafo.SelectedItem.ToString();
            string nodoPrincipaleNome = selectedNodeText.Split(new[] { " -> " }, StringSplitOptions.None)[0];
            NodoGrafo nodoPrincipale = grafo.Nodi.Find(n => n.Nome == nodoPrincipaleNome);

            if (nodoPrincipale == null)
            {
                MessageBox.Show("Nodo principale non trovato.");
                return;
            }

            StringBuilder visitedNodes = new StringBuilder();
            Stack<NodoGrafo> stack = new Stack<NodoGrafo>();
            HashSet<NodoGrafo> visited = new HashSet<NodoGrafo>();

            stack.Push(nodoPrincipale);

            while (stack.Count > 0)
            {
                NodoGrafo current = stack.Pop();

                if (!visited.Contains(current))
                {
                    visitedNodes.Append($"{current.Nome}, ");
                    visited.Add(current);

                    foreach (var adiacente in current.NodiAdiacenti)
                    {
                        if (!visited.Contains(adiacente))
                        {
                            stack.Push(adiacente);
                        }
                    }
                }
            }

            if (visitedNodes.Length > 0)
            {
                visitedNodes.Length -= 2;
            }

            MessageBox.Show("Visiti: " + visitedNodes.ToString());
        }
        private void bidir_CheckedChanged(object sender, EventArgs e) {}
        private void nodoc_TextChanged(object sender, EventArgs e) {}
        private void nodop_TextChanged(object sender, EventArgs e) {}
        private void panel1_Paint(object sender, PaintEventArgs e) {}
        private void label21_Click(object sender, EventArgs e) {}
        private void label8_Click_1(object sender, EventArgs e) {}
        private void label11_Click(object sender, EventArgs e) {}
    }
}

