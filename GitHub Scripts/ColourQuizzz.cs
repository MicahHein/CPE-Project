using OVR.OpenVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;


public class ColorQuizzz : MonoBehaviour
{


    public GameObject ovrCameraRig;
    public GameObject quizPlane;
    private VideoPlayer videoPlayer;    // Reference to the VideoPlayer component

    public GameObject scoreDialog;

    public VideoClip ColorVideoClip;

    public GameObject quizTopicButtons;


    public GameObject ColorChoices;

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


    public GameObject AlphabetChoices;
    public GameObject NumbersChoices;
    public GameObject FoodChoices;
    public GameObject FruitChoices;
    public GameObject IntroChoices;
    public GameObject DaysChoices;
    public GameObject JobsChoices;
    public GameObject AnimalsChoices;
    public GameObject DirectionsChoices;
    public GameObject FamilyChoices;
    public GameObject HobbiesChoices;


    public GameObject option1;

    public List<int> correctSequence = new List<int> { 1, 5, 4, 2, 3 }; // correct sequence of buttons


    public List<int> userSequence = new List<int>(); // the user's input sequence

    public int currentIndex = 0; //which order number the user is at currently

    public float movementDuration = 2.0f;  // The duration of the movement (smoothly moving player)


    //public Text scoreText; //to diplay score

    //public int score = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //determining when to show the score dialog
        //if (currentIndex >= 4)
        //{
        //    updateScore();
        //    scoreDialog.SetActive(true);
        //}

