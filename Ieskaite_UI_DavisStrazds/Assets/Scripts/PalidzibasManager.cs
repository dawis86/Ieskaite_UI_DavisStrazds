using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class PalidzibasManager : MonoBehaviour
{
    public TextMeshProUGUI sarakstaTeksts; // Vilkt no tavas tāfeles
    private List<string> izveletieVeidi = new List<string>();

    public void PievienotSarakstam(string veids)
    {
        // Pievienojam sarakstam
        izveletieVeidi.Add(veids);
        AtjaunotDispleju();
    }

    void AtjaunotDispleju()
    {
        // Pārbaudām, vai sarakstā kaut kas ir, lai neizmet kļūdu
        if (izveletieVeidi.Count > 0)
        {
            // Paņemam pašu pēdējo pievienoto elementu un aizstājam visu tekstu
            sarakstaTeksts.text = "Izvēlēts: " + izveletieVeidi[izveletieVeidi.Count - 1];
        }
    }
}