using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class GameUIManager : MonoBehaviour
{

    public GameObject quizChoices;
    public GameObject Buttons;
    public GameObject Dialogue;
    public GameObject topicButtons;
    public GameObject inClassDialogue;
    public GameObject Mirror;
    public GameObject ovrCameraRig;
    public GameObject returnMainMenu;
    public GameObject quizTopicButtons;
    public GameObject quizButton;
    public GameObject dialogInside;

    public GameObject videoContainer;
    public VideoPlayer alphabetVideoPlayer;

    public GameObject correct1;
    public GameObject correct2;
    public GameObject correct3;
    public GameObject correct4;
    public GameObject correct5;

    public GameObject wrong1;
    public GameObject wrong2;
    public GameObject wrong3;
    public GameObject wrong4;
    public GameObject wrong5;


    //stuff from quiz to setactive false
    public GameObject scoreDialog;
    public GameObject AlphabetChoices;
    public GameObject NumbersChoices;
    public GameObject ColorsChoices;
    public GameObject FoodChoices;
    public GameObject FruitChoices;
    public GameObject IntroChoices;
    public GameObject DaysChoices;
    public GameObject JobsChoices;
    public GameObject AnimalsChoices;
    public GameObject DirectionsChoices;
    public GameObject FamilyChoices;
    public GameObject HobbiesChoices;
    public GameObject quizStuff;


    // Start is called before the first frame update
    void Start()
    {
        Buttons.SetActive(true);
        Dialogue.SetActive(true);
        topicButtons.SetActive(false);
        inClassDialogue.SetActive(false);
        Mirror.SetActive(false);
        dialogInside.SetActive(false);

        correct1.SetActive(false);
        correct2.SetActive(false);
        correct3.SetActive(false);
        correct4.SetActive(false);
        correct5.SetActive(false);
        wrong1.SetActive(false); 
        wrong2.SetActive(false); 
        wrong3.SetActive(false);
        wrong4.SetActive(false);
        wrong5.SetActive(false);


        if (ovrCameraRig != null)
        {
            ovrCameraRig.transform.position = new Vector3(-7f, 0f, -2.3f);
            RotatePlayer(90f);

        }
        else
        {
            Debug.LogError("OVRCameraRig reference not set in the inspector.");
        }

    }

    public void LearnButton()
    {
        scoreDialog.SetActive(false);
        quizStuff.SetActive(false);

        Debug.Log("Boo");

        // Teleport the player
        TeleportPlayer(new Vector3(0f, 0f, 0.2f), Quaternion.Euler(0f, 90f, 0f));
        RotatePlayer(90f);

        // Activate relevant objects
        inClassDialogue.SetActive(true);
        topicButtons.SetActive(true);
        Mirror.SetActive(true);
        dialogInside.SetActive(true);
        
    }

    public void quizButtonClick()
    {
        returnMainMenu.SetActive(false);

        quizStuff.SetActive(true);

        TeleportPlayer(new Vector3(-2.8f, 0f, -2.2f), Quaternion.Euler(0f, 90f, 0f));

        quizTopicButtons.SetActive(true);

        scoreDialog.SetActive(false);

        topicButtons.SetActive(false);
}

    //takes player to the trip scene
    public void tripButton()
    {
        SceneManager.LoadScene("quizasset");
    }

    //teleporting player to desired position with desired rotation
    public void TeleportPlayer(Vector3 targetPosition, Quaternion targetRotation)
    {
        if (ovrCameraRig != null)
        {
            // Set the position of the OVRCameraRig
            ovrCameraRig.transform.position = targetPosition;
            ovrCameraRig.transform.rotation = targetRotation;

        }
        else
        {
            Debug.LogError("OVRCameraRig reference not set in the inspector.");
        }
    }

    public void RotatePlayer(float degrees)
    {
        if (ovrCameraRig != null)
        {

            ovrCameraRig.transform.rotation = Quaternion.Euler(0f, degrees, 0f);
        }
        else
        {
            Debug.LogError("OVRCameraRig reference not set in the inspector.");
        }
    }

    public void ReturnToMainMenu()
    {
        // Teleport the player back to the initial position
        TeleportPlayer(new Vector3(-6.15f, 0f, -2.3f), Quaternion.Euler(0f, 0f, 0f));

        // Deactivate objects 
        inClassDialogue.SetActive(false);
        topicButtons.SetActive(false);
        Mirror.SetActive(false);
        dialogInside.SetActive(false);
        returnMainMenu.SetActive(false);

        scoreDialog.SetActive(false);
    }



    public void alphabetVideo()
    {

        videoContainer.SetActive(true);
        VideoPlayer alphabetVideoPlayer = videoContainer.GetComponentInChildren<VideoPlayer>();

        // Enable the VideoPlayer component
        alphabetVideoPlayer.enabled = true;

      

        // Play the video
        alphabetVideoPlayer.Play();

    }

        // Update is called once per frame
        void Update()
        {

        //for debugging purposes
            if (Input.GetKeyDown(KeyCode.Space))
            {
            //LearnButton();
            quizButtonClick();

            }

        if (Input.GetKeyDown(KeyCode.R)) 
            {
                ReturnToMainMenu();
            }

        }
    }