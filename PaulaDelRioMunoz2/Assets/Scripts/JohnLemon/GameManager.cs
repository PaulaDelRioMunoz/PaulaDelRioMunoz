using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Variables
    [Header("Images")]
    [SerializeField]
    private Image _caughtImage;
    [SerializeField]
    private Image _wonImage;

    //Duración del "fade"
    [Header("Fade")]
    [SerializeField]
    private float _fadeDuration;
    //Tiempo de imágen en pantalla
    [SerializeField]
    private float _displayImageDuration;
    //Contador de tiempo
    private float _timer;

    //Indicador de llegada a salida
    public bool IsPlayerAtExit;
    //Indicador de ser atrapado
    public bool IsPlayerCaught;
    //Resetear nivel
    private bool _isResetartLevel;

    [Header("Audio")]
    [SerializeField]
    private AudioClip _caughtClip;
    [SerializeField]
    private AudioClip _wonClip;
    private AudioSource _audioSource;
    
    [Header("Retry")]
    [SerializeField]
    private GameObject _panelRetry;

    private void Awake()
    {

        _audioSource = GetComponent<AudioSource>();

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (IsPlayerAtExit)
        {

            Won();

        }
        else if (IsPlayerCaught)
        {

            Caught();

        }

    }

    private void Won()
    {

        _audioSource.clip = _wonClip;
        if(_audioSource.isPlaying == false)
        {

            _audioSource.Play();

        }

        _timer = _timer + Time.deltaTime; //_timer += Time.deltaTime;
        
        //Aumentar el canal alfa de la imágen
        _wonImage.color = new Color(_wonImage.color.r, _wonImage.color.g, _wonImage.color.b, _timer / _fadeDuration);

        //Duración de la imágen
        if(_timer > _fadeDuration + _displayImageDuration)
        {

            Debug.Log("¡Has ganado!");

        }

        //Llamamos a retry
        Retry();

    }

    private void Caught()
    {

        _audioSource.clip = _caughtClip;
        if(_audioSource.isPlaying == false)
        {

            _audioSource.Play();

        }

        _timer = _timer + Time.deltaTime; //_timer += Time.deltaTime;
        
        //Aumentar el canal alfa de la imágen
        _caughtImage.color = new Color(_caughtImage.color.r, _caughtImage.color.g, _caughtImage.color.b, _timer / _fadeDuration);

        //Duración de la imágen
        if(_timer > _fadeDuration + _displayImageDuration)
        {

            Debug.Log("¡Has perdido!");
            SceneManager.LoadScene("UD03");//Nombre o número de la escena
            
        }

    }

    //Aparezca el cartel de Win al pasar la puerta
    private void OnTriggerEnter(Collider infoAccess)
    {
        
        if (infoAccess.CompareTag("JohnLemon"))
        {

            IsPlayerAtExit = true;

        }

    }

    public void Retry()
    {

        //Activar el panel Retry
        _panelRetry.SetActive(true);
        
        //Activar el curso
        Cursor.lockState = CursorLockMode.Confined;

    }
    

    //Botón de reinicio
    public void LoadSceneLevel()
    {

        SceneManager.LoadScene("UD03");

    }

}
