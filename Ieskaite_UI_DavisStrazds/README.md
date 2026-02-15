# 🏥 Ieskaite UI: Sociālās Palīdzības Simulācija
**Autors:** Dāvis Strazds  
**Platforma:** Unity 2D (URP)

---

## 🎯 Projekta vīzija un mērķis
Šī simulācija ir izstrādāta kā interaktīvs rīks sociālajiem darbiniekiem un aprūpētājiem. Projekta mērķis ir vizualizēt un simulēt personalizētu aprūpes procesu, nodrošinot klientam gan fizisku, gan emocionālu atbalstu digitālā vidē.

### 💡 Idejiskā vīzija
* **Empātijas veicināšana:** Caur vizuālām izmaiņām lietotājs redz tūlītēju klienta reakciju uz sniegto palīdzību.
* **Resursu pārvaldība:** Informācijas dēlis simulē palīdzības punktu, kur katra poga reprezentē konkrētu atbalsta virzienu.
* **Personalizācija:** Katrs klients ir unikāls — aprūpes inventāram (sega, vitamīni) jābūt pielāgojamam.
* **Interaktivitāte:** *Drag & Drop* funkcija ļauj lietotājam burtiski "sniegt palīdzīgu roku".

---

## 📋 Progresa Checklist (Ieskaites prasības)

**1. Aina: Koridors** | Vārda/Gada ievade un vecuma aprēķins | ✅<br>
Navigācija starp ainām un spēles iziešana | ✅  <br>
**2. Aina: Istaba** | Dropdown sistēma (tēla stāvokļa maiņa) | ✅<br>
Informācijas dēlis (Pārtika, Med, Psihologs) | ✅<br>
Audio (Fona mūzika un interakciju skaņas) | ✅<br>
**3. Pielāgošana** | Toggle pogas (Aprīkojuma ieslēgšana) | ✅<br>
Slideri (Tēla mērogošana / Scale) | ✅<br>
Drag & Drop (Objektu pārvietošana) | ✅<br>

---

## 🚀 Kā palaist?
1. Atvērt projektu **Unity** vidē.
2. Hierarhijas logā atvērt `Assets/MainScene/SampleScene.unity`.
3. Nospiest **Play**.
4. Ievadīt datus koridorā un izmantot UI elementus istabā.

---

## 💭 Pārdomas par procesu
> **Izaicinājums:** Unity UI sasaiste ar C# skriptiem sākumā šķita piņķerīga, taču, sakārtojot loģiku `Managers.cs` un `PalidzibasManager.cs`, viss nostājās savās vietās.

> **Laika plānošana:** Prioritāte tika piešķirta tīram kodam un kļūdu apstrādei (piemēram, lai nevar ievadīt burtus gada laukā). Paldies par lekcijām — iemācījos ne tikai salikt pogas, bet arī saprast, kas notiek "zem pārsega".
