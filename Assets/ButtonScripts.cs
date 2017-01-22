using UnityEngine;
using System.Collections;

public class ButtonScripts : MonoBehaviour {

	public void LoadLevel()
    {
        Application.LoadLevel(1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Credits() {
    Application.LoadLevel(2);
    }
}
