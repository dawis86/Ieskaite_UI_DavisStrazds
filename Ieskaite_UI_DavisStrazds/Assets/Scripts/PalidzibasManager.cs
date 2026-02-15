using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PalidzibasManager : MonoBehaviour
{
    public TextMeshProUGUI sarakstaTeksts;
    public Image telaBilde;
    public Sprite raudBilde;
    public Sprite smaidigaBilde;
    public GameObject klientsObjekts;

    public GameObject segaObjekts;
    public GameObject zupaObjekts;
    public GameObject vitaminiObjekts;

    public TMP_InputField vardaLauks;
    public TMP_InputField gadaLauks;

    void Start() {
        MainitTelu(0);
    }

    public void PogaPartika() {
        sarakstaTeksts.text = "Pārtika: Zupa, maize un āboli sagatavoti!";
    }

    public void PogaMedicina() {
        sarakstaTeksts.text = "Medicīna: Termometrs, plāksteri un zāles ir plauktā.";
    }

    public void PogaPsihologs() {
        sarakstaTeksts.text = "Psihologs: Ieteikta atpūta un tēja. Viss būs labi!";
    }

    public void AprekinatVecumu() {
        if (vardaLauks.text != "" && gadaLauks.text != "") {
            string vards = vardaLauks.text;
            int gads = int.Parse(gadaLauks.text);
            int vecums = 2026 - gads; 
            sarakstaTeksts.text = vards + " ir " + vecums + " gadus vecs/a.";
        }
    }

    public void ToggleSega(bool irIeslegts) {
        if(segaObjekts != null) segaObjekts.SetActive(irIeslegts);
    }

    public void ToggleZupa(bool irIeslegts) {
        if(zupaObjekts != null) zupaObjekts.SetActive(irIeslegts);
    }

    public void ToggleVitamini(bool irIeslegts) {
        if(vitaminiObjekts != null) vitaminiObjekts.SetActive(irIeslegts);
    }

    public void MainitTelu(int index) {
        if (index == 0) {
            telaBilde.color = new Color(1, 1, 1, 0);
            sarakstaTeksts.text = "Izvēlies tēlu!";
        } 
        else if (index == 1) {
            telaBilde.sprite = raudBilde;
            telaBilde.color = new Color(1, 1, 1, 1);
            sarakstaTeksts.text = "Klients ir bēdīgs.";
        } 
        else if (index == 2) {
            telaBilde.sprite = smaidigaBilde;
            telaBilde.color = new Color(1, 1, 1, 1);
            sarakstaTeksts.text = "Lieliski! Klients smaidīgs.";
        }
    }

    public void MainitPlatumu(float vertiba) {
        if (klientsObjekts != null)
            klientsObjekts.transform.localScale = new Vector3(vertiba, klientsObjekts.transform.localScale.y, 1f);
    }

    public void MainitGarumu(float vertiba) {
        if (klientsObjekts != null)
            klientsObjekts.transform.localScale = new Vector3(klientsObjekts.transform.localScale.x, vertiba, 1f);
    }

    public void IzietKoridora() {
        SceneManager.LoadScene("SampleScene"); 
    }
}