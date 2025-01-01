// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class CollisionHandler : MonoBehaviour
// {
//     [SerializeField] float loadDelay = 1f;
//     [SerializeField] ParticleSystem crashVFX;
    
//     void OnTriggerEnter(Collider other) 
//     {
//         StartCrashSequence();    
//     }

//     void StartCrashSequence()
//     {
//         crashVFX.Play();
//         GetComponent<MeshRenderer>().enabled = false;
//         GetComponent<PlayerControls>().enabled = false;
//         GetComponent<BoxCollider>().enabled = false;
//         Invoke("ReloadLevel", loadDelay);
//     }

//     void ReloadLevel()
//     {
        
//         int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
//         SceneManager.LoadScene(currentSceneIndex);
//     }

// }



// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class CollisionHandler : MonoBehaviour
// {
//     [SerializeField] float loadDelay = 1f;
//     [SerializeField] ParticleSystem crashVFX;
//     // [SerializeField] ParticleSystem winVFX;
//     [SerializeField] GameObject winUI; // Assign a UI element for the "You Win" screen in the Inspector
//     [SerializeField] AudioClip crashSound;
//     [SerializeField] AudioClip winSound;

//     private AudioSource audioSource;
//     private bool hasCrashed = false;
//     private bool hasWon = false;

//     void Start()
//     {
//         audioSource = GetComponent<AudioSource>();
//     }

//     void OnTriggerEnter(Collider other)
//     {
//         if (other.CompareTag("WinPoint") && !hasWon)
//         {
//             hasWon = true;
//             WinGame();
//         }
//         else if (!hasCrashed && !hasWon)
//         {
//             hasCrashed = true;
//             StartCrashSequence();
//         }
//     }

//     void StartCrashSequence()
//     {
//         crashVFX.Play();
//         audioSource.PlayOneShot(crashSound);
//         DisablePlayerControls();
//         Invoke("PauseGame", loadDelay); // Pause the game after a delay
//     }

//     void WinGame()
//     {
//         // winVFX.Play();
//         audioSource.PlayOneShot(winSound);
//         DisablePlayerControls();
//         if (winUI != null)
//         {
//             winUI.SetActive(true);
            
//         }
//         Debug.Log("You Win!");
//     }

//     void PauseGame()
//     {
//         Time.timeScale = 0; // Pause the game
//         Debug.Log("Game Paused! Press R to Restart.");
//     }

//     void Update()
//     {
//         // Allow manual restart if the game is paused
//         if ((hasCrashed || hasWon) && Input.GetKeyDown(KeyCode.R))
//         {
//             RestartLevel();
//         }
//     }

//     void RestartLevel()
//     {
//         Time.timeScale = 1; // Resume the game time
//         int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
//         SceneManager.LoadScene(currentSceneIndex);
//     }

//     void DisablePlayerControls()
//     {
//         GetComponent<MeshRenderer>().enabled = false;
//         GetComponent<PlayerControls>().enabled = false;
//         GetComponent<BoxCollider>().enabled = false;
//     }
// }




// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class CollisionHandler : MonoBehaviour
// {
//     [SerializeField] float loadDelay = 1f;
//     [SerializeField] ParticleSystem crashVFX;
//     [SerializeField] ParticleSystem winVFX;
//     [SerializeField] GameObject winUI; // Assign a UI element for the "You Win" screen in the Inspector
//     [SerializeField] AudioClip crashSound;
//     [SerializeField] AudioClip winSound;

//     private AudioSource audioSource;
//     private bool hasCrashed = false;
//     private bool hasWon = false;
//     private bool gameStarted = false; // Track if the game has started

//     void Start()
//     {
//         audioSource = GetComponent<AudioSource>();
//     }

//     void OnTriggerEnter(Collider other)
//     {
//         if (!gameStarted)
//             return; // Don't process collisions before the game starts

//         if (other.CompareTag("WinPoint") && !hasWon)
//         {
//             hasWon = true;
//             WinGame();
//         }
//         else if (!hasCrashed && !hasWon)
//         {
//             hasCrashed = true;
//             StartCrashSequence();
//         }
//     }

//     void StartCrashSequence()
//     {
//         crashVFX.Play();
//         audioSource.PlayOneShot(crashSound);
//         DisablePlayerControls();
//         Invoke("PauseGame", loadDelay); // Pause the game after a delay
//     }

//     void WinGame()
//     {
//         winVFX.Play();
//         audioSource.PlayOneShot(winSound);
//         DisablePlayerControls();
//         if (winUI != null)
//         {
//             winUI.SetActive(true); // Display the "You Win" UI
//         }
//         Debug.Log("You Win!");
//     }

