using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace garage
{
    public class Manutenzione
    {
        public string Tipo { get; set; }
        public int UltimoKm { get; set; }
        public DateTime UltimaData { get; set; }

        public int IntervalloKm => Tipo == "Olio" ? 6000 : 10000;

        public int IntervalloMesi => Tipo == "Revisione" ? 24 : 12;

        public int GetKmRimanenti(int kmAttualiMoto)
        {
            if (IntervalloKm <= 0) return int.MaxValue;

            if (DateTime.Now >= GetProssimaData()) return 0;

            int prossimoKm = UltimoKm + IntervalloKm;
            return Math.Max(0, prossimoKm - kmAttualiMoto);
        }

        public DateTime GetProssimaData()
        {
            if (IntervalloMesi <= 0) return DateTime.MaxValue;
            return UltimaData.AddMonths(IntervalloMesi);
        }

        public string GetStato(int kmAttualiMoto)
        {
            int kmRim = GetKmRimanenti(kmAttualiMoto);
            DateTime prossimaData = GetProssimaData();

            bool scadutoKm = (kmRim <= 0);
            bool scadutoData = (DateTime.Now >= prossimaData);

            if (scadutoKm || scadutoData) return "SCADUTO!";

            bool inScadenzaKm = (kmRim <= 500);
            bool inScadenzaData = (DateTime.Now.AddDays(30) >= prossimaData);

            if (inScadenzaKm || inScadenzaData) return "In Scadenza..";

            return "OK";
        }
    }

    public class Moto
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Marca { get; set; }
        public string Modello { get; set; }
        public string Targa { get; set; }
        public int KmAttuali { get; set; }

        public List<Manutenzione> ListaManutenzioni { get; set; } = new List<Manutenzione>();

        public override string ToString()
        {
            return $"{Marca} {Modello} ({Targa}) - {KmAttuali} km";
        }
    }

    public static class GarageDataManager
    {
        private static readonly string PercorsoFile = "garage.json";

        public static void SalvaDati(List<Moto> listaMoto)
        {
            try
            {
                var opzioni = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(listaMoto, opzioni);
                File.WriteAllText(PercorsoFile, jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore durante il salvataggio dei dati: {ex.Message}");
            }
        }

        public static List<Moto> CaricaDati()
        {
            try
            {
                if (!File.Exists(PercorsoFile)) return new List<Moto>();
                string jsonString = File.ReadAllText(PercorsoFile);
                List<Moto> listaMoto = JsonSerializer.Deserialize<List<Moto>>(jsonString);
                return listaMoto ?? new List<Moto>();
            }
            catch (Exception)
            {
                return new List<Moto>();
            }
        }
    }
}