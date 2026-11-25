using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace garage
{
    public partial class Form1 : Form
    {
        private List<Moto> garageList = new List<Moto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            garageList = GarageDataManager.CaricaDati();
            AggiornaListaUI();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text) || string.IsNullOrWhiteSpace(txtModello.Text))
            {
                MessageBox.Show("Inserisci almeno marca e modello!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int kmInseriti = (int)numKmAttuali.Value;
            DateTime dataUltimaManutenzione = dtpUltimaData.Value.Date;

            Moto nuovaMoto = new Moto
            {
                Marca = txtMarca.Text,
                Modello = txtModello.Text,
                Targa = txtTarga.Text,
                KmAttuali = kmInseriti
            };

            nuovaMoto.ListaManutenzioni.Add(CreaManutenzione("Cambio Gomme", kmInseriti, dataUltimaManutenzione));
            nuovaMoto.ListaManutenzioni.Add(CreaManutenzione("Olio", kmInseriti, dataUltimaManutenzione));
            nuovaMoto.ListaManutenzioni.Add(CreaManutenzione("Revisione", kmInseriti, dataUltimaManutenzione));

            garageList.Add(nuovaMoto);
            GarageDataManager.SalvaDati(garageList);
            AggiornaListaUI();
            PulisciCampi();
        }

        private Manutenzione CreaManutenzione(string tipo, int chilometri, DateTime data)
        {
            return new Manutenzione
            {
                Tipo = tipo,
                UltimoKm = chilometri,
                UltimaData = data
            };
        }

        private void PulisciCampi()
        {
            txtMarca.Clear();
            txtModello.Clear();
            txtTarga.Clear();
            numKmAttuali.Value = 0;
            dtpUltimaData.Value = DateTime.Now;
        }

        private void AggiornaListaUI()
        {
            lstMoto.Items.Clear();
            foreach (var moto in garageList)
            {
                lstMoto.Items.Add(moto);
            }
        }

        private void lstMoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMoto.SelectedIndex >= 0)
            {
                Moto motoSelezionata = garageList[lstMoto.SelectedIndex];

                txtMarca.Text = motoSelezionata.Marca;
                txtModello.Text = motoSelezionata.Modello;
                txtTarga.Text = motoSelezionata.Targa;
                numKmAttuali.Value = motoSelezionata.KmAttuali;

                // Controllo di sicurezza se la lista è null
                if (motoSelezionata.ListaManutenzioni == null)
                {
                    motoSelezionata.ListaManutenzioni = new List<Manutenzione>();
                }

                var listaVisualizzazione = new List<object>();
                foreach (var m in motoSelezionata.ListaManutenzioni)
                {
                    DateTime prossimaData = m.GetProssimaData();
                    listaVisualizzazione.Add(new
                    {
                        m.Tipo,
                        m.UltimoKm,
                        UltimaData = m.UltimaData.ToShortDateString(),
                        KmRimanenti = m.GetKmRimanenti(motoSelezionata.KmAttuali),
                        ProssimaData = prossimaData == DateTime.MaxValue ? "N/D" : prossimaData.ToShortDateString(),
                        Stato = m.GetStato(motoSelezionata.KmAttuali)
                    });
                }

                gridManutenzioni.DataSource = null;
                gridManutenzioni.DataSource = listaVisualizzazione;
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (lstMoto.SelectedIndex < 0)
            {
                MessageBox.Show("Seleziona prima la moto che desideri eliminare dalla lista!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult risultato = MessageBox.Show(
                "Sei sicuro di voler eliminare questa moto e tutte le relative manutenzioni?",
                "Conferma eliminazione",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (risultato == DialogResult.Yes)
            {
                int indiceSelezionato = lstMoto.SelectedIndex;
                garageList.RemoveAt(indiceSelezionato);

                GarageDataManager.SalvaDati(garageList);
                AggiornaListaUI();

                PulisciCampi();
                gridManutenzioni.DataSource = null;

                MessageBox.Show("Moto eliminata con successo.", "Eliminazione completata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}