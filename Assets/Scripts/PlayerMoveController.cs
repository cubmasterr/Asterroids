using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMoveController : MonoBehaviour
{
    [SerializeField]private float playerSpeed = 5f,rottatitonSpeed=20f;
    [SerializeField] private float _horizontal , _vertical;
    private void Update()//take input values  for rotation and transform
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical"); 
    }
    private void FixedUpdate()//make rottation and transform by inpyt values
    {
            transform.Translate( _vertical * Vector3.up * playerSpeed * Time.fixedDeltaTime);
            transform.Rotate(_horizontal * Vector3.back * rottatitonSpeed * Time.fixedDeltaTime);
    }
}
