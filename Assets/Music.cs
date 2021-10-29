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
        
        backmusic = GetComponent<AudioSource>(); //������� �����ص�
       
       
    }
    public void BackGroundMusicOffButton() //������� Ű�� ���� ��ư
    {

        BackgroundMusic = GameObject.Find("BackgroundMusic");
        backmusic = BackgroundMusic.GetComponent<AudioSource>(); //������� �����ص�
        if (backmusic.isPlaying) backmusic.Pause();
        else backmusic.Play();
    }

}
