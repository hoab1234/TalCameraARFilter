using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{

    private GameObject BackgroundMusic;
    AudioSource backmusic;
    

    void Awake()
    {


        BackgroundMusic = GameObject.FindGameObjectWithTag("Music");
       

        DontDestroyOnLoad(transform.gameObject);
        
        backmusic = GetComponent<AudioSource>(); //배경음악 저장해둠
       
       
    }
    public void BackGroundMusicOffButton() //배경음악 키고 끄는 버튼
    {

        BackgroundMusic = GameObject.Find("BackgroundMusic");
        backmusic = BackgroundMusic.GetComponent<AudioSource>(); //배경음악 저장해둠
        if (backmusic.isPlaying) backmusic.Pause();
        else backmusic.Play();
    }

}
