using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Managers : MonoBehaviour
{
    public TMP_InputField vardaLauks;
    public TMP_InputField gadaLauks;
    public TextMeshProUGUI rezultataTeksts;

    public void AprekinatUnIenakt()
    {

        if (string.IsNullOrEmpty(vardaLauks.text) || string.IsNullOrEmpty(gadaLauks.text))
        {
            rezultataTeksts.text = "Lūdzu, aizpildi datus!";
            return;
        }

        int dzimsanasGads;
        if (int.TryParse(gadaLauks.text, out dzimsanasGads))
        {
            int vecums = System.DateTime.Now.Year - dzimsanasGads;
            rezultataTeksts.text = "Klients " + vardaLauks.text + " ir " + vecums + " gadus vecs!";


            Invoke("IetUzIstabu", 1.0f);
        }
    }

    public void IetUzIstabu()
    {
        SceneManager.LoadScene(1);
    }
}