using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject creditsPainel, quitPainel;
   
    public void PlayBTN()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenCreditsBTN()
    {
        creditsPainel.SetActive(true);
    }
    public void CloseCreditsBTN()
    {
        creditsPainel.SetActive(false);
    }

   public void QuitBTN()
   {
        Application.Quit();
        print("Quitou");
   }

    public void OpenQuitPainelBTN()
    {
        quitPainel.SetActive(true);
    }

    public void CloseQuitPainelBTN()
    {
        quitPainel.SetActive(false);
    }
}