        if (Input.GetKeyDown(KeyCode.W))
        {
            //LearnButton();
            ColorQuiz();
        }
    }


    public void ColorQuiz()
    {
        scoreDialog.SetActive(false);
        option1.SetActive(true);

        currentIndex = 0;
        //score = 0; //reset score and currentIndex to 0

        // move the player smoothly in a walking effect to the desk
        SmoothMovePlayer(new Vector3(0f, 0f, 0.2f), 180f);
        RotatePlayer(90f);

        AlphabetChoices.SetActive(false);
        NumbersChoices.SetActive(false);
        ColorChoices.SetActive(true);
        FoodChoices.SetActive(false);
        FruitChoices.SetActive(false);
        IntroChoices.SetActive(false);
        DaysChoices.SetActive(false);
        JobsChoices.SetActive(false);
        AnimalsChoices.SetActive(false);
        DirectionsChoices.SetActive(false);
        FamilyChoices.SetActive(false);
        HobbiesChoices.SetActive(false);

        ColorChoices.SetActive(true); //show the choices

        // Get the VideoPlayer component from the videoPlane GameObject
        videoPlayer = quizPlane.GetComponent<VideoPlayer>();

        ColorVideo(); //play quiz video

        quizTopicButtons.SetActive(false);


        //hide all the feedback texts
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
    }

    public void ColorButtonOne()
    {
        if (currentIndex < 5) //user can only press 5 maximum buttons, else the button will not update 
        {
            userSequence.Add(1); //add the button number the user pressed to the list 

            if (CheckSequence() == true)
            {
                // Correct sequence
                Debug.Log("Correct sequence!");
                correct1.SetActive(true);
            }
            else
            {
                //wrong sequence
                wrong1.SetActive(true);
            }

            currentIndex++;

        }

    }

    public void ColorButtonTwo()
    {
        if (currentIndex < 5)
        {
            userSequence.Add(2);

            if (CheckSequence() == true)
            {
                // Correct sequence
                Debug.Log("Correct sequence!");
                correct2.SetActive(true);
            }
            else
            {
                wrong2.SetActive(true);
            }

            currentIndex++;


        }
    }

    public void ColorButtonThree()
    {
        if (currentIndex < 5)
        {
            userSequence.Add(3);

            if (CheckSequence() == true)
            {
                // Correct sequence
                Debug.Log("Correct sequence!");
                correct3.SetActive(true);
            }
            else
            {
                wrong3.SetActive(true);
            }

            currentIndex++;


        }
    }

    public void ColorButtonFour()
    {
        if (currentIndex < 5)
        {
            userSequence.Add(4);

            if (CheckSequence() == true)
            {
                // Correct sequence
                Debug.Log("Correct sequence!");
                correct4.SetActive(true);
            }
            else
            {
                wrong4.SetActive(true);
            }

            currentIndex++;

        }

    }

    public void ColorButtonFive()
    {
        if (currentIndex < 5)
        {
            userSequence.Add(5);

            if (CheckSequence() == true)
            {
                // Correct sequence
                Debug.Log("Correct sequence!");
                correct5.SetActive(true);
            }
            else
            {
                wrong5.SetActive(true);
            }

            currentIndex++;
        }
    }


    // Check if the user's sequence matches the correct sequence
    public bool CheckSequence()
    {
        //if user presses the right button at the right order
        if (userSequence[currentIndex] == correctSequence[currentIndex])
        {
            //score++; //correct answer
            return true;
        }
        else
        {
            return false; //wrong answer
        }

    }


    public void ReturnToTopic()
    {
        //score = 0;
        currentIndex = 0;

        // Teleport the player back to the initial position
        TeleportPlayer(new Vector3(-2.8f, 0f, -2.2f), Quaternion.Euler(0f, 90f, 0f));
        quizTopicButtons.SetActive(true);

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
        ColorChoices.SetActive(false);
        scoreDialog.SetActive(false);


        // Clear the user sequence
        userSequence.Clear();

    }

    public void ReturnToMainMenu()
    {
        //score = 0;
        currentIndex = 0;
        // Teleport the player back to the initial position
        TeleportPlayer(new Vector3(-6.15f, 0f, -2.3f), Quaternion.Euler(0f, 0f, 0f));

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
        ColorChoices.SetActive(false);
        scoreDialog.SetActive(false);

        // Clear the user sequence
        userSequence.Clear();

    }

    ////shows the dialog after two seconds 
    //public void dialogShow()
    //{
    //    StartCoroutine(dialogShowRoutine());
    //}

    //private IEnumerator dialogShowRoutine()
    //{
    //    Time.timeScale = 1.0f;

    //    // Wait for a short duration (e.g., 2 seconds)
    //    yield return new WaitForSeconds(2.0f);

    //    updateScore();

    //    scoreDialog.SetActive(true);
    //}

    //teleport player to desired position and rotation
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

    //smoothly move the player in a walking manner to desired position
    public void SmoothMovePlayer(Vector3 targetPosition, float targetRotation)
    {
        StartCoroutine(MovePlayerCoroutine(targetPosition, targetRotation));
    }

    // Coroutine for smooth movement
    private IEnumerator MovePlayerCoroutine(Vector3 targetPosition, float targetRotation)
    {
        float elapsedTime = 0f;
        Vector3 startingPosition = ovrCameraRig.transform.position;

        while (elapsedTime < movementDuration)
        {
            // Interpolate between the starting and target positions
            ovrCameraRig.transform.position = Vector3.Lerp(startingPosition, targetPosition, elapsedTime / movementDuration);

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the player is at the exact target position
        ovrCameraRig.transform.position = targetPosition;

        // Rotate the player to the desired degree
        ovrCameraRig.transform.rotation = Quaternion.Euler(0f, targetRotation, 0f);
    }


    //projects video on board
    public void ColorVideo()
    {
        // Check if the VideoPlayer component is null
        if (videoPlayer == null)
        {
            throw new System.Exception("VideoPlayer component is null.");
        }

        // Enable the videoPlane GameObject
        quizPlane.SetActive(true);

        // Set the video clip for this button
        videoPlayer.clip = ColorVideoClip;

        // Play the video 
        videoPlayer.Play();
    }


    //rotate player in specified angle
    public void RotatePlayer(float degrees)
    {
        if (ovrCameraRig != null)
        {
            // Rotate the OVRCameraRig's TrackingSpace
            ovrCameraRig.transform.rotation = Quaternion.Euler(0f, degrees, 0f);
        }
        else
        {
            Debug.LogError("OVRCameraRig reference not set in the inspector.");
        }
    }
}