//     void PauseGame()
//     {
//         Time.timeScale = 0; // Pause the game
//         Debug.Log("Game Paused! Press R to Restart.");
//     }

//     void Update()
//     {
//         // Allow manual restart if the game is paused
//         if ((hasCrashed || hasWon) && Input.GetKeyDown(KeyCode.R))
//         {
//             RestartLevel();
//         }
//     }

//     void RestartLevel()
//     {
//         Time.timeScale = 1; // Resume the game time
//         int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
//         SceneManager.LoadScene(currentSceneIndex);
//     }

//     void DisablePlayerControls()
//     {
//         GetComponent<MeshRenderer>().enabled = false;
//         GetComponent<PlayerControls>().enabled = false;
//         GetComponent<BoxCollider>().enabled = false;
//     }

//     // Call this function to start the game when the player clicks "Start Game"
//     public void StartGame()
//     {
//         gameStarted = true;
//     }
// }

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;







// public class CollisionHandler : MonoBehaviour
// {
//     [SerializeField] float loadDelay = 1f;
//     [SerializeField] ParticleSystem crashVFX;
//     [SerializeField] ParticleSystem winVFX;
//     [SerializeField] GameObject winUI; // Assign a UI element for the "You Win" screen in the Inspector
//     [SerializeField] AudioClip crashSound;
//     [SerializeField] AudioClip winSound;

//     private AudioSource audioSource;
//     private bool hasCrashed = false;
//     private bool hasWon = false;
//     public bool gameStarted = false; // Keep this private

//     void Start()
//     {
//         audioSource = GetComponent<AudioSource>();
//     }

//     void OnTriggerEnter(Collider other)
//     {
//         if (!gameStarted)
//             return; // Don't process collisions before the game starts

//         if (other.CompareTag("WinPoint") && !hasWon)
//         {
//             hasWon = true;
//             WinGame();
//         }
//         else if (!hasCrashed && !hasWon)
//         {
//             hasCrashed = true;
//             StartCrashSequence();
//         }
//     }

//     void StartCrashSequence()
//     {
//         crashVFX.Play();
//         audioSource.PlayOneShot(crashSound);
//         DisablePlayerControls();
//         Invoke("PauseGame", loadDelay); // Pause the game after a delay
//     }

//     void WinGame()
//     {
//         winVFX.Play();
//         audioSource.PlayOneShot(winSound);
//         DisablePlayerControls();
//         if (winUI != null)
//         {
//             winUI.SetActive(true); // Display the "You Win" UI
//         }
//         Debug.Log("You Win!");
//     }

//     void PauseGame()
//     {
//         Time.timeScale = 0; // Pause the game
//         Debug.Log("Game Paused! Press R to Restart.");
//     }

//     void Update()
//     {
//         // Allow manual restart if the game is paused
//         if ((hasCrashed || hasWon) && Input.GetKeyDown(KeyCode.R))
//         {
//             RestartLevel();
//         }
//     }

//     void RestartLevel()
//     {
//         Time.timeScale = 1; // Resume the game time
//         int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
//         SceneManager.LoadScene(currentSceneIndex);
//     }

//     void DisablePlayerControls()
//     {
//         GetComponent<MeshRenderer>().enabled = false;
//         GetComponent<PlayerControls>().enabled = false;
//         GetComponent<BoxCollider>().enabled = false;
//     }

//     // Public method to start the game
//     public void StartGame()
//     {
//         gameStarted = true;
//     }
// }



// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class CollisionHandler : MonoBehaviour
// {
//     [SerializeField] float loadDelay = 1f;
//     [SerializeField] ParticleSystem crashVFX;
//     private bool hasCrashed = false;

//     void OnTriggerEnter(Collider other) 
//     {
//         if (!hasCrashed)
//         {
//             hasCrashed = true; // Prevent multiple triggers
//             StartCrashSequence();
//         }
//     }

//     void StartCrashSequence()
//     {
//         crashVFX.Play();
//         GetComponent<MeshRenderer>().enabled = false;
//         GetComponent<PlayerControls>().enabled = false;
//         GetComponent<BoxCollider>().enabled = false;

//         // Pause the game instead of auto-reloading
//         Invoke("PauseGame", loadDelay);
//     }

//     void PauseGame()
//     {
//         Time.timeScale = 0; // Pause the game
//         Debug.Log("Game Paused! Press R to Restart.");
//     }

