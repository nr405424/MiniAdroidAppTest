using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManagement : MonoBehaviour
{
    AndroidJavaClass ajc;

    void Start() {
        ajc = new AndroidJavaClass("com.example.myplugin.ButtonHandler");
    }

    public void VibratePhone() {
        ajc.CallStatic("VibratePhone");
    }

    public void ShowToastMessage(string message) {
        ajc.CallStatic("ShowToast", message);
    }

    public void QuitApp() {
        Application.Quit();
    }
}
