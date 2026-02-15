using UnityEngine;
using TMPro;

public class PalidzibasManager : MonoBehaviour
{
    public TextMeshProUGUI sarakstaTeksts;

    public void PogaPartika()
    {
        sarakstaTeksts.text = "Pārtika: Tev ir sagatavota zupa un maize.";
    }

    public void PogaMedicina()
    {
        sarakstaTeksts.text = "Medicīna: Plāksteri un vitamīni ir pieejami.";
    }

    public void PogaPsihologs()
    {
        sarakstaTeksts.text = "Psihologs: Mēs esam šeit, lai palīdzētu.";
    }
}