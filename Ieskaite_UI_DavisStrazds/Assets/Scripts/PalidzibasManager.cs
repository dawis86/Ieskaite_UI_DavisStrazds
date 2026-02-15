using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PalidzibasManager : MonoBehaviour
{
    public TextMeshProUGUI sarakstaTeksts;
    public Image telaBilde;
    public Sprite raudBilde;
    public Sprite smaidigaBilde; 

    void Start()
    {
        MainitTelu(0);
    }

    public void PogaPartika() {
        sarakstaTeksts.text = "Pārtika: Zupa un maize sagatavota!";
    }

    public void PogaMedicina() {
        sarakstaTeksts.text = "Medicīna: Plāksteri un vitamīni pieejami.";
    }

    public void PogaPsihologs() {
        sarakstaTeksts.text = "Psihologs: Speciālists ir gatavs uzklausīt.";
    }

    public void MainitTelu(int index)
    {
        if (index == 0) {
            telaBilde.color = new Color(1, 1, 1, 0);
            sarakstaTeksts.text = "Kā tu jūties?";
        } 
        else if (index == 1) {
            telaBilde.sprite = raudBilde;
            telaBilde.color = new Color(1, 1, 1, 1);
            sarakstaTeksts.text = "Klients ir bēdīgs un viņam nepieciešama palīdzība.";
        } 
        else if (index == 2) {
            telaBilde.sprite = smaidigaBilde;
            telaBilde.color = new Color(1, 1, 1, 1);
            sarakstaTeksts.text = "Lieliski! Klients jūtas aprūpēts un smaidīgs.";
        }
    }
}