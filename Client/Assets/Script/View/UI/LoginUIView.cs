using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginUIView : MonoBehaviour
{
    #region Fields
    [SerializeField]
    protected Button LoginButton;
    [SerializeField]
    protected Button QuitButton;
    #endregion

    void OnEnable()
    {
        LoginButton.onClick.AddListener(OnLoginButtonClick);
        QuitButton.onClick.AddListener(OnQuitButtonClick);
    }

    // Update is called once per frame
    void OnDisable()
    {
        LoginButton.onClick.RemoveListener(OnLoginButtonClick);
        QuitButton.onClick.RemoveListener(OnQuitButtonClick);
    }

    protected void OnLoginButtonClick()
    {
        SceneManager.LoadScene("GameScene");
    }

    protected void OnQuitButtonClick()
    {
        Debug.Log("Quit");
    }
}
