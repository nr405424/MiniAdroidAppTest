using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManagement : MonoBehaviour
{
    AndroidJavaClass ajc;

    void Start() {
        ajc = new AndroidJavaClass("com.example.myplugin.ButtonHandler");
        SendToAndroid("Hello World");
    }

    public void VibratePhone() {
        ajc.CallStatic("VibratePhone");
    }

    public void ShowToastMessage(string message) {
        ajc.CallStatic("ShowToast", message);
    }

    private void SendToAndroid(string message) {
        ajc.CallStatic("ShowToast", message);
    }

    private void ReceiveFromAndroid(string message) {
        Debug.Log("Received message from toast plugin: " + message);
    }
}
