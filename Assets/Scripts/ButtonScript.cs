using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour
{

    public void OpenMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void OpenLoganScene()
    {
        SceneManager.LoadScene("Wolverine");
    }
    public void OpenJeanScene()
    {
        SceneManager.LoadScene("Phoenix");
    }

    public void OpenScottScene()
    {
        SceneManager.LoadScene("Cyclops");
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