//     void Update()
//     {
//         // Allow the player to manually restart the game
//         if (hasCrashed && Input.GetKeyDown(KeyCode.R))
//         {
//             RestartLevel();
//         }
//     }

//     void RestartLevel()
//     {
//         Time.timeScale = 1; // Resume the game time before restarting
//         int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
//         SceneManager.LoadScene(currentSceneIndex);
//     }
// }



// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class CollisionHandler : MonoBehaviour
// {
//     [SerializeField] float loadDelay = 1f;
//     [SerializeField] ParticleSystem crashVFX;

//     private bool hasCrashed = false;
//     private bool gameStarted = false; // Track if the game has started

//     void Update()
//     {
//         // Start the game only when the player presses "S"
//         if (!gameStarted && Input.GetKeyDown(KeyCode.S))
//         {
//             StartGame();
//         }

//         // Allow restart only after a crash
//         if (hasCrashed && Input.GetKeyDown(KeyCode.R))
//         {
//             RestartLevel();
//         }
//     }

//     void StartGame()
//     {
//         gameStarted = true;
//         Time.timeScale = 1; // Resume game time if it was paused
//         Debug.Log("Game Started! Move the player and avoid crashing.");
//     }

//     void OnTriggerEnter(Collider other)
//     {
//         if (gameStarted && !hasCrashed) // Allow collision only if the game has started
//         {
//             hasCrashed = true; // Prevent multiple triggers
//             StartCrashSequence();
//         }
//     }

//     void StartCrashSequence()
//     {
//         crashVFX.Play();
//         GetComponent<MeshRenderer>().enabled = false;
//         GetComponent<PlayerControls>().enabled = false;
//         GetComponent<BoxCollider>().enabled = false;

//         // Pause the game instead of auto-reloading
//         Invoke("PauseGame", loadDelay);
//     }

//     void PauseGame()
//     {
//         Time.timeScale = 0; // Pause the game
//         Debug.Log("Game Paused! Press R to Restart.");
//     }

//     void RestartLevel()
//     {
//         Time.timeScale = 1; // Resume the game time before restarting
//         int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
//         SceneManager.LoadScene(currentSceneIndex);
//     }
// }





// using System.Collections;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class CollisionHandler : MonoBehaviour
// {
//     [SerializeField] float loadDelay = 1f;
//     [SerializeField] ParticleSystem crashVFX;

//     private bool hasCrashed = false;
//     private bool gameStarted = false; // Check if the game has started

//     void Start()
//     {
//         // Pause the game at the beginning
//         Time.timeScale = 0; 
//         Debug.Log("Press 'S' to Start the Game!");
        
//         // Disable player controls at the start
//         GetComponent<PlayerControls>().enabled = false;
//     }

//     void Update()
//     {
//         // Start the game when 'S' is pressed
//         if (!gameStarted && Input.GetKeyDown(KeyCode.S))
//         {
//             StartGame();
//         }

//         // Restart the level after a crash
//         if (hasCrashed && Input.GetKeyDown(KeyCode.R))
//         {
//             RestartLevel();
//         }
//     }

//     void StartGame()
//     {
//         gameStarted = true;
//         Time.timeScale = 1; // Resume game time
//         GetComponent<PlayerControls>().enabled = true; // Enable player controls
//         Debug.Log("Game Started! Avoid crashing.");
//     }

//     void OnTriggerEnter(Collider other)
//     {
//         if (gameStarted && !hasCrashed) // Only check collision if the game has started
//         {
//             hasCrashed = true;
//             StartCrashSequence();
//         }
//     }

//     void StartCrashSequence()
//     {
//         crashVFX.Play();
//         GetComponent<MeshRenderer>().enabled = false; // Hide the player
//         GetComponent<PlayerControls>().enabled = false; // Disable controls
//         GetComponent<BoxCollider>().enabled = false; // Disable collider

//         Invoke("PauseGame", loadDelay);
//     }

//     void PauseGame()
//     {
//         Time.timeScale = 0; // Pause the game
//         Debug.Log("Game Over! Press 'R' to Restart.");
//     }

//     void RestartLevel()
//     {
//         Time.timeScale = 1; // Resume game time before restarting
//         int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
//         SceneManager.LoadScene(currentSceneIndex);
//     }
// }



