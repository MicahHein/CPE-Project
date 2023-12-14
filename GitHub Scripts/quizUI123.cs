using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class quizUI123 : MonoBehaviour
{

    public GameObject answerPlanes;
    public GameObject correctAnswers;
 
    public GameObject ovrCameraRig;

    public GameObject quizApplePlane;
    public GameObject quizFishPlane;
    public GameObject quizCarrotPlane;

    private VideoPlayer videoPlayer;    // Reference to the VideoPlayer component

    public VideoClip AppleClip;
    public VideoClip FishClip;
    public VideoClip CarrotClip;

    public float oscillationHeight = 0.5f;  // The height of the oscillation
    public float oscillationSpeed = 1.0f;   // The speed of the oscillation

    public float movementDuration = 2.0f;  // The duration of the movement (smoothly moving player)


    public void AppleVideo()
    {
        // Check if the VideoPlayer component is null
        if (videoPlayer == null)
        {
            throw new System.Exception("VideoPlayer component is null.");
        }

        // Enable the videoPlane GameObject
        quizApplePlane.SetActive(true);

        // Set the video clip for this button
        videoPlayer.clip = AppleClip;

        // Play the video 
        videoPlayer.Play();
    }

    public void FishVideo()
    {
        // Check if the VideoPlayer component is null
        if (videoPlayer == null)
        {
            throw new System.Exception("VideoPlayer component is null.");
        }

        // Enable the videoPlane GameObject
        quizFishPlane.SetActive(true);

        // Set the video clip for this button
        videoPlayer.clip = FishClip;

        // Play the video 
        videoPlayer.Play();
    }
    public void CarrotVideo()
    {
        // Check if the VideoPlayer component is null
        if (videoPlayer == null)
        {
            throw new System.Exception("VideoPlayer component is null.");
        }

        // Enable the videoPlane GameObject
        quizCarrotPlane.SetActive(true);

        // Set the video clip for this button
        videoPlayer.clip = CarrotClip;

        // Play the video 
        videoPlayer.Play();
    }

    public void startTrip()
    {
        StartCoroutine(MovePlayerSequence());
        answerPlanes.SetActive(true);
        StartOscillation(answerPlanes);

        AppleVideo();
        FishVideo();
        CarrotVideo();
    }


    public void checkAnswers()
    {
        
        correctAnswers.SetActive(true);

    }

    public void returnToClasssroom()
    {
        SceneManager.LoadScene("cpe project");
    }

    private IEnumerator MovePlayerSequence()
    {
        yield return StartCoroutine(SmoothMovePlayerCoroutine(new Vector3(0.157f, 0f, 1.229f)));
        RotatePlayer(90);

        yield return StartCoroutine(SmoothMovePlayerCoroutine(new Vector3(0.157f, 0f, -0.359f)));
        RotatePlayer(-90);

        yield return StartCoroutine(SmoothMovePlayerCoroutine(new Vector3(-0.606f, 0f, -0.359f)));

        quizApplePlane.SetActive(true);
        quizFishPlane.SetActive(true);
        quizCarrotPlane.SetActive(true);

        StartOscillation(quizApplePlane);
        StartOscillation(quizFishPlane);
        StartOscillation(quizCarrotPlane);
    }

    private IEnumerator SmoothMovePlayerCoroutine(Vector3 targetPosition)
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
    }



    public void RotatePlayer(float degrees)
    {
        if (ovrCameraRig != null)
        {
            // Rotate the OVRCameraRig
            ovrCameraRig.transform.rotation = Quaternion.Euler(0f, degrees, 0f);
        }
        else
        {
            Debug.LogError("OVRCameraRig reference not set in the inspector.");
        }
    }


    // oscillating the planes
    public void StartOscillation(GameObject objectToOscillate)
    {
        StartCoroutine(OscillateObjectCoroutine(objectToOscillate));
    }

    // Coroutine for oscillating the planes
    private IEnumerator OscillateObjectCoroutine(GameObject objectToOscillate)
    {
        Vector3 initialPosition = objectToOscillate.transform.position;

        while (true)
        {
            float oscillationValue = Mathf.Sin(Time.time * oscillationSpeed);
            Vector3 newPosition = initialPosition + Vector3.up * oscillationValue * oscillationHeight;

            objectToOscillate.transform.position = newPosition;

            yield return null;
        }
    }



    public void SmoothMovePlayer(Vector3 targetPosition)
    {
        StartCoroutine(MovePlayerCoroutine(targetPosition));
    }

    // Coroutine for smooth movement
    private IEnumerator MovePlayerCoroutine(Vector3 targetPosition)
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
    }

    public void TeleportPlayer(Vector3 targetPosition, Quaternion targetRotation)
    {
        if (ovrCameraRig != null)
        {
            // Setting the position of the OVRCameraRig
            ovrCameraRig.transform.position = targetPosition;
            ovrCameraRig.transform.rotation = targetRotation;

        }
        else
        {
            Debug.LogError("OVRCameraRig reference not set in the inspector.");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        RotatePlayer(180);
        answerPlanes.SetActive(false);
        correctAnswers.SetActive(false);
        TeleportPlayer(new Vector3(-2.863f, 0f, 1.229f),  Quaternion.Euler(0f, 0f, 0f));

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startTrip();

        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            correctAnswers.SetActive(true);
        }
    }
}
