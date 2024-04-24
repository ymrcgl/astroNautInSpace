using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitch : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Eğer oyuncu trigger alanına girerse
        {
            // Bir sonraki sahnenin index'ini al
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            int nextSceneIndex = currentSceneIndex + 1;

            // Eğer bir sonraki sahne index'i mevcutsa, o sahneye geçiş yap
            if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(nextSceneIndex);
            }
            else
            {
                Debug.Log("Bu son sahne, başka bir sahne yok.");
                // İsterseniz burada bir şeyler yapabilirsiniz, örneğin oyunu yeniden başlatabilirsiniz.
            }
        }
       
    }
    public void StartGame()
    {
        // Oyunun başlaması için ilk oyun sahnesinin index'ini kullanıyoruz.
        SceneManager.LoadScene(1); // İlk oyun sahnesinin index'i genellikle 1 olur.
    }
}
