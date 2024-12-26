using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour
{
    public void GoToStrukturFungsi()
    {
        // Simpan target panel yang ingin dituju
        PlayerPrefs.SetString("TargetPanel", "StrukturFungsi");
        PlayerPrefs.Save(); // Simpan perubahan
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void GoToOrganHidung()
    {
        // Simpan target panel yang ingin dituju
        PlayerPrefs.SetString("TargetPanel", "OrganHidung");
        PlayerPrefs.Save(); // Simpan perubahan
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
