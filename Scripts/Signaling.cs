using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;
public class Signaling : MonoBehaviour
{
    [SerializeField] private UnityEvent _signaling;
    [SerializeField] private AudioSource _songSignaling;
    private bool _inHouse = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _signaling?.Invoke();

        if (collision.TryGetComponent<Swindler>(out Swindler swindler))
        {
            if (_inHouse)
            {
                _songSignaling.DOFade(1, 5);
                _songSignaling.loop = true;
                _inHouse = false;
            }
            else                    
            {
                _songSignaling.DOFade(0, 5);

                _songSignaling.loop = false;
                _inHouse = true;
            }                      
        }        
    }
}
