using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerTanks : MonoBehaviour
{
    //Variables
    [Header("Game Over")]
    [SerializeField]
    private GameObject _panelGameOver;
    [SerializeField]
    private EnemyManager _enemyManager;

    public void GameOver()
    {

        //Activamos el panel "Game Over"
        _panelGameOver.SetActive(true);
        //Desactivamos el componente "EnemyManager"
        _enemyManager.enabled = false;
        //Activar cursor
        Cursor.lockState = CursorLockMode.Confined;

    }

    //Método para recargar escena
    public void LoadSceneLevel()
    {

        SceneManager.LoadScene(1);
    }

}