using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem crashVFX;

    private bool hasCrashed = false;
    private bool gameStarted = false;

    void Start()
    {
        Time.timeScale = 0; // Game paused at the start
        GetComponent<PlayerControls>().enabled = false; // Disable player controls initially
        Debug.Log("Press 'S' to Start the Game!");
    }

    void Update()
    {
        if (!gameStarted && Input.GetKeyDown(KeyCode.S))
        {
            StartGame();
        }

        if (hasCrashed && Input.GetKeyDown(KeyCode.R))
        {
            RestartLevel();
        }
    }

    void StartGame()
    {
        gameStarted = true;
        Time.timeScale = 1; // Resume the game
        GetComponent<PlayerControls>().enabled = true; // Enable player controls
        Debug.Log("Game Started!");
    }

    void OnTriggerEnter(Collider other)
    {
        // Detect collision with WinPoint
        if (other.gameObject.CompareTag("WinPoint"))
        {
            ActivateFinishCanvas();
        }
        else if (gameStarted && !hasCrashed) // Handle crash
        {
            hasCrashed = true;
            StartCrashSequence();
        }
    }

    void StartCrashSequence()
    {
        crashVFX.Play();
        GetComponent<MeshRenderer>().enabled = false; // Hide the player
        GetComponent<PlayerControls>().enabled = false; // Disable controls
        GetComponent<BoxCollider>().enabled = false; // Disable collider

        Invoke("PauseGame", loadDelay);
    }

    void PauseGame()
    {
        Time.timeScale = 0; // Pause the game
        Debug.Log("Game Over! Press 'R' to Restart.");
    }

    void RestartLevel()
    {
        Time.timeScale = 1; // Resume game time
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    void ActivateFinishCanvas()
    {
        // Find the Canvas with the "Finish" tag
        GameObject finishCanvas = GameObject.FindGameObjectWithTag("finish");
        if (finishCanvas != null)
        {
            finishCanvas.SetActive(true); // Enable the Canvas
            Time.timeScale = 0; // Pause the game
            Debug.Log("You Win! Congratulations!");
        }
        else
        {
            Debug.LogError("No Canvas with tag 'Finish' found in the scene.");
        }
    }
}


// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class CollisionHandler : MonoBehaviour
// {
//     [SerializeField] float loadDelay = 1f;
//     [SerializeField] ParticleSystem crashVFX;

//     private bool hasCrashed = false;
//     private bool gameStarted = false;

//     void Start()
//     {
//         Time.timeScale = 0; // Game paused at the start
//         GetComponent<PlayerControls>().enabled = false; // Disable player controls initially
//         Debug.Log("Press 'S' to Start the Game!");
//     }

//     void Update()
//     {
//         if (!gameStarted && Input.GetKeyDown(KeyCode.S))
//         {
//             StartGame();
//         }

//         if (hasCrashed && Input.GetKeyDown(KeyCode.R))
//         {
//             RestartLevel();
//         }
//     }

//     void StartGame()
//     {
//         gameStarted = true;
//         Time.timeScale = 1; // Resume the game
//         GetComponent<PlayerControls>().enabled = true; // Enable player controls
//         Debug.Log("Game Started!");
//     }

//     void OnTriggerEnter(Collider other)
//     {
//         // Detect collision with WinPoint
//         if (other.gameObject.CompareTag("WinPoint"))
//         {
//             ActivateFinishCanvas(other.gameObject);
//         }
//         else if (gameStarted && !hasCrashed) // Handle crash
//         {
//             hasCrashed = true;
//             StartCrashSequence();
//         }
//     }

//     void StartCrashSequence()
//     {
//         crashVFX.Play();
//         GetComponent<MeshRenderer>().enabled = false; // Hide the player
//         GetComponent<PlayerControls>().enabled = false; // Disable controls
//         GetComponent<BoxCollider>().enabled = false; // Disable collider

//         Invoke("PauseGame", loadDelay);
//     }

//     void PauseGame()
//     {
//         Time.timeScale = 0; // Pause the game
//         Debug.Log("Game Over! Press 'R' to Restart.");
//     }

//     void RestartLevel()
//     {
//         Time.timeScale = 1; // Resume game time
//         int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
//         SceneManager.LoadScene(currentSceneIndex);
//     }

//     void ActivateFinishCanvas(GameObject WinPoint)
//     {
//         // Find the Canvas with tag "Finish" inside the WinPoint object
//         Transform finishCanvas = WinPoint.transform.Find("finish");

//         if (finishCanvas != null)
//         {
//             finishCanvas.gameObject.SetActive(true); // Enable the Canvas
//             Time.timeScale = 0; // Pause the game
//             Debug.Log("You Win! Congratulations!");
//         }
//         else
//         {
//             Debug.LogError("No child Canvas with tag 'Finish' found in the WinPoint object.");
//         }
//     }
// }
