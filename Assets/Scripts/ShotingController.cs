using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotingController : MonoBehaviour
{
    [SerializeField] private float reloadTime = 1f;
    [SerializeField]GameObject Bullet;
    [SerializeField]AudioSource audioShoot;
    private bool _isReloading = false;
    public void Shoot() //method for ui button
    {
        if (!_isReloading)//Cheak Is not reloading now
        {
            audioShoot.Play();
            SpaunBullet();
        }
    }
    private void SpaunBullet()//Spaun bullet and start reload
    {
        Instantiate(Bullet,gameObject.transform.position, Quaternion.identity);
       _isReloading = true;
        Invoke("ReloadComplite", reloadTime);
    }
    private void ReloadComplite()//End reload
    {
        _isReloading = false;
    }
}
