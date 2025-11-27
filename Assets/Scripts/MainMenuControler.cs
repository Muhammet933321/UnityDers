using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControler : MonoBehaviour
{
       
    public void PlayBtnCick()
    {
        Debug.Log("PLay Butonunua Basildi");
        SceneManager.LoadScene("Level1Scene");
    }
}
