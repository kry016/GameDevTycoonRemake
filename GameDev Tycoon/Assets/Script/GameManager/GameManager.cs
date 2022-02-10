using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    
    [SerializeField] private Date date;
    [SerializeField] private GameState gameState;
    [SerializeField] private OfficeObJect office;

    private void Awake()
    {
        gameManager = this;
        DontDestroyOnLoad(gameObject);
    }

    public void ChangeOffice()
    {
        foreach (Office office in office.Getoffice)
        {
            bool change = office.OfficeChange(gameState.GetCash, date.GetDateSum());
            
            if (change)
            {
                StartCoroutine(LoadScene(office.GetScene));
                return;
            }
        }
        
    }

    private IEnumerator LoadScene(string scene)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(scene);
        asyncOperation.allowSceneActivation = false;
        while (!asyncOperation.isDone)
        {
            if (asyncOperation.progress >= 0.9f)
            {
                asyncOperation.allowSceneActivation = true;
            }

            yield return null;
        }

    }
}
