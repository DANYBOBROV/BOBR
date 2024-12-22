using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    public void SwitchScence(int num)
    {
        SceneManager.LoadScene(num);
    }
}