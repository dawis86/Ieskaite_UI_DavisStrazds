using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Nepieciešams ainu pārslēgšanai

public class Managers : MonoBehaviour
{
    [Header("UI Elementi")]
    public TMP_InputField vardaLauks;
    public TMP_InputField gadaLauks;
    public TextMeshProUGUI rezultataTeksts;
    
    [Header("Skaņas")]
    public AudioSource klauvienaAvots;

    public void AprekinatVecumu()
    {
        // 1. Atskaņojam klauvējienu, kad nospiež pogu
        if(klauvienaAvots != null) 
        {
            klauvienaAvots.Play();
        }

        // 2. Iegūstam datus no ievades laukiem
        string vards = vardaLauks.text;
        int dzimsanasGads;

        // 3. Pārbaudām, vai ievadīts skaitlis un aprēķinām vecumu
        if (int.TryParse(gadaLauks.text, out dzimsanasGads))
        {
            int pasreizejaisGads = System.DateTime.Now.Year;
            int vecums = pasreizejaisGads - dzimsanasGads;
            
            // Attēlojam rezultātu, kā prasīts uzdevumā
            rezultataTeksts.text = "Klients " + vards + " ir " + vecums + " gadus vecs!";
            
            // 4. Pēc aprēķina pēc 1.5 sekundēm automātiski ieiesim iekšā telpā
            Invoke("IetUzIstabu", 1.5f); 
        }
        else
        {
            rezultataTeksts.text = "Lūdzu, ievadiet derīgu gadu!";
        }
    }

    // Funkcija, lai pārietu uz nākamo ainu
    public void IetUzIstabu()
    {
        // Pārliecinies, ka Build Settings logā "Istaba" ir ar indeksu 1
        SceneManager.LoadScene(1); 
    }

    // Funkcija projekta aizvēršanai (pogai "Iziet")
    public void IzietNoSpeles()
    {
        Debug.Log("Spēle tiek aizvērta...");
        Application.Quit(); // Šis nostrādās tikai gatavā (.exe) versijā
    }
}