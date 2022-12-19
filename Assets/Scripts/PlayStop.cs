using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayStop : MonoBehaviour
{
   private VideoPlayer video;

   private void Awake()
   {

video = GetComponent<VideoPlayer>();

   } 

public void PlayVideo()
{

video.Play();
}

public void StopVideo()
{

video.Stop();


}




}
