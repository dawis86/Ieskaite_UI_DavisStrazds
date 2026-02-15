using UnityEngine;
using TMPro;

public class Managers : MonoBehaviour
{
    public TMP_InputField vardaLauks;
    public TMP_InputField gadaLauks;
    public TextMeshProUGUI rezultataTeksts;

    public void AprekinatVecumu()
    {
        string vards = vardaLauks.text;
        int dzimsanasGads;

        if (int.TryParse(gadaLauks.text, out dzimsanasGads))
        {
            int pasreizejaisGads = System.DateTime.Now.Year;
            int vecums = pasreizejaisGads - dzimsanasGads;
            rezultataTeksts.text = "Klients " + vards + " ir " + vecums + " gadus vecs!";
        }
        else
        {
            rezultataTeksts.text = "Lūdzu, ievadiet derīgu gadu!";
        }
    }
}