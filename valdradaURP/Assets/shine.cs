using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shine : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource music;
    bool isActive = false;
    void OnTriggerEnter(Collider other){
        Debug.Log("hit");
        if(other.gameObject.tag ==  "transition" && isActive == false ){
            Debug.Log("other.gameObject.tag");
            music.Play();
            Invoke("endMusic",427);
            
        }

    }
    private void endMusic(){
        isActive = true;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
