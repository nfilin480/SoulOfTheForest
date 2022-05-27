using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.CoreModule;

public class LevelChanger : MonoBehaviour
{
    private Animator anim;
    public int levelToLoad;

    public Vector3 position;
    //public VectorValue playerStorage;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void FadeToLevel(){
        //anim.setTrigger("fade");
        //anim.SetBool("fade_level", true);
        SceneManager.LoadScene(levelToLoad);
    }

    public void OnFadeComplete(){
        //playerStorage.initialValue = position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
