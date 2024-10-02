using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoTrigger : MonoBehaviour
{

    private int index=0;
    private int i=0;
    public VideoClip[] videoList;
    private VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        experienceManger(0);
        videoPlayer=GetComponent<VideoPlayer>();
        videoPlayer.clip = videoList[0];
    }

    // Update is called once per frame
    void Update()
    { 
        
    }

    public void experienceManger(int change){
        if(index==2 && change==1){
            index=0;
        }
        else if(index==0 && change==-1){
            index=2;
        }
        else
            index+=change;
        for(i=0;i<3;i++){
            videoPlayer.clip=videoList[index];
        }
    }


}
