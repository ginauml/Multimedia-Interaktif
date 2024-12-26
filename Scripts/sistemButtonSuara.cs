using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sistemButtonSuara : MonoBehaviour
{
    public GameObject btnSuaraOn;
    public GameObject btnSuaraOff;
    // Start is called before the first frame update
    void Start()
    {
        btnSuaraOn.SetActive(true);
        btnSuaraOff.SetActive(false);
    }

    public void Mute(){
        sistemBacksound.instance.SuaraMusik.Pause();
        btnSuaraOff.SetActive(true);
        btnSuaraOn.SetActive(false);
    }

    public void Aktifkan(){
        sistemBacksound.instance.SuaraMusik.UnPause();
        btnSuaraOff.SetActive(false);
        btnSuaraOn.SetActive(true);
    }

    // Update is called once per frame
    // void Update()
    // {
         
    // }
}
