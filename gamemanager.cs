public class gamemanager : MonoBehaviour
{
    bool gamehasended = false;

    public void completelevel() {
        completelevelui.SetActive(true);
    }
    public GameObject completelevelui;

    public void endgame()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("game over");
            Invoke("restart", 3f);
            
        }

    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
