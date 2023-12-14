using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class TopicButton : MonoBehaviour
{
    public GameObject videoPlane;      // Reference to the GameObject with the VideoPlayer component
    private VideoPlayer videoPlayer;    // Reference to the VideoPlayer component

    public VideoClip AlphabetsVideoClip;
    public VideoClip AnimalsVideoClip; // Video clip to play for this button

    public VideoClip NumbersVideoClip; // Video clip to play for this button

    public VideoClip ColoursVideoClip; // Video clip to play for this button

    public VideoClip HobbiesVideoClip; // Video clip to play for this button

    public VideoClip FruitsVideoClip; // Video clip to play for this button

    public VideoClip FoodVideoClip; // Video clip to play for this button

    public VideoClip FamilyVideoClip; // Video clip to play for this button

    public VideoClip DirectionsVideoClip; // Video clip to play for this button

    public VideoClip IntroWordsVideoClip; // Video clip to play for this button
    public VideoClip JobsVideoClip; // Video clip to play for this button
    public VideoClip DaysVideoClip; // Video clip to play for this button



    void Start()
    {
        // Get the VideoPlayer component from the videoPlane GameObject
        videoPlayer = videoPlane.GetComponent<VideoPlayer>();
    }

    void Update()
    {
       
    }

    public void FamilyPlayVideo()
    {
        // Check if the VideoPlayer component is null
        if (videoPlayer == null)
        {
            throw new System.Exception("VideoPlayer component is null.");
        }

        // Enable the videoPlane GameObject
        videoPlane.SetActive(true);

        // Set the video clip for this button
        videoPlayer.clip = FamilyVideoClip;

        // Play the video 
        videoPlayer.Play();
    }

    public void FruitsPlayVideo()
    {
        // Check if the VideoPlayer component is null
        if (videoPlayer == null)
        {
            throw new System.Exception("VideoPlayer component is null.");
        }

        // Enable the videoPlane GameObject
        videoPlane.SetActive(true);

        // Set the video clip for this button
        videoPlayer.clip = FruitsVideoClip;

        // Play the video 
        videoPlayer.Play();
    }
    public void IntroWordsPlayVideo()
    {
        // Check if the VideoPlayer component is null
        if (videoPlayer == null)
        {
            throw new System.Exception("VideoPlayer component is null.");
        }

        // Enable the videoPlane GameObject
        videoPlane.SetActive(true);

        // Set the video clip for this button
        videoPlayer.clip = IntroWordsVideoClip;

        // Play the video 
        videoPlayer.Play();
    }
    public void JobsPlayVideo()
    {
        // Check if the VideoPlayer component is null
        if (videoPlayer == null)
        {
            throw new System.Exception("VideoPlayer component is null.");
        }

        // Enable the videoPlane GameObject
        videoPlane.SetActive(true);

        // Set the video clip for this button
        videoPlayer.clip = JobsVideoClip;

        // Play the video 
        videoPlayer.Play();
    }

    public void HobbiesPlayVideo()
    {
        // Check if the VideoPlayer component is null
        if (videoPlayer == null)
        {
            throw new System.Exception("VideoPlayer component is null.");
        }

        // Enable the videoPlane GameObject
        videoPlane.SetActive(true);

        // Set the video clip for this button
        videoPlayer.clip = HobbiesVideoClip;

        // Play the video 
        videoPlayer.Play();
    }
    public void FoodPlayVideo()
    {
        // Check if the VideoPlayer component is null
        if (videoPlayer == null)
        {
            throw new System.Exception("VideoPlayer component is null.");
        }

        // Enable the videoPlane GameObject
        videoPlane.SetActive(true);

        // Set the video clip for this button
        videoPlayer.clip = FoodVideoClip;

        // Play the video 
        videoPlayer.Play();
    }
    public void DirectionsPlayVideo()
    {
        // Check if the VideoPlayer component is null
        if (videoPlayer == null)
        {
            throw new System.Exception("VideoPlayer component is null.");
        }

        // Enable the videoPlane GameObject
        videoPlane.SetActive(true);

        // Set the video clip for this button
        videoPlayer.clip = DirectionsVideoClip;

        // Play the video 
        videoPlayer.Play();
    }

    public void ColoursPlayVideo()
    {
        // Check if the VideoPlayer component is null
        if (videoPlayer == null)
        {
            throw new System.Exception("VideoPlayer component is null.");
        }

        // Enable the videoPlane GameObject
        videoPlane.SetActive(true);

        // Set the video clip for this button
        videoPlayer.clip = ColoursVideoClip;

        // Play the video 
        videoPlayer.Play();
    }
    public void NumbersPlayVideo()
    {
        // Check if the VideoPlayer component is null
        if (videoPlayer == null)
        {
            throw new System.Exception("VideoPlayer component is null.");
        }

        // Enable the videoPlane GameObject
        videoPlane.SetActive(true);

        // Set the video clip for this button
        videoPlayer.clip = NumbersVideoClip;

        // Play the video 
        videoPlayer.Play();
    }

    public void AlphabetsPlayVideo()
    {
        // Check if the VideoPlayer component is null
        if (videoPlayer == null)
        {
            throw new System.Exception("VideoPlayer component is null.");
        }

        // Enable the videoPlane GameObject
        videoPlane.SetActive(true);

        // Set the video clip for this button
        videoPlayer.clip = AlphabetsVideoClip;

        // Play the video 
        videoPlayer.Play();
    }

    public void AnimalsPlayVideo()
    {
        // Check if the VideoPlayer component is null
        if (videoPlayer == null)
        {
            throw new System.Exception("VideoPlayer component is null.");
        }

        // Enable the videoPlane GameObject
        videoPlane.SetActive(true);

        // Set the video clip for this button
        videoPlayer.clip = AnimalsVideoClip;

        // Play the video 
        videoPlayer.Play();
    }

    public void DaysPlayVideo()
    {
        // Check if the VideoPlayer component is null
        if (videoPlayer == null)
        {
            throw new System.Exception("VideoPlayer component is null.");
        }

        // Enable the videoPlane GameObject
        videoPlane.SetActive(true);

        // Set the video clip for this button
        videoPlayer.clip = DaysVideoClip;

        // Play the video 
        videoPlayer.Play();
    }
}