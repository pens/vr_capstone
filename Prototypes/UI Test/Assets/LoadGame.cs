using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadGame : MonoBehaviour {

	public void Load()
    {
        SceneManager.LoadScene(1);
    }
}
