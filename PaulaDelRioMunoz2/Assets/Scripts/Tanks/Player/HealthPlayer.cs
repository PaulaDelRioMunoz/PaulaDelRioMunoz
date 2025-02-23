using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
{
    //Variables
    [Header("Health")]
    //Salud máxima
    [SerializeField]
    private float _maxHealth;
    //Salud actual
    [SerializeField]
    private float _currentHealth;
    //Daño por bala enemiga
    [SerializeField]
    private float _damageEnemyBullet;

    [Header("ProgressBar")]
    [SerializeField]
    private Image _lifeBar;

    [Header("Explosions")]
    [SerializeField]
    private ParticleSystem _bigExplosion;
    [SerializeField]
    private ParticleSystem _smallExplosion;

    [Header("Game Over")]
    [SerializeField]
    private GameManagerTanks _gameManager;

    private void Awake()
    {

        _bigExplosion.Stop();
        _smallExplosion.Stop();
        _currentHealth = _maxHealth;
        _lifeBar.fillAmount = 1.0f;

    }

    private void OnTriggerEnter(Collider infoAccess)
    {

        if (infoAccess.CompareTag("ShellEnemy"))
        {

            _smallExplosion.Play();
            //_currentHealth = _currentHealth - _damageEnemyBullet;
            _currentHealth -= _damageEnemyBullet;
            _lifeBar.fillAmount = _currentHealth/_maxHealth;
            Destroy(infoAccess.gameObject);

            if(_currentHealth <=0.0f)
            {

                _bigExplosion.Play();
                Death();

            }

        }

    }

    private void Death()
    {

        _gameManager.GameOver();
        Destroy(gameObject, 1.0f);

    }

}
