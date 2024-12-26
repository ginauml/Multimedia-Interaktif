using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public GameObject home;
    public GameObject pengembang;
    public GameObject info;
    public GameObject referensi;
    public GameObject quest;
    public GameObject menu;
    public GameObject materi;
    public GameObject strukturfungsi;
    public GameObject vidio;
    public GameObject organhidung;
    public GameObject organfaring;
    public GameObject organtrakea;
    public GameObject organbronkus;
    public GameObject organparu;
    public GameObject questgangguan;
    public GameObject gangguan;
    public GameObject penyakitbronkitis;
    public GameObject penyakitateros;
    public GameObject penyakitasma;
    public GameObject penyakitkankerparu;
    public GameObject penyakitemfisema;


    // Start is called before the first frame update
    void Start()
    {
        home.SetActive(true);
        pengembang.SetActive(false);
        info.SetActive(false);
        referensi.SetActive(false);
        quest.SetActive(false);
        menu.SetActive(false);
        materi.SetActive(false);
        vidio.SetActive(false);
        strukturfungsi.SetActive(false);
        organhidung.SetActive(false);
        organfaring.SetActive(false);
        organtrakea.SetActive(false);
        organbronkus.SetActive(false);
        organparu.SetActive(false);
        questgangguan.SetActive(false);
        gangguan.SetActive(false);
        penyakitbronkitis.SetActive(false);
        penyakitateros.SetActive(false);
        penyakitasma.SetActive(false);
        penyakitkankerparu.SetActive(false);
        penyakitemfisema.SetActive(false);
    }

    public void btnStartClicked(){
        quest.SetActive(true);
        home.SetActive(false);
    }

    public void pengembangbtnClicked(){
        home.SetActive(false);
        pengembang.SetActive(true);
    }

    public void pengembangnextbtnClicked(){
        pengembang.SetActive(false);
        referensi.SetActive(true);
    }

    public void referensibackbtnClicked(){
        pengembang.SetActive(true);
        referensi.SetActive(false);
    }

    public void referensiquitbtnClicked(){
        home.SetActive(true);
        referensi.SetActive(false);
    }

    public void infobtnClicked(){
        home.SetActive(false);
        info.SetActive(true);
    }

    public void infoquitbtnClicked(){
        home.SetActive(true);
        info.SetActive(false);
    }

    public void questnextbtnClicked(){
        quest.SetActive(false);
        menu.SetActive(true);
    }

    public void questbackbtnClicked(){
        home.SetActive(true);
        quest.SetActive(false);
    }

    public void menubackbtnClicked(){
        quest.SetActive(true);
        menu.SetActive(false);
    }

    public void menubelajarbtnClicked(){
        menu.SetActive(false);
        materi.SetActive(true);
    }

    public void materiquitbtnClicked(){
        menu.SetActive(true);
        materi.SetActive(false);
    }

    public void materistrukturbtnClicked(){
        materi.SetActive(false);
        strukturfungsi.SetActive(true);
    }

    public void materigangguanbtnClicked(){
        materi.SetActive(false);
        questgangguan.SetActive(true);
    }

    public void strukturfungsibackbtnClicked(){
        materi.SetActive(true);
        strukturfungsi.SetActive(false);
    }

    public void strukturfungsinextbtnClicked(){
        vidio.SetActive(true);
        strukturfungsi.SetActive(false);
    }

    public void vidiobackbtnClicked(){
        vidio.SetActive(false);
        strukturfungsi.SetActive(true);
    }

    public void vidionextbtnClicked(){
        vidio.SetActive(false);
        organhidung.SetActive(true);
    }

    public void organhidungbackbtnClicked(){
        vidio.SetActive(true);
        organhidung.SetActive(false);
    }

    public void organhidungmateribtnClicked(){
        materi.SetActive(true);
        organhidung.SetActive(false);
    }

    public void organhidungsesudahbtnClicked(){
        organfaring.SetActive(true);
        organhidung.SetActive(false);
    }

    public void organfaringsebelumbtnClicked(){
        organfaring.SetActive(false);
        organhidung.SetActive(true);
    }

    public void organfaringsesudahbtnClicked(){
        organfaring.SetActive(false);
        organtrakea.SetActive(true);
    }

    public void organfaringmateribtnClicked(){
        organfaring.SetActive(false);
        materi.SetActive(true);
    }

    public void organtrakeasebelumbtnClicked(){
        organfaring.SetActive(true);
        organtrakea.SetActive(false);
    }

    public void organtrakeamateribtnClicked(){
        materi.SetActive(true);
        organtrakea.SetActive(false);
    }

    public void organtrakeasesudahbtnClicked(){
        organtrakea.SetActive(false);
        organbronkus.SetActive(true);
    }

    public void organbronkussebelumbtnClicked(){
        organtrakea.SetActive(true);
        organbronkus.SetActive(false);
    }

    public void organbronkusmateribtnClicked(){
        materi.SetActive(true);
        organbronkus.SetActive(false);
    }

    public void organbronkussesudahbtnClicked(){
        organparu.SetActive(true);
        organbronkus.SetActive(false);
    }

    public void organparusebelumbtnClicked(){
        organparu.SetActive(false);
        organbronkus.SetActive(true);
    }

    public void organparumateribtnClicked(){
        organparu.SetActive(false);
        materi.SetActive(true);
    }

    public void organparunextbtnClicked(){
        organparu.SetActive(false);
        questgangguan.SetActive(true);
    }

    public void questgangguanbackbtnClicked(){
        organparu.SetActive(true);
        questgangguan.SetActive(false);
    }

    public void questgangguanmateribtnClicked(){
        materi.SetActive(true);
        questgangguan.SetActive(false);
    }

    public void questgangguannextbtnClicked(){
        gangguan.SetActive(true);
        questgangguan.SetActive(false);
    }

    public void gangguanbackbtnClicked(){
        gangguan.SetActive(false);
        questgangguan.SetActive(true);
    }

    public void gangguanmateribtnClicked(){
        materi.SetActive(true);
        gangguan.SetActive(false);
    }

    public void gangguannextbtnClicked(){
        gangguan.SetActive(false);
        penyakitbronkitis.SetActive(true);
    }

    public void penyakitbronkitisbackbtnClicked(){
        gangguan.SetActive(true);
        penyakitbronkitis.SetActive(false);
    }

    public void penyakitbronkitismateribtnClicked(){
        materi.SetActive(true);
        penyakitbronkitis.SetActive(false);
    }

    public void penyakitbronkitissesudahbackbtnClicked(){
        penyakitateros.SetActive(true);
        penyakitbronkitis.SetActive(false);
    }

    public void penyakitaterossebelumbackbtnClicked(){
        penyakitateros.SetActive(false);
        penyakitbronkitis.SetActive(true);
    }

    public void penyakitaterosmateribackbtnClicked(){
        penyakitateros.SetActive(false);
        materi.SetActive(true);
    }

    public void penyakitaterossesudahbackbtnClicked(){
        penyakitateros.SetActive(false);
        penyakitasma.SetActive(true);
    }

    public void penyakitasmasebelumbackbtnClicked(){
        penyakitateros.SetActive(true);
        penyakitasma.SetActive(false);
    }

    public void penyakitasmasesudahbackbtnClicked(){
        penyakitasma.SetActive(false);
        penyakitkankerparu.SetActive(true);
    }

    public void penyakitasmamateribackbtnClicked(){
        penyakitasma.SetActive(false);
        materi.SetActive(true);
    }

     public void penyakitkankerparusebelumbackbtnClicked(){
        penyakitasma.SetActive(true);
        penyakitkankerparu.SetActive(false);
    }

     public void penyakitkankerparusesudahbackbtnClicked(){
        penyakitkankerparu.SetActive(false);
        penyakitemfisema.SetActive(true);
    }

     public void penyakitkankerparumateribackbtnClicked(){
        penyakitkankerparu.SetActive(false);
        materi.SetActive(true);
    }

    public void penyakitemfisemasebelumbackbtnClicked(){
        penyakitkankerparu.SetActive(true);
        penyakitemfisema.SetActive(false);
    }

    public void penyakitemfisemamateribackbtnClicked(){
        penyakitemfisema.SetActive(false);
        materi.SetActive(true);
    }

    public void penyakitemfisemamenubackbtnClicked(){
        penyakitemfisema.SetActive(false);
        menu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
