using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour {
    [SerializeField] GameObject bullet;
    //[SerializeField] float FireRate = 0.1f;
    [SerializeField] GameObject bulletEmitter;
    
    // Use this for initialization
   // private float timerlastshot = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //timerlastshot = +Time.deltaTime;
       // if (timerlastshot > FireRate)
       // {           
            var fire1 = Input.GetAxis("Fire1");
            if (fire1 > 0)
            {
                Instantiate(bullet, bulletEmitter.transform.position, bulletEmitter.transform.rotation);
              //  timerlastshot = 0;
            }
            
      //  }
	}
}
