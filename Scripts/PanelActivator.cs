using UnityEngine;

public class PanelActivator : MonoBehaviour
{
    public GameObject panelStrukturFungsi; // Panel Struktur Fungsi
    public GameObject panelOrganHidung;   // Panel Organ Hidung
    public GameObject panelHome;          // Panel Home (opsional)

    void Start()
    {
        // Ambil target panel dari PlayerPrefs
        string targetPanel = PlayerPrefs.GetString("TargetPanel", "Home");

        // Matikan semua panel terlebih dahulu
        panelStrukturFungsi.SetActive(false);
        panelOrganHidung.SetActive(false);
        panelHome.SetActive(false);

        // Aktifkan hanya panel yang sesuai
        if (targetPanel == "StrukturFungsi")
        {
            panelStrukturFungsi.SetActive(true);
        }
        else if (targetPanel == "OrganHidung")
        {
            panelOrganHidung.SetActive(true);
        }
        else
        {
            panelHome.SetActive(true); // Default ke Panel Home
        }
    }
}
